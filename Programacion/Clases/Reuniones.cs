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

        /// <summary>
        /// Crea una lista con las reuniones asociadas a un usuario.
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <returns></returns>
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
                reader.Close();
            }
            return reunions;
        }

        /// <summary>
        /// Crea una reunión y la introduce en la base de datos.
        /// </summary>
        /// <param name="cargo">Cargo al que va dirigido la reunión.</param>
        /// <param name="desc">Descripción de la reunión.</param>
        /// <param name="f">Fecha.</param>
        /// <param name="h">Hora.</param>
        /// <param name="n">Nombre.</param>
        /// <param name="user">Usuario.</param>
        public static void CReunion(string cargo, string desc, DateTime f, DateTime h, string n, Usuario user)
        {
            List<Usuario> lista = Usuario.BuscarCargos(cargo);
            int retorno;

            string consulta = String.Format("INSERT INTO reuniones (descripcion,fecha,hora,nombre) VALUES " +
                "('{0}','{1}','{2}','{3}')", desc, f.ToString("yyyy-MM-dd"), h.ToString("t"), n);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();

            if (user.Cargo != cargo)
            {
                string consulta2 = String.Format("INSERT INTO usuarios_has_reuniones (usuarios_id,reuniones_id) VALUES " +
                "('{0}',(SELECT MAX(id) FROM reuniones))", user.Id);
                MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
                retorno = comando2.ExecuteNonQuery();
            }

            for (int i = 0; i < lista.Count; i++)
            {
                string consulta3 = String.Format("INSERT INTO usuarios_has_reuniones (usuarios_id,reuniones_id) VALUES " +
                    "('{0}',(SELECT MAX(id) FROM reuniones))", lista[i].Id);
                MySqlCommand comando3 = new MySqlCommand(consulta3, conexion.Conexion);
                retorno = comando3.ExecuteNonQuery();
            }
        }
    }
}
