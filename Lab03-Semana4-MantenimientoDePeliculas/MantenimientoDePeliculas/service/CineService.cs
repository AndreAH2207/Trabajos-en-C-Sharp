using MantenimientoDePeliculas.entities;
using MantenimientoDePeliculas.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.service
{
    internal class CineService
    {
        private CineRepository cineRepository = new CineRepository();

        public bool Registrar(Cine cine)
        {
            if(cineRepository.Existe(cine.Codigo))
            {
                return false;
            }
            else
            {
                cineRepository.Registrar(cine);
                return true;
            }
        }

        public List<Cine> ListarTodo()
        {
            return CineRepository.ListarTodo();
        }

        public void Eliminar(String codigo)
        {
            cineRepository.Eliminar(codigo);
        }

        public List<Cine> BuscarPorNombre(String nombre)
        {
            return cineRepository.BuscarPorNombre(nombre);
        }

        public List<Cine> OrdenarPorGerente()
        {
            return cineRepository.OrdenarPorGerente();
        }

    }
}
