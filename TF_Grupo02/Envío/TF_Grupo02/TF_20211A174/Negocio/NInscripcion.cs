using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NInscripcion
    {
        private DInscripcion dInscripcion = new DInscripcion();

        public string Registrar(Inscripciones inscripcion)
        {
            return dInscripcion.Registrar(inscripcion);
        }

        public string Modificar(Inscripciones inscripcion)
        {
            return dInscripcion.Modificar(inscripcion);
        }

        public string Eliminar(int idInscripcion)
        {
            return dInscripcion.Eliminar(idInscripcion);
        }

        public List<Inscripciones> ListarTodo()
        {
            return dInscripcion.ListarTodo();
        }
        public int ObtenerCantidadInscritosPorTorneo(int idTorneo)
        {
            return new DInscripcion().ContarInscripcionesPorTorneo(idTorneo);
        }

        public List<Equipos> ListarPorTorneoConfirmados(int idTorneo)
        {
            return dInscripcion.ListarPorTorneoConfirmados(idTorneo);
        }

    }
}
