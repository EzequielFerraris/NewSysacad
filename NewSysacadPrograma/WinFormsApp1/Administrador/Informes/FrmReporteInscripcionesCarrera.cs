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
    public partial class FrmReporteInscripcionesCarrera : Form
    {
        private Administrador admin;
        public FrmReporteInscripcionesCarrera(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
