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
        public string ActualizarResumen(int idTorneo, int idEquipo, bool gano, int golesFavor, int golesContra)
        {
            return dResumen.ActualizarResumen(idTorneo, idEquipo, gano, golesFavor, golesContra);
        }
        public List<object> ObtenerPorTorneo(int idTorneo)
        {
            return dResumen.ObtenerPorTorneo(idTorneo);
        }
    }
}
