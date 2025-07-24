using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NJugador
    {
        private DJugador dJugador = new DJugador();

        public string Registrar(Jugadores jugador)
        {
            if (jugador.DNI.Length != 8)
                return "El DNI debe tener 8 dígitos.";

            return dJugador.Registrar(jugador);
        }

        public string Modificar(Jugadores jugador)
        {
            return dJugador.Modificar(jugador);
        }

        public string Eliminar(int id)
        {
            return dJugador.Eliminar(id);
        }

        public List<Jugadores> ListarTodo()
        {
            return dJugador.ListarTodo();
        }
        public Jugadores ObtenerPorId(int idJugador)
        {
            return dJugador.ObtenerPorId(idJugador);
        }

        public List<Jugadores> ListarPorEquipo(int idEquipo)
        {
            return dJugador.ListarPorEquipo(idEquipo);
        }


    }
}
