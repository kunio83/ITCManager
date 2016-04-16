namespace ITCManager.Core.UI.Forms
{
    partial class frmCargaDatos
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
            this.components = new System.ComponentModel.Container();
            this.mtabCargaDatos = new MetroFramework.Controls.MetroTabControl();
            this.tabSelect = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.cmbTablas = new MetroFramework.Controls.MetroComboBox();
            this.tabFormu = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCarga = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mtabCargaDatos.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabFormu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtabCargaDatos
            // 
            this.mtabCargaDatos.Controls.Add(this.tabSelect);
            this.mtabCargaDatos.Controls.Add(this.tabFormu);
            this.mtabCargaDatos.Controls.Add(this.metroTabPage3);
            this.mtabCargaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtabCargaDatos.Location = new System.Drawing.Point(20, 60);
            this.mtabCargaDatos.Name = "mtabCargaDatos";
            this.mtabCargaDatos.SelectedIndex = 1;
            this.mtabCargaDatos.Size = new System.Drawing.Size(928, 320);
            this.mtabCargaDatos.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtabCargaDatos.TabIndex = 1;
            this.mtabCargaDatos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtabCargaDatos.TabIndexChanged += new System.EventHandler(this.mtabCargaDatos_TabIndexChanged);
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.metroLabel1);
            this.tabSelect.Controls.Add(this.btnAceptar);
            this.tabSelect.Controls.Add(this.cmbTablas);
            this.tabSelect.HorizontalScrollbarBarColor = true;
            this.tabSelect.Location = new System.Drawing.Point(4, 35);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Size = new System.Drawing.Size(920, 281);
            this.tabSelect.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabSelect.TabIndex = 0;
            this.tabSelect.Text = "Tabla";
            this.tabSelect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSelect.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(101, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tabla:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(101, 159);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 48);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbTablas
            // 
            this.cmbTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTablas.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.ItemHeight = 29;
            this.cmbTablas.Location = new System.Drawing.Point(101, 101);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(325, 35);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabFormu
            // 
            this.tabFormu.AutoScroll = true;
            this.tabFormu.Controls.Add(this.tableLayoutPanel1);
            this.tabFormu.HorizontalScrollbar = true;
            this.tabFormu.HorizontalScrollbarBarColor = true;
            this.tabFormu.Location = new System.Drawing.Point(4, 35);
            this.tabFormu.Name = "tabFormu";
            this.tabFormu.Size = new System.Drawing.Size(920, 281);
            this.tabFormu.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabFormu.TabIndex = 1;
            this.tabFormu.Text = "Formulario";
            this.tabFormu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFormu.VerticalScrollbar = true;
            this.tabFormu.VerticalScrollbarBarColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCarga, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 281);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvCarga
            // 
            this.dgvCarga.AllowUserToOrderColumns = true;
            this.dgvCarga.AllowUserToResizeRows = false;
            this.dgvCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarga.Location = new System.Drawing.Point(49, 17);
            this.dgvCarga.Name = "dgvCarga";
            this.dgvCarga.Size = new System.Drawing.Size(822, 246);
            this.dgvCarga.TabIndex = 0;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(920, 281);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Grilla";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(ITCManager.Core.Entities.Persona);
            // 
            // chequeBindingSource
            // 
            this.chequeBindingSource.DataSource = typeof(ITCManager.Core.Entities.Cheque);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 442);
            this.Controls.Add(this.mtabCargaDatos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCargaDatos";
            this.Text = "Carga de Datos";
            this.Controls.SetChildIndex(this.mtabCargaDatos, 0);
            this.mtabCargaDatos.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tabSelect.PerformLayout();
            this.tabFormu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtabCargaDatos;
        private MetroFramework.Controls.MetroTabPage tabSelect;
        private MetroFramework.Controls.MetroTabPage tabFormu;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroComboBox cmbTablas;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource chequeBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.Button button1;
    }
}