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
    public partial class FrmControlReportes : Form
    {
        Administrador admin;
        FrmInformeInscripcionesPorPeriodo inscripcionesPeriodo;
        FrmInformeEstudiantesInscriptosMateria inscripcionesMateria;
        FrmInformeIngresos ingresos;
        FrmInformeInscripcionesPorCarrera inscripcionesCarrera;
        FrmInformeListaEspera listaEspera;
        public FrmControlReportes(Administrador admin)
        {
            InitializeComponent();

            this.admin = admin;

            inscripcionesPeriodo = new FrmInformeInscripcionesPorPeriodo();
            inscripcionesPeriodo.TopLevel = false;
            pnlDisplayOpcionesReporte.Controls.Add(inscripcionesPeriodo);
            inscripcionesPeriodo.Hide();

            inscripcionesMateria = new FrmInformeEstudiantesInscriptosMateria(admin);
            inscripcionesMateria.TopLevel = false;
            pnlDisplayOpcionesReporte.Controls.Add(inscripcionesMateria);
            inscripcionesMateria.Hide();

            ingresos = new FrmInformeIngresos();
            ingresos.TopLevel = false;
            pnlDisplayOpcionesReporte.Controls.Add(ingresos);
            ingresos.Hide();

            inscripcionesCarrera = new FrmInformeInscripcionesPorCarrera();
            inscripcionesCarrera.TopLevel = false;
            pnlDisplayOpcionesReporte.Controls.Add(inscripcionesCarrera);
            inscripcionesCarrera.Hide();

            listaEspera = new FrmInformeListaEspera();
            listaEspera.TopLevel = false;
            pnlDisplayOpcionesReporte.Controls.Add(listaEspera);
            listaEspera.Hide();

        }


        private void cbxReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbxReportes.SelectedIndex;

            switch (indice)
            {
                case 0:
                    ingresos.Hide();
                    inscripcionesCarrera.Hide();
                    listaEspera.Hide();
                    inscripcionesMateria.Hide();
                    inscripcionesPeriodo.Show();
                    break;
                case 1:
                    inscripcionesPeriodo.Hide();
                    ingresos.Hide();
                    inscripcionesCarrera.Hide();
                    listaEspera.Hide();
                    inscripcionesMateria.Show();
                    break;
                case 2:
                    inscripcionesPeriodo.Hide();
                    inscripcionesCarrera.Hide();
                    listaEspera.Hide();
                    inscripcionesMateria.Hide();
                    ingresos.Show();
                    break;
                case 3:
                    inscripcionesPeriodo.Hide();
                    ingresos.Hide();
                    listaEspera.Hide();
                    inscripcionesMateria.Hide();
                    inscripcionesCarrera.Show();
                    break;
                case 4:
                    inscripcionesPeriodo.Hide();
                    ingresos.Hide();
                    inscripcionesCarrera.Hide();
                    inscripcionesMateria.Hide();
                    listaEspera.Show();
                    break;
            }

        }
    }
}
