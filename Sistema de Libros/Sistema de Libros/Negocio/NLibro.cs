using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NLibro {

        private DLibro dLibro = new DLibro();


        public NLibro() { }

        public String Registrar(Libros libro) {
            return dLibro.Registrar(libro);
        }

        public String Modificar(Libros libro) {
            return dLibro.Modificar(libro);
        }

        public String Eliminar(int id_Libro) {
            return dLibro.Eliminar(id_Libro);
        }

        public List<Libros> ListarTodo() {
            return dLibro.ListarTodo();
        }

        public List<dynamic> ObtenerLibrosPorAutor(Autores p_autor) {
            return dLibro.ObtenerLibrosPorAutor(p_autor);
        }

        public List<dynamic> ObtenerLibrosPorEstadoDeDeficiencia(string p_severidad) {

            return dLibro.ObtenerLibrosPorEstadoDeDeficiencia(p_severidad);
        }

        
        public Libros ObtenerLibroPorTitulo(string p_titulo) {

            return dLibro.ObtenerLibroPorTitulo(p_titulo);
        }

        public List<dynamic> BuscarLibros(string genero, string autor, string idioma, DateTime? fechaInicio, DateTime? fechaFin) {

            return dLibro.BuscarLibros(genero, autor, idioma, fechaInicio, fechaFin);
        }

        public List<string> ObtenerGeneros() {

            return dLibro.ObtenerGeneros();
        }

        public List<string> ObtenerIdiomas() {

            return dLibro.ObtenerIdiomas();
        }

        public bool ActualizarEstadoLibro(string p_titulo, string nuevoEstado) {

            return dLibro.ActualizarEstadoLibro(p_titulo, nuevoEstado);
        }

        public List<string> ObtenerTitulos() {

            return dLibro.ObtenerTitulos();
        }

    }
}
