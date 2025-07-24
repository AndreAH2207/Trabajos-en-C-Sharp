using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInscripcion
    {
        private DInscripcion dInscripcion = new DInscripcion();

        public string Registrar(Inscripciones inscripcion)
        {
            return dInscripcion.Registrar(inscripcion);
        }

        public List<Inscripciones> ListarPorTorneo(int idTorneo)
        {
            return dInscripcion.ListarPorTorneo(idTorneo);
        }
    }
}
