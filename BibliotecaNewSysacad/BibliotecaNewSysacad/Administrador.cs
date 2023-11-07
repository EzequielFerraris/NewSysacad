using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Administrador : Persona
    {
        private int id;
        private string queryEstudiante = "INSERT INTO ESTUDIANTE VALUES (@DNI, @APELLIDO, @NOMBRE, @EMAIL, @NOMBRE_USUARIO, @CALLE, @ALTURA, @TELEFONO, @CARRERA, @DEBE_CAMBIAR_PASS, @INSCRIPCION_FECHA, @PASSWORD);";
        public Administrador() { }



        //ESTUDIANTES ------------------------------------------------------------------------------------------
        //AGREGA UN ESTUDIANTE Y LE ASIGNA UN NÚMERO DE LEGAJO. AUMENTA EL NÚMERO DE LEGAJO 
        private bool ValidarEstudianteNuevo(Estudiante estudianteNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            NewSysacad.ActualizarListaEstudiantes();

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

        public bool AgregarEstudiante(Estudiante e, out string error)
        {
            bool condicion = ValidarEstudianteNuevo(e, out string campoRepetido);
            error = campoRepetido;

            if (condicion)
            {
                //ESCRIBIR LA QUERY A LA BASE DE DATOS AQUÍ
                try
                {

                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = queryEstudiante;
                    sqlCommand.Parameters.AddWithValue("@DNI", e.Dni);
                    sqlCommand.Parameters.AddWithValue("@APELLIDO", e.Apellido);
                    sqlCommand.Parameters.AddWithValue("@NOMBRE", e.Nombre);
                    sqlCommand.Parameters.AddWithValue("@EMAIL", e.EMail);
                    sqlCommand.Parameters.AddWithValue("@NOMBRE_USUARIO", e.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@CALLE", e.Calle);
                    sqlCommand.Parameters.AddWithValue("@ALTURA", e.Altura);
                    sqlCommand.Parameters.AddWithValue("@TELEFONO", e.Telefono);
                    sqlCommand.Parameters.AddWithValue("@CARRERA", (int)e.Carrera);
                    sqlCommand.Parameters.AddWithValue("@DEBE_CAMBIAR_PASS", e.DebeCambiarPassword);
                    sqlCommand.Parameters.AddWithValue("@INSCRIPCION_FECHA", e.Inscripcion.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@PASSWORD", e.Password);
                  

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    BDConexion.conexion.Close();
                }
                //

                EnviarCorreoElectronico(e);
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

