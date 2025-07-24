using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSupermercado
    {
        public String Registrar(Supermercado supermercado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Supermercado.Add(supermercado);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Supermercado supermercado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Supermercado supermercadoTemp = context.Supermercado.Find(supermercado.SupermercadoId);
                    supermercadoTemp.NombreReferencial = supermercado.NombreReferencial;
                    supermercadoTemp.Direccion = supermercado.Direccion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int SupermercadoId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Supermercado supermercadoTemp = context.Supermercado.Find(SupermercadoId);
                    context.Supermercado.Remove(supermercadoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Supermercado> ListarTodo()
        {
            List<Supermercado> supermercados = new List<Supermercado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    supermercados = context.Supermercado.ToList();
                }
                return supermercados;
            }
            catch (Exception ex)
            {
                return supermercados;
            }
        }

        public List<Supermercado> BuscarPorNombreReferencial(String nombreR)
        {
            List<Supermercado> supermercados = new List<Supermercado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    supermercados = context.Supermercado.Where(p => p.NombreReferencial.Contains(nombreR)).ToList();
                }
                return supermercados;
            }
            catch (Exception ex)
            {
                return supermercados;
            }
        }
    }
}
