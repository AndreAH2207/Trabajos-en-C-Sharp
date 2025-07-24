using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NMulta {

        DMulta DM = new DMulta();

        public NMulta() { }


        public List<dynamic> VerEstadoDeLaMulta(bool estado, string dni, DateTime fechaInicio, DateTime fechaFin) {

            return DM.VerEstadoDeLaMulta(estado, dni, fechaInicio, fechaFin);
        }




    }
}
