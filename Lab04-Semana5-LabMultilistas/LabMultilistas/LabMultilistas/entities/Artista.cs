using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMultilistas.entities
{
    class Artista
    {
        public Artista() { }
        public String Codigo { get; set; }
        public String Seudonimo { get; set; }
        public int Edad { get; set; }
        public List<Cuadro> Cuadros { get; set; }
    }
}
