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
                txtID.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNIF.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNacimiento.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCargo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPuntos.Text = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtContrasena.Text = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
        }
    }
}
