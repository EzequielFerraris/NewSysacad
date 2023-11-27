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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewSysacadFront
{
    public partial class FrmPreferenciasUsuario : Form

    {
        private Estudiante usuario;
        FrmHomeEstudiante home;
        public FrmPreferenciasUsuario(Estudiante usuario, FrmHomeEstudiante home)
        {
            InitializeComponent();
            this.home = home;

            this.usuario = usuario;
            chbxNotificaciones.Checked = usuario.RecibirNotificaciones;
            chbxMails.Checked = usuario.RecibirMail;
            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.RecibirNotificaciones = chbxNotificaciones.Checked;
            usuario.RecibirMail = chbxMails.Checked;  

            string mensaje = "¿Está seguro que quiere guardar estas preferencias?";
            string titulo = "Confirmar Preferencias";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {
                usuario.ActualizarEnBD();
                home.ListaNotificaciones.ActualizarListas();
                home.CampanaNotificaciones();
                string tituloMensaje = "Actualizar Preferencias";
                string correcto = "Información actualizada correctamente";
                DialogResult resultado = MessageBox.Show(correcto, tituloMensaje);
            }
        }
    }

}
