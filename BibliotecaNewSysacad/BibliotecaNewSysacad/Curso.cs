using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaNewSysacad
{
    
    public class Curso : CRUDInterfase<Curso>
    {
        private string nombre;
        private int codigo;
        private string descripcion;
        private int cupoMaximo;
        private dia diaCursada;
        private turno turnoCursada;
        private Carrera carrera;
        private decimal promedioMinimo;
        
        private List<int> estudiantesInscriptos;
        private List<string> listaCorrelatividades;
        private List<int> listaDeEspera;

        public Curso()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.cupoMaximo = 0;
            this.codigo = 0;
            estudiantesInscriptos = new List<int>();
            this.promedioMinimo = 0;
            listaCorrelatividades = new List<string>();
            listaDeEspera = new List<int>();

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
            this.promedioMinimo = 0;

            estudiantesInscriptos = new List<int>();
            listaCorrelatividades = new List<string>();
            listaDeEspera = new List<int>();
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
            get
            {
                ActualizarLegajosInscriptos();
                return estudiantesInscriptos;
            }
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

        public decimal PromedioMinimo
        {
            get => promedioMinimo;
            set
            {
                if (value >= 0 && value <= 10)
                {
                    promedioMinimo = value;
                }
            }
        }

        public List<string> ListaCorrelatividades
        {
            get
            {
                ActualizarListaCorrelatividades();
                return listaCorrelatividades;
            }
            set => listaCorrelatividades = value;
        }
        
        public List<int> ListaDeEspera
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


        public int CantidadInscriptos()
        {
            ActualizarLegajosInscriptos();
            return estudiantesInscriptos.Count(); 
        }

        //VALIDA UN CURSO
        public bool ValidarCursoNuevo(out string campoRepetido)
        {
            NewSysacad.ActualizarLista<Curso>(NewSysacad.ActualizarCursos, NewSysacad.MapeoCurso);
            campoRepetido = "Ninguno";
            bool resultado = true;
            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                if (curso.Codigo == this.Codigo)
                {
                    campoRepetido = "Codigo";
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        public void ActualizarLegajosInscriptos()
        {

            try
            {
                BDConexion.conexion.Open();
                string queryActualizarInscriptos = "SELECT * FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CODIGO_CURSO;";


                estudiantesInscriptos.Clear();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryActualizarInscriptos;
                sqlCommand.Parameters.AddWithValue("@CODIGO_CURSO", (int)this.Codigo);

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        int legajo = Convert.ToInt32(dataReader["LEGAJO_ESTUDIANTE"]);
                        estudiantesInscriptos.Add(legajo);

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

        //CORRELATIVIDADES--------------------------------------------------------------


        public DataTable ObtenerCorrelativas()
        {
            string query = "SELECT DISTINCT CURSO.NOMBRE, NOMBRE_CARRERAS.CARRERA, CURSO.CARRERA AS 'ID CARRERA' FROM CORRELATIVIDAD JOIN CURSO ON CORRELATIVIDAD.CORRELATIVIDAD = CURSO.CODIGO JOIN NOMBRE_CARRERAS ON CURSO.CARRERA = NOMBRE_CARRERAS.ID WHERE CORRELATIVIDAD.CODIGO_CURSO = @CODIGO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", this.Codigo);

            return ConsultasBD.ObtenerDataTabla(sqlCommand);
        }

        public bool RegistrarCorrelatividad(int codigo, int correlatividad)
        {
            bool result = false;
            string query = "INSERT INTO CORRELATIVIDAD VALUES (@CODIGO, @CORRELATIVIDAD);";

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CODIGO", codigo);
                sqlCommand.Parameters.AddWithValue("@CORRELATIVIDAD", correlatividad);

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

        public bool EliminarCorrelatividad(int codigo, int correlatividad)
        {
            bool result = false;
            string query = "DELETE FROM CORRELATIVIDAD WHERE CODIGO_CURSO = @CODIGO AND CORRELATIVIDAD = @CORRELATIVIDAD;";

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CODIGO", codigo);
                sqlCommand.Parameters.AddWithValue("@CORRELATIVIDAD", correlatividad);

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

        private void ActualizarListaCorrelatividades()
        {
            List<string> result = new List<string>();

            DataTable dt = this.ObtenerCorrelativas();
            
            foreach (DataRow dr in dt.Rows) 
            {
                result.Add(dr[0].ToString());
            }

            listaCorrelatividades = result;
        }

        public bool ChequearRequisitoCorrelativas(List<string> cursosAprobadosPorEstudiante)
        {
            bool result = true;

            foreach (string curso in this.ListaCorrelatividades)
            {
                if(!cursosAprobadosPorEstudiante.Contains(curso))
                {
                    result = false;
                }
            }
            return result;
        }

        //LISTAS DE ESPERA-------------------------------------------------------
        
        private int MapeoEstudiantesEnEspera(IDataReader dataReader)
        {
            int legajo = Convert.ToInt32(dataReader["LEGAJO_ESTUDIANTE"]);

            return legajo;
        }

        
        private void ObtenerEstudiantesEnListaEspera()
        {
            string query = "SELECT LEGAJO_ESTUDIANTE FROM LISTAS_DE_ESPERA WHERE CODIGO_CURSO = @CODIGO ORDER BY FECHA_INSCRIPCION, ID;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", this.Codigo);

            ListaDeEspera = ConsultasBD.ObtenerLista(sqlCommand, MapeoEstudiantesEnEspera);
        }

        
        public bool ChequearListaEspera(int legajoEst)
        {
            bool resultado = true;
            ObtenerEstudiantesEnListaEspera();

            foreach (int legajo in ListaDeEspera)
            {
                if (legajo == legajoEst)
                {
                    resultado = false; break;
                }
            }

            return resultado;
        }
        
        public void InscribirEnListaEspera(int legajo)
        {
            try
            {
                string query = "INSERT INTO LISTAS_DE_ESPERA VALUES(@CODIGO_CURSO, @LEGAJO_ESTUDIANTE, @FECHA_INSCRIPCION);";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;

                sqlCommand.Parameters.AddWithValue("@CODIGO_CURSO", this.Codigo);
                sqlCommand.Parameters.AddWithValue("@LEGAJO_ESTUDIANTE", legajo);
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

        public int NumeroInscriptosListaEspera()
        {
            string query = "SELECT COUNT(*) FROM LISTAS_DE_ESPERA WHERE CODIGO_CURSO = @CODIGO;";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", this.codigo);

            return ConsultasBD.ObtenerCantidad(sqlCommand);

        }

        public DataTable ListaInscriptosListaEspera()
        {
            string query = "SELECT LISTAS_DE_ESPERA.FECHA_INSCRIPCION AS 'FECHA', ESTUDIANTE.LEGAJO, ESTUDIANTE.APELLIDO, ESTUDIANTE.NOMBRE FROM LISTAS_DE_ESPERA JOIN ESTUDIANTE ON LISTAS_DE_ESPERA.LEGAJO_ESTUDIANTE = ESTUDIANTE.LEGAJO WHERE CODIGO_CURSO = @CODIGO ORDER BY LISTAS_DE_ESPERA.FECHA_INSCRIPCION, LISTAS_DE_ESPERA.ID;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", this.Codigo);

            return ConsultasBD.ObtenerDataTabla(sqlCommand);
        }

        public bool EliminarEstudianteDeListaDeEspera(int legajo)
        {
            bool result = false;

            string query = "DELETE FROM LISTAS_DE_ESPERA WHERE CODIGO_CURSO = @CODIGO AND LEGAJO_ESTUDIANTE = @LEGAJO;";

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CODIGO", this.Codigo);
                sqlCommand.Parameters.AddWithValue("@LEGAJO", legajo);

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

        //BD-------------------------------------------------------------------------------
        public bool AgregarABD(out string error)
        {
            
            bool condicion = ValidarCursoNuevo(out string campoRepetido);
            bool result = false;
            error = campoRepetido;
            string queryAgregarCurso = "INSERT INTO CURSO VALUES (@CODIGO, @NOMBRE, @DESCRIPCION, @CUPO_MAXIMO, @DIA_CURSADA, @TURNO_CURSADA, @CARRERA, @PROMEDIO_MINIMO);";

            if (condicion)
            {
                try
                {
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = queryAgregarCurso;

                    sqlCommand.Parameters.AddWithValue("@CODIGO", (int)this.Codigo);
                    sqlCommand.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    sqlCommand.Parameters.AddWithValue("@DESCRIPCION", this.Descripcion);
                    sqlCommand.Parameters.AddWithValue("@CUPO_MAXIMO", (int)this.CupoMaximo);
                    sqlCommand.Parameters.AddWithValue("@DIA_CURSADA", (int)this.DiaCursada);
                    sqlCommand.Parameters.AddWithValue("@TURNO_CURSADA", (int)this.TurnoCursada);
                    sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);
                    sqlCommand.Parameters.AddWithValue("@PROMEDIO_MINIMO", (decimal)this.PromedioMinimo);

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
            bool result = false;
            
            ActualizarLegajosInscriptos();
            if(this.EstudiantesInscriptos.Count() > 0)
            {
                //HAY QUE ELIMINAR PRIMERO TODAS LAS INSCRIPCIONES
                try
                {
                    string queryEliminarInscripciones = "DELETE FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CODIGO_CURSO;";
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = queryEliminarInscripciones;

                    sqlCommand.Parameters.AddWithValue("@CODIGO_CURSO", (int)this.Codigo);
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
            //AHORA ELIMINAMOS EL CURSO
            try
            {
                string queryEliminarCurso = "DELETE FROM CURSO WHERE CODIGO = @CODIGO;";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryEliminarCurso;

                sqlCommand.Parameters.AddWithValue("@CODIGO", (int)this.Codigo);
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

        public bool ActualizarEnBD()
        {
            bool result = false;
            string queryActualizarCurso = "UPDATE CURSO SET NOMBRE = @NOMBRE, DESCRIPCION = @DESCRIPCION, CUPO_MAXIMO = @CUPO_MAXIMO, DIA_CURSADA = @DIA_CURSADA, TURNO_CURSADA = @TURNO_CURSADA, CARRERA = @CARRERA, PROMEDIO_MINIMO = @PROMEDIO_MINIMO WHERE CODIGO = @CODIGO;";
            
            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryActualizarCurso;

                sqlCommand.Parameters.AddWithValue("@CODIGO", (int)this.Codigo);
                sqlCommand.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", this.Descripcion);
                sqlCommand.Parameters.AddWithValue("@CUPO_MAXIMO", (int)this.CupoMaximo);
                sqlCommand.Parameters.AddWithValue("@DIA_CURSADA", (int)this.DiaCursada);
                sqlCommand.Parameters.AddWithValue("@TURNO_CURSADA", (int)this.TurnoCursada);
                sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);
                sqlCommand.Parameters.AddWithValue("@PROMEDIO_MINIMO", (decimal)this.PromedioMinimo);

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
    }

   
}
