using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    
    public class Pago : CRUDInterfase<Pago>
    {
        private string concepto;
        private decimal monto;
        private int codigo;
        private DateTime fechaLimite;
        private TipoDePago tipo;
        private Carrera tipoCarrera;

        private int legajoDelEstudiante;
        private string titularPago;
        private string numeroTransaccion;
        private DateTime fechaAbonado;
        private string tarjetaCuenta;
        private FormaDePago formaDePago;

        private string queryAgregarPagoRealizado = "INSERT INTO PAGOS_REALIZADOS VALUES (@CODIGO, @CONCEPTO, @MONTO, @TIPO, @FECHA_PAGO, @TITULAR_PAGO, @TRANSACCION, @TARJETA_CUENTA, @LEGAJO_ESTUDIANTE, @FECHA_LIMITE, @FORMA_DE_PAGO);";

        public Pago()
        {
            this.concepto = String.Empty;
            this.monto = 0;
            this.tipo = TipoDePago.Pendiente;
            this.fechaLimite = DateTime.Now;
            this.codigo = 0;
            titularPago = String.Empty;
            numeroTransaccion = String.Empty;
            tarjetaCuenta = String.Empty;
            this.tipoCarrera = Carrera.NINGUNA;
        }

        public Pago(string concepto, decimal monto, 
            TipoDePago tipo, DateTime fechaLimite, 
            int codigo, Carrera carrera)
        {
            this.concepto = concepto;
            this.monto = monto;
            this.tipo = tipo;
            this.fechaLimite = fechaLimite;
            this.codigo = codigo;
            titularPago = String.Empty;
            numeroTransaccion = String.Empty;
            tarjetaCuenta = String.Empty;
            this.tipoCarrera = carrera;
        }
        public string Concepto 
        { 
            get => concepto; 
            set => concepto = value; 
        }
        public decimal Monto
        {
            get => monto;
            set => monto = value;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public TipoDePago Tipo
        {
            get => tipo;
            set => tipo = value;
        }
        public string TarjetaCuenta
        {
            get => tarjetaCuenta;
            set => tarjetaCuenta = value;
        }

        public int LegajoDelEstudiante
        {
            get => legajoDelEstudiante;
            set
            {
                if (legajoDelEstudiante == default)
                { legajoDelEstudiante = value; }
            }
        }

        public FormaDePago FormaDePago
        {
            get => formaDePago;
            set => formaDePago = value;
        }
        public DateTime FechaLimite
        {
            get => fechaLimite;
            set => fechaLimite = value;
        }
        public string NumeroTransaccion
        {
            get => numeroTransaccion;
            set => numeroTransaccion = value;
        }
        public DateTime FechaAbonado
        {
            get => fechaAbonado;
            set => fechaAbonado = value;
        }
        public string TitularPago 
        { 
            get => titularPago; 
            set => titularPago = value; 
        }
        public Carrera Carrera
        {
            get => tipoCarrera;
            set => tipoCarrera = value;
        }


        public bool ActualizarEnBD()
        {
            throw new NotImplementedException();
        }

        public bool AgregarABD(out string error)
        {
            bool result = false;
            error = string.Empty;

            if(this.Tipo == TipoDePago.Realizado)
            {
                try
                {
                    BDConexion.conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = BDConexion.conexion;
                    sqlCommand.CommandText = queryAgregarPagoRealizado;

                    sqlCommand.Parameters.AddWithValue("@CODIGO", (int)this.Codigo);
                    sqlCommand.Parameters.AddWithValue("@CONCEPTO", this.Concepto);
                    sqlCommand.Parameters.AddWithValue("@MONTO", (int)this.Monto);
                    sqlCommand.Parameters.AddWithValue("@TIPO", (int)this.Tipo);
                    sqlCommand.Parameters.AddWithValue("@FECHA_PAGO", this.FechaAbonado.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@TITULAR_PAGO", this.TitularPago);
                    sqlCommand.Parameters.AddWithValue("@TRANSACCION", this.NumeroTransaccion);
                    sqlCommand.Parameters.AddWithValue("@TARJETA_CUENTA", this.TarjetaCuenta);
                    sqlCommand.Parameters.AddWithValue("@LEGAJO_ESTUDIANTE", (int)this.LegajoDelEstudiante);
                    sqlCommand.Parameters.AddWithValue("@FECHA_LIMITE", this.FechaLimite.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@FORMA_DE_PAGO", (int)this.FormaDePago);
                    sqlCommand.Parameters.AddWithValue("@CARRERA", (int)this.Carrera);

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
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
            throw new NotImplementedException();
        }
    }
}
