using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAutor {

        public DAutor() { }

        public String Registrar(Autores autor) {
            try {
                using (var context = new BDEFEntities()) {

                    context.Autores.Add(autor);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }


        public List<string> ObtenerNombresDeAutores() {

            using (var context = new BDEFEntities()) {

                List<string> lista = new List<string>();

                List<Autores> autores = context.Autores.Where(a => a.Eliminado == false).ToList();

                foreach (Autores autor in autores) {
                    
                    lista.Add(autor.Nombre + " " + autor.Apellido);
                }

                return lista;
            }
        }

        public Autores ObtenerAutor(string p_nombreCompleto) {

            using (var context = new BDEFEntities()) {

                return context.Autores.Where(a => a.Eliminado == false).FirstOrDefault(a => a.Nombre + " "+ a.Apellido == p_nombreCompleto);
            }
        }



    }
}
