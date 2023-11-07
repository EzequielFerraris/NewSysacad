
using BibliotecaNewSysacad;
using System.Data.SqlClient;

namespace TestBD
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Estudiante> estudiantes = BDConexion.LeerEstudiantes();

            foreach (var est in estudiantes)
            {
                Console.WriteLine($"{est.Nombre}, {est.Apellido}");
            }
        }
    }
}