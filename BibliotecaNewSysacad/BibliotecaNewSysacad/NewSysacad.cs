using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Data.Common;

namespace BibliotecaNewSysacad
{ 
    public static class NewSysacad
    {
        private static List<Administrador> listaAdministradores;
        private static List<Estudiante> listaEstudiantes;
        private static List<Curso> listaCursos;
        private static List<Pago> listaPagosPendientes;
        private static List<Pago> listaPagosRealizados;
        private static List<Notificacion> listaNotificaciones;
        private static List<Profesor> listaProfesores;

        private static string actualizarEstudiantes = "SELECT * FROM ESTUDIANTE;";
        private static string actualizarAdministrador = "SELECT * FROM ADMINISTRADOR;";
        private static string actualizarCursos = "SELECT * FROM CURSO;";
        private static string actualizarPagosPendientes = "SELECT * FROM PAGO_PENDIENTE;";
        private static string actualizarPagosRealizados = "SELECT * FROM PAGOS_REALIZADOS;";
        private static string actualizarNotificaciones = "SELECT * FROM NOTIFICACIONES;";
        private static string actualizarProfesores = "SELECT * FROM PROFESORES;";
        static NewSysacad() 
        {
            //LISTAS MANEJADAS POR EL SISTEMA
            
            listaEstudiantes = ActualizarLista<Estudiante>(actualizarEstudiantes, MapeoEstudiante);
            listaAdministradores = ActualizarLista<Administrador>(actualizarAdministrador, MapeoAdministrador);
            listaCursos = ActualizarLista<Curso>(actualizarCursos, MapeoCurso);
            listaPagosPendientes = ActualizarLista<Pago>(actualizarPagosPendientes, MapeoPagosPendientes);
            listaPagosRealizados = ActualizarLista<Pago>(actualizarPagosRealizados, MapeoPagosRealizados);
            listaNotificaciones = ActualizarLista<Notificacion>(actualizarNotificaciones, MapeoNotificaciones);
            listaProfesores = ActualizarLista<Profesor>(actualizarProfesores, MapeoProfesor);

        }

        //GETTERS

        public static List<Pago> ListaPagosRealizados
        {
            get
            {
                listaPagosRealizados = ActualizarLista<Pago>(actualizarPagosRealizados, MapeoPagosRealizados);
                return listaPagosRealizados;
            }
            set => listaPagosRealizados = value;
        }

        public static List<Estudiante> ListaEstudiantes
        {
            get {
                listaEstudiantes = ActualizarLista<Estudiante>(actualizarEstudiantes, MapeoEstudiante);
                return listaEstudiantes;
                }
            set => listaEstudiantes = value;
        }

        public static List<Curso> ListaCursos
        {
            get
            {
                listaCursos = ActualizarLista<Curso>(actualizarCursos, MapeoCurso);
                return listaCursos;
            }
            set => listaCursos = value;
        }

        public static List<Pago> ListaPagosPendientes
        {
            get
            {
                listaPagosPendientes = ActualizarLista<Pago>(actualizarPagosPendientes, MapeoPagosPendientes);
                return listaPagosPendientes;
            }
            set => listaPagosPendientes = value;
        }

        public static List<Notificacion> ListaNotificaciones
        {
            get
            {
                listaNotificaciones = ActualizarLista<Notificacion>(actualizarNotificaciones, MapeoNotificaciones);
                return listaNotificaciones;
            }
            set => listaNotificaciones = value;
        }

        public static List<Profesor> ListaProfesores
        {
            get
            {
                listaProfesores = ActualizarLista<Profesor>(actualizarProfesores, MapeoProfesor);
                return listaProfesores;
            }
            set => listaProfesores = value;
        }

        public static string ActualizarEstudiantes
        {
            get => actualizarEstudiantes;
        }

        public static string ActualizarCursos
        {
            get => actualizarCursos;
        }

        

        //BD-------------------------------------------------------------------------------

