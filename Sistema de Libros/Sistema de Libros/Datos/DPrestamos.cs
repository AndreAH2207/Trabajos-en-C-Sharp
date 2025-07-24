using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DPrestamos {

        public DPrestamos() { }


        public List<dynamic> PrestamosParaForm(string p_dni) {

            using (var context = new BDEFEntities()) {

                var consulta = from p in context.Prestamos
                               where p.Dni == p_dni && 
                                     p.Eliminado == false
                               select new {
                                   Dni = p.Dni,
                                   FechaInicio = p.FechaInicio,
                                   FechaDevolucionPrevista = p.FechaDevolucionPrevista,
                                   FechaDevolucionReal = p.FechaDevolucionReal,
                                   Estado = p.Estado
                               };

                return consulta.ToList<dynamic>();
            }
        }


        public List<Prestamos> ListarTodo() {

            using (var context = new BDEFEntities()) {

                return context.Prestamos.Where(p => p.Eliminado == false).ToList();
            }
           
        }


        public List<dynamic> VerEstadoDelPrestamo(string estado, DateTime fechaInicio, DateTime fechaDevolucionReal) {

            using (var context = new BDEFEntities()) {

                var consulta = from p in context.Prestamos
                               where
                                   p.Estado == estado &&
                                   p.FechaInicio >= fechaInicio &&
                                   (p.FechaDevolucionReal == null || p.FechaDevolucionReal <= fechaDevolucionReal) &&
                                   p.Eliminado == false
                               select new {
                                   Dni = p.Dni,
                                   ReservaId = p.ReservaId,
                                   FechaInicio = p.FechaInicio,
                                   FechaDevolucionPrevista = p.FechaDevolucionPrevista,
                                   Estado = p.Estado
                               };


                return consulta.ToList<dynamic>();
            }
        }


    }
}
