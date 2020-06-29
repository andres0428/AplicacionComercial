namespace InitialProject
{
    partial class frmParametrosBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrosBodega));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bodegaBomboBox = new System.Windows.Forms.ComboBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.minimoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diasReposicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadMinimaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.dSAll = new InitialProject.DSAll.DSAll();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new InitialProject.DSAll.DSAllTableAdapters.BodegaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mínimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días Reposición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Máximo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad Mínima:";
            // 
            // bodegaBomboBox
            // 
            this.bodegaBomboBox.DataSource = this.bodegaBindingSource;
            this.bodegaBomboBox.DisplayMember = "Descripcion";
            this.bodegaBomboBox.FormattingEnabled = true;
            this.bodegaBomboBox.Location = new System.Drawing.Point(114, 18);
            this.bodegaBomboBox.Name = "bodegaBomboBox";
            this.bodegaBomboBox.Size = new System.Drawing.Size(121, 21);
            this.bodegaBomboBox.TabIndex = 6;
            this.bodegaBomboBox.ValueMember = "IDBodega";
            this.bodegaBomboBox.SelectedIndexChanged += new System.EventHandler(this.bodegaBomboBox_SelectedIndexChanged);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(356, 19);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(120, 20);
            this.stockTextBox.TabIndex = 7;
            // 
            // minimoNumericUpDown
            // 
            this.minimoNumericUpDown.Location = new System.Drawing.Point(115, 45);
            this.minimoNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.minimoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimoNumericUpDown.Name = "minimoNumericUpDown";
            this.minimoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimoNumericUpDown.TabIndex = 8;
            this.minimoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diasReposicionNumericUpDown
            // 
            this.diasReposicionNumericUpDown.Location = new System.Drawing.Point(115, 71);
            this.diasReposicionNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.diasReposicionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diasReposicionNumericUpDown.Name = "diasReposicionNumericUpDown";
            this.diasReposicionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.diasReposicionNumericUpDown.TabIndex = 9;
            this.diasReposicionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maximoNumericUpDown
            // 
            this.maximoNumericUpDown.Location = new System.Drawing.Point(356, 45);
            this.maximoNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.maximoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximoNumericUpDown.Name = "maximoNumericUpDown";
            this.maximoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maximoNumericUpDown.TabIndex = 10;
            this.maximoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cantidadMinimaNumericUpDown
            // 
            this.cantidadMinimaNumericUpDown.Location = new System.Drawing.Point(356, 71);
            this.cantidadMinimaNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.cantidadMinimaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadMinimaNumericUpDown.Name = "cantidadMinimaNumericUpDown";
            this.cantidadMinimaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadMinimaNumericUpDown.TabIndex = 11;
            this.cantidadMinimaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cancelarButton
            // 
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelarButton.Image")));
            this.cancelarButton.Location = new System.Drawing.Point(263, 119);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(49, 45);
            this.cancelarButton.TabIndex = 13;
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = ((System.Drawing.Image)(resources.GetObject("aceptarButton.Image")));
            this.aceptarButton.Location = new System.Drawing.Point(208, 119);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(49, 45);
            this.aceptarButton.TabIndex = 12;
            this.aceptarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // dSAll
            // 
            this.dSAll.DataSetName = "DSAll";
            this.dSAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAll;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmParametrosBodega
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(496, 182);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cantidadMinimaNumericUpDown);
            this.Controls.Add(this.maximoNumericUpDown);
            this.Controls.Add(this.diasReposicionNumericUpDown);
            this.Controls.Add(this.minimoNumericUpDown);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.bodegaBomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametrosBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmParametrosBodega";
            this.Load += new System.EventHandler(this.frmParametrosBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bodegaBomboBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.NumericUpDown minimoNumericUpDown;
        private System.Windows.Forms.NumericUpDown diasReposicionNumericUpDown;
        private System.Windows.Forms.NumericUpDown maximoNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadMinimaNumericUpDown;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private DSAll.DSAll dSAll;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAll.DSAllTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}