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
            // TODO: This line of code loads data into the 'dSAll.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAll.TipoDocumento);
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

        private void editItemBindingNavigator_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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

        //************************************************ Metodos ***************************************************
        private void HabilitarCampos()
        {
            firstItemBindingNavigator.Enabled = false;
            previousItemBindingNavigator.Enabled = false;
            nextItemBindingNavigator.Enabled = false;
            lastItemBindingNavigator.Enabled = false;
            editItemBindingNavigator.Enabled = false;
            addNewItemBindingNavigator.Enabled = false;
            deleteItemBindingNavigator.Enabled = false;
            saveItemBindingNavigator.Enabled = true;
            cancelItemBindingNavigator.Enabled = true;
            searchItemBindingNavigator.Enabled = false;

            //campos texbox
            //iDClienteTextBox.ReadOnly = false;
            iDTipoDocumentoComboBox.Enabled = true;
            documentoTextBox.ReadOnly = false;
            nombreComercialTextBox.ReadOnly = false;
            nombresContactoTextBox.ReadOnly = false;
            apellidosContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            aniversarioDateTimePicker.Enabled = true;
            notasTextBox.ReadOnly = false;            
            iDTipoDocumentoComboBox.Focus();
        }

    }
}
