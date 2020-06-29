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
    public partial class frmParametrosBodega : Form
    {
        private int idProducto;
        public int IdProducto { set => idProducto = value; }

        public frmParametrosBodega()
        {
            InitializeComponent();        }

        

        private void frmParametrosBodega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAll.Bodega' table. You can move, or remove it, as needed.
            this.bodegaTableAdapter.Fill(this.dSAll.Bodega);
            bodegaBomboBox.SelectedIndex = -1;
        }

        private void bodegaBomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodegaBomboBox.SelectedIndex == -1) return;
            CADBodegaProducto miBodegaProducto = CADBodegaProducto.GetBodegaProductoByBodegaAndIdProducto((int)bodegaBomboBox.SelectedValue,idProducto);
            if (miBodegaProducto == null)
            {
                limpiarCampos();
            }else
            {
                stockTextBox.Text = miBodegaProducto.Stock.ToString();
                minimoNumericUpDown.Value = (decimal)miBodegaProducto.Minimo;
                maximoNumericUpDown.Value = (decimal)miBodegaProducto.Maximo;
                diasReposicionNumericUpDown.Value = (decimal)miBodegaProducto.DiasReposicion;
                cantidadMinimaNumericUpDown.Value = (decimal)miBodegaProducto.CantidadMinima;
            }            
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (bodegaBomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(bodegaBomboBox,"Debes de ingresar un id de Bodega");
                bodegaBomboBox.Focus();
                return;
            }

            CADBodegaProducto.updateBodegaProducto((int)bodegaBomboBox.SelectedValue,
                                                    idProducto,
                                                   (float) minimoNumericUpDown.Value,
                                                   (float) maximoNumericUpDown.Value,
                                                    (int) diasReposicionNumericUpDown.Value,
                                                   (float) cantidadMinimaNumericUpDown.Value);
            this.Close();
        }

        private void limpiarCampos()
        {
            //BodegaComboBox.SelectedValue = -1;
            stockTextBox.Text = string.Empty;
            minimoNumericUpDown.Value = 1;
            maximoNumericUpDown.Value = 1;
            diasReposicionNumericUpDown.Value = 1;
            cantidadMinimaNumericUpDown.Value = 1;                
        }
    }
}
