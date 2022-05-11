using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVerde.Clases
{
    internal class Tarea
    {
        private string titulo;
        private int puntos;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int Puntos { get { return puntos; } set { puntos = value; } }

        public Tarea() 
        {

        }
        

        public static List<Tarea> ListadoTareas()
        {
            List<Tarea> tareas = new List<Tarea>();
            string consulta = String.Format("SELECT * FROM tarea WHERE asignado = false && finalizado = false;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de tareas.
                while (reader.Read())
                {
                    Tarea t = new Tarea();
                    t.Titulo = reader.GetString(1);
                    t.puntos = reader.GetInt32(3);
                    tareas.Add(t);
                }
            }
            reader.Close();
            return tareas;
        }
    }
}
