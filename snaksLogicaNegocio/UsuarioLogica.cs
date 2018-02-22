using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using snaksDatos;

namespace snaksLogicaNegocio
{
    public class UsuarioLogica
    {
        Usuario validateLogin;
        UsuarioDatos oDatosUsuario = new UsuarioDatos();


        public Boolean searchUser(string usuario, string contrasena)
        {
            validateLogin= oDatosUsuario.searchUser(usuario, contrasena);
            if (validateLogin.nombreUsuario != "" && validateLogin.contrasena != "")
            {
                return true;
            }

            return false;
        }
    }
}
