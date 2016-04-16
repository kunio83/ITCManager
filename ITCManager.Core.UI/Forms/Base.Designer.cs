namespace ITCManager.Core.UI.Forms
{
    partial class Base
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
            this.bottomBar1 = new ITCManager.Core.UI.Forms.Controles.BottomBar();
            this.SuspendLayout();
            // 
            // bottomBar1
            // 
            this.bottomBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar1.Location = new System.Drawing.Point(20, 457);
            this.bottomBar1.Name = "bottomBar1";
            this.bottomBar1.Size = new System.Drawing.Size(786, 42);
            this.bottomBar1.TabIndex = 0;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 519);
            this.Controls.Add(this.bottomBar1);
            this.Name = "Base";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Base";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Base_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.BottomBar bottomBar1;
    }
}