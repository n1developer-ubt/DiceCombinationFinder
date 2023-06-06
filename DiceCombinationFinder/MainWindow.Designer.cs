namespace DiceCombinationFinder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutputSum = new UBTStandardLibrary.UBTTextBox();
            this.txtRolls = new UBTStandardLibrary.UBTTextBox();
            this.txtRemoveCombination = new UBTStandardLibrary.UBTTextBox();
            this.txtFaces = new UBTStandardLibrary.UBTTextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCopiedText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtOutput);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 160);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(800, 230);
            this.panel6.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(4, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(792, 222);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 2);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblCopiedText);
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Controls.Add(this.progress);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 392);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(800, 58);
            this.panel3.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress.Location = new System.Drawing.Point(5, 5);
            this.progress.Margin = new System.Windows.Forms.Padding(5);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(657, 48);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtOutputSum);
            this.panel2.Controls.Add(this.txtRolls);
            this.panel2.Controls.Add(this.txtRemoveCombination);
            this.panel2.Controls.Add(this.txtFaces);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 158);
            this.panel2.TabIndex = 1;
            // 
            // txtOutputSum
            // 
            this.txtOutputSum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtOutputSum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtOutputSum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtOutputSum.BorderThickness = 2;
            this.txtOutputSum.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOutputSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOutputSum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOutputSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtOutputSum.Hint = "Sum 10, 20, 40";
            this.txtOutputSum.Index = -1;
            this.txtOutputSum.isPassword = false;
            this.txtOutputSum.Location = new System.Drawing.Point(0, 114);
            this.txtOutputSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputSum.MaxLength = 32767;
            this.txtOutputSum.Name = "txtOutputSum";
            this.txtOutputSum.Size = new System.Drawing.Size(800, 38);
            this.txtOutputSum.TabIndex = 3;
            this.txtOutputSum.Text = "Sum 10, 20, 40";
            this.txtOutputSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRolls
            // 
            this.txtRolls.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRolls.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRolls.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRolls.BorderThickness = 2;
            this.txtRolls.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRolls.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRolls.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRolls.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRolls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRolls.Hint = "No. Of Rolls E.g 5";
            this.txtRolls.Index = -1;
            this.txtRolls.isPassword = false;
            this.txtRolls.Location = new System.Drawing.Point(0, 76);
            this.txtRolls.Margin = new System.Windows.Forms.Padding(4);
            this.txtRolls.MaxLength = 32767;
            this.txtRolls.Name = "txtRolls";
            this.txtRolls.Size = new System.Drawing.Size(800, 38);
            this.txtRolls.TabIndex = 2;
            this.txtRolls.Text = "No. Of Rolls E.g 5";
            this.txtRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRemoveCombination
            // 
            this.txtRemoveCombination.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRemoveCombination.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRemoveCombination.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRemoveCombination.BorderThickness = 2;
            this.txtRemoveCombination.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemoveCombination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemoveCombination.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemoveCombination.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRemoveCombination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRemoveCombination.Hint = "Remove Combination OOO, EEOOEE";
            this.txtRemoveCombination.Index = -1;
            this.txtRemoveCombination.isPassword = false;
            this.txtRemoveCombination.Location = new System.Drawing.Point(0, 38);
            this.txtRemoveCombination.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemoveCombination.MaxLength = 32767;
            this.txtRemoveCombination.Name = "txtRemoveCombination";
            this.txtRemoveCombination.Size = new System.Drawing.Size(800, 38);
            this.txtRemoveCombination.TabIndex = 1;
            this.txtRemoveCombination.Text = "Remove Combination OOO, EEOOEE";
            this.txtRemoveCombination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFaces
            // 
            this.txtFaces.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFaces.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFaces.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFaces.BorderThickness = 2;
            this.txtFaces.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFaces.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFaces.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFaces.Hint = "Faces 1-30, 34, 40, 44, #19, #20-24";
            this.txtFaces.Index = -1;
            this.txtFaces.isPassword = false;
            this.txtFaces.Location = new System.Drawing.Point(0, 0);
            this.txtFaces.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaces.MaxLength = 32767;
            this.txtFaces.Name = "txtFaces";
            this.txtFaces.Size = new System.Drawing.Size(800, 38);
            this.txtFaces.TabIndex = 0;
            this.txtFaces.Text = "Faces 1-30, 34, 40, 44, #19, #20-24";
            this.txtFaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = false;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = false;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(662, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(133, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Active = false;
            this.btnCopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.BorderRadius = 0;
            this.btnCopy.ButtonText = "Copy";
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DisabledColor = System.Drawing.Color.Gray;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCopy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCopy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCopy.Iconimage")));
            this.btnCopy.Iconimage_right = null;
            this.btnCopy.Iconimage_right_Selected = null;
            this.btnCopy.Iconimage_Selected = null;
            this.btnCopy.IconMarginLeft = 0;
            this.btnCopy.IconMarginRight = 0;
            this.btnCopy.IconRightVisible = false;
            this.btnCopy.IconRightZoom = 0D;
            this.btnCopy.IconVisible = false;
            this.btnCopy.IconZoom = 90D;
            this.btnCopy.IsTab = false;
            this.btnCopy.Location = new System.Drawing.Point(5, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCopy.selected = false;
            this.btnCopy.Size = new System.Drawing.Size(133, 48);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopy.Textcolor = System.Drawing.Color.White;
            this.btnCopy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblCopiedText
            // 
            this.lblCopiedText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCopiedText.AutoSize = true;
            this.lblCopiedText.Location = new System.Drawing.Point(144, 24);
            this.lblCopiedText.Name = "lblCopiedText";
            this.lblCopiedText.Size = new System.Drawing.Size(0, 13);
            this.lblCopiedText.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Combination Finder";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private UBTStandardLibrary.UBTTextBox txtFaces;
        private UBTStandardLibrary.UBTTextBox txtRemoveCombination;
        private UBTStandardLibrary.UBTTextBox txtRolls;
        private UBTStandardLibrary.UBTTextBox txtOutputSum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ProgressBar progress;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnCopy;
        private System.Windows.Forms.Label lblCopiedText;
    }
}

