namespace InitialProject
{
    partial class frmProductos
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
            System.Windows.Forms.Label iDDepartamentoLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label iDMedidaLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label notasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSAll = new InitialProject.DSAll.DSAll();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new InitialProject.DSAll.DSAllTableAdapters.TableAdapterManager();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.addNewItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.countItemBindingNavigator = new System.Windows.Forms.ToolStripLabel();
            this.deleteItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.firstItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.positionItemBindingNavigator = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nextItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.lastItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.saveItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.cancelItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.searchItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iDDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.DepartamentoTableAdapter();
            this.iVATableAdapter = new InitialProject.DSAll.DSAllTableAdapters.IVATableAdapter();
            this.medidaTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.MedidaTableAdapter();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.bucarImagenButton = new System.Windows.Forms.Button();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraGroupBox = new System.Windows.Forms.GroupBox();
            this.bodegaGroupBox = new System.Windows.Forms.GroupBox();
            this.barraDataGridView = new System.Windows.Forms.DataGridView();
            this.bodegaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.barraTextBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.agregarBodegaButton = new System.Windows.Forms.Button();
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barraTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.BarraTableAdapter();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaProductoTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.BodegaProductoTableAdapter();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDepartamentoLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            iDMedidaLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.codigoBarraGroupBox.SuspendLayout();
            this.bodegaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDepartamentoLabel
            // 
            iDDepartamentoLabel.AutoSize = true;
            iDDepartamentoLabel.Location = new System.Drawing.Point(10, 52);
            iDDepartamentoLabel.Name = "iDDepartamentoLabel";
            iDDepartamentoLabel.Size = new System.Drawing.Size(88, 13);
            iDDepartamentoLabel.TabIndex = 2;
            iDDepartamentoLabel.Text = "IDDepartamento:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(281, 52);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(38, 13);
            iDIVALabel.TabIndex = 4;
            iDIVALabel.Text = "IDIVA:";
            // 
            // iDMedidaLabel
            // 
            iDMedidaLabel.AutoSize = true;
            iDMedidaLabel.Location = new System.Drawing.Point(475, 53);
            iDMedidaLabel.Name = "iDMedidaLabel";
            iDMedidaLabel.Size = new System.Drawing.Size(56, 13);
            iDMedidaLabel.TabIndex = 6;
            iDMedidaLabel.Text = "IDMedida:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(34, 78);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(64, 13);
            iDProductoLabel.TabIndex = 8;
            iDProductoLabel.Text = "IDProducto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(253, 78);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 10;
            descripcionLabel.Text = "Descripcion:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(486, 79);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(45, 13);
            medidaLabel.TabIndex = 12;
            medidaLabel.Text = "Medida:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(58, 104);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 14;
            precioLabel.Text = "Precio:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(274, 104);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(45, 13);
            imagenLabel.TabIndex = 16;
            imagenLabel.Text = "Imagen:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(60, 130);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 18;
            notasLabel.Text = "Notas:";
            // 
            // dSAll
            // 
            this.dSAll.DataSetName = "DSAll";
            this.dSAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSAll;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraDetalleTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.KardexTableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SalidaDetalleTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.TrasladoDetalleTableAdapter = null;
            this.tableAdapterManager.TrasladoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InitialProject.DSAll.DSAllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VentaDetalleTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.addNewItemBindingNavigator;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.countItemBindingNavigator;
            this.productoBindingNavigator.DeleteItem = this.deleteItemBindingNavigator;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItemBindingNavigator,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.positionItemBindingNavigator,
            this.countItemBindingNavigator,
            this.bindingNavigatorSeparator1,
            this.nextItemBindingNavigator,
            this.lastItemBindingNavigator,
            this.bindingNavigatorSeparator2,
            this.editItemBindingNavigator,
            this.addNewItemBindingNavigator,
            this.deleteItemBindingNavigator,
            this.saveItemBindingNavigator,
            this.cancelItemBindingNavigator,
            this.searchItemBindingNavigator});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.firstItemBindingNavigator;
            this.productoBindingNavigator.MoveLastItem = this.lastItemBindingNavigator;
            this.productoBindingNavigator.MoveNextItem = this.nextItemBindingNavigator;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.positionItemBindingNavigator;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1028, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // addNewItemBindingNavigator
            // 
            this.addNewItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemBindingNavigator.Image")));
            this.addNewItemBindingNavigator.Name = "addNewItemBindingNavigator";
            this.addNewItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.addNewItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.addNewItemBindingNavigator.Text = "Add new";
            // 
            // countItemBindingNavigator
            // 
            this.countItemBindingNavigator.Name = "countItemBindingNavigator";
            this.countItemBindingNavigator.Size = new System.Drawing.Size(35, 22);
            this.countItemBindingNavigator.Text = "of {0}";
            this.countItemBindingNavigator.ToolTipText = "Total number of items";
            // 
            // deleteItemBindingNavigator
            // 
            this.deleteItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemBindingNavigator.Image")));
            this.deleteItemBindingNavigator.Name = "deleteItemBindingNavigator";
            this.deleteItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.deleteItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.deleteItemBindingNavigator.Text = "Delete";
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
            // editItemBindingNavigator
            // 
            this.editItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("editItemBindingNavigator.Image")));
            this.editItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editItemBindingNavigator.Name = "editItemBindingNavigator";
            this.editItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.editItemBindingNavigator.Text = "toolStripButton1";
            // 
            // saveItemBindingNavigator
            // 
            this.saveItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveItemBindingNavigator.Enabled = false;
            this.saveItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("saveItemBindingNavigator.Image")));
            this.saveItemBindingNavigator.Name = "saveItemBindingNavigator";
            this.saveItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.saveItemBindingNavigator.Text = "Save Data";
            this.saveItemBindingNavigator.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // cancelItemBindingNavigator
            // 
            this.cancelItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelItemBindingNavigator.Enabled = false;
            this.cancelItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("cancelItemBindingNavigator.Image")));
            this.cancelItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelItemBindingNavigator.Name = "cancelItemBindingNavigator";
            this.cancelItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.cancelItemBindingNavigator.Text = "toolStripButton2";
            // 
            // searchItemBindingNavigator
            // 
            this.searchItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchItemBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("searchItemBindingNavigator.Image")));
            this.searchItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchItemBindingNavigator.Name = "searchItemBindingNavigator";
            this.searchItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.searchItemBindingNavigator.Text = "toolStripButton3";
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToOrderColumns = true;
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(0, 394);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(1028, 246);
            this.productoDataGridView.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // iDDepartamentoComboBox
            // 
            this.iDDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDDepartamento", true));
            this.iDDepartamentoComboBox.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoComboBox.DisplayMember = "Descripcion";
            this.iDDepartamentoComboBox.FormattingEnabled = true;
            this.iDDepartamentoComboBox.Location = new System.Drawing.Point(104, 48);
            this.iDDepartamentoComboBox.Name = "iDDepartamentoComboBox";
            this.iDDepartamentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDDepartamentoComboBox.TabIndex = 3;
            this.iDDepartamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSAll;
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(325, 48);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDIVAComboBox.TabIndex = 5;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSAll;
            // 
            // iDMedidaComboBox
            // 
            this.iDMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDMedida", true));
            this.iDMedidaComboBox.DataSource = this.medidaBindingSource;
            this.iDMedidaComboBox.DisplayMember = "Descripcion";
            this.iDMedidaComboBox.FormattingEnabled = true;
            this.iDMedidaComboBox.Location = new System.Drawing.Point(537, 49);
            this.iDMedidaComboBox.Name = "iDMedidaComboBox";
            this.iDMedidaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDMedidaComboBox.TabIndex = 7;
            this.iDMedidaComboBox.ValueMember = "IDMedida";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dSAll;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(104, 75);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.Size = new System.Drawing.Size(121, 20);
            this.iDProductoTextBox.TabIndex = 9;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(325, 75);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descripcionTextBox.TabIndex = 11;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(537, 76);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.Size = new System.Drawing.Size(121, 20);
            this.medidaTextBox.TabIndex = 13;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(104, 101);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 15;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(325, 101);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.Size = new System.Drawing.Size(121, 20);
            this.imagenTextBox.TabIndex = 17;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(104, 127);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(342, 48);
            this.notasTextBox.TabIndex = 19;
            // 
            // bucarImagenButton
            // 
            this.bucarImagenButton.FlatAppearance.BorderSize = 0;
            this.bucarImagenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bucarImagenButton.Image = ((System.Drawing.Image)(resources.GetObject("bucarImagenButton.Image")));
            this.bucarImagenButton.Location = new System.Drawing.Point(452, 104);
            this.bucarImagenButton.Name = "bucarImagenButton";
            this.bucarImagenButton.Size = new System.Drawing.Size(79, 71);
            this.bucarImagenButton.TabIndex = 20;
            this.bucarImagenButton.UseVisualStyleBackColor = true;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.Location = new System.Drawing.Point(537, 104);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(121, 71);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenPictureBox.TabIndex = 21;
            this.imagenPictureBox.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.DataSource = this.departamentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDDepartamento";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Imagen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Imagen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDMedida";
            this.dataGridViewTextBoxColumn8.DataSource = this.medidaBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID Medida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDMedida";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // codigoBarraGroupBox
            // 
            this.codigoBarraGroupBox.Controls.Add(this.eliminarButton);
            this.codigoBarraGroupBox.Controls.Add(this.agregarButton);
            this.codigoBarraGroupBox.Controls.Add(this.barraTextBox);
            this.codigoBarraGroupBox.Controls.Add(this.label1);
            this.codigoBarraGroupBox.Controls.Add(this.barraDataGridView);
            this.codigoBarraGroupBox.Location = new System.Drawing.Point(0, 191);
            this.codigoBarraGroupBox.Name = "codigoBarraGroupBox";
            this.codigoBarraGroupBox.Size = new System.Drawing.Size(310, 197);
            this.codigoBarraGroupBox.TabIndex = 22;
            this.codigoBarraGroupBox.TabStop = false;
            this.codigoBarraGroupBox.Text = "Código Barra";
            // 
            // bodegaGroupBox
            // 
            this.bodegaGroupBox.Controls.Add(this.agregarBodegaButton);
            this.bodegaGroupBox.Controls.Add(this.bodegaDataGridView);
            this.bodegaGroupBox.Location = new System.Drawing.Point(346, 191);
            this.bodegaGroupBox.Name = "bodegaGroupBox";
            this.bodegaGroupBox.Size = new System.Drawing.Size(682, 191);
            this.bodegaGroupBox.TabIndex = 23;
            this.bodegaGroupBox.TabStop = false;
            this.bodegaGroupBox.Text = "Bodegas";
            // 
            // barraDataGridView
            // 
            this.barraDataGridView.AllowUserToAddRows = false;
            this.barraDataGridView.AllowUserToDeleteRows = false;
            this.barraDataGridView.AllowUserToOrderColumns = true;
            this.barraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraDataGridView.AutoGenerateColumns = false;
            this.barraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.barraDataGridViewTextBoxColumn});
            this.barraDataGridView.DataSource = this.barraBindingSource;
            this.barraDataGridView.Location = new System.Drawing.Point(6, 87);
            this.barraDataGridView.Name = "barraDataGridView";
            this.barraDataGridView.ReadOnly = true;
            this.barraDataGridView.Size = new System.Drawing.Size(298, 104);
            this.barraDataGridView.TabIndex = 0;
            // 
            // bodegaDataGridView
            // 
            this.bodegaDataGridView.AllowUserToAddRows = false;
            this.bodegaDataGridView.AllowUserToDeleteRows = false;
            this.bodegaDataGridView.AllowUserToOrderColumns = true;
            this.bodegaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodegaDataGridView.AutoGenerateColumns = false;
            this.bodegaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bodegaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bodegaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.bodegaDataGridView.DataSource = this.bodegaProductoBindingSource;
            this.bodegaDataGridView.Location = new System.Drawing.Point(19, 87);
            this.bodegaDataGridView.Name = "bodegaDataGridView";
            this.bodegaDataGridView.ReadOnly = true;
            this.bodegaDataGridView.Size = new System.Drawing.Size(657, 98);
            this.bodegaDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barra";
            // 
            // barraTextBox
            // 
            this.barraTextBox.Location = new System.Drawing.Point(48, 32);
            this.barraTextBox.Name = "barraTextBox";
            this.barraTextBox.Size = new System.Drawing.Size(100, 20);
            this.barraTextBox.TabIndex = 2;
            // 
            // agregarButton
            // 
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.Location = new System.Drawing.Point(196, 19);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(40, 40);
            this.agregarButton.TabIndex = 3;
            this.agregarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarButton.Image")));
            this.eliminarButton.Location = new System.Drawing.Point(243, 21);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(40, 40);
            this.eliminarButton.TabIndex = 4;
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // agregarBodegaButton
            // 
            this.agregarBodegaButton.FlatAppearance.BorderSize = 0;
            this.agregarBodegaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBodegaButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarBodegaButton.Image")));
            this.agregarBodegaButton.Location = new System.Drawing.Point(361, 21);
            this.agregarBodegaButton.Name = "agregarBodegaButton";
            this.agregarBodegaButton.Size = new System.Drawing.Size(40, 40);
            this.agregarBodegaButton.TabIndex = 4;
            this.agregarBodegaButton.UseVisualStyleBackColor = true;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "Barra";
            this.barraBindingSource.DataSource = this.dSAll;
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dSAll;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn1
            // 
            this.iDProductoDataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.Name = "iDProductoDataGridViewTextBoxColumn1";
            this.iDProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Minimo";
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Maximo";
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 652);
            this.Controls.Add(this.bodegaGroupBox);
            this.Controls.Add(this.codigoBarraGroupBox);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.bucarImagenButton);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(this.medidaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(iDMedidaLabel);
            this.Controls.Add(this.iDMedidaComboBox);
            this.Controls.Add(iDIVALabel);
            this.Controls.Add(this.iDIVAComboBox);
            this.Controls.Add(iDDepartamentoLabel);
            this.Controls.Add(this.iDDepartamentoComboBox);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.codigoBarraGroupBox.ResumeLayout(false);
            this.codigoBarraGroupBox.PerformLayout();
            this.bodegaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAll.DSAll dSAll;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSAll.DSAllTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DSAll.DSAllTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton addNewItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel countItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton deleteItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton firstItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox positionItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton nextItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton lastItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveItemBindingNavigator;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.ToolStripButton editItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton cancelItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton searchItemBindingNavigator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox iDMedidaComboBox;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.ComboBox iDDepartamentoComboBox;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAll.DSAllTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSAll.DSAllTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DSAll.DSAllTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.Button bucarImagenButton;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox bodegaGroupBox;
        private System.Windows.Forms.Button agregarBodegaButton;
        private System.Windows.Forms.DataGridView bodegaDataGridView;
        private System.Windows.Forms.GroupBox codigoBarraGroupBox;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox barraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView barraDataGridView;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private DSAll.DSAllTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DSAll.DSAllTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
    }
}