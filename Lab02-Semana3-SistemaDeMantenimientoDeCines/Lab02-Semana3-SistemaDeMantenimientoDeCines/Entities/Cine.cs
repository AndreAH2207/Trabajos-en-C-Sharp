using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Semana3_SistemaDeMantenimientoDeCines.Entities
{
    class Cine
    {
        public Cine() { }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double Area { get; set; }
        public string Gerente {  get; set; }
        public int NumeroSalas {  get; set; }
        public string SitioWeb {  get; set; }
    }
}
