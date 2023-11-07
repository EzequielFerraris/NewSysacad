using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaNewSysacad
{
    
    public class Curso
    {
        private string nombre;
        private int codigo;
        private string descripcion;
        private int cupoMaximo;
        private List<int> estudiantesInscriptos;
        private dia diaCursada;
        private turno turnoCursada;
        private Carrera carrera;
        private Queue<int> listaDeEspera;
        
        public Curso()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.cupoMaximo = 0;
            this.codigo = 0;
            estudiantesInscriptos = new List<int>();
            listaDeEspera = new Queue<int>();

        }
        public Curso(string nombre, string descripcion, 
            int cupoMaximo, int codigo, dia diaCursada, 
            turno turnoCursada, Carrera carrera)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cupoMaximo = cupoMaximo;
            this.codigo = codigo;
            this.diaCursada = diaCursada;
            this.turnoCursada = turnoCursada;
            this.carrera = carrera;
            estudiantesInscriptos = new List<int>();
            listaDeEspera = new Queue<int>();
        }



        public string Nombre 
        { 
            get => nombre;
            set
            {
                if (Validaciones.ValidarNombreCurso(value))
                {
                    nombre = value;
                }
            }
        }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value > 0 && value < 100000)
                {
                    codigo = value;
                }
            }
        }

        public string Descripcion 
        { 
            get => descripcion; 
            set
            {
                if (Validaciones.ValidarDescripcion(value))
                {
                    descripcion = value;
                }
            }
        }

        public int CupoMaximo
        {
            get => cupoMaximo;
            set
            {
                if(value > 0 && value < 100)
                {
                    cupoMaximo = value;
                }
            }
        }

        public List<int> EstudiantesInscriptos
        {
            get => estudiantesInscriptos;
            set => estudiantesInscriptos = value;
        }
        public dia DiaCursada
        {
            get => diaCursada;
            set => diaCursada = value;
        }
        public turno TurnoCursada
        {
            get => turnoCursada;
            set => turnoCursada = value;
        }

        public Carrera Carrera
        {
            get => carrera;
            set => carrera = value;
        }

        public Queue<int> ListaDeEspera
        {
            get => listaDeEspera;
            set => listaDeEspera = value;
        }

        //CHEQUEO SI HAY LUGAR PARA EL ESTUDIANTE
        public bool ChequearDisponibilidad()
        {
            bool resultado = true;
            if (this.CupoMaximo == this.CantidadInscriptos())
            {
                resultado = false;
            }
            return resultado;
        }


        //INSCRIPCION ESTUDIANTE
        public bool InscribirEstudiante(Estudiante estudianteNuevo, out string error)
        {
            bool resultado = false;
            error = "";

            if(estudiantesInscriptos.Count() > 0)
            {
                foreach (int legajo in estudiantesInscriptos)
                {
                    if (legajo == estudianteNuevo.Legajo)
                    {
                        error = "Usuario ya inscripto.";
                        resultado = false;
                        break;
                    }
                    resultado = true;
                }
            }
            else
            {
                resultado = true;
            }
            
            if (ChequearDisponibilidad())
            {
                if (resultado)
                {
                    estudiantesInscriptos.Add(estudianteNuevo.Legajo);
                    NewSysacad.EscribirJSON(NewSysacad.DataBaseCursosNombreArchivo, datoDelSistema.curso);
                }

            }
            else
            {
                error = "El curso se encuentra lleno ¿Desea inscribirse en la lista de espera?";
                resultado = false;
            }
            return resultado;
        }

        //INSCRIPCION EN LA LISTA DE ESPERA
        public bool InscribirEstudianteEnListaDeEspera(Estudiante estudianteNuevo, out string error)
        {
            bool resultado = true;
            error = "";

            foreach (int legajo in listaDeEspera)
            {
                if (legajo == estudianteNuevo.Legajo)
                {
                    error = "Usuario ya inscripto.";
                    resultado = false;
                    break;
                }  
            }
            if (resultado)
            {
                listaDeEspera.Enqueue(estudianteNuevo.Legajo);
            }

            return resultado;
        }

        public int CantidadInscriptos()
        { 
            return estudiantesInscriptos.Count(); 
        }
    }

   
}
