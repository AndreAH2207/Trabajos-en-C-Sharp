using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.entities
{
    internal class Cine
    {
        // Constructor
        public Cine()
        {
            Peliculas = new List<Pelicula>();
        }

        // Propiedades
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public double Area { get; set; }
        public string Gerente { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }

        // Lista de películas
        public List<Pelicula> Peliculas { get; set; }
    }
}

