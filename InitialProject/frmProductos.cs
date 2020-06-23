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
            // TODO: This line of code loads data into the 'dSAll.BodegaProducto' table. You can move, or remove it, as needed.
            this.bodegaProductoTableAdapter.Fill(this.dSAll.BodegaProducto);
            // TODO: This line of code loads data into the 'dSAll.Barra' table. You can move, or remove it, as needed.
            this.barraTableAdapter.Fill(this.dSAll.Barra);
            // TODO: This line of code loads data into the 'dSAll.Medida' table. You can move, or remove it, as needed.
            this.medidaTableAdapter.Fill(this.dSAll.Medida);
            // TODO: This line of code loads data into the 'dSAll.IVA' table. You can move, or remove it, as needed.
            this.iVATableAdapter.Fill(this.dSAll.IVA);
            // TODO: This line of code loads data into the 'dSAll.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.dSAll.Departamento);
            // TODO: This line of code loads data into the 'dSAll.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dSAll.Producto);

        }

       
    }
}
