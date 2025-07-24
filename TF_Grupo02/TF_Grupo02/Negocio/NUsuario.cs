using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();

        public string Registrar(Usuarios usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Correo) || string.IsNullOrWhiteSpace(usuario.ClaveHash))
            {
                return "Correo y contraseña son obligatorios.";
            }

            return dUsuario.Registrar(usuario);
        }

        public Usuarios LoginUsuario(string correo, string clave)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
                return null;

            return dUsuario.Login(correo, clave);
        }

        public List<Usuarios> ListarUsuarios()
        {
            return dUsuario.ListarTodo();
        }
    }
}
