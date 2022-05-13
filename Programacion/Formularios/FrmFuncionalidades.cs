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
    public partial class FrmFuncionalidades : Form
    {
        private int id;
        private int numPag;

        public int NumPag { get => numPag; set => numPag = value; }
        public int Id { get => id; set => id = value; }
        
        public void RellenarDataGrid()
        {
            conexion.AbrirConexion();
            // Tareas
            List<Tarea> list = new List<Tarea>();
            list = Tarea.ListadoTareas();
            for (int i = 0; i < list.Count; i++)
            {
                dgvTareasSinAsignar.Rows.Add(list[i].Id, list[i].Titulo, list[i].FPublicacion.ToString("dd-MM-yyyy"), list[i].FLimite.ToString("dd-MM-yyyy"), list[i].Puntos);
            }

            // Correo
            List<Correo> correos = new List<Correo>();
            correos = Correo.Bandeja("aa"); //Introducir correo del usuario como parámetro
            for (int i = 0; i < correos.Count; i++)
            {
                dgvBandeja.Rows.Add(correos[i].Id, correos[i].Asunto, correos[i].Recipiente, correos[i].Remitente, correos[i].Fecha.ToString("dd-MM-yyyy"));
            }
            conexion.CerrarConexion();
        }
        public FrmFuncionalidades()
        {
            InitializeComponent();
        }

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(numPag);
            RellenarDataGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTareasSinAsignar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idTarea = dgvTareasSinAsignar.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (conexion.Conexion != null)
                {

                    conexion.AbrirConexion();
                    Tarea.AsignarTarea(idTarea, id);
                    RellenarDataGrid();
                    conexion.CerrarConexion();

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

    }
}
