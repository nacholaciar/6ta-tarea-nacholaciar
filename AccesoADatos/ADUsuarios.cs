using System.Data;
using System.Data.SqlClient;

namespace miapp_r2.AccesoADatos
{
    public class ADUsuarios
    {
        public static bool ValidarUsuario(string nombreDeUsuario, string passwordDeUsuario)
        {

            bool resultado = false;

            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            // hacemos las consultas a la base de datos
            string consulta = "SELECT * FROM UsuariosBD WHERE NombreDeUsuarioBD like @nombre_usu AND PasswordBD like @pass_usu";

            comando.Parameters.Clear(); // limpiar todos los parametros que pueda tener
            comando.Parameters.AddWithValue("@nombre_usu", nombreDeUsuario);
            comando.Parameters.AddWithValue("@pass_usu", passwordDeUsuario);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open(); // abrimos conexion a la BD
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;

            //conexion.Close();
        } // [Form Login] hacemos conexion con la base de datos para traer el user y validarlo 

        public static DataTable ObtenerListadoUsuarios()
        {

            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            // hacemos las consultas a la base de datos
            string consulta = "SELECT * FROM UsuariosBD";

            comando.Parameters.Clear(); // limpiar todos los parametros que pueda tener

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open(); // abrimos conexion a la BD
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;

        } // [Form Usuarios] conexion a la BD para traer los datos a la grilla 

        public static bool InsertarUsuarios(string nombreDeUsuario, string password)
        {
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resultado = false;


            SqlCommand comando = new SqlCommand();
            // hacemos las consultas a la base de datos
            //string consulta = "INSERT INTO UsuariosBD (NombreDeUsuarioBD, PasswordBD) VALUES(@nombreUsu, @pass)";
            string consulta = "GetInsetarUsuario";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
            comando.Parameters.AddWithValue("@pass", password);

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery(); // no quiero ningun resultado como respuesta, o sea estamos insertando

            resultado = true;
            return resultado;

        } // [Form Usuarios] conexion con la BD para insertar el usaurio en ella 
    }


}
