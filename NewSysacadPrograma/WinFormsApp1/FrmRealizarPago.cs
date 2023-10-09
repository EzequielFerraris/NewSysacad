using BibliotecaNewSysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSysacadFront
{
    public partial class FrmRealizarPago : Form
    {
        private List<Pago> pagosARealizar;
        private FrmPagoTarjetaDebito pagoTarjetaDebito;
        private FrmPagoTarjetaCredito pagoTarjetaCredito;
        private FrmPagoTransferencia pagoTransferencia;
        private FrmPagosPendientes pagosListados;
        private Estudiante usuario;
        private string concepto = string.Empty;
        private string codigos = string.Empty;
        private decimal monto = 0;
        public FrmRealizarPago(List<Pago> pagos, Estudiante usuario, FrmPagosPendientes pagosListados)
        {
            InitializeComponent();
            pagosARealizar = pagos;
            this.usuario = usuario;
            this.pagosListados = pagosListados;

            foreach (Pago pago in pagosARealizar)
            {
                concepto += pago.Concepto + "\n";
                codigos += pago.Codigo + "\n";
                monto += pago.Monto;
            }

            lblConcepto.Text = concepto;
            lblCodigo.Text = codigos;
            lblMonto.Text = monto.ToString();

            cbxFormaPago.DataSource = Enum.GetValues(typeof(FormaDePago));

            pagoTarjetaCredito = new FrmPagoTarjetaCredito();
            pagoTarjetaCredito.TopLevel = false;
            pnlDatosPago.Controls.Add(pagoTarjetaCredito);
            pagoTarjetaCredito.Hide();

            pagoTarjetaDebito = new FrmPagoTarjetaDebito();
            pagoTarjetaDebito.TopLevel = false;
            pnlDatosPago.Controls.Add(pagoTarjetaDebito);
            pagoTarjetaDebito.Hide();

            pagoTransferencia = new FrmPagoTransferencia();
            pagoTransferencia.TopLevel = false;
            pnlDatosPago.Controls.Add(pagoTransferencia);
            pagoTransferencia.Hide();

            cbxFormaPago.SelectedIndex = 2;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere realizar este pago?";
            string titulo = "Confirmar pago";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                bool datosValidados = true;
                //
                //VALIDACIONES
                if (cbxFormaPago.SelectedIndex == 0)
                {
                    if (!Validaciones.ValidarNombreYApellido(pagoTarjetaCredito.Titular))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Titular = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTarjetaCredito.Tarjeta, 16, 16))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Tarjeta = "";
                    }
                    if(!Validaciones.ValidarMesTarjeta(pagoTarjetaCredito.Mes))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Mes = "";
                    }
                    if (!Validaciones.ValidarAnioTarjeta(pagoTarjetaCredito.Anio))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Anio = "";
                    }
                    if(!Validaciones.ValidarNumero(pagoTarjetaCredito.CodigoSeguridad, 3, 3))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.CodigoSeguridad = "";
                    }
                    if (!Validaciones.ValidarMail(pagoTarjetaCredito.Email))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Email = "";
                    }
                    if (!Validaciones.ValidarCalle(pagoTarjetaCredito.Calle))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Calle = "";
                    }
                    if (!Validaciones.ValidarAltura(pagoTarjetaCredito.Altura))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Altura = "";
                    }
                    if(!Validaciones.ValidarNumero(pagoTarjetaCredito.Documento, 7, 9))
                    {
                        datosValidados = false;
                        pagoTarjetaCredito.Documento = "";
                    }

                }
                else if (cbxFormaPago.SelectedIndex == 1)
                {
                    if (!Validaciones.ValidarNombreYApellido(pagoTarjetaDebito.Titular))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Titular = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTarjetaDebito.Tarjeta, 16, 16))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Tarjeta = "";
                    }
                    if (!Validaciones.ValidarMesTarjeta(pagoTarjetaDebito.Mes))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Mes = "";
                    }
                    if (!Validaciones.ValidarAnioTarjeta(pagoTarjetaDebito.Anio))    
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Anio = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTarjetaDebito.CodigoSeguridad, 3, 3))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.CodigoSeguridad = "";
                    }
                    if (!Validaciones.ValidarMail(pagoTarjetaDebito.Email))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Email = "";
                    }
                    if (!Validaciones.ValidarCalle(pagoTarjetaDebito.Calle))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Calle = "";
                    }
                    if (!Validaciones.ValidarAltura(pagoTarjetaDebito.Altura))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Altura = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTarjetaDebito.Documento, 7, 9))
                    {
                        datosValidados = false;
                        pagoTarjetaDebito.Documento = "";
                    }
                }
                else if (cbxFormaPago.SelectedIndex == 2)
                {
                    if (!Validaciones.ValidarNombreYApellido(pagoTransferencia.Titular)) 
                    {
                        datosValidados = false;
                        pagoTransferencia.Titular = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTransferencia.Transaccion, 8, 20))
                    {

                        datosValidados = false;
                        pagoTransferencia.Transaccion = "";
                    }
                    if (!Validaciones.ValidarNumero(pagoTransferencia.Cuenta, 16, 16))
                    {
                        datosValidados = false;
                        pagoTransferencia.Cuenta = "";
                    }
                }
                //
                if(datosValidados)
                {
                    List<Pago> nuevosPagos = new List<Pago>();
                    bool condicion1 = true;

                    foreach (Pago pagoEnProceso in pagosARealizar)
                    {
                        Random random = new Random(); //PARA SIMULAR UNA TRANSACCION
                        Pago pagoRealizado = new Pago(pagoEnProceso.Concepto, pagoEnProceso.Monto, TipoDePago.Realizado, pagoEnProceso.FechaLimite, pagoEnProceso.Codigo);
                        pagoRealizado.LegajoDelEstudiante = usuario.Legajo;
                        pagoRealizado.FechaAbonado = DateTime.Now;
                        pagoRealizado.FormaDePago = (FormaDePago)cbxFormaPago.SelectedValue;

                        if (cbxFormaPago.SelectedIndex == 0)
                        {
                            pagoRealizado.TarjetaCuenta = pagoTarjetaCredito.Tarjeta;
                            pagoRealizado.NumeroTransaccion = random.Next(999999999).ToString();
                            pagoRealizado.TitularPago = pagoTarjetaCredito.Titular;
                        }
                        else if (cbxFormaPago.SelectedIndex == 1)
                        {
                            pagoRealizado.NumeroTransaccion = random.Next(999999999).ToString();
                            pagoRealizado.TarjetaCuenta = pagoTarjetaDebito.Tarjeta;
                            pagoRealizado.TitularPago = pagoTarjetaDebito.Titular;
                        }
                        else if (cbxFormaPago.SelectedIndex == 2)
                        {
                            pagoRealizado.NumeroTransaccion = pagoTransferencia.Transaccion;
                            pagoRealizado.TarjetaCuenta = pagoTransferencia.Cuenta;
                            pagoRealizado.TitularPago = pagoTransferencia.Titular;
                        }

                        condicion1 = NewSysacad.ValidarPagoRealizadoNuevo(pagoRealizado, out string errorRegistro);

                        if (!condicion1)
                        {
                            string mensaje2 = "Error. Uno de los cursos ya ha sido abonado.";
                            string titulo2 = "Pagar curso";
                            DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                            break;
                        }
                        nuevosPagos.Add(pagoRealizado);
                    }

                    if (condicion1)
                    {
                        foreach (Pago pagoChequeado in nuevosPagos)
                        {
                            NewSysacad.RegistrarPagoRealizado(pagoChequeado);
                        }

                        string mensaje1 = "Pago realizado correctamente.";
                        string titulo1 = "Abonar pago";
                        DialogResult result1 = MessageBox.Show(mensaje1, titulo1);

                        this.Close();
                    }
                    pagosListados.ActualizarLista();
                }
                else
                {
                    string mensaje3 = "Dato incorrecto. Inténtelo nuevamente";
                    string titulo3 = "Pagar curso";
                    DialogResult result2 = MessageBox.Show(mensaje3, titulo3);
                    
                }
                
            }
        }

        private void cbxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFormaPago.SelectedIndex == 0)
            {
                pagoTarjetaDebito.Hide();
                pagoTransferencia.Hide();
                pagoTarjetaCredito.Show();

            }
            else if (cbxFormaPago.SelectedIndex == 1)
            {
                pagoTransferencia.Hide();
                pagoTarjetaCredito.Hide();
                pagoTarjetaDebito.Show();
            }
            else if (cbxFormaPago.SelectedIndex == 2)
            {
                pagoTarjetaCredito.Hide();
                pagoTarjetaDebito.Hide();
                pagoTransferencia.Show();
            }


        }
    }
}
