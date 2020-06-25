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
            habilitarCampos();
        }       

        private void addNewItemBindingNavigator_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            clienteBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();

        }

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas Segura de borar el registro actual", "Comfimar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            clienteBindingSource.RemoveAt(clienteBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if (!validaCampos()) return;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            }
            catch (Exception)
            {
                errorProvider1.SetError(documentoTextBox,"Documento ya existe");
                documentoTextBox.Focus();
                return;
            }
            deshabilitarCampos();
            errorProvider1.Clear();    

        }      

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource .CancelEdit();
            deshabilitarCampos();
            errorProvider1.Clear();
        }

        private void searchItemBindingNavigator_Click(object sender, EventArgs e)
        {
            frmBusquedaClientes2 frm = new frmBusquedaClientes2();
            frm.ShowDialog();
            //MessageBox.Show("Hola" + frm.IdProvedor); //Aca es para hacer una prueba 
            if (frm.IdCliente == 0) return;
            int posicion = clienteBindingSource.Find("iDCliente",frm.IdCliente);
            clienteBindingSource.Position = posicion;
        }

        //************************************************ Metodos ***************************************************
        private void habilitarCampos()
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

        private void deshabilitarCampos()
        {
            firstItemBindingNavigator.Enabled = true;
            previousItemBindingNavigator.Enabled = true;
            nextItemBindingNavigator.Enabled = true;
            lastItemBindingNavigator.Enabled = true;
            editItemBindingNavigator.Enabled = true;
            addNewItemBindingNavigator.Enabled = true;
            deleteItemBindingNavigator.Enabled = true;
            saveItemBindingNavigator.Enabled = false;
            cancelItemBindingNavigator.Enabled = false;
            searchItemBindingNavigator.Enabled = true;

            //campos texbox
            //iDClienteTextBox.ReadOnly = true;
            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;
            nombreComercialTextBox.ReadOnly = true;
            nombresContactoTextBox.ReadOnly = true;
            apellidosContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            aniversarioDateTimePicker.Enabled = false;
            notasTextBox.ReadOnly = true;
            iDTipoDocumentoComboBox.Focus();
        }

        private bool validaCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debes ingresar un tipo de documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debes ingresar un  documento");
                documentoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreComercialTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreComercialTextBox, "Debes ingresar un nombre comercial");
                nombreComercialTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombresContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debes ingresar un nombre");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (apellidosContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debes ingresar un apellido");
                apellidosContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();            

            if (correoTextBox.Text != string.Empty)
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Ingresa correo valido");
                    correoTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }


            return true;

        }

    }
}
