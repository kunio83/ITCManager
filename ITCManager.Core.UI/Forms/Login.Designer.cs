namespace ITCManager.Core.UI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(120, 61);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(154, 23);
            this.txtUser.TabIndex = 0;
            this.txtUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(120, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(154, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuario";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.InitialImage = null;
            this.pcbLogo.Location = new System.Drawing.Point(261, 5);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(50, 50);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 8;
            this.pcbLogo.TabStop = false;
            // 
            // pcbPass
            // 
            this.pcbPass.BackColor = System.Drawing.Color.Red;
            this.pcbPass.Image = global::ITCManager.Core.UI.Properties.Resources._1460619161_multiply;
            this.pcbPass.Location = new System.Drawing.Point(280, 95);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(31, 23);
            this.pcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPass.TabIndex = 7;
            this.pcbPass.TabStop = false;
            this.pcbPass.Visible = false;
            // 
            // pcbUser
            // 
            this.pcbUser.BackColor = System.Drawing.Color.Red;
            this.pcbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbUser.Image = global::ITCManager.Core.UI.Properties.Resources._1460619161_multiply;
            this.pcbUser.Location = new System.Drawing.Point(280, 61);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(31, 23);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 6;
            this.pcbUser.TabStop = false;
            this.pcbUser.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 237);
            this.ControlBox = false;
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pcbPass);
            this.Controls.Add(this.pcbUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "Login";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Ingreso";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}