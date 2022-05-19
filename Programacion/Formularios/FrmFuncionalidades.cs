using ProyectoIntegradoVerde.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class FrmFuncionalidades : Form
    {
        private Usuario user;
        private int numPag;
        bool lang;
        bool luz;
        
        

        public int NumPag { get => numPag; set => numPag = value; }
        public Usuario User { get => user; set => user = value; }
        public bool Lang { get { return lang; } set { lang = value; } }
        public bool Luz { get { return luz; } set { luz = value; } }





        public void RellenarDataGrid()
        {

            // Tareas sin asignar

            dgvTareasPendientes.Rows.Clear();
            dgvTareasSinAsignar.Rows.Clear();
            dgvReuniones.Rows.Clear();

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
            for (int i = 0; i < correos.Count; i++)
            {
                dgvBandeja.Rows.Add(correos[i].Id, correos[i].Asunto, correos[i].Cuerpo, correos[i].Remitente, correos[i].Fecha);
            }

            //Productos
            List<Tienda> list4 = new List<Tienda>();
            list4 = Tienda.Catalogo();
            for (int i = 0; i < list4.Count; i++)
            {
                dgvProductos.Rows.Add(list4[i].Id_prod, list4[i].Nombre, list4[i].Coste, list4[i].Descripcion);
            }

            // Reuniones

            List<Reuniones> list3 = new List<Reuniones>();
            list3 = Reuniones.ListadoReuniones(user.Id);
            for (int i = 0; i < list3.Count; i++)
            {
                string f = list3[i].Fecha.ToString("dd-MM-yyyy") + " // " + list3[i].Hora.ToString("HH:mm");
                dgvReuniones.Rows.Add(list3[i].Id, list3[i].Nombre, list3[i].Descripcion, f);
            }
            conexion.CerrarConexion();
        }
        public FrmFuncionalidades(bool lu, bool lan )
        {
            
            InitializeComponent();
            luz = lu;
            lang = lan;

        }

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            this.dgvProductos.Columns["codigo"].Visible = false;
            lblPuntos.Text = user.Puntos.ToString();
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





        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            RellenarDataGrid();
            conexion.CerrarConexion();
        }

        private void btnActualizarReuniones_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            RellenarDataGrid();
            conexion.CerrarConexion();
        }
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            if (Correo.YaEsta(txtDest.Text) == false)
            {
                MessageBox.Show("El destinatario ha sido introducido incorrectamente o no existe.");
                conexion.CerrarConexion();
            }
            else if (Usuario.ComprobarBorrado("correo", txtDest.Text) == true)
            {
                MessageBox.Show("El usuario al que intenta mandar el correo está eliminado.");
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");


                Correo cor = new Correo();

                cor.Asunto = txtAsunto.Text;
                cor.Cuerpo = txtCuerpo.Text;
                cor.Recipiente = txtDest.Text;
                cor.Remitente = user.Correo;
                cor.Fecha = sqlFormattedDate;


                conexion.AbrirConexion();
                Correo.AgregarCorreo(cor);
                conexion.CerrarConexion();
                MessageBox.Show("Correo enviado con éxito.");
                txtAsunto.Text = "";
                txtCuerpo.Text = "";
                txtDest.Text = "";
            }
        }



        private void btnCrearReunion_Click(object sender, EventArgs e)
        {
            CrearReunion reu = new CrearReunion(user,luz,lang);
            reu.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAsunto.Text = "";
            txtCuerpo.Text = "";
            txtDest.Text = "";
        }



        private void dgvTareasPendientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvTareasPendientes.Rows[e.RowIndex].Cells[4].Value != null)
            {
                int puntos = Convert.ToInt32(dgvTareasPendientes.Rows[e.RowIndex].Cells[4].Value);
                int id = Convert.ToInt32(dgvTareasPendientes.Rows[e.RowIndex].Cells[0].Value);

                user.Puntos = user.Puntos + puntos;
                conexion.AbrirConexion();
                Tarea.EliminarTarea(id);
                Tarea.AñadirPuntos(user);
                RellenarDataGrid();
                conexion.CerrarConexion();
                MessageBox.Show("Tarea completada, puntos actuales: "+user.Puntos.ToString());
                lblPuntos.Text = user.Puntos.ToString();

            }
              
        }

        private void dgvBandeja_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBandeja.Rows[e.RowIndex].Cells[2].Value != null)
            {
                MessageBox.Show(dgvBandeja.Rows[e.RowIndex].Cells[2].Value.ToString(), "Cuerpo: ");

            }
        }

       

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                string p_prod = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string cod = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                int p_produ = Convert.ToInt32(p_prod);


            if (user.Puntos >= p_produ)
            {
                conexion.AbrirConexion();
                user.Puntos = user.Puntos - p_produ;
                lblPuntos.Text = User.Puntos.ToString();
                Tienda.RestarPuntos(user.Id, user.Puntos);
                ;
                MessageBox.Show(cod, "Codigo :", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                conexion.CerrarConexion();
            }
            else
                MessageBox.Show("Puntos insuficientes");


            
        }

        private void btnCrearTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea tar = new AgregarTarea(user);
            tar.ShowDialog();
        }
    }
}

