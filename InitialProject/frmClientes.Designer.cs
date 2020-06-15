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
            this.AnteriorToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.SiguienteToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.UltimoToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.NuevoToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.GuardarToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.BuscarToolStripButton10 = new System.Windows.Forms.ToolStripButton();
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
            this.clientesToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesToolStrip
            // 
            this.clientesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrimerToolStripButton,
            this.AnteriorToolStripButton2,
            this.SiguienteToolStripButton3,
            this.UltimoToolStripButton4,
            this.toolStripSeparator1,
            this.ModificarToolStripButton5,
            this.NuevoToolStripButton6,
            this.BorrarToolStripButton7,
            this.GuardarToolStripButton8,
            this.CancelarToolStripButton9,
            this.BuscarToolStripButton10});
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
            // AnteriorToolStripButton2
            // 
            this.AnteriorToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AnteriorToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("AnteriorToolStripButton2.Image")));
            this.AnteriorToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnteriorToolStripButton2.Name = "AnteriorToolStripButton2";
            this.AnteriorToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.AnteriorToolStripButton2.Text = "toolStripButton2";
            this.AnteriorToolStripButton2.ToolTipText = "Anterior Registro";
            this.AnteriorToolStripButton2.Click += new System.EventHandler(this.AnteriorToolStripButton2_Click);
            // 
            // SiguienteToolStripButton3
            // 
            this.SiguienteToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SiguienteToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("SiguienteToolStripButton3.Image")));
            this.SiguienteToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SiguienteToolStripButton3.Name = "SiguienteToolStripButton3";
            this.SiguienteToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.SiguienteToolStripButton3.Text = "toolStripButton3";
            this.SiguienteToolStripButton3.ToolTipText = "Siguiente Registro";
            this.SiguienteToolStripButton3.Click += new System.EventHandler(this.SiguienteToolStripButton3_Click);
            // 
            // UltimoToolStripButton4
            // 
            this.UltimoToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UltimoToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("UltimoToolStripButton4.Image")));
            this.UltimoToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UltimoToolStripButton4.Name = "UltimoToolStripButton4";
            this.UltimoToolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.UltimoToolStripButton4.Text = "toolStripButton4";
            this.UltimoToolStripButton4.ToolTipText = "Ultimo registro";
            this.UltimoToolStripButton4.Click += new System.EventHandler(this.UltimoToolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ModificarToolStripButton5
            // 
            this.ModificarToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModificarToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ModificarToolStripButton5.Image")));
            this.ModificarToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarToolStripButton5.Name = "ModificarToolStripButton5";
            this.ModificarToolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.ModificarToolStripButton5.Text = "toolStripButton5";
            this.ModificarToolStripButton5.ToolTipText = "Editar Registro";
            this.ModificarToolStripButton5.Click += new System.EventHandler(this.ModificarToolStripButton5_Click);
            // 
            // NuevoToolStripButton6
            // 
            this.NuevoToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton6.Image")));
            this.NuevoToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton6.Name = "NuevoToolStripButton6";
            this.NuevoToolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.NuevoToolStripButton6.Text = "toolStripButton6";
            this.NuevoToolStripButton6.ToolTipText = "Agregar Registro";
            this.NuevoToolStripButton6.Click += new System.EventHandler(this.NuevoToolStripButton6_Click);
            // 
            // BorrarToolStripButton7
            // 
            this.BorrarToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarToolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton7.Image")));
            this.BorrarToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton7.Name = "BorrarToolStripButton7";
            this.BorrarToolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.BorrarToolStripButton7.Text = "toolStripButton7";
            this.BorrarToolStripButton7.ToolTipText = "Eliminar Registro";
            this.BorrarToolStripButton7.Click += new System.EventHandler(this.BorrarToolStripButton7_Click);
            // 
            // GuardarToolStripButton8
            // 
            this.GuardarToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarToolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton8.Image")));
            this.GuardarToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton8.Name = "GuardarToolStripButton8";
            this.GuardarToolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.GuardarToolStripButton8.Text = "toolStripButton8";
            this.GuardarToolStripButton8.ToolTipText = "Guardar Registro";
            this.GuardarToolStripButton8.Click += new System.EventHandler(this.GuardarToolStripButton8_Click);
            // 
            // CancelarToolStripButton9
            // 
            this.CancelarToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelarToolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("CancelarToolStripButton9.Image")));
            this.CancelarToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton9.Name = "CancelarToolStripButton9";
            this.CancelarToolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.CancelarToolStripButton9.Text = "toolStripButton9";
            this.CancelarToolStripButton9.ToolTipText = "Cancelar Acción";
            this.CancelarToolStripButton9.Click += new System.EventHandler(this.CancelarToolStripButton9_Click);
            // 
            // BuscarToolStripButton10
            // 
            this.BuscarToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarToolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("BuscarToolStripButton10.Image")));
            this.BuscarToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarToolStripButton10.Name = "BuscarToolStripButton10";
            this.BuscarToolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.BuscarToolStripButton10.Text = "toolStripButton10";
            this.BuscarToolStripButton10.ToolTipText = "Buscar";
            this.BuscarToolStripButton10.Click += new System.EventHandler(this.BuscarToolStripButton10_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip clientesToolStrip;
        private System.Windows.Forms.ToolStripButton PrimerToolStripButton;
        private System.Windows.Forms.ToolStripButton AnteriorToolStripButton2;
        private System.Windows.Forms.ToolStripButton SiguienteToolStripButton3;
        private System.Windows.Forms.ToolStripButton UltimoToolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarToolStripButton5;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton6;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton7;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton8;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton9;
        private System.Windows.Forms.ToolStripButton BuscarToolStripButton10;
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
    }
}