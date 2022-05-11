using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProyectoIntegradoVerde.Clases
{
    internal class Tienda
    {
        // Atributos

        private int id_prod;
        private string nombre;
        private int coste;
        private string descripcion;

        //Constructor completo
        public Tienda(int id ,string nom, int cost, string desc)
        {
            id_prod = id;
            nombre = nom;
            coste = cost;
            descripcion = desc;
        }

        //Constructor vacio
        public Tienda() { }

        //Getters y Setters
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Coste { get => coste; set => coste = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        //Metodos


        static public int AgregarProducto(MySqlConnection conexion, Tienda prod)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO tienda (id_prod,nombre,coste,descripcion) VALUES " +
                "('{0}','{1}','{2}','{3}')", prod.id_prod, prod.nombre, prod.coste, prod.descripcion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public bool YaEsta(MySqlConnection conexion, string nom)
        {
            string consulta = string.Format("SELECT * FROM tienda" +
            " WHERE nombre='{0}'", nom);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            { 
                reader.Close();  
                return true;
            }
            else
            {
                reader.Close(); 
                return false;
            }
        }

        public static int EliminarProducto(MySqlConnection conexion, string nom)
        {
            int retorno;

            string consulta = string.Format("DELETE FROM tienda WHERE nom={0}", nom);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


    }
    }
