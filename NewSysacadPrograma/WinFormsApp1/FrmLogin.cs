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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {

            if (cbxUsuario.Text == "Administrador")
            {
                if (NewSysacad.LoginAdministrador(tbxNombreUsuario.Text, txbPassword.Text))
                {
                    FrmHomeAdministrador home = new FrmHomeAdministrador(tbxNombreUsuario.Text);
                    home.Show();
                    this.Hide();

                }
                else
                {
                    string mensaje = "Usuario o contraseña incorrectos";
                    string titulo = "Error";
                    DialogResult result = MessageBox.Show(mensaje, titulo);

                }

            }
            else 
            {
                if (NewSysacad.LoginEstudiante(tbxNombreUsuario.Text, txbPassword.Text))
                {
                    Estudiante estudiante = NewSysacad.ObtenerEstudiante(tbxNombreUsuario.Text);
                    
                    if (estudiante.DebeCambiarPassword) 
                    {
                        FrmCambiarPassword cambio = new FrmCambiarPassword(estudiante);
                        cambio.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmHomeEstudiante home = new FrmHomeEstudiante(tbxNombreUsuario.Text);
                        home.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    string mensaje = "Usuario o contraseña incorrectos";
                    string titulo = "Error";
                    DialogResult result = MessageBox.Show(mensaje, titulo);

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbxNombreUsuario.Text = "est1";
            this.txbPassword.Text = "1234";
            this.cbxUsuario.SelectedIndex = 0;
        }

        private void btnAdminDefecto_Click(object sender, EventArgs e)
        {
            this.tbxNombreUsuario.Text = "admin";
            this.txbPassword.Text = "1234";
            this.cbxUsuario.SelectedIndex = 1;
        }
    }
}
