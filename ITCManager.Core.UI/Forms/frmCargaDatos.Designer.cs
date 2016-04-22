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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDatos));
            this.mtabCargaDatos = new MetroFramework.Controls.MetroTabControl();
            this.tabSelect = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.cmbTablas = new MetroFramework.Controls.MetroComboBox();
            this.tabFormu = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.mtabCargaDatos.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabFormu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.mtabCargaDatos.Size = new System.Drawing.Size(986, 536);
            this.mtabCargaDatos.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtabCargaDatos.TabIndex = 1;
            this.mtabCargaDatos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.metroLabel1);
            this.tabSelect.Controls.Add(this.btnAceptar);
            this.tabSelect.Controls.Add(this.cmbTablas);
            this.tabSelect.HorizontalScrollbarBarColor = true;
            this.tabSelect.Location = new System.Drawing.Point(4, 35);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Size = new System.Drawing.Size(978, 497);
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
            this.tabFormu.Size = new System.Drawing.Size(978, 497);
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
            this.tableLayoutPanel1.Controls.Add(this.dgvDatos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bindingNavigator1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 497);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(51, 42);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(874, 426);
            this.dgvDatos.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(48, 14);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(880, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(978, 497);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Grilla";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlumnoHorarioSetTableAdapter = null;
            this.tableAdapterManager1.ArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager1.AsignacionCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager1.AsignacionReciboSetTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CapacitacionSetTableAdapter = null;
            this.tableAdapterManager1.ChequePropioSetTableAdapter = null;
            this.tableAdapterManager1.ChequeSetTableAdapter = null;
            this.tableAdapterManager1.CiudadActivaLocacionesSetTableAdapter = null;
            this.tableAdapterManager1.CiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager1.CiudadPersonalSetTableAdapter = null;
            this.tableAdapterManager1.CiudadProductosSetTableAdapter = null;
            this.tableAdapterManager1.CiudadSetTableAdapter = null;
            this.tableAdapterManager1.CoeficTarjetasSetTableAdapter = null;
            this.tableAdapterManager1.CompraPagoLocalSetTableAdapter = null;
            this.tableAdapterManager1.CompraSetTableAdapter = null;
            this.tableAdapterManager1.CondicionEmpleadoSetTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CuentaBancoSetTableAdapter = null;
            this.tableAdapterManager1.CuentaBancoTerceroSetTableAdapter = null;
            this.tableAdapterManager1.DepositoSetTableAdapter = null;
            this.tableAdapterManager1.DetalleArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager1.DetalleCompraSetTableAdapter = null;
            this.tableAdapterManager1.DetalleCondicionEmpleadoTableAdapter = null;
            this.tableAdapterManager1.DiaSetTableAdapter = null;
            this.tableAdapterManager1.EstadoAlumnoTableAdapter = null;
            this.tableAdapterManager1.EstadoAsignacionEquipoSetTableAdapter = null;
            this.tableAdapterManager1.EstadoChequeSetTableAdapter = null;
            this.tableAdapterManager1.EstadoCompraSetTableAdapter = null;
            this.tableAdapterManager1.EstadoDepositoSetTableAdapter = null;
            this.tableAdapterManager1.EstadoPagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager1.EstadoRendicionSetTableAdapter = null;
            this.tableAdapterManager1.EstadoTransferenciaSetTableAdapter = null;
            this.tableAdapterManager1.EstadoVentaSetTableAdapter = null;
            this.tableAdapterManager1.FormaPagoLocalSetTableAdapter = null;
            this.tableAdapterManager1.FormaPagoSetTableAdapter = null;
            this.tableAdapterManager1.GastoBaseSetTableAdapter = null;
            this.tableAdapterManager1.GastoChequeSetTableAdapter = null;
            this.tableAdapterManager1.GastoLocalPagoLocalSetTableAdapter = null;
            this.tableAdapterManager1.GastoLocalSetTableAdapter = null;
            this.tableAdapterManager1.HorarioSetTableAdapter = null;
            this.tableAdapterManager1.ItemPagadoSetTableAdapter = null;
            this.tableAdapterManager1.LineaCiudadSetTableAdapter = null;
            this.tableAdapterManager1.LineaSetTableAdapter = null;
            this.tableAdapterManager1.LocacionRolLocadorSetTableAdapter = null;
            this.tableAdapterManager1.LocacionSetTableAdapter = null;
            this.tableAdapterManager1.LocalidadSetTableAdapter = null;
            this.tableAdapterManager1.PagoChequeSetTableAdapter = null;
            this.tableAdapterManager1.PagoLocalChequePropioSetTableAdapter = null;
            this.tableAdapterManager1.PagoLocalChequeSetTableAdapter = null;
            this.tableAdapterManager1.PagoLocalSetTableAdapter = null;
            this.tableAdapterManager1.PagoLocalTarjetaSetTableAdapter = null;
            this.tableAdapterManager1.PagoLocalTransferenciaSetTableAdapter = null;
            this.tableAdapterManager1.PagoSetTableAdapter = null;
            this.tableAdapterManager1.PagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager1.PermisoAccesoTableAdapter = null;
            this.tableAdapterManager1.PermisoTableAdapter = null;
            this.tableAdapterManager1.PersonaTableAdapter = null;
            this.tableAdapterManager1.PlanBaseSetTableAdapter = null;
            this.tableAdapterManager1.PlanVendedorAlumnoSetTableAdapter = null;
            this.tableAdapterManager1.ProductosSetTableAdapter = null;
            this.tableAdapterManager1.ProveedorSetTableAdapter = null;
            this.tableAdapterManager1.ReciboSetTableAdapter = null;
            this.tableAdapterManager1.RendicionDepositoSetTableAdapter = null;
            this.tableAdapterManager1.RendicionGastoSetTableAdapter = null;
            this.tableAdapterManager1.RendicionPagoSetTableAdapter = null;
            this.tableAdapterManager1.RendicionPersonaCiudadSetTableAdapter = null;
            this.tableAdapterManager1.RendicionVentaEquipoSetTableAdapter = null;
            this.tableAdapterManager1.RolAlumnoTableAdapter = null;
            this.tableAdapterManager1.RolCiudadActivaGastosSetTableAdapter = null;
            this.tableAdapterManager1.RolCiudadActivaHorarioSetTableAdapter = null;
            this.tableAdapterManager1.RolCiudadActivaPlanSetTableAdapter = null;
            this.tableAdapterManager1.RolCiudadActivaSetTableAdapter = null;
            this.tableAdapterManager1.RolCiudadEnProcesoSetTableAdapter = null;
            this.tableAdapterManager1.RolDocenteSetTableAdapter = null;
            this.tableAdapterManager1.RolEmpleadoTableAdapter = null;
            this.tableAdapterManager1.RolLocacionAlojamientoSetTableAdapter = null;
            this.tableAdapterManager1.RolLocacionSalonSetTableAdapter = null;
            this.tableAdapterManager1.RolLocadorSetTableAdapter = null;
            this.tableAdapterManager1.RolVendedorTableAdapter = null;
            this.tableAdapterManager1.TarjetaPropiaSetTableAdapter = null;
            this.tableAdapterManager1.TipoChequeSetTableAdapter = null;
            this.tableAdapterManager1.TransferenciaSetTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1026, 658);
            this.Controls.Add(this.mtabCargaDatos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCargaDatos";
            this.Text = "Carga de Datos";
            this.Load += new System.EventHandler(this.frmCargaDatos_Load);
            this.Controls.SetChildIndex(this.mtabCargaDatos, 0);
            this.mtabCargaDatos.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tabSelect.PerformLayout();
            this.tabFormu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtabCargaDatos;
        private MetroFramework.Controls.MetroTabPage tabSelect;
        private MetroFramework.Controls.MetroTabPage tabFormu;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAceptar;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal ITC_DBPOwerDataSet iTC_DBPOwerDataSet;
        internal System.Windows.Forms.DataGridView dgvDatos;
        internal MetroFramework.Controls.MetroComboBox cmbTablas;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ITC_DBPOwerDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}