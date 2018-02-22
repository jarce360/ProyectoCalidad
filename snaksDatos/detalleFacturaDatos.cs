using System.Data;
using System.Data.SqlClient;

namespace snaksDatos
{
    public class detalleFacturaDatos
    {
        public static void Insertar(string id, int idFact, int idProducto, int cantidadProd, double precioProd, double subTotal)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_InsertarDetalleFactura");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@IDFactura", idFact);
            comando.Parameters.AddWithValue("@IDProducto", idProducto);
            comando.Parameters.AddWithValue("@cantidadProd", cantidadProd);
            comando.Parameters.AddWithValue("@precioProd", precioProd);
            comando.Parameters.AddWithValue("@subTotal", subTotal);
            db.ExecuteNonQuery(comando);
        }

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_SeleccionarDetalle");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "detalleFactura");
            return ds;
        }
    }
}