using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NLibroAutor {

        DLibroAutor DLA = new DLibroAutor();

        public void Registrar(int p_libroId, int p_autorId) {

            DLA.Registrar(p_libroId, p_autorId);
        }



    }
}
