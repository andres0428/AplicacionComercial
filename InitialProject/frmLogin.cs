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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox,"Debes de ingresar un usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClaveTextBox,"Debes de ingresar una clave de acceso");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


        }
    }
}
