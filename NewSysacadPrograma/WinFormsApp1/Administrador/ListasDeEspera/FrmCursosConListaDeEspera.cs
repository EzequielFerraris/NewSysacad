using BibliotecaNewSysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewSysacadFront
{
    public partial class FrmCursosConListaDeEspera : Form
    {
        private Administrador admin;
        private int estudianteSeleccionado = 0;
        private List<Curso> listaDeCursos;
        private Curso cursoSeleccionado;
        private bool mostrarAgregar = false;

        public FrmCursosConListaDeEspera(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.listaDeCursos = NewSysacad.ListaCursos;
            this.dgvListasDeEspera.DataSource = admin.ObtenerCursosConListaDeEspera();

            lblCodigoSeleccionado.Hide();
            lblCursoSeleccionado.Hide();
            lblAgregar1.Hide();
            lblAgregar2.Hide();
            lblAgregar3.Hide();
            txbLegajo.Hide();
            btnConfirmarAgregar.Hide();

            int selectedRowCount = dgvListasDeEspera.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int codigo = (int)dgvListasDeEspera.SelectedRows[1].Cells[0].Value;
                foreach (Curso curso in listaDeCursos)
                {
                    if (codigo == curso.Codigo)
                    {
                        cursoSeleccionado = curso;
                        break;
                    }
                }
                this.dgvListaEsperaCursoSelecccionado.DataSource = cursoSeleccionado.ListaInscriptosListaEspera();
            }

        }

        private void dgvListasDeEspera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigo = (int)dgvListasDeEspera.SelectedRows[0].Cells[0].Value;
            foreach (Curso curso in listaDeCursos)
            {
                if (codigo == curso.Codigo)
                {
                    cursoSeleccionado = curso;
                    break;
                }
            }
            dgvListaEsperaCursoSelecccionado.DataSource = cursoSeleccionado.ListaInscriptosListaEspera();

        }


        private void btnAgregarEstLE_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvListasDeEspera.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (!mostrarAgregar && selectedRowCount > 0)
            {
                lblCodigoSeleccionado.Text = cursoSeleccionado.Codigo.ToString();
                lblCursoSeleccionado.Text = cursoSeleccionado.Nombre;

                lblCodigoSeleccionado.Show();
                lblCursoSeleccionado.Show();
                lblAgregar1.Show();
                lblAgregar2.Show();
                lblAgregar3.Show();
                txbLegajo.Show();
                btnConfirmarAgregar.Show();

                mostrarAgregar = true;

            }
            else
            {
                lblCodigoSeleccionado.Hide();
                lblCursoSeleccionado.Hide();
                lblAgregar1.Hide();
                lblAgregar2.Hide();
                lblAgregar3.Hide();
                txbLegajo.Hide();
                btnConfirmarAgregar.Hide();

                mostrarAgregar = false;
            }

        }

        private void btnEliminarEstudianteLE_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Listas de Espera";

            if(mostrarAgregar)
            {
                lblCodigoSeleccionado.Hide();
                lblCursoSeleccionado.Hide();
                lblAgregar1.Hide();
                lblAgregar2.Hide();
                lblAgregar3.Hide();
                txbLegajo.Hide();
                btnConfirmarAgregar.Hide();

                mostrarAgregar = false;
            }

            int selectedRowCount = dgvListaEsperaCursoSelecccionado.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                string msjEliminarAlumno = "¿Está seguro que quiere eliminar a este alumno de la lista de espera?";

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult consultarCambio = MessageBox.Show(msjEliminarAlumno, tituloMensaje, botones);

                if (consultarCambio == DialogResult.Yes)
                {
                    bool elim = cursoSeleccionado.EliminarEstudianteDeListaDeEspera(estudianteSeleccionado);
                    if (elim)
                    {
                        string correcto = "Información actualizada correctamente";
                        DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                        dgvListasDeEspera.DataSource = admin.ObtenerCursosConListaDeEspera();
                        dgvListaEsperaCursoSelecccionado.DataSource = cursoSeleccionado.ListaInscriptosListaEspera();
                    }
                    else
                    {
                        string correcto = "No se pudo completar la operación. Reinicie en inténtelo nuevamente.";
                        DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                    }

                }

            }
            else
            {
                string resultado = "No se seleccionó ningún estudiante.";
                DialogResult result = MessageBox.Show(resultado, tituloMensaje);
            }
        }

        private void dgvListaEsperaCursoSelecccionado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            estudianteSeleccionado = (int)dgvListaEsperaCursoSelecccionado.SelectedRows[0].Cells[1].Value;

        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Listas de Espera";

            string msjEliminarAlumno = "¿Está seguro que quiere agregar a este alumno a la lista de espera?";

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult consultarCambio = MessageBox.Show(msjEliminarAlumno, tituloMensaje, botones);

            if (consultarCambio == DialogResult.Yes)
            {
                bool validarLegajo = Validaciones.ValidarIntPositivo(txbLegajo.Text);
                if (validarLegajo)
                {
                    Estudiante est = NewSysacad.ObtenerEstudiante(int.Parse(txbLegajo.Text));

                    if (est.Nombre != string.Empty)
                    {
                        if (cursoSeleccionado.ChequearListaEspera(est.Legajo))
                        {
                            cursoSeleccionado.InscribirEnListaEspera(est.Legajo);
                            string msjListaEspera2 = $"{cursoSeleccionado.Nombre}: Inscripción exitosa.\n";
                            DialogResult confirmacion = MessageBox.Show(msjListaEspera2, tituloMensaje);
                            dgvListaEsperaCursoSelecccionado.DataSource = cursoSeleccionado.ListaInscriptosListaEspera();
                        }
                        else
                        {
                            //el est ya está en la lista de espera
                            string error1 = $"{cursoSeleccionado.Nombre}: El estudiante ya se encuentra registrado en la lista de espera de este curso.";
                            DialogResult confirmacion = MessageBox.Show(error1, tituloMensaje);
                        }

                    }
                    else
                    {
                        //mensaje de que el estudiante no existe
                        string error2 = $"El legajo proporcionado no coincide con el de ningún estudiante inscripto.";
                        DialogResult confirmacion = MessageBox.Show(error2, tituloMensaje);
                    }
                }
                else
                {
                    string error3 = "No se ha ingresado un número válido.";
                    DialogResult confirmacion = MessageBox.Show(error3, tituloMensaje);
                }
            }

            
        }
    }
}
