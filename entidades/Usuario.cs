using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapp_r2.entidades
{
    public class Usuario
    {
        // esta clase tiene dos atributus, nombre de usuario y contraseña 
        private string NombreUsu;
        private string Pass;

        // toda clase tiene que tener un constructor
        public Usuario(string nombreUsuario, string password)
        {
            // seteamos 
            NombreUsu = nombreUsuario;
            Pass = password;
        }

        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
