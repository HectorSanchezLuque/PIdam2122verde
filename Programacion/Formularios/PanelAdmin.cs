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
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
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
                if (dgvUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString() == "1")
                {
                    checkDeshab.Checked = true;
                }
                else { checkDeshab.Checked = false; }

            }
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
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
                    dgvUsuarios.Rows.Add(list[i].Id, list[i].Nif, list[i].Nombre, list[i].FechaNacimiento.ToString("dd-MM-yyyy"), list[i].Cargo, list[i].Puntos, list[i].Correo, list[i].Password, list[i].Borrado.ToString());
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Id = Convert.ToInt32(txtID.Text);
            usu.Nif= txtNIF.Text;
            usu.Nombre = txtNombre.Text;
            usu.FechaNacimiento = Convert.ToDateTime(dateNacimiento.Text);
            usu.Cargo = txtCargo.Text;
            usu.Puntos = Convert.ToInt32(txtPuntos.Text);
            usu.Correo = txtCorreo.Text;
            usu.Password = txtContrasena.Text;
            usu.Borrado = Convert.ToInt32(checkDeshab.Checked);
            usu.Foto = null;

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                Usuario.ActualizaUsuario(usu, Convert.ToInt32(txtOldID.Text));
                conexion.CerrarConexion();
            }
            dgvUsuarios.Refresh();
            MessageBox.Show("Usuario modificado con éxito.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                Usuario usu = new Usuario();
                usu.Id = Convert.ToInt32(txtID.Text);
                usu.Nif = txtNIF.Text;
                usu.Nombre = txtNombre.Text;
                usu.FechaNacimiento = Convert.ToDateTime(dateNacimiento.Text);
                usu.Cargo = txtCargo.Text;
                usu.Puntos = Convert.ToInt32(txtPuntos.Text);
                usu.Correo = txtCorreo.Text;
                usu.Password = txtContrasena.Text;
                usu.Borrado = Convert.ToInt32(checkDeshab.Checked);
                usu.Foto = null;

                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    usu.AgregarUsuario();
                    conexion.CerrarConexion();
                }
                dgvUsuarios.Refresh();
                MessageBox.Show("Usuario agregado con éxito.");
            }
        }
    }
}
