using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Programacion
{
    internal class Usuario
    {
        // Atributos
        private string nif;
        private string nombre;
        private DateTime fechaNacimiento;
        private string cargo;
        private int puntos;
        private string correo;
        private string password;
        // private ??? foto;

        /*  Constructor con foto
         * public Usuario(string niff,string nom, DateTime nacimiento, string puesto, int points, string email, string passwd)//??? picture
        {
            nif = niff;
            nombre = nom;
            fechaNacimiento = nacimiento;
            cargo = puesto;
            correo = email;
            password = passwd;
            //foto = picture;
        }
        */

        // Constructor sin foto
        public Usuario(string niff, string nom, DateTime nacimiento, string puesto, int points, string email, string passwd)
        {
            nif = niff;
            nombre = nom;
            fechaNacimiento = nacimiento;
            cargo = puesto;
            correo = email;
            password = passwd;
        }

        // Getters y Setters
        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }

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

        static public void Registro(string nif, string nom, DateTime nacimiento, string puesto,string email, string pass)
        {
            string add = "INSERT INTO empleados VALUES(\"\",\"" + nif + "\",\"" + nom + "\",\"" + nacimiento + "\"," + puesto + ",\"\",\"" + email + "\",\"" + pass + "\")";
            MySqlCommand comando = new MySqlCommand(add, conexion.Conexion);
            comando.ExecuteNonQuery();
            // Comprobar si funciona.
        }

    }
}
