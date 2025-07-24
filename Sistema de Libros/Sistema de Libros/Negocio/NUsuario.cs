using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NUsuario {

        private DUsuario dUsuario = new DUsuario();
        private static Usuarios usuarioLogueado;

        public String Registrar(Usuarios usuario) {
            return dUsuario.Registrar(usuario);
        }

        public String Modificar(Usuarios usuario) {
            return dUsuario.Modificar(usuario);
        }

        public String Eliminar(int id_Usuario) {
            return dUsuario.Eliminar(id_Usuario);
        }

        public List<Usuarios> ListarTodo() {
            return dUsuario.ListarTodo();
        }

        public Usuarios Login(string dni, string contraseña) {
            return dUsuario.Login(dni, contraseña);
        }

        public void AsignarUsuarioLogeado(Usuarios p_usuario) {
            usuarioLogueado = p_usuario;
        }

        public Usuarios ObtenerUsuarioLogeado() {
            return usuarioLogueado;
        }

        public List<dynamic> CantidadReservasDeGeneroPorUsuario(string p_dni, string p_genero) {

            return dUsuario.CantidadReservasDeGeneroPorUsuario(p_dni, p_genero);
        }

    }
}
