﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Collections;

namespace BibliotecaNewSysacad
{
    public class Administrador : Persona
    {
        
        public Administrador() { }

        //OBTENER LISTAS DEL SISTEMA

        public List<Estudiante> ListaEstudiantes()
        {
            return NewSysacad.ListaEstudiantes;
        }
        public List<Curso> ObtenerCursos()
        {
            return NewSysacad.ListaCursos;
        }

        public List<Pago> ObtenerPagosPendientes()
        {
            return NewSysacad.ListaPagosPendientes;
        }

        public List<Pago> ObtenerPagosRealizados ()
        {
            return NewSysacad.ListaPagosRealizados;
        }

        //INFORMES
        //INSCRIPCIONES POR PERIODO------------------------------------------------
        public int ObtenerNumeroInscripcionesPeriodo(DateTime date1, DateTime date2)
        {
            string query = "SELECT COUNT(*) FROM ESTUDIANTE WHERE INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2;";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerCantidad(sqlCommand);
        }

        public DataTable CompletarListaInscripcionesPeriodo(DateTime date1, DateTime date2)
        {
            string query = "SELECT INSCRIPCION_FECHA AS 'FECHA', LEGAJO, APELLIDO, NOMBRE FROM ESTUDIANTE WHERE INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }

        // INSCRIPCIONES POR CURSO --------------------------------------------------------------
        public int ObtenerNumeroInscripcionesCurso(Curso curso)
        {
            string query = "SELECT COUNT(*) FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CURSO;";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CURSO", curso.Codigo);

            return InformesConsultas.ObtenerCantidad(sqlCommand);
        }

        public DataTable CompletarListaInscripcionesCurso(Curso curso)
        {
            string query = "SELECT ESTUDIANTE.LEGAJO, ESTUDIANTE.APELLIDO, ESTUDIANTE.NOMBRE FROM ESTUDIANTES_CURSOS_INSCRIPTOS JOIN ESTUDIANTE ON ESTUDIANTES_CURSOS_INSCRIPTOS.LEGAJO_ESTUDIANTE = ESTUDIANTE.LEGAJO WHERE CODIGO_CURSO = @CURSO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CURSO", curso.Codigo);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }

        //INGRESOS-----------------------------------------------------------------
        public decimal ObtenerSumaMonto(DateTime date1, DateTime date2, string categoria)
        {
            string query = "SELECT SUM(MONTO) FROM PAGOS_REALIZADOS WHERE CONCEPTO = @CONCEPTO AND FECHA_PAGO BETWEEN @DATE1 AND @DATE2";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CONCEPTO", categoria);
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.SumaMonto(sqlCommand);
        }

        public decimal ObtenerSumaMontoTotal(DateTime date1, DateTime date2)
        {
            string query = "SELECT SUM(MONTO) FROM PAGOS_REALIZADOS WHERE FECHA_PAGO BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.SumaMonto(sqlCommand);
        }
        
        public DataTable ObtenerPagosPeriodo(DateTime date1, DateTime date2)
        {
            string query = "SELECT FECHA_PAGO AS 'FECHA DE PAGO', CODIGO, CONCEPTO, MONTO, TITULAR_PAGO AS 'TITULAR', TRANSACCION, LEGAJO_ESTUDIANTE AS 'LEGAJO' FROM PAGOS_REALIZADOS WHERE FECHA_PAGO BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }

        public DataTable ObtenerPagosPorCategoria(DateTime date1, DateTime date2, string categoria)
        {
            string query = "SELECT FECHA_PAGO AS 'FECHA DE PAGO', CODIGO, CONCEPTO, MONTO, TITULAR_PAGO AS 'TITULAR', TRANSACCION, LEGAJO_ESTUDIANTE AS 'LEGAJO' FROM PAGOS_REALIZADOS WHERE CONCEPTO = @CONCEPTO AND FECHA_PAGO BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CONCEPTO", categoria);
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }

        public int ObtenerNumeroInscripcionesCarrera(Carrera carrera)
        {
            string query = "SELECT COUNT(*) FROM ESTUDIANTE WHERE CARRERA = @CARRERA;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CARRERA", (int)carrera);

            return InformesConsultas.ObtenerCantidad(sqlCommand);
        }


        public int ObtenerInscripcionesCarreraPeriodo(DateTime date1, DateTime date2, Carrera carrera)
        {
            string query = "SELECT COUNT(*) FROM ESTUDIANTE WHERE CARRERA = @CARRERA AND INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CARRERA", (int)carrera);
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerCantidad(sqlCommand);
        }


            public DataTable ListaInscriptosCarreraPeriodo(DateTime date1, DateTime date2, Carrera carrera)
        {
            string query = "SELECT ESTUDIANTE.INSCRIPCION_FECHA, ESTUDIANTE.LEGAJO, ESTUDIANTE.APELLIDO, ESTUDIANTE.NOMBRE FROM ESTUDIANTE WHERE CARRERA = @CARRERA AND INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CARRERA", (int)carrera);
            sqlCommand.Parameters.AddWithValue("@DATE1", date1);
            sqlCommand.Parameters.AddWithValue("@DATE2", date2);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }
        // LISTA DE ESPERA ---------------------------------------------------------------------
        public int InscriptosListaEspera(int codigo)
        {
            string query = "SELECT COUNT(*) FROM LISTAS_DE_ESPERA WHERE CODIGO_CURSO = @CODIGO;";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", codigo);

            return InformesConsultas.ObtenerCantidad(sqlCommand);

        }

        public DataTable ListaInscriptosListaEspera(int codigo)
        {
            string query = "SELECT LISTAS_DE_ESPERA.FECHA_INSCRIPCION AS 'FECHA', ESTUDIANTE.LEGAJO, ESTUDIANTE.APELLIDO, ESTUDIANTE.NOMBRE FROM LISTAS_DE_ESPERA JOIN ESTUDIANTE ON LISTAS_DE_ESPERA.LEGAJO_ESTUDIANTE = ESTUDIANTE.LEGAJO WHERE CODIGO_CURSO = @CODIGO;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = BDConexion.conexion;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@CODIGO", codigo);

            return InformesConsultas.ObtenerDataTabla(sqlCommand);
        }
        

    }

}

