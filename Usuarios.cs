using miapp_r2.AccesoADatos;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgUsuariosFU.DataSource = ADUsuarios.ObtenerListadoUsuarios();
        } // cargamos la grilla con los datos de la base de datos

        private void btnLimpiarCamposFU_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        } // basicamente usamos el metodo LimpiarCampos en el este boton

        private void LimpiarCampos()
        {
            txtNombreFU.Text = "";
            txtContraseñaFU.Text = "";
            txtRContraseñaFU.Text = "";
        }

        private void btnAltaUsuarioFU_Click(object sender, EventArgs e) 
        {

            if (txtNombreFU.Text.Equals(""))
            {
                MessageBox.Show("debe agregar un usuario");
            }
            else
            {
                if (txtContraseñaFU.Text.Equals(txtRContraseñaFU.Text))
                {
                    MessageBox.Show("CORRECTO");
                    bool resultado = ADUsuarios.InsertarUsuarios(txtNombreFU.Text, txtContraseñaFU.Text);

                    if (resultado)
                    {
                        MessageBox.Show("Usuario dado de alta");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("las contraseña no coinciden");

                }
            }
        } // usamos el metodo InsertarUsuario (que ahora se encuentra alojado en ADUsuarios)en este boton
    }
}
