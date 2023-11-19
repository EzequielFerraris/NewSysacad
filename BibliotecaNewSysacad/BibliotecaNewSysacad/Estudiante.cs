﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaNewSysacad
{
    public class Estudiante : Persona, CRUDInterfase<Estudiante> 
    {
        private string dni;
        private string calle;
        private string altura;
        private string telefono;
        private DateTime inscripcion;
        private Carrera carrera;
        public bool debeCambiarPassword;
        private int legajo;
        private decimal promedio;

        private List<int> cursosInscriptoCodigos;
        private List<string> cursosAprobados;
        private List<int> enListaDeEspera;

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
            this.promedio = 0;

            cursosInscriptoCodigos = new List<int>();
            cursosAprobados = new List<string>();
            enListaDeEspera = new List<int>();


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

        public List<int> EnListaDeEspera
        {
            get => enListaDeEspera;
            set => enListaDeEspera = value;
        }

        public decimal Promedio
        {
            get => promedio;
            set => promedio = value;
        }
  

        //ACCIONES DE ESTUDIANTE CON CURSOS--------------------------------------------------------------------------------------------
        //LISTA DE CURSOS
        public List<Curso> ObtenerCursosVisibles()
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

        public void ActualizarCodigosCursosInscripto()
        {
            string query = "SELECT * FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE LEGAJO_ESTUDIANTE = @LEGAJO;";
            try
            {
                BDConexion.conexion.Open();

                cursosInscriptoCodigos.Clear();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@LEGAJO", (int)this.Legajo);

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        
                    int codigo = Convert.ToInt32(dataReader["CODIGO_CURSO"]); 
                    cursosInscriptoCodigos.Add(codigo);
                        
                        
                    }
                }

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
        }

        public List<Curso> ObtenerCursosInscripto()
        {
            List<Curso> cursosInscripto = new List<Curso>();
            ActualizarCodigosCursosInscripto();

            if(this.cursosInscriptoCodigos.Count() > 0)
            {
                foreach (int codigo in cursosInscriptoCodigos)
                {
                    foreach (Curso curso in NewSysacad.ListaCursos)
                    {
                        if (curso.Codigo == codigo)
                        {
                            cursosInscripto.Add(curso);
                            break;
                        }
                    }
                }
            }
            return cursosInscripto;
        }

        public bool ChequearDisponibilidadDelEstudiante(Curso cursoChequear)
        {
            List<Curso> cursos = ObtenerCursosInscripto();
            bool result = true;
            if (cursos.Count > 0)
            {
                if (cursoChequear.Carrera != this.Carrera)
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
        public bool InscribirEnCurso(Curso curso)
        {
            bool result = false;
            if(ChequearDisponibilidadDelEstudiante(curso))
            {
                try
                {
                    string query = "INSERT INTO ESTUDIANTES_CURSOS_INSCRIPTOS VALUES (@LEGAJO_ESTUDIANTE, @CODIGO_CURSO);";
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = query;

                    sqlCommand.Parameters.AddWithValue("@LEGAJO_ESTUDIANTE", (int)this.Legajo);
                    sqlCommand.Parameters.AddWithValue("@CODIGO_CURSO", (int)curso.Codigo);
                    
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    result = true;

                }
                catch (Exception)
                {
                    result = false;
                    return result;
                    throw;

                }
                finally
                {
                    BDConexion.conexion.Close();

                }
            }
            return result;
            
        }

        public DataTable ObtenerCursosAprobados()
        {
            string query = "SELECT NOMBRE_MATERIA, NOTA_FINAL FROM ALUMNOS_CURSOS_APROBADOS WHERE LEGAJO = @LEGAJO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@LEGAJO", this.Legajo);

            return ConsultasBD.ObtenerDataTabla(sqlCommand);
        }


        public List<string> ObtenerNombresCursosAprobados()
        { 
            List<string> result = new List<string>();

            DataTable dt = this.ObtenerCursosAprobados();

            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr[0].ToString());
            }

            return result;
        }

        //LISTAS DE ESPERA-------------------------------------------------------

        private int MapeoCursosEnEspera(IDataReader dataReader)
        {
            int codigo = Convert.ToInt32(dataReader["CODIGO_CURSO"]);

            return codigo;
        }

        private void ObtenerCursosEnListaEspera()
        {
            string query = "SELECT CODIGO_CURSO FROM LISTAS_DE_ESPERA WHERE LEGAJO_ESTUDIANTE = @LEGAJO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@LEGAJO", this.Legajo);

            EnListaDeEspera = ConsultasBD.ObtenerLista(sqlCommand, MapeoCursosEnEspera);
        }

        public bool ChequearListaEspera(int codigo)
        {
            bool resultado = true;
            ObtenerCursosEnListaEspera();

            foreach (int codigoCurso in EnListaDeEspera)
            {
                if (codigoCurso == codigo) 
                { 
                    resultado = false; break; 
                }
            }

            return resultado;
        }

        public void InscribirEnListaEspera(int codigo)
        {
            try
            {
                string query = "INSERT INTO LISTAS_DE_ESPERA VALUES(@CODIGO_CURSO, @LEGAJO_ESTUDIANTE, @FECHA_INSCRIPCION);";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;

                sqlCommand.Parameters.AddWithValue("@CODIGO_CURSO", codigo);
                sqlCommand.Parameters.AddWithValue("@LEGAJO_ESTUDIANTE", this.Legajo);  
                sqlCommand.Parameters.AddWithValue("@FECHA_INSCRIPCION", DateTime.Now.ToString("yyyy-MM-dd"));
                
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
        }

        //PAGOS---------------------------------------------------------------------------------------------------

        public List<Pago> ObtenerPagosPendientes()
        {
            return NewSysacad.ListaPagosPendientes;
        }

        public List<Pago> ObtenerPagosRealizados()
        {
            List <Pago> listaPendientes = new List<Pago>();
            foreach (Pago pago in NewSysacad.ListaPagosRealizados)
            {
                if(pago.LegajoDelEstudiante == this.Legajo)
                {
                    listaPendientes.Add(pago);
                }
            }

            return listaPendientes;
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
            pagoNuevo.AgregarABD(out string error);
        }

        //BD---------------------------------------------------------------------------------------------------

        private bool ValidarParaAgregar(out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            NewSysacad.ActualizarLista<Estudiante>(NewSysacad.ActualizarEstudiantes, NewSysacad.MapeoEstudiante); 

            foreach (Estudiante estudiante in NewSysacad.ListaEstudiantes)
            {
                if (estudiante.NombreUsuario == this.NombreUsuario)
                {
                    campoRepetido = "Nombre de usuario";
                    resultado = false;
                    break;
                }
                else if (estudiante.Dni == this.Dni)
                {
                    campoRepetido = "DNI";
                    resultado = false;
                    break;
                }
                else if (estudiante.EMail == this.EMail)
                {
                    campoRepetido = "E-Mail";
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        public bool AgregarABD(out string error) 
        {
            bool condicion = ValidarParaAgregar(out string error1);
            bool result = false;
            error = error1;
            
            if (condicion)
            {
                try
                {
                    string query = "INSERT INTO ESTUDIANTE VALUES (@DNI, @APELLIDO, @NOMBRE, @EMAIL, @NOMBRE_USUARIO, @CALLE, @ALTURA, @TELEFONO, @CARRERA, @DEBE_CAMBIAR_PASS, @INSCRIPCION_FECHA, @PASSWORD, @PROMEDIO);";
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = query;
                    sqlCommand.Parameters.AddWithValue("@DNI", this.Dni);
                    sqlCommand.Parameters.AddWithValue("@APELLIDO", this.Apellido);
                    sqlCommand.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    sqlCommand.Parameters.AddWithValue("@EMAIL", this.EMail);
                    sqlCommand.Parameters.AddWithValue("@NOMBRE_USUARIO", this.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@CALLE", this.Calle);
                    sqlCommand.Parameters.AddWithValue("@ALTURA", this.Altura);
                    sqlCommand.Parameters.AddWithValue("@TELEFONO", this.Telefono);
                    sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);
                    sqlCommand.Parameters.AddWithValue("@DEBE_CAMBIAR_PASS", this.DebeCambiarPassword);
                    sqlCommand.Parameters.AddWithValue("@INSCRIPCION_FECHA", this.Inscripcion.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@PASSWORD", this.Password);
                    sqlCommand.Parameters.AddWithValue("@PROMEDIO", this.Promedio);

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    result = true;

                }
                catch (Exception)
                {

                    result = false;
                    return result;
                    throw;

                }
                finally
                {
                    BDConexion.conexion.Close();
                    
                }
                
            }
            return result;
        }

        public bool EliminarDeBD()
        {
            return false;
        }

        public bool ActualizarEnBD()
        {
            
            bool result = false;    
            try
            {
                string query = "UPDATE ESTUDIANTE SET DNI = @DNI , APELLIDO = @APELLIDO, NOMBRE = @NOMBRE, EMAIL = @EMAIL, NOMBRE_USUARIO = @NOMBRE_USUARIO, CALLE = @CALLE, ALTURA = @ALTURA, TELEFONO = @TELEFONO, CARRERA = @CARRERA, DEBE_CAMBIAR_PASS = @DEBE_CAMBIAR_PASS, INSCRIPCION_FECHA = @INSCRIPCION_FECHA, PASSWORD = @PASSWORD WHERE LEGAJO = @LEGAJO, PROMEDIO = @PROMEDIO;";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;

                sqlCommand.Parameters.AddWithValue("@DNI", this.Dni);
                sqlCommand.Parameters.AddWithValue("@APELLIDO", this.Apellido);
                sqlCommand.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                sqlCommand.Parameters.AddWithValue("@EMAIL", this.EMail);
                sqlCommand.Parameters.AddWithValue("@NOMBRE_USUARIO", this.NombreUsuario);
                sqlCommand.Parameters.AddWithValue("@CALLE", this.Calle);
                sqlCommand.Parameters.AddWithValue("@ALTURA", this.Altura);
                sqlCommand.Parameters.AddWithValue("@TELEFONO", this.Telefono);
                sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);
                sqlCommand.Parameters.AddWithValue("@DEBE_CAMBIAR_PASS", this.DebeCambiarPassword);
                sqlCommand.Parameters.AddWithValue("@INSCRIPCION_FECHA", this.Inscripcion.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@PASSWORD", this.Password);
                sqlCommand.Parameters.AddWithValue("@PROMEDIO", this.Promedio);

                sqlCommand.Parameters.AddWithValue("@LEGAJO", (int)this.Legajo);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                result = true;

            }
            catch (Exception)
            {

                result = false;
                return result;
                throw;

            }
            finally
            {
                BDConexion.conexion.Close();

            }
            return result;
        }

        //ENVIA UN CORREO ELECTRONICO AL ESTUDIANTE REGISTRADO (?)
        public bool EnviarCorreoElectronico()
        {
            return true;
        }
    }


}
