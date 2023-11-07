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

namespace BibliotecaNewSysacad
{
    
    public static class NewSysacad
    {
        private static List<Administrador> listaAdministradores;
        private static List<Estudiante> listaEstudiantes;
        private static List<Curso> listaCursos;
        private static List<Pago> listaPagosPendientes;
        private static List<Pago> listaPagosRealizados;
        private static string dataBaseEstudiantesNombreArchivo = "DBEstudiantes.json";
        private static string dataBaseCursosNombreArchivo = "DBCursos.json";
        private static string dataBasePagosPendientes = "DBPagosPendientes.json";
        private static string dataBasePagosRealizados = "DBPagosRealizados.json";
        private static string actualizarEstudiantes = "SELECT * FROM ESTUDIANTE;";
        private static string actualizarAdministrador = "SELECT * FROM ADMINISTRADOR;";
        private static string actualizarCursos = "SELECT * FROM CURSO;";
        private static string actualizarPagosPendientes = "SELECT * FROM PAGO_PENDIENTE;";
        private static string actualizarPagosRealizados = "SELECT * FROM PAGOS_REALIZADOS;";
        static NewSysacad() 
        {
            //LISTAS MANEJADAS POR EL SISTEMA
            listaEstudiantes = new List<Estudiante>();
            listaAdministradores = new List<Administrador>();
            listaCursos = new List<Curso>();
            listaPagosPendientes = new List<Pago>();
            listaPagosRealizados = new List<Pago>();

            //ACTUALIZO LISTAS
            listaEstudiantes = ActualizarListaEstudiantes();
            listaAdministradores = ActualizarListaAdministradores();
            listaCursos = ActualizarListaCursos();
            listaPagosPendientes = ActualizarListaPagosPendientes();
            listaPagosRealizados = ActualizarListaPagosRealizados();

        }

        //GETTERS

        public static List<Pago> ListaPagosRealizados
        {
            get => listaPagosRealizados;
            set => listaPagosRealizados = value;
        }

        public static List<Estudiante> ListaEstudiantes
        {
            get {
                ActualizarListaEstudiantes();
                return listaEstudiantes;
                }
            set => listaEstudiantes = value;
        }

        public static List<Curso> ListaCursos
        {
            get => listaCursos;
            set => listaCursos = value;
        }

        public static List<Pago> ListaPagosPendientes
        {
            get => listaPagosPendientes;
            set => listaPagosPendientes = value;
        }

        public static string DataBaseEstudiantesNombreArchivo
        {
            get => dataBaseEstudiantesNombreArchivo;
        }

        public static string DataBaseCursosNombreArchivo
        {
            get => dataBaseCursosNombreArchivo;
        }

        public static string DataBasePagosPendientes
        {
            get => dataBasePagosPendientes;
        }

        public static string DataBasePagosRealizados
        {
            get => dataBasePagosRealizados;
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

        //ACTUALIZAR LISTA DE ADMINISTRADORES
        public static List<Administrador> ActualizarListaAdministradores()
        {
            List<Administrador> administradores = new List<Administrador>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = actualizarAdministrador;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Administrador admin = new Administrador();
                        admin.Nombre = dataReader["NOMBRE"].ToString();
                        admin.Apellido = dataReader["APELLIDO"].ToString();
                        admin.NombreUsuario = dataReader["NOMBRE_USUARIO"].ToString();
                        admin.EMail = dataReader["EMAIL"].ToString();
                        admin.Password = dataReader["PASSWORD"].ToString();

                        administradores.Add(admin);
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
            return administradores;
        }

        //ARCHIVOS------------------------------------------------------------------------
        //GENERA EL PATH DONDE GUARDAR LOS ARCHIVOS CON DATOS DEL SISTEMA
        private static string Combinar(string file)
        {
            Environment.SpecialFolder documentos = Environment.SpecialFolder.MyDocuments;

            var documents = Environment.GetFolderPath(documentos);
            var path = Path.Combine(documents, file);
            return path;
        }

        //ESCRIBE LOS ARCHIVOS DONDE PERSISTEN LOS DATOS
        public static void EscribirJSON(string file, datoDelSistema tipo)
        {
            try
            {
                using (var writer = new StreamWriter(Combinar(file)))
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    switch (tipo)
                    {
                        case datoDelSistema.estudiante:
                            var json1 = JsonSerializer.Serialize(NewSysacad.listaEstudiantes, options);
                            writer.Write(json1);
                            break;
                        case datoDelSistema.administrador:
                            var json2 = JsonSerializer.Serialize(NewSysacad.listaAdministradores, options);
                            writer.Write(json2);
                            break;
                        case datoDelSistema.curso:
                            var json3 = JsonSerializer.Serialize(NewSysacad.listaCursos, options);
                            writer.Write(json3);
                            break;
                        case datoDelSistema.pagoPendiente:
                            var json4 = JsonSerializer.Serialize(NewSysacad.listaPagosPendientes, options);
                            writer.Write(json4);
                            break;
                        case datoDelSistema.pagoRealizado:
                            var json5 = JsonSerializer.Serialize(NewSysacad.listaPagosRealizados, options);
                            writer.Write(json5);
                            break;
                    }
                }
            }
            catch 
            { 
            
            }
            
        }

