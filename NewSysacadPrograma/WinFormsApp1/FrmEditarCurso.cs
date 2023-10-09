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
        public FrmEditarCurso(Curso curso, FrmListaDeCursos lista)
        {
            InitializeComponent();
            cursoAEditar = curso;
            txbNombre.Text = cursoAEditar.Nombre;
            txbCodigo.Text = cursoAEditar.Codigo.ToString();
            txbCupoMax.Text = cursoAEditar.CupoMaximo.ToString();
            txbDescripcion.Text = cursoAEditar.Descripcion;
            cbxDia.DataSource = Enum.GetValues(typeof(dia));
            cbxTurno.DataSource = Enum.GetValues(typeof(turno));
            cbxDia.SelectedItem = cursoAEditar.DiaCursada;
            cbxTurno.SelectedItem = cursoAEditar.TurnoCursada;
            listaPadre = lista;
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

                nuevoCurso.Nombre = txbNombre.Text;
                nuevoCurso.Descripcion = txbDescripcion.Text;
                try
                {
                    nuevoCurso.CupoMaximo = int.Parse(txbCupoMax.Text);
                    nuevoCurso.Codigo = int.Parse(txbCodigo.Text);
                }
                catch
                {
                    nuevoCurso.CupoMaximo = 0;
                    nuevoCurso.Codigo = 0;
                }

                nuevoCurso.DiaCursada = (dia)cbxDia.SelectedValue;
                nuevoCurso.TurnoCursada = (turno)cbxTurno.SelectedValue;

                List<string> props = new List<string> { nuevoCurso.Nombre, nuevoCurso.Descripcion };
                List<int> props2 = new List<int> { nuevoCurso.CupoMaximo, nuevoCurso.Codigo };

                bool validados = true;

                foreach (string prop in props)
                {
                    if (prop == string.Empty)
                    {
                        txbNombre.Text = nuevoCurso.Nombre;
                        txbDescripcion.Text = nuevoCurso.Descripcion;

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

                        txbCupoMax.Text = nuevoCurso.CupoMaximo.ToString();
                        txbCodigo.Text = nuevoCurso.Codigo.ToString();

                        validados = false;

                        string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                        string tituloError1 = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                        break;
                    }
                }

                if (validados)
                {
                    if (NewSysacad.EliminarCurso(cursoAEditar, out string error))
                    {
                        if (NewSysacad.AgregarCurso(nuevoCurso, out string error2))
                        {
                            string mensaje1 = "Curso actualizado correctamente.";
                            string titulo1 = "Editar curso";
                            DialogResult result1 = MessageBox.Show(mensaje1, titulo1);
                            listaPadre.ActualizarLista();
                            this.Hide();
                            this.Close();
                        }
                        else
                        {
                            string mensaje2 = $"Error en los registros. {error2}.";
                            string titulo2 = "Editar curso";
                            DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                            listaPadre.ActualizarLista();
                            this.Hide();
                            this.Close();
                        }
                    }
                    else
                    {
                        string mensaje3 = $"Error en los registros. {error}.";
                        string titulo3 = "Editar curso";
                        DialogResult result3 = MessageBox.Show(mensaje3, titulo3);
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
}
