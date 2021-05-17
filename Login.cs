using miapp_r2.AccesoADatos;
using miapp_r2.entidades; // creamos un using del Objeto Usuario para poder utilizarlo en este form
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace miapp_r2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals("") || txtContraseña.Text.Equals("")) // comparo si es igual
            {
                MessageBox.Show("debe ingresar un nombre de usuario y password");

            }
            else
            {

                bool resultado = false;

                resultado = ADUsuarios.ValidarUsuario(txtNombre.Text, txtContraseña.Text);

                if (resultado)
                {
                    Usuario user = new Usuario(txtNombre.Text, txtContraseña.Text);
                    Principal ventana = new Principal(user);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no existe");
                }
            }
        } // usamos el metodo ValidarUsuario (que hora se encuentra en ADUsuarios) en este boton

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
