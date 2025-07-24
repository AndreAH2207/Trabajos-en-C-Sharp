using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DResumenEstadisticaEquipo
    {
        public List<object> ObtenerPorTorneo(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var resumen = (from r in context.ResumenEstadisticasEquipo
                               join e in context.Equipos on r.IdEquipo equals e.IdEquipo
                               where r.IdTorneo == idTorneo
                               select new
                               {
                                   Equipo = e.NombreEquipo,
                                   PJ = r.PartidosJugados,
                                   PG = r.PartidosGanados,
                                   PP = r.PartidosPerdidos,
                                   GF = r.GolesFavor,
                                   GC = r.GolesContra,
                                   DIF = r.GolesFavor - r.GolesContra
                               })
                               .OrderByDescending(r => r.PG)
                               .ThenByDescending(r => r.DIF)
                               .ToList<object>();

                return resumen;
            }
        }
    }
}
