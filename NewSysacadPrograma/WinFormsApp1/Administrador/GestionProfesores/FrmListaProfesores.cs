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
    public partial class FrmListaProfesores : Form
    {
        private List<FrmProfesor> profes;
        private Administrador admin;
        public FrmListaProfesores(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            profes = new List<FrmProfesor>();
            ActualizarLista();
        }
        
        public void ActualizarLista()
        {
            profes.Clear();
            pnlListaCursos.Controls.Clear();
            foreach (Profesor profe in admin.ObtenerProfesores())
            {

                FrmProfesor cardProfe = new FrmProfesor(profe, this, admin);
                cardProfe.TopLevel = false;
                pnlListaCursos.Controls.Add(cardProfe);
                cardProfe.Dock = DockStyle.Top;
                cardProfe.Show();
            }
        }
        
    }
}
