namespace InitialProject
{
    partial class frmBusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSAplicacionComercial = new InitialProject.DS.DSAplicacionComercial();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new InitialProject.DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoTableAdapter = new InitialProject.DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busquedaProveedorToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.busquedaProveedorToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.busquedaProveedorToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 263);
            this.dataGridView1.TabIndex = 0;
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
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.DataSource = this.tipoDocumentoBindingSource;
            this.iDProveedorDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProveedorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDProveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDProveedorDataGridViewTextBoxColumn.ValueMember = "IDTipoDocumento";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "ID Tipo Documento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Name = "iDTipoDocumentoDataGridViewTextBoxColumn";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresContactoDataGridViewTextBoxColumn
            // 
            this.nombresContactoDataGridViewTextBoxColumn.DataPropertyName = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.HeaderText = "Nombres Contacto";
            this.nombresContactoDataGridViewTextBoxColumn.Name = "nombresContactoDataGridViewTextBoxColumn";
            this.nombresContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "Apellidos Contacto";
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Teléfono 1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Teléfono 2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busquedaProveedorToolStrip
            // 
            this.busquedaProveedorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.nombresContactoToolStripLabel,
            this.nombresContactoToolStripTextBox,
            this.apellidosContactoToolStripLabel,
            this.apellidosContactoToolStripTextBox,
            this.busquedaProveedorToolStripButton});
            this.busquedaProveedorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.busquedaProveedorToolStrip.Name = "busquedaProveedorToolStrip";
            this.busquedaProveedorToolStrip.Size = new System.Drawing.Size(820, 25);
            this.busquedaProveedorToolStrip.TabIndex = 1;
            this.busquedaProveedorToolStrip.Text = "busquedaProveedorToolStrip";
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombresContactoToolStripLabel
            // 
            this.nombresContactoToolStripLabel.Name = "nombresContactoToolStripLabel";
            this.nombresContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.nombresContactoToolStripLabel.Text = "NombresContacto:";
            // 
            // nombresContactoToolStripTextBox
            // 
            this.nombresContactoToolStripTextBox.Name = "nombresContactoToolStripTextBox";
            this.nombresContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosContactoToolStripLabel
            // 
            this.apellidosContactoToolStripLabel.Name = "apellidosContactoToolStripLabel";
            this.apellidosContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.apellidosContactoToolStripLabel.Text = "ApellidosContacto:";
            // 
            // apellidosContactoToolStripTextBox
            // 
            this.apellidosContactoToolStripTextBox.Name = "apellidosContactoToolStripTextBox";
            this.apellidosContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // busquedaProveedorToolStripButton
            // 
            this.busquedaProveedorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.busquedaProveedorToolStripButton.Name = "busquedaProveedorToolStripButton";
            this.busquedaProveedorToolStripButton.Size = new System.Drawing.Size(117, 22);
            this.busquedaProveedorToolStripButton.Text = "BusquedaProveedor";
            this.busquedaProveedorToolStripButton.Click += new System.EventHandler(this.busquedaProveedorToolStripButton_Click);
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 469);
            this.Controls.Add(this.busquedaProveedorToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaProveedor";
            this.Text = "frmBusquedaProveedor";
            this.Load += new System.EventHandler(this.frmBusquedaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.busquedaProveedorToolStrip.ResumeLayout(false);
            this.busquedaProveedorToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip busquedaProveedorToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton busquedaProveedorToolStripButton;
    }
}