using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public interface CRUDInterfase<T> where T : class
    {
        bool AgregarABD(out string error);
        bool EliminarDeBD();
        bool ActualizarEnBD();

    }
}
