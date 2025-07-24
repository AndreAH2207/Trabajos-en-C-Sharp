using LabMultilistas.entities;
using LabMultilistas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMultilistas.services
{
    class CuadroService
    {
        private CuadroRepository cuadroRepository = new CuadroRepository();

        public bool Registrar(String codigoArtista, Cuadro cuadro)
        {
            if (cuadroRepository.Existe(cuadro.Codigo))
            {
                return false;
            }
            else
            {
                // Lógica de negocio
                if (cuadro.Categoria.Equals("Especial"))
                {
                    cuadro.Precio *= 1.2;
                }

                cuadroRepository.Registrar(codigoArtista, cuadro);
                return true;
            }
        }

        public List<Cuadro> ListarTodo(String codigoArtista)
        {
            return cuadroRepository.ListarTodo(codigoArtista);
        }

        public List<Cuadro> BuscarCuadroPorTitulo(string titulo)
        {
            return cuadroRepository.BuscarCuadroPorTitulo(titulo);
        }
        public List<Cuadro> BuscarCuadrosArtistasMenosJovenes()
        {
            return cuadroRepository.BuscarCuadrosArtistasMenosJovenes();
        }
    }
}
