using System;
﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoIntegradoVerde.Clases
{
    internal class Tarea
    {

        private string titulo;
        private string descripcion;
        private int puntos;
        private bool asignado;
        private bool finalizado;

        // Constructor vacio
        public Tarea() { }

        // Constructor
        public Tarea(string titulo, string descripcion, int puntos, bool asignado, bool finalizado)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.puntos = puntos;
            this.asignado = asignado;
            this.finalizado = finalizado;
        }

        // Getters/Setters
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public bool Asignado { get => asignado; set => asignado = value; }
        public bool Finalizado { get => finalizado; set => finalizado = value; }

        // Metodos

        public static List<Tarea> ListadoTareas()
        {
            List<Tarea> tareas = new List<Tarea>();
            string consulta = String.Format("SELECT * FROM tarea;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de tareas.
                while (reader.Read())
                {
                    Tarea t = new Tarea();
                    t.Titulo = reader.GetString(1);
                    t.puntos = reader.GetInt32(3);
                    tareas.Add(t);
                }
                reader.Close();
            }
            return tareas;
        }

        /// Agregar tarea a la base de datos.
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="tar"></param>
        /// <returns></returns>
        static public int AgregarTarea(MySqlConnection conexion, Tarea tar)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO tarea (titulo,descripcion,puntos,asignado,finalizado) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", tar.titulo, tar.descripcion, tar.puntos, tar.asignado, tar.finalizado);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        /// <summary>
        ///  Comprueba si un usuario está dado de alta o no previamente a su agregación
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nom">nombre del usuario</param>
        /// <returns>true si está y false si no está</returns>
        public bool YaEsta(MySqlConnection conexion, string titulo)
        {
            string consulta = string.Format("SELECT * FROM tarea" +
            " WHERE titulo='{0}'", titulo);

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
        public static int EliminarTarea(MySqlConnection conexion, int titulo)
        {
            int retorno;
           
            string consulta = string.Format("DELETE FROM tarea WHERE titulo={0}", titulo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Método para actualizar los datos de un usuario en la Base de Datos.
        /// </summary>
        /// <param name="conexion">objeto conexion</param>
        /// <param name="usu"> datos del usuario a modificar</param>
        /// <returns></returns>

        }
    }
