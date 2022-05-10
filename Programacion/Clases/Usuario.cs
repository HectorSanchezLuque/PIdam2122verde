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
        // private ??? foto;

        //*  Constructor con foto
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
        /// Agregar nuevo usuario a la tabla usuarios
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="nom"></param>
        /// <param name="nacimiento"></param>
        /// <param name="puesto"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        static public int AgregarUsuario(MySqlConnection conexion, Usuario usu)
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

        

    }
}
