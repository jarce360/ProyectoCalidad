using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using snaksEntidades;
using snaksDatos;
using System.Data;

namespace snaksLogicaNegocio
{
    public class ProductoLogica
    {


        public static DataSet TodosProductosDS()
        {

            DataSet ds = ProductoDatos.SeleccionarTodos();
            return ds;

        }

        public static List<Producto> TodosProductos()
        {
            List<Producto> datos = new List<Producto>();

           
            DataSet ds = ProductoDatos.SeleccionarTodos();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Producto prod = new Producto();
                prod.ID = Convert.ToInt16(row["ID"]);
                prod.descripcion = row["descripcion"].ToString();
                prod.precioVenta = Convert.ToDouble( row["precioVenta"]);
                prod.promocion = Convert.ToInt16(row["promocion"]) == 1 ? true :false ;
                prod.imagenUrl = row["imagenUrl"].ToString();
                prod.textoMostrar = prod.descripcion + " - Precio ¢: " + prod.precioVenta;
                datos.Add(prod);
            }

            return datos;

        }
    }
}
