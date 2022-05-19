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
    public partial class FrmDatos : Form
    {
        bool luz;
        bool lang;
        private Usuario user;
        public FrmDatos(Usuario us,bool lu,bool lan)
        {
            InitializeComponent();
            user = us;
            luz = lu;
            lang = lan;
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
            luzForm();
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

        private void luzForm()
        {

            if (luz)
            {

                luz = true;
                this.BackColor = Color.FromArgb(255, 255, 255);
                lblCargo.ForeColor = Color.FromArgb(0, 0, 122);
                lblNif.ForeColor = Color.FromArgb(0, 0, 122);
                lblPuntos.ForeColor = Color.FromArgb(0, 0, 122);
                lblNomUser.ForeColor = Color.FromArgb(0, 0, 122);
                lblCodigo.ForeColor = Color.FromArgb(0, 0, 122);
                lblCargo2.ForeColor = Color.FromArgb(0, 0, 122);
                lblNif2.ForeColor = Color.FromArgb(0, 0, 122);
                lblPuntos2.ForeColor = Color.FromArgb(0, 0, 122);
                






            }
            else
            {

                luz = false;
                this.BackColor = Color.FromArgb(0, 0, 122);
                lblCargo.ForeColor = Color.FromArgb(255, 255, 255);
                lblNif.ForeColor = Color.FromArgb(255, 255, 255);
                lblPuntos.ForeColor = Color.FromArgb(255, 255, 255);
                lblNomUser.ForeColor = Color.FromArgb(255, 255, 255);
                lblCodigo.ForeColor = Color.FromArgb(255, 255, 255);
                lblCargo2.ForeColor = Color.FromArgb(255, 255, 255);
                lblNif2.ForeColor = Color.FromArgb(255, 255, 255);
                lblPuntos2.ForeColor = Color.FromArgb(255, 255, 255);
                





            }

        }

    }
}
