using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVerde.Clases
{
    class Reuniones
    {
        private int id;
        private string descripcion;
        private DateTime fecha;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public Reuniones() 
        {
            
        }

        public static List<Reuniones> ListadoReuniones(int userID)
        {
            List<Reuniones> reunions = new List<Reuniones>();
            string consulta = String.Format("SELECT * FROM reuniones r LEFT JOIN usuarios_has_reuniones u ON r.id = u.reuniones_id WHERE u.usuarios_id = ({0});", userID);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de tareas.
                while (reader.Read())
                {
                    Reuniones r = new Reuniones();
                    r.Id = reader.GetInt32(0);
                    r.Descripcion = reader.GetString(1);
                    r.Fecha = reader.GetDateTime(2);
                    r.Nombre = reader.GetString(3);
                    reunions.Add(r);
                }
            }
            reader.Close();
            return reunions;
        }

    }
}
