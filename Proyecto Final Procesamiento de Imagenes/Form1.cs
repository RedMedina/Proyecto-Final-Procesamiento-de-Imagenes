using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            costumizeDesing();
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void costumizeDesing() 
        {
            PanelSubMenuFiltros.Visible = false;
            PanelSubMenuDeteccion.Visible = false;
        }

        private void hideSubMenu() 
        {
            if (PanelSubMenuFiltros.Visible == true) 
            {
                PanelSubMenuFiltros.Visible = false;
            }
            if (PanelSubMenuDeteccion.Visible == true)
            {
                PanelSubMenuDeteccion.Visible = false;
            }
        }

        private void showSubMenu(Panel Submenu) 
        {
            if(Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuFiltros);
        }

        private void btnDeteccion_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuDeteccion);
        }

        private Form ActiveForm = null;
        private void ShowForm(Form childForm) 
        {
            if (ActiveForm != null) 
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(childForm);
            PanelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnImgFiltro_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new Imagenes());
            hideSubMenu();
        }

        private void btnVideoFIltro_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new Videos());
            hideSubMenu();
        }

        private void btnDeteccionP_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new CapturaMovimiento());
            hideSubMenu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Maximizado = false;
        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (Maximizado == false) 
            {
                this.WindowState = FormWindowState.Maximized;
                Maximizado = true;
                pictureMaximize.Image = Properties.Resources.icons8_restore_window_20;
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
                Maximizado = false;
                pictureMaximize.Image = Properties.Resources.icons8_maximize_window_20;
            }
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFiltros_MouseHover(object sender, EventArgs e)
        {
            btnFiltros.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnFiltros_MouseLeave(object sender, EventArgs e)
        {
            btnFiltros.ResetBackColor();
        }

        private void btnDeteccion_MouseHover(object sender, EventArgs e)
        {
            btnDeteccion.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnDeteccion_MouseLeave(object sender, EventArgs e)
        {
            btnDeteccion.ResetBackColor();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ResetBackColor();
        }
    }
}
