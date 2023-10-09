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
    public partial class FrmListaCursosEstudiante : Form
    {
        private List<FrmCursoParaEstudiante> cursosAgregados;
        private List<Curso> cursosSeleccionados;
        private Estudiante EstudianteUsuario;
        public FrmListaCursosEstudiante(Estudiante usuario)
        {
            InitializeComponent();
            cursosAgregados = new List<FrmCursoParaEstudiante>();
            cursosSeleccionados = new List<Curso>();
            ActualizarLista();
            EstudianteUsuario = usuario;
            EstudianteUsuario.ActualizarCursosInscripto();
        }

        public void ActualizarLista()
        {
            cursosAgregados.Clear();
            pnlListaCursos.Controls.Clear();
            cursosSeleccionados.Clear();

            ActualizarListaLocal();
            foreach (FrmCursoParaEstudiante curso in cursosAgregados)
            {
                curso.TopLevel = false;
                pnlListaCursos.Controls.Add(curso);
                curso.Dock = DockStyle.Top;
                curso.Show();
            }
        }

        private void ActualizarListaLocal()
        {
            foreach (Curso curso in NewSysacad.ListaCursos)
            {
                FrmCursoParaEstudiante cardCurso = new FrmCursoParaEstudiante(curso, this);
                cursosAgregados.Add(cardCurso);
                
            }
        }

        public void ActualizarSeleccion()
        {

            if (cursosSeleccionados.Count() > 0)
            {
                btnInscribir.Enabled = true;
            }
            else
            {
                btnInscribir.Enabled = false;
            }
        }

        public bool AgregarQuitarSelecccion(Curso curso, string accion)
        {
            foreach (Curso item in cursosSeleccionados)
            {
                if (curso.Nombre == item.Nombre && curso.Codigo == item.Codigo)
                {
                    if (accion == "agregar")
                    {
                        return false;
                    }
                    else
                    {
                        cursosSeleccionados.Remove(curso);
                        return true;
                    }
                }
            }
            if (accion == "agregar")
            {
                cursosSeleccionados.Add(curso);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {

            string mensaje = "¿Está seguro que quiere registrar estas inscripciones?";
            string titulo = "Confirmar inscripcion";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                if (cursosSeleccionados.Count() < 1) //SI NO HA SELECCIONADO NADA
                {
                    string mensajeConfirmacion = "No ha seleccionado ningún curso.";
                    string tituloConfirmacion = "Inscripción";
                    DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion);
                }
                else
                {
                    string listaErrores = string.Empty;
                    string listaInscripciones = string.Empty;
                    foreach (Curso curso in cursosSeleccionados)
                    {

                        if (EstudianteUsuario.ChequearDisponibilidad(curso))
                        {
                            //INSCRIBE AL USUARIO EN LA CLASE CURSO
                            bool inscripcion = curso.InscribirEstudiante(EstudianteUsuario, out string errorCurso);
                            //GUARDA LOS CAMBIOS EN LA BASE DE DATOS
                            NewSysacad.ActualizarCurso(curso);
                            if (!inscripcion)
                            {
                                listaErrores += $"{curso.Nombre}: {errorCurso}\n";
                            }
                            else
                            {
                                //REGISTRA EL CODIGO DEL CURSO EN LA INFO DEL ESTUDIANTE

                                listaInscripciones += $"{curso.Nombre}: Inscripción exitosa.\n";
                                EstudianteUsuario.AgregarCurso(curso);
                            }
                        }
                        else
                        {
                            listaErrores += $"{curso.Nombre}: El estudiante ya está inscripto en otro curso en ese horario.\n";
                        }
                    }

                    if (listaErrores != string.Empty) //MUESTRA LOS ERRORES
                    {
                        string mensajeConfirmacion = listaErrores;
                        string tituloConfirmacion = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion);
                    }
                    if (listaInscripciones != string.Empty) //MUESTRA LAS INSCRIPCIONES EXITOSAS
                    {
                        string mensajeConfirmacion1 = listaInscripciones;
                        string tituloConfirmacion1 = "Inscripción";
                        DialogResult confirmacion1 = MessageBox.Show(mensajeConfirmacion1, tituloConfirmacion1);
                    }
                }

            }

        }
    }
}
