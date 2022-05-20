using ProyectoIntegradoVerde.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace ProyectoIntegradoVerde.Formularios
{
    public partial class FrmPrincipal : Form
    {

        bool luz;
        bool lang;
        private Usuario user;


        public FrmPrincipal(bool l, Usuario us, bool leng)
        {
            InitializeComponent();
            luz = l;
            user = us;
            lang = leng;
        }



        private void lblAbreFormulario_MouseEnter(object sender, EventArgs e)
        {
            lblAbreFormulario.ForeColor = Color.Blue;
            
        }

        private void lblAbreFormulario_MouseLeave(object sender, EventArgs e)
        {
            if (!luz) { lblAbreFormulario.ForeColor = Color.Black; }
            else
                lblAbreFormulario.ForeColor = Color.White;

        }

        private void lblAbreFormulario_Click(object sender, EventArgs e)
        {
            FrmDatos d = new FrmDatos(user,luz,lang);
            d.ShowDialog();
        }
        
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            FrmFuncionalidades func = new FrmFuncionalidades(luz,lang);
            func.ShowDialog();

        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.Conexion != null)
                {
                    FrmFuncionalidades func = new FrmFuncionalidades(luz, lang);
                    func.User = user;
                    func.NumPag = 0;

                    func.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {

            FrmFuncionalidades func = new FrmFuncionalidades(luz, lang);
            func.User = user;
            func.NumPag = 1;
            func.ShowDialog();
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(luz, lang);
            func.User = user;
            func.NumPag = 2;
            func.ShowDialog();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {

            FrmFuncionalidades func = new FrmFuncionalidades(luz, lang);
            func.User = user;
            func.NumPag = 3;
            func.ShowDialog();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(luz, lang);
            func.User = user;
            func.NumPag = 4;
            func.ShowDialog();
        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            lblAbreFormulario.Text = user.Nombre + "  /  " + user.Cargo + "  /  " + user.Nif;
            timer1.Enabled = true;
            btnAdmin.Hide();
            if (user.Cargo == "Administrador" || user.Cargo == "Jefe")
            {
                btnAdmin.Show();
            }
            luzForm();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PanelAdmin pnlAd = new PanelAdmin(luz, lang);
            pnlAd.ShowDialog();
        }

        private void luzForm()
        {

            if (luz)
            {


                this.BackColor = Color.FromArgb(255, 255, 255);
                lblAbreFormulario.ForeColor = Color.White;
                lblHora.ForeColor = Color.FromArgb(0, 0, 122);
                lblFecha.ForeColor = Color.FromArgb(0, 0, 122);
                btnAdmin.ForeColor = Color.FromArgb(0, 0, 122);
                btnCerrarSesion.ForeColor = Color.FromArgb(0, 0, 122);
                btnCalendario.ForeColor = Color.FromArgb(0, 0, 122);
                btnCorreo.ForeColor = Color.FromArgb(0, 0, 122);
                btnReuniones.ForeColor = Color.FromArgb(0, 0, 122);
                btnTareas.ForeColor = Color.FromArgb(0, 0, 122);
                btnTienda.ForeColor = Color.FromArgb(0, 0, 122);
                panel1.BackColor = Color.FromArgb(0, 0, 122);
                ptbInfo.BackColor = Color.FromArgb(0, 0, 122);
                lblAbreFormulario.BackColor = Color.FromArgb(0, 0, 122);





            }
            else
            {
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblAbreFormulario.ForeColor = Color.Black;
                lblHora.ForeColor = Color.FromArgb(0, 0, 122);
                lblFecha.ForeColor = Color.FromArgb(255, 255, 255);
                btnAdmin.ForeColor = Color.FromArgb(255, 255, 255);
                btnCerrarSesion.ForeColor = Color.FromArgb(255, 255, 255);
                btnCalendario.ForeColor = Color.FromArgb(255, 255, 255);
                btnCorreo.ForeColor = Color.FromArgb(255, 255, 255);
                btnReuniones.ForeColor = Color.FromArgb(255, 255, 255);
                btnTareas.ForeColor = Color.FromArgb(255, 255, 255);
                btnTienda.ForeColor = Color.FromArgb(255, 255, 255);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                ptbInfo.BackColor = Color.FromArgb(255, 255, 255);
                lblAbreFormulario.BackColor = Color.FromArgb(255, 255, 255);

            }



        }

    }
}
