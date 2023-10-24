using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    
    public class Pago
    {
        private string concepto;
        private decimal monto;
        private int codigo;
        private DateTime fechaLimite;
        private TipoDePago tipo;

        private int legajoDelEstudiante;

        private string titularPago;
        private FormaDePago formaDePago;
        private string numeroTransaccion;
        private DateTime fechaAbonado;
        private string tarjetaCuenta;

        public Pago(string concepto, decimal monto, TipoDePago tipo, DateTime fechaLimite, int codigo)
        {
            this.concepto = concepto;
            this.monto = monto;
            this.tipo = tipo;
            this.fechaLimite = fechaLimite;
            this.codigo = codigo;
            
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
        
    }
}
