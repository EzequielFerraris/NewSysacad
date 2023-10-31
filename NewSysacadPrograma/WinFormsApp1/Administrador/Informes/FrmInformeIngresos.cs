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
using System.Linq;

namespace NewSysacadFront
{
    public partial class FrmInformeIngresos : Form
    {
        private Administrador admin;



        public FrmInformeIngresos(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;

            dtimerInicio.MinDate = new DateTime(2000, 1, 1);
            dtimerInicio.MaxDate = DateTime.Now;

            dtimerFinal.MinDate = new DateTime(2000, 1, 1);
            dtimerFinal.MaxDate = DateTime.Now;

            List<string> concepto = new List<string>();
            foreach (Pago item in admin.ObtenerPagosRealizados())
            {
                concepto.Add(item.Concepto);
            }
            concepto.Add("Ingresos totales");
            List<string> conceptoFiltrado = concepto.Distinct().ToList();

            cbxCursos.DataSource = conceptoFiltrado;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere crear este informe?";
            string titulo = "Generar reporte";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                DateTime inicio = dtimerInicio.Value.Date;
                DateTime final = dtimerFinal.Value.Date;

                if (DateTime.Compare(inicio, final) > 0)
                {
                    string error = "La fecha de inicio es posterior a la de finalización";
                    string titulo1 = "Generar reporte";
                    MessageBox.Show(error, titulo1);
                }
                else
                {
                    FrmReporteIngresos ingresos = new FrmReporteIngresos();
                    ingresos.Show();
                }
            }
            
        }
    }
}