        //LEE LOS ARCHIVOS
        private static List<T> LeerJSON<T>(string file)
        {

            var path = Combinar(file);

            var nuevaLista = new List<T>();
            try
            {
                if (File.Exists(path))
                {
                    using (var reader = new StreamReader(path))
                    {
                        var json = reader.ReadToEnd();

                        var listaAux = JsonSerializer.Deserialize<List<T>>(json);

                        if (listaAux != null)
                        {
                            nuevaLista = listaAux;
                        }
                    }
                }
            }
            catch
            {

            }
            return nuevaLista;

        }

        //ESTUDIANTES-------------------------------------------------------------------

        //ACTUALIZAR LISTA DE ESTUDIANTES
        public static List<Estudiante> ActualizarListaEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = actualizarEstudiantes;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
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
                        
                        estudiantes.Add(estudiante);
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
            return estudiantes;
        }
    


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
                }
            }
            return resultado;
        }

        //ACTUALIZAR ESTUDIANTE CON NUEVO PASSWORD
        public static void ActualizarEstudiante(Estudiante estudianteActualizado)
        {
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (estudianteActualizado.NombreUsuario == estudiante.NombreUsuario && estudianteActualizado.Legajo == estudiante.Legajo)
                {
                    estudiante.Password = estudianteActualizado.Password;
                    estudiante.DebeCambiarPassword = false;
                    EscribirJSON(dataBaseEstudiantesNombreArchivo, datoDelSistema.estudiante);
                }
            }

        }

        //-------------------------------------------------------------------------

        //ACTUALIZAR LISTA DE CURSOS
        public static List<Curso> ActualizarListaCursos()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = actualizarCursos;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Curso curso = new Curso();
                        curso.Nombre = dataReader["NOMBRE"].ToString();
                        curso.Descripcion = dataReader["DESCRIPCION"].ToString();
                        curso.CupoMaximo = Convert.ToInt32(dataReader["CUPO_MAXIMO"]); 
                        curso.Codigo = Convert.ToInt32(dataReader["CODIGO"]);
                        curso.DiaCursada = (dia)Convert.ToInt32(dataReader["DIA_CURSADA"]);
                        curso.TurnoCursada = (turno)Convert.ToInt32(dataReader["TURNO_CURSADA"]);
                        curso.Carrera = (Carrera)Convert.ToInt32(dataReader["CARRERA"]);

                        cursos.Add(curso);
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
            return cursos;
        }
        //ACTUALIZAR LISTA PAGOS PENDIENTES

        public static List<Pago> ActualizarListaPagosPendientes()
        {
            List<Pago> pagosPendientes = new List<Pago>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = actualizarPagosPendientes;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Pago pago = new Pago();
                        pago.Codigo = (int)dataReader["Codigo"];
                        pago.Concepto = dataReader["CONCEPTO"].ToString();
                        pago.Monto = Convert.ToDecimal(dataReader["MONTO"]);
                        pago.Tipo = (TipoDePago)Convert.ToInt32(dataReader["TIPO"]);
                        pago.FechaLimite = Convert.ToDateTime(dataReader["FECHA_LIMITE"]);
                        
                        pagosPendientes.Add(pago);
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
            return pagosPendientes;
        }

        //ACTUALIZAR LISTA PAGOS REALIZADOS

        public static List<Pago> ActualizarListaPagosRealizados()
        {
            List<Pago> pagosRealizados = new List<Pago>();
            try
            {

                BDConexion.conexion.Open();
                BDConexion.comando.CommandText = actualizarPagosRealizados;

                using (SqlDataReader dataReader = BDConexion.comando.ExecuteReader())
                {
                    while (dataReader.Read())
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

                        pagosRealizados.Add(pago);
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
            return pagosRealizados;
        }
    }

}
