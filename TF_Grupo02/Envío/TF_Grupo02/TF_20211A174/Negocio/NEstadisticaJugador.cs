using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstadisticaJugador
    {
        private DEstadisticaJugador dEstadistica = new DEstadisticaJugador();

        public string Registrar(EstadisticasJugador estadistica)
        {
            if (estadistica.IdPartido <= 0 || estadistica.IdJugador <= 0)
                return "Datos inválidos.";

            return dEstadistica.Registrar(estadistica);
        }

        public string Modificar(EstadisticasJugador estadistica)
        {
            return dEstadistica.Modificar(estadistica);
        }

        public List<EstadisticasJugador> ListarPorPartido(int idPartido)
        {
            return dEstadistica.ListarPorPartido(idPartido);
        }

        public EstadisticasJugador ObtenerPorPartidoYJugador(int idPartido, int idJugador)
        {
            return dEstadistica.ObtenerPorPartidoYJugador(idPartido, idJugador);
        }

        public List<object> ObtenerPorTorneo(int idTorneo)
        {
            return dEstadistica.ObtenerPorTorneo(idTorneo);
        }
    }
}