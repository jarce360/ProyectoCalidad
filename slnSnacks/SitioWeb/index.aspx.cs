using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using snaksLogicaNegocio;

namespace slnSnacks.SitioWeb
{
    public partial class index : System.Web.UI.Page
    {
        UsuarioLogica oDatosUsuario = new UsuarioLogica();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validateUser_Click(object sender, EventArgs e)
        {
            if (oDatosUsuario.searchUser(Usuario.Text, Contrasena.Text) == true)
            {
                Response.Redirect("welcome.aspx");
            }else{
                lblMessage.Text = "Usuario o contraseña incorrecta";
            }
        }
    }
}