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
        private string fecha;
        private int usuario_id;

        // Constructor vacio

        public Correo() { }

        // Constructor
        public Correo(int id, string asunto, string cuerpo, string recipiente, string remitente, string fecha, int usuario_id)
        {
            this.id = id;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.recipiente = recipiente;
            this.remitente = remitente;
            this.fecha = fecha;
            this.usuario_id = usuario_id;
        }


        // Getters/Setters
        public int Id { get => id; set => id = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Cuerpo { get => cuerpo; set => cuerpo = value; }
        public string Recipiente { get => recipiente; set => recipiente = value; }
        public string Remitente { get => remitente; set => remitente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Usuario_id { get => usuario_id; set => usuario_id = value; }

        // Metodos

        /// <summary>
        /// Agrega un correo a la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="cor"></param>
        /// <returns></returns>
        static public int AgregarCorreo(Correo cor)
        {
            int retorno;

                string consulta = String.Format("INSERT INTO Correos (idCorreo,asunto,cuerpo,recipiente,remitente,fecha,usuarios_id) VALUES " +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cor.id, cor.asunto, cor.cuerpo, cor.recipiente, cor.remitente, cor.fecha,cor.Usuario_id );

                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                retorno = comando.ExecuteNonQuery();

                return retorno;
        }
        /// <summary>
        ///  Comprueba si un correo ya existe o no previamente a su agregación
        /// </summary>
        /// <param name="id">Id del correo</param>
        /// <returns>True si está y False si no está</returns>
        public bool YaEsta(string id)
        {
            string consulta = string.Format("SELECT * FROM Correos" +
            " WHERE idCorreo='{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
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
        /// <param name="id">ID de la reunion a eliminar</param>
        /// <returns></returns>
        public static int EliminarCorreo(int id)
        {
            int retorno;
            // Eliminamos definitivamente el usuario de la tabla usuario.
            string consulta = string.Format("DELETE FROM Correos WHERE id={0}", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        /// Método para actualizar los datos de un correo en la Base de Datos.
        /// </summary>
        /// <param name="cor"> Nuevos datos del correo</param>
        /// <param name="ident"> Antiguo ID del correo</param>
        /// <returns></returns>
        public int ActualizarCorreo(Correo cor, int ident)
        {

            int retorno;

            string consulta = string.Format("UPDATE Correos SET idCorreo = '{0}',asunto = '{1}',cuerpo = '{2}' ,remitente = '{3}', recipiente = '{4}' WHERE idCorreo={5}", cor.id, cor.asunto, cor.cuerpo, cor.remitente, cor.recipiente, ident);


            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
        /// <summary>
        /// Crea una lista con la bandeja de entrada del usuario.
        /// </summary>
        /// <param name="correo">Usuario</param>
        /// <returns>Lista de correos</returns>
        public static List<Correo> Bandeja(string correo)
        {
            List<Correo> bandeja = new List<Correo>();
            string consulta = String.Format("SELECT * from Correos WHERE recipiente = '{0}'",correo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Correo co = new Correo();
                    co.id = reader.GetInt32(0);
                    co.asunto = reader.GetString(1);
                    co.cuerpo = reader.GetString(2);
                    co.recipiente = reader.GetString(3);
                    co.remitente = reader.GetString(4);
                    co.fecha = reader.GetString(5);
                    co.usuario_id = reader.GetInt32(6);
                    bandeja.Add(co);
                }
                reader.Close();
            }
            return bandeja;
        }
    }
}
