namespace InitialProject
{
    partial class frmProveedores
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
            System.Windows.Forms.Label iDProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label iDTipoDocumentoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombresContactoLabel;
            System.Windows.Forms.Label apellidosContactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label notasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.dSAplicacionComercial = new InitialProject.DS.DSAplicacionComercial();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new InitialProject.DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.tableAdapterManager = new InitialProject.DS.DSAplicacionComercialTableAdapters.TableAdapterManager();
            this.proveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.countItemBindingNavigator = new System.Windows.Forms.ToolStripLabel();
            this.firstItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.previousItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.positionItemBindingNavigator = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nextItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.lastItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.addNewItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.deleteItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.saveItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.cancelItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.searchItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.proveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.iDTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAll = new InitialProject.DSAll.DSAll();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.tipoDocumentoTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.TipoDocumentoTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            iDTipoDocumentoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombresContactoLabel = new System.Windows.Forms.Label();
            apellidosContactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).BeginInit();
            this.proveedorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.Location = new System.Drawing.Point(43, 56);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(70, 13);
            iDProveedorLabel.TabIndex = 1;
            iDProveedorLabel.Text = "IDProveedor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(66, 111);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // iDTipoDocumentoLabel
            // 
            iDTipoDocumentoLabel.AutoSize = true;
            iDTipoDocumentoLabel.Location = new System.Drawing.Point(277, 56);
            iDTipoDocumentoLabel.Name = "iDTipoDocumentoLabel";
            iDTipoDocumentoLabel.Size = new System.Drawing.Size(100, 13);
            iDTipoDocumentoLabel.TabIndex = 3;
            iDTipoDocumentoLabel.Text = "IDTipo Documento:";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(567, 57);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 5;
            documentoLabel.Text = "Documento:";
            // 
            // nombresContactoLabel
            // 
            nombresContactoLabel.AutoSize = true;
            nombresContactoLabel.Location = new System.Drawing.Point(15, 85);
            nombresContactoLabel.Name = "nombresContactoLabel";
            nombresContactoLabel.Size = new System.Drawing.Size(98, 13);
            nombresContactoLabel.TabIndex = 7;
            nombresContactoLabel.Text = "Nombres Contacto:";
            // 
            // apellidosContactoLabel
            // 
            apellidosContactoLabel.AutoSize = true;
            apellidosContactoLabel.Location = new System.Drawing.Point(279, 86);
            apellidosContactoLabel.Name = "apellidosContactoLabel";
            apellidosContactoLabel.Size = new System.Drawing.Size(98, 13);
            apellidosContactoLabel.TabIndex = 9;
            apellidosContactoLabel.Text = "Apellidos Contacto:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(577, 85);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(574, 111);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(58, 13);
            telefono1Label.TabIndex = 15;
            telefono1Label.Text = "Telefono1:";
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(55, 137);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(58, 13);
            telefono2Label.TabIndex = 17;
            telefono2Label.Text = "Telefono2:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(336, 137);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 19;
            correoLabel.Text = "Correo:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(75, 163);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 21;
            notasLabel.Text = "Notas:";
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InitialProject.DS.DSAplicacionComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // proveedorBindingNavigator
            // 
            this.proveedorBindingNavigator.AddNewItem = null;
            this.proveedorBindingNavigator.BindingSource = this.proveedorBindingSource;
            this.proveedorBindingNavigator.CountItem = this.countItemBindingNavigator;
            this.proveedorBindingNavigator.DeleteItem = null;
            this.proveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItemBindingNavigator,
            this.previousItemBindingNavigator,
            this.bindingNavigatorSeparator,
            this.positionItemBindingNavigator,
            this.countItemBindingNavigator,
            this.bindingNavigatorSeparator1,
            this.nextItemBindingNavigator,
            this.lastItemBindingNavigator,
            this.bindingNavigatorSeparator2,
            this.modifierItemBindingNavigator,
            this.addNewItemBindingNavigator,
            this.deleteItemBindingNavigator,
            this.saveItemBindingNavigator,
            this.cancelItemBindingNavigator,
            this.searchItemBindingNavigator});
            this.proveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedorBindingNavigator.MoveFirstItem = this.firstItemBindingNavigator;
            this.proveedorBindingNavigator.MoveLastItem = this.lastItemBindingNavigator;
            this.proveedorBindingNavigator.MoveNextItem = this.nextItemBindingNavigator;
            this.proveedorBindingNavigator.MovePreviousItem = this.previousItemBindingNavigator;
            this.proveedorBindingNavigator.Name = "proveedorBindingNavigator";
            this.proveedorBindingNavigator.PositionItem = this.positionItemBindingNavigator;
            this.proveedorBindingNavigator.Size = new System.Drawing.Size(973, 25);
            this.proveedorBindingNavigator.TabIndex = 0;
            this.proveedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // countItemBindingNavigator
            // 
            this.countItemBindingNavigator.Name = "countItemBindingNavigator";
            this.countItemBindingNavigator.Size = new System.Drawing.Size(35, 22);
            this.countItemBindingNavigator.Text = "of {0}";
            this.countItemBindingNavigator.ToolTipText = "Total number of items";
            // 
            // firstItemBindingNavigator
            // 
            this.firstItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("firstItemBindingNavigator.Image")));
            this.firstItemBindingNavigator.Name = "firstItemBindingNavigator";
            this.firstItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.firstItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.firstItemBindingNavigator.Text = "Move first";
            // 
            // previousItemBindingNavigator
            // 
            this.previousItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("previousItemBindingNavigator.Image")));
            this.previousItemBindingNavigator.Name = "previousItemBindingNavigator";
            this.previousItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.previousItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.previousItemBindingNavigator.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // positionItemBindingNavigator
            // 
            this.positionItemBindingNavigator.AccessibleName = "Position";
            this.positionItemBindingNavigator.AutoSize = false;
            this.positionItemBindingNavigator.Name = "positionItemBindingNavigator";
            this.positionItemBindingNavigator.Size = new System.Drawing.Size(50, 23);
            this.positionItemBindingNavigator.Text = "0";
            this.positionItemBindingNavigator.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nextItemBindingNavigator
            // 
            this.nextItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("nextItemBindingNavigator.Image")));
            this.nextItemBindingNavigator.Name = "nextItemBindingNavigator";
            this.nextItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.nextItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.nextItemBindingNavigator.Text = "Move next";
            // 
            // lastItemBindingNavigator
            // 
            this.lastItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("lastItemBindingNavigator.Image")));
            this.lastItemBindingNavigator.Name = "lastItemBindingNavigator";
            this.lastItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.lastItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.lastItemBindingNavigator.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // modifierItemBindingNavigator
            // 
            this.modifierItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modifierItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("modifierItemBindingNavigator.Image")));
            this.modifierItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifierItemBindingNavigator.Name = "modifierItemBindingNavigator";
            this.modifierItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.modifierItemBindingNavigator.Text = "Edit";
            this.modifierItemBindingNavigator.Click += new System.EventHandler(this.modifierItemBindingNavigator_Click);
            // 
            // addNewItemBindingNavigator
            // 
            this.addNewItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemBindingNavigator.Image")));
            this.addNewItemBindingNavigator.Name = "addNewItemBindingNavigator";
            this.addNewItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.addNewItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.addNewItemBindingNavigator.Text = "Add new";
            this.addNewItemBindingNavigator.Click += new System.EventHandler(this.addNewItemBindingNavigator_Click);
            // 
            // deleteItemBindingNavigator
            // 
            this.deleteItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemBindingNavigator.Enabled = false;
            this.deleteItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemBindingNavigator.Image")));
            this.deleteItemBindingNavigator.Name = "deleteItemBindingNavigator";
            this.deleteItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.deleteItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.deleteItemBindingNavigator.Text = "Delete";
            this.deleteItemBindingNavigator.Click += new System.EventHandler(this.deleteItemBindingNavigator_Click);
            // 
            // saveItemBindingNavigator
            // 
            this.saveItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveItemBindingNavigator.Enabled = false;
            this.saveItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("saveItemBindingNavigator.Image")));
            this.saveItemBindingNavigator.Name = "saveItemBindingNavigator";
            this.saveItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.saveItemBindingNavigator.Text = "Save Data";
            this.saveItemBindingNavigator.Click += new System.EventHandler(this.saveItemBindingNavigator_Click);
            // 
            // cancelItemBindingNavigator
            // 
            this.cancelItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("cancelItemBindingNavigator.Image")));
            this.cancelItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelItemBindingNavigator.Name = "cancelItemBindingNavigator";
            this.cancelItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.cancelItemBindingNavigator.Text = "Cancel";
            this.cancelItemBindingNavigator.Click += new System.EventHandler(this.cancelItemBindingNavigator_Click);
            // 
            // searchItemBindingNavigator
            // 
            this.searchItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("searchItemBindingNavigator.Image")));
            this.searchItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchItemBindingNavigator.Name = "searchItemBindingNavigator";
            this.searchItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.searchItemBindingNavigator.Text = "Search";
            this.searchItemBindingNavigator.Click += new System.EventHandler(this.searchItemBindingNavigator_Click);
            // 
            // proveedorDataGridView
            // 
            this.proveedorDataGridView.AllowUserToAddRows = false;
            this.proveedorDataGridView.AllowUserToDeleteRows = false;
            this.proveedorDataGridView.AllowUserToOrderColumns = true;
            this.proveedorDataGridView.AutoGenerateColumns = false;
            this.proveedorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11});
            this.proveedorDataGridView.DataSource = this.proveedorBindingSource;
            this.proveedorDataGridView.Location = new System.Drawing.Point(0, 228);
            this.proveedorDataGridView.Name = "proveedorDataGridView";
            this.proveedorDataGridView.ReadOnly = true;
            this.proveedorDataGridView.Size = new System.Drawing.Size(953, 252);
            this.proveedorDataGridView.TabIndex = 23;
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "IDProveedor", true));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(119, 53);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.ReadOnly = true;
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDProveedorTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(119, 108);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(385, 20);
            this.nombreTextBox.TabIndex = 14;
            // 
            // iDTipoDocumentoComboBox
            // 
            this.iDTipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedorBindingSource, "IDTipoDocumento", true));
            this.iDTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
            this.iDTipoDocumentoComboBox.Enabled = false;
            this.iDTipoDocumentoComboBox.FormattingEnabled = true;
            this.iDTipoDocumentoComboBox.Location = new System.Drawing.Point(383, 53);
            this.iDTipoDocumentoComboBox.Name = "iDTipoDocumentoComboBox";
            this.iDTipoDocumentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDTipoDocumentoComboBox.TabIndex = 4;
            this.iDTipoDocumentoComboBox.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAll;
            // 
            // dSAll
            // 
            this.dSAll.DataSetName = "DSAll";
            this.dSAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(638, 53);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.ReadOnly = true;
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 6;
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NombresContacto", true));
            this.nombresContactoTextBox.Location = new System.Drawing.Point(119, 82);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.ReadOnly = true;
            this.nombresContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresContactoTextBox.TabIndex = 8;
            this.nombresContactoTextBox.TextChanged += new System.EventHandler(this.nombresContactoTextBox_TextChanged);
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "ApellidosContacto", true));
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(383, 82);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.ReadOnly = true;
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidosContactoTextBox.TabIndex = 10;
            this.apellidosContactoTextBox.TextChanged += new System.EventHandler(this.apellidosContactoTextBox_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(638, 82);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono1", true));
            this.telefono1TextBox.Location = new System.Drawing.Point(638, 108);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.ReadOnly = true;
            this.telefono1TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono1TextBox.TabIndex = 16;
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono2", true));
            this.telefono2TextBox.Location = new System.Drawing.Point(119, 134);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.ReadOnly = true;
            this.telefono2TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono2TextBox.TabIndex = 18;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(383, 134);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.ReadOnly = true;
            this.correoTextBox.Size = new System.Drawing.Size(121, 20);
            this.correoTextBox.TabIndex = 20;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(119, 160);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.notasTextBox.Size = new System.Drawing.Size(619, 44);
            this.notasTextBox.TabIndex = 22;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDTipoDocumento";
            this.dataGridViewTextBoxColumn3.DataSource = this.tipoDocumentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Tipo Documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDTipoDocumento";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombresContacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombres Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ApellidosContacto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Apellidos Contacto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Teléfono 1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Teléfono 2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 500);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.telefono1TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidosContactoLabel);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(nombresContactoLabel);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(iDTipoDocumentoLabel);
            this.Controls.Add(this.iDTipoDocumentoComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.proveedorDataGridView);
            this.Controls.Add(this.proveedorBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).EndInit();
            this.proveedorBindingNavigator.ResumeLayout(false);
            this.proveedorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private DS.DSAplicacionComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedorBindingNavigator;
        private System.Windows.Forms.ToolStripButton addNewItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel countItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton deleteItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton firstItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton previousItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox positionItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton nextItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton lastItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveItemBindingNavigator;
        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private System.Windows.Forms.TextBox iDProveedorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox iDTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private DSAll.DSAll dSAll;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAll.DSAllTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.ToolStripButton modifierItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton cancelItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton searchItemBindingNavigator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
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
    }
}