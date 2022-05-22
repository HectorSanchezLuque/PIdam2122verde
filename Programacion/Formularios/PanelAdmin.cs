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
using System.Globalization;
using System.Threading;
using ProyectoIntegradoVerde.RecursosLocalizables;

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class PanelAdmin : Form
    {
        bool luz;
        bool lang;
        public PanelAdmin(bool lu, bool lan)
        {
            InitializeComponent();
            luz = lu;
            lang = lan;
            

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
                lblIdAntes.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            formLang();
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
                usu.Id = Convert.ToInt32(lblIdAntes.Text);
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
                    Usuario.ActualizaUsuario(usu, Convert.ToInt32(lblIdAntes.Text));
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

            lblCargo.Text = StringRecursos.pan_adlblCargo;
            lblCorr.Text = StringRecursos.pan_adlblCorr;
            lblfech.Text = StringRecursos.pan_adlblfech;
            lblFoto.Text = StringRecursos.pan_adlblFoto;
            lblIdAntes.Text = StringRecursos.pan_adlblIdAntes;
            lblNom.Text = StringRecursos.pan_adlblNom;
            lblPassw.Text = StringRecursos.pan_adlblPassw;
            lblPunt.Text = StringRecursos.pan_adlblPunt;
            btnAgregar.Text = StringRecursos.pan_adbtnAgregar;
            btnCargar.Text = StringRecursos.pan_adbtnCargar;
            btnCerrar.Text = StringRecursos.pan_adbtnCerrar;
            btnModificar.Text = StringRecursos.pan_adbtnModificar;

            dgvUsuarios.Columns[2].HeaderText = StringRecursos.pan_addtg_1;
            dgvUsuarios.Columns[3].HeaderText = StringRecursos.pan_addtg_2;
            dgvUsuarios.Columns[4].HeaderText = StringRecursos.pan_addtg_3;
            dgvUsuarios.Columns[5].HeaderText = StringRecursos.pan_addtg_4;
            dgvUsuarios.Columns[6].HeaderText = StringRecursos.pan_addtg_5;
            dgvUsuarios.Columns[7].HeaderText = StringRecursos.pan_addtg_6;
            dgvUsuarios.Columns[8].HeaderText = StringRecursos.pan_addtg_7;




        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
