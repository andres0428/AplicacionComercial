namespace InitialProject
{
    partial class frmBusquedaClientes2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaClientes2));
            this.busquedaClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniversarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new InitialProject.DS.DSAplicacionComercial();
            this.eleccionBroupBox = new System.Windows.Forms.GroupBox();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.termineRadioButton = new System.Windows.Forms.RadioButton();
            this.empieceRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new InitialProject.DS.DSAplicacionComercialTableAdapters.ClienteTableAdapter();
            this.busquedaClientesToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreComercialToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreComercialToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.busquedaClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            this.eleccionBroupBox.SuspendLayout();
            this.busquedaClientesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // busquedaClienteDataGridView
            // 
            this.busquedaClienteDataGridView.AllowUserToAddRows = false;
            this.busquedaClienteDataGridView.AllowUserToDeleteRows = false;
            this.busquedaClienteDataGridView.AllowUserToOrderColumns = true;
            this.busquedaClienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaClienteDataGridView.AutoGenerateColumns = false;
            this.busquedaClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busquedaClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busquedaClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombreComercialDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.aniversarioDataGridViewTextBoxColumn});
            this.busquedaClienteDataGridView.DataSource = this.clienteBindingSource;
            this.busquedaClienteDataGridView.Location = new System.Drawing.Point(-2, 155);
            this.busquedaClienteDataGridView.Name = "busquedaClienteDataGridView";
            this.busquedaClienteDataGridView.ReadOnly = true;
            this.busquedaClienteDataGridView.Size = new System.Drawing.Size(845, 332);
            this.busquedaClienteDataGridView.TabIndex = 0;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nombreComercialDataGridViewTextBoxColumn
            // 
            this.nombreComercialDataGridViewTextBoxColumn.DataPropertyName = "NombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.HeaderText = "Nombre Comercial";
            this.nombreComercialDataGridViewTextBoxColumn.Name = "nombreComercialDataGridViewTextBoxColumn";
            this.nombreComercialDataGridViewTextBoxColumn.ReadOnly = true;
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
            // aniversarioDataGridViewTextBoxColumn
            // 
            this.aniversarioDataGridViewTextBoxColumn.DataPropertyName = "Aniversario";
            this.aniversarioDataGridViewTextBoxColumn.HeaderText = "Aniversario";
            this.aniversarioDataGridViewTextBoxColumn.Name = "aniversarioDataGridViewTextBoxColumn";
            this.aniversarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eleccionBroupBox
            // 
            this.eleccionBroupBox.Controls.Add(this.reiniciarButton);
            this.eleccionBroupBox.Controls.Add(this.termineRadioButton);
            this.eleccionBroupBox.Controls.Add(this.empieceRadioButton);
            this.eleccionBroupBox.Controls.Add(this.contengaRadioButton);
            this.eleccionBroupBox.Location = new System.Drawing.Point(13, 29);
            this.eleccionBroupBox.Name = "eleccionBroupBox";
            this.eleccionBroupBox.Size = new System.Drawing.Size(490, 54);
            this.eleccionBroupBox.TabIndex = 2;
            this.eleccionBroupBox.TabStop = false;
            this.eleccionBroupBox.Text = "Caracter de busqueda";
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.FlatAppearance.BorderSize = 0;
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Image = global::InitialProject.Properties.Resources.ic_cached;
            this.reiniciarButton.Location = new System.Drawing.Point(382, 10);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(70, 38);
            this.reiniciarButton.TabIndex = 3;
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // termineRadioButton
            // 
            this.termineRadioButton.AutoSize = true;
            this.termineRadioButton.Location = new System.Drawing.Point(225, 20);
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
            this.empieceRadioButton.Location = new System.Drawing.Point(116, 20);
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
            this.contengaRadioButton.Location = new System.Drawing.Point(7, 20);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Image = global::InitialProject.Properties.Resources.ic_check;
            this.buscarButton.Location = new System.Drawing.Point(643, 39);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 44);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = global::InitialProject.Properties.Resources.ic_clear;
            this.cancelarButton.Location = new System.Drawing.Point(724, 39);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 44);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // busquedaClientesToolStrip
            // 
            this.busquedaClientesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreComercialToolStripLabel,
            this.nombreComercialToolStripTextBox,
            this.nombresContactoToolStripLabel1,
            this.nombresContactoToolStripTextBox1,
            this.apellidosContactoToolStripLabel1,
            this.apellidosContactoToolStripTextBox1,
            this.busquedaClientesToolStripButton});
            this.busquedaClientesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.busquedaClientesToolStrip.Name = "busquedaClientesToolStrip";
            this.busquedaClientesToolStrip.Size = new System.Drawing.Size(842, 25);
            this.busquedaClientesToolStrip.TabIndex = 5;
            this.busquedaClientesToolStrip.Text = "busquedaClientesToolStrip";
            // 
            // nombreComercialToolStripLabel
            // 
            this.nombreComercialToolStripLabel.Name = "nombreComercialToolStripLabel";
            this.nombreComercialToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.nombreComercialToolStripLabel.Text = "NombreComercial:";
            // 
            // nombreComercialToolStripTextBox
            // 
            this.nombreComercialToolStripTextBox.Name = "nombreComercialToolStripTextBox";
            this.nombreComercialToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombresContactoToolStripLabel1
            // 
            this.nombresContactoToolStripLabel1.Name = "nombresContactoToolStripLabel1";
            this.nombresContactoToolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.nombresContactoToolStripLabel1.Text = "NombresContacto:";
            // 
            // nombresContactoToolStripTextBox1
            // 
            this.nombresContactoToolStripTextBox1.Name = "nombresContactoToolStripTextBox1";
            this.nombresContactoToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosContactoToolStripLabel1
            // 
            this.apellidosContactoToolStripLabel1.Name = "apellidosContactoToolStripLabel1";
            this.apellidosContactoToolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.apellidosContactoToolStripLabel1.Text = "ApellidosContacto:";
            // 
            // apellidosContactoToolStripTextBox1
            // 
            this.apellidosContactoToolStripTextBox1.Name = "apellidosContactoToolStripTextBox1";
            this.apellidosContactoToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // busquedaClientesToolStripButton
            // 
            this.busquedaClientesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busquedaClientesToolStripButton.Image = global::InitialProject.Properties.Resources.ic_search;
            this.busquedaClientesToolStripButton.Name = "busquedaClientesToolStripButton";
            this.busquedaClientesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.busquedaClientesToolStripButton.Text = "BusquedaClientes";
            this.busquedaClientesToolStripButton.Click += new System.EventHandler(this.busquedaClientesToolStripButton_Click);
            // 
            // frmBusquedaClientes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 488);
            this.Controls.Add(this.busquedaClientesToolStrip);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eleccionBroupBox);
            this.Controls.Add(this.busquedaClienteDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaClientes2";
            this.Text = "frmBusquedaClientes2";
            this.Load += new System.EventHandler(this.frmBusquedaClientes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busquedaClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            this.eleccionBroupBox.ResumeLayout(false);
            this.eleccionBroupBox.PerformLayout();
            this.busquedaClientesToolStrip.ResumeLayout(false);
            this.busquedaClientesToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView busquedaClienteDataGridView;
        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniversarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox eleccionBroupBox;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.RadioButton termineRadioButton;
        private System.Windows.Forms.RadioButton empieceRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ToolStrip busquedaClientesToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreComercialToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreComercialToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton busquedaClientesToolStripButton;
    }
}