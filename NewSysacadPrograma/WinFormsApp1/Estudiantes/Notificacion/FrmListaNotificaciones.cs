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
    public partial class FrmListaNotificaciones : Form

    {
        public List<FrmNotificacion> notificacionesNoLeidas;
        public List<FrmNotificacionLeida> notificacionesLeidas;

        private Estudiante usuario;
        FrmHomeEstudiante home;
        public FrmListaNotificaciones(Estudiante usuario, FrmHomeEstudiante home)
        {
            InitializeComponent();
            this.home = home;
            notificacionesNoLeidas = new List<FrmNotificacion>();
            notificacionesLeidas = new List<FrmNotificacionLeida>();

            this.usuario = usuario;

            ActualizarListas();
        }

        public void ActualizarListas()
        {
            notificacionesNoLeidas.Clear();
            notificacionesLeidas.Clear();
            pnlListaNotificaciones.Controls.Clear();

            ActualizarListasLocales();

            notificacionesLeidas.Reverse();
            notificacionesNoLeidas.Reverse();

            foreach (FrmNotificacionLeida notiLeida in notificacionesLeidas)
            {
                notiLeida.TopLevel = false;
                pnlListaNotificaciones.Controls.Add(notiLeida);
                notiLeida.Dock = DockStyle.Top;
                notiLeida.Show();
            }

            foreach (FrmNotificacion notiNoLeida in notificacionesNoLeidas)
            {
                notiNoLeida.TopLevel = false;
                pnlListaNotificaciones.Controls.Add(notiNoLeida);
                notiNoLeida.Dock = DockStyle.Top;
                notiNoLeida.Show();
            }
        
        }

        private void ActualizarListasLocales()
        {
            List<int> notificacionesLeidasID = usuario.ObtenerNotificacionesLeidas();

            foreach (Notificacion notificacion in usuario.ObtenerNotificaciones())
            {
                if (!notificacionesLeidasID.Contains(notificacion.Id))
                {
                    FrmNotificacion notificacionPendiente = new FrmNotificacion(notificacion, usuario, this, home);
                    notificacionesNoLeidas.Add(notificacionPendiente);

                }
                else
                {
                    FrmNotificacionLeida notificacionLeida = new FrmNotificacionLeida(notificacion);
                    notificacionesLeidas.Add(notificacionLeida);
                }
            }
        }

        
          
    }

    
    

}
