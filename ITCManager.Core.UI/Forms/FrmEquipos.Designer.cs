namespace ITCManager.Core.UI.Forms
{
    partial class FrmEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.rolCiudadActivaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.rolCiudadActivaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.idRolCiudadActivaTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.asignacionCiudadEquiposSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionCiudadEquiposSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.AsignacionCiudadEquiposSetTableAdapter();
            this.asignacionCiudadEquiposSetDataGridView = new System.Windows.Forms.DataGridView();
            this.estadoAsignacionEquipoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoAsignacionEquipoSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.EstadoAsignacionEquipoSetTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            idRolCiudadActivaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).BeginInit();
            this.rolCiudadActivaSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionCiudadEquiposSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionCiudadEquiposSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAsignacionEquipoSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.20588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.79412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rolCiudadActivaSetBindingNavigator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.idRolCiudadActivaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.asignacionCiudadEquiposSetDataGridView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(idRolCiudadActivaLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolCiudadActivaSetBindingSource
            // 
            this.rolCiudadActivaSetBindingSource.DataMember = "RolCiudadActivaSet";
            this.rolCiudadActivaSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // rolCiudadActivaSetTableAdapter
            // 
            this.rolCiudadActivaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoHorarioSetTableAdapter = null;
            this.tableAdapterManager.ArmadoEquipoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionCiudadEquiposSetTableAdapter = this.asignacionCiudadEquiposSetTableAdapter;
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
            this.tableAdapterManager.EnvioSetTableAdapter = null;
            this.tableAdapterManager.EstadoAlumnoTableAdapter = null;
            this.tableAdapterManager.EstadoAsignacionEquipoSetTableAdapter = this.estadoAsignacionEquipoSetTableAdapter;
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
            // rolCiudadActivaSetBindingNavigator
            // 
            this.rolCiudadActivaSetBindingNavigator.AddNewItem = null;
            this.rolCiudadActivaSetBindingNavigator.BindingSource = this.rolCiudadActivaSetBindingSource;
            this.rolCiudadActivaSetBindingNavigator.CountItem = null;
            this.rolCiudadActivaSetBindingNavigator.DeleteItem = null;
            this.rolCiudadActivaSetBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolCiudadActivaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolCiudadActivaSetBindingNavigatorSaveItem});
            this.rolCiudadActivaSetBindingNavigator.Location = new System.Drawing.Point(56, 0);
            this.rolCiudadActivaSetBindingNavigator.MoveFirstItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveLastItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveNextItem = null;
            this.rolCiudadActivaSetBindingNavigator.MovePreviousItem = null;
            this.rolCiudadActivaSetBindingNavigator.Name = "rolCiudadActivaSetBindingNavigator";
            this.rolCiudadActivaSetBindingNavigator.PositionItem = null;
            this.rolCiudadActivaSetBindingNavigator.Size = new System.Drawing.Size(404, 30);
            this.rolCiudadActivaSetBindingNavigator.TabIndex = 2;
            this.rolCiudadActivaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // idRolCiudadActivaLabel
            // 
            idRolCiudadActivaLabel.AutoSize = true;
            idRolCiudadActivaLabel.ForeColor = System.Drawing.SystemColors.Control;
            idRolCiudadActivaLabel.Location = new System.Drawing.Point(3, 30);
            idRolCiudadActivaLabel.Name = "idRolCiudadActivaLabel";
            idRolCiudadActivaLabel.Size = new System.Drawing.Size(43, 30);
            idRolCiudadActivaLabel.TabIndex = 3;
            idRolCiudadActivaLabel.Text = "Id Rol Ciudad Activa:";
            // 
            // idRolCiudadActivaTextBox
            // 
            this.idRolCiudadActivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaSetBindingSource, "IdRolCiudadActiva", true));
            this.idRolCiudadActivaTextBox.Location = new System.Drawing.Point(59, 33);
            this.idRolCiudadActivaTextBox.Name = "idRolCiudadActivaTextBox";
            this.idRolCiudadActivaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idRolCiudadActivaTextBox.TabIndex = 4;
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
            // asignacionCiudadEquiposSetBindingSource
            // 
            this.asignacionCiudadEquiposSetBindingSource.DataMember = "FK_RolCiudadActivaAsignacionCiudadEquipos";
            this.asignacionCiudadEquiposSetBindingSource.DataSource = this.rolCiudadActivaSetBindingSource;
            // 
            // asignacionCiudadEquiposSetTableAdapter
            // 
            this.asignacionCiudadEquiposSetTableAdapter.ClearBeforeFill = true;
            // 
            // asignacionCiudadEquiposSetDataGridView
            // 
            this.asignacionCiudadEquiposSetDataGridView.AutoGenerateColumns = false;
            this.asignacionCiudadEquiposSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignacionCiudadEquiposSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.asignacionCiudadEquiposSetDataGridView.DataSource = this.asignacionCiudadEquiposSetBindingSource;
            this.asignacionCiudadEquiposSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asignacionCiudadEquiposSetDataGridView.Location = new System.Drawing.Point(59, 63);
            this.asignacionCiudadEquiposSetDataGridView.Name = "asignacionCiudadEquiposSetDataGridView";
            this.asignacionCiudadEquiposSetDataGridView.Size = new System.Drawing.Size(398, 286);
            this.asignacionCiudadEquiposSetDataGridView.TabIndex = 0;
            this.asignacionCiudadEquiposSetDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.asignacionCiudadEquiposSetDataGridView_CellMouseClick);
            // 
            // estadoAsignacionEquipoSetBindingSource
            // 
            this.estadoAsignacionEquipoSetBindingSource.DataMember = "EstadoAsignacionEquipoSet";
            this.estadoAsignacionEquipoSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // estadoAsignacionEquipoSetTableAdapter
            // 
            this.estadoAsignacionEquipoSetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAsignacionCiudadEquipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAsignacionCiudadEquipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdEstadoAsignacionEquipo";
            this.dataGridViewTextBoxColumn4.DataSource = this.estadoAsignacionEquipoSetBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "DetalleEstadoASignacionEquipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdEstadoAsignacionEquipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdEstadoAsignacionEquipo";
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEquipos";
            this.Text = "FrmEquipos";
            this.Load += new System.EventHandler(this.FrmEquipos_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).EndInit();
            this.rolCiudadActivaSetBindingNavigator.ResumeLayout(false);
            this.rolCiudadActivaSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionCiudadEquiposSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionCiudadEquiposSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAsignacionEquipoSetBindingSource)).EndInit();
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
        private ITC_DBPOwerDataSetTableAdapters.AsignacionCiudadEquiposSetTableAdapter asignacionCiudadEquiposSetTableAdapter;
        private System.Windows.Forms.BindingSource asignacionCiudadEquiposSetBindingSource;
        private System.Windows.Forms.DataGridView asignacionCiudadEquiposSetDataGridView;
        private ITC_DBPOwerDataSetTableAdapters.EstadoAsignacionEquipoSetTableAdapter estadoAsignacionEquipoSetTableAdapter;
        private System.Windows.Forms.BindingSource estadoAsignacionEquipoSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}