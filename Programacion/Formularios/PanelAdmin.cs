using ProyectoIntegradoVerde.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void RecargarDGV()
        {
            
            dgvUsuarios.Rows.Clear();
            if (conexion.Conexion != null)
            {
                List<Usuario> list = new List<Usuario>();
                conexion.AbrirConexion();
                list = Usuario.ListadoUsuarios();
                conexion.CerrarConexion();

                for (int i = 0; i < list.Count; i++)
                {
                   dgvUsuarios.Rows.Add(list[i].Id, list[i].Nif, list[i].Nombre, list[i].FechaNacimiento.ToString("dd-MM-yyyy"), list[i].Cargo, list[i].Puntos, list[i].Correo, list[i].Password, list[i].Borrado.ToString(),list[i].Foto);
                }
            }
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows[e.RowIndex].Cells[4].Value != null)
            {
                txtID.Clear();
                txtNIF.Clear();
                txtNombre.Clear();
                dateNacimiento.Text = DateTime.Now.ToString();
                txtCargo.Clear();
                txtPuntos.Clear();
                txtCorreo.Clear();
                txtContrasena.Clear();
                pictureFoto.Image = null;
                checkDeshab.Checked = false;

                txtID.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNIF.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNacimiento.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCargo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPuntos.Text = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtContrasena.Text = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtOldID.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                label9.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    if (Usuario.BuscarFoto(dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString()) == null)
                    {

                    }
                    else
                    {
                        pictureFoto.Image = Usuario.BuscarFoto(dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                    conexion.CerrarConexion();
                }

                    if (dgvUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString() == "1")
                {
                    checkDeshab.Checked = true;
                }
                else { checkDeshab.Checked = false; }

            }
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            RecargarDGV();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();
                usu.Id = Convert.ToInt32(label9.Text);
                usu.Nif = txtNIF.Text;
                usu.Nombre = txtNombre.Text;
                usu.FechaNacimiento = Convert.ToDateTime(dateNacimiento.Text);
                usu.Cargo = txtCargo.Text;
                usu.Puntos = Convert.ToInt32(txtPuntos.Text);
                usu.Correo = txtCorreo.Text;
                usu.Password = txtContrasena.Text;
                if (checkDeshab.Checked == true)
                {
                    usu.Borrado = 1;
                }
                else
                {
                    usu.Borrado = 0;
                }

                MemoryStream ms = new MemoryStream();
                pictureFoto.Image.Save(ms, pictureFoto.Image.RawFormat);
                byte[] img = ms.ToArray();

                usu.Foto = img;

                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    Usuario.ActualizaUsuario(usu, Convert.ToInt32(label9.Text));
                    conexion.CerrarConexion();
                }

                RecargarDGV();

                MessageBox.Show("Usuario modificado con éxito.");
            } catch (Exception ex)
            {
                MessageBox.Show("Uno de los campos está vacio o incorrectamente introducido."+ex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try{ 
                Usuario usu = new Usuario();
                usu.Id = Convert.ToInt32(txtID.Text);
                usu.Nif = txtNIF.Text;
                usu.Nombre = txtNombre.Text;
                usu.FechaNacimiento = Convert.ToDateTime(dateNacimiento.Text);
                usu.Cargo = txtCargo.Text;
                usu.Puntos = Convert.ToInt32(txtPuntos.Text);
                usu.Correo = txtCorreo.Text;
                usu.Password = txtContrasena.Text;
                if (checkDeshab.Checked == true)
                {
                    usu.Borrado = 1;
                }
                else
                {
                    usu.Borrado = 0;
                }

                MemoryStream ms = new MemoryStream();
                pictureFoto.Image.Save(ms, pictureFoto.Image.RawFormat);
                byte[] img = ms.ToArray();

                usu.Foto = img;

                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    usu.AgregarUsuario();
                    conexion.CerrarConexion();
                }
                RecargarDGV();
                MessageBox.Show("Usuario agregado con éxito.");
            } catch (Exception ex)
            {
                MessageBox.Show("Uno de los campos está vacio o incorrectamente introducido: " + ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos de imagen|*.jpg";
                openFileDialog1.Title = "Seleccione una imagen";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pictureFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            } catch (Exception ex) { MessageBox.Show("Ha habido un problema al cargar la imágen, vuelvalo a intentarlo o seleccione una distinta:" + ex); }
        }
    }
}
