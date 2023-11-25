using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Profesor : Persona, CRUDInterfase<Profesor>
    {
        private string dni;
        private string telefono;
        
        public Profesor() 
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.eMail = string.Empty;
            this.password = string.Empty;
            this.dni = string.Empty;
            this.telefono = string.Empty;
        }

        public string Dni
        {
            get => dni;
            set
            {
                if (Validaciones.ValidarNumero(value, 7, 9))
                {
                    dni = value;
                }
            }
        }

        public string Telefono
        {
            get => telefono;
            set
            {
                if (Validaciones.ValidarNumero(value, 8, 12))
                {
                    telefono = value;
                }
            }
        }

        public bool ActualizarEnBD()
        {
            throw new NotImplementedException();
        }

        public bool AgregarABD(out string error)
        {
            throw new NotImplementedException();
        }

        public bool EliminarDeBD()
        {
            throw new NotImplementedException();
        }
    }
}
