using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoIntegradoVerde;
using ProyectoIntegradoVerde.Formularios;
using ProyectoIntegradoVerde.RecursosLocalizables;
using ProyectoIntegradoVerde.Properties;

namespace Programacion
{
   
    public partial class Login : Form
    {
        bool luz = true;
        bool lang = false;
        public Login()
        {
            InitializeComponent();
        }



        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNif.Text)) {
                MessageBox.Show("Error al Iniciar sesion: El campo NIF esta vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (Usuario.compNif(txtNif.Text))
                {
                    try
                    {
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            Usuario user = Usuario.BuscarUsuario(txtNif.Text);

                            if (user.Nif == txtNif.Text && user.Password == txtPassword.Text)
                            {
                                if (Usuario.ComprobarBorrado("nif", txtNif.Text) == true)
                                {
                                    MessageBox.Show("Este usuario ya no existe.");
                                }
                                else
                                {
                                    FrmPrincipal princ = new FrmPrincipal(luz, user, lang);
                                    this.Hide();
                                    princ.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido iniciar sesión");
                            }
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
                else
                {
                    MessageBox.Show("El NIF no es válido");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            txtNif.Text = txtNif.Text.ToUpper();
        }

        private void pcbLuz_Click(object sender, EventArgs e)
        {

            if (luz)
            {

                luz = false;
                this.BackColor = Color.FromArgb(0, 0,122);
                lblLang.ForeColor = Color.FromArgb(255, 255, 255);
                lblNIF.ForeColor = Color.FromArgb(255, 255, 255);
                lblPsw.ForeColor = Color.FromArgb(255, 255, 255);
                lblNotif.LinkColor = Color.FromArgb(255, 255, 255);
                lblOlvidoCont.LinkColor = Color.FromArgb(255, 255, 255);


            }
            else
            {
                luz = true;
                this.BackColor = Color.FromArgb(255, 255, 255);
                lblLang.ForeColor = Color.FromArgb(0, 0, 0);
                lblNIF.ForeColor = Color.FromArgb(0, 0, 0);
                lblPsw.ForeColor = Color.FromArgb(0, 0, 0);
                lblNotif.LinkColor = Color.FromArgb(0, 0, 204);
                lblOlvidoCont.LinkColor = Color.FromArgb(0, 0, 204);


            }

        }

        private void picFlag_Click(object sender, EventArgs e)
        {
            if (lang)
            {
                picFlag.Image = Resources.spFlag;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                lang = false;

            }
            else
            {
                picFlag.Image = Resources.engFlag;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("EN");
                lang = true;

                
            }

            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            lblLang.Text = StringRecursos.lang;
            lblNotif.Text = StringRecursos.notiAd;
            lblOlvidoCont.Text = StringRecursos.contOlv;
            lblPsw.Text = StringRecursos.passwd;
            btnIniSesion.Text = StringRecursos.logIn;
            btnRegistro.Text = StringRecursos.regUsu;
           


        }
    }
}
