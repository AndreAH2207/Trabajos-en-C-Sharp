using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EVehiculo
    {
        public EVehiculo() { }
        public String Placa { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public double Precio { get; set; }
        public double Kilometraje { get; set; }
    }
}
