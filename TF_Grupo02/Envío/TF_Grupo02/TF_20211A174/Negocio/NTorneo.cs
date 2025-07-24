using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NTorneo
    {
        private DTorneo dTorneo = new DTorneo();

        public string Registrar(Torneos torneo)
        {
            if (string.IsNullOrWhiteSpace(torneo.NombreTorneo))
                return "El nombre del torneo es obligatorio.";
            if (torneo.FechaInicio >= torneo.FechaFin)
                return "La fecha de inicio debe ser menor a la fecha de fin.";

            return dTorneo.Registrar(torneo);
        }

        public string Modificar(Torneos torneo)
        {
            return dTorneo.Modificar(torneo);
        }

        public string Eliminar(int idTorneo)
        {
            return dTorneo.Eliminar(idTorneo);
        }

        public List<Torneos> ListarTodo()
        {
            return dTorneo.ListarTodo();
        }

        public Torneos ObtenerPorId(int idTorneo)
        {
            return dTorneo.ObtenerPorId(idTorneo);
        }
    }
}
