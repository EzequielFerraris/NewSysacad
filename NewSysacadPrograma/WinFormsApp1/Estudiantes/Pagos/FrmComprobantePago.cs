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
        private Estudiante estudiante;
        public FrmComprobantePago(Pago pagoRealizado, Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            lblConcepto.Text = pagoRealizado.Concepto;
            lblMonto.Text = pagoRealizado.Monto.ToString();
            lblTransaccion.Text = pagoRealizado.NumeroTransaccion;
            lblFormaDePago.Text = pagoRealizado.FormaDePago.ToString();
            lblFechaPago.Text = pagoRealizado.FechaAbonado.ToString("dd/MM/yyyy");
            lblTarjetaCuenta.Text = pagoRealizado.TarjetaCuenta;
            lblTitular.Text = pagoRealizado.TitularPago;
            lblCarrera.Text = Enumerables.CarreraAString(estudiante.Carrera);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
