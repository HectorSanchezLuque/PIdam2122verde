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

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class Soporte : Form
    {
        private int numPag;

        public int NumPag { get => numPag; set => numPag = value; }

        public Soporte()
        {
            InitializeComponent();
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
        }
    }
}
