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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NewSysacadFront
{
    public partial class FrmPagoRealizadoIndividual : Form
    {
        private Pago pagoRealizado;
        private FrmPagosRealizados formularioPadre;
        public FrmPagoRealizadoIndividual(Pago pago, FrmPagosRealizados lista1)
        {
            InitializeComponent();
            pagoRealizado = pago;
            lblConcepto.Text = pagoRealizado.Concepto;
            lblCodigo.Text = pagoRealizado.Codigo.ToString();
            lblMonto.Text = pagoRealizado.Monto.ToString();
            lblVencimiento.Text = pagoRealizado.FechaLimite.ToString("dd/MM/yyyy");
            this.formularioPadre = lista1;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            FrmComprobantePago comprobante = new FrmComprobantePago(pagoRealizado);
            comprobante.Show();
        }
    }
}
