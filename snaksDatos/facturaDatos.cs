using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snaksDatos
{
    public class FacturaDatos
    {

        public static void Insertar(int id, DateTime fecha, int IDUsuario, string nombreUsuario, double subTotal, double totalVenta, double impuesto, double montoDescuento, int porcentajeDescuento, string nombreCliente,string formaPago)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_InsertarFactura");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@subTotal", subTotal);
            comando.Parameters.AddWithValue("@totalVenta", totalVenta);
            comando.Parameters.AddWithValue("@impuesto", impuesto);
            comando.Parameters.AddWithValue("@montoDescuento", montoDescuento);
            comando.Parameters.AddWithValue("@porcentajeDescuento", porcentajeDescuento);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@formaPago", formaPago);
            db.ExecuteNonQuery(comando);
        }

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_SeleccionarFactura");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "Factura");
            return ds;
        }
    }
}