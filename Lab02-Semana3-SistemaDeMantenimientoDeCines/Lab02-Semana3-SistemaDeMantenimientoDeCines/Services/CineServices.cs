using Lab02_Semana3_SistemaDeMantenimientoDeCines.Entities;
using Lab02_Semana3_SistemaDeMantenimientoDeCines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Semana3_SistemaDeMantenimientoDeCines.Services
{
    class CineServices
    {
        private CineRepository cineRepository = new CineRepository();

        public bool Registrar(Cine cn)
        {
            if (cineRepository.Existe(cn.Codigo))
            {
                return false;
            }
            else 
            {
                cineRepository.Registrar(cn);
                return true;
            }
        }
        public List<Cine> ListarTodo()
        {
            return CineRepository.ListarTodo();
        }
        public void Eliminar(string codigo)
        {
            cineRepository.Eliminar(codigo);
        }

        public List<Cine> BuscarPorDireccion(string direccion)
        {
            return cineRepository.BuscarPorDireccion(direccion);
        }

        public List<Cine> OrdenarPorArea()
        {
            return cineRepository.OrdenarPorArea();
        }

    }
}
