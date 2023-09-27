namespace DiceCombinationFinder
{
    partial class Visualizer
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
            this.wv = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv)).BeginInit();
            this.SuspendLayout();
            // 
            // wv
            // 
            this.wv.AllowExternalDrop = true;
            this.wv.CreationProperties = null;
            this.wv.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wv.Location = new System.Drawing.Point(0, 0);
            this.wv.Name = "wv";
            this.wv.Size = new System.Drawing.Size(800, 450);
            this.wv.TabIndex = 0;
            this.wv.ZoomFactor = 1D;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wv);
            this.Name = "Visualizer";
            this.Text = "Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.wv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv;
    }
}