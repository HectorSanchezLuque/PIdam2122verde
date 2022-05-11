using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegradoVerde.Clases
{
    internal class Reunion
    {
        // Atributos
        private int id;
        private List<Usuario> participantes = new List<Usuario>();
        private DateTime fechaHora;
        private string titulo;

        // Constructor vacío
        public Reunion() { }

        // Constructor
        public Reunion(List<Usuario> participantes, DateTime fechaHora, string titulo)
        {
            this.participantes = participantes;
            this.fechaHora = fechaHora;
            this.titulo = titulo;
        }

        // Getters y setters
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        internal List<Usuario> Participantes { get => participantes; set => participantes = value; }

        // Metodos


        static public int AgregarReunion(MySqlConnection conexion, Reunion reu)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO reuniones (id,participantes,nombre,fechaHora) VALUES " +
                "('{0}','{1}','{2}','{3}')", reu.id, reu.participantes, reu.titulo, reu.fechaHora);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        /// <summary>
        ///  Comprueba si una reunión ya existe o no previamente a su agregación
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nom">Titulo de la reunion</param>
        /// <returns>True si está y False si no está</returns>
        public bool YaEsta(MySqlConnection conexion, string nom)
        {
            string consulta = string.Format("SELECT * FROM reuniones" +
            " WHERE nombre='{0}'", nom);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            { // si existen registros en la devolución de la consulta
                reader.Close();   // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return true;
            }
            else
            {
                reader.Close();  // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return false;
            }

        }
        /// <summary>
        /// Método para eliminar una reunion en la Base de Datos.
        /// </summary>
        /// <param name="conexion">Objeto conexion</param>
        /// <param name="id">ID de la reunion a eliminar</param>
        /// <returns></returns>
        public static int EliminarReunion(MySqlConnection conexion, int id)
        {
            int retorno;
            // Eliminamos definitivamente el usuario de la tabla usuario.
            string consulta = string.Format("DELETE FROM reuniones WHERE id={0}", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        /// Método para actualizar los datos de una reunion en la Base de Datos.
        /// </summary>
        /// <param name="conexion">objeto conexion</param>
        /// <param name="reu"> Nuevos datos de la reunion</param>
        /// <param name="ident"> Antiguo ID de la reunion</param>
        /// <returns></returns>
        public int ActualizaUsuario(MySqlConnection conexion, Reunion reu, int ident)
        {

            int retorno;

            string consulta = string.Format("UPDATE reuniones SET id = '{0}',participantes = '{1}',nombre = '{2}' ,fechaHora = '{3}' WHERE id={4}", reu.id, reu.participantes, reu.titulo, reu.fechaHora,ident);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
    }
}
