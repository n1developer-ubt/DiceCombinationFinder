﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DiceCombinationFinder
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing+=delegate(object sender, CancelEventArgs args) { Environment.Exit(Environment.ExitCode); };
            List<string> s= new List<string>();
            CheckForIllegalCrossThreadCalls = false;

            //GetCombinations(5, 8, 18, new List<int>(), ref s);
            //s = Set(s);
            //foreach (string s1 in s)
            //{
            //    MessageBox.Show(s1);
            //}

            progress.MarqueeAnimationSpeed = 10;
            progress.Visible = false;
            btnVisualize.Enabled = false;
            

        }

        private List<string> Set(List<string> s)
        {
            List<string> l = new List<string>();
            for (int x = 0; x < s.Count; x++)
            {
                if (!Contains(ref l, s[x]))
                {
                    l.Add(s[x]);
                }
            }

            return l;
        }

        private bool Contains(ref List<string> sx, string toCheck)
        { 
            var toCompare = toCheck.Split('+');
            toCompare = toCompare.Select(x => x.Trim()).OrderBy(x=>x).ToArray<string>();

            foreach (string s in sx)
            {
                var toCompare2 = s.Split('+');
                toCompare2 = toCompare2.Select(x => x.Trim()).OrderBy(x=>x).ToArray<string>();
                
                if(toCompare2.Length != toCompare.Length)
                    continue;

                bool result = true;
                for (int x = 0; x < toCompare2.Length; x++)
                {
                    if (!toCompare2[x].Equals(toCompare[x]))
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                    return true;
            }

            return false;
        }

        private ExportOutput exportOutput = null;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            var faces = NumberFunctions.Parse(txtFaces.Text);
            var combinationsToRemove = txtRemoveCombination.Text.Trim().Split(',').Select(x => x.Trim()).ToList();
            int rolls = -1;
            List<int> sums;

            //Convert rolls to int
            try
            {
                rolls = Convert.ToInt16(txtRolls.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Number of rolls should be integer!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //from txtSUms to sums
            try
            {
                sums = txtOutputSum.Text.Split(',').Where(IsInt).Select(x => Convert.ToInt32(x.Trim())).ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show("All Sums Should Be Integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region Printer

            lblCopiedText.Text = "";

            txtOutput.AppendText("Faces: ", Color.Red);
            faces.ForEach(x=>txtOutput.AppendText(x+", ", Color.ForestGreen));
            txtOutput.AppendText("\n\n", Color.Red);

            
            txtOutput.AppendText("Combination To Remove: ", Color.Red);
            combinationsToRemove.ForEach(x=>txtOutput.AppendText(x+", ", Color.ForestGreen));
            txtOutput.AppendText("\n\n", Color.Red);

            txtOutput.AppendText("Rolls: ",Color.Red);
            txtOutput.AppendText(rolls.ToString(),Color.ForestGreen);
            txtOutput.AppendText("\n\n", Color.Red);

            txtOutput.AppendText("Sum: ", Color.Red);
            sums.ForEach(x => txtOutput.AppendText(x + ", ", Color.ForestGreen));
            txtOutput.AppendText("\n\n", Color.Red);



            #endregion

            progress.Visible = true;
            Task.Run(() => {
                btnSearch.Enabled = false; 
                txtOutput.ScrollToBottom();

                OutputSumCombinationList = NumberFunctions.GetFastCombinations(rolls, faces, sums);

                OutputSumCombinationList = RemoveFromCombination(combinationsToRemove, OutputSumCombinationList);

                exportOutput = OutputSumCombinationList.Export();
                exportOutput.Rolls = rolls;
                exportOutput.Faces = faces;

                btnVisualize.Enabled = true;

                txtOutput.AppendText("Total Combinations: ", Color.Red);
                txtOutput.AppendText(OutputSumCombinationList.Count +"", Color.ForestGreen);
                txtOutput.AppendText("\n\n", Color.Red);

                txtOutput.AppendText("Output\n\n", Color.Red);

                OutputSumCombinationList.ForEach(x => txtOutput.AppendText(x.Out + "\n", Color.ForestGreen)); 
                txtOutput.ScrollToBottom();
                btnSearch.Enabled = true; 
                progress.Visible= false; 

            });
        }

        

        private List<Output> OutputSumCombinationList = new List<Output>();

        private List<Output> RemoveFromCombination(List<string> combsToRemove, List<Output> combs)
        {
            List<Output> newFilteredCombinations = new List<Output>();
            newFilteredCombinations.AddRange(combs);
            foreach (Output comb in combs)
            {
                bool result = false;
                foreach (string combToRemove in combsToRemove)
                {
                    var tc = comb.Filter;
                    var filteredCombination = comb.Filter;

                    if (filteredCombination.Count != combToRemove.Length)
                    {
                        continue;
                    }
                    
                    result = true;
                    for (int x = 0; x < filteredCombination.Count; x++)
                    {
                        if (filteredCombination[x] % 2 == 0 && char.ToLower(combToRemove[x]) == 'e')
                            continue;
                        
                        if(char.ToLower(combToRemove[x]) == 'o' &&filteredCombination[x] % 2 != 0)
                            continue;

                        result = false;
                        break;
                    }

                    if (string.Join(",", filteredCombination) == "2,4,6,8,10")
                    {
                        Debug.WriteLine("Here: " + result + ", Comb: "+combToRemove);

                    }
                    if (result)
                        break;
                }

                if (result)
                    newFilteredCombinations.Remove(comb);
            }

            return newFilteredCombinations;
        }

        private static bool IsInt(string s)
        {
            try
            {
                Convert.ToInt16(s.Trim());
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var r = string.Join("\n", OutputSumCombinationList.Select(a => a.Out));

            if (!string.IsNullOrEmpty(r))
            { 
                Clipboard.SetText(r);
                lblCopiedText.Text = "Copied!";
            }
            else
            {
                lblCopiedText.Text = "Nothing to copy!";
            }
        }

        private void VisualizeButtonClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                btnVisualize.Enabled = false;
                btnVisualize.Text = "Loading...";

                var viewerPath = Path.Combine(Application.StartupPath, "viewer.zip");
                
                try
                {
                    if (File.Exists(viewerPath)) 
                        File.Delete(viewerPath);  
                    File.WriteAllBytes(viewerPath, Resource.viewer);
                    var viewerDir = Path.Combine(Application.StartupPath, "viewer");

                    if (Directory.Exists(viewerDir))
                    {
                        Directory.Delete(viewerDir, true);
                    }

                    ZipFile.ExtractToDirectory(viewerPath, viewerDir);

                    File.Delete(viewerPath);

                    File.WriteAllText(Path.Combine(viewerDir, "data", "data.json"), JsonConvert.SerializeObject(exportOutput, new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }));

                    Invoke(new MethodInvoker(() =>
                    {
                        btnVisualize.Enabled = true;
                        btnVisualize.Text = "Visualize";
                        var nv = new Visualizer(Path.Combine(viewerDir, "index.html"));
                        nv.WindowState = FormWindowState.Maximized;
                        nv.ShowDialog();
                    }));
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Unable to load viewver, try again latter.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } 
            });
        }
    }
}
