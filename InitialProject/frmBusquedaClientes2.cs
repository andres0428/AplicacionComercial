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
    public partial class frmBusquedaClientes2 : Form
    {
        private int idCliente;

        public int IdCliente { get => idCliente; }

        public frmBusquedaClientes2()
        {
            InitializeComponent();
        }

        private void frmBusquedaClientes2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }

        private void busquedaClientesToolStripButton_Click(object sender, EventArgs e)
        {
            string nombreComercial, nombresContacto1, apellidosContacto1;

            if (contengaRadioButton.Checked == true)
            {
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text + "%";
                nombresContacto1 = "%" + nombresContactoToolStripTextBox1.Text + "%";
                apellidosContacto1 = "%" + apellidosContactoToolStripTextBox1.Text + "%";

            } else if (empieceRadioButton.Checked == true)
            {
                nombreComercial = nombreComercialToolStripTextBox.Text + "%";
                nombresContacto1 = nombreComercialToolStripTextBox.Text + "%";
                apellidosContacto1 = apellidosContactoToolStripTextBox1.Text + "%";

            } else if (termineRadioButton.Checked == true)
            {
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text;
                nombresContacto1 = "%" + nombresContactoToolStripTextBox1.Text;
                apellidosContacto1 = "%" + apellidosContactoToolStripTextBox1.Text;

            }
            else
            {
                nombreComercial = nombreComercialToolStripTextBox.Text;
                nombresContacto1 = nombresContactoToolStripTextBox1.Text;
                apellidosContacto1 = apellidosContactoToolStripTextBox1.Text;
            }

            try
            {
                this.clienteTableAdapter.BusquedaClientes(this.dSAplicacionComercial.Cliente,
                    nombreComercial,
                    nombresContacto1,
                    apellidosContacto1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            nombreComercialToolStripTextBox.Text = string.Empty;
            nombresContactoToolStripTextBox1.Text = string.Empty;
            apellidosContactoToolStripTextBox1.Text = string.Empty;
            busquedaClientesToolStripButton_Click(sender, e);
        }       

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (busquedaClienteDataGridView.Rows.Count == 0)
            {
                idCliente = 0;
            }
            else if (busquedaClienteDataGridView.SelectedRows.Count != 0)
            {
                idCliente = (int)busquedaClienteDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idCliente = (int)busquedaClienteDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            idCliente = 0;
            this.Close();
        }
    }
}
