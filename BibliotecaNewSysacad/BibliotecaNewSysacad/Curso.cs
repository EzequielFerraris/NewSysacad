using System;
using System.Collections.Generic;
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
        
        private string queryAgregarCurso = "INSERT INTO CURSO VALUES (@CODIGO, @NOMBRE, @DESCRIPCION, @CUPO_MAXIMO, @DIA_CURSADA, @TURNO_CURSADA, @CARRERA);";
        private string queryActualizarCurso = "UPDATE CURSO SET NOMBRE = @NOMBRE, DESCRIPCION = @DESCRIPCION, CUPO_MAXIMO = @CUPO_MAXIMO, DIA_CURSADA = @DIA_CURSADA, TURNO_CURSADA = @TURNO_CURSADA, CARRERA = @CARRERA WHERE CODIGO = @CODIGO;";
        private string queryEliminarCurso = "DELETE FROM CURSO WHERE CODIGO = @CODIGO;";
        private string queryEliminarInscripciones = "DELETE FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CODIGO_CURSO;";

        private string queryActualizarInscriptos = "SELECT * FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CODIGO_CURSO;";
        private string queryActualizarListaEspera;
        
        private List<int> estudiantesInscriptos;
        private Queue<int> listaDeEspera;

        public Curso()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.cupoMaximo = 0;
            this.codigo = 0;
            estudiantesInscriptos = new List<int>();
            listaDeEspera = new Queue<int>();

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
            estudiantesInscriptos = new List<int>();
            listaDeEspera = new Queue<int>();
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

        public Queue<int> ListaDeEspera
        {
            get => listaDeEspera;
            set => listaDeEspera = value;
        }

        //ACTUALIZAR LISTA DE INSCRIPTOS


        //ACTUALIZAR LISTA DE ESPERA


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

        //INSCRIPCION EN LA LISTA DE ESPERA
        public bool InscribirEstudianteEnListaDeEspera(Estudiante estudianteNuevo, out string error)
        {
            bool resultado = true;
            error = "";

            foreach (int legajo in listaDeEspera)
            {
                if (legajo == estudianteNuevo.Legajo)
                {
                    error = "Usuario ya inscripto.";
                    resultado = false;
                    break;
                }  
            }
            if (resultado)
            {
                listaDeEspera.Enqueue(estudianteNuevo.Legajo);
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


        //BD-------------------------------------------------------------------------------
        public bool AgregarABD(out string error)
        {
            
            bool condicion = ValidarCursoNuevo(out string campoRepetido);
            bool result = false;
            error = campoRepetido;

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
