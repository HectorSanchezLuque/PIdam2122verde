using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Resources;
using System.IO;
using System.Drawing.Imaging;

namespace Programacion
{
    internal class Usuario
    {
        // Atributos
        private int id;
        private string nif;
        private string nombre;
        private DateTime fechaNacimiento;
        private string cargo;
        private int puntos;
        private string correo;
        private string password;
        private Image foto;

        //  Constructor con foto
         public Usuario(int idusu,string niff,string nom, DateTime nacimiento, string puesto, int points, string email, string passwd, Image fot )
        {
            id = idusu;
            nif = niff;
            nombre = nom;
            fechaNacimiento = nacimiento;
            cargo = puesto;
            correo = email;
            password = passwd;
            foto = fot;
        }
        // Constructor vacío
        public Usuario() { }

        // Getters y Setters
        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public Image Foto { get { return foto; } set { foto = value; } }


        // Metodos

        /// <summary>
        /// Comprueba si un usuario ha introducido su nombre y contraseña, también comprueba si el usuario es administrador.
        /// </summary>
        /// <param name="user">NIF del usuario</param>
        /// <param name="pass">Contraseña del usuario</param>
        /// <returns>Ha introducido la contraseña correctamente o no</returns>
        static public bool Verificador(string user, string pass)
        {
            bool correct = false;
            string search = "SELECT nif,pswd,cargo FROM empleados WHERE nif LIKE \"" + user + "\"";
            MySqlCommand comando = new MySqlCommand(search, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0) == user && reader.GetString(1) == pass) && (reader.GetString(2) == "Admin"))
                    correct = true;
            }
            reader.Close();
            comando.ExecuteNonQuery();
            return correct;
        }

        /// <summary>
        /// Agregar usuario a la base de datos.
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="usu"></param>
        /// <returns></returns>
        static public int AgregarUsuario(MySqlConnection conexion, Usuario usu) // Investigar
        {
            int retorno;

            // Preparación de la imagen
            MemoryStream ms = new MemoryStream();
            usu.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();


            // Imp: se puede cambiar la configuración regional del ordenador para que el signo
            // decimal sea el . y el signo de millares la , (MySQL está en formato USA)
            // o se añade en program.cs la siguiente linea:
            string consulta = String.Format("INSERT INTO usuarios (id,nif,nombre,fecha_nac,cargo,puntos,correo,pswd,imagen) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',@imagen)", usu.id, usu.nif, usu.nombre, usu.fechaNacimiento,
                usu.cargo, usu.puntos, usu.correo, usu.password);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        /// <summary>
        ///  Comprueba si un usuario está dado de alta o no previamente a su agregación
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nom">nombre del usuario</param>
        /// <returns>true si está y false si no está</returns>
        public bool YaEsta(MySqlConnection conexion, string nom)
        {
            string consulta = string.Format("SELECT * FROM usuarios" +
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
        /// Método para eliminar un usuario en la Base de Datos.
        /// </summary>
        /// <param name="conexion">Objeto conexion</param>
        /// <param name="nom">Nombre del usuario a eliminar</param>
        /// <returns></returns>
        public static int EliminaUsuario(MySqlConnection conexion, int nom)
        {
            int retorno;   
            // Eliminamos definitivamente el usuario de la tabla usuario.
            string consulta = string.Format("DELETE FROM usuarios WHERE nom={0}", nom);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }



    }
}
