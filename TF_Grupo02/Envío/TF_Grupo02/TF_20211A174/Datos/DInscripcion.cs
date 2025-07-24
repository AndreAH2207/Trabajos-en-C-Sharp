using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DInscripcion
    {
        public string Registrar(Inscripciones inscripcion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Inscripciones.Add(inscripcion);
                    context.SaveChanges();
                    return "Inscripción registrada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar inscripción: " + ex.Message;
            }
        }

        public string Modificar(Inscripciones inscripcion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existente = context.Inscripciones.Find(inscripcion.IdInscripcion);
                    if (existente != null)
                    {
                        existente.IdTorneo = inscripcion.IdTorneo;
                        existente.IdEquipo = inscripcion.IdEquipo;
                        existente.Estado = inscripcion.Estado;
                        context.SaveChanges();
                        return "Inscripción modificada correctamente.";
                    }
                    return "Inscripción no encontrada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar inscripción: " + ex.Message;
            }
        }

        public string Eliminar(int idInscripcion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var inscripcion = context.Inscripciones.Find(idInscripcion);
                    if (inscripcion != null)
                    {
                        context.Inscripciones.Remove(inscripcion);
                        context.SaveChanges();
                        return "Inscripción eliminada correctamente.";
                    }
                    return "Inscripción no encontrada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar inscripción: " + ex.Message;
            }
        }

        public List<Inscripciones> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Inscripciones
                    .Include("Torneos")
                    .Include("Equipos")
                    .ToList();
            }
        }

        public int ContarInscripcionesPorTorneo(int idTorneo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Inscripciones.Count(i => i.IdTorneo == idTorneo);
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<Equipos> ListarPorTorneoConfirmados(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var equipos = from insc in context.Inscripciones
                              join eq in context.Equipos on insc.IdEquipo equals eq.IdEquipo
                              where insc.IdTorneo == idTorneo && insc.Estado == "Confirmado"
                              select eq;

                return equipos.ToList();
            }
        }

    }
}
