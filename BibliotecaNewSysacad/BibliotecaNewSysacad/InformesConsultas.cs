using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace BibliotecaNewSysacad
{

    public static class InformesConsultas
    {

        

        static InformesConsultas() { }


        public static int CantidadInscriptosPeriodo(DateTime date1, DateTime date2)
        {
            int cantidad = 0;

            string queryPeriodo = "SELECT COUNT(*) FROM ESTUDIANTE WHERE INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2";

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = queryPeriodo;
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                cantidad += (int)sqlCommand.ExecuteScalar();

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

            return cantidad;
        }


        public static void CrearPDF(string titulo, string subtitulo, string cuerpo)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            QuestPDF.Fluent.Document.Create(container =>
            {

            }).ShowInPreviewer();
            
        }
    }
}
