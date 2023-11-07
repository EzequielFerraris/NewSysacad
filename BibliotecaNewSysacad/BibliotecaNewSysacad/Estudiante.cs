using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Estudiante : Persona
    {
        private string dni;
        private string calle;
        private string altura;
        private string telefono;
        private DateTime inscripcion;
        private Carrera carrera;
        public bool debeCambiarPassword;
        private int legajo;
        private List<int> cursosInscriptoCodigos;
        private List<string> cursosAprobados;

        public Estudiante()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.eMail = string.Empty;
            this.password = string.Empty;
            this.dni = string.Empty;
            this.calle = string.Empty;
            this.altura = string.Empty;
            this.telefono = string.Empty;
            this.carrera = Carrera.TUP;

            cursosInscriptoCodigos = new List<int>();
            cursosAprobados = new List<string>();   
 
        }
        
        public string Dni 
        {
            get => dni;
            set 
            {
                if(Validaciones.ValidarNumero(value, 7, 9))
                {
                    dni = value;
                }
            }
        }
        public string Calle
        {
            get => calle;
            set
            {
                if (Validaciones.ValidarCalle(value))
                {
                    calle = value;
                }
            }
        }

        public string Altura
        {
            get => altura;
            set
            {
                if (Validaciones.ValidarAltura(value))
                {
                    altura = value;
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

        public bool DebeCambiarPassword
        {
            get => debeCambiarPassword;
            set => debeCambiarPassword = value;
        }

        public int Legajo
        {
            get => legajo;
            set
            {
                if (legajo == default)
                { 
                    legajo = value; 
                }
            }
        }

        public DateTime Inscripcion
        {
            get => inscripcion;
            set => inscripcion = value;
        }

        public List<int> CursosInscriptoCodigos
        { 
            get => cursosInscriptoCodigos; 
            set => cursosInscriptoCodigos = value;
        }

        public Carrera Carrera
        {
            get => carrera;
            set => carrera = value;
        }

        public List<string> CursosAprobados
        {
            get => cursosAprobados;
            set => cursosAprobados = value;
        }

        //ACCIONES DE ESTUDIANTE CON CURSOS--------------------------------------------------------------------------------------------
        //LISTA DE CURSOS
        public List<Curso> ObtenerCursos()
        {
            List<Curso> cursosVisibles = new List<Curso>();

            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                if(this.Carrera == curso.Carrera)
                {
                    cursosVisibles.Add(curso);
                }
            }
            return cursosVisibles;
        }

        public List<Curso> ObtenerCursosInscripto()
        {
            List<Curso> cursosInscripto = new List<Curso>();

            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                if (this.Carrera == curso.Carrera)
                {
                    foreach (int codigo in this.cursosInscriptoCodigos)
                    {
                        if(codigo == curso.Codigo)
                        {
                            cursosInscripto.Add(curso);
                            break;
                        }
                       
                    }
                    
                }
            }
            return cursosInscripto;
        }

        public bool ChequearDisponibilidad(Curso cursoChequear)
        {
            List<Curso> cursos = ObtenerCursosInscripto();
            bool result = true;
            if(cursosInscriptoCodigos.Count > 0)
            {
                if(cursoChequear.Carrera != this.Carrera)
                {
                    result = false;
                }
                else
                {
                    foreach (Curso cursoInscripto in cursos)
                    {
                        if (cursoInscripto.DiaCursada == cursoChequear.DiaCursada
                            && cursoInscripto.TurnoCursada == cursoChequear.TurnoCursada
                            )
                        {
                            result = false;
                        }
                    }
                 }
                
             }
            return result;
          }
        
        public void AgregarCurso(Curso curso)
        {
            if(ChequearDisponibilidad(curso))
            {
                cursosInscriptoCodigos.Add(curso.Codigo);
                NewSysacad.ActualizarEstudiante(this);
            }
            
        }
        public void ActualizarCursosInscripto()
        {
            foreach(Curso curso in NewSysacad.ListaCursos)
            {
                foreach(int estudiante in curso.EstudiantesInscriptos) 
                { 
                    if(estudiante == this.Legajo) 
                    {
                        AgregarCurso(curso);
                        break;
                    }
                }
            }
        }

        //ACTUALIZA UN CURSO YA EXISTENTE CON NUEVOS INSCRIPTOS
        public bool ActualizarCurso(Curso cursoNuevo)
        {
            bool resultado = false;
            foreach (Curso c in NewSysacad.ListaCursos)
            {
                if (c.Nombre == cursoNuevo.Nombre && c.Codigo == cursoNuevo.Codigo)
                {
                    List<Curso> actualizada = NewSysacad.ListaCursos;
                    actualizada.Remove(c);
                    actualizada.Add(cursoNuevo);
                    NewSysacad.ListaCursos = actualizada;
                    NewSysacad.EscribirJSON(NewSysacad.DataBaseCursosNombreArchivo, datoDelSistema.curso);
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
        
        //PAGOS---------------------------------------------------------------------------------------------------

        public List<Pago> ObtenerPagosPendientes()
        {
            return NewSysacad.ListaPagosPendientes;
        }

        public List<Pago> ObtenerPagosRealizados()
        {
            return NewSysacad.ListaPagosRealizados;
        }

        //VALIDAR PAGOS REALIZADOS
        public bool ValidarPagoRealizadoNuevo(Pago pagoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            if (this.ObtenerPagosRealizados().Count() > 0)
            {
                foreach (Pago pago in this.ObtenerPagosRealizados())
                {
                    if (pago.Concepto == pagoNuevo.Concepto && pago.LegajoDelEstudiante == pagoNuevo.LegajoDelEstudiante && pago.Codigo == pagoNuevo.Codigo)
                    {
                        campoRepetido = "Pago ya realizado";
                        resultado = false;
                        break;
                    }

                }
            }
            return resultado;
        }

        //REGISTRAR PAGO REALIZADO
        public void RegistrarPagoRealizado(Pago pagoNuevo)
        {
            List<Pago> actualizada = this.ObtenerPagosRealizados();
            actualizada.Add(pagoNuevo);
            NewSysacad.ListaPagosRealizados = actualizada;
            NewSysacad.EscribirJSON(NewSysacad.DataBasePagosRealizados, datoDelSistema.pagoRealizado);
        }

        
    }
}
