using LabMultilistas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LabMultilistas.repositories
{
    class ArtistaRepository
    {
        private static List<Artista> artistas = new List<Artista>();

        public bool Existe(String codigoArtista)
        {
            return artistas.Exists(a => a.Codigo.Equals(codigoArtista));
        }

        public void Registrar(Artista artista)
        {
            artistas.Add(artista);
        }

        public static List<Artista> ListarTodo()
        {
            return artistas;
        }
        public List<Artista> ListarArtistasXCuadrosMasBaratos()
        {
            return artistas
                .Where(a => a.Cuadros != null && a.Cuadros.Count > 0)
                .OrderBy(a => a.Cuadros.Min(c => c.Precio))
                .ToList();
        }
        public List<Artista> ListarArtistasConMasCuadrosDeTipoDiferenteANormal()
        {
            return artistas
                .Where(a => a.Cuadros != null && a.Cuadros.Any(c => c.Categoria != "Normal"))
                .OrderByDescending(a => a.Cuadros.Count(c => c.Categoria != "Normal"))
                .ToList();
        }

        public List<Artista> ListarArtistasConMasCuadrosEnCategoria(string categoria)
        {
            return artistas
                .Where(a => a.Cuadros != null)
                .OrderByDescending(a => a.Cuadros.Count(c => c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
