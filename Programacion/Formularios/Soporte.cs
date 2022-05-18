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
using ProyectoIntegradoVerde.RecursosLocalizables;

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class Soporte : Form
    {
        bool luz;
        bool lang;
        private int numPag;

        public int NumPag { get => numPag; set => numPag = value; }

        public Soporte(bool lu , bool lan)
        {
            
            InitializeComponent();
            luz = lu;
            lang = lan;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {


            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            List<String> correos = new List<String>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                correos = Correo.CorreosAdmin();
                conexion.CerrarConexion();

                for (int i = 0; i < correos.Count; i++)
                {

                    Correo informe = new Correo();

                    informe.Asunto = "Informe de usuario";
                    informe.Cuerpo = txtInforme.Text;
                    informe.Recipiente = correos[i];
                    informe.Remitente = "Usuario";
                    informe.Fecha = sqlFormattedDate;
                    informe.Usuario_id = 9;

                    conexion.AbrirConexion();
                    Correo.AgregarCorreo(informe);
                    conexion.CerrarConexion();
                }
            }
            MessageBox.Show("Informe de error enviado.");
        }

        private void btnSolMail_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<String> correos = new List<String>();
                correos = Correo.CorreosAdmin();
                conexion.CerrarConexion();

                for (int i = 0; i < correos.Count; i++)
                {

                    Correo solicitud = new Correo();

                    solicitud.Asunto = "Restablecimiento de contraseña";
                    solicitud.Cuerpo = "Solicitado restablecimiento de contraseña para el correo: " + txtSolMail.Text;
                    solicitud.Recipiente = correos[i];
                    solicitud.Remitente = txtSolMail.Text;
                    solicitud.Fecha = sqlFormattedDate;
                    solicitud.Usuario_id = 9;
                    conexion.AbrirConexion();
                    Correo.AgregarCorreo(solicitud);
                    conexion.CerrarConexion();

                }
            }
            MessageBox.Show("La solicitud se ha enviado con éxito, los administradores se pondrán en contacto con usted lo más pronto posible.");
        }

        private void Soporte_Load(object sender, EventArgs e)
        {
            this.tabSoporte.SelectTab(numPag);
            formLang();
            luzForm();
        }

        private void luzForm()
        {
            if (luz)
            {
                luz = false;
                this.BackColor = Color.FromArgb(255, 255, 255);
                lblMess.ForeColor = Color.FromArgb(0, 0, 122);
                lblrecup.ForeColor = Color.FromArgb(0, 0, 122);
                lbltitle.ForeColor = Color.FromArgb(0, 0, 122);
                tabPague1.ForeColor = Color.FromArgb(255, 255, 255);
                tabPage2.ForeColor = Color.FromArgb(255, 255, 255);
                tabSoporte.ForeColor = Color.FromArgb(255, 255, 255);

            }
            else
            {

                luz = true;
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblMess.ForeColor = Color.FromArgb(255, 255, 255);
                lblrecup.ForeColor = Color.FromArgb(255, 255, 255);
                lbltitle.ForeColor = Color.FromArgb(255, 255, 255);
                tabPague1.ForeColor = Color.FromArgb(0, 0, 122);
                tabPage2.ForeColor = Color.FromArgb(0, 0, 122);
                tabSoporte.ForeColor = Color.FromArgb(0, 0, 122);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void formLang()
        {
            if (!lang)
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                lang = false;

            }
            else
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("EN");
                lang = true;


            }

            AplicarIdioma();
        }
        private void AplicarIdioma()
        {

            //lblCargo.Text = StringRecursos.regCargo;
            lbltitle.Text = StringRecursos.sopTitle;
            btnInforme.Text = StringRecursos.sopbtnEnvInf1;
            lblrecup.Text = StringRecursos.sopTitle2;
            btnSolMail.Text = StringRecursos.sopbtnEnviar;
            lblMess.Text = StringRecursos.sopBtnENvin2;
            


        }
    }
}
