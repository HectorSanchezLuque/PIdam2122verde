using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegradoVerde.Clases
{
    internal class Correo
    {
        // Atributos

        private int id;
        private string asunto;
        private string cuerpo;
        private string recipiente;
        private string remitente;
        private DateTime fecha;

        // Constructor vacio

        public Correo() { }

        // Constructor
        public Correo(int id, string asunto, string cuerpo, string recipiente, string remitente, DateTime fecha)
        {
            this.id = id;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.recipiente = recipiente;
            this.remitente = remitente;
            this.fecha = fecha;
        }

        // Getters/Setters
        public int Id { get => id; set => id = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Cuerpo { get => cuerpo; set => cuerpo = value; }
        public string Recipiente { get => recipiente; set => recipiente = value; }
        public string Remitente { get => remitente; set => remitente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        // Metodos

        /// <summary>
        /// Agrega un correo a la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="cor"></param>
        /// <returns></returns>
        static public int AgregarCorreo(MySqlConnection conexion, Correo cor)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO reuniones (idCorreo,asunto,cuerpo,recipiente,remitente,fecha) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", cor.id, cor.asunto, cor.cuerpo, cor.recipiente,cor.remitente,cor.fecha);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        /// <summary>
        ///  Comprueba si un correo ya existe o no previamente a su agregación
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="id">Id del correo</param>
        /// <returns>True si está y False si no está</returns>
        public bool YaEsta(MySqlConnection conexion, string id)
        {
            string consulta = string.Format("SELECT * FROM Correos" +
            " WHERE idCorreo='{0}'", id);

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
        /// Método para eliminar un correo en la Base de Datos.
        /// </summary>
        /// <param name="conexion">Objeto conexion</param>
        /// <param name="id">ID de la reunion a eliminar</param>
        /// <returns></returns>
        public static int EliminarCorreo(MySqlConnection conexion, int id)
        {
            int retorno;
            // Eliminamos definitivamente el usuario de la tabla usuario.
            string consulta = string.Format("DELETE FROM Correos WHERE id={0}", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        /// Método para actualizar los datos de un correo en la Base de Datos.
        /// </summary>
        /// <param name="conexion">objeto conexion</param>
        /// <param name="cor"> Nuevos datos del correo</param>
        /// <param name="ident"> Antiguo ID del correo</param>
        /// <returns></returns>
        public int ActualizarCorreo(MySqlConnection conexion, Correo cor, int ident)
        {

            int retorno;

            string consulta = string.Format("UPDATE Correos SET idCorreo = '{0}',asunto = '{1}',cuerpo = '{2}' ,remitente = '{3}', recipiente = '{4}' WHERE idCorreo={5}", cor.id, cor.asunto, cor.cuerpo, cor.remitente, cor.recipiente, ident);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
    }
}
