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
    public partial class FrmCrearNotificacion : Form
    {
        public bool agregado = false;
        private Administrador admin;
        private List<Task> listaTareas;
        public FrmCrearNotificacion(Administrador admin, List<Task> listaTareas)
        {
            InitializeComponent();
            this.admin = admin;
            this.listaTareas = listaTareas;
            cbxCarrera.SelectedIndex = 0;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere registrar esta notificación?";
            string titulo = "Confirmar notificación";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {

                EnviarNotificacion(txbTitulo.Text, txbDescripcion.Text, (Carrera)this.cbxCarrera.SelectedIndex, DateTime.Now);

            }

        }

        public void EnviarNotificacion(string titulo, string cuerpo, Carrera carrera, DateTime fecha)
        {
            Notificacion notificacion = new Notificacion();

            notificacion.Titulo = titulo;
            notificacion.Cuerpo = cuerpo;
            notificacion.Carrera = carrera;
            notificacion.FechaCreacion = fecha;

            if (notificacion.Titulo == string.Empty || notificacion.Cuerpo == string.Empty)
            {
                string mensajeError1 = $"Uno o más de los campos es inválido. Inténtelo nuevamente.";
                string tituloError1 = "Notificaciones";
                DialogResult confirmacion = MessageBox.Show(mensajeError1, tituloError1);

                

            }
            else
            {
                if (notificacion.AgregarABD(out string error))
                {
                    string mensaje1 = "Notificación publicada correctamente.";
                    string titulo1 = "Agregar Notificación";
                    DialogResult result1 = MessageBox.Show(mensaje1, titulo1);
                    notificacion.EnviarMails();
                    /*
                    Task enviarNotificacionPorMail = Task.Run(notificacion.EnviarMails);
                    listaTareas.Add(enviarNotificacionPorMail);
                    */

                }
                else
                {
                    string mensaje2 = $"{error}";
                    string titulo2 = "Agregar Notificación";
                    DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                }
            }
        }

        
    }
}
