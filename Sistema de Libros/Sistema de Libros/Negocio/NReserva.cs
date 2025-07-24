using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NReserva {

        DReserva DR = new DReserva();

        public NReserva() { }

        public bool CrearReserva(int libroId, DateTime fechaDevolucion, Usuarios usuario) {

            return DR.CrearReserva(libroId, fechaDevolucion, usuario);           
        }



    }
}
