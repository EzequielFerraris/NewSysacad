using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public abstract class Persona
    {

        protected string nombre;
        protected string apellido;
        protected string nombreUsuario;
        protected string eMail;
        protected string password;

        protected Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.eMail = string.Empty;
            this.password = string.Empty;
        }
        protected Persona(string nombre, string apellido, string nombreUsuario, string eMail, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.eMail = eMail;
            this.password = password;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (Validaciones.ValidarNombre(value))
                { 
                    nombre = value; 
                }
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (Validaciones.ValidarNombre(value))
                {
                    apellido = value;
                }
            }
        }

        public string NombreUsuario
        {
            get => nombreUsuario;
            set
            {
                if (Validaciones.ValidarUsuario(value))
                {
                    nombreUsuario = value;
                }
               
            }
               
        }

        public string EMail
        {
            get => eMail;
            set
            {
                    if (Validaciones.ValidarMail(value))
                    {
                        eMail = value;
                    }

            }
            
        }

        public string Password
        {
            get => password;
            set
            {   
                password = value;
            }    
                
        }
    }
}
