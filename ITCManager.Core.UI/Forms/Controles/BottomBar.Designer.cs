namespace ITCManager.Core.UI.Forms.Controles
{
    partial class BottomBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BottomBar));
            this.lblMsj = new MetroFramework.Controls.MetroLabel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.mpbProgress = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(191, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(195, 19);
            this.lblMsj.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMsj.TabIndex = 3;
            this.lblMsj.Text = "Aqui va algun text de indicacion";
            this.lblMsj.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(646, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(145, 43);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // mpbProgress
            // 
            this.mpbProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpbProgress.Location = new System.Drawing.Point(0, 0);
            this.mpbProgress.Name = "mpbProgress";
            this.mpbProgress.Size = new System.Drawing.Size(145, 43);
            this.mpbProgress.Style = MetroFramework.MetroColorStyle.Blue;
            this.mpbProgress.TabIndex = 2;
            this.mpbProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BottomBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.mpbProgress);
            this.Controls.Add(this.lblMsj);
            this.Name = "BottomBar";
            this.Size = new System.Drawing.Size(791, 43);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMsj;
        private System.Windows.Forms.PictureBox pcbLogo;
        private MetroFramework.Controls.MetroProgressBar mpbProgress;
    }
}
