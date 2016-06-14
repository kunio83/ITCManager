namespace ITCManager.Core.UI.Forms
{
    partial class Principal
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
            this.tabInicio = new MetroFramework.Controls.MetroTabControl();
            this.mtp = new MetroFramework.Controls.MetroTabPage();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.mtiCargarDatos = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tabHerram = new MetroFramework.Controls.MetroTabPage();
            this.tabConfig = new MetroFramework.Controls.MetroTabPage();
            this.tabInicio.SuspendLayout();
            this.mtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.mtp);
            this.tabInicio.Controls.Add(this.tabHerram);
            this.tabInicio.Controls.Add(this.tabConfig);
            this.tabInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInicio.Location = new System.Drawing.Point(10, 30);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.SelectedIndex = 0;
            this.tabInicio.Size = new System.Drawing.Size(807, 409);
            this.tabInicio.TabIndex = 1;
            this.tabInicio.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtp
            // 
            this.mtp.Controls.Add(this.metroTile6);
            this.mtp.Controls.Add(this.metroTile5);
            this.mtp.Controls.Add(this.metroTile4);
            this.mtp.Controls.Add(this.metroTile3);
            this.mtp.Controls.Add(this.mtiCargarDatos);
            this.mtp.Controls.Add(this.metroTile1);
            this.mtp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtp.HorizontalScrollbarBarColor = true;
            this.mtp.Location = new System.Drawing.Point(4, 35);
            this.mtp.Name = "mtp";
            this.mtp.Size = new System.Drawing.Size(799, 370);
            this.mtp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtp.TabIndex = 0;
            this.mtp.Text = "Inicio";
            this.mtp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtp.VerticalScrollbarBarColor = true;
            // 
            // metroTile6
            // 
            this.metroTile6.Location = new System.Drawing.Point(347, 208);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(150, 150);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile6.TabIndex = 7;
            this.metroTile6.Text = "metroTile6";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.UseTileImage = true;
            // 
            // metroTile5
            // 
            this.metroTile5.Location = new System.Drawing.Point(347, 52);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(150, 150);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile5.TabIndex = 6;
            this.metroTile5.Text = "Carga Linea Ciudad";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(191, 208);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(150, 150);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Carga Linea";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(191, 52);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(150, 150);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Carga Personal";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImage = global::ITCManager.Core.UI.Properties.Resources._1463636823_conference;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // mtiCargarDatos
            // 
            this.mtiCargarDatos.Location = new System.Drawing.Point(35, 208);
            this.mtiCargarDatos.Name = "mtiCargarDatos";
            this.mtiCargarDatos.Size = new System.Drawing.Size(150, 150);
            this.mtiCargarDatos.Style = MetroFramework.MetroColorStyle.Red;
            this.mtiCargarDatos.TabIndex = 3;
            this.mtiCargarDatos.Text = "Cargar Datos";
            this.mtiCargarDatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtiCargarDatos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtiCargarDatos.TileImage = global::ITCManager.Core.UI.Properties.Resources._1460763548_database;
            this.mtiCargarDatos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtiCargarDatos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtiCargarDatos.UseTileImage = true;
            this.mtiCargarDatos.Click += new System.EventHandler(this.mtiCargarDatos_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(35, 52);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(150, 150);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Alumnos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileImage = global::ITCManager.Core.UI.Properties.Resources._1460763318_student;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tabHerram
            // 
            this.tabHerram.HorizontalScrollbarBarColor = true;
            this.tabHerram.Location = new System.Drawing.Point(4, 35);
            this.tabHerram.Name = "tabHerram";
            this.tabHerram.Size = new System.Drawing.Size(799, 370);
            this.tabHerram.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabHerram.TabIndex = 1;
            this.tabHerram.Text = "Herramientas";
            this.tabHerram.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabHerram.VerticalScrollbarBarColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.HorizontalScrollbarBarColor = true;
            this.tabConfig.Location = new System.Drawing.Point(4, 35);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(799, 370);
            this.tabConfig.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Configuración";
            this.tabConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabConfig.VerticalScrollbarBarColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 467);
            this.Controls.Add(this.tabInicio);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Controls.SetChildIndex(this.tabInicio, 0);
            this.tabInicio.ResumeLayout(false);
            this.mtp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabInicio;
        private MetroFramework.Controls.MetroTabPage mtp;
        private MetroFramework.Controls.MetroTabPage tabHerram;
        private MetroFramework.Controls.MetroTabPage tabConfig;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile mtiCargarDatos;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}