using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReporte
    {
        private DReporte dReporte = new DReporte();

        public List<object> ObtenerServiciosEnRangoDeFechasPorTipoServicio(DateTime fechaInicio, DateTime fechaFin, string tipoServicio)
        {
            return dReporte.ObtenerServiciosEnRangoDeFechasPorTipoServicio(fechaInicio, fechaFin, tipoServicio).Cast<object>().ToList();
        }

        public List<object> ObtenerCantidadServiciosAtendidosPorMecanico()
        {
            return dReporte.ObtenerCantidadServiciosAtendidosPorMecanico().Cast<object>().ToList();
        }
    }
}
