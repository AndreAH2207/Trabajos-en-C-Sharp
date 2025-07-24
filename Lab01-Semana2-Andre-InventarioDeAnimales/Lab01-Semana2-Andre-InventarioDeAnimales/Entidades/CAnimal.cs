using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Semana2_Andre_InventarioDeAnimales.Entidades
{
    internal class CAnimal
    {
        public CAnimal() { }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }

    }
}
