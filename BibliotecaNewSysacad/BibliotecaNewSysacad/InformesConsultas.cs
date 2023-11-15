using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using iText;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace BibliotecaNewSysacad
{

    public static class InformesConsultas
    {
        static InformesConsultas() { }

        public static int CantidadInscriptos(DateTime date1, DateTime date2, string query)
        {
            int cantidad = 0;

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                var resultadoQuery = sqlCommand.ExecuteScalar();
                if (resultadoQuery != null)
                {
                    cantidad += (int)sqlCommand.ExecuteScalar();
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

            return cantidad;
        }

        public static int CantidadInscriptos(Curso curso, string query)
        {
            int cantidad = 0;
            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CURSO", curso.Codigo);

                var resultadoQuery = sqlCommand.ExecuteScalar();
                if (resultadoQuery is not DBNull)
                {
                    cantidad += (int)sqlCommand.ExecuteScalar();
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
            return cantidad;
        }


        public static DataTable InscriptosPeriodo(DateTime date1, DateTime date2, string query)
        {
            DataTable dt = new DataTable();

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);

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

            return dt;
        }

        public static DataTable InscriptosCurso(Curso curso, string query)
        {
            DataTable dt = new DataTable();

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CURSO", curso.Codigo);
                

                SqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);

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

            return dt;
        }

        public static decimal SumaMonto(DateTime date1, DateTime date2, string categoria, string query)
        {
            decimal monto = 0;

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CONCEPTO", categoria);
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                var resultadoQuery = sqlCommand.ExecuteScalar();
                if (resultadoQuery is not DBNull)
                {
                    monto += (decimal)sqlCommand.ExecuteScalar();
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

            return monto;
        }

        public static decimal SumaMonto(DateTime date1, DateTime date2, string query)
        {
            decimal monto = 0;

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                var resultadoQuery = sqlCommand.ExecuteScalar();
                if (resultadoQuery is not DBNull)
                {
                    monto += (decimal)sqlCommand.ExecuteScalar();
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

            return monto;
        }

        public static DataTable ObtenerPagos(DateTime date1, DateTime date2, string query)
        {
            DataTable dt = new DataTable();

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);

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

            return dt;
        }

        public static DataTable ObtenerPagos(DateTime date1, DateTime date2, string categoria, string query)
        {
            DataTable dt = new DataTable();

            try
            {
                BDConexion.conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = BDConexion.conexion;
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@CONCEPTO", categoria);
                sqlCommand.Parameters.AddWithValue("@DATE1", date1);
                sqlCommand.Parameters.AddWithValue("@DATE2", date2);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);

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

            return dt;
        }

        // GENERA EL PDF--------------------------------------------------------------------
        public static iText.Layout.Document CrearPdf(PdfDocument pdf, string titulo, string cuerpo)
        {
            var doc = new iText.Layout.Document(pdf, iText.Kernel.Geom.PageSize.A4);
            doc.SetMargins(25, 50, 50, 25);

            Paragraph p0 =
                       new Paragraph(titulo)
                                .SetFontSize(20)
                                .SetMargins(0, 0, 0, 0)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                                .SetTextAlignment(TextAlignment.CENTER);

            doc.Add(p0);

            Paragraph p1 =
                       new Paragraph(cuerpo)
                                .SetFontSize(12)
                                .SetMargins(50, 50, 0, 50)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                .SetTextAlignment(TextAlignment.JUSTIFIED);

            doc.Add(p1);

            return doc;
        }

        
    }
}
