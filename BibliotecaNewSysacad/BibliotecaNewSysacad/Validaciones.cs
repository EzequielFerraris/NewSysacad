using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaNewSysacad
{
    public static class Validaciones
    {
        public static bool ValidarNumero(string dato, int longitudMinima, int longitudMaxima)
        {   
            bool valid = true;
            if (string.IsNullOrEmpty(dato))
                valid = false;
            foreach (char c in dato)
            {

                if (!char.IsNumber(c))
                    valid = false;
            }
            if (dato.Length < longitudMinima || dato.Length > longitudMaxima)
                valid =  false;

            return valid;
        }

        public static bool ValidarCalle(string calle)
        {
            if (string.IsNullOrEmpty(calle))
                return false;
            if (calle.Trim() != calle)
                return false;

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
            if (numero <= 0)
                return false;
            return true;
        }



        public static bool ValidarNombreYApellido(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return false;

            if (nombre.Trim() != nombre)
                return false;

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        public static bool ValidarUsuario(string usuario)
        {

            if (string.IsNullOrEmpty(usuario))
                return false;

            if (usuario.Trim() != usuario)
                return false;

            foreach (var c in usuario)
            {
                if (!(char.IsLetter(c) || char.IsDigit(c) || c == '-'))
                    return false;
            }

            return true;
        }

        public static bool ValidarNombre(string nombre)
        {

            if (string.IsNullOrEmpty(nombre))
                return false;

            if (nombre.Trim() != nombre)
                return false;

            foreach (char c in nombre)
            {

                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static bool ValidarMail(string mail)
        {

            Regex validarEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

            if (validarEmailRegex.IsMatch(mail))
            {
                return true;
            }

            return false;
        }


        public static bool ValidarDescripcion(string descripcion)
        {

            if (string.IsNullOrEmpty(descripcion))
                return false;

            if (descripcion.Trim() != descripcion)
                return false;

            return true;
        }

        public static bool ValidarNombreCurso(string nombre)
        {

            if (string.IsNullOrEmpty(nombre))
                return false;


            if (nombre.Trim() != nombre)
                return false;


            foreach (var c in nombre)
            {
                if (!(char.IsLetter(c) || char.IsDigit(c) || c == '-' || c == ' ' ))
                    return false;
            }
            return true;
        }

        public static bool ValidarMesTarjeta(string mes)
        {
            if (!int.TryParse(mes, out var numero))
                return false;

            if (numero < 1 || numero > 12)
                return false;

            return true;

        }

        public static bool ValidarAnioTarjeta(string anio)
        {
            if (!int.TryParse(anio, out var numero))
                return false;

            if (numero < 23 || numero > 40)
                return false;
            return true;
        }

        public static bool ValidarDecimal(string flotante)
        {
            if (!decimal.TryParse(flotante, out var numero))
                return false;

            if (numero < 0 || numero > 10)
                return false;
            return true;
        }

        public static bool ValidarIntPositivo(string intpositivo)
        {
            if (!int.TryParse(intpositivo, out var numero))
                return false;
            if (numero <= 0)
                return false;
            return true;
        }

    }
}
