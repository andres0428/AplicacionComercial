namespace InitialProject
{
    partial class frmBusquedaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedores));
            this.proveedorDataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new InitialProject.DS.DSAplicacionComercial();
            this.proveedorTableAdapter = new InitialProject.DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.busquedaProveedoresToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.busquedaProveedoresToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eleccionGroupBox = new System.Windows.Forms.GroupBox();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.termineRadioButton = new System.Windows.Forms.RadioButton();
            this.empieceRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            this.busquedaProveedoresToolStrip.SuspendLayout();
            this.eleccionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // proveedorDataGridView1
            // 
            this.proveedorDataGridView1.AllowUserToAddRows = false;
            this.proveedorDataGridView1.AllowUserToDeleteRows = false;
            this.proveedorDataGridView1.AllowUserToOrderColumns = true;
            this.proveedorDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorDataGridView1.AutoGenerateColumns = false;
            this.proveedorDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedorDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.proveedorDataGridView1.DataSource = this.proveedorBindingSource;
            this.proveedorDataGridView1.Location = new System.Drawing.Point(0, 107);
            this.proveedorDataGridView1.Name = "proveedorDataGridView1";
            this.proveedorDataGridView1.ReadOnly = true;
            this.proveedorDataGridView1.Size = new System.Drawing.Size(820, 365);
            this.proveedorDataGridView1.TabIndex = 0;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID Proveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // busquedaProveedoresToolStrip
            // 
            this.busquedaProveedoresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.nombresContactoToolStripLabel,
            this.nombresContactoToolStripTextBox,
            this.apellidosContactoToolStripLabel,
            this.apellidosContactoToolStripTextBox,
            this.busquedaProveedoresToolStripButton});
            this.busquedaProveedoresToolStrip.Location = new System.Drawing.Point(0, 0);
            this.busquedaProveedoresToolStrip.Name = "busquedaProveedoresToolStrip";
            this.busquedaProveedoresToolStrip.Size = new System.Drawing.Size(820, 25);
            this.busquedaProveedoresToolStrip.TabIndex = 1;
            this.busquedaProveedoresToolStrip.Text = "busquedaProveedoresToolStrip";
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
            // busquedaProveedoresToolStripButton
            // 
            this.busquedaProveedoresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busquedaProveedoresToolStripButton.Image = global::InitialProject.Properties.Resources.ic_search;
            this.busquedaProveedoresToolStripButton.Name = "busquedaProveedoresToolStripButton";
            this.busquedaProveedoresToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.busquedaProveedoresToolStripButton.Text = "BusquedaProveedores";
            this.busquedaProveedoresToolStripButton.Click += new System.EventHandler(this.busquedaProveedoresToolStripButton_Click);
            // 
            // eleccionGroupBox
            // 
            this.eleccionGroupBox.Controls.Add(this.reiniciarButton);
            this.eleccionGroupBox.Controls.Add(this.termineRadioButton);
            this.eleccionGroupBox.Controls.Add(this.empieceRadioButton);
            this.eleccionGroupBox.Controls.Add(this.contengaRadioButton);
            this.eleccionGroupBox.Location = new System.Drawing.Point(13, 43);
            this.eleccionGroupBox.Name = "eleccionGroupBox";
            this.eleccionGroupBox.Size = new System.Drawing.Size(480, 54);
            this.eleccionGroupBox.TabIndex = 2;
            this.eleccionGroupBox.TabStop = false;
            this.eleccionGroupBox.Text = "Caracter de busqueda";
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.FlatAppearance.BorderSize = 0;
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Image = global::InitialProject.Properties.Resources.ic_cached;
            this.reiniciarButton.Location = new System.Drawing.Point(401, 8);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(73, 42);
            this.reiniciarButton.TabIndex = 3;
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // termineRadioButton
            // 
            this.termineRadioButton.AutoSize = true;
            this.termineRadioButton.Location = new System.Drawing.Point(204, 20);
            this.termineRadioButton.Name = "termineRadioButton";
            this.termineRadioButton.Size = new System.Drawing.Size(63, 17);
            this.termineRadioButton.TabIndex = 2;
            this.termineRadioButton.TabStop = true;
            this.termineRadioButton.Text = "Termine";
            this.termineRadioButton.UseVisualStyleBackColor = true;
            // 
            // empieceRadioButton
            // 
            this.empieceRadioButton.AutoSize = true;
            this.empieceRadioButton.Location = new System.Drawing.Point(105, 20);
            this.empieceRadioButton.Name = "empieceRadioButton";
            this.empieceRadioButton.Size = new System.Drawing.Size(66, 17);
            this.empieceRadioButton.TabIndex = 1;
            this.empieceRadioButton.TabStop = true;
            this.empieceRadioButton.Text = "Empiece";
            this.empieceRadioButton.UseVisualStyleBackColor = true;
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(6, 20);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = global::InitialProject.Properties.Resources.ic_clear;
            this.cancelarButton.Location = new System.Drawing.Point(699, 44);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(60, 57);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Image = global::InitialProject.Properties.Resources.ic_check;
            this.buscarButton.Location = new System.Drawing.Point(604, 44);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(60, 57);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // frmBusquedaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eleccionGroupBox);
            this.Controls.Add(this.busquedaProveedoresToolStrip);
            this.Controls.Add(this.proveedorDataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaProveedores";
            this.Text = "frmBusquedaProveedores";
            this.Load += new System.EventHandler(this.frmBusquedaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            this.busquedaProveedoresToolStrip.ResumeLayout(false);
            this.busquedaProveedoresToolStrip.PerformLayout();
            this.eleccionGroupBox.ResumeLayout(false);
            this.eleccionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proveedorDataGridView1;
        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ToolStrip busquedaProveedoresToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton busquedaProveedoresToolStripButton;
        private System.Windows.Forms.GroupBox eleccionGroupBox;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.RadioButton termineRadioButton;
        private System.Windows.Forms.RadioButton empieceRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}