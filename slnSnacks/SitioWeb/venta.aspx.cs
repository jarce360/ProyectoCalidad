using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using snaksLogicaNegocio;
using snaksEntidades;


namespace slnSnacks.SitioWeb
{
    public partial class venta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

             cargarListBoxProducto();
            }
        }

        //protected void cargarListaProductos() {
        //    this.dltDatosProductos.DataSource = ProductoLogica.TodosProductosDS();
        //    this.dltDatosProductos.DataBind();
        //}


        protected void cargarListBoxProducto()
        {
            this.lstProductos.DataSource = ProductoLogica.TodosProductos();
            this.lstProductos.DataTextField = "textoMostrar";
            this.lstProductos.DataValueField = "ID";
            this.lstProductos.DataBind();
        }
    }
}