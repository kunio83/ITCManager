namespace ITCManager.Client.UI_Client.Forms
{
    partial class FrmVendedor
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
            System.Windows.Forms.Label idPersonaLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label barrioLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telAlternativoLabel;
            System.Windows.Forms.Label estadoCivilLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label valorMatriculaLabel;
            System.Windows.Forms.Label cantCuotasLabel;
            System.Windows.Forms.Label valorCuotaLabel;
            System.Windows.Forms.Label valorDescuentoLabel;
            System.Windows.Forms.Label valorCertificadoLabel;
            System.Windows.Forms.Label comisionIdaLabel;
            System.Windows.Forms.Label comisionVueltaLabel;
            System.Windows.Forms.Label comisionCertificadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            this.sqliteClientDataBaseDataSet = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.PersonaTableAdapter();
            this.tableAdapterManager = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.TableAdapterManager();
            this.alumnoHorarioSetTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.AlumnoHorarioSetTableAdapter();
            this.planVendedorAlumnoSetTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.PlanVendedorAlumnoSetTableAdapter();
            this.rolAlumnoTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.RolAlumnoTableAdapter();
            this.personaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.barrioTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.telAlternativoTextBox = new System.Windows.Forms.TextBox();
            this.estadoCivilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.rolAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoHorarioSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planVendedorAlumnoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.rolEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolEmpleadoTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.RolEmpleadoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCapacitacion = new System.Windows.Forms.ComboBox();
            this.panPlanEspecial = new System.Windows.Forms.Panel();
            this.valorMatriculaTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaPlanSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantCuotasTextBox = new System.Windows.Forms.TextBox();
            this.valorCuotaTextBox = new System.Windows.Forms.TextBox();
            this.valorDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.valorCertificadoTextBox = new System.Windows.Forms.TextBox();
            this.comisionIdaTextBox = new System.Windows.Forms.TextBox();
            this.comisionVueltaTextBox = new System.Windows.Forms.TextBox();
            this.comisionCertificadoTextBox = new System.Windows.Forms.TextBox();
            this.rolCiudadActivaPlanSetTableAdapter = new ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.RolCiudadActivaPlanSetTableAdapter();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.txtNroRecibo = new System.Windows.Forms.TextBox();
            this.txtObservacionGerente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstadoAlumno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoHorario = new System.Windows.Forms.ComboBox();
            idPersonaLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            barrioLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telAlternativoLabel = new System.Windows.Forms.Label();
            estadoCivilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            valorMatriculaLabel = new System.Windows.Forms.Label();
            cantCuotasLabel = new System.Windows.Forms.Label();
            valorCuotaLabel = new System.Windows.Forms.Label();
            valorDescuentoLabel = new System.Windows.Forms.Label();
            valorCertificadoLabel = new System.Windows.Forms.Label();
            comisionIdaLabel = new System.Windows.Forms.Label();
            comisionVueltaLabel = new System.Windows.Forms.Label();
            comisionCertificadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqliteClientDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).BeginInit();
            this.personaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoHorarioSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planVendedorAlumnoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoBindingSource)).BeginInit();
            this.panPlanEspecial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(9, 57);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel.TabIndex = 1;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(9, 83);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(9, 109);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 5;
            nombresLabel.Text = "Nombres:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new System.Drawing.Point(9, 136);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 7;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(9, 161);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 9;
            dNILabel.Text = "DNI:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(9, 187);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // barrioLabel
            // 
            barrioLabel.AutoSize = true;
            barrioLabel.Location = new System.Drawing.Point(9, 213);
            barrioLabel.Name = "barrioLabel";
            barrioLabel.Size = new System.Drawing.Size(37, 13);
            barrioLabel.TabIndex = 13;
            barrioLabel.Text = "Barrio:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(9, 239);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 15;
            ciudadLabel.Text = "Ciudad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(9, 265);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 17;
            provinciaLabel.Text = "Provincia:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(9, 291);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 19;
            celularLabel.Text = "Celular:";
            // 
            // telAlternativoLabel
            // 
            telAlternativoLabel.AutoSize = true;
            telAlternativoLabel.Location = new System.Drawing.Point(9, 317);
            telAlternativoLabel.Name = "telAlternativoLabel";
            telAlternativoLabel.Size = new System.Drawing.Size(78, 13);
            telAlternativoLabel.TabIndex = 21;
            telAlternativoLabel.Text = "Tel Alternativo:";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.Location = new System.Drawing.Point(9, 343);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(65, 13);
            estadoCivilLabel.TabIndex = 23;
            estadoCivilLabel.Text = "Estado Civil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(9, 369);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 25;
            mailLabel.Text = "Mail:";
            // 
            // valorMatriculaLabel
            // 
            valorMatriculaLabel.AutoSize = true;
            valorMatriculaLabel.Location = new System.Drawing.Point(11, 8);
            valorMatriculaLabel.Name = "valorMatriculaLabel";
            valorMatriculaLabel.Size = new System.Drawing.Size(80, 13);
            valorMatriculaLabel.TabIndex = 6;
            valorMatriculaLabel.Text = "Valor Matricula:";
            // 
            // cantCuotasLabel
            // 
            cantCuotasLabel.AutoSize = true;
            cantCuotasLabel.Location = new System.Drawing.Point(11, 34);
            cantCuotasLabel.Name = "cantCuotasLabel";
            cantCuotasLabel.Size = new System.Drawing.Size(68, 13);
            cantCuotasLabel.TabIndex = 8;
            cantCuotasLabel.Text = "Cant Cuotas:";
            // 
            // valorCuotaLabel
            // 
            valorCuotaLabel.AutoSize = true;
            valorCuotaLabel.Location = new System.Drawing.Point(11, 60);
            valorCuotaLabel.Name = "valorCuotaLabel";
            valorCuotaLabel.Size = new System.Drawing.Size(65, 13);
            valorCuotaLabel.TabIndex = 10;
            valorCuotaLabel.Text = "Valor Cuota:";
            // 
            // valorDescuentoLabel
            // 
            valorDescuentoLabel.AutoSize = true;
            valorDescuentoLabel.Location = new System.Drawing.Point(11, 86);
            valorDescuentoLabel.Name = "valorDescuentoLabel";
            valorDescuentoLabel.Size = new System.Drawing.Size(89, 13);
            valorDescuentoLabel.TabIndex = 12;
            valorDescuentoLabel.Text = "Valor Descuento:";
            // 
            // valorCertificadoLabel
            // 
            valorCertificadoLabel.AutoSize = true;
            valorCertificadoLabel.Location = new System.Drawing.Point(11, 112);
            valorCertificadoLabel.Name = "valorCertificadoLabel";
            valorCertificadoLabel.Size = new System.Drawing.Size(87, 13);
            valorCertificadoLabel.TabIndex = 14;
            valorCertificadoLabel.Text = "Valor Certificado:";
            // 
            // comisionIdaLabel
            // 
            comisionIdaLabel.AutoSize = true;
            comisionIdaLabel.Location = new System.Drawing.Point(11, 138);
            comisionIdaLabel.Name = "comisionIdaLabel";
            comisionIdaLabel.Size = new System.Drawing.Size(70, 13);
            comisionIdaLabel.TabIndex = 16;
            comisionIdaLabel.Text = "Comision Ida:";
            // 
            // comisionVueltaLabel
            // 
            comisionVueltaLabel.AutoSize = true;
            comisionVueltaLabel.Location = new System.Drawing.Point(11, 164);
            comisionVueltaLabel.Name = "comisionVueltaLabel";
            comisionVueltaLabel.Size = new System.Drawing.Size(85, 13);
            comisionVueltaLabel.TabIndex = 18;
            comisionVueltaLabel.Text = "Comision Vuelta:";
            // 
            // comisionCertificadoLabel
            // 
            comisionCertificadoLabel.AutoSize = true;
            comisionCertificadoLabel.Location = new System.Drawing.Point(11, 190);
            comisionCertificadoLabel.Name = "comisionCertificadoLabel";
            comisionCertificadoLabel.Size = new System.Drawing.Size(105, 13);
            comisionCertificadoLabel.TabIndex = 20;
            comisionCertificadoLabel.Text = "Comision Certificado:";
            // 
            // sqliteClientDataBaseDataSet
            // 
            this.sqliteClientDataBaseDataSet.DataSetName = "SqliteClientDataBaseDataSet";
            this.sqliteClientDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.sqliteClientDataBaseDataSet;
            this.personaBindingSource.PositionChanged += new System.EventHandler(this.personaBindingSource_PositionChanged);
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoHorarioSetTableAdapter = this.alumnoHorarioSetTableAdapter;
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
            this.tableAdapterManager.PersonaTableAdapter = this.personaTableAdapter;
            this.tableAdapterManager.PlanBaseSetTableAdapter = null;
            this.tableAdapterManager.PlanVendedorAlumnoSetTableAdapter = this.planVendedorAlumnoSetTableAdapter;
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
            this.tableAdapterManager.RolAlumnoTableAdapter = this.rolAlumnoTableAdapter;
            this.tableAdapterManager.RolCiudadActivaGastosSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaHorarioSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaPlanSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadActivaSetTableAdapter = null;
            this.tableAdapterManager.RolCiudadEnProcesoSetTableAdapter = null;
            this.tableAdapterManager.RolDocenteSetTableAdapter = null;
            this.tableAdapterManager.RolEmpleadoActualTableAdapter = null;
            this.tableAdapterManager.RolEmpleadoTableAdapter = null;
            this.tableAdapterManager.RolLocacionAlojamientoSetTableAdapter = null;
            this.tableAdapterManager.RolLocacionSalonSetTableAdapter = null;
            this.tableAdapterManager.RolLocadorSetTableAdapter = null;
            this.tableAdapterManager.RolVendedorTableAdapter = null;
            this.tableAdapterManager.SueldoPagoSetTableAdapter = null;
            this.tableAdapterManager.TarjetaPropiaSetTableAdapter = null;
            this.tableAdapterManager.TipoChequeSetTableAdapter = null;
            this.tableAdapterManager.TransferenciaSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITCManager.Client.UI_Client.SqliteClientDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValeFinanciacionSetTableAdapter = null;
            this.tableAdapterManager.ValeSetTableAdapter = null;
            // 
            // alumnoHorarioSetTableAdapter
            // 
            this.alumnoHorarioSetTableAdapter.ClearBeforeFill = true;
            // 
            // planVendedorAlumnoSetTableAdapter
            // 
            this.planVendedorAlumnoSetTableAdapter.ClearBeforeFill = true;
            // 
            // rolAlumnoTableAdapter
            // 
            this.rolAlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // personaBindingNavigator
            // 
            this.personaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personaBindingNavigator.BindingSource = this.personaBindingSource;
            this.personaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.personaBindingNavigatorSaveItem});
            this.personaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personaBindingNavigator.Name = "personaBindingNavigator";
            this.personaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personaBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.personaBindingNavigator.TabIndex = 0;
            this.personaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personaBindingNavigatorSaveItem
            // 
            this.personaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personaBindingNavigatorSaveItem.Image")));
            this.personaBindingNavigatorSaveItem.Name = "personaBindingNavigatorSaveItem";
            this.personaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.personaBindingNavigatorSaveItem.Click += new System.EventHandler(this.personaBindingNavigatorSaveItem_Click);
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(93, 54);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPersonaTextBox.TabIndex = 2;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(93, 80);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(93, 106);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 6;
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personaBindingSource, "FechaNac", true));
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(93, 132);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacDateTimePicker.TabIndex = 8;
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(93, 158);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(200, 20);
            this.dNITextBox.TabIndex = 10;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(93, 184);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // barrioTextBox
            // 
            this.barrioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Barrio", true));
            this.barrioTextBox.Location = new System.Drawing.Point(93, 210);
            this.barrioTextBox.Name = "barrioTextBox";
            this.barrioTextBox.Size = new System.Drawing.Size(200, 20);
            this.barrioTextBox.TabIndex = 14;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(93, 236);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(200, 20);
            this.ciudadTextBox.TabIndex = 16;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(93, 262);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.provinciaTextBox.TabIndex = 18;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(93, 288);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(200, 20);
            this.celularTextBox.TabIndex = 20;
            // 
            // telAlternativoTextBox
            // 
            this.telAlternativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelAlternativo", true));
            this.telAlternativoTextBox.Location = new System.Drawing.Point(93, 314);
            this.telAlternativoTextBox.Name = "telAlternativoTextBox";
            this.telAlternativoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telAlternativoTextBox.TabIndex = 22;
            // 
            // estadoCivilTextBox
            // 
            this.estadoCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EstadoCivil", true));
            this.estadoCivilTextBox.Location = new System.Drawing.Point(93, 340);
            this.estadoCivilTextBox.Name = "estadoCivilTextBox";
            this.estadoCivilTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoCivilTextBox.TabIndex = 24;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(93, 366);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.mailTextBox.TabIndex = 26;
            // 
            // rolAlumnoBindingSource
            // 
            this.rolAlumnoBindingSource.DataMember = "FK_RolAlumno_0_0";
            this.rolAlumnoBindingSource.DataSource = this.personaBindingSource;
            // 
            // alumnoHorarioSetBindingSource
            // 
            this.alumnoHorarioSetBindingSource.DataMember = "FK_AlumnoHorarioSet_1_0";
            this.alumnoHorarioSetBindingSource.DataSource = this.rolAlumnoBindingSource;
            // 
            // planVendedorAlumnoSetBindingSource
            // 
            this.planVendedorAlumnoSetBindingSource.DataMember = "FK_PlanVendedorAlumnoSet_2_0";
            this.planVendedorAlumnoSetBindingSource.DataSource = this.rolAlumnoBindingSource;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataSource = this.rolEmpleadoBindingSource;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(384, 57);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(139, 21);
            this.cmbVendedor.TabIndex = 27;
            // 
            // rolEmpleadoBindingSource
            // 
            this.rolEmpleadoBindingSource.DataMember = "RolEmpleado";
            this.rolEmpleadoBindingSource.DataSource = this.sqliteClientDataBaseDataSet;
            // 
            // rolEmpleadoTableAdapter
            // 
            this.rolEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Dia";
            // 
            // cmbDia
            // 
            this.cmbDia.DataSource = this.rolEmpleadoBindingSource;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(658, 62);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(139, 21);
            this.cmbDia.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Horario";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DataSource = this.rolEmpleadoBindingSource;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(658, 87);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(139, 21);
            this.cmbHorario.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Plan";
            // 
            // cmbPlan
            // 
            this.cmbPlan.DataSource = this.rolEmpleadoBindingSource;
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(658, 145);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(139, 21);
            this.cmbPlan.TabIndex = 33;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Capacitación";
            // 
            // cmbCapacitacion
            // 
            this.cmbCapacitacion.DataSource = this.rolEmpleadoBindingSource;
            this.cmbCapacitacion.FormattingEnabled = true;
            this.cmbCapacitacion.Location = new System.Drawing.Point(658, 37);
            this.cmbCapacitacion.Name = "cmbCapacitacion";
            this.cmbCapacitacion.Size = new System.Drawing.Size(139, 21);
            this.cmbCapacitacion.TabIndex = 37;
            // 
            // panPlanEspecial
            // 
            this.panPlanEspecial.Controls.Add(valorMatriculaLabel);
            this.panPlanEspecial.Controls.Add(this.valorMatriculaTextBox);
            this.panPlanEspecial.Controls.Add(cantCuotasLabel);
            this.panPlanEspecial.Controls.Add(this.cantCuotasTextBox);
            this.panPlanEspecial.Controls.Add(valorCuotaLabel);
            this.panPlanEspecial.Controls.Add(this.valorCuotaTextBox);
            this.panPlanEspecial.Controls.Add(valorDescuentoLabel);
            this.panPlanEspecial.Controls.Add(this.valorDescuentoTextBox);
            this.panPlanEspecial.Controls.Add(valorCertificadoLabel);
            this.panPlanEspecial.Controls.Add(this.valorCertificadoTextBox);
            this.panPlanEspecial.Controls.Add(comisionIdaLabel);
            this.panPlanEspecial.Controls.Add(this.comisionIdaTextBox);
            this.panPlanEspecial.Controls.Add(comisionVueltaLabel);
            this.panPlanEspecial.Controls.Add(this.comisionVueltaTextBox);
            this.panPlanEspecial.Controls.Add(comisionCertificadoLabel);
            this.panPlanEspecial.Controls.Add(this.comisionCertificadoTextBox);
            this.panPlanEspecial.Location = new System.Drawing.Point(549, 208);
            this.panPlanEspecial.Margin = new System.Windows.Forms.Padding(2);
            this.panPlanEspecial.Name = "panPlanEspecial";
            this.panPlanEspecial.Size = new System.Drawing.Size(284, 214);
            this.panPlanEspecial.TabIndex = 39;
            // 
            // valorMatriculaTextBox
            // 
            this.valorMatriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ValorMatricula", true));
            this.valorMatriculaTextBox.Location = new System.Drawing.Point(148, 5);
            this.valorMatriculaTextBox.Name = "valorMatriculaTextBox";
            this.valorMatriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorMatriculaTextBox.TabIndex = 7;
            // 
            // rolCiudadActivaPlanSetBindingSource
            // 
            this.rolCiudadActivaPlanSetBindingSource.DataMember = "RolCiudadActivaPlanSet";
            this.rolCiudadActivaPlanSetBindingSource.DataSource = this.sqliteClientDataBaseDataSet;
            // 
            // cantCuotasTextBox
            // 
            this.cantCuotasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "CantCuotas", true));
            this.cantCuotasTextBox.Location = new System.Drawing.Point(148, 31);
            this.cantCuotasTextBox.Name = "cantCuotasTextBox";
            this.cantCuotasTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantCuotasTextBox.TabIndex = 9;
            // 
            // valorCuotaTextBox
            // 
            this.valorCuotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ValorCuota", true));
            this.valorCuotaTextBox.Location = new System.Drawing.Point(148, 57);
            this.valorCuotaTextBox.Name = "valorCuotaTextBox";
            this.valorCuotaTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCuotaTextBox.TabIndex = 11;
            // 
            // valorDescuentoTextBox
            // 
            this.valorDescuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ValorDescuento", true));
            this.valorDescuentoTextBox.Location = new System.Drawing.Point(148, 83);
            this.valorDescuentoTextBox.Name = "valorDescuentoTextBox";
            this.valorDescuentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorDescuentoTextBox.TabIndex = 13;
            // 
            // valorCertificadoTextBox
            // 
            this.valorCertificadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ValorCertificado", true));
            this.valorCertificadoTextBox.Location = new System.Drawing.Point(148, 109);
            this.valorCertificadoTextBox.Name = "valorCertificadoTextBox";
            this.valorCertificadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCertificadoTextBox.TabIndex = 15;
            // 
            // comisionIdaTextBox
            // 
            this.comisionIdaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ComisionIda", true));
            this.comisionIdaTextBox.Location = new System.Drawing.Point(148, 135);
            this.comisionIdaTextBox.Name = "comisionIdaTextBox";
            this.comisionIdaTextBox.Size = new System.Drawing.Size(100, 20);
            this.comisionIdaTextBox.TabIndex = 17;
            // 
            // comisionVueltaTextBox
            // 
            this.comisionVueltaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ComisionVuelta", true));
            this.comisionVueltaTextBox.Location = new System.Drawing.Point(148, 161);
            this.comisionVueltaTextBox.Name = "comisionVueltaTextBox";
            this.comisionVueltaTextBox.Size = new System.Drawing.Size(100, 20);
            this.comisionVueltaTextBox.TabIndex = 19;
            // 
            // comisionCertificadoTextBox
            // 
            this.comisionCertificadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolCiudadActivaPlanSetBindingSource, "ComisionCertificado", true));
            this.comisionCertificadoTextBox.Location = new System.Drawing.Point(148, 187);
            this.comisionCertificadoTextBox.Name = "comisionCertificadoTextBox";
            this.comisionCertificadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.comisionCertificadoTextBox.TabIndex = 21;
            // 
            // rolCiudadActivaPlanSetTableAdapter
            // 
            this.rolCiudadActivaPlanSetTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Location = new System.Drawing.Point(704, 174);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(93, 23);
            this.btnGuardarPlan.TabIndex = 40;
            this.btnGuardarPlan.Text = "Guardar Plan";
            this.btnGuardarPlan.UseVisualStyleBackColor = true;
            this.btnGuardarPlan.Visible = false;
            this.btnGuardarPlan.Click += new System.EventHandler(this.btnGuardarPlan_Click);
            // 
            // txtNroRecibo
            // 
            this.txtNroRecibo.Location = new System.Drawing.Point(384, 84);
            this.txtNroRecibo.Name = "txtNroRecibo";
            this.txtNroRecibo.Size = new System.Drawing.Size(139, 20);
            this.txtNroRecibo.TabIndex = 41;
            // 
            // txtObservacionGerente
            // 
            this.txtObservacionGerente.Location = new System.Drawing.Point(325, 213);
            this.txtObservacionGerente.Multiline = true;
            this.txtObservacionGerente.Name = "txtObservacionGerente";
            this.txtObservacionGerente.Size = new System.Drawing.Size(198, 176);
            this.txtObservacionGerente.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nro. Recibo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Observación Gerente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Estado";
            // 
            // cmbEstadoAlumno
            // 
            this.cmbEstadoAlumno.FormattingEnabled = true;
            this.cmbEstadoAlumno.Location = new System.Drawing.Point(384, 113);
            this.cmbEstadoAlumno.Name = "cmbEstadoAlumno";
            this.cmbEstadoAlumno.Size = new System.Drawing.Size(139, 21);
            this.cmbEstadoAlumno.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo Horario";
            // 
            // cmbTipoHorario
            // 
            this.cmbTipoHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHorario.FormattingEnabled = true;
            this.cmbTipoHorario.Items.AddRange(new object[] {
            "Principal",
            "Rotativo"});
            this.cmbTipoHorario.Location = new System.Drawing.Point(658, 114);
            this.cmbTipoHorario.Name = "cmbTipoHorario";
            this.cmbTipoHorario.Size = new System.Drawing.Size(139, 21);
            this.cmbTipoHorario.TabIndex = 47;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 442);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTipoHorario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstadoAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservacionGerente);
            this.Controls.Add(this.txtNroRecibo);
            this.Controls.Add(this.btnGuardarPlan);
            this.Controls.Add(this.panPlanEspecial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCapacitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(idPersonaLabel);
            this.Controls.Add(this.idPersonaTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(fechaNacLabel);
            this.Controls.Add(this.fechaNacDateTimePicker);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(barrioLabel);
            this.Controls.Add(this.barrioTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(telAlternativoLabel);
            this.Controls.Add(this.telAlternativoTextBox);
            this.Controls.Add(estadoCivilLabel);
            this.Controls.Add(this.estadoCivilTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.personaBindingNavigator);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqliteClientDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).EndInit();
            this.personaBindingNavigator.ResumeLayout(false);
            this.personaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoHorarioSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planVendedorAlumnoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoBindingSource)).EndInit();
            this.panPlanEspecial.ResumeLayout(false);
            this.panPlanEspecial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolCiudadActivaPlanSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SqliteClientDataBaseDataSet sqliteClientDataBaseDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private SqliteClientDataBaseDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private SqliteClientDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personaBindingNavigatorSaveItem;
        private SqliteClientDataBaseDataSetTableAdapters.RolAlumnoTableAdapter rolAlumnoTableAdapter;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacDateTimePicker;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox barrioTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox telAlternativoTextBox;
        private System.Windows.Forms.TextBox estadoCivilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.BindingSource rolAlumnoBindingSource;
        private SqliteClientDataBaseDataSetTableAdapters.AlumnoHorarioSetTableAdapter alumnoHorarioSetTableAdapter;
        private System.Windows.Forms.BindingSource alumnoHorarioSetBindingSource;
        private SqliteClientDataBaseDataSetTableAdapters.PlanVendedorAlumnoSetTableAdapter planVendedorAlumnoSetTableAdapter;
        private System.Windows.Forms.BindingSource planVendedorAlumnoSetBindingSource;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.BindingSource rolEmpleadoBindingSource;
        private SqliteClientDataBaseDataSetTableAdapters.RolEmpleadoTableAdapter rolEmpleadoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCapacitacion;
        private System.Windows.Forms.Panel panPlanEspecial;
        private System.Windows.Forms.BindingSource rolCiudadActivaPlanSetBindingSource;
        private SqliteClientDataBaseDataSetTableAdapters.RolCiudadActivaPlanSetTableAdapter rolCiudadActivaPlanSetTableAdapter;
        private System.Windows.Forms.TextBox valorMatriculaTextBox;
        private System.Windows.Forms.TextBox cantCuotasTextBox;
        private System.Windows.Forms.TextBox valorCuotaTextBox;
        private System.Windows.Forms.TextBox valorDescuentoTextBox;
        private System.Windows.Forms.TextBox valorCertificadoTextBox;
        private System.Windows.Forms.TextBox comisionIdaTextBox;
        private System.Windows.Forms.TextBox comisionVueltaTextBox;
        private System.Windows.Forms.TextBox comisionCertificadoTextBox;
        private System.Windows.Forms.Button btnGuardarPlan;
        private System.Windows.Forms.TextBox txtNroRecibo;
        private System.Windows.Forms.TextBox txtObservacionGerente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstadoAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoHorario;
    }
}