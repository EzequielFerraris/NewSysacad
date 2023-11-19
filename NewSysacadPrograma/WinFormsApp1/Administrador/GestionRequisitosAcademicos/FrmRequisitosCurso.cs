using BibliotecaNewSysacad;
using System;
using System.Collections;
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
    public partial class FrmRequisitosCurso : Form
    {
        private FrmListaDeRequisitos listaPadre;
        private Curso cursoObj;
        private Administrador admin;
        public FrmRequisitosCurso(Curso curso, FrmListaDeRequisitos lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursoObj = curso;
            lblNombre.Text = cursoObj.Nombre;
            lblCodigo.Text = $"{cursoObj.Codigo}";
            lblCarrera.Text = cursoObj.Carrera.ToString();
            lblPromedioMinimo.Text = cursoObj.PromedioMinimo.ToString();

            dgvCorrelatividades.DataSource = cursoObj.ObtenerCorrelativas();

            listaPadre = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarRequisitos nuevaEdicion = new FrmEditarRequisitos(cursoObj, listaPadre, admin);
            nuevaEdicion.Show();

        }


    }
}
