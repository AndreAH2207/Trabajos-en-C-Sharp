using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReporte
    {
        public IEnumerable ObtenerServiciosEnRangoDeFechasPorTipoServicio(DateTime fechaInicio, DateTime fechaFin, string tipoServicio)
        {
            using (var context = new BDEFEntities())
            {
                var reporte = context.Servicio.Where(s =>
                                                s.FechaHoraServicio >= fechaInicio &&
                                                s.FechaHoraServicio <= fechaFin &&
                                                s.TipoServicio.Equals(tipoServicio)
                                                ).Select(r => new
                                                {
                                                    FechaServicio = r.FechaHoraServicio,
                                                    PlacaVehiculo = r.Vehiculo.Placa,
                                                    NombreCompleto = r.Mecanico.NombreCompleto
                                                }).ToList();
                return reporte;
            }
        }

        public IEnumerable ObtenerCantidadServiciosAtendidosPorMecanico()
        {
            using (var context = new BDEFEntities())
            {
                var reporte = context.Servicio.Where(s => s.Atendido == true).GroupBy(s => s.Mecanico.NombreCompleto).Select
                    (r => new
                    {
                        NombreCompletoMecanico = r.Key,
                        Cantidad = r.Count()
                    }).ToList();
                return reporte;
            }
        }
    }
}