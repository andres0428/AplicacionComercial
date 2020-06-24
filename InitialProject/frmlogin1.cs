using InitialProject.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialProject
{
    public partial class frmlogin1 : Form
    {
        public frmlogin1()
        {
            InitializeComponent();
        }

        #region moverPantalla

        //********** codigo para mover la pantalla*********************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        #region frmLogin
        private void frmlogin1_Load(object sender, EventArgs e)
        {
            loginErrorProvider.Clear();
        }

        #region Button
        private void frmlogin1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #endregion

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == string.Empty)
            {
                loginErrorProvider.SetError(usuarioTextBox, "Debes de ingresar un usuario");
                usuarioTextBox.Focus();
                return;
            }
            loginErrorProvider.Clear();

            if (claveTextBox.Text == string.Empty)
            {
                loginErrorProvider.SetError(claveTextBox, "Debes de ingresar una clave de acceso");
                claveTextBox.Focus();
                return;
            }
            loginErrorProvider.Clear();

            if (!CADUsuario.ValidaUsuario(usuarioTextBox.Text, claveTextBox.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Posible intruso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuarioTextBox.Text = string.Empty;
                claveTextBox.Text = string.Empty;
                usuarioTextBox.Focus();
                return;
            }


            frmPrincipalMDI frm = new frmPrincipalMDI();
            this.Hide();
            frm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Procedes a cerrar", "Precaución", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }

        }

        #endregion

        #region Leabel  

       

        private void inicioSesionLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void haOlvidadoLaContrasenaLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #endregion

        #region Minimizar
        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrarPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Procedes a cerrar", "Precaución", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }

        }
        #endregion

        private void logoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }



        #region EventosTexBox
        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "Usuario:")
            {
                usuarioTextBox.Text = string.Empty;
                usuarioTextBox.ForeColor = Color.DimGray;
            }

        }

        private void claveTextBox_Enter(object sender, EventArgs e)
        {
            if (claveTextBox.Text == "Clave:")
            {
                claveTextBox.Text = String.Empty;
                claveTextBox.ForeColor = Color.DimGray;
                claveTextBox.UseSystemPasswordChar = true;
            }

        }

        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == string.Empty)
            {
                usuarioTextBox.Text = "Usuario:";
                usuarioTextBox.ForeColor = Color.DimGray;
            }

        }

        private void claveTextBox_Leave(object sender, EventArgs e)
        {
            if (claveTextBox.Text == string.Empty)
            {
                claveTextBox.Text = "Clave:";
                claveTextBox.ForeColor = Color.DimGray;
                claveTextBox.UseSystemPasswordChar = false;
            }

        }
        #endregion
    }
}
