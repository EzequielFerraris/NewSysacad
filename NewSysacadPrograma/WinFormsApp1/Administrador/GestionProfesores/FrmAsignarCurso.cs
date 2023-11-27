using BibliotecaNewSysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class FrmAsignarCurso : Form
    {
        private Profesor profesorAsignar;
        FrmListaProfesores listaPadre;
        private Administrador admin;



        public FrmAsignarCurso(Profesor profesorAsignar, FrmListaProfesores lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.profesorAsignar = profesorAsignar;
            listaPadre = lista;

            dgvCursosDisponibles.DataSource = admin.ObtenerCursosDisponiblesParaAsignar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tituloMensaje = "Asignar Curso";
            int selectedRowCount = dgvCursosDisponibles.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {

                string mensajeAsignar = "¿Está seguro que quiere asignar este curso a este profesor?";

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult consultarCambio = MessageBox.Show(mensajeAsignar, tituloMensaje, botones);

                if (consultarCambio == DialogResult.Yes)
                {

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        int codigo = (int)dgvCursosDisponibles.SelectedRows[i].Cells[0].Value;
                        //CHEQUEAR DISPONIBILIDAD HORARIA
                        if (profesorAsignar.ChequearDisponibilidadHoraria(codigo))
                        {
                            profesorAsignar.AsignarCurso(codigo);
                            string correcto = "Información actualizada correctamente";
                            DialogResult result = MessageBox.Show(correcto, tituloMensaje);
                            listaPadre.ActualizarLista();
                            this.Close();
                        }
                        else
                        {
                            string incorrecto = "El profesor no tiene disponibilidad en ese horario.";
                            DialogResult horarioOcupadoresult = MessageBox.Show(incorrecto, tituloMensaje);
                        }
                        
                    } 
                }

            }
            else
            {
                string correcto = "No se pudo asignar el curso.";
                DialogResult result = MessageBox.Show(correcto, tituloMensaje);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }


}
