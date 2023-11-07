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
    public partial class FrmAgregarCurso : Form
    {
        public bool agregado = false;
        private Administrador admin;
        public FrmAgregarCurso(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cbxDia.DataSource = Enum.GetValues(typeof(dia));
            cbxTurno.DataSource = Enum.GetValues(typeof(turno));
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere registrar este curso?";
            string titulo = "Confirmar curso";
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
                    if (admin.AgregarCurso(nuevoCurso, out string error))
                    {
                        string mensaje1 = "Curso agregado correctamente.";
                        string titulo1 = "Agregar curso";
                        DialogResult result1 = MessageBox.Show(mensaje1, titulo1);
                        agregado = true;
                        this.Close();
                    }
                    else
                    {
                        string mensaje2 = $"Error en el registro. {error} ya registrado.";
                        string titulo2 = "Agregar curso";
                        DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                    }
                }

            }

        }
    }
}
