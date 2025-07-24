using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPartido
    {
        public string Registrar(Partidos partido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Partidos.Add(partido);
                    context.SaveChanges();
                    return "Partido registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar partido: " + ex.Message;
            }
        }

        public List<Partidos> ListarPorTorneo(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return context.Partidos
                              .Where(p => p.IdTorneo == idTorneo)
                              .ToList();
            }
        }

        public Partidos ObtenerPorId(int idPartido)
        {
            using (var context = new BDEFEntities())
            {
                return context.Partidos.Find(idPartido);
            }
        }

        public string EliminarPartidosPorTorneo(int idTorneo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var partidos = context.Partidos.Where(p => p.IdTorneo == idTorneo).ToList();
                    context.Partidos.RemoveRange(partidos);
                    context.SaveChanges();
                    return "Partidos anteriores eliminados correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar partidos anteriores: " + ex.Message;
            }
        }


        public (string campeon, string subcampeon) ObtenerFinalistas(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                var final = context.Partidos
                    .FirstOrDefault(p => p.IdTorneo == idTorneo && p.Ronda == "Final" && p.Estado == "Finalizado");

                if (final == null || final.IdGanador == null)
                    return ("No definido", "No definido");

                var campeon = context.Equipos.Find(final.IdGanador)?.NombreEquipo;
                var subcampeon = (final.IdGanador == final.IdEquipoLocal)
                    ? context.Equipos.Find(final.IdEquipoVisitante)?.NombreEquipo
                    : context.Equipos.Find(final.IdEquipoLocal)?.NombreEquipo;

                return (campeon, subcampeon);
            }
        }
    }
}
