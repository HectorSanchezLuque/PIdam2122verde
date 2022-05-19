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
        private string codigo;

        //Constructor completo
        public Tienda(int id ,string nom, int cost, string desc,string cod)
        {
            id_prod = id;
            nombre = nom;
            coste = cost;
            descripcion = desc;
            codigo = cod;
        }

        //Constructor vacio
        public Tienda() { }

        //Getters y Setters
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Coste { get => coste; set => coste = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //Metodos


        static public int AgregarProducto( Tienda prod)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO tienda (id_prod,nombre,coste,descripcion) VALUES " +
                "('{0}','{1}','{2}','{3}')", prod.id_prod, prod.nombre, prod.coste, prod.descripcion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public bool YaEsta(string nom)
        {
            string consulta = string.Format("SELECT * FROM tienda" +
            " WHERE nombre='{0}'", nom);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
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

        public static int EliminarProducto(string nom)
        {
            int retorno;

            string consulta = string.Format("DELETE FROM tienda WHERE nom={0}", nom);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<Tienda> Catalogo()
        {
            List<Tienda> productos = new List<Tienda>();
            string consulta = String.Format("SELECT * from tienda");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Tienda prod = new Tienda();
                    prod.Id_prod = reader.GetInt32(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Coste = reader.GetInt32(2);
                    prod.Descripcion = reader.GetString(3);
                    prod.Codigo = reader.GetString(4);
                    productos.Add(prod);
                }
                reader.Close();
            }
            return productos;
        }

        public static int RestarPuntos(int id, int Punt)
        {
            int retorno;

            string consulta = String.Format("UPDATE usuarios SET puntos = '{0}' Where id = '{1}'", Punt,id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
