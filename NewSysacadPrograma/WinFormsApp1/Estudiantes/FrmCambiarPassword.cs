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
    public partial class FrmCambiarPassword : Form
    {
        Estudiante usuario;
        public FrmCambiarPassword(Estudiante estudiante)
        {
            InitializeComponent();
            usuario = estudiante;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txbNuevoPass1.Text == txbNuevoPass2.Text)
            {
                if (txbNuevoPass1.Text.Length > 3)
                {
                    string nuevoPass = BCrypt.Net.BCrypt.EnhancedHashPassword(txbNuevoPass1.Text, 13);
                    usuario.Password = nuevoPass;
                    usuario.DebeCambiarPassword = false;
                    usuario.ActualizarEnBD();

                    FrmHomeEstudiante home = new FrmHomeEstudiante(usuario.NombreUsuario);
                    string mensaje = "Password cambiado exitosamente";
                    string titulo = "Cambiar Password";
                    DialogResult result2 = MessageBox.Show(mensaje, titulo);
                    home.Show();
                    this.Hide();

                }
                else
                {
                    string mensaje1 = "Error. El nuevo password es muy corto.";
                    string titulo1 = "Cambiar Password";
                    DialogResult result2 = MessageBox.Show(mensaje1, titulo1);
                }
            }
            else
            {
                string mensaje2 = "Error. Los passwords no coinciden.";
                string titulo2 = "Cambiar Password";
                DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
            }
        }
    }
}
