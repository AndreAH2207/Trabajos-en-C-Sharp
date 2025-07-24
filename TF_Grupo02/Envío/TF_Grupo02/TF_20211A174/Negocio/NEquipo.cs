using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NEquipo
    {
        private DEquipo dEquipo = new DEquipo();

        public string Registrar(Equipos equipo)
        {
            return dEquipo.Registrar(equipo);
        }

        public string Modificar(Equipos equipo)
        {
            return dEquipo.Modificar(equipo);
        }

        public string Eliminar(int id)
        {
            return dEquipo.Eliminar(id);
        }

        public List<Equipos> ListarTodo()
        {
            return dEquipo.ListarTodo();
        }
    }
}
