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
    public partial class FrmDatos : Form
    {
        private Usuario user;
        public FrmDatos(Usuario us)
        {
            InitializeComponent();
            user = us;
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            lblNomUser.Text = user.Nombre;
            lblCodigo.Text = user.Id.ToString("D4");
            lblCargo2.Text = user.Cargo;
            lblNif2.Text = user.Nif;
            lblPuntos2.Text = user.Puntos.ToString();
            if (Usuario.BuscarFoto(user.Nif) == null)
            {

            }
            else
            {
                ptbFoto.Image = Usuario.BuscarFoto(user.Nif);
                
            }
            conexion.CerrarConexion();
        }

        private void ptbFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*.jpg";
            openFileDialog1.Title = "Seleccione una imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ptbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                
                MemoryStream ms = new MemoryStream();
                ptbFoto.Image.Save(ms, ptbFoto.Image.RawFormat);
                byte[] img = ms.ToArray();
                conexion.AbrirConexion();
                Usuario.ActualizarFoto(user.Nif, img);
                conexion.CerrarConexion();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
