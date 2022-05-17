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

namespace ProyectoIntegradoVerde
{
    public class Usuario
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
         public Usuario(string niff,string nom, DateTime nacimiento, string puesto, string email, string passwd, Image fot )
        {
           
            nif = niff;
            nombre = nom;
            fechaNacimiento = nacimiento;
            cargo = puesto;
            correo = email;
            password = passwd;
            foto = fot;
            puntos = 0;
            
        }
        // Constructor vacío
        public Usuario() { }

        // Getters y Setters
        public int Id { get => id; set  => id = value; }
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
        /// <returns>0 si la contraseña es incorrecta. 1 si la contraseña es correcta pero no es administrador. 2 si la contraseña es correcta y es administrador.</returns>
        static public int Verificador(string user, string pass)
        {
            int correct = 0;
            string search = "SELECT nif,pswd,cargo FROM empleados WHERE nif LIKE \"" + user + "\"";
            MySqlCommand comando = new MySqlCommand(search, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0) == user && reader.GetString(1) == pass) && (reader.GetString(2) != "Admin"))
                    return correct = 1;
                else if ((reader.GetString(0) == user && reader.GetString(1) == pass) && (reader.GetString(2) == "Admin"))
                    correct = 2;
            }
            reader.Close();
            comando.ExecuteNonQuery();
            return correct;
        }

        /// <summary>
        /// Agregar usuario a la base de datos.
        /// </summary>
        /// <param></param>
        /// <returns></returns>
         public int AgregarUsuario() // Investigar
        {
            int retorno;

            // Preparación de la imagen
            MemoryStream ms = new MemoryStream();
            this.foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();

            // Imp: se puede cambiar la configuración regional del ordenador para que el signo
            // decimal sea el . y el signo de millares la , (MySQL está en formato USA)
            // o se añade en program.cs la siguiente linea:
            string consulta = String.Format("INSERT INTO usuarios (nif,nombre,fecha_nac,cargo,puntos,correo,pswd,imagen) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}',@imagen)", this.nif, this.nombre, this.fechaNacimiento,
                this.cargo, this.puntos, this.correo, this.password);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        /// <summary>
        ///  Comprueba si un usuario está dado de alta o no previamente a su agregación
        /// </summary>
        /// <param name="nif">nif del usuario</param>
        /// <returns>true si está y false si no está</returns>
        public bool YaEsta(string nif)
        {
            string consulta = string.Format("SELECT * FROM usuarios" +
            " WHERE nombre='{0}'", nif);

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
        /// Método para eliminar un usuario en la Base de Datos.
        /// </summary>
        /// <param name="nif">Nombre del usuario a eliminar</param>
        /// <returns></returns>
        public static int EliminaUsuario(int nif)
        {
            int retorno;   
            // Eliminamos definitivamente el usuario de la tabla usuario.
            string consulta = string.Format("DELETE FROM usuarios WHERE nif={0}", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        /// Método para actualizar los datos de un usuario en la Base de Datos.
        /// </summary>
        /// <param name="usu"> datos del usuario a modificar</param>
        /// <returns></returns>
        public int ActualizaUsuario(Usuario usu)
        {

            int retorno;

          
            MemoryStream ms = new MemoryStream();
            usu.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();

            string consulta = string.Format("UPDATE usuarios SET id = '{1}',nif = '{2}',nombre = '{3}' ,fecha_nac = '{4}',cargo = '{5}',puntos = '{6}',correo = '{7}',pswd = '{8}',imagen=@imagen WHERE id={6}", usu.id, usu.nif, usu.nombre, usu.fechaNacimiento,
                usu.cargo, usu.puntos, usu.correo, usu.password);
     

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

       
            return retorno;
        }

        public static Usuario BuscarUsuario(string nif)
        {
            Usuario usu = new Usuario();
            string consulta = String.Format("SELECT * FROM usuarios WHERE nif = '{0}';", nif); ;
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de tareas.
                while (reader.Read())
                {
                    usu.Id = reader.GetInt32(0);
                    usu.Nif = reader.GetString(1);
                    usu.Nombre = reader.GetString(2);
                    usu.FechaNacimiento = reader.GetDateTime(3);
                    usu.Cargo = reader.GetString(4);
                    usu.Puntos = reader.GetInt32(5);
                    usu.Correo = reader.GetString(6);
                    usu.Password = reader.GetString(7);
                }
            }
            reader.Close();
            return usu;
        }

        /// <summary>
        /// Comprueba si el nif introducido es válido
        /// </summary>
        /// <param name="nif">nif del usuario</param>
        /// <returns>Compureba si la letra de nif es correcta devuele true si es asi</returns>
        static public bool compNif(string nif)
        {

            string num = "";
            string lets = "TRWAGMYFPDXBNJZSQVHLCKE";
            char let;

            if (nif.Length != 9)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nif.Length - 1; i++)
                {
                    if (char.IsDigit(nif[i]))
                    {
                        num += nif[i];
                    }
                    else
                    {
                        return false;
                    }

                }
                let = lets[int.Parse(num) % 23];
                if (let == nif[nif.Length - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        /// <summary>
        /// A través de un tipo de campo de la base de datos introducido junto a su valor, devolvera si el usuario al cual pertenece ese valor está borrado o no.
        /// Ejemplo: ComprobarBorrado("correo","ejemplo@hotmail.com"). Buscara en el campo correo el usuario de "ejemplo@hotmail.com" y devolverá si está borrado o no.
        /// 
        /// </summary>
        /// <param name="campoDato">Campo de la BdD</param>
        /// <param name="valorDato">Valor del dato</param>
        /// <returns>True si está borrado, False si no está borrado.</returns>
        static public bool ComprobarBorrado(string campoDato,string valorDato)
        {
            bool existe = false;

            string verificador = "SELECT borrado FROM usuarios WHERE "+campoDato+"='" + valorDato + "';";

            MySqlCommand verif = new MySqlCommand(verificador, conexion.Conexion);
            MySqlDataReader reader = verif.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetBoolean(0) == true)
                {
                    existe = true;
                }
                else existe = false;
            }
            return existe;
        }
    }
}
