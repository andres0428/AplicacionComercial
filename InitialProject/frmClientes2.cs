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
    public partial class frmClientes2 : Form
    {
        public frmClientes2()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void frmClientes2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }

        private void firstItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void previousItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void nextItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void lastItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void modifierItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void addNewItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void searchItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }
    }
}
