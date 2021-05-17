using miapp_r2.AccesoADatos;
using miapp_r2.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miapp_r2
{
    public partial class AltaPersona : Form // AltaPersona hereda de form
    {
        public AltaPersona()
        {
            InitializeComponent(); // inicializa los compnentes graficos que posee la ventana
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            //mskCantidadHijosA.Enabled = false;

            // cargar los combos
            btnActualizarDatosA.Enabled = false;
            btnGuardarPersonaA.Enabled = true;
            CargarComboTipoDocumento();
            CargarComboTipoCarrera();
            CargarGrilla();


        }

        private void CargarComboTipoDocumento()
        {

            cbTDocumentoA.DataSource = ADPersonas.ObtenerTiposDeDocumento(); // asignamos al combo la tabla que acabamos de crear
            cbTDocumentoA.DisplayMember = "Nombre"; // en la tabla TipoDocumentoBD de la BD mostrame unicamente la columna Nombre
            cbTDocumentoA.ValueMember = "Id";
            cbTDocumentoA.SelectedIndex = -1; // inicializar en campo vacio

        } // cargar combo tipo documento desde la BD

        private void CargarComboTipoCarrera()
        {
            cbCarreraA.DataSource = ADPersonas.ObtenerTiposDeCarrera(); // asignamos al combo la tabla que acabamos de crear
            cbCarreraA.DisplayMember = "Nombre"; // en la tabla TipoDocumentoBD de la BD mostrame unicamente la columna Nombre
            cbCarreraA.ValueMember = "Id";
            cbCarreraA.SelectedIndex = -1; // inicializar en campo vacio
        } // cargar combo tipo carrera desde la BD

        private void CargarGrilla()
        {
            dgPersonas.DataSource = ADPersonas.ObtenerListadoPersonasReducido();

        } // cargamos la grilla con los datos de la BD

        private Persona ObtenerDatosPersona()
        {
            Persona p = new Persona();

            // obtener text
            p.NombrePersona = txtNombreA.Text.Trim();
            p.ApellidoPersona = txtApellidoA.Text.Trim();
            p.CallePersona = txtCalleA.Text.Trim();
            p.NroCasaPersona = txtNroCasaA.Text.Trim();

            //obtener mask
            p.FechaNacimientoPersona = DateTime.Parse(mskFNacimientoA.Text); // como FechaNacimientoPersona esta como propiedad DateTime en entidad Persona, no lo puedo usar como texto, por lo tanto convertimos con la funcion PropiedadAcatual.Parse(nom.text)
            p.DocumentoPersona = mskNroDocumentoA.Text.Trim();

            if (mskCantidadHijosA.Text.Equals(""))
            {
                p.CantidadHijosPersona = 0;
            }
            else
            {
                p.CantidadHijosPersona = int.Parse(mskCantidadHijosA.Text);
            }

            // obtener radio buttons
            if (rdMasculinoA.Checked)
            {
                p.IdSexoPersona = 1;
            }
            else if (rdFemeninoA.Checked)
            {
                p.IdSexoPersona = 2;
            }
            else
            {
                p.IdSexoPersona = 3;
            }

            // obtener los checkboxes
            if (ckSolteroA.Checked)
            {
                p.SolteroPersona = true;
            }
            else
            {
                p.SolteroPersona = false;
            }

            if (ckCasadoA.Checked)
            {
                p.CasadoPersona = true;
            }
            else
            {
                p.CasadoPersona = false;

            }

            if (ckHijosA.Checked)
            {
                p.HijosPersona = true;
            }
            else
            {
                p.HijosPersona = false;

            }

            // obtener combos
            p.IdTipoDocumentoPersona = (int)cbTDocumentoA.SelectedValue;
            p.IdCarreraPersona = (int)cbCarreraA.SelectedValue;

            return p;
        }

        private void btnGuardarPersonaA_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona(); // encapsulamos porque este metodo lo vamos a utilizar mas de una vez

            bool resultado = ADPersonas.AgregarPersonaABD(p);

            if (resultado)
            {
                MessageBox.Show("Persona agregada con exito");
                LimpiarCampos();
                CargarComboTipoCarrera();
                CargarComboTipoCarrera();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void AgregarPersona(Persona per) // metodo para agregar el objeto al grid
        {
            DataGridViewRow fila = new DataGridViewRow(); // objeto fila 

            // celda documento
            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell(); // celda creada
            celdaDocumento.Value = per.DocumentoPersona;
            fila.Cells.Add(celdaDocumento); // celda agregada a la fila

            // celda nombre
            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell(); // celda creada
            celdaNombre.Value = per.NombrePersona;
            fila.Cells.Add(celdaNombre); // celda agregada a la fila

            // celda apellido
            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell(); // celda creada
            celdaApellido.Value = per.ApellidoPersona;
            fila.Cells.Add(celdaApellido); // celda agregada a la fila

            dgPersonas.Rows.Add(fila); // agregar fila creada al date grid
            LimpiarCampos();
            txtNombreA.Focus(); // posiciona en el primer input del form
        }

        private void ckHijosA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHijosA.Checked)
            {
                mskCantidadHijosA.Enabled = true;
            }
            else
            {
                mskCantidadHijosA.Enabled = false;
            }
        }

        private void btnLimpiarDatosA_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // limpiar valores txt
            txtNombreA.Text = "";
            txtApellidoA.Text = "";
            txtCalleA.Text = "";
            txtNroCasaA.Text = "";

            // limpiar valores mask
            mskFNacimientoA.Text = "";
            mskNroDocumentoA.Text = "";
            mskCantidadHijosA.Text = "";

            // limpiar valores radio button
            rdMasculinoA.Checked = false; 
            rdFemeninoA.Checked = false;
            rdOtroA.Checked = false;

            // limpiar valores checkboxes
            ckCasadoA.Checked = false;
            ckSolteroA.Checked = false;
            ckHijosA.Checked = false;
        }

        private bool ExisteEneGrilla(string criterioABuscar) // validar para que no se repita el usuario registrado
        {
            bool resultado = false; // al cajon para hacer uso de esta funcion

            for (int i = 0; i < dgPersonas.Rows.Count; i++) // recorre todas las filas
            {
                if (dgPersonas.Rows[i].Cells["Documento"].Value.Equals(criterioABuscar)) // recorre todas las filas hasta que encuentre una de ellas que posee como Documento el criterio a buscar
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void dgPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; // saber en que indice estoy parado
            btnActualizarDatosA.Enabled = true;
            btnGuardarPersonaA.Enabled = false;
            DataGridViewRow filaSeleccionada = dgPersonas.Rows[indice];
            string documento = filaSeleccionada.Cells["Documento"].Value.ToString();
            Persona p = ObtenerPersona(documento);
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Persona p)
        {
            // texts
            txtApellidoA.Text = p.ApellidoPersona;
            txtCalleA.Text = p.CallePersona;
            txtNombreA.Text = p.NombrePersona;
            txtNroCasaA.Text = p.NroCasaPersona;

            // masks
            mskFNacimientoA.Text = p.FechaNacimientoPersona.Date.ToShortDateString(); // devuelve la fecha en formato corto
            mskNroDocumentoA.Text = p.DocumentoPersona;
            if (p.CantidadHijosPersona > 0)
            {
                mskCantidadHijosA.Text = p.CantidadHijosPersona.ToString();
            }
            else
            {
                mskCantidadHijosA.Text = "";
            }

            // radio buttons
            if (p.IdSexoPersona == 1)
            {
                rdMasculinoA.Checked = true;
            }
            else if (p.IdSexoPersona == 2)
            {
                rdFemeninoA.Checked = true;
            }
            else
            {
                rdOtroA.Checked = true;
            }

            // combos
            cbTDocumentoA.SelectedValue = p.IdTipoDocumentoPersona;
            cbCarreraA.SelectedValue = p.IdCarreraPersona;

            // cheks
            if (p.CasadoPersona)
            {
                ckCasadoA.Checked = true;
            }
            else
            {
                ckCasadoA.Checked = false;
            }

            if (p.SolteroPersona)
            {
                ckSolteroA.Checked = true;
            }
            else
            {
                ckSolteroA.Checked = false;
            }

            if (p.HijosPersona)
            {
                ckHijosA.Checked = true;
            }
            else
            {
                ckHijosA.Checked = false;
            }

        }

        private Persona ObtenerPersona(string documento)
        {
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            Persona per = new Persona();

            SqlCommand comando = new SqlCommand();
            // hacemos las consultas a la base de datos
            string consulta = "SELECT * FROM PersonasBD where NroDocumento like @doc";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@doc", documento);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            SqlDataReader dr = comando.ExecuteReader();

            if (dr != null && dr.Read())
            {
                per.NombrePersona = dr["Nombre"].ToString();
                per.ApellidoPersona = dr["Apellido"].ToString();
                per.FechaNacimientoPersona = DateTime.Parse(dr["FechaNacimiento"].ToString());
                per.IdSexoPersona = int.Parse(dr["IdSexo"].ToString());
                per.IdTipoDocumentoPersona = int.Parse(dr["IdTipoDocumento"].ToString());
                per.DocumentoPersona = dr["NroDocumento"].ToString();
                per.CallePersona = dr["Calle"].ToString();
                per.NroCasaPersona = dr["NroCasa"].ToString();
                per.SolteroPersona = bool.Parse(dr["Soltero"].ToString());
                per.CasadoPersona = bool.Parse(dr["Casado"].ToString());
                per.HijosPersona = bool.Parse(dr["Hijos"].ToString());
                per.CantidadHijosPersona = int.Parse(dr["CantidadHijos"].ToString());
                per.IdCarreraPersona = int.Parse(dr["IdCarrera"].ToString());

            }

            return per;
        }

        private void btnActualizarDatosA_Click(object sender, EventArgs e)
        {
            Persona p = ObtenerDatosPersona();
            bool resultado = ActualizarPersona(p);
            if (resultado)
            {
                MessageBox.Show("Persona actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboTipoCarrera();
                CargarComboTipoDocumento();
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario");
            }
        }

        private bool ActualizarPersona(Persona per)
        {
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resultado = false;


            SqlCommand comando = new SqlCommand();
            // hacemos las consultas a la base de datos
            string consulta = "UPDATE PersonasBD SET Nombre = @nombre, Apellido = @apellido, FechaNacimiento = @fechaNacimiento, IdSexo = @idSexo, IdTipoDocumento = @idTipoDocumento, IdCarrera = @idCarrera, NroDocumento = @nroDocumento, Calle = @calle, NroCasa = @nroCasa, Soltero = @soltero, Casado = @casado, Hijos = @hijos, CantidadHijos = @cantidadHijos WHERE NroDocumento like @nroDocumento";

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
        }
    }
}