        //LECTURA GENÉRICA DESDE LA BD
        public static List<T> ActualizarLista<T>(string query, Func<IDataReader, T> funcionMapeo)
        {
            List<T> lista = new List<T>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = query;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        T item = funcionMapeo(dataReader);
                        lista.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                BDConexion.conexion.Close();
            }
            return lista;
        }

        //MAPPERS--------------------------------------------------------------------------
        public static Estudiante MapeoEstudiante(IDataReader dataReader)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = dataReader["NOMBRE"].ToString();
            estudiante.Apellido = dataReader["APELLIDO"].ToString();
            estudiante.NombreUsuario = dataReader["NOMBRE_USUARIO"].ToString();
            estudiante.EMail = dataReader["EMAIL"].ToString();
            estudiante.Password = dataReader["PASSWORD"].ToString();
            estudiante.Dni = dataReader["DNI"].ToString();
            estudiante.Calle = dataReader["CALLE"].ToString();
            estudiante.Altura = dataReader["ALTURA"].ToString();
            estudiante.Telefono = dataReader["TELEFONO"].ToString();
            estudiante.DebeCambiarPassword = Convert.ToBoolean(dataReader["DEBE_CAMBIAR_PASS"]);
            estudiante.Inscripcion = Convert.ToDateTime(dataReader["INSCRIPCION_FECHA"]);
            estudiante.Carrera = (Carrera)Convert.ToInt32(dataReader["CARRERA"]);
            estudiante.Legajo = Convert.ToInt32(dataReader["LEGAJO"]);
            estudiante.Promedio = Convert.ToDecimal(dataReader["PROMEDIO"]);

