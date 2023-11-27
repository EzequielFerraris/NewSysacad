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
    public partial class FrmEditarCurso : Form
    {
        private Curso cursoAEditar;
        FrmListaDeCursos listaPadre;
        private Administrador admin;

        public delegate void NotificadorCambioCurso(Curso nuevoCurso, InfoCursoEventArgs infoCurso);
        public event NotificadorCambioCurso TurnoCambiado;
        public event NotificadorCambioCurso DiaCambiado;

        public FrmEditarCurso(Curso curso, FrmListaDeCursos lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursoAEditar = curso;
            listaPadre = lista;

            txbNombre.Text = cursoAEditar.Nombre;
            txbCupoMax.Text = cursoAEditar.CupoMaximo.ToString();
            txbDescripcion.Text = cursoAEditar.Descripcion;
            cbxDia.DataSource = Enum.GetValues(typeof(dia));
            cbxTurno.DataSource = Enum.GetValues(typeof(turno));
            cbxDia.SelectedItem = cursoAEditar.DiaCursada;
            cbxTurno.SelectedItem = cursoAEditar.TurnoCursada;
            cbxCarrera.SelectedIndex = (int)cursoAEditar.Carrera;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que desea guardar estos cambios?";
            string titulo = "Editar curso";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                Curso nuevoCurso = new Curso();

                nuevoCurso.Codigo = cursoAEditar.Codigo;
                nuevoCurso.Nombre = txbNombre.Text;
                nuevoCurso.Descripcion = txbDescripcion.Text;
                try
                {
                    nuevoCurso.CupoMaximo = int.Parse(txbCupoMax.Text);
                }
                catch
                {
                    nuevoCurso.CupoMaximo = 0;
                }

                nuevoCurso.DiaCursada = (dia)cbxDia.SelectedValue;
                nuevoCurso.TurnoCursada = (turno)cbxTurno.SelectedValue;

                nuevoCurso.Carrera = (Carrera)this.cbxCarrera.SelectedIndex;
                nuevoCurso.PromedioMinimo = cursoAEditar.PromedioMinimo;

                List<string> props = new List<string> { nuevoCurso.Nombre, nuevoCurso.Descripcion };
                List<int> props2 = new List<int> { nuevoCurso.CupoMaximo };

                //--------------------------------------------------------
                bool validados = true;

                foreach (string prop in props)
                {
                    if (prop == string.Empty)
                    {
                        validados = false;

                        string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                        string tituloError1 = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                        break;
                    }
                }

                foreach (int prop in props2)
                {
                    if (prop == 0)
                    {
                        validados = false;

                        string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                        string tituloError1 = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                        break;
                    }
                }

                txbNombre.Text = nuevoCurso.Nombre;
                txbDescripcion.Text = nuevoCurso.Descripcion;
                txbCupoMax.Text = nuevoCurso.CupoMaximo.ToString();


                if (validados)
                {
                    try
                    {

                        if (nuevoCurso.ActualizarEnBD())
                        {
                            //ACÁ CHEQUEAR SI HUBO CAMBIO DE TURNO U HORARIO PARA ENVIAR NOTIFICACIÓN

                            if (nuevoCurso.TurnoCursada != cursoAEditar.TurnoCursada)
                            {
                                InfoCursoEventArgs infoCurso = new InfoCursoEventArgs(nuevoCurso.TurnoCursada, nuevoCurso.DiaCursada);
                                if(TurnoCambiado is not null)
                                {
                                    TurnoCambiado.Invoke(nuevoCurso, infoCurso);
                                }
                            }

                            if(nuevoCurso.DiaCursada != cursoAEditar.DiaCursada) 
                            {
                                InfoCursoEventArgs infoCurso = new InfoCursoEventArgs(nuevoCurso.TurnoCursada, nuevoCurso.DiaCursada);
                                if (DiaCambiado is not null)
                                {
                                    DiaCambiado.Invoke(nuevoCurso, infoCurso);
                                }
                            }

                            string mensaje1 = "Curso actualizado correctamente.";
                            string titulo1 = "Editar curso";
                            DialogResult result1 = MessageBox.Show(mensaje1, titulo1);
                            listaPadre.ActualizarLista();
                            this.Hide();
                            this.Close();
                        }

                    }
                    catch
                    {
                        string mensaje2 = $"Error en los registros. Inténtelo nuevamente.";
                        string titulo2 = "Editar curso";
                        DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                        listaPadre.ActualizarLista();
                        this.Hide();
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }

    public class InfoCursoEventArgs : EventArgs
    {
        public turno turnoCursada;
        public dia diaCursada;
        
        public InfoCursoEventArgs(turno turnoCursada, dia diaCursada)
        {
            this.turnoCursada = turnoCursada;
            this.diaCursada = diaCursada;
            
        }
    }
}
