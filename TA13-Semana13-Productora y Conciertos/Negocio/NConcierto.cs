using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NConcierto
    {
        private DConcierto dConcierto = new DConcierto();

        public String Registrar(Concierto concierto)
        {
            return dConcierto.Registrar(concierto);
        }

        public String Eliminar(int id_Concierto)
        {
            return dConcierto.Eliminar(id_Concierto);
        }

        public List<Concierto> ListarTodo(int id_Concierto)
        {
            return dConcierto.ListarTodo(id_Concierto);
        }

        public List<Concierto> BuscarConciertosDeProductorasSinAmonestaciones()
        {
            return dConcierto.BuscarConciertosDeProductorasSinAmonestaciones();
        }
    }
}
