namespace ITCManager.Core.UI.Forms
{
    partial class FrmRolCiudadActivaPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRolCiudadActivaPlan));
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
            this.rolCiudadActivaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.rolCiudadActivaPlanSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaPlanSetTableAdapter();
            this.rolCiudadActivaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.rolCiudadActivaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idRolCiudadActivaTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaPlanSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolCiudadActivaPlanSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetallePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBaseSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDetallePLanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.planBaseSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.PlanBaseSetTableAdapter();
            this.getDetallePLanTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.getDetallePLanTableAdapter();
            idRolCiudadActivaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).BeginInit();
            this.rolCiudadActivaSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBaseSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetallePLanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idRolCiudadActivaLabel
            // 
            idRolCiudadActivaLabel.AutoSize = true;
            idRolCiudadActivaLabel.ForeColor = System.Drawing.SystemColors.Control;
            idRolCiudadActivaLabel.Location = new System.Drawing.Point(18, 13);
            idRolCiudadActivaLabel.Name = "idRolCiudadActivaLabel";
            idRolCiudadActivaLabel.Size = new System.Drawing.Size(107, 13);
            idRolCiudadActivaLabel.TabIndex = 2;
            idRolCiudadActivaLabel.Text = "Id Rol Ciudad Activa:";
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
            this.tableAdapterManager.RolCiudadActivaPlanSetTableAdapter = this.rolCiudadActivaPlanSetTableAdapter;
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
            // rolCiudadActivaPlanSetTableAdapter
            // 
            this.rolCiudadActivaPlanSetTableAdapter.ClearBeforeFill = true;
            // 
            // rolCiudadActivaSetBindingNavigator
            // 
            this.rolCiudadActivaSetBindingNavigator.AddNewItem = null;
            this.rolCiudadActivaSetBindingNavigator.BindingSource = this.rolCiudadActivaSetBindingSource;
            this.rolCiudadActivaSetBindingNavigator.CountItem = null;
            this.rolCiudadActivaSetBindingNavigator.DeleteItem = null;
            this.rolCiudadActivaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.rolCiudadActivaSetBindingNavigatorSaveItem});
            this.rolCiudadActivaSetBindingNavigator.Location = new System.Drawing.Point(10, 30);
            this.rolCiudadActivaSetBindingNavigator.MoveFirstItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveLastItem = null;
            this.rolCiudadActivaSetBindingNavigator.MoveNextItem = null;
            this.rolCiudadActivaSetBindingNavigator.MovePreviousItem = null;
            this.rolCiudadActivaSetBindingNavigator.Name = "rolCiudadActivaSetBindingNavigator";
            this.rolCiudadActivaSetBindingNavigator.PositionItem = null;
            this.rolCiudadActivaSetBindingNavigator.Size = new System.Drawing.Size(799, 25);
            this.rolCiudadActivaSetBindingNavigator.TabIndex = 1;
            this.rolCiudadActivaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // rolCiudadActivaSetBindingNavigatorSaveItem
            // 
            this.rolCiudadActivaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolCiudadActivaSetBindingNavigatorSaveItem.Image")));
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Name = "rolCiudadActivaSetBindingNavigatorSaveItem";
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Text = "Save Data";
            this.rolCiudadActivaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.rolCiudadActivaSetBindingNavigatorSaveItem_Click);
            // 
            // idRolCiudadActivaTextBox
            // 
            this.idRolCiudadActivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaSetBindingSource, "IdRolCiudadActiva", true));
            this.idRolCiudadActivaTextBox.Location = new System.Drawing.Point(131, 13);
            this.idRolCiudadActivaTextBox.Name = "idRolCiudadActivaTextBox";
            this.idRolCiudadActivaTextBox.ReadOnly = true;
            this.idRolCiudadActivaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idRolCiudadActivaTextBox.TabIndex = 3;
            // 
            // rolCiudadActivaPlanSetBindingSource
            // 
            this.rolCiudadActivaPlanSetBindingSource.DataMember = "FK_RolCiudadActivaRolCiudadActivaPlan";
            this.rolCiudadActivaPlanSetBindingSource.DataSource = this.rolCiudadActivaSetBindingSource;
            // 
            // rolCiudadActivaPlanSetDataGridView
            // 
            this.rolCiudadActivaPlanSetDataGridView.AutoGenerateColumns = false;
            this.rolCiudadActivaPlanSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolCiudadActivaPlanSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DetallePlan,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.rolCiudadActivaPlanSetDataGridView.DataSource = this.rolCiudadActivaPlanSetBindingSource;
            this.rolCiudadActivaPlanSetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolCiudadActivaPlanSetDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rolCiudadActivaPlanSetDataGridView.Name = "rolCiudadActivaPlanSetDataGridView";
            this.rolCiudadActivaPlanSetDataGridView.Size = new System.Drawing.Size(799, 283);
            this.rolCiudadActivaPlanSetDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRolCiudadActivaPlan";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdRolCiudadActivaPlan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdRolCiudadActiva";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdPlanBase";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdPlanBase";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DetallePlan
            // 
            this.DetallePlan.HeaderText = "DetallePlan";
            this.DetallePlan.Name = "DetallePlan";
            this.DetallePlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallePlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorMatricula";
            this.dataGridViewTextBoxColumn4.HeaderText = "ValorMatricula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CantCuotas";
            this.dataGridViewTextBoxColumn5.HeaderText = "CantCuotas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorCuota";
            this.dataGridViewTextBoxColumn6.HeaderText = "ValorCuota";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ValorDescuento";
            this.dataGridViewTextBoxColumn7.HeaderText = "ValorDescuento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValorCertificado";
            this.dataGridViewTextBoxColumn8.HeaderText = "ValorCertificado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ComisionIda";
            this.dataGridViewTextBoxColumn9.HeaderText = "ComisionIda";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ComisionVuelta";
            this.dataGridViewTextBoxColumn10.HeaderText = "ComisionVuelta";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ComisionCertificado";
            this.dataGridViewTextBoxColumn11.HeaderText = "ComisionCertificado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // planBaseSetBindingSource
            // 
            this.planBaseSetBindingSource.DataMember = "PlanBaseSet";
            this.planBaseSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // getDetallePLanBindingSource
            // 
            this.getDetallePLanBindingSource.DataMember = "getDetallePLan";
            this.getDetallePLanBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rolCiudadActivaPlanSetDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 283);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idRolCiudadActivaTextBox);
            this.panel2.Controls.Add(idRolCiudadActivaLabel);
            this.panel2.Location = new System.Drawing.Point(10, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 52);
            this.panel2.TabIndex = 6;
            // 
            // planBaseSetTableAdapter
            // 
            this.planBaseSetTableAdapter.ClearBeforeFill = true;
            // 
            // getDetallePLanTableAdapter
            // 
            this.getDetallePLanTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRolCiudadActivaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rolCiudadActivaSetBindingNavigator);
            this.Name = "FrmRolCiudadActivaPlan";
            this.Text = "FrmRolCiudadActivaPlan";
            this.Load += new System.EventHandler(this.FrmRolCiudadActivaPlan_Load);
            this.Controls.SetChildIndex(this.rolCiudadActivaSetBindingNavigator, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaSetBindingNavigator)).EndInit();
            this.rolCiudadActivaSetBindingNavigator.ResumeLayout(false);
            this.rolCiudadActivaSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBaseSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetallePLanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITC_DBPOwerDataSet iTC_DBPOwerDataSet;
        private System.Windows.Forms.BindingSource rolCiudadActivaSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaSetTableAdapter rolCiudadActivaSetTableAdapter;
        private ITC_DBPOwerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolCiudadActivaSetBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton rolCiudadActivaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idRolCiudadActivaTextBox;
        private ITC_DBPOwerDataSetTableAdapters.RolCiudadActivaPlanSetTableAdapter rolCiudadActivaPlanSetTableAdapter;
        private System.Windows.Forms.BindingSource rolCiudadActivaPlanSetBindingSource;
        private System.Windows.Forms.DataGridView rolCiudadActivaPlanSetDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource planBaseSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.PlanBaseSetTableAdapter planBaseSetTableAdapter;
        private System.Windows.Forms.BindingSource getDetallePLanBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.getDetallePLanTableAdapter getDetallePLanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetallePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}