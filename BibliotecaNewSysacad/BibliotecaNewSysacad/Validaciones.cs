using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaNewSysacad
{
    public static class Validaciones
    {
        public static bool ValidarNumero(string dato, int longitudMinima, int longitudMaxima)
        {   
            bool valid = true;
            /*
                verifica si el campo es null o vacío, en tal caso, retorna false
                de lo contrario retorna true
             */
            if (string.IsNullOrEmpty(dato))
                valid = false;
            /*
                verifica si cada caracter es número
            
             */
            foreach (char c in dato)
            {

                if (!char.IsNumber(c))
                    valid = false;
            }
            /*
             verifica que el número ingresado esté dentro del rango correspondiente
            (que está indicado por parámetro), si el número está dentro del rango, retorna
            true, de lo contrario retorna false
             */
            if (dato.Length < longitudMinima || dato.Length > longitudMaxima)
                valid =  true;

            return valid;
        }

        public static bool ValidarCalle(string calle)
        {
            /*
                verifica si el campo es null o vacío, en tal caso, retorna false
                de lo contrario retorna true
             */
            if (string.IsNullOrEmpty(calle))
                return false;

            /*
             Verifica si la cadena de texto ingresada tiene espacios vacios en los
            extremos derechos e izquierdos, en tal caso, retorna false, de lo 
            contrario retorna true
             
             */
            if (calle.Trim() != calle)
                return false;

            /*
             Valida que la cadena de texto pueda tener unicamente espacios entre
            palabras y que unicamente tome como válido el "." y ningún 
            otro caracter especial, si la cadena de texto NO cumple
            con esos requisitos, devuekve false, de lo contrario retorna true
             
             */
            foreach (char c in calle)
            {

                if (!char.IsLetter(c) && c != ' ' && c != '.')
                    return false;
            }

            return true;

        }
        public static bool ValidarAltura(string altura)
        {
            if (!int.TryParse(altura, out var numero))
                return false;
            /*
             
             Valida que el entero ingresado no sea ni menor ni igual a 0
             
             */
            if (numero <= 0)
                return false;


            return true;

        }

        public static bool ValidarNombreYApellido(string nombre)
        {
            /*
             Verifica si la cadena de texto ingresada es "null" o está vacía
            en ese caso retorna false, de lo contrario, retorna true
             
             */
            if (string.IsNullOrEmpty(nombre))
                return false;


            /*
             Verifica que la cadena de texto NO tenga espacios vacíos en 
            sus extremos derechos o izquierdos, en caso de que tenga. retorna false
            de lo contrario retorna true
             
             */
            if (nombre.Trim() != nombre)
                return false;



            /*
             Verifica cada caracter de la cadena de texto y chequea que
            únicamente sean letras y solamente toma como válido el espacio 
            vació entre palabras (con la idea de que sea un solo campo
            para ingresar nombre y apellido), tampoco admite ningún caracter
            especial, en caso de que la cadena NO cumpla con estas validaciones,
            se va a retornar un false, de lo contrario, si es válida, retorna true
             
             */
            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }

            return true;

        }

        public static bool ValidarUsuario(string usuario)
        {

            /*
             Verifica si la cadena de string es "null" o está vacía
             
             */

            if (string.IsNullOrEmpty(usuario))
                return false;

            /*
             Verifica que la cadena de texto NO tenga espacios vacíos en 
            sus extremos derechos o izquierdos, en caso de que tenga. retorna false
            de lo contrario retorna true
             
             */

            if (usuario.Trim() != usuario)
                return false;

            /*
             Recorre cada caractér de la cadena de texto para analizar que no 
            tenga ningún caractér además de letras, números o guiones, en caso de 
            que la cadena de texto NO cumpla con las validaciones, retorna false, 
            en caso contrario, retorna true
             
             
             */

            foreach (var c in usuario)
            {
                if (!(char.IsLetter(c) || char.IsDigit(c) || c == '-'))
                    return false;
            }

            return true;
        }

        public static bool ValidarNombre(string nombre)
        {
            /*
                verifica si el campo es null o vacío, en tal caso, retorna false
                de lo contrario retorna true
             */
            if (string.IsNullOrEmpty(nombre))
                return false;

            /*
             Verifica si la cadena de texto ingresada tiene espacios vacios en los
            extremos derechos e izquierdos, en tal caso, retorna false, de lo 
            contrario retorna true
             
             */
            if (nombre.Trim() != nombre)
                return false;
            /*
             Valida que la cadena de texto pueda tener unicamente letras
             
             */
            foreach (char c in nombre)
            {

                if (!char.IsLetter(c))
                    return false;
            }

            return true;

        }

        public static bool ValidarMail(string mail)
        {
            return true;
        }

        public static bool ValidarDescripcion(string descripcion)
        {
            /*
                verifica si el campo es null o vacío, en tal caso, retorna false
                de lo contrario retorna true
             */
            if (string.IsNullOrEmpty(descripcion))
                return false;

            /*
             Verifica si la cadena de texto ingresada tiene espacios vacios en los
            extremos derechos e izquierdos, en tal caso, retorna false, de lo 
            contrario retorna true
             
             */
            if (descripcion.Trim() != descripcion)
                return false;

            return true;

        }

        public static bool ValidarNombreCurso(string nombre)
        {

            /*
             Verifica si la cadena de string es "null" o está vacía
             
             */

            if (string.IsNullOrEmpty(nombre))
                return false;

            /*
             Verifica que la cadena de texto NO tenga espacios vacíos en 
            sus extremos derechos o izquierdos, en caso de que tenga. retorna false
            de lo contrario retorna true
             
             */

            if (nombre.Trim() != nombre)
                return false;

            /*
             Recorre cada caractér de la cadena de texto para analizar que no 
            tenga ningún caractér además de letras, números o guiones, en caso de 
            que la cadena de texto NO cumpla con las validaciones, retorna false, 
            en caso contrario, retorna true
             
             
             */

            foreach (var c in nombre)
            {
                if (!(char.IsLetter(c) || char.IsDigit(c) || c == '-' || c == ' ' ))
                    return false;
            }

            return true;
        }

    }
}
