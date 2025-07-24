using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        public String Registrar(Usuarios usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Usuarios Login(string correo, string contraseña)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var usuarioTemp = context.Usuarios.FirstOrDefault(u => u.Correo == correo && u.ClaveHash == contraseña);
                    if (usuarioTemp == null)
                    {
                        Console.WriteLine("Usuario no encontrado o credenciales incorrectas.");
                    }
                    return usuarioTemp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Login: " + ex.Message);
                return null;
            }
        }

        public List<Usuarios> ListarTodo()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                usuarios = context.Usuarios.ToList();
            }
            return usuarios;

        }
    }
}
