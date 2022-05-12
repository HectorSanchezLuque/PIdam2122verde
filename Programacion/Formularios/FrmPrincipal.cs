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
    public partial class FrmPrincipal : Form
    {
        private string nif;
        private bool luz;
        public FrmPrincipal(string n, bool l)
        {
            luz = l;
            nif = n;
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblAbreFormulario_MouseEnter(object sender, EventArgs e)
        {
            lblAbreFormulario.ForeColor = Color.Blue;
        }

        private void lblAbreFormulario_MouseLeave(object sender, EventArgs e)
        {
            lblAbreFormulario.ForeColor = Color.Black;
        }

        private void lblAbreFormulario_Click(object sender, EventArgs e)
        {
            FrmDatos d = new FrmDatos();
            d.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            FrmFuncionalidades func = new FrmFuncionalidades(0);
            func.ShowDialog();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.Conexion != null)
                {
                        conexion.AbrirConexion();                       
                        FrmFuncionalidades func = new FrmFuncionalidades(0);
                        func.Show();
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

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(1);
            func.ShowDialog();
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(2);
            func.ShowDialog();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(3);
            func.ShowDialog();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades func = new FrmFuncionalidades(4);
            func.ShowDialog();
        }

        
    }
}
