using Lab02_Semana3_SistemaDeMantenimientoDeCines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Semana3_SistemaDeMantenimientoDeCines.Repositories
{
    class CineRepository
    {
        private static List<Cine> cine = new List<Cine>();

        public bool Existe(string codigo)
        {
            return cine.Exists(c=>c.Codigo.Equals(codigo));
        }

        public void Registrar(Cine cn)
        {
            cine.Add(cn);
        }
        public static List<Cine>ListarTodo()
        {
            return cine;
        }
        public void Eliminar(string codigo)
        {
            cine.RemoveAll(c=>c.Codigo.Equals(codigo));
        }

        public List<Cine> BuscarPorDireccion(string direccion) 
        {
            return cine.Where(c=>c.Direccion.Contains(direccion)).ToList(); 
        }

        public List<Cine> OrdenarPorArea()
        {
            return cine.OrderByDescending(c=>c.Area).ToList();
        }
    }
}
