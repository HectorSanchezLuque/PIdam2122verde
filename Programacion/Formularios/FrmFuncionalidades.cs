﻿using ProyectoIntegradoVerde.Clases;
using System;
using System.Collections.Generic;
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
                dgvBandeja.Rows.Add(correos[i].Id, correos[i].Asunto, correos[i].Cuerpo, correos[i].Recipiente, correos[i].Remitente, correos[i].Fecha);
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
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            Correo cor = new Correo();

            cor.Asunto = txtAsunto.Text;
            cor.Cuerpo = txtCuerpo.Text;
            cor.Recipiente = txtDest.Text;
            cor.Remitente = user.Correo;
            cor.Fecha = sqlFormattedDate;
            cor.Usuario_id = user.Id;

            conexion.AbrirConexion();
            Correo.AgregarCorreo(cor);
            conexion.CerrarConexion();
        }


        private void dgvBandeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBandeja.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dgvBandeja.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),"Cuerpo");
            }
        }
    }
}

