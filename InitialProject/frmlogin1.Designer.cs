namespace InitialProject
{
    partial class frmlogin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin1));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.inicioSesionLabel = new System.Windows.Forms.Label();
            this.haOlvidadoLaContrasenaLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.cerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 237);
            this.logoPanel.TabIndex = 2;
            // 
            // inicioSesionLabel
            // 
            this.inicioSesionLabel.AutoSize = true;
            this.inicioSesionLabel.Font = new System.Drawing.Font("Century Gothic", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.inicioSesionLabel.Location = new System.Drawing.Point(380, 19);
            this.inicioSesionLabel.Name = "inicioSesionLabel";
            this.inicioSesionLabel.Size = new System.Drawing.Size(181, 34);
            this.inicioSesionLabel.TabIndex = 3;
            this.inicioSesionLabel.Text = "Inicio Sesión";
            this.inicioSesionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inicioSesionLabel_MouseDown);
            // 
            // haOlvidadoLaContrasenaLabel
            // 
            this.haOlvidadoLaContrasenaLabel.AutoSize = true;
            this.haOlvidadoLaContrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haOlvidadoLaContrasenaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.haOlvidadoLaContrasenaLabel.Location = new System.Drawing.Point(351, 190);
            this.haOlvidadoLaContrasenaLabel.Name = "haOlvidadoLaContrasenaLabel";
            this.haOlvidadoLaContrasenaLabel.Size = new System.Drawing.Size(237, 21);
            this.haOlvidadoLaContrasenaLabel.TabIndex = 4;
            this.haOlvidadoLaContrasenaLabel.Text = "¿Ha olvidado su contraseña?";
            this.haOlvidadoLaContrasenaLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.haOlvidadoLaContrasenaLabel_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usuarioTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.usuarioTextBox.Location = new System.Drawing.Point(289, 73);
            this.usuarioTextBox.Multiline = true;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(380, 27);
            this.usuarioTextBox.TabIndex = 1;
            this.usuarioTextBox.Text = "JAE";
            this.usuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuarioTextBox.Enter += new System.EventHandler(this.usuarioTextBox_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // claveTextBox
            // 
            this.claveTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.claveTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.claveTextBox.Location = new System.Drawing.Point(289, 106);
            this.claveTextBox.Multiline = true;
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(380, 27);
            this.claveTextBox.TabIndex = 2;
            this.claveTextBox.Text = "123";
            this.claveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.claveTextBox.Enter += new System.EventHandler(this.claveTextBox_Enter);
            this.claveTextBox.Leave += new System.EventHandler(this.claveTextBox_Leave);
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // acceptButton
            // 
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
            this.acceptButton.Location = new System.Drawing.Point(427, 142);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(49, 45);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "...........";
            this.acceptButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(482, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(49, 45);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "...........";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minimizarPictureBox
            // 
            this.minimizarPictureBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarPictureBox.Image = global::InitialProject.Properties.Resources.minimizar20x201;
            this.minimizarPictureBox.Location = new System.Drawing.Point(646, 0);
            this.minimizarPictureBox.Name = "minimizarPictureBox";
            this.minimizarPictureBox.Size = new System.Drawing.Size(23, 28);
            this.minimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarPictureBox.TabIndex = 1;
            this.minimizarPictureBox.TabStop = false;
            this.minimizarPictureBox.Click += new System.EventHandler(this.minimizarPictureBox_Click);
            // 
            // cerrarPictureBox
            // 
            this.cerrarPictureBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPictureBox.Image = global::InitialProject.Properties.Resources._20x20cerrar21;
            this.cerrarPictureBox.Location = new System.Drawing.Point(675, 0);
            this.cerrarPictureBox.Name = "cerrarPictureBox";
            this.cerrarPictureBox.Size = new System.Drawing.Size(23, 28);
            this.cerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarPictureBox.TabIndex = 2;
            this.cerrarPictureBox.TabStop = false;
            this.cerrarPictureBox.Click += new System.EventHandler(this.cerrarPictureBox_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Image = global::InitialProject.Properties.Resources._256x256_login;
            this.logoPictureBox.Location = new System.Drawing.Point(51, 38);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(138, 159);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPictureBox_MouseDown);
            // 
            // frmlogin1
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(710, 237);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.minimizarPictureBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.cerrarPictureBox);
            this.Controls.Add(this.haOlvidadoLaContrasenaLabel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.inicioSesionLabel);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin1";
            this.Load += new System.EventHandler(this.frmlogin1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmlogin1_MouseDown);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label inicioSesionLabel;
        private System.Windows.Forms.Label haOlvidadoLaContrasenaLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PictureBox cerrarPictureBox;
        private System.Windows.Forms.PictureBox minimizarPictureBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
    }
}