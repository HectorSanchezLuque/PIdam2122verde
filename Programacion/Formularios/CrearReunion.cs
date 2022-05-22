using MySql.Data.MySqlClient;
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
    
    public partial class CrearReunion : Form
    {
        bool luz;
        bool lang;
            
        private Usuario user;
        public CrearReunion(Usuario us,bool lu, bool la)
        {
            InitializeComponent();
            user = us;
            luz = lu;
            lang = la;
        }

        private void btnCrearReunion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRNombre.Text) || String.IsNullOrEmpty(txtDesc.Text) || dtpFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe llenar todos los campos correctamente");
            }
            else
            {
                conexion.AbrirConexion();
                Reuniones.CReunion(cmbCargos.Text, txtDesc.Text, dtpFecha.Value, dtpHora.Value, txtRNombre.Text, user);
                conexion.CerrarConexion();
                MessageBox.Show("Reunión creada con éxito");
                this.Close();
                
            }
        }

        private void CrearReunion_Load(object sender, EventArgs e)
        {
            formLang();
            luzForm();
            conexion.AbrirConexion();
            cmbCargos.Items.AddRange(Usuario.ListadoCargos().ToArray());
            conexion.CerrarConexion();

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


            lblCargos.Text = StringRecursos.crun_lblCargos;
            lblCrearReunion.Text = StringRecursos.crun_lblCrearReunion;
            lblFechaReunion.Text = StringRecursos.crun_lblFechaReunion;
            lblHoraReunion.Text = StringRecursos.crun_lblHoraReunion;
            lblRDesc.Text = StringRecursos.crun_lblRDesc;
            lblRNombre.Text = StringRecursos.crun_lblRNombre;
            btnCrearReunion.Text = StringRecursos.crun_btnCrearReunion;
            this.Text = StringRecursos.crun_title;


        }

        private void luzForm()
        {

            if (luz)
            {

                

            }
            else
            {

                luz = false;
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblCargos.ForeColor = Color.FromArgb(255, 255, 255);
                lblCrearReunion.ForeColor = Color.FromArgb(255, 255, 255);
                lblFechaReunion.ForeColor = Color.FromArgb(255, 255, 255);
                lblHoraReunion.ForeColor = Color.FromArgb(255, 255, 255);
                lblRDesc.ForeColor = Color.FromArgb(255, 255, 255);
                lblRNombre.ForeColor = Color.FromArgb(255, 255, 255);
                btnCrearReunion.ForeColor = Color.FromArgb(255, 255, 255);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                panel2.BackColor = Color.FromArgb(255, 255, 255);



            }

        }

        




    }
}
