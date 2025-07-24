using MantenimientoDePeliculas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDePeliculas.repository
{
    internal class CineRepository
    {
        private static List<Cine> cines = new List<Cine>();

        public bool Existe(String codigo)
        {
            return cines.Exists(lugar => lugar.Codigo.Equals(codigo));
        }

        public void Registrar(Cine cine)
        {
            cines.Add(cine);
        }

        public static List<Cine> ListarTodo()
        {
            return cines;
        }

        public void Eliminar(String codigo)
        {
            cines.RemoveAll(lugar => lugar.Codigo.Equals(codigo));
        }

        public  List<Cine> BuscarPorNombre(String nombre)
        {
            return cines.Where(lugar => lugar.Nombre.Contains(nombre)).ToList();
        }

        public  List<Cine> OrdenarPorGerente()
        {
            return cines.OrderBy(lugar => lugar.Gerente).ToList();
        }
    }
}
