using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.entities
{
    internal class Pelicula
    {
        public Pelicula() { }

        public String Codigo { get; set; }
        public String Titulo {  get; set; }
        public String Valoracion { get; set; }
        public String Genero { get; set; }
        public int Duracion { get; set; }
        public double Recaudacion {  get; set; }
    }
}
