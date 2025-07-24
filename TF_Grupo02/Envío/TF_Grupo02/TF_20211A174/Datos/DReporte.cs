using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DReporte
    {
        // 1. Top 5 Equipos con mejor diferencia de goles
        public List<object> TopDiferenciaGoles(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return (from r in context.ResumenEstadisticasEquipo
                        join e in context.Equipos on r.IdEquipo equals e.IdEquipo
                        where r.IdTorneo == idTorneo
                        let diferencia = r.GolesFavor - r.GolesContra
                        orderby diferencia descending
                        select new
                        {
                            Equipo = e.NombreEquipo,
                            GolesAFavor = r.GolesFavor,
                            GolesEnContra = r.GolesContra,
                            Diferencia = diferencia
                        })
                        .Take(5)
                        .ToList<object>();
            }
        }

        // 2. Jugadores con más asistencias
        public List<object> TopAsistencias(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return (from e in context.EstadisticasJugador
                        join j in context.Jugadores on e.IdJugador equals j.IdJugador
                        join eq in context.Equipos on j.IdEquipo equals eq.IdEquipo
                        join p in context.Partidos on e.IdPartido equals p.IdPartido
                        where p.IdTorneo == idTorneo
                        group e by new { j.Nombres, j.Apellidos, eq.NombreEquipo } into g
                        select new
                        {
                            Jugador = g.Key.Nombres + " " + g.Key.Apellidos,
                            Equipo = g.Key.NombreEquipo,
                            Asistencias = g.Sum(x => x.Asistencias)
                        })
                        .OrderByDescending(x => x.Asistencias)
                        .Take(10)
                        .ToList<object>();
            }
        }

        // 3. Promedio de goles por torneo
        public List<object> PromedioGolesPorTorneo()
        {
            using (var context = new BDEFEntities())
            {
                return (from r in context.Resultados
                        join p in context.Partidos on r.IdPartido equals p.IdPartido
                        join t in context.Torneos on p.IdTorneo equals t.IdTorneo
                        group r by new { t.IdTorneo, t.NombreTorneo } into g
                        select new
                        {
                            Torneo = g.Key.NombreTorneo,
                            TotalPartidos = g.Count(),
     
                            TotalGoles = g.Sum(x => x.GolesEquipoLocal + x.GolesEquipoVisitante),
                            PromedioGoles = g.Average(x => x.GolesEquipoLocal + x.GolesEquipoVisitante)
                        })
                        .ToList<object>();
            }
        }

        // 4. Ranking de equipos por efectividad
        public List<object> RankingEfectividad(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return (from r in context.ResumenEstadisticasEquipo
                        join e in context.Equipos on r.IdEquipo equals e.IdEquipo
                        where r.IdTorneo == idTorneo && r.PartidosJugados > 0
                        select new
                        {
                            Equipo = e.NombreEquipo,
                            PartidosJugados = r.PartidosJugados,
                            PartidosGanados = r.PartidosGanados,
                            Efectividad = ((double)r.PartidosGanados / r.PartidosJugados) * 100
                        })
                        .OrderByDescending(x => x.Efectividad)
                        .ToList<object>();
            }
        }

        public List<object> JugadoresConMasGoles(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var topGoleadores = (from e in context.EstadisticasJugador
                                   join j in context.Jugadores on e.IdJugador equals j.IdJugador
                                   join eq in context.Equipos on j.IdEquipo equals eq.IdEquipo
                                   join p in context.Partidos on e.IdPartido equals p.IdPartido
                                   where p.IdTorneo == idTorneo
                                   group e by new { j.Nombres, j.Apellidos, eq.NombreEquipo } into g
                                   orderby g.Sum(x => x.Goles) descending
                                   select new
                                   {
                                       Jugador = g.Key.Nombres + " " + g.Key.Apellidos,
                                       Equipo = g.Key.NombreEquipo,
                                       Goles = g.Sum(x => x.Goles)
                                   }).Take(10).ToList<object>();

                return topGoleadores;
            }
        }

        public List<object> PromedioPartidosPorTorneo()
        {
            using (var context = new BDEFEntities())
            {
                return (from r in context.ResumenEstadisticasEquipo
                        join t in context.Torneos on r.IdTorneo equals t.IdTorneo
                        group r by new { t.IdTorneo, t.NombreTorneo } into g
                        select new
                        {
                            Torneo = g.Key.NombreTorneo,
                            TotalEquipos = g.Count(),
                            PromedioPartidos = g.Average(x => x.PartidosJugados)
                        })
                        .ToList<object>();
            }
        }

        public List<object> PromedioFaltas(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return (from e in context.EstadisticasJugador
                        join j in context.Jugadores on e.IdJugador equals j.IdJugador
                        join eq in context.Equipos on j.IdEquipo equals eq.IdEquipo
                        join p in context.Partidos on e.IdPartido equals p.IdPartido
                        join t in context.Torneos on p.IdTorneo equals t.IdTorneo
                        where p.IdTorneo == idTorneo
                        group e by new { eq.NombreEquipo, t.NombreTorneo } into g
                        select new
                        {
                            NombreEquipo = g.Key.NombreEquipo,
                            NombreTorneo = g.Key.NombreTorneo,
                            Faltas = g.Average(x => x.Faltas)
                        })
                        .OrderByDescending(x => x.Faltas)
                        .ToList<object>();
            }
        }
    }
}
