using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVerde.Clases
{
    internal class Reuniones
    {
        private int id;
        private string nombre;
        private DateTime fecha;
        private string descripcion;
        private DateTime hora;
        
        public int Id { get => id; set => id = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public DateTime Hora { get => hora; set => hora = value; }

        public Reuniones() { }


        public static List<Reuniones> ListadoReuniones(int id)
        {
            List<Reuniones> reunions = new List<Reuniones>();
            string consulta = String.Format("SELECT * FROM reuniones INNER JOIN usuarios_has_reuniones ON usuarios_has_reuniones.reuniones_id =  reuniones.id && usuarios_has_reuniones.usuarios_id = ({0}) && reuniones.fecha >= CURRENT_DATE()", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de reuniones.
                while (reader.Read())
                {
                    Reuniones r = new Reuniones();
                    r.Id = reader.GetInt32(0);
                    r.Nombre = reader.GetString(4);
                    r.Fecha = reader.GetDateTime(2);
                    r.Hora = DateTime.Parse(reader.GetString(3));
                    r.Descripcion = reader.GetString(1);

                    DateTime f = DateTime.Parse(DateTime.Now.ToString("d"));
                    r.fecha = DateTime.Parse(r.Fecha.ToString("d"));

                    if (r.Fecha > f)
                    {
                        reunions.Add(r);
                    }
                    if (r.Fecha == f)
                    {
                        if (r.Hora.Hour > DateTime.Now.Hour)
                        {
                            reunions.Add(r);
                        }
                    }
                    
                }
            }
            reader.Close();
            return reunions;
        }
    }
}
