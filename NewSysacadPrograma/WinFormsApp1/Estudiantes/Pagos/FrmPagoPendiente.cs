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
    public partial class FrmPagoPendiente : Form
    {

        private Pago pagoPendiente;
        private FrmPagosPendientes formularioPadre;

        public FrmPagoPendiente(Pago pago, FrmPagosPendientes lista1)
        {
            InitializeComponent();
            pagoPendiente = pago;
            lblConcepto.Text = pagoPendiente.Concepto;
            lblCodigo.Text = pagoPendiente.Codigo.ToString();
            lblMonto.Text = pagoPendiente.Monto.ToString();
            lblVencimiento.Text = pagoPendiente.FechaLimite.ToString("dd/MM/yyyy");
            this.formularioPadre = lista1;  
        }

        private void chbxPago_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxPago.Checked)
            {
                formularioPadre.AgregarQuitarSelecccion(pagoPendiente, "agregar");
                formularioPadre.ActualizarSeleccion();
            }
            else
            {
                formularioPadre.AgregarQuitarSelecccion(pagoPendiente, "quitar");
                formularioPadre.ActualizarSeleccion();
            }
        }

        public Pago PagoPendiente
        {
            get => PagoPendiente;
            set => PagoPendiente = value;
        }
    }

    
}
