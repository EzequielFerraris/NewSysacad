using System;
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
        private bool recibirNotificaciones;
        private bool recibirMail;

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
            this.recibirMail = false;
            this.recibirNotificaciones = true;

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
        public bool RecibirNotificaciones { get => recibirNotificaciones; set => recibirNotificaciones = value; }
        public bool RecibirMail { get => recibirMail; set => recibirMail = value; }


        //ACCIONES DE ESTUDIANTE CON CURSOS--------------------------------------------------------------------------------------------
        //LISTA DE CURSOS
        public List<Curso> ObtenerCursosVisibles()
        {
            List<Curso> cursosVisibles = new List<Curso>();


            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                List<string> aprobados = ObtenerNombresCursosAprobados();
                if(!aprobados.Contains(curso.Nombre))
                {
                    if (this.Carrera == Carrera.TUSI)
                    {
                        if (curso.Carrera == this.Carrera || curso.Carrera == Carrera.TUP)
                        {
                            cursosVisibles.Add(curso);
                        }
                    }
                    else if (this.Carrera == curso.Carrera)
                    {
                        cursosVisibles.Add(curso);
                    }
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

        //NOTIFICACIONES-----------------------------------------------------------

        public List<Notificacion> ObtenerNotificaciones()
        {

            List<Notificacion> resultado = new List<Notificacion>();

            if(this.RecibirNotificaciones)
            {
                foreach (var item in NewSysacad.ListaNotificaciones)
                {
                    if (item.Carrera == this.Carrera)
                    {
                        resultado.Add(item);
                    }
                }
                
            }
            return resultado;

        }

        private int MapeoNotificacionesLeidas(IDataReader dataReader)
        {
            
            int notificacionLeida = (int)dataReader["ID_NOTIFICACION"];
           
            return notificacionLeida;
        }

        public List<int> ObtenerNotificacionesLeidas()
        {
            string query = "SELECT ID_NOTIFICACION FROM NOTIFICACIONES_LEIDAS WHERE LEGAJO_ALUMNO = @LEGAJO ORDER BY ID_NOTIFICACION;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@LEGAJO", this.Legajo);

            return ConsultasBD.ObtenerLista<int>(sqlCommand, MapeoNotificacionesLeidas);
        }

        public void RegistrarLecturaNotificacion(Notificacion notificacionMarcada)
        {
            List<int> leidas = ObtenerNotificacionesLeidas();

            if(!leidas.Contains(notificacionMarcada.Id))
            {
                try
                {
                    string query = "INSERT INTO NOTIFICACIONES_LEIDAS VALUES (@ID_NOTIFICACION, @LEGAJO_ALUMNO);";
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = query;
                    sqlCommand.Parameters.AddWithValue("@ID_NOTIFICACION", notificacionMarcada.Id);
                    sqlCommand.Parameters.AddWithValue("@LEGAJO_ALUMNO", this.Legajo);
                   

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

        }


        //BD---------------------------------------------------------------------------------------------------

        private bool ValidarParaAgregar(out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
             

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
                    string query = "INSERT INTO ESTUDIANTE VALUES (@DNI, @APELLIDO, @NOMBRE, @EMAIL, @NOMBRE_USUARIO, @CALLE, @ALTURA, @TELEFONO, @CARRERA, @DEBE_CAMBIAR_PASS, @INSCRIPCION_FECHA, @PASSWORD, @PROMEDIO, @NOTIFICACIONES, @RECIBIR_MAIL);";
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
                    sqlCommand.Parameters.AddWithValue("@NOTIFICACIONES", this.RecibirNotificaciones);
                    sqlCommand.Parameters.AddWithValue("@RECIBIR_MAIL", this.RecibirMail);

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    result = true;

                }
                catch (Exception)
                {

                    result = false;
                    return result;
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
                string query = "UPDATE ESTUDIANTE SET DNI = @DNI , APELLIDO = @APELLIDO, NOMBRE = @NOMBRE, EMAIL = @EMAIL, NOMBRE_USUARIO = @NOMBRE_USUARIO, CALLE = @CALLE, ALTURA = @ALTURA, TELEFONO = @TELEFONO, CARRERA = @CARRERA, DEBE_CAMBIAR_PASS = @DEBE_CAMBIAR_PASS, INSCRIPCION_FECHA = @INSCRIPCION_FECHA, PASSWORD = @PASSWORD, PROMEDIO = @PROMEDIO, NOTIFICACIONES = @NOTIFICACIONES, RECIBIR_MAIL = @RECIBIR_MAIL WHERE LEGAJO = @LEGAJO;";
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
                sqlCommand.Parameters.AddWithValue("@NOTIFICACIONES", this.RecibirNotificaciones);
                sqlCommand.Parameters.AddWithValue("@RECIBIR_MAIL", this.RecibirMail);

                sqlCommand.Parameters.AddWithValue("@LEGAJO", (int)this.Legajo);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                result = true;

            }
            catch (Exception)
            {

                result = false;
                return result;

            }
            finally
            {
                BDConexion.conexion.Close();

            }
            return result;
        }

        //ENVIA UN CORREO ELECTRONICO AL ESTUDIANTE REGISTRADO (?)
        public void EnviarCorreoRegistro()
        {
            string mensaje = $"Estimado/a {this.Nombre}:\n\nSe ha registrado su inscripción en la UTNFRA.\n";
            mensaje += $"Para ingresar en el sistema de alumnos su nombre de usuario es {NombreUsuario} y su contraseña será su DNI la primera vez que ingrese.";
            mensaje += " Luego se le pedirá modificarla\n";
            mensaje += "En caso de no reconocer esta actividad, envíe un mail a newsysacad@gmail.com.\n\n";
            mensaje += "UTN Facultad Regional Avellaneda.";
            EmailAdm.EnviarEmail(this.EMail, "Inscripción NewSysacad", mensaje);
        }

        public void EnviarCorreoNotificacion(Notificacion notificacion)
        {
            string titulo = notificacion.Titulo;
            string mensaje = notificacion.Cuerpo;

            EmailAdm.EnviarEmail(this.EMail, titulo, mensaje);
        }

    }


}
