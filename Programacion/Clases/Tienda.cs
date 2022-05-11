using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
