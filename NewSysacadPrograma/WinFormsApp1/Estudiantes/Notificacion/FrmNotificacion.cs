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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NewSysacadFront
{
    public partial class FrmNotificacion : Form
    {
        private Notificacion notificacion;
        private Estudiante usuario;
        private FrmListaNotificaciones listaPadre;
        private FrmHomeEstudiante homeEstudiante;

        public FrmNotificacion(Notificacion notificacion, Estudiante usuario, FrmListaNotificaciones listaPadre, FrmHomeEstudiante homeEstudiante)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.listaPadre = listaPadre;
            this.homeEstudiante = homeEstudiante;
            this.notificacion = notificacion;
            this.txbTitulo.Text = notificacion.Titulo;
            this.txbDescripcion.Text = notificacion.Cuerpo;
            this.homeEstudiante = homeEstudiante;
        }

        private void btnMarcarLeida_Click(object sender, EventArgs e)
        {
            usuario.RegistrarLecturaNotificacion(notificacion);
            listaPadre.ActualizarListas();
            homeEstudiante.CampanaNotificaciones();

        }
    }
}
