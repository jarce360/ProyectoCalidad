using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snaksDatos
{
    public class UsuarioDatos
    {

        public static void Insertar(int id, int identificacion, string nombre, string nombreUsu, string contrasena)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_InsertarUsuario");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@identificacion", identificacion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsu);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            db.ExecuteNonQuery(comando);
        }

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_SeleccionarUsuario");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "Usuario");
            return ds;
        }


        public Usuario searchUser(string usuario, string contrasena)
        {
            Usuario oUsuario = null;
            try
            {

                SqlDataAdapter adaptador = null;
                String sql = "select * from usuario where nombreUsuario=@Usuario and contrasena=@Contrasena";
                DataSet dsTabla = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = ConexionBaseDatos();
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);


                adaptador = new SqlDataAdapter(sql, ConexionBaseDatos());
                adaptador.Fill(dsTabla);
                if (dsTabla.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsTabla.Tables[0].Rows[0];
                    oUsuario = new Usuario();
                    oUsuario.nombreUsuario = dr["nombreUsuario"].ToString();
                    oUsuario.contrasena = dr["contrasena"].ToString();
                }
            }
            catch (SqlException)
            {

                throw;
            }

            return oUsuario;
        }

        public static SqlConnection ConexionBaseDatos()
        {
            SqlConnection conexion = null;
            conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source=localhost; Initial Catalog=snacksDB;Integrated Security=true; MultipleActiveResultSets=true;";

            conexion.Open();
            return conexion;
        }
    }
}