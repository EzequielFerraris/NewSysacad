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
                    result = "Tec. Univ. en Programación";
                    break;
                case Carrera.TUSI:
                    result = "Tec. Univ. en Sistemas";
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

        
    }
}
