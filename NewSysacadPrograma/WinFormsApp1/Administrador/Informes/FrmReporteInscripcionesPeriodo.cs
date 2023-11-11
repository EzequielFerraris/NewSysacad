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
    public partial class FrmReporteInscripcionesPeriodo : Form
    {
        public FrmReporteInscripcionesPeriodo(Administrador admin, DateTime inicio, DateTime fin)
        {
            InitializeComponent();

            int inscriptos = admin.ObtenerNumeroInscripcionesPeriodo(inicio, fin);
            int estTotales = 100;

            this.lblFechaInicio.Text = inicio.ToShortDateString();
            this.lblFechaFinal.Text = fin.ToShortDateString();

            this.lblCantidadInscriptos.Text = inscriptos.ToString();
            this.lblPorcentaje.Text = (((decimal)inscriptos / (decimal)estTotales)).ToString() + "%";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
