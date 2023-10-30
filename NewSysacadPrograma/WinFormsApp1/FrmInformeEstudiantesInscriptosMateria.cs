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
    public partial class FrmInformeEstudiantesInscriptosMateria : Form
    {
        private List<string> nombresCursos;
        private Administrador admin;
        public FrmInformeEstudiantesInscriptosMateria(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;

            nombresCursos = new List<string>();
            foreach (Curso curso in admin.ObtenerCursos())
            {
                nombresCursos.Add(curso.Nombre);
            }

            cbxCursos.DataSource = nombresCursos;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FrmReporteInscripcionesCurso reporte = new FrmReporteInscripcionesCurso();
            reporte.Show();
        }
    }
}
