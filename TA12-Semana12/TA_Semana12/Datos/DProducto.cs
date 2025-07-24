using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        public String Registrar(Producto producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Producto producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Producto productoTemp = context.Producto.Find(producto.ProductoId);
                    productoTemp.Nombre = producto.Nombre;
                    productoTemp.Categoria = producto.Categoria;
                    productoTemp.Marca = producto.Marca;
                    productoTemp.Precio = producto.Precio;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int ProductoId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Producto productoTemp = context.Producto.Find(ProductoId);
                    context.Producto.Remove(productoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Producto> ListarTodo()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> BuscarPorMarca(String marca)
        {
            List<Producto> productos = new List<Producto>();
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(p => p.Marca.Contains(marca)).ToList();
                }
                return productos;
            
        }
    }
}
