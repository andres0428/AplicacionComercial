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
    public partial class frmPrincipalMDI : Form
    {
        public frmPrincipalMDI()
        {
            InitializeComponent();
            EsconderPanelesSubmenus();
        }



        #region mover

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpram, int lparam);



        private void tituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            restaurarPictureBox.Visible = false;
            maximizarPictureBox.Visible = true;

        }
        #endregion





        #region abroirfrmHijos
        private void AbrirFormPanelMDI(object formHijo)
        {
            if (this.contenedorPanel.Controls.Count > 0)
                this.contenedorPanel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedorPanel.Controls.Add(fh);
            this.contenedorPanel.Tag = fh;
            fh.Show();
        } 
        #endregion


        #region MoverFormulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance,
                                              tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.principalPanel.Region = region;//ojo panel principal el panel mas grande
            this.Invalidate();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        //aca debo de hacer una region
        private void EsconderPanelesSubmenus()
        {
            archivosSubMenuPanel.Visible = false;
            movimientosSubMenuPanel.Visible = false;
            reportesSubMenuPanel.Visible = false;
        }


        #region EsconderSubMenu
        private void EsconderSubMenu()
        {
            if (archivosSubMenuPanel.Visible == true)
                archivosSubMenuPanel.Visible = false;

            if (movimientosSubMenuPanel.Visible == true)
                movimientosSubMenuPanel.Visible = false;

            if (reportesSubMenuPanel.Visible == true)
                reportesSubMenuPanel.Visible = false;
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubMenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        
        #region Archivo
        private void archivoButton_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(archivosSubMenuPanel);
        }

        private void bodegaButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
           
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            AbrirFormPanelMDI(new frmClientes2());
        }

        private void productosButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void proveedoresButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            AbrirFormPanelMDI( new frmProveedores());
        }

        private void tipoDocumentoButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void cambioUsuariosButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void cambioClaveButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        } 
        #endregion


        #region Movimientos
        private void movimientosButton_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(movimientosSubMenuPanel);
        }

        private void comprasButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void devolucionesButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void trasladosButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void salidasButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void ventasButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        } 
        #endregion



        #region Reportes
        private void reportesButton_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(reportesSubMenuPanel);
        }

        private void kardexButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void inventariosButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void ventaButton_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }
        #endregion
        
        private void slidePictureBox_Click(object sender, EventArgs e)
        {
            if (menuVerticalPanel.Width == 200)
            {
                menuVerticalPanel.Width = 97;
            }
            else
            {
                menuVerticalPanel.Width = 200;
            }
        }

        #region maximizarMaximizarRestaurar

        int LX, LY, SW, SH;
        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            

        }

   

        private void restaurarPictureBox_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SH, SW);// sé pone como parametro el tamaña de nuestro formulario
            this.Location = new Point(LX, LY);
            restaurarPictureBox.Visible = false;
            minimizarPictureBox.Visible = true;
            maximizarPictureBox.Visible = true;

        }

        private void maximizarPictureBox_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;//psicion de x pantalla.
            LY = this.Location.Y; // posicion de y en la pantalla
            SH = this.Size.Width;
            SW = this.Size.Height;
            // this.WindowState = FormWindowState.Maximized;
            #region no ocupe toda la pantalla
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            #endregion
            restaurarPictureBox.Visible = true;
            maximizarPictureBox.Visible = false;
        }

        private void cerrarPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estar seguro de cerrar", "Precacuón", MessageBoxButtons.YesNo) == DialogResult.No) return;
            Application.Exit();
        } 
        #endregion
    }
}
