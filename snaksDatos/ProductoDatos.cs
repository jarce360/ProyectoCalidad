using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snaksDatos
{
    public class ProductoDatos
    {
        public static void Insertar(string id, string categoria, string proveedor, string descripcion, double precioCosto, double precioVenta, bool promocion, string imagenUrl)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_InsertarProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precioVenta", precioVenta);
            comando.Parameters.AddWithValue("@promocion", promocion);
            comando.Parameters.AddWithValue("@imagenUrl", imagenUrl);
            db.ExecuteNonQuery(comando);
        }

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_SeleccionarTodoProducto");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "Producto");
            return ds;
        }

    }
}