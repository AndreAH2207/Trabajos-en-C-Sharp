using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DLibroAutor {

        public DLibroAutor() { }

        public void Registrar(int p_libroId, int p_autorId) {

            using (var context = new BDEFEntities()){

                LibrosAutores LA = new LibrosAutores();

                LA.LibroId = p_libroId;
                LA.AutorId = p_autorId;
                LA.Eliminado = false;

                context.LibrosAutores.Add(LA);
                context.SaveChanges();
            }

        }



    }
}
