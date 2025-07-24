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
        public string ActualizarResumen(int idTorneo, int idEquipo, bool gano, int golesFavor, int golesContra)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var resumen = context.ResumenEstadisticasEquipo
                        .FirstOrDefault(r => r.IdTorneo == idTorneo && r.IdEquipo == idEquipo);

                    if (resumen == null)
                    {
                        resumen = new ResumenEstadisticasEquipo();
                        resumen.IdTorneo = idTorneo;
                        resumen.IdEquipo = idEquipo;
                        resumen.PartidosJugados = 1;

                        if (gano)
                            resumen.PartidosGanados = 1;
                        else
                            resumen.PartidosGanados = 0;

                        if (!gano)
                            resumen.PartidosPerdidos = 1;
                        else
                            resumen.PartidosPerdidos = 0;

                        resumen.GolesFavor = golesFavor;
                        resumen.GolesContra = golesContra;

                        context.ResumenEstadisticasEquipo.Add(resumen);
                    }
                    else
                    {
                        resumen.PartidosJugados = resumen.PartidosJugados + 1;

                        if (gano)
                            resumen.PartidosGanados = resumen.PartidosGanados + 1;

                        if (!gano)
                            resumen.PartidosPerdidos = resumen.PartidosPerdidos + 1;

                        resumen.GolesFavor = resumen.GolesFavor + golesFavor;
                        resumen.GolesContra = resumen.GolesContra + golesContra;
                    }

                    context.SaveChanges();
                    return "Resumen actualizado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar resumen: " + ex.Message;
            }
        }

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
