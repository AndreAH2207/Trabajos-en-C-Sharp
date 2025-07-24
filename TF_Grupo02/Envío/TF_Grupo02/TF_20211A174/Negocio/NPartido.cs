using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPartido
    {
        private DPartido dPartido = new DPartido();

        public string Registrar(Partidos partido)
        {
            return dPartido.Registrar(partido);
        }

        public List<Partidos> ListarPorTorneo(int idTorneo)
        {
            return dPartido.ListarPorTorneo(idTorneo);
        }

        public List<Partidos> ListarPartidosPorTorneoConRelaciones(int idTorneo)
        {
            return dPartido.ListarPartidosPorTorneoConRelaciones(idTorneo);
        }


        public Partidos ObtenerPorId(int idPartido)
        {
            return dPartido.ObtenerPorId(idPartido);
        }

        public string Modificar(Partidos partido)
        {
            return dPartido.Modificar(partido);
        }


        public string EliminarPartidosPorTorneo(int idTorneo)
        {
            return dPartido.EliminarPartidosPorTorneo(idTorneo);
        }

        public string GenerarFixture(List<Partidos> listaPartidos)
        {
            return dPartido.RegistrarFixture(listaPartidos);
        }


        public (string campeon, string subcampeon) ObtenerFinalistas(int idTorneo)
        {
            return dPartido.ObtenerFinalistas(idTorneo);
        }
    }
}