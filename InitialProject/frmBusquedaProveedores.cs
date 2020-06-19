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
            try
            {
                this.proveedorTableAdapter.BusquedaProveedores(this.dSAplicacionComercial.Proveedor, nombreToolStripTextBox.Text, nombresContactoToolStripTextBox.Text, apellidosContactoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
