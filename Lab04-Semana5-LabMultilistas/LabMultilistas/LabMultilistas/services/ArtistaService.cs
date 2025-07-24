using LabMultilistas.entities;
using LabMultilistas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMultilistas.services
{
    class ArtistaService
    {
        private ArtistaRepository artistaRepository = new ArtistaRepository();

        public bool Registrar(Artista artista)
        {
            if (artistaRepository.Existe(artista.Codigo))
            {
                return false;
            }
            else
            {
                artistaRepository.Registrar(artista);
                return true;
            }
        }

        public List<Artista> ListarTodo()
        {
            return ArtistaRepository.ListarTodo();
        }

        public List<Artista> ListarArtistasXCuadrosMasBaratos()
        {
            return artistaRepository.ListarArtistasXCuadrosMasBaratos();
        }
        public List<Artista> ListarArtistasConMasCuadrosDeTipoDiferenteANormal()
        {
            return artistaRepository.ListarArtistasConMasCuadrosDeTipoDiferenteANormal();
        }
        public List<Artista> ListarArtistasConMasCuadrosEnCategoria(string categoria)
        {
            return artistaRepository.ListarArtistasConMasCuadrosEnCategoria(categoria);
        }

    }
}
