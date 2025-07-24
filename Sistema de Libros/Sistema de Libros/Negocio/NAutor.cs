using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NAutor {

        DAutor dAutor = new DAutor();

        public NAutor() { }


        public String Registrar(Autores autor) {

            return dAutor.Registrar(autor);
        }

        public List<string> ObtenerNombresDeAutores() {

            return dAutor.ObtenerNombresDeAutores();
        }

        public Autores ObtenerAutor(string p_nombreCompleto) {

            return dAutor.ObtenerAutor(p_nombreCompleto);
        }

    }
}
