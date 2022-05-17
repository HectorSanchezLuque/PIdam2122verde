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

namespace ProyectoIntegradoVerde
{
    public partial class Registro : Form
    {

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
        public Registro()
        {
            InitializeComponent();
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
                            MessageBox.Show("Existe un usuario con ese nif quieres darlo de alta?", "Nif ya registrado", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            conexion.Conexion.Close();
                            conexion.Conexion.Open();
                            //guardar imagen
                            MemoryStream ms = new MemoryStream();
                            pbProfPicRegistro.Image.Save(ms, pbProfPicRegistro.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            

                            Usuario user = new Usuario(txtNifRegistro.Text, txtNombreRegistro.Text, dtpFNRegistro.Value.Date, txtPasswordRegistro.Text, txtEmailRegistro.Text, txtCargo.Text, img);
                            user.AgregarUsuario();

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
    }
}
