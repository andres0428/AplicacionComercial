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
    public partial class frmBusquedaProveedores : Form
    {
        public frmBusquedaProveedores()
        {
            InitializeComponent();
        }

        private void frmBusquedaProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void busquedaProveedoresToolStripButton_Click(object sender, EventArgs e)
        {
            string nombre, nombresContacto, apellidosContacto;

            if (contengaRadioButton.Checked == true)
            {
                nombre = "%"+ nombreToolStripTextBox.Text + "%";
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";

            }else if (empieceRadioButton.Checked == true)
            {
                nombre = nombreToolStripTextBox.Text + "%";
                nombresContacto = nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = apellidosContactoToolStripTextBox.Text + "%";

            }else if (termineRadioButton.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text;
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text;
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text;
            }
            else
            {
                nombre = nombreToolStripTextBox.Text;
                nombresContacto = nombresContactoToolStripTextBox.Text;
                apellidosContacto = apellidosContactoToolStripTextBox.Text;
            }

            try
            {
                this.proveedorTableAdapter.BusquedaProveedores(this.dSAplicacionComercial.Proveedor, 
                    nombre, 
                    nombresContacto, 
                    apellidosContacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            nombreToolStripTextBox.Text = string.Empty;
            nombresContactoToolStripTextBox.Text = string.Empty;
            apellidosContactoToolStripTextBox.Text = string.Empty;
            busquedaProveedoresToolStripButton_Click(sender, e);
        }
    }
}
