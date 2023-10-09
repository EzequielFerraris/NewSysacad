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
    public enum datoDelSistema
    { 
        estudiante,
        administrador,
        curso,
        pagoPendiente,
        pagoRealizado
    }
    public static class NewSysacad
    {
        public static int numeroDeLegajo = 1;

        private static List<Estudiante> listaEstudiantes; 
        private static List<Administrador> listaAdministradores;
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
                                                                 "1533556677", false);
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

        public static List<Curso> ListaCursos
        {
            get => listaCursos;
        }

        public static List<Pago> ListaPagosPendientes
        {
            get => listaPagosPendientes;
        }

        public static List<Pago> ListaPagosRealizados
        {
            get => listaPagosRealizados;
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
        
        //VALIDACION DE ESTUDIANTES
        private static bool ValidarEstudianteNuevo(Estudiante estudianteNuevo, out string campoRepetido) 
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            foreach (Estudiante estudiante in listaEstudiantes)
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
         
        //AGREGA UN ESTUDIANTE Y LE ASIGNA UN NÚMERO DE LEGAJO. AUMENTA EL NÚMERO DE LEGAJO 
        public static bool AgregarEstudiante(Estudiante estudianteNuevo, out string error)
        {

            bool condicion = ValidarEstudianteNuevo(estudianteNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                estudianteNuevo.Legajo += numeroDeLegajo;
                numeroDeLegajo++;
                listaEstudiantes.Add(estudianteNuevo);
                EscribirJSON(dataBaseEstudiantesNombreArchivo, datoDelSistema.estudiante);
                EnviarCorreoElectronico(estudianteNuevo);
                return true; 
            }
            return false;
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
        private static void EscribirJSON(string file, datoDelSistema tipo)
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

        //LEE LOS ARCHIVOS
        private static List<T> LeerJSON<T>(string file)
        {
            var path = Combinar(file);

            var nuevaLista = new List<T>();

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

            return nuevaLista;
        }
       
        //CURSOS---------------------------------------------------------------
        //VALIDA UN CURSO
        private static bool ValidarCursoNuevo(Curso cursoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            foreach (Curso curso in listaCursos)
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
        public static bool AgregarCurso(Curso cursoNuevo, out string error)
        {
            bool resultado = false;
            bool condicion = ValidarCursoNuevo(cursoNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                listaCursos.Add(cursoNuevo);
                EscribirJSON(dataBaseCursosNombreArchivo, datoDelSistema.curso);
                resultado = true;
            }
            return resultado;
        }

        //ACTUALIZA UN CURSO YA EXISTENTE CON NUEVOS INSCRIPTOS
        public static bool ActualizarCurso(Curso cursoNuevo)
        {
            bool resultado = false;
            foreach (Curso c in listaCursos)
            {
                if (c.Nombre == cursoNuevo.Nombre && c.Codigo == cursoNuevo.Codigo)
                {
                    listaCursos.Remove(c);
                    listaCursos.Add(cursoNuevo);
                    EscribirJSON(dataBaseCursosNombreArchivo, datoDelSistema.curso);
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        //ELIMINAR UN CURSO
        public static bool EliminarCurso(Curso cursoAEliminar, out string error)
        {
            bool resultado = false;
            error = "Curso no encontrado";
            foreach (var curso in listaCursos)
            {
                if((cursoAEliminar.Nombre == curso.Nombre) && (cursoAEliminar.Codigo == curso.Codigo))
                { 
                    listaCursos.Remove(curso);
                    EscribirJSON(dataBaseCursosNombreArchivo, datoDelSistema.curso);
                    resultado = true;
                    error = String.Empty;
                    break;
                }
            }
            return resultado;
        }



        //ESTUDIANTES-------------------------------------------------------------------
        //ENVIA UN CORREO ELECTRONICO AL ESTUDIANTE REGISTRADO (?)
        private static bool EnviarCorreoElectronico(Estudiante estudianteRegistrado)
        {
            return true;
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

        //OBTENER ESTUDIANTE
        public static Estudiante ObtenerEstudiante(string nombreDeUsuario)
        {
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if(nombreDeUsuario == estudiante.NombreUsuario)
                {
                    return estudiante;
                }
            }
            return null;
        }

        //PAGOS--------------------------------------------------------------------------
        //VALIDA UN PAGO NUEVO
        private static bool ValidarRegistroPagoNuevo(Pago pagoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            if (listaPagosPendientes.Count() > 0)
            {
                foreach (Pago pago in listaPagosPendientes)
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

        public static bool AgregarPago(Pago pagoNuevo, out string error)
        {
            bool resultado = false;
            bool condicion = ValidarRegistroPagoNuevo(pagoNuevo, out string campoRepetido);
            error = campoRepetido;
            if (condicion)
            {
                listaPagosPendientes.Add(pagoNuevo);
                EscribirJSON(dataBasePagosPendientes, datoDelSistema.pagoPendiente);
                resultado = true;
            }
            return resultado;
        }

        //PAGOS REALIZADOS
        //VALIDA

        public static bool ValidarPagoRealizadoNuevo(Pago pagoNuevo, out string campoRepetido)
        {
            campoRepetido = "Ninguno";
            bool resultado = true;
            if (listaPagosRealizados.Count() > 0)
            {
                foreach (Pago pago in listaPagosRealizados)
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
        //REGISTRA PAGO REALIZADO
        public static void RegistrarPagoRealizado(Pago pagoNuevo)
        {
            listaPagosRealizados.Add(pagoNuevo);
            EscribirJSON(dataBasePagosRealizados, datoDelSistema.pagoRealizado);
        }


    }

}
