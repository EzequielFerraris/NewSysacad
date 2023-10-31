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

    public partial class FrmPagoTransferencia : Form
    {
        public FrmPagoTransferencia()
        {
            InitializeComponent();
        }

        public string Titular
        {
            get => txbTitular.Text;
            set => txbTitular.Text = string.Empty;
        }
        public string Cuenta
        {
            get => txbNroCuenta.Text;
            set => txbNroCuenta.Text = string.Empty;
        }
        public string Transaccion
        {
            get => txbTransaccion.Text;
            set => txbTransaccion.Text = string.Empty;
        }
    }
}