            return estudiante;
        }

        public static Administrador MapeoAdministrador(IDataReader dataReader)
        {
            Administrador admin = new Administrador();
            admin.Nombre = dataReader["NOMBRE"].ToString();
            admin.Apellido = dataReader["APELLIDO"].ToString();
            admin.NombreUsuario = dataReader["NOMBRE_USUARIO"].ToString();
            admin.EMail = dataReader["EMAIL"].ToString();
            admin.Password = dataReader["PASSWORD"].ToString();

            return admin;
        }

        public static Curso MapeoCurso(IDataReader dataReader)
        {
            Curso curso = new Curso();
            curso.Nombre = dataReader["NOMBRE"].ToString();
            curso.Descripcion = dataReader["DESCRIPCION"].ToString();
            curso.CupoMaximo = Convert.ToInt32(dataReader["CUPO_MAXIMO"]);
            curso.Codigo = Convert.ToInt32(dataReader["CODIGO"]);
            curso.DiaCursada = (dia)Convert.ToInt32(dataReader["DIA_CURSADA"]);
            curso.TurnoCursada = (turno)Convert.ToInt32(dataReader["TURNO_CURSADA"]);
            curso.Carrera = (Carrera)Convert.ToInt32(dataReader["CARRERA"]);
            curso.PromedioMinimo = Convert.ToDecimal(dataReader["PROMEDIO_MINIMO"]);

            return curso;
        }

        public static Pago MapeoPagosPendientes(IDataReader dataReader)
        {
            Pago pago = new Pago();
            pago.Codigo = (int)dataReader["Codigo"];
            pago.Concepto = dataReader["CONCEPTO"].ToString();
            pago.Monto = Convert.ToDecimal(dataReader["MONTO"]);
            pago.Tipo = (TipoDePago)Convert.ToInt32(dataReader["TIPO"]);
            pago.FechaLimite = Convert.ToDateTime(dataReader["FECHA_LIMITE"]);

            return pago;
        }

        public static Pago MapeoPagosRealizados(IDataReader dataReader)
        {
            Pago pago = new Pago();
            pago.Codigo = (int)dataReader["Codigo"];
            pago.Concepto = dataReader["CONCEPTO"].ToString();
            pago.Monto = Convert.ToDecimal(dataReader["MONTO"]);
            pago.Tipo = (TipoDePago)Convert.ToInt32(dataReader["TIPO"]);
            pago.FechaAbonado = Convert.ToDateTime(dataReader["FECHA_PAGO"]);
            pago.TitularPago = dataReader["TITULAR_PAGO"].ToString();
            pago.NumeroTransaccion = dataReader["TRANSACCION"].ToString();
            pago.TarjetaCuenta = dataReader["TARJETA_CUENTA"].ToString();
            pago.LegajoDelEstudiante = Convert.ToInt32(dataReader["LEGAJO_ESTUDIANTE"]);
            pago.FechaLimite = Convert.ToDateTime(dataReader["FECHA_LIMITE"]);
            pago.FormaDePago = (FormaDePago)Convert.ToInt32(dataReader["FORMA_DE_PAGO"]);


            return pago;
        }

        public static Notificacion MapeoNotificaciones(IDataReader dataReader)
        {
            Notificacion notificacion = new Notificacion();
            notificacion.Id = (int)dataReader["ID"];
            notificacion.Titulo = dataReader["TITULO"].ToString();
            notificacion.Cuerpo = dataReader["CUERPO"].ToString();
            notificacion.FechaCreacion = Convert.ToDateTime(dataReader["FECHA_CREACION"]);
            notificacion.Carrera = (Carrera)Convert.ToInt32(dataReader["CARRERA"]);
            notificacion.Codigo = (int)dataReader["CODIGO"];

            return notificacion;
        }

        public static Profesor MapeoProfesor(IDataReader dataReader)
        {
            Profesor profe = new Profesor();
            profe.Legajo = Convert.ToInt32(dataReader["LEGAJO"]);
            profe.Nombre = dataReader["NOMBRE"].ToString();
            profe.Apellido = dataReader["APELLIDO"].ToString();
            profe.NombreUsuario = dataReader["NOMBRE_USUARIO"].ToString();
            profe.EMail = dataReader["EMAIL"].ToString();
            profe.Password = dataReader["PASSWORD"].ToString();
            profe.Dni = dataReader["DNI"].ToString();
            profe.Calle = dataReader["CALLE"].ToString();
            profe.Altura = dataReader["ALTURA"].ToString();
            profe.Telefono = dataReader["TELEFONO"].ToString();
            profe.Area = dataReader["AREA"].ToString();

            return profe;
        }

        //ADMINISTRADOR--------------------------------------------------------------------
        //LOGGEO DEL ADMINISTRADOR
        public static bool LoginAdministrador(string nombreDeUsuario, string password)
        {
            bool result = false;
            foreach (Administrador admin in listaAdministradores)
            {
                
                if (nombreDeUsuario == admin.NombreUsuario && BCrypt.Net.BCrypt.EnhancedVerify(password, admin.Password))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //BUSCA UN ADMINISTRADOR POR EL NOMBRE DE USUARIO
        public static Administrador ObtenerEstudianteAdministrador(string nombreDeUsuario)
        {
            Administrador resultado = new Administrador();

            foreach (Administrador admin in listaAdministradores)
            {
                if (nombreDeUsuario == admin.NombreUsuario)
                {
                    resultado = admin;
                }
            }
            return resultado;
        }
   

    //ESTUDIANTES-------------------------------------------------------------------

    //LOGGEO DEL ESTUDIANTE
    public static bool LoginEstudiante(string nombreDeUsuario, string password)
        {
            bool result = false;
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (nombreDeUsuario == estudiante.NombreUsuario && BCrypt.Net.BCrypt.EnhancedVerify(password, estudiante.Password))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //OBTENER ESTUDIANTE CON EL NOMBRE DE USUARIO
        public static Estudiante ObtenerEstudiante(string nombreDeUsuario)
        {
            Estudiante resultado = new Estudiante();

            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (nombreDeUsuario == estudiante.NombreUsuario)
                {
                    resultado = estudiante;
                    break;
                }
            }
            return resultado;
        }

        public static Estudiante ObtenerEstudiante(int legajo)
        {
            Estudiante resultado = new Estudiante();

            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (legajo == estudiante.Legajo)
                {
                    resultado = estudiante;
                    break;
                }
            }
            return resultado;
        }


        //-------------------------------------------------------------------------


    }

}
