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

        //RECIBE UN COMMAND Y DEVUELVE UNA SUMA DE CASOS ENTEROS
        public static int ObtenerCantidad(SqlCommand sqlCommand)
        {
            int cantidad = 0;
            try
            {
                BDConexion.conexion.Open();

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

        //RECIBE UN COMMAND Y DEVUELVE EL MATERIAL PARA UNA TABLA
        public static DataTable ObtenerDataTabla(SqlCommand sqlCommand)
        {
            DataTable dt = new DataTable();

            try
            {
                BDConexion.conexion.Open();
                
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

        //RECIBE UN COMMAND Y DEVUELVE UNA SUMA DE MONTOS EN TIPO DECIMAL

        public static decimal SumaMonto(SqlCommand sqlCommand)
        {
            decimal monto = 0;

            try
            {
                BDConexion.conexion.Open();
                
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
        
    }
}
