using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReporte
    {
        private DReporte dReporte = new DReporte();

        public List<object> TopDiferenciaGoles(int idTorneo)
        {
            return dReporte.TopDiferenciaGoles(idTorneo);
        }

        public List<object> TopAsistencias(int idTorneo)
        {
            return dReporte.TopAsistencias(idTorneo);
        }

        public List<object> PromedioGolesPorTorneo()
        {
            return dReporte.PromedioGolesPorTorneo();
        }

        public List<object> RankingEfectividad(int idTorneo)
        {
            return dReporte.RankingEfectividad(idTorneo);
        }

        public List<object> JugadoresConMasGoles(int idTorneo)
        {
            return dReporte.JugadoresConMasGoles(idTorneo);
        }

        public List<object> PromedioFaltas(int idTorneo)
        {
            return dReporte.PromedioFaltas(idTorneo) ;
        }
    }
}