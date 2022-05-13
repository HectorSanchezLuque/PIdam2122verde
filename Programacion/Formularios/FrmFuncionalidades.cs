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

<<<<<<< HEAD
=======

        
        
>>>>>>> 63372ebeb04806ab0909949de7c59a546c18326f
        public void RellenarDataGrid()
        {
            
            // Tareas
            dgvTareasSinAsignar.Rows.Clear();
            List<Tarea> list = new List<Tarea>();
            list = Tarea.ListadoTareas();
<<<<<<< HEAD
=======
           
>>>>>>> 63372ebeb04806ab0909949de7c59a546c18326f
            for (int i = 0; i < list.Count; i++)
            {
                dgvTareasSinAsignar.Rows.Add(list[i].Id, list[i].Titulo, list[i].FPublicacion.ToString("dd-MM-yyyy"), list[i].FLimite.ToString("dd-MM-yyyy"), list[i].Puntos);
            }
<<<<<<< HEAD
=======

            // Correo
            List<Correo> correos;
            correos = Correo.Bandeja(user.Correo);
            conexion.CerrarConexion();
            for (int i = 0; i < correos.Count; i++)
            {
                dgvBandeja.Rows.Add(correos[i].Id, correos[i].Asunto,correos[i].Cuerpo, correos[i].Recipiente, correos[i].Remitente, correos[i].Fecha.ToString("dd-MM-yyyy"));
            }
            
>>>>>>> 63372ebeb04806ab0909949de7c59a546c18326f
        }

        public void RellenarDataGridPendientes()
        {
            dgvTareasPendientes.Rows.Clear();
            List<Tarea> list = new List<Tarea>();
            list = Tarea.ListadoTareasAsignadas(user.Id);
            for (int i = 0; i < list.Count; i++)
            {
                dgvTareasPendientes.Rows.Add(list[i].Id, list[i].Titulo, list[i].FPublicacion.ToString("dd-MM-yyyy"), list[i].FLimite.ToString("dd-MM-yyyy"), list[i].Puntos);
            }
        }

        public void RellenarDataGridReuniones() 
        {
            dgvReuniones.Rows.Clear();
            List<Reuniones> list = new List<Reuniones>();
            list = Reuniones.ListadoReuniones(user.Id);
            conexion.CerrarConexion();
            for (int i = 0; i < list.Count; i++)
            {
                dgvReuniones.Rows.Add(list[i].Id, list[i].Nombre, list[i].Descripcion, list[i].Fecha);
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
                    RellenarDataGridPendientes();
                    RellenarDataGridReuniones();

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
                    RellenarDataGridPendientes();

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

<<<<<<< HEAD
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            RellenarDataGrid();
            RellenarDataGridPendientes();
            conexion.CerrarConexion();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            RellenarDataGridReuniones();
            conexion.CerrarConexion();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearReunion crear = new CrearReunion();
            crear.ShowDialog();
=======
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
>>>>>>> f4efb22d260410cef7e0fd12eeedc4000ce677c5
        }
    }
}
