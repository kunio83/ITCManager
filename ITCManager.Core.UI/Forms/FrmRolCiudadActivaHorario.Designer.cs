namespace ITCManager.Core.UI.Forms
{
    partial class FrmRolCiudadActivaHorario
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
            System.Windows.Forms.Label idRolCiudadActivaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRolCiudadActivaHorario));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rolCiudadActivaHorarioSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.diaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.IdHorario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.horarioSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaHorarioSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRolCiudadActivaTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.rolCiudadActivaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rolCiudadActivaSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.diaSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.DiaSetTableAdapter();
            this.horarioSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.HorarioSetTableAdapter();
            this.rolCiudadActivaHorarioSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaHorarioSetTableAdapter();
            idRolCiudadActivaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaHorarioSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaHorarioSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).BeginInit();
            this.rolCiudadActivaSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idRolCiudadActivaLabel
            // 
            idRolCiudadActivaLabel.AutoSize = true;
            idRolCiudadActivaLabel.Dock = System.Windows.Forms.DockStyle.Right;
            idRolCiudadActivaLabel.ForeColor = System.Drawing.SystemColors.Control;
            idRolCiudadActivaLabel.Location = new System.Drawing.Point(19, 40);
            idRolCiudadActivaLabel.Name = "idRolCiudadActivaLabel";
            idRolCiudadActivaLabel.Size = new System.Drawing.Size(107, 40);
            idRolCiudadActivaLabel.TabIndex = 3;
            idRolCiudadActivaLabel.Text = "Id Rol Ciudad Activa:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.29846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.70154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.rolCiudadActivaHorarioSetDataGridView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.idRolCiudadActivaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(idRolCiudadActivaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rolCiudadActivaSetBindingNavigator, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 322);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rolCiudadActivaHorarioSetDataGridView
            // 
            this.rolCiudadActivaHorarioSetDataGridView.AutoGenerateColumns = false;
            this.rolCiudadActivaHorarioSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolCiudadActivaHorarioSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.IdDia,
            this.IdHorario});
            this.rolCiudadActivaHorarioSetDataGridView.DataSource = this.rolCiudadActivaHorarioSetBindingSource;
            this.rolCiudadActivaHorarioSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolCiudadActivaHorarioSetDataGridView.Location = new System.Drawing.Point(132, 83);
            this.rolCiudadActivaHorarioSetDataGridView.Name = "rolCiudadActivaHorarioSetDataGridView";
            this.rolCiudadActivaHorarioSetDataGridView.Size = new System.Drawing.Size(445, 246);
            this.rolCiudadActivaHorarioSetDataGridView.TabIndex = 4;
            this.rolCiudadActivaHorarioSetDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rolCiudadActivaHorarioSetDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRolCiudadActivaHorario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdRolCiudadActivaHorario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // IdDia
            // 
            this.IdDia.DataPropertyName = "IdDia";
            this.IdDia.DataSource = this.diaSetBindingSource;
            this.IdDia.DisplayMember = "DetalleDia";
            this.IdDia.HeaderText = "Dia";
            this.IdDia.Name = "IdDia";
            this.IdDia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdDia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdDia.ValueMember = "IdDia";
            // 
            // diaSetBindingSource
            // 
            this.diaSetBindingSource.DataMember = "DiaSet";
            this.diaSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdHorario
            // 
            this.IdHorario.DataPropertyName = "IdHorario";
            this.IdHorario.DataSource = this.horarioSetBindingSource;
            this.IdHorario.DisplayMember = "DetalleHorario";
            this.IdHorario.HeaderText = "Horario";
            this.IdHorario.Name = "IdHorario";
            this.IdHorario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdHorario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdHorario.ValueMember = "IdHorario";
            // 
            // horarioSetBindingSource
            // 
            this.horarioSetBindingSource.DataMember = "HorarioSet";
            this.horarioSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // rolCiudadActivaHorarioSetBindingSource
            // 
            this.rolCiudadActivaHorarioSetBindingSource.DataMember = "FK_RolCiudadActivaRolCiudadActivaHorario";
            this.rolCiudadActivaHorarioSetBindingSource.DataSource = this.rolCiudadActivaSetBindingSource;
            // 
            // rolCiudadActivaSetBindingSource
            // 
            this.rolCiudadActivaSetBindingSource.DataMember = "RolCiudadActivaSet";
            this.rolCiudadActivaSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // idRolCiudadActivaTextBox
            // 
            this.idRolCiudadActivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaSetBindingSource, "IdRolCiudadActiva", true));
            this.idRolCiudadActivaTextBox.Location = new System.Drawing.Point(132, 43);
            this.idRolCiudadActivaTextBox.Name = "idRolCiudadActivaTextBox";
            this.idRolCiudadActivaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idRolCiudadActivaTextBox.TabIndex = 4;
            // 
            // rolCiudadActivaSetBindingNavigator
            // 
            this.rolCiudadActivaSetBindingNavigator.AddNewItem = null;
            this.rolCiudadActivaSetBindingNavigator.BindingSource = this.rolCiudadActivaSetBindingSource;
            this.rolCiudadActivaSetBindingNavigator.CountItem = null;
            this.rolCiudadActivaSetBindingNavigator.DeleteItem = null;
            this.rolCiudadActivaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolCiudadActivaSetBindingNavigatorSaveItem});
            this.rolCiudadActivaSetBindingNavigator.Location = new System.Drawing.Point(129, 0);
            this.rolCiudadActivaSetBindingNavigator.MoveFirstItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveLastItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveNextItem = null;
            this.rolCiudadActivaSetBindingNavigator.MovePreviousItem = null;
            this.rolCiudadActivaSetBindingNavigator.Name = "rolCiudadActivaSetBindingNavigator";
            this.rolCiudadActivaSetBindingNavigator.PositionItem = null;
            this.rolCiudadActivaSetBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.rolCiudadActivaSetBindingNavigator.TabIndex = 2;
            this.rolCiudadActivaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // rolCiudadActivaSetBindingNavigatorSaveItem
            // 
            this.rolCiudadActivaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolCiudadActivaSetBindingNavigatorSaveItem.Image")));
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Name = "rolCiudadActivaSetBindingNavigatorSaveItem";
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.rolCiudadActivaSetBindingNavigatorSaveItem_Click);
            // 
            // rolCiudadActivaSetTableAdapter
            // 
            this.rolCiudadActivaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoHorarioSetTableAdapter = null;
            this.tableAdapterManager.ArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.AsignacionReciboSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaEfectivoSetTableAdapter = null;
            this.tableAdapterManager.CapacitacionSetTableAdapter = null;
            this.tableAdapterManager.ChequePropioSetTableAdapter = null;
            this.tableAdapterManager.ChequeSetTableAdapter = null;
            this.tableAdapterManager.CiudadActivaLocacionesSetTableAdapter = null;
            this.tableAdapterManager.CiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.CiudadFechasHorariosSetTableAdapter = null;
            this.tableAdapterManager.CiudadPersonalSetTableAdapter = null;
            this.tableAdapterManager.CiudadProductosSetTableAdapter = null;
            this.tableAdapterManager.CiudadSetTableAdapter = null;
            this.tableAdapterManager.CoeficTarjetasSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.CondicionEmpleadoSetTableAdapter = null;
            this.tableAdapterManager.CuentaBancoSetTableAdapter = null;
            this.tableAdapterManager.CuentaBancoTerceroSetTableAdapter = null;
            this.tableAdapterManager.DepositoSetTableAdapter = null;
            this.tableAdapterManager.DetalleArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager.DetalleCompraSetTableAdapter = null;
            this.tableAdapterManager.DetalleCondicionEmpleadoTableAdapter = null;
            this.tableAdapterManager.DiaSetTableAdapter = this.diaSetTableAdapter;
            this.tableAdapterManager.EnvioCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.EnvioSetTableAdapter = null;
            this.tableAdapterManager.EstadoAlumnoTableAdapter = null;
            this.tableAdapterManager.EstadoAsignacionEquipoSetTableAdapter = null;
            this.tableAdapterManager.EstadoChequeSetTableAdapter = null;
            this.tableAdapterManager.EstadoCompraSetTableAdapter = null;
            this.tableAdapterManager.EstadoDepositoSetTableAdapter = null;
            this.tableAdapterManager.EstadoPagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager.EstadoRendicionSetTableAdapter = null;
            this.tableAdapterManager.EstadoTransferenciaSetTableAdapter = null;
            this.tableAdapterManager.EstadoVentaSetTableAdapter = null;
            this.tableAdapterManager.FormaPagoLocalSetTableAdapter = null;
            this.tableAdapterManager.FormaPagoSetTableAdapter = null;
            this.tableAdapterManager.GastoBaseSetTableAdapter = null;
            this.tableAdapterManager.GastoChequeSetTableAdapter = null;
            this.tableAdapterManager.GastoLocalSetTableAdapter = null;
            this.tableAdapterManager.HorarioSetTableAdapter = this.horarioSetTableAdapter;
            this.tableAdapterManager.ItemPagadoSetTableAdapter = null;
            this.tableAdapterManager.LocacionRolLocadorSetTableAdapter = null;
            this.tableAdapterManager.LocacionSetTableAdapter = null;
            this.tableAdapterManager.LocalidadSetTableAdapter = null;
            this.tableAdapterManager.MovimientoInternoEfectivoSetTableAdapter = null;
            this.tableAdapterManager.PagoChequeSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalCajaEfectivoSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalChequePropioSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalChequeSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalEnvioSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalSueldoSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalTarjetaSetTableAdapter = null;
            this.tableAdapterManager.PagoLocalTransferenciaSetTableAdapter = null;
            this.tableAdapterManager.PagoSetTableAdapter = null;
            this.tableAdapterManager.PagoTarjetaSetTableAdapter = null;
            this.tableAdapterManager.PermisoAccesoTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.PersonaTableAdapter = null;
            this.tableAdapterManager.PlanBaseSetTableAdapter = null;
            this.tableAdapterManager.PlanVendedorAlumnoSetTableAdapter = null;
            this.tableAdapterManager.ProductosSetTableAdapter = null;
            this.tableAdapterManager.ProveedorSetTableAdapter = null;
            this.tableAdapterManager.PuestoSetTableAdapter = null;
            this.tableAdapterManager.ReciboSetTableAdapter = null;
            this.tableAdapterManager.RendicionDepositoSetTableAdapter = null;
            this.tableAdapterManager.RendicionGastoSetTableAdapter = null;
            this.tableAdapterManager.RendicionPagoSetTableAdapter = null;
            this.tableAdapterManager.RendicionPersonaCiudadSetTableAdapter = null;
            this.tableAdapterManager.RendicionSueldoSetTableAdapter = null;
            this.tableAdapterManager.RendicionValeSetTableAdapter = null;
            this.tableAdapterManager.RendicionVentaEquipoSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoPracticasSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoPresentismoSetTableAdapter = null;
            this.tableAdapterManager.RolAlumnoTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaGastosSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaHorarioSetTableAdapter = this.rolCiudadActivaHorarioSetTableAdapter;
            this.tableAdapterManager.RolCiudadActivaPlanSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaSetTableAdapter = this.rolCiudadActivaSetTableAdapter;
            this.tableAdapterManager.RolCiudadEnProcesoSetTableAdapter = null;
            this.tableAdapterManager.RolDocenteSetTableAdapter = null;
            this.tableAdapterManager.RolEmpleadoTableAdapter = null;
            this.tableAdapterManager.RolLocacionAlojamientoSetTableAdapter = null;
            this.tableAdapterManager.RolLocacionSalonSetTableAdapter = null;
            this.tableAdapterManager.RolLocadorSetTableAdapter = null;
            this.tableAdapterManager.RolVendedorTableAdapter = null;
            this.tableAdapterManager.SueldoPagoSetTableAdapter = null;
            this.tableAdapterManager.TarjetaPropiaSetTableAdapter = null;
            this.tableAdapterManager.TipoChequeSetTableAdapter = null;
            this.tableAdapterManager.TransferenciaSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValeFinanciacionSetTableAdapter = null;
            this.tableAdapterManager.ValeSetTableAdapter = null;
            // 
            // diaSetTableAdapter
            // 
            this.diaSetTableAdapter.ClearBeforeFill = true;
            // 
            // horarioSetTableAdapter
            // 
            this.horarioSetTableAdapter.ClearBeforeFill = true;
            // 
            // rolCiudadActivaHorarioSetTableAdapter
            // 
            this.rolCiudadActivaHorarioSetTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRolCiudadActivaHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmRolCiudadActivaHorario";
            this.Text = "FrmRolCiudadActivaHorario";
            this.Load += new System.EventHandler(this.FrmRolCiudadActivaHorario_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaHorarioSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaHorarioSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).EndInit();
            this.rolCiudadActivaSetBindingNavigator.ResumeLayout(false);
            this.rolCiudadActivaSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ITC_DBPOwerDataSet iTC_DBPOwerDataSet;
        private System.Windows.Forms.BindingSource rolCiudadActivaSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter rolCiudadActivaSetTableAdapter;
        private ITC_DBPOwerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolCiudadActivaSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton rolCiudadActivaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idRolCiudadActivaTextBox;
        private ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaHorarioSetTableAdapter rolCiudadActivaHorarioSetTableAdapter;
        private System.Windows.Forms.BindingSource rolCiudadActivaHorarioSetBindingSource;
        private System.Windows.Forms.DataGridView rolCiudadActivaHorarioSetDataGridView;
        private ITC_DBPOwerDataSetTableAdapters.DiaSetTableAdapter diaSetTableAdapter;
        private System.Windows.Forms.BindingSource diaSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.HorarioSetTableAdapter horarioSetTableAdapter;
        private System.Windows.Forms.BindingSource horarioSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdDia;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdHorario;
    }
}