using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Administrador : Persona
    {
        
        public Administrador(string nombre, string apellido, string nombreUsuario, string eMail, string password) : base(nombre, apellido, nombreUsuario, eMail, password)
        {
            
        }
    }

}

