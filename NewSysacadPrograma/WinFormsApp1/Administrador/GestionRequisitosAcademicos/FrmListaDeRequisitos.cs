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
    public partial class FrmListaDeRequisitos : Form
    {
        private List<FrmCurso> cursos;
        private Administrador admin;
        public FrmListaDeRequisitos(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursos = new List<FrmCurso>();
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            cursos.Clear();
            pnlListaRequisitos.Controls.Clear();
            foreach (Curso curso in admin.ObtenerCursos())
            {

                FrmRequisitosCurso cardRequisito = new FrmRequisitosCurso(curso, this, admin);
                cardRequisito.TopLevel = false;
                pnlListaRequisitos.Controls.Add(cardRequisito);
                cardRequisito.Dock = DockStyle.Top;
                cardRequisito.Show();

            }
        }
    }
}
