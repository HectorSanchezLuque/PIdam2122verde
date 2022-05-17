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

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class CrearReunion : Form
    {
        private Usuario user;
        public CrearReunion(Usuario us)
        {
            InitializeComponent();
            user = us;
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
            conexion.AbrirConexion();
            cmbCargos.Items.AddRange(Usuario.ListadoCargos().ToArray());
            conexion.CerrarConexion();
        }
    }
}
