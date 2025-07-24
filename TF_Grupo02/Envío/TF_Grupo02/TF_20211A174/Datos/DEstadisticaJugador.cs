using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    var existente = context.EstadisticasJugador
                        .FirstOrDefault(e => e.IdPartido == estadistica.IdPartido && e.IdJugador == estadistica.IdJugador);

                    if (existente != null)
                    {
                        existente.Goles = estadistica.Goles;
                        existente.Asistencias = estadistica.Asistencias;
                        existente.Faltas = estadistica.Faltas;
                        existente.FechaRegistro = DateTime.Now;
                    }

                    else
                    {
                        estadistica.FechaRegistro = DateTime.Now;
                        context.EstadisticasJugador.Add(estadistica);
                    }

                    context.SaveChanges();
                    return "Estadística registrada o actualizada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar o actualizar estadística: " + ex.Message;
            }
        }


        public List<EstadisticasJugador> ListarPorPartido(int idPartido)
        {
            using (var context = new BDEFEntities())
            {
                return context.EstadisticasJugador
                    .Where(e => e.IdPartido == idPartido)
                    .Include("Jugadores")
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
    }
}
