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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewSysacadFront
{
    public partial class FrmPagosPendientes : Form
    {
        public List<FrmPagoPendiente> pagosEnLista;
        public List<Pago> pagosSeleccionados;
        private Estudiante usuario;
        public FrmPagosPendientes(Estudiante usuario)
        {
            InitializeComponent();
            pagosEnLista = new List<FrmPagoPendiente>();
            pagosSeleccionados = new List<Pago>();
            this.usuario = usuario;
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            pagosEnLista.Clear();
            pagosSeleccionados.Clear();
            pnlListaPagosPendientes.Controls.Clear();

            ActualizarListaLocal();

            foreach (FrmPagoPendiente cardPago in pagosEnLista)
            {
                cardPago.TopLevel = false;
                pnlListaPagosPendientes.Controls.Add(cardPago);
                cardPago.Dock = DockStyle.Top;
                cardPago.Show();
            }
        }

        private void ActualizarListaLocal()
        {
            foreach (Pago pagoPendiente in usuario.ObtenerPagosPendientes())
            {
                bool condicion1 = true;
                foreach (Pago pagoRealizado in usuario.ObtenerPagosRealizados())
                {
                    if(pagoPendiente.Codigo == pagoRealizado.Codigo && pagoRealizado.LegajoDelEstudiante == usuario.Legajo)
                    {
                        condicion1 = false;
                        break;
                    }

                }
                if(condicion1)
                {
                    FrmPagoPendiente cardPago = new FrmPagoPendiente(pagoPendiente, this);
                    pagosEnLista.Add(cardPago);
                }
            }
        }

        public void ActualizarSeleccion()
        {

            if (pagosSeleccionados.Count() > 0)
            {
                btnPagar.Enabled = true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }

        public bool AgregarQuitarSelecccion(Pago pago, string accion)
        {
            foreach (Pago item in pagosSeleccionados)
            {
                if (pago.Concepto == item.Concepto && pago.Codigo == item.Codigo)
                {
                    if (accion == "agregar")
                    {
                        return false;
                    }
                    else
                    {
                        pagosSeleccionados.Remove(pago);
                        return true;
                    }
                }
            }
            if (accion == "agregar")
            {
                pagosSeleccionados.Add(pago);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmRealizarPago nuevoPago = new FrmRealizarPago(pagosSeleccionados, usuario, this);
            nuevoPago.Show();
        }
    }
}
