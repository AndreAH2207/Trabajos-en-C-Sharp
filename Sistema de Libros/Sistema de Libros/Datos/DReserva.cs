using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DReserva {

        public DReserva() { }

        public bool CrearReserva(int libroId, DateTime fechaDevolucion, Usuarios usuario) {


            using (var context = new BDEFEntities()) {

                var ejemplar = context.Ejemplares.FirstOrDefault(e => e.LibroId == libroId && e.Eliminado == false);

                if (ejemplar == null) {
                    return false; 
                }

                Reservas nuevaReserva = new Reservas {
                    EjemplarId = ejemplar.Id,
                    UsuarioId = usuario.Id,
                    FechaInicio = DateTime.Now,
                    FechaFin = fechaDevolucion,
                    Disponible = fechaDevolucion,
                    Estado = "Reservado",
                    Activo = true,
                    Eliminado = false
                };

                context.Reservas.Add(nuevaReserva);

                context.SaveChanges();

                return true;
            }
        }







    }
}
