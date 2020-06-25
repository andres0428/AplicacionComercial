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
    public partial class frmBarras : Form
    {
        private long idBarra = 0;
        public frmBarras()
        {
            InitializeComponent();
        }

        public long IdBarra { get => idBarra; }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (barraTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(barraTextBox,"Ingresa un número de barra");
                barraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (!long.TryParse(barraTextBox.Text, out idBarra))
            {
                errorProvider1.SetError(barraTextBox,"Debes de ingresar digitos numéricos");
                barraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (idBarra < 1000000)
            {
                errorProvider1.SetError(barraTextBox,"Debes de ingresar un dato de barra adecuado");
                barraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (CADBarra.existeBarra(idBarra))
            {
                errorProvider1.SetError(barraTextBox,"Número de barra repetido");
                barraTextBox.Focus();
                return;
            }
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            idBarra = 0;
            this.Close();
        }
    }
}
