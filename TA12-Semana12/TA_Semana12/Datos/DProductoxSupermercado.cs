using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProductoxSupermercado
    {
        public String Asignar(ProductoxSupermercado productoxSupermercado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.ProductoxSupermercado.Add(productoxSupermercado);
                    context.SaveChanges();
                }
                return "Asignado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Desasignar(int ProductoId, int SupermercadoId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    ProductoxSupermercado productoxSupermercadoTemp = context.ProductoxSupermercado.Find(ProductoId, SupermercadoId);
                    context.ProductoxSupermercado.Remove(productoxSupermercadoTemp);
                    context.SaveChanges();
                }
                return "Desasignado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ProductoxSupermercado> ListarTodo()
        {
            List<ProductoxSupermercado> productoxSupermercados = new List<ProductoxSupermercado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productoxSupermercados = context.ProductoxSupermercado.ToList();
                }
                return productoxSupermercados;
            }
            catch (Exception ex)
            {
                return productoxSupermercados;
            }
        }
    }
}
