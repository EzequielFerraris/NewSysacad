using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSysacadFront
{
    public partial class FrmPagoTarjetaCredito : Form
    {
        private string titular; 
        private int tarjeta;
        private int mes;
        private int anio;
        private int codigoSeguridad;
        private string email;
        private string calle;
        private string altura;
        private string documento;
        public FrmPagoTarjetaCredito()
        {
            InitializeComponent();
        }
        public int Tarjeta { get => Int32.Parse(txbNumeroTarjeta.Text); }
        public int Mes { get => Int32.Parse(txbVencimientoMes.Text); }
        public int Anio { get => Int32.Parse(txbVencimientoAnio.Text); }
        public int CodigoSeguridad { get => Int32.Parse(txbCodigoSeg.Text); }
        public string Email { get => txbMail.Text; }
        public string Calle { get => txbCalle.Text; }
        public int Altura { get => Int32.Parse(txbAltura.Text); }
        public string Documento { get => txbDni.Text; }
        public string Titular { get => txbTitular.Text; }
    }
}
