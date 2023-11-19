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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewSysacadFront
{
    public partial class FrmEditarRequisitos : Form
    {
        private Curso cursoAEditar;
        private FrmListaDeRequisitos listaPadre;
        private Administrador admin;

        private List<string> nombresCursos0 = new List<string>();
        private List<string> nombresCursos1 = new List<string>();
        private List<string> nombresCursos2 = new List<string>();
        private List<string> nombresCursos3 = new List<string>();

        public FrmEditarRequisitos(Curso curso, FrmListaDeRequisitos lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursoAEditar = curso;
            listaPadre = lista;

            ObtenerCursosCarrera();

            this.lblTitulo.Text = $"Editar requisitos {curso.Nombre} ({curso.Codigo})";
            dgvCorrelatividades.DataSource = cursoAEditar.ObtenerCorrelativas();

            this.txbPromedio.Text = cursoAEditar.PromedioMinimo.ToString();
            this.cbxCarrera.SelectedIndex = 0;
            this.cbxCursos.DataSource = nombresCursos0;

        }

        private void btnMostrarMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlAgregarCorrelativa.Visible)
            {
                this.pnlAgregarCorrelativa.Visible = false;
                this.btnAgregarCorrelativa.Enabled = false;

            }
            else
            {
                this.pnlAgregarCorrelativa.Visible = true;
                this.btnAgregarCorrelativa.Enabled = true;
            }
        }

        private void ObtenerCursosCarrera()
        {
            foreach (Curso curso1 in admin.ObtenerCursos())
            {
                if (cursoAEditar.Nombre != curso1.Nombre)
                {
                    switch ((int)curso1.Carrera)
                    {
                        case 0:
                            if (!nombresCursos0.Contains(curso1.Nombre))
                            { nombresCursos0.Add(curso1.Nombre); }
                            break;
                        case 1:
                            if (!nombresCursos0.Contains(curso1.Nombre))
                            { nombresCursos1.Add(curso1.Nombre); }
                            break;
                        case 2:
                            if (!nombresCursos0.Contains(curso1.Nombre))
                            { nombresCursos2.Add(curso1.Nombre); }
                            break;
                        case 3:
                            if (!nombresCursos3.Contains(curso1.Nombre))
                            { nombresCursos0.Add(curso1.Nombre); }
                            break;

                    }
                }

            }

        }

        private void cbxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCarrera.SelectedIndex)
            {
                case 0:
                    this.cbxCursos.DataSource = nombresCursos0;
                    if (nombresCursos0.Count() < 1)
                    {
                        btnAgregarCorrelativa.Enabled = false;
                    }
                    else
                    {
                        btnAgregarCorrelativa.Enabled = true;
                    }
                    break;
                case 1:
                    this.cbxCursos.DataSource = nombresCursos1;
                    if (nombresCursos1.Count() < 1)
                    {
                        btnAgregarCorrelativa.Enabled = false;
                    }
                    else
                    {
                        btnAgregarCorrelativa.Enabled = true;
                    }
                    break;
                case 2:
                    this.cbxCursos.DataSource = nombresCursos2;
                    if (nombresCursos2.Count() < 1)
                    {
                        btnAgregarCorrelativa.Enabled = false;
                    }
                    else
                    {
                        btnAgregarCorrelativa.Enabled = true;
                    }
                    break;
                case 3:
                    this.cbxCursos.DataSource = nombresCursos3;
                    if (nombresCursos3.Count() < 1)
                    {
                        btnAgregarCorrelativa.Enabled = false;
                    }
                    else
                    {
                        btnAgregarCorrelativa.Enabled = true;
                    }
                    break;
            }
        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Editar requisitos académicos";
            bool condicion = Validaciones.ValidarDecimal(txbPromedio.Text);
            if (condicion)
            {
                string mensajePromedio = "¿Está seguro que quiere cambiar el promedio mínimo requerido para anotarse en esta materia?";

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult consultarCambio = MessageBox.Show(mensajePromedio, tituloMensaje, botones);

                if (consultarCambio == DialogResult.Yes)
                {
                    cursoAEditar.PromedioMinimo = Decimal.Parse(txbPromedio.Text);
                    cursoAEditar.ActualizarEnBD();

                    string correcto = "Información actualizada correctamente";
                    DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                    listaPadre.ActualizarLista();
                    this.Close();
                }
            }
            else
            {
                string correcto = "El dato ingresado es incorrecto. Ingrese un número entre 0 y 10.";
                DialogResult result = MessageBox.Show(correcto, tituloMensaje);
            }
        }

        private void btnAgregarCorrelativa_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Editar requisitos académicos";
            string mensajeAgregarCorrelativa = "¿Está seguro que quiere agregar esta correlatividad?";

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult consultarCambio = MessageBox.Show(mensajeAgregarCorrelativa, tituloMensaje, botones);

            if (consultarCambio == DialogResult.Yes)
            {
                foreach (Curso curso in admin.ObtenerCursos())
                {
                    if (curso.Nombre == cbxCursos.SelectedValue.ToString() && curso.Carrera == (Carrera)cbxCarrera.SelectedIndex)
                    {
                        cursoAEditar.RegistrarCorrelatividad(this.cursoAEditar.Codigo, curso.Codigo);
                    }
                }

                string correcto = "Información actualizada correctamente";
                DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                listaPadre.ActualizarLista();
                this.Close();
            }
        }

        private void btnEliminarCorrelativa_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Editar requisitos académicos";
            int selectedRowCount = dgvCorrelatividades.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {

                string mensajeEliminarCorrelativa = "¿Está seguro que quiere eliminar esta correlatividad?";

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult consultarCambio = MessageBox.Show(mensajeEliminarCorrelativa, tituloMensaje, botones);

                if (consultarCambio == DialogResult.Yes)
                {
                    foreach (Curso curso in admin.ObtenerCursos())
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            string nombre = dgvCorrelatividades.SelectedRows[i].Cells[0].Value.ToString();
                            int carrera = (int)dgvCorrelatividades.SelectedRows[i].Cells[2].Value;


                            if (curso.Nombre == nombre && curso.Carrera == (Carrera)carrera)
                            {
                                //this.TEST.Text += $"{this.cursoAEditar.Codigo}  {curso.Codigo}\n";
                                cursoAEditar.EliminarCorrelatividad(this.cursoAEditar.Codigo, curso.Codigo);
                            }

                        }

                    }

                    string correcto = "Información actualizada correctamente";
                    DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                    listaPadre.ActualizarLista();
                    this.Close();
                }

            }
            else
            {
                string correcto = "No hay correlatividades para eliminar.";
                DialogResult result = MessageBox.Show(correcto, tituloMensaje);
            }
        }
    }
}
