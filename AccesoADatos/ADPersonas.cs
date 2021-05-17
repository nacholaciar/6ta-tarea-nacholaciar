using miapp_r2.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapp_r2.AccesoADatos
{
    public class ADPersonas
    {
        public static DataTable ObtenerListadoPersonasReducido()
        {

            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            // hacemos las consultas a la base de datos
            //string consulta = "SELECT * FROM PersonasBD"; AGREGAR Todas las columnas
            string consulta = "SELECT Nombre, Apellido, IdTipoDocumento, NroDocumento FROM PersonasBD"; // agregar especificando cual columna


            comando.Parameters.Clear(); // limpiar todos los parametros que pueda tener

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open(); // abrimos conexion a la BD
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;

        } // [form AltaPersona] obtener personas desde la BD hacia la grilla

        public static DataTable ObtenerTiposDeDocumento()
        {
            // config SQL
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"]; // enlazamos con el appconfig (Donde esta config la base de datos)
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();

            // hacemos las consultas a la base de datos
            string consulta = "GetTiposDocumentos";

            comando.Parameters.Clear(); // limpiar todos los parametros que pueda tener
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            conexion.Open(); // abrimos conexion a la BD
            comando.Connection = conexion; // aisgnamos la conexion al comando

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;
        }  // [form AltaPersona] traemos los combos de la base de datos para mostrarlo en el form

        public static DataTable ObtenerTiposDeCarrera()
        {
            // config SQL
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"]; // enlazamos con el appconfig (Donde esta config la base de datos)
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();

            // hacemos las consultas a la base de datos
            string consulta = "GetTiposCarrera";

            comando.Parameters.Clear(); // limpiar todos los parametros que pueda tener
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            conexion.Open(); // abrimos conexion a la BD
            comando.Connection = conexion; // aisgnamos la conexion al comando

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;
        } // [form AltaPersona] traemos los combos de la base de datos para mostarlo en el form

        public static bool AgregarPersonaABD(Persona per)
        {
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resultado = false;


            SqlCommand comando = new SqlCommand();
            // hacemos las consultas a la base de datos
            string consulta = "INSERT INTO PersonasBD (Nombre, Apellido, FechaNacimiento, IdSexo, IdTipoDocumento, IdCarrera, NroDocumento, Calle, NroCasa, Soltero, Casado, Hijos, CantidadHijos) VALUES(@nombre, @apellido, @fechaNacimiento, @idSexo, @idTipoDocumento, @idCarrera, @nroDocumento, @calle, @nroCasa, @soltero, @casado, @hijos, @cantidadHijos)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", per.NombrePersona);
            comando.Parameters.AddWithValue("@apellido", per.ApellidoPersona);
            comando.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimientoPersona);
            comando.Parameters.AddWithValue("@idSexo", per.IdSexoPersona);
            comando.Parameters.AddWithValue("@idTipoDocumento", per.IdTipoDocumentoPersona);
            comando.Parameters.AddWithValue("@idCarrera", per.IdCarreraPersona);
            comando.Parameters.AddWithValue("@nroDocumento", per.DocumentoPersona);
            comando.Parameters.AddWithValue("@calle", per.CallePersona);
            comando.Parameters.AddWithValue("@nroCasa", per.NroCasaPersona);
            comando.Parameters.AddWithValue("@soltero", per.SolteroPersona);
            comando.Parameters.AddWithValue("@casado", per.CasadoPersona);
            comando.Parameters.AddWithValue("@hijos", per.HijosPersona);
            comando.Parameters.AddWithValue("@cantidadHijos", per.CantidadHijosPersona);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery(); // no quiero ningun resultado como respuesta, o sea estamos insertando

            resultado = true;
            return resultado;
        } // [form AltaPersona] insertamos persona a la base de datos a traves del form
    }
}
   