using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Inscripciones> ListarPorTorneo(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return context.Inscripciones
                              .Where(i => i.IdTorneo == idTorneo)
                              .ToList();
            }
        }
    }
}
