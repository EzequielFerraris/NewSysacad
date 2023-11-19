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
    public partial class FrmCursoParaEstudiante : Form
    {

        private FrmListaCursosEstudiante listaPadre;
        private Curso cursoObj;
        private Estudiante est;

        public FrmCursoParaEstudiante(Curso curso, FrmListaCursosEstudiante lista, Estudiante est)
        {
            InitializeComponent();
            cursoObj = curso;
            this.est = est;

            lblNombre.Text = cursoObj.Nombre;
            lblCodigo.Text = $"{cursoObj.Codigo}";
            lblCupo.Text = $"{cursoObj.CantidadInscriptos()}/{curso.CupoMaximo}";
            lblDescripcion.Text = cursoObj.Descripcion;
            lblDia.Text = cursoObj.DiaCursada.ToString();
            lblTurno.Text = cursoObj.TurnoCursada.ToString();
            lblPromedio.Text = cursoObj.PromedioMinimo.ToString();
            dgvCorrelatividades.DataSource = cursoObj.ObtenerCorrelativas();

            listaPadre = lista;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listaPadre.AgregarQuitarSelecccion(cursoObj, "agregar");
                listaPadre.ActualizarSeleccion();
            }
            else
            {
                listaPadre.AgregarQuitarSelecccion(cursoObj, "quitar");
                listaPadre.ActualizarSeleccion();
            }
        }

        public Curso CursoObj
        {
            get => cursoObj;
            set => cursoObj = value;
        }
    }

}
