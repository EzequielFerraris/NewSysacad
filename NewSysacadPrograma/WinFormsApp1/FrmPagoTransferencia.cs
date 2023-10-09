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
        private string titular;
        private int cuenta;
        private int transaccion;
        public FrmPagoTransferencia()
        {
            InitializeComponent();
        }

        public string Titular { get => txbTitular.Text;}
        public int Cuenta { get => Int32.Parse(txbNroCuenta.Text);}
        public int Transaccion { get => Int32.Parse(txbTransaccion.Text); }
    }
}
