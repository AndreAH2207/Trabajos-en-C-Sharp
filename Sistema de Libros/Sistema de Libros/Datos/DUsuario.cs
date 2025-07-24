using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DUsuario {
        public String Registrar(Usuarios usuario) {
            try {
                using (var context = new BDEFEntities()) {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public String Modificar(Usuarios usuario) {
            try {
                using (var context = new BDEFEntities()) {
                    Usuarios usuarioTemp = context.Usuarios.Find(usuario.Id);
                    usuarioTemp.Dni = usuario.Dni;
                    usuarioTemp.Contraseña = usuario.Contraseña;
                    usuarioTemp.Nombre = usuario.Nombre;
                    usuarioTemp.Apellido = usuario.Apellido;
                    usuarioTemp.Correo = usuario.Correo;
                    usuarioTemp.Telefono = usuario.Telefono;
                    usuarioTemp.ZonaHoraria = usuario.ZonaHoraria;
                    usuarioTemp.Activo = usuario.Activo;
                    usuarioTemp.Eliminado = usuario.Eliminado;
                    usuarioTemp.CreacionId = usuario.CreacionId;
                    usuarioTemp.FechaCreacion = usuario.FechaCreacion;
                    usuarioTemp.ModificacionId = usuario.ModificacionId;
                    usuarioTemp.FechaModificacion = usuario.FechaModificacion;
                    context.SaveChanges();

                }
                return "Modificado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Usuario) {
            try {
                using (var context = new BDEFEntities()) {
                    Usuarios usuarioTemp = context.Usuarios.Find(id_Usuario);
                    context.Usuarios.Remove(usuarioTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public List<Usuarios> ListarTodo() {
            List<Usuarios> usuarios = new List<Usuarios>();
            try {
                using (var context = new BDEFEntities()) {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuarios.Where(u => u.Eliminado == false).ToList();
                }
                return usuarios;
            }
            catch (Exception ex) {
                return usuarios;
            }
        }


        public Usuarios Login(string dni, string contraseña) {
            try {
                using (var context = new BDEFEntities()) {
                    var usuarioTemp = context.Usuarios.FirstOrDefault(u => u.Dni == dni && u.Contraseña == contraseña && u.Eliminado == false);
                    if (usuarioTemp == null) {
                        Console.WriteLine("Usuario no encontrado o credenciales incorrectas.");
                    }
                    return usuarioTemp;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error en Login: " + ex.Message);
                return null;
            }
        }

        
        public List<dynamic> CantidadReservasDeGeneroPorUsuario(string p_dni, string p_genero) {

            using (var context = new BDEFEntities()) {

                var consulta = from u in context.Usuarios
                               join r in context.Reservas
                                    on u.Id equals r.UsuarioId
                               join e in context.Ejemplares
                                    on r.EjemplarId equals e.Id
                               join l in context.Libros
                                    on e.LibroId equals l.Id
                               where
                                    l.Genero == p_genero &&
                                    u.Dni == p_dni &&
                                    u.Eliminado == false &&
                                    r.Eliminado == false
                               group new { u, l } by new { u.Dni, u.Nombre, u.Apellido } into groupBy
                               select new {
                                   Dni = groupBy.Key.Dni,
                                   Nombre = groupBy.Key.Nombre,
                                   Apellido = groupBy.Key.Apellido,
                                   Cantidad = groupBy.Count()
                               };

                return consulta.ToList<dynamic>();
            }
        }

        

    }
}
