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
    public partial class FrmPagosRealizados : Form
    {
        private Estudiante estudiante;
        public List<FrmPagoRealizadoIndividual> pagosEnLista;
        
        public FrmPagosRealizados(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            pagosEnLista = new List<FrmPagoRealizadoIndividual>();
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            pagosEnLista.Clear();
            pnlListaPagosRealizados.Controls.Clear();

            ActualizarListaLocal();

            foreach (FrmPagoRealizadoIndividual cardPago in pagosEnLista)
            {
                cardPago.TopLevel = false;
                pnlListaPagosRealizados.Controls.Add(cardPago);
                cardPago.Dock = DockStyle.Top;
                cardPago.Show();
            }
        }

        private void ActualizarListaLocal()
        {
            foreach (Pago pago in NewSysacad.ListaPagosRealizados)
            {
                FrmPagoRealizadoIndividual cardPago = new FrmPagoRealizadoIndividual(pago, this);
                pagosEnLista.Add(cardPago);
            }
        }
    }
}
