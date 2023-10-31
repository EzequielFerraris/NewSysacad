using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Administrador : Persona
    {
        
        public Administrador() { }
        public Administrador(string nombre, string apellido, string nombreUsuario, 
                            string eMail, string password) 
                            : base(nombre, apellido, nombreUsuario, 
                            eMail, password)
        {
            
        }

        private bool ValidarEstudianteNuevo(Estudiante estudianteNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            foreach (Estudiante estudiante in NewSysacad.ListaEstudiantes)
            {
                if (estudiante.NombreUsuario == estudianteNuevo.NombreUsuario)
                {
                    campoRepetido = "Nombre de usuario";
                    resultado = false;
                    break;
                }
                else if (estudiante.Dni == estudianteNuevo.Dni)
                {
                    campoRepetido = "DNI";
                    resultado = false;
                    break;
                }
                else if (estudiante.EMail == estudianteNuevo.EMail)
                {
                    campoRepetido = "E-Mail";
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        //ESTUDIANTES ------------------------------------------------------------------------------------------
        //AGREGA UN ESTUDIANTE Y LE ASIGNA UN NÚMERO DE LEGAJO. AUMENTA EL NÚMERO DE LEGAJO 
        public bool AgregarEstudiante(Estudiante estudianteNuevo, out string error)
        {
            bool condicion = ValidarEstudianteNuevo(estudianteNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                estudianteNuevo.Legajo += NewSysacad.numeroDeLegajo;
                NewSysacad.numeroDeLegajo++;
                List<Estudiante> actualizada = NewSysacad.ListaEstudiantes;
                NewSysacad.ListaEstudiantes = actualizada;
                NewSysacad.EscribirJSON(NewSysacad.DataBaseEstudiantesNombreArchivo, datoDelSistema.estudiante);
                EnviarCorreoElectronico(estudianteNuevo);
                return true; 
            }
            return false;
        }

        //OBTIENE LISTA DE ESTUDIANTES DEL SISTEMA
        public List<Estudiante> ListaEstudiantes()
        {
            return NewSysacad.ListaEstudiantes; 
        }

        //ENVIA UN CORREO ELECTRONICO AL ESTUDIANTE REGISTRADO (?)
        public bool EnviarCorreoElectronico(Estudiante estudianteRegistrado)
        {
            return true;
        }

        //CURSOS---------------------------------------------------------------
        //VALIDA UN CURSO

        public bool ValidarCursoNuevo(Curso cursoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                if (curso.Nombre == cursoNuevo.Nombre)
                {
                    campoRepetido = "Nombre del curso";
                    resultado = false;
                    break;
                }
                else if (curso.Codigo == cursoNuevo.Codigo)
                {
                    campoRepetido = "Codigo";
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        //AGREGA UN CURSO NUEVO
        public bool AgregarCurso(Curso cursoNuevo, out string error)
        {
            bool resultado = false;
            bool condicion = ValidarCursoNuevo(cursoNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                List<Curso> actualizada = NewSysacad.ListaCursos;
                actualizada.Add(cursoNuevo);
                NewSysacad.ListaCursos = actualizada;
                NewSysacad.EscribirJSON(NewSysacad.DataBaseCursosNombreArchivo, datoDelSistema.curso);
                resultado = true;
            }
            return resultado;
        }

        //ELIMINAR UN CURSO
        public bool EliminarCurso(Curso cursoAEliminar, out string error)
        {
            bool resultado = false;
            error = "Curso no encontrado";
            foreach (var curso in NewSysacad.ListaCursos)
            {
                if((cursoAEliminar.Nombre == curso.Nombre) && (cursoAEliminar.Codigo == curso.Codigo))
                {
                    List<Curso> actualizada = NewSysacad.ListaCursos;
                    actualizada.Remove(curso);
                    NewSysacad.ListaCursos = actualizada;
                    NewSysacad.EscribirJSON(NewSysacad.DataBaseCursosNombreArchivo, datoDelSistema.curso);
                    resultado = true;
                    error = String.Empty;
                    break;
                }
            }
            return resultado;
        }

        //LISTA DE CURSOS

        public List<Curso> ObtenerCursos()
        {
            return NewSysacad.ListaCursos;
        }

        //PAGOS--------------------------------------------------------------------------
        //OBTENER PAGOS
        public List<Pago> ObtenerPagosPendientes()
        {
            return NewSysacad.ListaPagosPendientes;
        }

        public List<Pago> ObtenerPagosRealizados ()
        {
            return NewSysacad.ListaPagosRealizados;
        }

        //VALIDA UN PAGO NUEVO
        private bool ValidarRegistroPagoNuevo(Pago pagoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            if (ObtenerPagosPendientes().Count() > 0)
            {
                foreach (Pago pago in ObtenerPagosPendientes())
                {
                    if (pago.Concepto == pagoNuevo.Concepto)
                    {
                        campoRepetido = "Concepto del Pago";
                        resultado = false;
                        break;
                    }
                    else if (pago.Codigo == pagoNuevo.Codigo)
                    {
                        campoRepetido = "Codigo";
                        resultado = false;
                        break;
                    }
                }
            }

            return resultado;
        }

        //AGREGAR PAGOS 
        public bool AgregarPago(Pago pagoNuevo, out string error)
        {
            bool resultado = false;
            bool condicion = ValidarRegistroPagoNuevo(pagoNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                List<Pago> actualizada = ObtenerPagosPendientes();
                actualizada.Add(pagoNuevo);
                NewSysacad.ListaPagosPendientes = actualizada;
                NewSysacad.EscribirJSON(NewSysacad.DataBasePagosPendientes, datoDelSistema.pagoPendiente);
                resultado = true;
            }
            return resultado;
        }
    }

}

