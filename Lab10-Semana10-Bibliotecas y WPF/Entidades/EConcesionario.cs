using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EConcesionario
    {
        public EConcesionario() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public String Dueño { get; set; }
        public List<EVehiculo> Vehiculos { get; set; }
    }
}
