using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DMulta {

        public DMulta() { }


        public List<dynamic> VerEstadoDeLaMulta(bool estado, string dni, DateTime fechaInicio, DateTime fechaFin) {

            using (var context = new BDEFEntities()) {
                var consulta = from m in context.Multas
                               join p in context.Prestamos
                                    on m.PrestamoId equals p.Id
                               where m.Estado == estado &&           
                                     p.Dni == dni &&               
                                     (m.FechaCreacion == null || (m.FechaCreacion >= fechaInicio && m.FechaCreacion <= fechaFin)) &&
                                     m.Eliminado == false          
                               select new {
                                   Dni = p.Dni,
                                   PrestamoId = m.PrestamoId,
                                   FechaDevolucionPrevista = p.FechaDevolucionPrevista,
                                   Estado = m.Estado,
                                   Monto = m.Monto,
                                   Motivo = m.Motivo
                               };

                return consulta.ToList<dynamic>();
            }
        }




    }
}
