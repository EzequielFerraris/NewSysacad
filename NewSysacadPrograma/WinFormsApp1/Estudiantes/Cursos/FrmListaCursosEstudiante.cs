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
            EstudianteUsuario = usuario;
            cursosAgregados = new List<FrmCursoParaEstudiante>();
            cursosSeleccionados = new List<Curso>();
            EstudianteUsuario.ActualizarCodigosCursosInscripto();
            ActualizarLista();
            
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
            List<Curso> lista = EstudianteUsuario.ObtenerCursosVisibles();
            foreach (Curso curso in lista)
            {
                FrmCursoParaEstudiante cardCurso = new FrmCursoParaEstudiante(curso, this, EstudianteUsuario);
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

            string tituloConfirmacion = "Inscripción";

            if (result == DialogResult.Yes)
            {
                if (cursosSeleccionados.Count() < 1) //SI NO HA SELECCIONADO NADA
                {
                    string mensajeConfirmacion = "No ha seleccionado ningún curso.";
                    DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion);
                }
                else //SI HAY SELECCION
                {
                    string listaErrores = string.Empty;
                    string listaInscripciones = string.Empty;
                    List<Curso> listaListasDeEspera = new List<Curso>();

                    foreach (Curso curso in cursosSeleccionados)
                    {
                        //CHEQUEA QUE EL ESTUDIANTE TENGA DISPONIBILIDAD HORARIA
                        if (EstudianteUsuario.ChequearDisponibilidadDelEstudiante(curso))
                        {
                            //CHEQUEAR PROMEDIO 
                            if (EstudianteUsuario.Promedio >= curso.PromedioMinimo)
                            {
                                //CHEQUEAR EQUIVALENCIAS

                                bool chequearCorrelativas = curso.ChequearRequisitoCorrelativas(EstudianteUsuario.ObtenerNombresCursosAprobados());
                                if (chequearCorrelativas)
                                {
                                    //CHEQUEA QUE HAYA LUGAR EN EL CURSO
                                    bool inscripcion = curso.ChequearDisponibilidad();

                                    if (!inscripcion)
                                    {
                                        //LISTA DE ESPERA
                                        listaListasDeEspera.Add(curso);
                                    }
                                    else
                                    {
                                        //INSCRIBE AL ESTUDIANTE - GUARDA EN BD
                                        listaInscripciones += $"{curso.Nombre}: Inscripción exitosa.\n";
                                        EstudianteUsuario.InscribirEnCurso(curso);
                                        EstudianteUsuario.ActualizarCodigosCursosInscripto();
                                    }
                                }
                                else
                                {
                                    listaErrores += $"{curso.Nombre}: El estudiante no cuenta con las equivalencias necesarias para inscribirse en este curso.\n";
                                }
                                
                            }
                            else
                            {
                                listaErrores += $"{curso.Nombre}: El estudiante no cuenta con el promedio necesario para inscribirse en este curso.\n";
                            }
                            
                        }
                        else
                        {
                            listaErrores += $"{curso.Nombre}: El estudiante ya está inscripto en otro curso en ese horario.\n";
                        }
                    }

                    if (listaListasDeEspera.Count() > 0)
                    {
                        //PREGUNTA POR LAS INSCRIPCIONES A LISTA DE ESPERA
                        foreach (Curso curso in listaListasDeEspera)
                        {
                            string msjListaEspera = $"El curso {curso.Nombre} está completo ¿Desea inscribirse en la lista de espera?";
                            MessageBoxButtons btns = MessageBoxButtons.YesNo;
                            DialogResult resultado = MessageBox.Show(msjListaEspera, tituloConfirmacion, btns);

                            if (resultado == DialogResult.Yes)
                            {
                                if (curso.ChequearListaEspera(EstudianteUsuario.Legajo))
                                {
                                    curso.InscribirEnListaEspera(EstudianteUsuario.Legajo);
                                    string msjListaEspera2 = $"{curso.Nombre}: Inscripción exitosa.\n";
                                    DialogResult confirmacion = MessageBox.Show(msjListaEspera2, tituloConfirmacion);
                                }
                                else
                                {
                                    listaErrores += $"{curso.Nombre}: El estudiante ya se encuentra registrado en la lista de espera de este curso.\n";
                                }
                            }
                        }
                    }

                    if (listaErrores != string.Empty) //MUESTRA LOS ERRORES
                    {
                        string mensajeConfirmacion = listaErrores;
                        DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion);
                    }
                    if (listaInscripciones != string.Empty) //MUESTRA LAS INSCRIPCIONES EXITOSAS
                    {
                        string mensajeConfirmacion1 = listaInscripciones;
                        DialogResult confirmacion1 = MessageBox.Show(mensajeConfirmacion1, tituloConfirmacion);
                    }
                   

                }

            }

        }
    }
}
