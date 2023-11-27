using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Profesor : Persona, CRUDInterfase<Profesor>
    {
        private int legajo;
        private string dni;
        private string telefono;
        private string calle;
        private string altura;
        private string area;

        private List<int> cursosAsignados;

        public Profesor() 
        {
            
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.eMail = string.Empty;
            this.dni = string.Empty;
            this.telefono = string.Empty;
            this.calle = string.Empty;
            this.altura = string.Empty;
            this.Area = string.Empty;

            this.password = string.Empty;
            this.nombreUsuario = string.Empty;

            cursosAsignados = new List<int>();
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

        public string Dni
        {
            get => dni;
            set
            {
                if (Validaciones.ValidarNumero(value, 7, 9))
                {
                    dni = value;
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

        public List<int> CursosAsignados 
        { 
            get
            {
                cursosAsignados = ObtenerCursosAsignados();
                return cursosAsignados;
            }

            set => cursosAsignados = value; 
        }
        public string Area 
        {
            get => area;
            set
            {
                if (Validaciones.ValidarDescripcion(value))
                {
                    area = value;
                }
            }
        }

        // CURSOS ASIGNADOS----------------------------------------------------------------------


        private List<int> ObtenerCursosAsignados()
        {
            string query = "SELECT CODIGO_CURSO FROM CURSOS_ASIGNADOS WHERE LEGAJO_PROFE = @LEGAJO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@LEGAJO", this.Legajo);

            return ConsultasBD.ObtenerLista<int>(sqlCommand, MapeoCodigosCursosAsignados);
        }

        private int MapeoCodigosCursosAsignados(IDataReader dataReader)
        {
            int mailUtilizado = (int)dataReader["CODIGO_CURSO"];

            return mailUtilizado;
        }

        private List<Curso> ObtenerCursosAsignadosCompletos()
        {
            List<Curso> cursosAsignados = new List<Curso>();

            foreach (int codigCurso in ObtenerCursosAsignados())
            {
                foreach (Curso c in NewSysacad.ListaCursos)
                {
                    if(c.Codigo == codigCurso)
                    {
                        cursosAsignados.Add(c);
                        break;
                    }
                }
            }

            return cursosAsignados;
        }

        //CHEQUEAR MAILS DUPLICADOS--------------------------------------------------------------

        public bool ChequearMailsDuplicados(string mail)
        {
            bool result = true;

            List<string> listaMails = ObtenerMailsProfesores();

            if(listaMails.Contains(mail))
            {
                result = false;
            }

            return result;
        }

        public List<string> ObtenerMailsProfesores()
        {
            string query = "SELECT EMAIL FROM PROFESORES;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@EMAIL", this.EMail);

            return ConsultasBD.ObtenerLista<string>(sqlCommand, MapeoMailsProfesores);
        }

        private string MapeoMailsProfesores(IDataReader dataReader)
        {
            string mailUtilizado = dataReader["EMAIL"].ToString();

            return mailUtilizado;
        }

        //DISPONIBILIDAD HORARIA --------------------------------------------------------------------
        public bool ChequearDisponibilidadHoraria(int codigoCurso)
        {
            bool result = true;

            Curso cursoAChequear = new Curso();

            foreach (Curso c in NewSysacad.ListaCursos)
            {
                if(c.Codigo == codigoCurso)
                {
                    cursoAChequear = c;
                    break;
                }
            }

            if (cursoAChequear.Codigo != 0)
            {
                List<Curso> cursosAsignados = ObtenerCursosAsignadosCompletos();

                foreach (Curso cursoAsignado in cursosAsignados)
                {
                    if(cursoAsignado.DiaCursada == cursoAChequear.DiaCursada && cursoAsignado.TurnoCursada == cursoAChequear.TurnoCursada)
                    {
                        result = false;
                        break;
                    }

                }
            }
            else
            { 
                result = false; 
            }

            return result;
        }


        //LISTA DE CURSOS ASIGNADOS-------------------------------------------------------------
        public void ActualizarCursosAsignados()
        {

            try
            {
                BDConexion.conexion.Open();
                string queryActualizarInscriptos = "SELECT * FROM CURSOS_ASIGNADOS WHERE LEGAJO_PROFE = @LEGAJO;";

                cursosAsignados.Clear();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryActualizarInscriptos;
                sqlCommand.Parameters.AddWithValue("@LEGAJO", (int)this.Legajo);

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        int codigoCurso = Convert.ToInt32(dataReader["CODIGO_CURSO"]);
                        cursosAsignados.Add(codigoCurso);

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

        public bool AsignarCurso(int codigo)
        {
            bool result = false;

            try
            {
                string query = "INSERT INTO CURSOS_ASIGNADOS VALUES (@LEGAJO, @CODIGO);";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@LEGAJO", (int)this.Legajo);
                sqlCommand.Parameters.AddWithValue("@CODIGO", codigo);

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


        //BD--------------------------------------------------------------------------------------

        private bool ValidarParaAgregar(out string campoRepetido)
            {
            campoRepetido = "Ninguno";
            bool resultado = true;
            

            foreach (Profesor profe in NewSysacad.ListaProfesores)
            {
                if (profe.Dni == this.Dni)
                {
                    campoRepetido = "DNI";
                    resultado = false;
                    break;
                }
                else if (profe.EMail == this.EMail)
                {
                    campoRepetido = "E-Mail";
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }
        

        public bool ActualizarEnBD()
        {
            bool result = false;
            try
            {
                string query = "UPDATE PROFESORES SET DNI = @DNI, APELLIDO = @APELLIDO, NOMBRE = @NOMBRE, EMAIL = @EMAIL, NOMBRE_USUARIO = @NOMBRE_USUARIO, CALLE = @CALLE, ALTURA = @ALTURA, TELEFONO = @TELEFONO, PASSWORD = @PASSWORD, AREA = @AREA WHERE LEGAJO = @LEGAJO;";
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
                sqlCommand.Parameters.AddWithValue("@PASSWORD", this.Password);
                sqlCommand.Parameters.AddWithValue("@AREA", this.Area);

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

        public bool AgregarABD(out string error)
        {
            bool condicion = ValidarParaAgregar(out string error1);
            bool result = false;
            error = error1;

            if (condicion)
            {
                try
                {
                    string query = "INSERT INTO PROFESORES VALUES (@DNI, @APELLIDO, @NOMBRE, @EMAIL, @NOMBRE_USUARIO, @CALLE, @ALTURA, @TELEFONO, @PASSWORD, @AREA);";
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
                    sqlCommand.Parameters.AddWithValue("@PASSWORD", this.Password);
                    sqlCommand.Parameters.AddWithValue("@AREA", this.Area);


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
            bool result = false;

            ActualizarCursosAsignados();

            if (this.CursosAsignados.Count() > 0)
            {
                //HAY QUE ELIMINAR PRIMERO TODAS LAS ASIGNACIONES DE CURSOS
                try
                {
                    string queryEliminarAsignaciones = "DELETE FROM CURSOS_ASIGNADOS WHERE LEGAJO_PROFE = @LEGAJO;";
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = queryEliminarAsignaciones;

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
            }
            //AHORA ELIMINAMOS EL PROFE
            try
            {
                string queryEliminarProfe = "DELETE FROM PROFESORES WHERE LEGAJO = @LEGAJO;";
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryEliminarProfe;

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

        

    }
}
