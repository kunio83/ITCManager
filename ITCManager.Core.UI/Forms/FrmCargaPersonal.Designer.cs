namespace ITCManager.Core.UI.Forms
{
    partial class FrmCargaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaPersonal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.personaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTC_DBPOwerDataSet = new ITCManager.Core.UI.ITC_DBPOwerDataSet();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rolEmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.puestoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rolVendedorDataGridView = new System.Windows.Forms.DataGridView();
            this.getJefesVentasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.getJefesVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRolEmpleadoRolVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getJefesVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPersonaRolEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.PersonaTableAdapter();
            this.tableAdapterManager = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
            this.rolEmpleadoTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolEmpleadoTableAdapter();
            this.puestoSetTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.PuestoSetTableAdapter();
            this.rolVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolVendedorTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.RolVendedorTableAdapter();
            this.getJefesVentasTableAdapter = new ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters.getJefesVentasTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGerente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gerente = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).BeginInit();
            this.personaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolVendedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolEmpleadoRolVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonaRolEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolVendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.ForeColor = System.Drawing.SystemColors.Control;
            idPersonaLabel.Location = new System.Drawing.Point(13, 17);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel.TabIndex = 1;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.ForeColor = System.Drawing.SystemColors.Control;
            apellidoLabel.Location = new System.Drawing.Point(13, 43);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombresLabel.Location = new System.Drawing.Point(13, 69);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 5;
            nombresLabel.Text = "Nombres:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaNacLabel.Location = new System.Drawing.Point(13, 96);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 7;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.ForeColor = System.Drawing.SystemColors.Control;
            dNILabel.Location = new System.Drawing.Point(13, 121);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 9;
            dNILabel.Text = "DNI:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
            direccionLabel.Location = new System.Drawing.Point(13, 147);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // barrioLabel
            // 
            barrioLabel.AutoSize = true;
            barrioLabel.ForeColor = System.Drawing.SystemColors.Control;
            barrioLabel.Location = new System.Drawing.Point(13, 173);
            barrioLabel.Name = "barrioLabel";
            barrioLabel.Size = new System.Drawing.Size(37, 13);
            barrioLabel.TabIndex = 13;
            barrioLabel.Text = "Barrio:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.ForeColor = System.Drawing.SystemColors.Control;
            ciudadLabel.Location = new System.Drawing.Point(13, 199);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 15;
            ciudadLabel.Text = "Ciudad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.ForeColor = System.Drawing.SystemColors.Control;
            provinciaLabel.Location = new System.Drawing.Point(13, 225);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 17;
            provinciaLabel.Text = "Provincia:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.ForeColor = System.Drawing.SystemColors.Control;
            celularLabel.Location = new System.Drawing.Point(13, 251);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 19;
            celularLabel.Text = "Celular:";
            // 
            // telAlternativoLabel
            // 
            telAlternativoLabel.AutoSize = true;
            telAlternativoLabel.ForeColor = System.Drawing.SystemColors.Control;
            telAlternativoLabel.Location = new System.Drawing.Point(13, 277);
            telAlternativoLabel.Name = "telAlternativoLabel";
            telAlternativoLabel.Size = new System.Drawing.Size(78, 13);
            telAlternativoLabel.TabIndex = 21;
            telAlternativoLabel.Text = "Tel Alternativo:";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.ForeColor = System.Drawing.SystemColors.Control;
            estadoCivilLabel.Location = new System.Drawing.Point(13, 303);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(65, 13);
            estadoCivilLabel.TabIndex = 23;
            estadoCivilLabel.Text = "Estado Civil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.ForeColor = System.Drawing.SystemColors.Control;
            mailLabel.Location = new System.Drawing.Point(13, 329);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 25;
            mailLabel.Text = "Mail:";
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
            this.personaBindingNavigator.Location = new System.Drawing.Point(10, 30);
            this.personaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personaBindingNavigator.Name = "personaBindingNavigator";
            this.personaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personaBindingNavigator.Size = new System.Drawing.Size(793, 25);
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // iTC_DBPOwerDataSet
            // 
            this.iTC_DBPOwerDataSet.DataSetName = "ITC_DBPOwerDataSet";
            this.iTC_DBPOwerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // personaBindingNavigatorSaveItem
            // 
            this.personaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personaBindingNavigatorSaveItem.Image")));
            this.personaBindingNavigatorSaveItem.Name = "personaBindingNavigatorSaveItem";
            this.personaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personaBindingNavigatorSaveItem.Text = "Save Data";
            this.personaBindingNavigatorSaveItem.Click += new System.EventHandler(this.personaBindingNavigatorSaveItem_Click);
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(97, 14);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPersonaTextBox.TabIndex = 2;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(97, 40);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(97, 66);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 6;
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personaBindingSource, "FechaNac", true));
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(97, 92);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacDateTimePicker.TabIndex = 8;
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(97, 118);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(200, 20);
            this.dNITextBox.TabIndex = 10;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(97, 144);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // barrioTextBox
            // 
            this.barrioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Barrio", true));
            this.barrioTextBox.Location = new System.Drawing.Point(97, 170);
            this.barrioTextBox.Name = "barrioTextBox";
            this.barrioTextBox.Size = new System.Drawing.Size(200, 20);
            this.barrioTextBox.TabIndex = 14;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(97, 196);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(200, 20);
            this.ciudadTextBox.TabIndex = 16;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(97, 222);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.provinciaTextBox.TabIndex = 18;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(97, 248);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(200, 20);
            this.celularTextBox.TabIndex = 20;
            // 
            // telAlternativoTextBox
            // 
            this.telAlternativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelAlternativo", true));
            this.telAlternativoTextBox.Location = new System.Drawing.Point(97, 274);
            this.telAlternativoTextBox.Name = "telAlternativoTextBox";
            this.telAlternativoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telAlternativoTextBox.TabIndex = 22;
            // 
            // estadoCivilTextBox
            // 
            this.estadoCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EstadoCivil", true));
            this.estadoCivilTextBox.Location = new System.Drawing.Point(97, 300);
            this.estadoCivilTextBox.Name = "estadoCivilTextBox";
            this.estadoCivilTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoCivilTextBox.TabIndex = 24;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(97, 326);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.mailTextBox.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idPersonaTextBox);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(idPersonaLabel);
            this.panel1.Controls.Add(mailLabel);
            this.panel1.Controls.Add(this.estadoCivilTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(estadoCivilLabel);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(this.telAlternativoTextBox);
            this.panel1.Controls.Add(nombresLabel);
            this.panel1.Controls.Add(telAlternativoLabel);
            this.panel1.Controls.Add(this.nombresTextBox);
            this.panel1.Controls.Add(this.celularTextBox);
            this.panel1.Controls.Add(fechaNacLabel);
            this.panel1.Controls.Add(celularLabel);
            this.panel1.Controls.Add(this.fechaNacDateTimePicker);
            this.panel1.Controls.Add(this.provinciaTextBox);
            this.panel1.Controls.Add(dNILabel);
            this.panel1.Controls.Add(provinciaLabel);
            this.panel1.Controls.Add(this.dNITextBox);
            this.panel1.Controls.Add(this.ciudadTextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(ciudadLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(this.barrioTextBox);
            this.panel1.Controls.Add(barrioLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 412);
            this.panel1.TabIndex = 27;
            // 
            // rolEmpleadoDataGridView
            // 
            this.rolEmpleadoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolEmpleadoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolEmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rolEmpleadoDataGridView.DataSource = this.rolEmpleadoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolEmpleadoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.rolEmpleadoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolEmpleadoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.rolEmpleadoDataGridView.Name = "rolEmpleadoDataGridView";
            this.rolEmpleadoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolEmpleadoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rolEmpleadoDataGridView.Size = new System.Drawing.Size(451, 154);
            this.rolEmpleadoDataGridView.TabIndex = 0;
            this.rolEmpleadoDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rolEmpleadoDataGridView_CellMouseClick);
            this.rolEmpleadoDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.rolEmpleadoDataGridView_DataBindingComplete);
            this.rolEmpleadoDataGridView.MouseEnter += new System.EventHandler(this.rolEmpleadoDataGridView_MouseEnter);
            this.rolEmpleadoDataGridView.MouseLeave += new System.EventHandler(this.rolEmpleadoDataGridView_MouseLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPersona";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPersona";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdPuesto";
            this.dataGridViewTextBoxColumn3.DataSource = this.puestoSetBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "DetallePuesto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdPuesto";
            // 
            // puestoSetBindingSource
            // 
            this.puestoSetBindingSource.DataMember = "PuestoSet";
            this.puestoSetBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CelCorp";
            this.dataGridViewTextBoxColumn4.HeaderText = "CelCorp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SueldoBasico";
            this.dataGridViewTextBoxColumn7.HeaderText = "SueldoBasico";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // rolEmpleadoBindingSource
            // 
            this.rolEmpleadoBindingSource.DataMember = "FK_PersonaRolEmpleado";
            this.rolEmpleadoBindingSource.DataSource = this.personaBindingSource;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rolVendedorDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rolEmpleadoDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.60993F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.39007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 412);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // rolVendedorDataGridView
            // 
            this.rolVendedorDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolVendedorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rolVendedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolVendedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.SubGerente,
            this.Gerente});
            this.rolVendedorDataGridView.DataSource = this.fKRolEmpleadoRolVendedorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolVendedorDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.rolVendedorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolVendedorDataGridView.Location = new System.Drawing.Point(3, 163);
            this.rolVendedorDataGridView.Name = "rolVendedorDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolVendedorDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rolVendedorDataGridView.Size = new System.Drawing.Size(451, 127);
            this.rolVendedorDataGridView.TabIndex = 1;
            // 
            // getJefesVentasBindingSource2
            // 
            this.getJefesVentasBindingSource2.DataMember = "getJefesVentas";
            this.getJefesVentasBindingSource2.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // getJefesVentasBindingSource1
            // 
            this.getJefesVentasBindingSource1.DataMember = "getJefesVentas";
            this.getJefesVentasBindingSource1.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // fKRolEmpleadoRolVendedorBindingSource
            // 
            this.fKRolEmpleadoRolVendedorBindingSource.DataMember = "FK_RolEmpleadoRolVendedor";
            this.fKRolEmpleadoRolVendedorBindingSource.DataSource = this.rolEmpleadoBindingSource;
            // 
            // getJefesVentasBindingSource
            // 
            this.getJefesVentasBindingSource.DataMember = "getJefesVentas";
            // 
            // fKPersonaRolEmpleadoBindingSource
            // 
            this.fKPersonaRolEmpleadoBindingSource.DataMember = "FK_PersonaRolEmpleado";
            this.fKPersonaRolEmpleadoBindingSource.DataSource = this.personaBindingSource;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LineaCiudadSetTableAdapter = null;
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
            this.tableAdapterManager.RolCiudadActivaSetTableAdapter = null;
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
            // rolEmpleadoTableAdapter
            // 
            this.rolEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // puestoSetTableAdapter
            // 
            this.puestoSetTableAdapter.ClearBeforeFill = true;
            // 
            // rolVendedorBindingSource
            // 
            this.rolVendedorBindingSource.DataMember = "RolVendedor";
            this.rolVendedorBindingSource.DataSource = this.iTC_DBPOwerDataSet;
            // 
            // rolVendedorTableAdapter
            // 
            this.rolVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // getJefesVentasTableAdapter
            // 
            this.getJefesVentasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdRolVendedor";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdRolVendedor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdRolEmpleado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdSubgerente";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdSubgerente";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdGerente";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdGerente";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // SubGerente
            // 
            this.SubGerente.DataPropertyName = "IdSubgerente";
            this.SubGerente.DataSource = this.getJefesVentasBindingSource2;
            this.SubGerente.DisplayMember = "Apellido";
            this.SubGerente.HeaderText = "Subgerente";
            this.SubGerente.Name = "SubGerente";
            this.SubGerente.ValueMember = "IdRolEmpleado";
            // 
            // Gerente
            // 
            this.Gerente.DataPropertyName = "IdGerente";
            this.Gerente.DataSource = this.getJefesVentasBindingSource1;
            this.Gerente.DisplayMember = "Apellido";
            this.Gerente.HeaderText = "Gerente";
            this.Gerente.Name = "Gerente";
            this.Gerente.ValueMember = "IdRolEmpleado";
            // 
            // FrmCargaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personaBindingNavigator);
            this.Name = "FrmCargaPersonal";
            this.Text = "Carga  de Personal";
            this.Load += new System.EventHandler(this.FrmCargaPersonal_Load);
            this.Controls.SetChildIndex(this.personaBindingNavigator, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).EndInit();
            this.personaBindingNavigator.ResumeLayout(false);
            this.personaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTC_DBPOwerDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolEmpleadoBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolVendedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolEmpleadoRolVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJefesVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonaRolEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolVendedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITC_DBPOwerDataSet iTC_DBPOwerDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private ITC_DBPOwerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource rolEmpleadoBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.RolEmpleadoTableAdapter rolEmpleadoTableAdapter;
        private System.Windows.Forms.DataGridView rolEmpleadoDataGridView;
        private System.Windows.Forms.BindingSource puestoSetBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.PuestoSetTableAdapter puestoSetTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource rolVendedorBindingSource;
        private ITC_DBPOwerDataSetTableAdapters.RolVendedorTableAdapter rolVendedorTableAdapter;
        private System.Windows.Forms.DataGridView rolVendedorDataGridView;
        private System.Windows.Forms.BindingSource fKRolEmpleadoRolVendedorBindingSource;
        private System.Windows.Forms.BindingSource fKPersonaRolEmpleadoBindingSource;
        private System.Windows.Forms.BindingSource getJefesVentasBindingSource;
        private System.Windows.Forms.BindingSource getJefesVentasBindingSource1;
        private ITC_DBPOwerDataSetTableAdapters.getJefesVentasTableAdapter getJefesVentasTableAdapter;
        private System.Windows.Forms.BindingSource getJefesVentasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubGerente;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gerente;
    }
}