using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DResultado
    {
        public string Registrar(Resultados resultado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Resultados.Add(resultado);
                    context.SaveChanges();
                    return "Resultado registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar resultado: " + ex.Message;
            }
        }

        public Resultados ObtenerPorPartido(int idPartido)
        {
            using (var context = new BDEFEntities())
            {
                return context.Resultados
                              .FirstOrDefault(r => r.IdPartido == idPartido);
            }
        }

        public List<Resultados> ListarPorPartido(int idPartido)
        {
            using (var context = new BDEFEntities())
            {
                return context.Resultados
                              .Where(r => r.IdPartido == idPartido)
                              .ToList();
            }
        }

        public List<Resultados> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                return context.Resultados.ToList();
            }
        }

        public List<Resultados> ListarPorTorneoConRelaciones(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Resultados
                    .Include("Partidos")
                    .Include("Partidos.Equipos")   // Local
                    .Include("Partidos.Equipos1")  // Visitante
                    .Where(r => r.Partidos.IdTorneo == idTorneo)
                    .ToList();
            }
        }
    }
}
