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

namespace BibliotecaNewSysacad
{
    
    public static class NewSysacad
    {
        public static int numeroDeLegajo = 1;

        private static List<Administrador> listaAdministradores;
        private static List<Estudiante> listaEstudiantes;
        private static List<Curso> listaCursos;
        private static List<Pago> listaPagosPendientes;
        private static List<Pago> listaPagosRealizados;
        private static string dataBaseEstudiantesNombreArchivo = "DBEstudiantes.json";
        private static string dataBaseAdministradoresNombreArchivo = "DBAdministradores.json";
        private static string dataBaseCursosNombreArchivo = "DBCursosI.json";
        private static string dataBasePagosPendientes = "DBPagosPendientes.json";
        private static string dataBasePagosRealizados = "DBPagosRealizados.json";

        static NewSysacad() 
        {
            //LISTAS MANEJADAS POR EL SISTEMA
            listaEstudiantes = new List<Estudiante>();
            listaAdministradores = new List<Administrador>();
            listaCursos = new List<Curso>();
            listaPagosPendientes = new List<Pago>();
            listaPagosRealizados = new List<Pago>();

            //CHEQUEO SI YA HAY ESTUDIANTES INGRESADOS CON ANTERIORIDAD Y ACTUALIZO LA LISTA Y EL NUMERO DE LEGAJO
            if (File.Exists(Combinar(dataBaseEstudiantesNombreArchivo)))
            {
                listaEstudiantes = LeerJSON<Estudiante>(dataBaseEstudiantesNombreArchivo);
                Estudiante ultimoLegajo = listaEstudiantes.Last();
                numeroDeLegajo = ultimoLegajo.Legajo + 1;
            }
            else
            {
                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword("1234", 13);
                Estudiante estudiantePorDefecto = new Estudiante("est1", "est1", "est1", "est1@gmail.com",
                                                                 hashedPassword, "12312312", "Siempreviva", "123",
                                                                 "1533556677", false, new DateTime(2022, 3, 5),
                                                                 Carrera.TUP, new List<string>());
                listaEstudiantes.Add(estudiantePorDefecto);
                EscribirJSON(dataBaseEstudiantesNombreArchivo, datoDelSistema.estudiante);
            }

            //CHEQUEO SI HAY ADMINISTRADORES REGISTRADOS. CASO CONTRARIO INSTANCIO UN ADMIN POR DEFECTO Y ESCRIBO EL ARCHIVO
            if (File.Exists(Combinar(dataBaseAdministradoresNombreArchivo)))
            {
                listaAdministradores = LeerJSON<Administrador>(dataBaseAdministradoresNombreArchivo);
            }
            else
            {
                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword("1234", 13);
                Administrador ad1 = new Administrador("admin", "admin", "admin", "admin@gmail.com", hashedPassword);
                listaAdministradores.Add(ad1);
                EscribirJSON(dataBaseAdministradoresNombreArchivo, datoDelSistema.administrador);
            }
            //CHEQUEO SI HAY CURSOS REGISTRADOS.
            if (File.Exists(Combinar(dataBaseCursosNombreArchivo)))
            {
                listaCursos = LeerJSON<Curso>(dataBaseCursosNombreArchivo); 
            }
            //CHEQUEO SI HAY PAGOS REGISTRADOS.
            if (File.Exists(Combinar(dataBasePagosPendientes)))
            {
                listaPagosPendientes = LeerJSON<Pago>(dataBasePagosPendientes);
            }
            else
            {
                Pago pg1 = new Pago("Cuota mensual", 23000, TipoDePago.Pendiente, new DateTime(2023, 11, 15), 102);
                Pago pg2 = new Pago("Matrícula", 50000, TipoDePago.Pendiente, new DateTime(2023, 12, 15), 212);
                listaPagosPendientes.Add(pg1);
                listaPagosPendientes.Add(pg2);
                EscribirJSON(dataBasePagosPendientes, datoDelSistema.pagoPendiente);
            }

            if (File.Exists(Combinar(dataBasePagosRealizados)))
            {
                listaPagosRealizados = LeerJSON<Pago>(dataBasePagosRealizados);
            }

        }

        //GETTERS

        public static List<Pago> ListaPagosRealizados
        {
            get => listaPagosRealizados;
            set => listaPagosRealizados = value;
        }

        public static List<Estudiante> ListaEstudiantes
        {
            get => listaEstudiantes;
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
        


    }

}
