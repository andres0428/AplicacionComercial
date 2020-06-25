using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialProject
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

      

        private void frmProductos_Load(object sender, EventArgs e)
        {          
            // TODO: This line of code loads data into the 'dSAll.Medida' table. You can move, or remove it, as needed.
            this.medidaTableAdapter.Fill(this.dSAll.Medida);
            // TODO: This line of code loads data into the 'dSAll.IVA' table. You can move, or remove it, as needed.
            this.iVATableAdapter.Fill(this.dSAll.IVA);
            // TODO: This line of code loads data into the 'dSAll.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.dSAll.Departamento);
            // TODO: This line of code loads data into the 'dSAll.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dSAll.Producto);

            // TODO: This line of code loads data into the 'dSAll.Barra' table. You can move, or remove it, as needed.            
           

            llenarGrillas();
            cargarImagen();
        }

        #region LlenarGrillas
        private void llenarGrillas()
        {
            this.barraTableAdapter.FillBy(this.dSAll.Barra, Convert.ToInt32(iDProductoTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSAll.BodegaProducto,Convert.ToInt32(iDProductoTextBox.Text));
        }       
        #endregion

        #region MenuMovimientoItem
        private void firstItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
            cargarImagen();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            llenarGrillas();
            cargarImagen();
        }

        private void nextItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
            cargarImagen();
        }

        private void lastItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
            cargarImagen();
        }
        #endregion
       

        #region EditAddDeleteSave
        private void editItemBindingNavigator_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }       

        private void addNewItemBindingNavigator_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            productoBindingSource.AddNew();
            iDDepartamentoComboBox.Focus();
        }       

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se procede a borrar permanentemente", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No) return;
            productoBindingSource.RemoveAt(productoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAll);
        }

        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if (!validamosCampos()) return;
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAll);
            deshabilitarCampos();
            errorProvider1.Clear();
        }        

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.productoBindingSource.CancelEdit();
            deshabilitarCampos();
            errorProvider1.Clear();
        }

        private void searchItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodoss
        private void deshabilitarCampos()
        {
            iDDepartamentoComboBox.Enabled = false;
            iDIVAComboBox.Enabled = false;
            iDMedidaComboBox.Enabled = false;
            iDProductoTextBox.ReadOnly = true;
            descripcionTextBox.ReadOnly = true;
            medidaTextBox.ReadOnly = true;
            precioTextBox.ReadOnly = true;
            imagenTextBox.ReadOnly = true;
            bucarImagenButton.Enabled = false;
            notasTextBox.ReadOnly = true;
            agregarBarraButton.Enabled = false;
            eliminarBarraButton.Enabled = false;
            agregarBodegaButton.Enabled = false;


            firstItemBindingNavigator.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            nextItemBindingNavigator.Enabled = true;
            lastItemBindingNavigator.Enabled = true;
            editItemBindingNavigator.Enabled = true;
            addNewItemBindingNavigator.Enabled = true;
            deleteItemBindingNavigator.Enabled = true;
            saveItemBindingNavigator.Enabled = false;
            cancelItemBindingNavigator.Enabled = false;
            searchItemBindingNavigator.Enabled = true;
        }

        private void habilitarCampos()
        {
            iDDepartamentoComboBox.Enabled = true;
            iDIVAComboBox.Enabled = true;
            iDMedidaComboBox.Enabled = true;
            iDProductoTextBox.ReadOnly = false;
            descripcionTextBox.ReadOnly = false;
            medidaTextBox.ReadOnly = false;
            precioTextBox.ReadOnly = false;
            imagenTextBox.ReadOnly = false;
            bucarImagenButton.Enabled = true;
            notasTextBox.ReadOnly = false;
            agregarBarraButton.Enabled = true;
            eliminarBarraButton.Enabled = true;
            agregarBodegaButton.Enabled = true;


            firstItemBindingNavigator.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            nextItemBindingNavigator.Enabled = false;
            lastItemBindingNavigator.Enabled = false;
            editItemBindingNavigator.Enabled = false;
            addNewItemBindingNavigator.Enabled = false;
            deleteItemBindingNavigator.Enabled = false;
            saveItemBindingNavigator.Enabled = true;
            cancelItemBindingNavigator.Enabled = true;
            searchItemBindingNavigator.Enabled = false;
        }

        private bool validamosCampos()
        {
            if (iDDepartamentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDDepartamentoComboBox, "Obligatorio campo id departamento");
                iDDepartamentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (iDIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDIVAComboBox, "Obligatorio campo id iva");
                iDIVAComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (iDMedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDMedidaComboBox, "Obligatorio campo iD Medida");
                iDMedidaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Obligatorio campo descripcion");
                descripcionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            decimal medida;
            if (!decimal.TryParse(medidaTextBox.Text, out medida))
            {
                errorProvider1.SetError(medidaTextBox, "Debes ingresar un valor numerico");
                medidaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (medida <= 0)
            {
                errorProvider1.SetError(medidaTextBox, "Debes ingresar un valor numerico mayor a cero");
                medidaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            decimal precio;
            if (!decimal.TryParse(precioTextBox.Text, out precio))
            {
                errorProvider1.SetError(precioTextBox, "Debes ingresar un valor numerico");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precio <= 0)
            {
                errorProvider1.SetError(precioTextBox, "Debes ingresar un valor numerico mayor a cero");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;

        }
        #endregion

        #region ImagenesProductos
        private void bucarImagenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagenTextBox.Text = openFileDialog1.FileName;            
            cargarImagen();
        }

        private void cargarImagen()
        {
            if (imagenTextBox.Text == string.Empty)
            {
                imagenPictureBox.Image = null;
            }
            else
            {
                if (File.Exists(imagenTextBox.Text))
                {
                    imagenPictureBox.Load(imagenTextBox.Text);
                }
            }
        }
        #endregion

        private void agregarBarraButton_Click(object sender, EventArgs e)
        {
            frmBarras frm = new frmBarras();
            frm.ShowDialog();
        }
    }
}
