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
    public partial class FrmInformeInscripcionesPorPeriodo : Form
    {
        public FrmInformeInscripcionesPorPeriodo()
        {
            InitializeComponent();
            dtimerInicio.MinDate = new DateTime(2000, 1, 1);
            dtimerInicio.MaxDate = DateTime.Now;

            dtimerFinal.MinDate = new DateTime(2000, 1, 1);
            dtimerFinal.MaxDate = DateTime.Now;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere crear este informe?";
            string titulo = "Generar reporte";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                bool condicion1 = false;
                string error1 = "El año de comparación es incorrecto. Ingrese un año entre 2000 y la fecha actual.";
                string titulo1 = "Generar reporte";


                if (!int.TryParse(txbAnioComparacion.Text, out int number))
                {
                    txbAnioComparacion.Text = "";
                    MessageBox.Show(error1, titulo1); 
                }
                else 
                {
                    condicion1 = number >= 2000 && number <= 2023;
                    if (!condicion1)
                    {
                        MessageBox.Show(error1, titulo1);
                    }
                    else
                    {
                        DateTime inicio = dtimerInicio.Value.Date;
                        DateTime final = dtimerFinal.Value.Date;

                        if (DateTime.Compare(inicio, final) > 0)
                        {
                            string error2 = "La fecha de inicio es posterior a la de finalización";
                            MessageBox.Show(error2, titulo1);
                        }
                        else
                        {
                            //ACA VA LA LOGICA
                            FrmReporteInscripcionesPeriodo informe = new FrmReporteInscripcionesPeriodo();
                            informe.Show();
                        }
                    }
                }
                
            }

        }
    }
}
