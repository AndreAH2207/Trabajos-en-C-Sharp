using MantenimientoDePeliculas.entities;
using MantenimientoDePeliculas.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.service
{
    internal class PeliculaService
    {
        private PeliculaRepository peliculaRepository = new PeliculaRepository();

        public bool Registrar(String codigoCine, Pelicula pelicula)
        {
            if(peliculaRepository.Existe(pelicula.Codigo))
            {
                return false;
            }
            else
            {
                peliculaRepository.Registrar(codigoCine, pelicula);
                return true;

            }
        }

        public List<Pelicula> ListarTodo(String codigoCine)
        {
            return peliculaRepository.ListarTodo(codigoCine);
        }

        public void Eliminar(String codigoCine, String codigoPelicula)
        {
            peliculaRepository.Eliminar(codigoCine, codigoPelicula);
        }

        public List<Pelicula> OrdenarPorDuracion(String codigoCine)
        {
            return peliculaRepository.OrdenarPorDuracion(codigoCine);
        }

    }
}
