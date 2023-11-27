using BibliotecaNewSysacad;
using System;
using System.Collections;
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
    public partial class FrmProfesor : Form
    {
        private FrmListaProfesores listaPadre;
        private Profesor profesorObj;
        private Administrador admin;
        public FrmProfesor(Profesor profe, FrmListaProfesores lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            profesorObj = profe;
            lblNombre.Text = $"{profe.Apellido}, {profe.Nombre}";
            lblLegajo.Text = profe.Legajo.ToString();
            lblMail.Text = profe.EMail;
            lblDni.Text = profe.Dni;
            lblDireccion.Text = $"{profe.Calle}, {profe.Altura}";
            lblTelefono.Text = profe.Telefono;
            lblArea.Text = profe.Area;
            dgvAsignaciones.DataSource = admin.ObtenerCursosAsignados(profesorObj);

            listaPadre = lista;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

            FrmEditarProfesor nuevaEdicion = new FrmEditarProfesor(profesorObj, listaPadre, admin);
            nuevaEdicion.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string mensaje = "¿Está seguro que quiere ELIMINAR este perfil?";
            string titulo = "Eliminar profesor";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {

                if (profesorObj.EliminarDeBD())
                {
                    string mensaje1 = "Perfil eliminado.";
                    string titulo1 = "Eliminar";
                    DialogResult result1 = MessageBox.Show(mensaje1, titulo1);


                    listaPadre.ActualizarLista();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    string mensaje2 = $"Pefil inexistente. Reinicie el programa para ver los cambios.";
                    string titulo2 = "Eliminar";
                    DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                }

            }
        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            FrmAsignarCurso asignar = new FrmAsignarCurso(profesorObj, listaPadre, admin);
            asignar.Show();
        }
    }
}
