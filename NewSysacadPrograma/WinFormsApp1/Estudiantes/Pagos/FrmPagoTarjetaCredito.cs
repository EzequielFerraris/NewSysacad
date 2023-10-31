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
        public FrmPagoTarjetaCredito()
        {
            InitializeComponent();
        }
        public string Tarjeta
        {
            get => txbNumeroTarjeta.Text;
            set => txbNumeroTarjeta.Text = string.Empty;
        }
        public string Mes
        {
            get => txbVencimientoMes.Text;
            set => txbVencimientoMes.Text = string.Empty;
        }
        public string Anio
        {
            get => txbVencimientoAnio.Text;
            set => txbVencimientoAnio.Text = string.Empty;
        }
        public string CodigoSeguridad
        {
            get => txbCodigoSeg.Text;
            set => txbCodigoSeg.Text = string.Empty;
        }
        public string Email
        {
            get => txbMail.Text;
            set => txbMail.Text = string.Empty;
        }
        public string Calle
        {
            get => txbCalle.Text;
            set => txbCalle.Text = string.Empty;
        }
        public string Altura
        {
            get => txbAltura.Text;
            set => txbAltura.Text = string.Empty;
        }
        public string Documento
        {
            get => txbDni.Text;
            set => txbDni.Text = string.Empty;
        }
        public string Titular
        {
            get => txbTitular.Text;
            set => txbTitular.Text = string.Empty;
        }
    }
}
