using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaNewSysacad
{
    public class Notificacion : CRUDInterfase<Notificacion>
    {
        private int id;
        private string titulo;
        private string cuerpo;
        private Carrera carrera;
      
        private DateTime fechaCreacion;
        private int codigo;

        public Notificacion() 
        {
            this.id = 0;
            this.titulo = string.Empty;
            this.cuerpo = string.Empty;
            this.carrera = Carrera.NINGUNA;
            this.fechaCreacion = DateTime.Now;
            this.codigo = 0;
        }

        public Notificacion(int id, string titulo, string cuerpo, Carrera carrera, DateTime fechaCreacion, int codigo)
        {
            this.Id = id;
            this.titulo = titulo;
            this.cuerpo = cuerpo;
            this.carrera = carrera;
            this.fechaCreacion = fechaCreacion;
            this.codigo = codigo;
        }

        public string Titulo
        {
            get => titulo;
            set
            {
                if (Validaciones.ValidarDescripcion(value))
                {
                    titulo = value;
                }
            }
        }
        public string Cuerpo
        {
            get => cuerpo;
            set
            {
                if (Validaciones.ValidarDescripcion(value))
                {
                    cuerpo = value;
                }
            }
        }

        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Id { get => id; set => id = value; }

        public Carrera Carrera { get => carrera; set => carrera = value; }

        public bool ActualizarEnBD()
        {
            throw new NotImplementedException();
        }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value >= 0 && value < 100000)
                {
                    codigo = value;
                }
            }
        }

        public bool AgregarABD(out string error)
        {
            bool result = false;
            error = "";
            string queryAgregarCurso = "INSERT INTO NOTIFICACIONES VALUES (@TITULO, @CUERPO, @FECHA_CREACION, @CARRERA, @CODIGO);";

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryAgregarCurso;

                sqlCommand.Parameters.AddWithValue("@TITULO", this.Titulo);
                sqlCommand.Parameters.AddWithValue("@CUERPO", this.Cuerpo);
                sqlCommand.Parameters.AddWithValue("@FECHA_CREACION", this.FechaCreacion.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);
                sqlCommand.Parameters.AddWithValue("@CODIGO", (int)this.Codigo);


                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                result = true;

            }
            catch (Exception)
            {
                error = "Error en la base de datos. Intentelo más tarde.";
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

        public bool EliminarDeBD()
        {
            throw new NotImplementedException();
        }
    }
}
