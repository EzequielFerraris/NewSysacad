using BibliotecaNewSysacad;
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
    public partial class FrmComprobantePago : Form
    {
        public FrmComprobantePago(Pago pagoRealizado)
        {
            InitializeComponent();
            lblConcepto.Text = pagoRealizado.Concepto;
            lblMonto.Text = pagoRealizado.Monto.ToString();
            lblTransaccion.Text = pagoRealizado.NumeroTransaccion.ToString();
            lblFormaDePago.Text = pagoRealizado.FormaDePago.ToString();
            lblFechaPago.Text = pagoRealizado.FechaAbonado.ToString("dd/MM/yyyy");
            lblTarjetaCuenta.Text = pagoRealizado.FormaDePago.ToString();
            lblTitular.Text = pagoRealizado.TitularPago;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
