namespace InitialProject
{
    partial class frmPrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMDI));
            this.principalPanel = new System.Windows.Forms.Panel();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.tituloPanel = new System.Windows.Forms.Panel();
            this.menuVerticalPanel = new System.Windows.Forms.Panel();
            this.reportesSubMenuPanel = new System.Windows.Forms.Panel();
            this.ventaButton = new System.Windows.Forms.Button();
            this.inventariosButton = new System.Windows.Forms.Button();
            this.kardexButton = new System.Windows.Forms.Button();
            this.reportesButton = new System.Windows.Forms.Button();
            this.movimientosSubMenuPanel = new System.Windows.Forms.Panel();
            this.ventasButton = new System.Windows.Forms.Button();
            this.salidasButton = new System.Windows.Forms.Button();
            this.trasladosButton = new System.Windows.Forms.Button();
            this.devolucionesButton = new System.Windows.Forms.Button();
            this.comprasButton = new System.Windows.Forms.Button();
            this.movimientosButton = new System.Windows.Forms.Button();
            this.archivosSubMenuPanel = new System.Windows.Forms.Panel();
            this.salirButton = new System.Windows.Forms.Button();
            this.cambioClaveButton = new System.Windows.Forms.Button();
            this.cambioUsuariosButton = new System.Windows.Forms.Button();
            this.usuariosButton = new System.Windows.Forms.Button();
            this.tipoDocumentoButton = new System.Windows.Forms.Button();
            this.proveedoresButton = new System.Windows.Forms.Button();
            this.productosButton = new System.Windows.Forms.Button();
            this.clientesButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.cerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.slidePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.maximizarPictureBox = new System.Windows.Forms.PictureBox();
            this.restaurarPictureBox = new System.Windows.Forms.PictureBox();
            this.bodegaButton = new System.Windows.Forms.Button();
            this.archivoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.principalPanel.SuspendLayout();
            this.tituloPanel.SuspendLayout();
            this.menuVerticalPanel.SuspendLayout();
            this.reportesSubMenuPanel.SuspendLayout();
            this.movimientosSubMenuPanel.SuspendLayout();
            this.archivosSubMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // principalPanel
            // 
            this.principalPanel.Controls.Add(this.contenedorPanel);
            this.principalPanel.Controls.Add(this.tituloPanel);
            this.principalPanel.Controls.Add(this.menuVerticalPanel);
            this.principalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principalPanel.Location = new System.Drawing.Point(0, 0);
            this.principalPanel.Name = "principalPanel";
            this.principalPanel.Size = new System.Drawing.Size(800, 520);
            this.principalPanel.TabIndex = 0;
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.contenedorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPanel.Location = new System.Drawing.Point(200, 50);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(600, 470);
            this.contenedorPanel.TabIndex = 2;
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tituloPanel.Controls.Add(this.cerrarPictureBox);
            this.tituloPanel.Controls.Add(this.slidePictureBox);
            this.tituloPanel.Controls.Add(this.minimizarPictureBox);
            this.tituloPanel.Controls.Add(this.maximizarPictureBox);
            this.tituloPanel.Controls.Add(this.restaurarPictureBox);
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Location = new System.Drawing.Point(200, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(600, 50);
            this.tituloPanel.TabIndex = 1;
            this.tituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPanel_MouseDown);
            // 
            // menuVerticalPanel
            // 
            this.menuVerticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVerticalPanel.Controls.Add(this.reportesSubMenuPanel);
            this.menuVerticalPanel.Controls.Add(this.reportesButton);
            this.menuVerticalPanel.Controls.Add(this.movimientosSubMenuPanel);
            this.menuVerticalPanel.Controls.Add(this.movimientosButton);
            this.menuVerticalPanel.Controls.Add(this.archivosSubMenuPanel);
            this.menuVerticalPanel.Controls.Add(this.archivoButton);
            this.menuVerticalPanel.Controls.Add(this.logoPanel);
            this.menuVerticalPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVerticalPanel.Location = new System.Drawing.Point(0, 0);
            this.menuVerticalPanel.Name = "menuVerticalPanel";
            this.menuVerticalPanel.Size = new System.Drawing.Size(200, 520);
            this.menuVerticalPanel.TabIndex = 0;
            // 
            // reportesSubMenuPanel
            // 
            this.reportesSubMenuPanel.Controls.Add(this.ventaButton);
            this.reportesSubMenuPanel.Controls.Add(this.inventariosButton);
            this.reportesSubMenuPanel.Controls.Add(this.kardexButton);
            this.reportesSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportesSubMenuPanel.Location = new System.Drawing.Point(0, 494);
            this.reportesSubMenuPanel.Name = "reportesSubMenuPanel";
            this.reportesSubMenuPanel.Size = new System.Drawing.Size(200, 75);
            this.reportesSubMenuPanel.TabIndex = 6;
            // 
            // ventaButton
            // 
            this.ventaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventaButton.FlatAppearance.BorderSize = 0;
            this.ventaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaButton.ForeColor = System.Drawing.Color.White;
            this.ventaButton.Location = new System.Drawing.Point(0, 46);
            this.ventaButton.Name = "ventaButton";
            this.ventaButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ventaButton.Size = new System.Drawing.Size(200, 23);
            this.ventaButton.TabIndex = 4;
            this.ventaButton.Text = "Ventas";
            this.ventaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventaButton.UseVisualStyleBackColor = true;
            this.ventaButton.Click += new System.EventHandler(this.ventaButton_Click);
            // 
            // inventariosButton
            // 
            this.inventariosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventariosButton.FlatAppearance.BorderSize = 0;
            this.inventariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventariosButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariosButton.ForeColor = System.Drawing.Color.White;
            this.inventariosButton.Location = new System.Drawing.Point(0, 23);
            this.inventariosButton.Name = "inventariosButton";
            this.inventariosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.inventariosButton.Size = new System.Drawing.Size(200, 23);
            this.inventariosButton.TabIndex = 3;
            this.inventariosButton.Text = "Inventarios";
            this.inventariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventariosButton.UseVisualStyleBackColor = true;
            this.inventariosButton.Click += new System.EventHandler(this.inventariosButton_Click);
            // 
            // kardexButton
            // 
            this.kardexButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.kardexButton.FlatAppearance.BorderSize = 0;
            this.kardexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kardexButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardexButton.ForeColor = System.Drawing.Color.White;
            this.kardexButton.Location = new System.Drawing.Point(0, 0);
            this.kardexButton.Name = "kardexButton";
            this.kardexButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.kardexButton.Size = new System.Drawing.Size(200, 23);
            this.kardexButton.TabIndex = 2;
            this.kardexButton.Text = "kardex";
            this.kardexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kardexButton.UseVisualStyleBackColor = true;
            this.kardexButton.Click += new System.EventHandler(this.kardexButton_Click);
            // 
            // reportesButton
            // 
            this.reportesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportesButton.FlatAppearance.BorderSize = 0;
            this.reportesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportesButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesButton.ForeColor = System.Drawing.Color.White;
            this.reportesButton.Location = new System.Drawing.Point(0, 466);
            this.reportesButton.Name = "reportesButton";
            this.reportesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportesButton.Size = new System.Drawing.Size(200, 28);
            this.reportesButton.TabIndex = 5;
            this.reportesButton.Text = "Reportes";
            this.reportesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesButton.UseVisualStyleBackColor = true;
            this.reportesButton.Click += new System.EventHandler(this.reportesButton_Click);
            // 
            // movimientosSubMenuPanel
            // 
            this.movimientosSubMenuPanel.Controls.Add(this.ventasButton);
            this.movimientosSubMenuPanel.Controls.Add(this.salidasButton);
            this.movimientosSubMenuPanel.Controls.Add(this.trasladosButton);
            this.movimientosSubMenuPanel.Controls.Add(this.devolucionesButton);
            this.movimientosSubMenuPanel.Controls.Add(this.comprasButton);
            this.movimientosSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movimientosSubMenuPanel.Location = new System.Drawing.Point(0, 346);
            this.movimientosSubMenuPanel.Name = "movimientosSubMenuPanel";
            this.movimientosSubMenuPanel.Size = new System.Drawing.Size(200, 120);
            this.movimientosSubMenuPanel.TabIndex = 4;
            // 
            // ventasButton
            // 
            this.ventasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventasButton.FlatAppearance.BorderSize = 0;
            this.ventasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventasButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasButton.ForeColor = System.Drawing.Color.White;
            this.ventasButton.Location = new System.Drawing.Point(0, 92);
            this.ventasButton.Name = "ventasButton";
            this.ventasButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ventasButton.Size = new System.Drawing.Size(200, 23);
            this.ventasButton.TabIndex = 6;
            this.ventasButton.Text = "Ventas";
            this.ventasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventasButton.UseVisualStyleBackColor = true;
            this.ventasButton.Click += new System.EventHandler(this.ventasButton_Click);
            // 
            // salidasButton
            // 
            this.salidasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salidasButton.FlatAppearance.BorderSize = 0;
            this.salidasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salidasButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasButton.ForeColor = System.Drawing.Color.White;
            this.salidasButton.Location = new System.Drawing.Point(0, 69);
            this.salidasButton.Name = "salidasButton";
            this.salidasButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salidasButton.Size = new System.Drawing.Size(200, 23);
            this.salidasButton.TabIndex = 5;
            this.salidasButton.Text = "Salidas";
            this.salidasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salidasButton.UseVisualStyleBackColor = true;
            this.salidasButton.Click += new System.EventHandler(this.salidasButton_Click);
            // 
            // trasladosButton
            // 
            this.trasladosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.trasladosButton.FlatAppearance.BorderSize = 0;
            this.trasladosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trasladosButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasladosButton.ForeColor = System.Drawing.Color.White;
            this.trasladosButton.Location = new System.Drawing.Point(0, 46);
            this.trasladosButton.Name = "trasladosButton";
            this.trasladosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.trasladosButton.Size = new System.Drawing.Size(200, 23);
            this.trasladosButton.TabIndex = 4;
            this.trasladosButton.Text = "Traslados";
            this.trasladosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trasladosButton.UseVisualStyleBackColor = true;
            this.trasladosButton.Click += new System.EventHandler(this.trasladosButton_Click);
            // 
            // devolucionesButton
            // 
            this.devolucionesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devolucionesButton.FlatAppearance.BorderSize = 0;
            this.devolucionesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devolucionesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolucionesButton.ForeColor = System.Drawing.Color.White;
            this.devolucionesButton.Location = new System.Drawing.Point(0, 23);
            this.devolucionesButton.Name = "devolucionesButton";
            this.devolucionesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.devolucionesButton.Size = new System.Drawing.Size(200, 23);
            this.devolucionesButton.TabIndex = 3;
            this.devolucionesButton.Text = "Devoluciones";
            this.devolucionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devolucionesButton.UseVisualStyleBackColor = true;
            this.devolucionesButton.Click += new System.EventHandler(this.devolucionesButton_Click);
            // 
            // comprasButton
            // 
            this.comprasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.comprasButton.FlatAppearance.BorderSize = 0;
            this.comprasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprasButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasButton.ForeColor = System.Drawing.Color.White;
            this.comprasButton.Location = new System.Drawing.Point(0, 0);
            this.comprasButton.Name = "comprasButton";
            this.comprasButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.comprasButton.Size = new System.Drawing.Size(200, 23);
            this.comprasButton.TabIndex = 2;
            this.comprasButton.Text = "Compras";
            this.comprasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasButton.UseVisualStyleBackColor = true;
            this.comprasButton.Click += new System.EventHandler(this.comprasButton_Click);
            // 
            // movimientosButton
            // 
            this.movimientosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.movimientosButton.FlatAppearance.BorderSize = 0;
            this.movimientosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimientosButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosButton.ForeColor = System.Drawing.Color.White;
            this.movimientosButton.Location = new System.Drawing.Point(0, 316);
            this.movimientosButton.Name = "movimientosButton";
            this.movimientosButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.movimientosButton.Size = new System.Drawing.Size(200, 30);
            this.movimientosButton.TabIndex = 3;
            this.movimientosButton.Text = "Movimientos";
            this.movimientosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimientosButton.UseVisualStyleBackColor = true;
            this.movimientosButton.Click += new System.EventHandler(this.movimientosButton_Click);
            // 
            // archivosSubMenuPanel
            // 
            this.archivosSubMenuPanel.Controls.Add(this.salirButton);
            this.archivosSubMenuPanel.Controls.Add(this.cambioClaveButton);
            this.archivosSubMenuPanel.Controls.Add(this.cambioUsuariosButton);
            this.archivosSubMenuPanel.Controls.Add(this.usuariosButton);
            this.archivosSubMenuPanel.Controls.Add(this.tipoDocumentoButton);
            this.archivosSubMenuPanel.Controls.Add(this.proveedoresButton);
            this.archivosSubMenuPanel.Controls.Add(this.productosButton);
            this.archivosSubMenuPanel.Controls.Add(this.clientesButton);
            this.archivosSubMenuPanel.Controls.Add(this.bodegaButton);
            this.archivosSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.archivosSubMenuPanel.Location = new System.Drawing.Point(0, 104);
            this.archivosSubMenuPanel.Name = "archivosSubMenuPanel";
            this.archivosSubMenuPanel.Size = new System.Drawing.Size(200, 212);
            this.archivosSubMenuPanel.TabIndex = 2;
            // 
            // salirButton
            // 
            this.salirButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salirButton.FlatAppearance.BorderSize = 0;
            this.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.ForeColor = System.Drawing.Color.White;
            this.salirButton.Location = new System.Drawing.Point(0, 184);
            this.salirButton.Name = "salirButton";
            this.salirButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salirButton.Size = new System.Drawing.Size(200, 23);
            this.salirButton.TabIndex = 10;
            this.salirButton.Text = "Salir";
            this.salirButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // cambioClaveButton
            // 
            this.cambioClaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cambioClaveButton.FlatAppearance.BorderSize = 0;
            this.cambioClaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambioClaveButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioClaveButton.ForeColor = System.Drawing.Color.White;
            this.cambioClaveButton.Location = new System.Drawing.Point(0, 161);
            this.cambioClaveButton.Name = "cambioClaveButton";
            this.cambioClaveButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cambioClaveButton.Size = new System.Drawing.Size(200, 23);
            this.cambioClaveButton.TabIndex = 9;
            this.cambioClaveButton.Text = "Cambio Clave";
            this.cambioClaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioClaveButton.UseVisualStyleBackColor = true;
            this.cambioClaveButton.Click += new System.EventHandler(this.cambioClaveButton_Click);
            // 
            // cambioUsuariosButton
            // 
            this.cambioUsuariosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cambioUsuariosButton.FlatAppearance.BorderSize = 0;
            this.cambioUsuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambioUsuariosButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioUsuariosButton.ForeColor = System.Drawing.Color.White;
            this.cambioUsuariosButton.Location = new System.Drawing.Point(0, 138);
            this.cambioUsuariosButton.Name = "cambioUsuariosButton";
            this.cambioUsuariosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cambioUsuariosButton.Size = new System.Drawing.Size(200, 23);
            this.cambioUsuariosButton.TabIndex = 8;
            this.cambioUsuariosButton.Text = "Cambio Usuarios";
            this.cambioUsuariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioUsuariosButton.UseVisualStyleBackColor = true;
            this.cambioUsuariosButton.Click += new System.EventHandler(this.cambioUsuariosButton_Click);
            // 
            // usuariosButton
            // 
            this.usuariosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuariosButton.FlatAppearance.BorderSize = 0;
            this.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosButton.ForeColor = System.Drawing.Color.White;
            this.usuariosButton.Location = new System.Drawing.Point(0, 115);
            this.usuariosButton.Name = "usuariosButton";
            this.usuariosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.usuariosButton.Size = new System.Drawing.Size(200, 23);
            this.usuariosButton.TabIndex = 7;
            this.usuariosButton.Text = "Usuarios";
            this.usuariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuariosButton.UseVisualStyleBackColor = true;
            this.usuariosButton.Click += new System.EventHandler(this.usuariosButton_Click);
            // 
            // tipoDocumentoButton
            // 
            this.tipoDocumentoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipoDocumentoButton.FlatAppearance.BorderSize = 0;
            this.tipoDocumentoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoDocumentoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDocumentoButton.ForeColor = System.Drawing.Color.White;
            this.tipoDocumentoButton.Location = new System.Drawing.Point(0, 92);
            this.tipoDocumentoButton.Name = "tipoDocumentoButton";
            this.tipoDocumentoButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.tipoDocumentoButton.Size = new System.Drawing.Size(200, 23);
            this.tipoDocumentoButton.TabIndex = 6;
            this.tipoDocumentoButton.Text = "Tipo Documeto";
            this.tipoDocumentoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoDocumentoButton.UseVisualStyleBackColor = true;
            this.tipoDocumentoButton.Click += new System.EventHandler(this.tipoDocumentoButton_Click);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.proveedoresButton.FlatAppearance.BorderSize = 0;
            this.proveedoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedoresButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresButton.ForeColor = System.Drawing.Color.White;
            this.proveedoresButton.Location = new System.Drawing.Point(0, 69);
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.proveedoresButton.Size = new System.Drawing.Size(200, 23);
            this.proveedoresButton.TabIndex = 5;
            this.proveedoresButton.Text = "Proveedores";
            this.proveedoresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresButton.UseVisualStyleBackColor = true;
            this.proveedoresButton.Click += new System.EventHandler(this.proveedoresButton_Click);
            // 
            // productosButton
            // 
            this.productosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productosButton.FlatAppearance.BorderSize = 0;
            this.productosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productosButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosButton.ForeColor = System.Drawing.Color.White;
            this.productosButton.Location = new System.Drawing.Point(0, 46);
            this.productosButton.Name = "productosButton";
            this.productosButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.productosButton.Size = new System.Drawing.Size(200, 23);
            this.productosButton.TabIndex = 4;
            this.productosButton.Text = "Productos";
            this.productosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosButton.UseVisualStyleBackColor = true;
            this.productosButton.Click += new System.EventHandler(this.productosButton_Click);
            // 
            // clientesButton
            // 
            this.clientesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientesButton.FlatAppearance.BorderSize = 0;
            this.clientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButton.ForeColor = System.Drawing.Color.White;
            this.clientesButton.Location = new System.Drawing.Point(0, 23);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.clientesButton.Size = new System.Drawing.Size(200, 23);
            this.clientesButton.TabIndex = 3;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 78);
            this.logoPanel.TabIndex = 0;
            // 
            // cerrarPictureBox
            // 
            this.cerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPictureBox.Image = global::InitialProject.Properties.Resources.cerrar32x32Color;
            this.cerrarPictureBox.Location = new System.Drawing.Point(558, 9);
            this.cerrarPictureBox.Name = "cerrarPictureBox";
            this.cerrarPictureBox.Size = new System.Drawing.Size(35, 35);
            this.cerrarPictureBox.TabIndex = 3;
            this.cerrarPictureBox.TabStop = false;
            this.cerrarPictureBox.Click += new System.EventHandler(this.cerrarPictureBox_Click);
            // 
            // slidePictureBox
            // 
            this.slidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidePictureBox.Image = global::InitialProject.Properties.Resources.submenuGriss64x64;
            this.slidePictureBox.Location = new System.Drawing.Point(7, 8);
            this.slidePictureBox.Name = "slidePictureBox";
            this.slidePictureBox.Size = new System.Drawing.Size(35, 35);
            this.slidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slidePictureBox.TabIndex = 0;
            this.slidePictureBox.TabStop = false;
            this.slidePictureBox.Click += new System.EventHandler(this.slidePictureBox_Click);
            // 
            // minimizarPictureBox
            // 
            this.minimizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarPictureBox.Image = global::InitialProject.Properties.Resources._32x32minimizarColor;
            this.minimizarPictureBox.Location = new System.Drawing.Point(474, 9);
            this.minimizarPictureBox.Name = "minimizarPictureBox";
            this.minimizarPictureBox.Size = new System.Drawing.Size(35, 35);
            this.minimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarPictureBox.TabIndex = 2;
            this.minimizarPictureBox.TabStop = false;
            this.minimizarPictureBox.Click += new System.EventHandler(this.minimizarPictureBox_Click);
            // 
            // maximizarPictureBox
            // 
            this.maximizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarPictureBox.Image = global::InitialProject.Properties.Resources.restaurar32x32Color;
            this.maximizarPictureBox.Location = new System.Drawing.Point(517, 9);
            this.maximizarPictureBox.Name = "maximizarPictureBox";
            this.maximizarPictureBox.Size = new System.Drawing.Size(35, 35);
            this.maximizarPictureBox.TabIndex = 1;
            this.maximizarPictureBox.TabStop = false;
            this.maximizarPictureBox.Click += new System.EventHandler(this.maximizarPictureBox_Click);
            // 
            // restaurarPictureBox
            // 
            this.restaurarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurarPictureBox.Image = global::InitialProject.Properties.Resources.restaurar_32x32;
            this.restaurarPictureBox.Location = new System.Drawing.Point(517, 9);
            this.restaurarPictureBox.Name = "restaurarPictureBox";
            this.restaurarPictureBox.Size = new System.Drawing.Size(35, 35);
            this.restaurarPictureBox.TabIndex = 0;
            this.restaurarPictureBox.TabStop = false;
            this.restaurarPictureBox.Visible = false;
            this.restaurarPictureBox.Click += new System.EventHandler(this.restaurarPictureBox_Click);
            // 
            // bodegaButton
            // 
            this.bodegaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodegaButton.FlatAppearance.BorderSize = 0;
            this.bodegaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodegaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodegaButton.ForeColor = System.Drawing.Color.White;
            this.bodegaButton.Image = global::InitialProject.Properties.Resources.bodegaNegro20x20;
            this.bodegaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bodegaButton.Location = new System.Drawing.Point(0, 0);
            this.bodegaButton.Name = "bodegaButton";
            this.bodegaButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bodegaButton.Size = new System.Drawing.Size(200, 23);
            this.bodegaButton.TabIndex = 2;
            this.bodegaButton.Text = "Bodega";
            this.bodegaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bodegaButton.UseVisualStyleBackColor = true;
            this.bodegaButton.Click += new System.EventHandler(this.bodegaButton_Click);
            // 
            // archivoButton
            // 
            this.archivoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.archivoButton.FlatAppearance.BorderSize = 0;
            this.archivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archivoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoButton.ForeColor = System.Drawing.Color.White;
            this.archivoButton.Image = global::InitialProject.Properties.Resources.archivoNegroRe20x20;
            this.archivoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archivoButton.Location = new System.Drawing.Point(0, 78);
            this.archivoButton.Name = "archivoButton";
            this.archivoButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.archivoButton.Size = new System.Drawing.Size(200, 26);
            this.archivoButton.TabIndex = 1;
            this.archivoButton.Text = "Archivo";
            this.archivoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archivoButton.UseVisualStyleBackColor = true;
            this.archivoButton.Click += new System.EventHandler(this.archivoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InitialProject.Properties.Resources.buho_orignal_sinDonfondo_letrasBlancas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.principalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "frmPrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipalMDI";
            this.principalPanel.ResumeLayout(false);
            this.tituloPanel.ResumeLayout(false);
            this.menuVerticalPanel.ResumeLayout(false);
            this.reportesSubMenuPanel.ResumeLayout(false);
            this.movimientosSubMenuPanel.ResumeLayout(false);
            this.archivosSubMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel principalPanel;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.PictureBox cerrarPictureBox;
        private System.Windows.Forms.PictureBox minimizarPictureBox;
        private System.Windows.Forms.PictureBox maximizarPictureBox;
        private System.Windows.Forms.PictureBox restaurarPictureBox;
        private System.Windows.Forms.Panel tituloPanel;
        private System.Windows.Forms.PictureBox slidePictureBox;
        private System.Windows.Forms.Panel menuVerticalPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel archivosSubMenuPanel;
        private System.Windows.Forms.Button bodegaButton;
        private System.Windows.Forms.Button archivoButton;
        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button productosButton;
        private System.Windows.Forms.Button proveedoresButton;
        private System.Windows.Forms.Button tipoDocumentoButton;
        private System.Windows.Forms.Button usuariosButton;
        private System.Windows.Forms.Button cambioUsuariosButton;
        private System.Windows.Forms.Button cambioClaveButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button movimientosButton;
        private System.Windows.Forms.Panel movimientosSubMenuPanel;
        private System.Windows.Forms.Button ventasButton;
        private System.Windows.Forms.Button salidasButton;
        private System.Windows.Forms.Button trasladosButton;
        private System.Windows.Forms.Button devolucionesButton;
        private System.Windows.Forms.Button comprasButton;
        private System.Windows.Forms.Button reportesButton;
        private System.Windows.Forms.Panel reportesSubMenuPanel;
        private System.Windows.Forms.Button ventaButton;
        private System.Windows.Forms.Button inventariosButton;
        private System.Windows.Forms.Button kardexButton;
    }
}