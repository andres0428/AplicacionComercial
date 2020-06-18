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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }        

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAll.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAll.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void modifierItemBindingNavigator_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void addNewItemBindingNavigator_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            proveedorBindingSource.AddNew();
            nombresContactoTextBox.Focus();

        }
        
        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }
        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if (!validaCampos()) return;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            deshabilitarCampos();            
        }       

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.proveedorBindingSource.CancelEdit();
            deshabilitarCampos();
            errorProvider1.Clear();
        }

        private void searchItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }            

        //*********************************************** METODOS ********************************************************************
        private void habilitarCampos()
        {
            firstItemBindingNavigator.Enabled = false;
            previousItemBindingNavigator.Enabled = false;
            nextItemBindingNavigator.Enabled = false;
            lastItemBindingNavigator.Enabled = false;
            modifierItemBindingNavigator.Enabled = false;
            addNewItemBindingNavigator.Enabled = false;
            deleteItemBindingNavigator.Enabled = false;
            saveItemBindingNavigator.Enabled = true;
            cancelItemBindingNavigator.Enabled = true;
            searchItemBindingNavigator.Enabled = false;

            //campos texbox
            //iDClienteTextBox.ReadOnly = false;            
            iDTipoDocumentoComboBox.Enabled = true;
            documentoTextBox.ReadOnly = false;            
            nombresContactoTextBox.ReadOnly = false;            
            apellidosContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;            
            notasTextBox.ReadOnly = false;            
            //aniversarioDateTimePicker.Enabled = true;
            iDTipoDocumentoComboBox.Focus();
        }
        private void limpiarCampos()
        {
            //iDClienteTextBox.Text = string.Empty;
            iDProveedorTextBox.Text = string.Empty;
            iDTipoDocumentoComboBox.SelectedIndex = -1;
            documentoTextBox.Text = string.Empty;
            nombresContactoTextBox.Text = string.Empty;
            apellidosContactoTextBox.Text = string.Empty;            
            direccionTextBox.Text = string.Empty;
            nombreTextBox.Text = string.Empty;
            telefono1TextBox.Text = string.Empty;
            telefono2TextBox.Text = string.Empty;
            correoTextBox.Text = string.Empty;
            notasTextBox.Text = string.Empty;            
            //aniversarioDateTimePicker.Value = DateTime.Today;

        }

        private void deshabilitarCampos()
        {
            firstItemBindingNavigator.Enabled = true;
            previousItemBindingNavigator.Enabled = true;
            nextItemBindingNavigator.Enabled = true;
            lastItemBindingNavigator.Enabled = true;
            modifierItemBindingNavigator.Enabled = true;
            addNewItemBindingNavigator.Enabled = true;
            deleteItemBindingNavigator.Enabled = true;
            saveItemBindingNavigator.Enabled = false;
            cancelItemBindingNavigator.Enabled = false;
            searchItemBindingNavigator.Enabled = true;

            //campos texbox
            //iDClienteTextBox.ReadOnly = true;            
            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;            
            nombresContactoTextBox.ReadOnly = true;            
            apellidosContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;            
            notasTextBox.ReadOnly = true;            
            //aniversarioDateTimePicker.Enabled = true;
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

            if (direccionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(direccionTextBox, "Debes ingresar una dirección");
                direccionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debes ingresar un nombre comercial");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "Debes ingresar un tipo un correo");
                correoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;

        }
    }
}
