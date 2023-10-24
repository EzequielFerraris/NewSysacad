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
}
