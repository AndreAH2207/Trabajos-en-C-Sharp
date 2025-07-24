using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductora
    {
        private DProductora dProductora = new DProductora();

        public String Registrar(Productora productora)
        {
            return dProductora.Registrar(productora);
        }

        public String Eliminar(int id_Productora)
        {
            return dProductora.Eliminar(id_Productora);
        }

        public List<Productora> ListarTodo()
        {
            return dProductora.ListarTodo();
        }

        public List<Productora> BuscarProductorasConConciertosEnRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return dProductora.BuscarProductorasConConciertosEnRango(fechaInicio, fechaFin);
        }
    }
}
