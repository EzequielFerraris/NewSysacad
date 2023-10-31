using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public enum dia
    {
        Lunes,
        Martes,
        Miércoles,
        Jueves,
        Viernes,
    }

    public enum turno
    {
        Mañana,
        Tarde,
        Noche
    }

    public enum datoDelSistema
    {
        estudiante,
        administrador,
        curso,
        pagoPendiente,
        pagoRealizado
    }

    public enum TipoDePago
    {
        Pendiente,
        Realizado
    }

    public enum FormaDePago
    {
        Credito,
        Debito,
        Transferencia
    }

    public enum Carrera
    {
        TUP,
        TUSI,
        LS,
        IS, 
        NINGUNA
    }

    public static class Enumerables
    {
        //CARRERA
        public static string CarreraAString(Carrera carrera)
        {
            string result = String.Empty;
            switch (carrera)
            {
                case Carrera.TUP:
                    result = "Tecnicatura Universitaria en Programación";
                    break;
                case Carrera.TUSI:
                    result = "Tecnicatura Universitaria en Sistemas de la Información";
                    break;
                case Carrera.LS:
                    result = "Licenciatura en Sistemas";
                    break;
                case Carrera.IS:
                    result = "Ingeniería en Sistemas";
                    break;
                case Carrera.NINGUNA:
                    result = "";
                    break;
            }
            return result;
        }

        public static Carrera StringACarrera(string carrera)
        {
            Carrera result;
            switch (carrera)
            {
                case "Tecnicatura Universitaria en Programación":
                    result = Carrera.TUP;
                    break;
                case "Tecnicatura Universitaria en Sistemas de la Información":
                    result = Carrera.TUSI;
                    break;
                case "Licenciatura en Sistemas":
                    result = Carrera.LS;
                    break;
                case "Ingeniería en Sistemas":
                    result = Carrera.IS;
                    break;
                default:
                    result = Carrera.NINGUNA;
                    break;
            }
            return result;
        }
    }
}
