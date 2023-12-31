﻿using BibliotecaNewSysacad;
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
        private Administrador admin;
        public FrmInformeInscripcionesPorPeriodo(Administrador admin)
        {
            InitializeComponent();

            this.admin = admin;

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

                if (DateTime.Compare(inicio, final) > 0)
                {
                    string titulo1 = "Generar reporte";
                    string error1 = "La fecha de inicio es posterior a la de finalización";
                    MessageBox.Show(error1, titulo1);
                }
                else
                { 
                    FrmReporteInscripcionesPeriodo informe = new FrmReporteInscripcionesPeriodo(this.admin, inicio, final);
                    informe.Show();
                }

            }

        }
    }
}
