namespace InitialProject
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.clientesToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AnteriorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SiguienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UltimoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BuscarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iDClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.iDTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAll = new InitialProject.DSAll.DSAll();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.aniversarioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoDocumentoTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.TipoDocumentoTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientesToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesToolStrip
            // 
            this.clientesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrimerToolStripButton,
            this.AnteriorToolStripButton,
            this.SiguienteToolStripButton,
            this.UltimoToolStripButton,
            this.toolStripSeparator1,
            this.ModificarToolStripButton,
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.GuardarToolStripButton,
            this.CancelarToolStripButton,
            this.BuscarToolStripButton});
            this.clientesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.clientesToolStrip.Name = "clientesToolStrip";
            this.clientesToolStrip.Size = new System.Drawing.Size(884, 25);
            this.clientesToolStrip.TabIndex = 0;
            this.clientesToolStrip.Text = "toolStrip1";
            // 
            // PrimerToolStripButton
            // 
            this.PrimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrimerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrimerToolStripButton.Image")));
            this.PrimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrimerToolStripButton.Name = "PrimerToolStripButton";
            this.PrimerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrimerToolStripButton.Text = "toolStripButton1";
            this.PrimerToolStripButton.ToolTipText = "Primer Registro";
            this.PrimerToolStripButton.Click += new System.EventHandler(this.PrimerToolStripButton_Click);
            // 
            // AnteriorToolStripButton
            // 
            this.AnteriorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AnteriorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AnteriorToolStripButton.Image")));
            this.AnteriorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnteriorToolStripButton.Name = "AnteriorToolStripButton";
            this.AnteriorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AnteriorToolStripButton.Text = "toolStripButton2";
            this.AnteriorToolStripButton.ToolTipText = "Anterior Registro";
            this.AnteriorToolStripButton.Click += new System.EventHandler(this.AnteriorToolStripButton_Click);
            // 
            // SiguienteToolStripButton
            // 
            this.SiguienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SiguienteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SiguienteToolStripButton.Image")));
            this.SiguienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SiguienteToolStripButton.Name = "SiguienteToolStripButton";
            this.SiguienteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SiguienteToolStripButton.Text = "toolStripButton3";
            this.SiguienteToolStripButton.ToolTipText = "Siguiente Registro";
            this.SiguienteToolStripButton.Click += new System.EventHandler(this.SiguienteToolStripButton_Click);
            // 
            // UltimoToolStripButton
            // 
            this.UltimoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UltimoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UltimoToolStripButton.Image")));
            this.UltimoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UltimoToolStripButton.Name = "UltimoToolStripButton";
            this.UltimoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UltimoToolStripButton.Text = "toolStripButton4";
            this.UltimoToolStripButton.ToolTipText = "Ultimo registro";
            this.UltimoToolStripButton.Click += new System.EventHandler(this.UltimoToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ModificarToolStripButton
            // 
            this.ModificarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModificarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarToolStripButton.Image")));
            this.ModificarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarToolStripButton.Name = "ModificarToolStripButton";
            this.ModificarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ModificarToolStripButton.Text = "toolStripButton5";
            this.ModificarToolStripButton.ToolTipText = "Editar Registro";
            this.ModificarToolStripButton.Click += new System.EventHandler(this.ModificarToolStripButton_Click);
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NuevoToolStripButton.Text = "toolStripButton6";
            this.NuevoToolStripButton.ToolTipText = "Agregar Registro";
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BorrarToolStripButton.Text = "toolStripButton7";
            this.BorrarToolStripButton.ToolTipText = "Eliminar Registro";
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarToolStripButton.Enabled = false;
            this.GuardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton.Image")));
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GuardarToolStripButton.Text = "toolStripButton8";
            this.GuardarToolStripButton.ToolTipText = "Guardar Registro";
            this.GuardarToolStripButton.Click += new System.EventHandler(this.GuardarToolStripButton_Click);
            // 
            // CancelarToolStripButton
            // 
            this.CancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelarToolStripButton.Enabled = false;
            this.CancelarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarToolStripButton.Image")));
            this.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton.Name = "CancelarToolStripButton";
            this.CancelarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CancelarToolStripButton.Text = "toolStripButton9";
            this.CancelarToolStripButton.ToolTipText = "Cancelar Acción";
            this.CancelarToolStripButton.Click += new System.EventHandler(this.CancelarToolStripButton_Click);
            // 
            // BuscarToolStripButton
            // 
            this.BuscarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarToolStripButton.Image")));
            this.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarToolStripButton.Name = "BuscarToolStripButton";
            this.BuscarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BuscarToolStripButton.Text = "toolStripButton10";
            this.BuscarToolStripButton.ToolTipText = "Buscar";
            this.BuscarToolStripButton.Click += new System.EventHandler(this.BuscarToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Comercial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Tipo Ducumento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres Contacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Apellidos Contacto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Teléfono 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Teléfono 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Aniversario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Notas:";
            // 
            // iDClienteTextBox
            // 
            this.iDClienteTextBox.Location = new System.Drawing.Point(108, 51);
            this.iDClienteTextBox.Name = "iDClienteTextBox";
            this.iDClienteTextBox.ReadOnly = true;
            this.iDClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDClienteTextBox.TabIndex = 13;
            // 
            // nombreComercialTextBox
            // 
            this.nombreComercialTextBox.Location = new System.Drawing.Point(108, 82);
            this.nombreComercialTextBox.Name = "nombreComercialTextBox";
            this.nombreComercialTextBox.ReadOnly = true;
            this.nombreComercialTextBox.Size = new System.Drawing.Size(128, 20);
            this.nombreComercialTextBox.TabIndex = 14;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(108, 113);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(128, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(108, 144);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.ReadOnly = true;
            this.correoTextBox.Size = new System.Drawing.Size(128, 20);
            this.correoTextBox.TabIndex = 16;
            // 
            // iDTipoDocumentoComboBox
            // 
            this.iDTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
            this.iDTipoDocumentoComboBox.Enabled = false;
            this.iDTipoDocumentoComboBox.FormattingEnabled = true;
            this.iDTipoDocumentoComboBox.Location = new System.Drawing.Point(348, 51);
            this.iDTipoDocumentoComboBox.Name = "iDTipoDocumentoComboBox";
            this.iDTipoDocumentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDTipoDocumentoComboBox.TabIndex = 17;
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
            this.documentoTextBox.Location = new System.Drawing.Point(583, 50);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.ReadOnly = true;
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 18;
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.Location = new System.Drawing.Point(348, 84);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.ReadOnly = true;
            this.nombresContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresContactoTextBox.TabIndex = 19;
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(583, 83);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.ReadOnly = true;
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosContactoTextBox.TabIndex = 20;
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.Location = new System.Drawing.Point(348, 117);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.ReadOnly = true;
            this.telefono1TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono1TextBox.TabIndex = 21;
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.Location = new System.Drawing.Point(583, 115);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.ReadOnly = true;
            this.telefono2TextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono2TextBox.TabIndex = 22;
            // 
            // aniversarioDateTimePicker
            // 
            this.aniversarioDateTimePicker.Enabled = false;
            this.aniversarioDateTimePicker.Location = new System.Drawing.Point(348, 150);
            this.aniversarioDateTimePicker.Name = "aniversarioDateTimePicker";
            this.aniversarioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.aniversarioDateTimePicker.TabIndex = 23;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notasTextBox.Location = new System.Drawing.Point(108, 181);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(575, 44);
            this.notasTextBox.TabIndex = 24;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 247);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(808, 188);
            this.clienteDataGridView.TabIndex = 25;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(this.aniversarioDateTimePicker);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(this.telefono1TextBox);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(this.iDTipoDocumentoComboBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.nombreComercialTextBox);
            this.Controls.Add(this.iDClienteTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.clientesToolStrip.ResumeLayout(false);
            this.clientesToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip clientesToolStrip;
        private System.Windows.Forms.ToolStripButton PrimerToolStripButton;
        private System.Windows.Forms.ToolStripButton AnteriorToolStripButton;
        private System.Windows.Forms.ToolStripButton SiguienteToolStripButton;
        private System.Windows.Forms.ToolStripButton UltimoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarToolStripButton;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton;
        private System.Windows.Forms.ToolStripButton BuscarToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox iDClienteTextBox;
        private System.Windows.Forms.TextBox nombreComercialTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox iDTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.DateTimePicker aniversarioDateTimePicker;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private DSAll.DSAll dSAll;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAll.DSAllTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}