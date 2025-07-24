using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstadisticaJugador
    {
        public string Registrar(EstadisticasJugador estadistica)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.EstadisticasJugador.Add(estadistica);
                    context.SaveChanges();
                    return "Estadística registrada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar estadística: " + ex.Message;
            }
        }

        public List<EstadisticasJugador> ListarPorPartido(int idPartido)
        {
            using (var context = new BDEFEntities())
            {
                return context.EstadisticasJugador
                              .Where(e => e.IdPartido == idPartido)
                              .ToList();
            }
        }

        public EstadisticasJugador ObtenerPorPartidoYJugador(int idPartido, int idJugador)
        {
            using (var context = new BDEFEntities())
            {
                return context.EstadisticasJugador
                    .FirstOrDefault(e => e.IdPartido == idPartido && e.IdJugador == idJugador);
            }
        }

        public string Modificar(EstadisticasJugador estadistica)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existente = context.EstadisticasJugador
                        .FirstOrDefault(e => e.IdEstadistica == estadistica.IdEstadistica);

                    if (existente != null)
                    {
                        existente.Goles = estadistica.Goles;
                        existente.Asistencias = estadistica.Asistencias;
                        existente.Faltas = estadistica.Faltas;
                        context.SaveChanges();
                        return "Estadística modificada correctamente.";
                    }

                    return "Estadística no encontrada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar estadística: " + ex.Message;
            }
        }

        public List<object> ObtenerPorTorneo(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var estadisticas = (from ej in context.EstadisticasJugador
                                    join j in context.Jugadores on ej.IdJugador equals j.IdJugador
                                    join eq in context.Equipos on j.IdEquipo equals eq.IdEquipo
                                    join p in context.Partidos on ej.IdPartido equals p.IdPartido
                                    where p.IdTorneo == idTorneo
                                    select new
                                    {
                                        Jugador = j.Nombres + " " + j.Apellidos,
                                        Equipo = eq.NombreEquipo,
                                        Goles = ej.Goles,
                                        Asistencias = ej.Asistencias,
                                        Faltas = ej.Faltas,
                                        Partido = p.Ronda,
                                        Fecha = p.FechaHora
                                    }).ToList<object>();

                return estadisticas;
            }
        }

        public List<object> ObtenerTopGoleadores(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var top = (from e in context.EstadisticasJugador
                           join j in context.Jugadores on e.IdJugador equals j.IdJugador
                           join eq in context.Equipos on j.IdEquipo equals eq.IdEquipo
                           join p in context.Partidos on e.IdPartido equals p.IdPartido
                           where p.IdTorneo == idTorneo
                           group e by new { j.Nombres, j.Apellidos, eq.NombreEquipo } into g
                           select new
                           {
                               Jugador = g.Key.Nombres + " " + g.Key.Apellidos,
                               Equipo = g.Key.NombreEquipo,
                               Goles = g.Sum(x => x.Goles)
                           })
                          .OrderByDescending(g => g.Goles)
                          .Take(5)
                          .ToList<object>();

                return top;
            }
        }
    }
}
