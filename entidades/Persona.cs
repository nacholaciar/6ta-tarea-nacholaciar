using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapp_r2.entidades
{
    public class Persona
    {
        // atributos
        private string Apellido;
        private string Nombre;
        private DateTime FechaNacimiento;
        private int IdSexo;
        private int IdTipoDocumento;
        private int IdCarrera;
        private string Documento;
        private string Calle;
        private string NroCasa;
        private bool Soltero;
        private bool Casado;
        private bool Hijos;
        private int CantidadHijos;

        // toda clase tiene que tener un constructor
        //public Persona(string documento, string apellido, string nombre)
        //{
        //    // seteamos 
        //    Documento = documento;
        //    Apellido = apellido;
        //    Nombre = nombre;
        //}

        public Persona()
        {

        }

        public string ApellidoPersona
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string NombrePersona
        {
            get => Nombre;
            set => Nombre = value;
        }

        public DateTime FechaNacimientoPersona
        {
            get => FechaNacimiento;
            set => FechaNacimiento = value;
        }

        public int IdSexoPersona
        {
            get => IdSexo;
            set => IdSexo = value;
        }

        public int IdTipoDocumentoPersona
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public int IdCarreraPersona
        {
            get => IdCarrera;
            set => IdCarrera = value;
        }

        public string DocumentoPersona
        {
            get => Documento;
            set => Documento = value;
        }

        public string CallePersona
        {
            get => Calle;
            set => Calle = value;
        }

        public string NroCasaPersona
        {
            get => NroCasa;
            set => NroCasa = value;
        }

        public bool SolteroPersona
        {
            get => Soltero;
            set => Soltero = value;
        }

        public bool CasadoPersona
        {
            get => Casado;
            set => Casado = value;
        }

        public bool HijosPersona
        {
            get => Hijos;
            set => Hijos = value;
        }

        public int CantidadHijosPersona
        {
            get => CantidadHijos;
            set => CantidadHijos = value;
        }
    }
}
