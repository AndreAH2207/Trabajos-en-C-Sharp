using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NPrestamos {

        private DPrestamos DP = new DPrestamos();

        public NPrestamos() { }


        public List<dynamic> PrestamosParaForm(string p_dni) {

            return DP.PrestamosParaForm(p_dni);
        }

        public List<Prestamos> ListarTodo() {

            return DP.ListarTodo();
        }

        public List<dynamic> VerEstadoDelPrestamo(string estado, DateTime fechaInicio, DateTime fechaDevolucionReal) {

            return DP.VerEstadoDelPrestamo(estado, fechaInicio, fechaDevolucionReal);
        }


    }
}
