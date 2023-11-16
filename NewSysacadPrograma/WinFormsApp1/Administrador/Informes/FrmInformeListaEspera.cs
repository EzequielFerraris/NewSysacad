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
    public partial class FrmInformeListaEspera : Form
    {
        private Administrador admin;
        private List<string> nombresCursos0 = new List<string>();
        private List<string> nombresCursos1 = new List<string>();
        private List<string> nombresCursos2 = new List<string>();
        private List<string> nombresCursos3 = new List<string>();
        public FrmInformeListaEspera(Administrador admin)
        {
            InitializeComponent();

            this.admin = admin;
            ObtenerCursosCarrera();

            cbxCarrera.SelectedIndex = 0;
            cbxCursos.DataSource = nombresCursos0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere crear este informe?";
            string titulo = "Generar reporte";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                foreach (Curso curso in admin.ObtenerCursos())
                {
                    if (curso.Nombre == cbxCursos.SelectedValue.ToString() && curso.Carrera == (Carrera)cbxCarrera.SelectedIndex)
                    {
                        FrmReporteListaDeEspera reporte = new FrmReporteListaDeEspera(curso, admin);
                        reporte.Show();
                    }

                }
            }
        }

        private void ObtenerCursosCarrera()
        {
            foreach (Curso curso in admin.ObtenerCursos())
            {
                switch ((int)curso.Carrera)
                {
                    case 0:
                        nombresCursos0.Add(curso.Nombre);
                        break;
                    case 1:
                        nombresCursos1.Add(curso.Nombre);
                        break;
                    case 2:
                        nombresCursos2.Add(curso.Nombre);
                        break;
                    case 3:
                        nombresCursos3.Add(curso.Nombre);
                        break;

                }
            }

        }

        private void cbxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCarrera.SelectedIndex)
            {
                case 0:
                    cbxCursos.DataSource = nombresCursos0;
                    if (nombresCursos0.Count() < 1)
                    {
                        btnGenerar.Enabled = false;
                    }
                    else
                    {
                        btnGenerar.Enabled = true;
                    }
                    break;
                case 1:
                    cbxCursos.DataSource = nombresCursos1;
                    if (nombresCursos1.Count() < 1)
                    {
                        btnGenerar.Enabled = false;
                    }
                    else
                    {
                        btnGenerar.Enabled = true;
                    }
                    break;
                case 2:
                    cbxCursos.DataSource = nombresCursos2;
                    if (nombresCursos2.Count() < 1)
                    {
                        btnGenerar.Enabled = false;
                    }
                    else
                    {
                        btnGenerar.Enabled = true;
                    }
                    break;
                case 3:
                    cbxCursos.DataSource = nombresCursos3;
                    if (nombresCursos3.Count() < 1)
                    {
                        btnGenerar.Enabled = false;
                    }
                    else
                    {
                        btnGenerar.Enabled = true;
                    }
                    break;

            }

        
        }
    }
}
