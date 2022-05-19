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
using System.Threading;
using ProyectoIntegradoVerde.RecursosLocalizables;
using System.Globalization;
namespace ProyectoIntegradoVerde.Formularios
{
    public partial class AgregarTarea : Form
    {
        bool luz;
        bool lang;
        Usuario user;
        public AgregarTarea(Usuario us,bool lu,bool la)
        {
            
            InitializeComponent();
            user = us;
            luz = lu;
            lang = la;
            luzForm();
            formLang();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un titulo");
            }
            else if (String.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion");
            } 
            else
            {
                conexion.AbrirConexion();
                Tarea tarea = new Tarea();
                tarea.Titulo = txtTitulo.Text;
                tarea.Descripcion = txtDesc.Text;
                tarea.FLimite = dtpFL.Value;
                tarea.Puntos = Convert.ToInt16(nudPuntos.Value);
                tarea.FPublicacion = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                Tarea.AgregarTarea(tarea);
                conexion.CerrarConexion();
                this.Close();
                this.Dispose();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void AgregarTarea_Load(object sender, EventArgs e)
        {
            
        }

        private void AplicarIdioma()
        {


            this.Text = StringRecursos.adTar_title;
            lblAgregarT.Text = StringRecursos.adTar_lblAgregarT;
            lblTitulo.Text = StringRecursos.adTar_lblTitulo;
            lblDesc.Text = StringRecursos.adTar_lblDesc;
            lblPuntos.Text = StringRecursos.adTar_lblPuntos;
            btnEnviar.Text = StringRecursos.adTar_btnEnviar;
            btnCerrar.Text = StringRecursos.adTar_btnCerrar;


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

        private void luzForm()
        {

            if (luz)
            {

                luz = true;
                this.BackColor = Color.FromArgb(255, 255, 255);
                lblTitulo.ForeColor = Color.FromArgb(0, 0, 122);
                lblDesc.ForeColor = Color.FromArgb(0, 0, 122);
                lblPuntos.ForeColor = Color.FromArgb(0, 0, 122);
                txtTitulo.BackColor = Color.FromArgb(255, 255, 255);
                txtDesc.BackColor = Color.FromArgb(255, 255, 255);
                txtTitulo.ForeColor = Color.FromArgb(0, 0, 122);
                txtDesc.ForeColor = Color.FromArgb(0, 0, 122);
                lblAgregarT.ForeColor = Color.FromArgb(0, 0, 122);
                lblFLimite.ForeColor = Color.FromArgb(255, 255, 255);

            }
            else
            {

                luz = false;
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
                lblDesc.ForeColor = Color.FromArgb(255, 255, 255);
                lblPuntos.ForeColor = Color.FromArgb(255, 255, 255);
                txtTitulo.BackColor = Color.FromArgb(0, 0, 122);
                txtDesc.BackColor = Color.FromArgb(0, 0, 122);
                txtTitulo.ForeColor = Color.FromArgb(255, 255, 255);
                txtDesc.ForeColor = Color.FromArgb(255, 255, 255);
                lblAgregarT.ForeColor = Color.FromArgb(255, 255, 255);
                lblFLimite.ForeColor = Color.FromArgb(255, 255, 255);




            }

        }

    }
}
