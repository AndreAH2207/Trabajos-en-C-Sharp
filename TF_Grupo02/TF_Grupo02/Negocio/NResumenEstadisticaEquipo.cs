using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NResumenEstadisticaEquipo
    {
        private DResumenEstadisticaEquipo dResumen = new DResumenEstadisticaEquipo();

        public List<object> ObtenerPorTorneo(int idTorneo)
        {
            return dResumen.ObtenerPorTorneo(idTorneo);
        }
    }
}
