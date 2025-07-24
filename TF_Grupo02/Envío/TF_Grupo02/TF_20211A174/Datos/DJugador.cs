using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Datos
{
    public class DJugador
    {
        public string Registrar(Jugadores jugador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    jugador.FechaRegistro = DateTime.Now;
                    context.Jugadores.Add(jugador);
                    context.SaveChanges();
                    return "Jugador registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar jugador: " + ex.Message;
            }
        }

        public string Modificar(Jugadores jugador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existente = context.Jugadores.Find(jugador.IdJugador);
                    if (existente != null)
                    {
                        existente.Nombres = jugador.Nombres;
                        existente.Apellidos = jugador.Apellidos;
                        existente.DNI = jugador.DNI;
                        existente.FechaNacimiento = jugador.FechaNacimiento;
                        existente.IdEquipo = jugador.IdEquipo;
                        context.SaveChanges();
                        return "Jugador modificado correctamente.";
                    }
                    return "Jugador no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar jugador: " + ex.Message;
            }
        }

        public string Eliminar(int idJugador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var jugador = context.Jugadores.Find(idJugador);
                    if (jugador != null)
                    {
                        context.Jugadores.Remove(jugador);
                        context.SaveChanges();
                        return "Jugador eliminado correctamente.";
                    }
                    return "Jugador no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar jugador: " + ex.Message;
            }
        }

        public List<Jugadores> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Jugadores.Include("Equipos").ToList(); 
            }
        }

        public Jugadores ObtenerPorId(int idJugador)
        {
            using (var context = new BDEFEntities())
            {
                return context.Jugadores.Include("Equipos").FirstOrDefault(j => j.IdJugador == idJugador);
            }
        }

        public List<Jugadores> ListarPorEquipo(int idEquipo)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Jugadores
                              .Include("Equipos")
                              .Where(j => j.IdEquipo == idEquipo)
                              .ToList();
            }
        }

    }
}
