namespace ITCManager.Core.UI.Forms
{
    partial class FrmEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnvio));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.envioSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proveedorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envioSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRolCiudadActivaTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.rolCiudadActivaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rolCiudadActivaSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.envioSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.EnvioSetTableAdapter();
            this.proveedorSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.ProveedorSetTableAdapter();
            idRolCiudadActivaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.envioSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envioSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).BeginInit();
            this.rolCiudadActivaSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idRolCiudadActivaLabel
            // 
            idRolCiudadActivaLabel.AutoSize = true;
            idRolCiudadActivaLabel.ForeColor = System.Drawing.SystemColors.Control;
            idRolCiudadActivaLabel.Location = new System.Drawing.Point(3, 30);
            idRolCiudadActivaLabel.Name = "idRolCiudadActivaLabel";
            idRolCiudadActivaLabel.Size = new System.Drawing.Size(74, 26);
            idRolCiudadActivaLabel.TabIndex = 3;
            idRolCiudadActivaLabel.Text = "Id Rol Ciudad Activa:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.envioSetDataGridView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.idRolCiudadActivaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(idRolCiudadActivaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rolCiudadActivaSetBindingNavigator, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 349);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // envioSetDataGridView
            // 
            this.envioSetDataGridView.AutoGenerateColumns = false;
            this.envioSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.envioSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.envioSetDataGridView.DataSource = this.envioSetBindingSource;
            this.envioSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.envioSetDataGridView.Location = new System.Drawing.Point(104, 63);
            this.envioSetDataGridView.Name = "envioSetDataGridView";
            this.envioSetDataGridView.Size = new System.Drawing.Size(638, 253);
            this.envioSetDataGridView.TabIndex = 4;
            this.envioSetDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.envioSetDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEnvio";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEnvio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaSolicitudEnvío";
            this.dataGridViewTextBoxColumn2.HeaderText = "FechaSolicitudEnvío";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaSalidaEnvío";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaSalidaEnvío";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaEstimadaRecepción";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaEstimadaRecepción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdProveedor";
            this.dataGridViewTextBoxColumn5.DataSource = this.proveedorSetBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "RazonSocial";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdProveedor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "IdProveedor";
            // 
            // proveedorSetBindingSource
            // 
            this.proveedorSetBindingSource.DataMember = "ProveedorSet";
            this.proveedorSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TipoRetiroEnvio";
            this.dataGridViewTextBoxColumn6.HeaderText = "TipoRetiroEnvio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoEntregaEnvio";
            this.dataGridViewTextBoxColumn7.HeaderText = "TipoEntregaEnvio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CantidadBultos";
            this.dataGridViewTextBoxColumn8.HeaderText = "CantidadBultos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CiudadOrigenEnvio";
            this.dataGridViewTextBoxColumn9.HeaderText = "CiudadOrigenEnvio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CiudadDestinoEnvio";
            this.dataGridViewTextBoxColumn10.HeaderText = "CiudadDestinoEnvio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Remitente";
            this.dataGridViewTextBoxColumn12.HeaderText = "Remitente";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Destinatarios";
            this.dataGridViewTextBoxColumn13.HeaderText = "Destinatarios";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TipoPago";
            this.dataGridViewTextBoxColumn14.HeaderText = "TipoPago";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Monto";
            this.dataGridViewTextBoxColumn15.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "EstadoEnvio";
            this.dataGridViewTextBoxColumn16.HeaderText = "EstadoEnvio";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn17.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // envioSetBindingSource
            // 
            this.envioSetBindingSource.DataMember = "FK_RolCiudadActivaEnvio";
            this.envioSetBindingSource.DataSource = this.rolCiudadActivaSetBindingSource;
            // 
            // rolCiudadActivaSetBindingSource
            // 
            this.rolCiudadActivaSetBindingSource.DataMember = "RolCiudadActivaSet";
            this.rolCiudadActivaSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // idRolCiudadActivaTextBox
            // 
            this.idRolCiudadActivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaSetBindingSource, "IdRolCiudadActiva", true));
            this.idRolCiudadActivaTextBox.Location = new System.Drawing.Point(104, 33);
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
            this.rolCiudadActivaSetBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolCiudadActivaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolCiudadActivaSetBindingNavigatorSaveItem});
            this.rolCiudadActivaSetBindingNavigator.Location = new System.Drawing.Point(101, 0);
            this.rolCiudadActivaSetBindingNavigator.MoveFirstItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveLastItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveNextItem = null;
            this.rolCiudadActivaSetBindingNavigator.MovePreviousItem = null;
            this.rolCiudadActivaSetBindingNavigator.Name = "rolCiudadActivaSetBindingNavigator";
            this.rolCiudadActivaSetBindingNavigator.PositionItem = null;
            this.rolCiudadActivaSetBindingNavigator.Size = new System.Drawing.Size(644, 30);
            this.rolCiudadActivaSetBindingNavigator.TabIndex = 2;
            this.rolCiudadActivaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // rolCiudadActivaSetBindingNavigatorSaveItem
            // 
            this.rolCiudadActivaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolCiudadActivaSetBindingNavigatorSaveItem.Image")));
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Name = "rolCiudadActivaSetBindingNavigatorSaveItem";
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 27);
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
            this.tableAdapterManager.DiaSetTableAdapter = null;
            this.tableAdapterManager.EnvioCiudadEquiposSetTableAdapter = null;
            this.tableAdapterManager.EnvioSetTableAdapter = this.envioSetTableAdapter;
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
            this.tableAdapterManager.HorarioSetTableAdapter = null;
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
            this.tableAdapterManager.RolCiudadActivaHorarioSetTableAdapter = null;
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
            // envioSetTableAdapter
            // 
            this.envioSetTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorSetTableAdapter
            // 
            this.proveedorSetTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEnvio";
            this.Text = "FrmEnvio";
            this.Load += new System.EventHandler(this.FrmEnvio_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.envioSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envioSetBindingSource)).EndInit();
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
        private ITC_DBPOwerDataSetTableAdapters.EnvioSetTableAdapter envioSetTableAdapter;
        private System.Windows.Forms.BindingSource envioSetBindingSource;
        private System.Windows.Forms.DataGridView envioSetDataGridView;
        private System.Windows.Forms.BindingSource proveedorSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.ProveedorSetTableAdapter proveedorSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}