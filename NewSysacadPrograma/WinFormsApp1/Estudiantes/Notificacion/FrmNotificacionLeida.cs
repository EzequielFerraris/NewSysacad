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
    public partial class FrmNotificacionLeida : Form
    {
        private Notificacion notificacion;

        public FrmNotificacionLeida(Notificacion notificacion)
        {
            InitializeComponent();
            this.notificacion = notificacion;
            this.txbTitulo.Text = this.notificacion.Titulo;
            this.txbDescripcion.Text = this.notificacion.Cuerpo;

        }



    }
}
