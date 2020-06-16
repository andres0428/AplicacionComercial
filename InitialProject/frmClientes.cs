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
        private bool nuevo; //suiche para poder saber si es nuevo o no
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
            if (clienteDataGridView.Rows.Count == 0) return;

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
            try
            {
                aniversarioDateTimePicker.Value = Convert.ToDateTime(clienteDataGridView.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {
                aniversarioDateTimePicker.Value = DateTime.Now;                
            }
        }

        private void PrimerToolStripButton_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistros();
        }

        private void AnteriorToolStripButton_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistros();
        }

        private void SiguienteToolStripButton_Click(object sender, EventArgs e)
        {
            if (i >= clienteDataGridView.Rows.Count - 1) return;
            i++;
            MostrarRegistros();
        }

        private void UltimoToolStripButton_Click(object sender, EventArgs e)
        {
            i = clienteDataGridView.Rows.Count - 1;
            MostrarRegistros();
        }
        private void ModificarToolStripButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }
        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            nuevo = true;
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas seguro de borrar el registro actual?","Confirmación",
                                                MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1);
            if (rta == DialogResult.No) return; ;
            CADCliente.DeleteClientes(Convert.ToInt32(iDClienteTextBox.Text));
            clienteDataGridView.DataSource = null;
            clienteDataGridView.DataSource = CADCliente.GetData();
            if (i != 0) i--;
            MostrarRagistro();
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;
            if (nuevo)
            {
                CADCliente.InsertClientes((int)iDTipoDocumentoComboBox.SelectedValue,
                                         documentoTextBox.Text,
                                         nombreComercialTextBox.Text,
                                         nombresContactoTextBox.Text,
                                         apellidosContactoTextBox.Text,
                                         direccionTextBox.Text,
                                         telefono1TextBox.Text,
                                         telefono2TextBox.Text,
                                         correoTextBox.Text,
                                         notasTextBox.Text,
                                         aniversarioDateTimePicker.Value);
            }
            else
            {
                CADCliente.UpdateClientes((int)iDTipoDocumentoComboBox.SelectedValue,
                                         documentoTextBox.Text,
                                         nombreComercialTextBox.Text,
                                         nombresContactoTextBox.Text,
                                         apellidosContactoTextBox.Text,
                                         direccionTextBox.Text,
                                         telefono1TextBox.Text,
                                         telefono2TextBox.Text,
                                         correoTextBox.Text,
                                         notasTextBox.Text,
                                         aniversarioDateTimePicker.Value,
                                         Convert.ToInt32(iDClienteTextBox.Text));
            }
            DeshabilitarCampos();
            RefrescarRegistro();
            if (nuevo) UltimoToolStripButton_Click(sender, e);

        }

       

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            MostrarRegistros();
            errorProvider1.Clear();
        }      

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        //***************************************** METODOS ***************************************************

        private void HabilitarCampos()
        {
            PrimerToolStripButton.Enabled = false;
            AnteriorToolStripButton.Enabled = false;
            SiguienteToolStripButton.Enabled = false;
            UltimoToolStripButton.Enabled = false;
            ModificarToolStripButton.Enabled = false;
            NuevoToolStripButton.Enabled = false;
            BorrarToolStripButton.Enabled = false;
            GuardarToolStripButton.Enabled = true;
            CancelarToolStripButton.Enabled = true;
            BuscarToolStripButton.Enabled = false;

            //campos texbox
            //iDClienteTextBox.ReadOnly = true;
            documentoTextBox.ReadOnly = false;
            nombreComercialTextBox.ReadOnly = false;
            nombresContactoTextBox.ReadOnly = false;
            apellidosContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
            iDTipoDocumentoComboBox.Enabled = true;
            aniversarioDateTimePicker.Enabled = true;
            iDTipoDocumentoComboBox.Focus();
        }

        private void LimpiarCampos()
        {            
            iDClienteTextBox.Text = string.Empty;
            documentoTextBox.Text = string.Empty;
            nombresContactoTextBox.Text = string.Empty;
            apellidosContactoTextBox.Text = string.Empty;
            nombreComercialTextBox.Text = string.Empty;
            direccionTextBox.Text = string.Empty;
            telefono1TextBox.Text = string.Empty;
            telefono2TextBox.Text = string.Empty;
            correoTextBox.Text = string.Empty;
            notasTextBox.Text = string.Empty;
            iDTipoDocumentoComboBox.SelectedIndex = -1;
            aniversarioDateTimePicker.Value = DateTime.Today;
        }

        private void DeshabilitarCampos()
        {
            PrimerToolStripButton.Enabled = true;
            AnteriorToolStripButton.Enabled = true;
            SiguienteToolStripButton.Enabled = true;
            UltimoToolStripButton.Enabled = true;
            ModificarToolStripButton.Enabled = true;
            NuevoToolStripButton.Enabled = true;
            BorrarToolStripButton.Enabled = true;
            GuardarToolStripButton.Enabled = false;
            CancelarToolStripButton.Enabled = false;
            BuscarToolStripButton.Enabled = true;

            //campos texbox
            //iDClienteTextBox.ReadOnly = false;
            documentoTextBox.ReadOnly = true;
            nombreComercialTextBox.ReadOnly = true;
            nombresContactoTextBox.ReadOnly = true;
            apellidosContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;
            iDTipoDocumentoComboBox.Enabled = false;
            aniversarioDateTimePicker.Enabled = false;
        }

        private void MostrarRagistro()
        {
            if (clienteDataGridView.Rows.Count == 0) return;
            iDClienteTextBox.Text = clienteDataGridView.Rows[i].Cells["IDCliente"].Value.ToString();
            documentoTextBox.Text = clienteDataGridView.Rows[i].Cells["Documento"].Value.ToString();
            nombresContactoTextBox.Text = clienteDataGridView.Rows[i].Cells["NombresContacto"].Value.ToString();
            apellidosContactoTextBox.Text = clienteDataGridView.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            nombreComercialTextBox.Text = clienteDataGridView.Rows[i].Cells["NombreComercial"].Value.ToString();
            direccionTextBox.Text = clienteDataGridView.Rows[i].Cells["Direccion"].Value.ToString();
            telefono1TextBox.Text = clienteDataGridView.Rows[i].Cells["Telefono1"].Value.ToString();
            telefono2TextBox.Text = clienteDataGridView.Rows[i].Cells["Telefono2"].Value.ToString();
            correoTextBox.Text = clienteDataGridView.Rows[i].Cells["Correo"].Value.ToString();
            notasTextBox.Text = clienteDataGridView.Rows[i].Cells["Notas"].Value.ToString();
            iDTipoDocumentoComboBox.SelectedValue = clienteDataGridView.Rows[i].Cells["IDTipoDocumento"].Value;
            try
            {
                aniversarioDateTimePicker.Value = Convert.ToDateTime(clienteDataGridView.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {
                aniversarioDateTimePicker.Value = DateTime.Now;
            }
        }

        private void RefrescarRegistro()
        {
            clienteDataGridView.DataSource = null;
            clienteDataGridView.DataSource = CADCliente.GetData();
            MostrarRagistro();
        }

        private bool validarCampos()
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

            if (direccionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(direccionTextBox, "Debes ingresar una dirección");
                direccionTextBox.Focus();
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
