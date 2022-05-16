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
        private Usuario user;
        private int numPag;

        public int NumPag { get => numPag; set => numPag = value; }
        public Usuario User { get => user; set => user = value; }


        
        
        public void RellenarDataGrid()
        {

            // Tareas sin asignar

            dgvTareasPendientes.Rows.Clear();
            dgvTareasSinAsignar.Rows.Clear();
            
            List<Tarea> list = new List<Tarea>();
            list = Tarea.ListadoTareas();
           
            for (int i = 0; i < list.Count; i++)
            {
                dgvTareasSinAsignar.Rows.Add(list[i].Id, list[i].Titulo, list[i].FPublicacion.ToString("dd-MM-yyyy"), list[i].FLimite.ToString("dd-MM-yyyy"), list[i].Puntos);
            }

            // Tareas asignadas
            
            List<Tarea> list2 = new List<Tarea>();
            list2 = Tarea.ListadoTareasAsignadas(user.Id);
            for (int i = 0; i < list2.Count; i++)
            {
                dgvTareasPendientes.Rows.Add(list2[i].Id, list2[i].Titulo, list2[i].FPublicacion.ToString("dd-MM-yyyy"), list2[i].FLimite.ToString("dd-MM-yyyy"), list2[i].Puntos);
            }

            // Correo
            List<Correo> correos;
            correos = Correo.Bandeja(user.Correo);
            conexion.CerrarConexion();
            for (int i = 0; i < correos.Count; i++)
            {
                dgvBandeja.Rows.Add(correos[i].Id, correos[i].Asunto,correos[i].Cuerpo, correos[i].Recipiente, correos[i].Remitente, correos[i].Fecha.ToString("dd-MM-yyyy"));
            }


            
        }
        public FrmFuncionalidades()
        {
            InitializeComponent();
        }

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(numPag);
            try
            {
                if (conexion.Conexion != null)
                {

                    conexion.AbrirConexion();
                    RellenarDataGrid();

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
                    Tarea.AsignarTarea(idTarea, User.Id);
                    RellenarDataGrid();

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

        private void dgvBandeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cuerpo = RowMessage();
            string title = "Cuerpo: ";
            MessageBox.Show(""+cuerpo,title);
        }

        private string RowMessage()
        {
            int count = 0;
            string message = "";
            for (int j = 0; j < dgvBandeja.Rows.Count; j++)
            {
                if (count < dgvBandeja.Rows.Count)
                {
                    string cuerpo = dgvBandeja.Rows[count].Cells[2].Value.ToString();
                    message += cuerpo;
                    count++;
                    if (count % 1 == 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return message;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            RellenarDataGrid();
            conexion.CerrarConexion();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime hola = Convert.ToDateTime(sqlFormattedDate);


            Correo cor = new Correo();
            cor.Asunto = txtAsunto.Text;
            cor.Cuerpo = txtCuerpo.Text;
            cor.Recipiente = txtDest.Text;
            cor.Recipiente = txtRemit.Text;
            cor.Fecha = hola;
            cor.Usuario_id = user.Id;

            conexion.AbrirConexion();
            Correo.AgregarCorreo(cor);
            conexion.CerrarConexion();

        }

    }
}
