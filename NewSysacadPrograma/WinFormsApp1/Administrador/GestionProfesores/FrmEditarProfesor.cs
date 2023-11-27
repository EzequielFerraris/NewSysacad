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
    public partial class FrmEditarProfesor : Form
    {
        private Profesor profesorAEditar;
        FrmListaProfesores listaPadre;
        private Administrador admin;



        public FrmEditarProfesor(Profesor profesorAEditar, FrmListaProfesores lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.profesorAEditar = profesorAEditar;
            listaPadre = lista;

            this.txbApellido.Text = profesorAEditar.Apellido;
            this.txbNombre.Text = profesorAEditar.Nombre;
            this.txbDni.Text = profesorAEditar.Dni;
            this.txbEmail.Text = profesorAEditar.EMail;
            this.txbTelefono.Text = profesorAEditar.Telefono;
            this.txbCalle.Text = profesorAEditar.Calle;
            this.txbAltura.Text = profesorAEditar.Altura;
            this.txbArea.Text = profesorAEditar.Area;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que desea guardar estos cambios?";
            string titulo = "Editar Perfil Profesor";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);

            if (result == DialogResult.Yes)
            {
                Profesor nuevoProfe = new Profesor();

                nuevoProfe.Legajo = profesorAEditar.Legajo;
                nuevoProfe.Apellido = this.txbApellido.Text;
                nuevoProfe.Nombre = this.txbNombre.Text;
                nuevoProfe.Dni = this.txbDni.Text;
                nuevoProfe.EMail = this.txbEmail.Text;
                nuevoProfe.Telefono = this.txbTelefono.Text;
                nuevoProfe.Calle = this.txbCalle.Text;
                nuevoProfe.Altura = this.txbAltura.Text;
                nuevoProfe.Area = this.txbArea.Text;

                List<string> props = new List<string> { nuevoProfe.Apellido, nuevoProfe.Nombre, nuevoProfe.Dni, nuevoProfe.EMail, nuevoProfe.Telefono, nuevoProfe.Calle, nuevoProfe.Altura, nuevoProfe.Area };

                //--------------------------------------------------------
                bool validados = true;

                foreach (string prop in props)
                {
                    if (prop == string.Empty)
                    {
                        validados = false;

                        string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                        string tituloError1 = "Editar Perfil Profesor";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                        break;
                    }
                }


                this.txbApellido.Text = nuevoProfe.Apellido;
                this.txbNombre.Text = nuevoProfe.Nombre;
                this.txbDni.Text = nuevoProfe.Dni;
                this.txbEmail.Text = nuevoProfe.EMail;
                this.txbTelefono.Text = nuevoProfe.Telefono;
                this.txbCalle.Text = nuevoProfe.Calle;
                this.txbAltura.Text = nuevoProfe.Altura;
                this.txbArea.Text = nuevoProfe.Area;

                if (validados)
                {
                    try
                    {
                        if (nuevoProfe.ActualizarEnBD())
                        {

                            string mensaje1 = "Perfil actualizado correctamente.";
                            string titulo1 = "Editar Perfil Profesor";
                            DialogResult result1 = MessageBox.Show(mensaje1, titulo1);
                            listaPadre.ActualizarLista();
                            this.Hide();
                            this.Close();
                        }

                    }
                    catch
                    {
                        string mensaje2 = $"Error en los registros. Inténtelo nuevamente.";
                        string titulo2 = "Editar Perfil Profesor";
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
