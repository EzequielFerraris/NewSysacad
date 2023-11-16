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
    public partial class FrmInformeInscripcionesPorCarrera : Form
    {
        private Administrador admin;
        public FrmInformeInscripcionesPorCarrera(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cbxCarrera.SelectedIndex = 0;

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
                DateTime inicio = dtimerInicio.Value.Date;
                DateTime final = dtimerFinal.Value.Date;
                Carrera carrera = (Carrera)cbxCarrera.SelectedIndex;

                if (DateTime.Compare(inicio, final) > 0)
                {
                    string error2 = "La fecha de inicio es posterior a la de finalización";
                    string titulo1 = "Generar reporte";
                    MessageBox.Show(error2, titulo1);
                }
                else
                {
                    Carrera carreraElegida = (Carrera)cbxCarrera.SelectedIndex;
                    FrmReporteInscripcionesCarrera informe = new FrmReporteInscripcionesCarrera(admin, carrera, inicio, final);
                    informe.Show();
                }
            }
        }
    }
}
