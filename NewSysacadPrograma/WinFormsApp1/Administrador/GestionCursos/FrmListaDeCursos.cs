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
    public partial class FrmListaDeCursos : Form
    {
        private List<FrmCurso> cursos;
        private Administrador admin;
        public FrmListaDeCursos(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursos = new List<FrmCurso>();
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            cursos.Clear();
            pnlListaCursos.Controls.Clear();
            foreach (Curso curso in admin.ObtenerCursos())
            {
                FrmCurso cardCurso = new FrmCurso(curso, this, admin);
                cardCurso.TopLevel = false;
                pnlListaCursos.Controls.Add(cardCurso);
                cardCurso.Dock = DockStyle.Top;
                cardCurso.Show();
            }
        }
    }
}
