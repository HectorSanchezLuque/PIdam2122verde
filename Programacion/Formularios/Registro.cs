using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradoVerde.Formularios;
using System.IO;
using System.Globalization;
using System.Threading;
using ProyectoIntegradoVerde.RecursosLocalizables;
using ProyectoIntegradoVerde.Properties;

namespace ProyectoIntegradoVerde
{
    
    public partial class Registro : Form
    {
        bool luz;
        bool lang;

        private  bool comprDatos()
        {
            bool comp = true;
            errorProvider1.Clear();
            
            if (!Usuario.compNif(txtNifRegistro.Text))
            {
                errorProvider1.SetError(txtNifRegistro, "NIF incorrecto");
                comp = false;

            }
             if (txtNombreRegistro.Text == "")
            {
                errorProvider1.SetError(txtNombreRegistro, "Introduzca un nombre");
                comp = false;

            }
             if (txtEmailRegistro.Text == "")
            {
                errorProvider1.SetError(txtEmailRegistro, "Introduzca un email");
                comp = false;
            }
             if (txtPasswordRegistro.Text == "")
            {
                errorProvider1.SetError(txtPasswordRegistro, "Introduzca una contraseña");
                comp = false;
            }
            if (txtCargo.Text == "")
            {
                errorProvider1.SetError(txtCargo, "Introduzca un cargo");
                comp = false;
            }

            if (dtpFNRegistro.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpFNRegistro, "Fecha incorrecta");
                comp = false;
            }

            return comp;

        }
        public Registro(bool lu, bool lan)
        {
            InitializeComponent();
            luz = lu;
            lang = lan;
            


        }
        private void btnCargarRegistro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*.jpg";
            openFileDialog1.Title = "Seleccione una imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pbProfPicRegistro.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtPasswordRegistro.UseSystemPasswordChar = true;
            luzForm();
            formLang();
        }

        private void btnRegistrarseRegistro_Click(object sender, EventArgs e)
        {
            if (comprDatos())
            {
                try
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.Conexion.Open();

                        if (Usuario.ComprobarBorrado("nif", txtNifRegistro.Text))
                        {
                            
                            // si esta borrado
                            DialogResult resp = MessageBox.Show("Existe un usuario con ese nif quieres darlo de alta?", "Nif ya registrado", MessageBoxButtons.YesNo);
                            if (resp == DialogResult.Yes)
                            {
                                conexion.Conexion.Close();
                                conexion.Conexion.Open();
                                Usuario.DarAlta(txtNifRegistro.Text);
                                
                                MessageBox.Show("Usuario dado de alta");
                                
                            }
                        }
                        else
                        {
                            conexion.Conexion.Close();
                            conexion.Conexion.Open();
                            //guardar imagen
                            MemoryStream ms = new MemoryStream();
                            pbProfPicRegistro.Image.Save(ms, pbProfPicRegistro.Image.RawFormat);
                            byte[] img = ms.ToArray();



                            Usuario user = new Usuario(txtNifRegistro.Text, txtNombreRegistro.Text, dtpFNRegistro.Value.Date, txtCargo.Text, txtEmailRegistro.Text, txtPasswordRegistro.Text, img, 0);

                            user.AgregarUsuario();
                            MessageBox.Show("Usuario registrado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la operacion: "+ex.Message);
                }
                finally
                {
                    conexion.Conexion.Close();
                }
            }
            
        }

        private void chkShowReg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowReg.Checked)
            {
                txtPasswordRegistro.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordRegistro.UseSystemPasswordChar = true;
            }
        }

        private void txtNifRegistro_TextChanged(object sender, EventArgs e)
        {
            txtNifRegistro.Text = txtNifRegistro.Text.ToUpper();
        }
        private void luzForm()
        {

            if (luz)
            {

              
               





            }
            else
            {

                
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblCargo.ForeColor = Color.FromArgb(255, 255, 255);
                lblEmailRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                lblFNacRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                lblNifRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                lblNombreRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                lblPasswordRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                lblRegistro.ForeColor = Color.FromArgb(255, 255, 255);
                chkShowReg.ForeColor = Color.FromArgb(255, 255, 255);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                panel2.BackColor = Color.FromArgb(255, 255, 255);



            }

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

            lblCargo.Text = StringRecursos.regCargo;
            lblFNacRegistro.Text = StringRecursos.regNaci;
            lblNombreRegistro.Text = StringRecursos.regNombre;
            lblPasswordRegistro.Text = StringRecursos.regClave;
            lblRegistro.Text = StringRecursos.regTitle;
            btnCargarRegistro.Text = StringRecursos.regCargar;
            btnClos.Text = StringRecursos.regBtnClose;
            btnRegistrarseRegistro.Text = StringRecursos.regBtnReg;
            chkShowReg.Text = StringRecursos.regMostContra;

        }
    }
}
