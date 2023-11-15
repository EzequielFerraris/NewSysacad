using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

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

        public int ObtenerNumeroInscripcionesPeriodo(DateTime date1, DateTime date2)
        {
            string queryPeriodo = "SELECT COUNT(*) FROM ESTUDIANTE WHERE INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.CantidadInscriptos(date1, date2, queryPeriodo);
        }

        public DataTable CompletarListaInscripcionesPeriodo(DateTime date1, DateTime date2)
        {
            string queryPeriodo = "SELECT INSCRIPCION_FECHA AS 'FECHA', LEGAJO, APELLIDO, NOMBRE FROM ESTUDIANTE WHERE INSCRIPCION_FECHA BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.InscriptosPeriodo(date1, date2, queryPeriodo);
        }

        public int ObtenerNumeroInscripcionesCurso(Curso curso)
        {
            string queryCurso = "SELECT COUNT(*) FROM ESTUDIANTES_CURSOS_INSCRIPTOS WHERE CODIGO_CURSO = @CURSO";
            return InformesConsultas.CantidadInscriptos(curso, queryCurso);
        }

        public DataTable CompletarListaInscripcionesCurso(Curso curso)
        {
            string queryCurso = "SELECT ESTUDIANTE.LEGAJO, ESTUDIANTE.APELLIDO, ESTUDIANTE.NOMBRE FROM ESTUDIANTES_CURSOS_INSCRIPTOS JOIN ESTUDIANTE ON ESTUDIANTES_CURSOS_INSCRIPTOS.LEGAJO_ESTUDIANTE = ESTUDIANTE.LEGAJO WHERE CODIGO_CURSO = @CURSO";
            return InformesConsultas.InscriptosCurso(curso, queryCurso);
        }
        public decimal ObtenerSumaMonto(DateTime date1, DateTime date2, string categoria)
        {
            string queryMonto = "SELECT SUM(MONTO) FROM PAGOS_REALIZADOS WHERE CONCEPTO = @CONCEPTO AND FECHA_PAGO BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.SumaMonto(date1, date2, categoria, queryMonto);
        }

        public decimal ObtenerSumaMontoTotal(DateTime date1, DateTime date2)
        {
            string queryMonto = "SELECT SUM(MONTO) FROM PAGOS_REALIZADOS WHERE FECHA_PAGO BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.SumaMonto(date1, date2, queryMonto);
        }
        
        public DataTable ObtenerPagosPeriodo(DateTime date1, DateTime date2)
        {
            string queryPagosPeriodo = "SELECT FECHA_PAGO AS 'FECHA DE PAGO', CODIGO, CONCEPTO, MONTO, TITULAR_PAGO AS 'TITULAR', TRANSACCION, LEGAJO_ESTUDIANTE AS 'LEGAJO' FROM PAGOS_REALIZADOS WHERE FECHA_PAGO BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.ObtenerPagos(date1, date2, queryPagosPeriodo);
        }

        public DataTable ObtenerPagosPorCategoria(DateTime date1, DateTime date2, string categoria)
        {
            string queryPagosCategoria = "SELECT FECHA_PAGO AS 'FECHA DE PAGO', CODIGO, CONCEPTO, MONTO, TITULAR_PAGO AS 'TITULAR', TRANSACCION, LEGAJO_ESTUDIANTE AS 'LEGAJO' FROM PAGOS_REALIZADOS WHERE CONCEPTO = @CONCEPTO AND FECHA_PAGO BETWEEN @DATE1 AND @DATE2";
            return InformesConsultas.ObtenerPagos(date1, date2, categoria, queryPagosCategoria);
        }
    }

}

