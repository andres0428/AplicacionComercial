using InitialProject.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialProject
{
    public partial class frmClientes : Form
    {
        private int i = 0;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAll.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAll.TipoDocumento);
            clienteDataGridView.DataSource = CADCliente.GetData();

            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            iDClienteTextBox.Text = clienteDataGridView.Rows[i].Cells["IDCliente"].Value.ToString();
            documentoTextBox.Text = clienteDataGridView.Rows[i].Cells["Documento"].Value.ToString();
            nombreComercialTextBox.Text = clienteDataGridView.Rows[i].Cells["NombreComercial"].Value.ToString();
            nombresContactoTextBox.Text = clienteDataGridView.Rows[i].Cells["NombresContacto"].Value.ToString();
            apellidosContactoTextBox.Text = clienteDataGridView.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            direccionTextBox.Text = clienteDataGridView.Rows[i].Cells["Direccion"].Value.ToString();
            telefono1TextBox.Text = clienteDataGridView.Rows[i].Cells["Telefono1"].Value.ToString();
            telefono2TextBox.Text = clienteDataGridView.Rows[i].Cells["Telefono2"].Value.ToString();
            correoTextBox.Text = clienteDataGridView.Rows[i].Cells["Correo"].Value.ToString();
            notasTextBox.Text = clienteDataGridView.Rows[i].Cells["Notas"].Value.ToString();            
            iDTipoDocumentoComboBox.SelectedValue = clienteDataGridView.Rows[i].Cells["IDTipoDocumento"].Value;
            aniversarioDateTimePicker.Value = Convert.ToDateTime (clienteDataGridView.Rows[i].Cells["Aniversario"].Value);
        }
    }
}
