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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAll);

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
        }

        #region Metodos
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
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }

        private void nextItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }

        private void lastItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }
        #endregion

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bodegaProductoTableAdapter.FillBy(this.dSAll.BodegaProducto, ((int)(System.Convert.ChangeType(iDProductoToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
