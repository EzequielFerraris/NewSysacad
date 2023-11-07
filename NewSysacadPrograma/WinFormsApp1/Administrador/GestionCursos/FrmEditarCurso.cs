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
        public FrmEditarCurso(Curso curso, FrmListaDeCursos lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursoAEditar = curso;
            txbNombre.Text = cursoAEditar.Nombre;
            txbCodigo.Text = cursoAEditar.Codigo.ToString();
            txbCupoMax.Text = cursoAEditar.CupoMaximo.ToString();
            txbDescripcion.Text = cursoAEditar.Descripcion;
            cbxDia.DataSource = Enum.GetValues(typeof(dia));
            cbxTurno.DataSource = Enum.GetValues(typeof(turno));
            cbxDia.SelectedItem = cursoAEditar.DiaCursada;
            cbxTurno.SelectedItem = cursoAEditar.TurnoCursada;
            cbxCarrera.SelectedIndex = (int)cursoAEditar.Carrera;
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
                nuevoCurso.Carrera = (Carrera)this.cbxCarrera.SelectedIndex;

                List<string> props = new List<string> { nuevoCurso.Nombre, nuevoCurso.Descripcion };
                List<int> props2 = new List<int> { nuevoCurso.CupoMaximo, nuevoCurso.Codigo };

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
                txbCodigo.Text = nuevoCurso.Codigo.ToString();


                if (validados)
                {
                    try
                    {
                        admin.EliminarCurso(cursoAEditar, out string error);
                        if (!admin.AgregarCurso(nuevoCurso, out string error2))
                        {
                            admin.AgregarCurso(cursoAEditar, out string x);
                            string mensaje3 = $"Error. El código ya está en uso.";
                            string titulo3 = "Editar curso";
                            DialogResult result3 = MessageBox.Show(mensaje3, titulo3);
                            txbCodigo.Text = cursoAEditar.Codigo.ToString();
                        }
                        else
                        {
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
}
