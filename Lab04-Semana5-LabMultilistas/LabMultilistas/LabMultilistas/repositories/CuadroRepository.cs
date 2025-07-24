using LabMultilistas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMultilistas.repositories
{
    class CuadroRepository
    {
        public bool Existe(String codigoCuadro)
        {
            List<Artista> artistas = ArtistaRepository.ListarTodo();
            return artistas.Exists(a => a.Cuadros.Exists(c => c.Codigo.Equals(codigoCuadro)));
        }

        public void Registrar(String codigoArtista, Cuadro cuadro)
        {
            List<Artista> artistas = ArtistaRepository.ListarTodo();
            Artista artista = artistas.Find(a => a.Codigo.Equals(codigoArtista));
            
            artista.Cuadros.Add(cuadro);
        }

        public List<Cuadro> ListarTodo(String codigoArtista)
        {
            List<Artista> artistas = ArtistaRepository.ListarTodo();
            Artista artista = artistas.Find(a => a.Codigo.Equals(codigoArtista));

            return artista.Cuadros;
        }


        public List<Cuadro> BuscarCuadroPorTitulo(string titulo)
        {
            List<Artista> artistas = ArtistaRepository.ListarTodo();

            return artistas
                .Where(a => a.Cuadros != null)
                .SelectMany(a => a.Cuadros)
                .Where(c => c.Titulo == titulo)
                .ToList();
        }


        public List<Cuadro> BuscarCuadrosArtistasMenosJovenes()
        {
            List<Artista> artistas = ArtistaRepository.ListarTodo();

            if (artistas == null || artistas.Count == 0)
                return new List<Cuadro>();

            int maxEdad = artistas.Max(a => a.Edad);

            return artistas
                .Where(a => a.Edad == maxEdad && a.Cuadros != null)
                .SelectMany(a => a.Cuadros)
                .ToList();
        }
    }
}
