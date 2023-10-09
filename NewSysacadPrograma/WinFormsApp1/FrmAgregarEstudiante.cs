using BCrypt.Net;
using BibliotecaNewSysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewSysacadFront
{
    public partial class FrmAgregarEstudiante : Form
    {
        public bool agregado = false;
        public FrmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string mensaje = "¿Está seguro que quiere registrar este estudiante?";
            string titulo = "Confirmar inscripcion";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {
                //VALIDACIONES
                Estudiante nuevoEstudiante = new Estudiante();

                nuevoEstudiante.Nombre = this.txbNombre.Text;
                nuevoEstudiante.Apellido = this.txbApellido.Text;
                nuevoEstudiante.NombreUsuario = this.txbNombreUsuario.Text;
                nuevoEstudiante.EMail = this.txEmail.Text;
                nuevoEstudiante.Dni = this.txbDni.Text;
                nuevoEstudiante.Calle = this.txbCalle.Text;
                nuevoEstudiante.Altura = this.txbAltura.Text;
                nuevoEstudiante.Telefono = this.txbTelefono.Text;
                nuevoEstudiante.DebeCambiarPassword = this.cbxCambiarPassword.Checked;

                List<string> props = new List<string> { nuevoEstudiante.Nombre, nuevoEstudiante.Apellido, nuevoEstudiante.NombreUsuario,
                                                        nuevoEstudiante.EMail, nuevoEstudiante.Dni, nuevoEstudiante.Calle, 
                                                        nuevoEstudiante.Altura, nuevoEstudiante.Telefono };
                
                bool validados = true;
                
                foreach (string prop in props)
                {
                    if(prop == string.Empty)
                    {

                        this.txbNombre.Text = nuevoEstudiante.Nombre;
                        this.txbApellido.Text = nuevoEstudiante.Apellido;
                        this.txbNombreUsuario.Text = nuevoEstudiante.NombreUsuario;
                        this.txEmail.Text = nuevoEstudiante.EMail;
                        this.txbDni.Text = nuevoEstudiante.Dni;
                        this.txbCalle.Text = nuevoEstudiante.Calle;
                        this.txbAltura.Text = nuevoEstudiante.Altura;
                        this.txbTelefono.Text = nuevoEstudiante.Telefono;

                        validados = false;

                        string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                        string tituloError1 = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                        break;
                    }
                }

                if (validados) 
                {
                    //ASIGNAMOS EL DNI COMO PASSWORD LA PRIMERA VEZ
                    nuevoEstudiante.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(nuevoEstudiante.Dni, 13);
                    
                    try
                    {
                        if (NewSysacad.AgregarEstudiante(nuevoEstudiante, out string error))
                        {
                            string mensajeConfirmacion = "Estudiante agregado correctamente.";
                            string tituloConfirmacion = "Inscripción";
                            DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion);
                            agregado = true;
                            this.Close();
                        }
                        else
                        {
                            string mensajeError = $"Error en el registro. {error} ya registrado.";
                            string tituloError = "Inscripción";
                            DialogResult confirmacion = MessageBox.Show(mensajeError, tituloError);
                        }
                    }
                    catch
                    {
                        string mensajeError1 = $"Error en los datos ingresados. Intente nuevamente";
                        string tituloError1 = "Inscripción";
                        DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                    }
                }
                
            }
               
        }
            
    }
    
}
