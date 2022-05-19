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
    public partial class AgregarTarea : Form
    {
        bool luz;
        bool lang;
        Usuario user;
        public AgregarTarea(Usuario us,bool lu,bool la)
        {
            
            InitializeComponent();
            user = us;
            luz = lu;
            lang = la;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un titulo");
            }
            else if (String.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion");
            } 
            else
            {
                conexion.AbrirConexion();
                Tarea tarea = new Tarea();
                tarea.Titulo = txtTitulo.Text;
                tarea.Descripcion = txtDesc.Text;
                tarea.FLimite = dtpFL.Value;
                tarea.Puntos = Convert.ToInt16(nudPuntos.Value);
                tarea.FPublicacion = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                Tarea.AgregarTarea(tarea);
                conexion.CerrarConexion();
                this.Close();
                this.Dispose();
            }

        }

<<<<<<< HEAD
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
=======
        private void AgregarTarea_Load(object sender, EventArgs e)
        {
            
        }
        
        
            
>>>>>>> origin/src
    }
}
