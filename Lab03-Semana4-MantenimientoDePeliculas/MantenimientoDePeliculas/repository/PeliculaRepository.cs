using MantenimientoDePeliculas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.repository
{
    internal class PeliculaRepository
    {
        public bool Existe(String codigoPelicula)
        {
            List<Cine> cines = CineRepository.ListarTodo();
            return cines.Exists(c => c.Peliculas.Exists(p => p.Codigo.Equals(codigoPelicula)));
        }

        public void Registrar(String codigoCine, Pelicula pelicula)
        {
            List<Cine> cines = CineRepository.ListarTodo();
            Cine cine = cines.Find(c => c.Codigo.Equals(codigoCine));

            cine.Peliculas.Add(pelicula);
        }

        public List<Pelicula> ListarTodo(String codigoCine)
        {
            List<Cine> cines = CineRepository.ListarTodo();
            Cine cine = cines.Find(c => c.Codigo.Equals(codigoCine));
            return cine.Peliculas;
        }

        public void Eliminar(String codigoCine, String codigoPelicula)
        {
            List<Cine> cines = CineRepository.ListarTodo();
            Cine cine = cines.Find(c => c.Codigo.Equals(codigoCine));

            cine.Peliculas.RemoveAll(peli => peli.Codigo.Equals(codigoPelicula));
        }

        public List<Pelicula> OrdenarPorDuracion(String codigoCine)
        {
            List<Cine> cines = CineRepository.ListarTodo();
            Cine cine = cines.Find(c => c.Codigo.Equals(codigoCine));
            return cine.Peliculas.OrderBy(peli => peli.Duracion).ToList();
        }
    }
}
