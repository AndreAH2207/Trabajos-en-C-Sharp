using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DLibro {

        public DLibro() { }

        public String Registrar(Libros libro) {
            try {
                using (var context = new BDEFEntities()) {

                    context.Libros.Add(libro);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public String Modificar(Libros libro) {
            try {
                using (var context = new BDEFEntities()) {
                    Libros libroTemp = context.Libros.Find(libro.Id);
                    libroTemp.Titulo = libro.Titulo;
                    libroTemp.Genero = libro.Genero;
                    libroTemp.Idioma = libro.Idioma;
                    libroTemp.FechaPublicacion = libro.FechaPublicacion;
                    libroTemp.CantidadPaginas = libro.CantidadPaginas;
                    libroTemp.Ubicacion = libro.Ubicacion;
                    libroTemp.Activo = libro.Activo;
                    libroTemp.Eliminado = libro.Eliminado;
                    libroTemp.CreacionId = libro.CreacionId;
                    libroTemp.FechaCreacion = libro.FechaCreacion;
                    libroTemp.ModificacionId = libro.ModificacionId;
                    libroTemp.FechaModificacion = libro.FechaModificacion;
                    context.SaveChanges();

                }
                return "Modificado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Libro) {
            try {
                using (var context = new BDEFEntities()) {
                    Libros libroTemp = context.Libros.Find(id_Libro);
                    context.Libros.Remove(libroTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public List<Libros> ListarTodo() {
            List<Libros> libros = new List<Libros>();
            try {
                using (var context = new BDEFEntities()) {
                    context.Configuration.LazyLoadingEnabled = false;
                    libros = context.Libros.Where(l => l.Eliminado == false).ToList();
                }
                return libros;
            }
            catch (Exception ex) {
                return libros;
            }
        }


        public List<dynamic> ObtenerLibrosPorAutor(Autores p_autor) {

            using (var context = new BDEFEntities()) {

                var consulta = from autor in context.Autores
                               join librosAutores in context.LibrosAutores
                                    on autor.Id equals librosAutores.AutorId
                               join libros in context.Libros
                                    on librosAutores.LibroId equals libros.Id
                               where
                                    autor.Nombre == p_autor.Nombre &&
                                    autor.Apellido == p_autor.Apellido &&
                                    libros.Eliminado == false
                               select new {
                                   Titulo = libros.Titulo,
                                   Genero = libros.Genero,
                                   Idioma = libros.Idioma,
                                   CantidadDePaginas = libros.CantidadPaginas,
                                   FechaPublicacion = libros.FechaPublicacion,
                                   Ubicacion = libros.Ubicacion
                               };

                return consulta.ToList<dynamic>();
            }
        }


        public List<dynamic> ObtenerLibrosPorEstadoDeDeficiencia(string p_severidad) {

            using (var context = new BDEFEntities()) {

                var consulta = from l in context.Libros
                               join e in context.Ejemplares
                                    on l.Id equals e.LibroId
                               where
                                    e.Estado == p_severidad &&
                                    l.Eliminado == false
                               select new {
                                   Titulo = l.Titulo,
                                   Genero = l.Genero,
                                   Idioma = l.Idioma,
                                   CantidadDePaginas = l.CantidadPaginas,
                                   FechaPublicacion = l.FechaPublicacion,
                                   Ubicacion = l.Ubicacion,
                                   Estado = e.Estado
                               };

                return consulta.ToList<dynamic>();
            }
        }


        public Libros ObtenerLibroPorTitulo(string p_titulo) {

            using (var context = new BDEFEntities()) {

                

                Libros libro = context.Libros.Where(l => l.Eliminado == false).FirstOrDefault(l => l.Titulo == p_titulo);

                return libro;
            }
        }


        public List<dynamic> BuscarLibros(string genero, string autor, string idioma, DateTime? fechaInicio, DateTime? fechaFin) {

            using (var context = new BDEFEntities()) {
                var consulta = from l in context.Libros
                               join la in context.LibrosAutores on l.Id equals la.LibroId
                               join a in context.Autores on la.AutorId equals a.Id
                               where l.Activo == true && l.Eliminado == false
                               select new {
                                   Titulo = l.Titulo,
                                   Genero = l.Genero,
                                   Idioma = l.Idioma,
                                   CantidadPaginas = l.CantidadPaginas,
                                   FechaPublicacion = l.FechaPublicacion,
                                   Ubicacion = l.Ubicacion,
                               };

                if (!string.IsNullOrEmpty(genero)) {
                    consulta = consulta.Where(l => l.Genero == genero);
                }


                if (!string.IsNullOrEmpty(idioma)) {
                    consulta = consulta.Where(l => l.Idioma == idioma);
                }

                if (fechaInicio.HasValue && fechaFin.HasValue) {
                    consulta = consulta.Where(l => l.FechaPublicacion >= fechaInicio && l.FechaPublicacion <= fechaFin);
                }

               
                return consulta.ToList<dynamic>();
            }
        }


        public List<string> ObtenerGeneros() {
            
            using (var context = new BDEFEntities()) {
                
                var lista = context.Libros
                                   .Where(a => a.Eliminado == false && a.Genero != null)
                                   .Select(l => l.Genero)
                                   .Distinct()
                                   .ToList();

                return lista;
            }
        }


        public List<string> ObtenerIdiomas() {
            
            using (var context = new BDEFEntities()) {
                
                var lista = context.Libros
                                   .Where(a => a.Eliminado == false && a.Idioma != null)
                                   .Select(l => l.Idioma)
                                   .Distinct()
                                   .ToList();

                return lista;
            }
        }

        public List<string> ObtenerTitulos() {

            using (var context = new BDEFEntities()) {

                var lista = context.Libros
                                   .Where(a => a.Eliminado == false && a.Titulo != null)
                                   .Select(l => l.Titulo)
                                   .Distinct()
                                   .ToList();

                return lista;
            }
        }

        public bool ActualizarEstadoLibro(string p_titulo, string nuevoEstado) {
            
            using (var context = new BDEFEntities()) {

                Libros libro = context.Libros.Where(l => l.Eliminado == false).FirstOrDefault(l => l.Titulo == p_titulo);

                Ejemplares ejemplar = context.Ejemplares.FirstOrDefault(e => e.LibroId == libro.Id && e.Eliminado == false);

                if (ejemplar == null) {

                    return false;
                }


                ejemplar.Estado = nuevoEstado;
                context.SaveChanges();

                return true;
            }
        }




    }
}
