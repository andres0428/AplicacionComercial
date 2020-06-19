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
    public partial class frmBusquedaProveedor : Form
    {
        public frmBusquedaProveedor()
        {
            InitializeComponent();
        }

        private void frmBusquedaProveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void busquedaProveedorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proveedorTableAdapter.BusquedaProveedor(this.dSAplicacionComercial.Proveedor, nombreToolStripTextBox.Text, nombresContactoToolStripTextBox.Text, apellidosContactoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
