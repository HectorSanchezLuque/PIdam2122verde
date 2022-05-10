using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProyectoIntegradoVerde
{
    internal class conexion
    {

        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();

        private conexion() { }

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        string server = "server=database-1.cy5wu53qozpc.us-east-1.rds.amazonaws.com;";
                        string port = "port=3306;";
                        string database = "database=Proyecto_Integrado;";
                        string usuario = "uid=admin;";
                        string password = "pwd=admin123;";
                        instancia.ConnectionString = server + port + database + usuario + password;
                    }
                    return instancia;
                }
            }
        }


        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }


        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }
    }
}
