using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                txtOutput.AppendText("Output\n\n", Color.Red);

                List<Output> sumCombinationList = NumberFunctions.GetFastCombinations(rolls, faces, sums);

                sumCombinationList = RemoveFromCombination(combinationsToRemove, sumCombinationList);
                sumCombinationList.ForEach(x => txtOutput.AppendText(x.Out + "\n", Color.ForestGreen)); 
                txtOutput.ScrollToBottom();
                btnSearch.Enabled = true; 
                progress.Visible= false; 

            });
        }

        private List<Output> RemoveFromCombination(List<string> combsToRemove, List<Output> combs)
        {
            List<Output> newFilteredCombinations = new List<Output>();
            newFilteredCombinations.AddRange(combs);
            foreach (Output comb in combs)
            {
                bool result = false;
                foreach (string combToRemove in combsToRemove)
                {
                    string distinctCharacter = new string(combToRemove.ToCharArray().Distinct().ToArray());

                    if(!distinctCharacter.ToLower().Contains("e") || !distinctCharacter.ToLower().Contains("o"))
                    {
                        continue;
                    }

                    var tc = comb.Filter;

                    List<short> filteredCombination = tc.Split('+')
                        .Select(x => x.Replace("d", "").Replace("D", "").Trim()).Where(IsInt)
                        .Select(x => Convert.ToInt16(x)).ToList();

                    if(filteredCombination.Count != combToRemove.Length)
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
                    if(result)
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
    }
}
