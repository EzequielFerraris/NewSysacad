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
    public partial class FrmHomeAdministrador : Form
    {

        public List<FrmAgregarEstudiante> formulariosEstudiantes;
        public List<FrmAgregarCurso> formulariosCursos;
        public FrmListaDeCursos listaDeCursos;
        
        public FrmHomeAdministrador(string nombreAdmin)
        {

            InitializeComponent();
            EstadoMenusPorDefecto();
            formulariosEstudiantes = new List<FrmAgregarEstudiante>();
            formulariosCursos = new List<FrmAgregarCurso>();
            lbNombreAdmin.Text = nombreAdmin;
            listaDeCursos = new FrmListaDeCursos();
            listaDeCursos.TopLevel = false;
            pnlDisplay.Controls.Add(listaDeCursos);

        }

        private void EstadoMenusPorDefecto()
        {
            pnlSubMenuGE.Visible = false;
        }

        private void EsconderSubMenus()
        {
            if (pnlSubMenuGE.Visible == true)
            {
                pnlSubMenuGE.Visible = false;
            }

        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            EsconderSubMenus(); //Esconde los submenus
            listaDeCursos.Hide(); //Esconde la lista de cursos
            if (formulariosCursos.Count() > 0) //Esconde los formularios de cursos si los hay
            {
                var cargarForm = formulariosCursos.Last();
                cargarForm.Hide();
            }

            if (formulariosEstudiantes.Count() == 0)
            {
                FrmAgregarEstudiante nuevoEstudiante = new FrmAgregarEstudiante();
                nuevoEstudiante.TopLevel = false;
                pnlDisplay.Controls.Add(nuevoEstudiante);
                nuevoEstudiante.Show();
                formulariosEstudiantes.Add(nuevoEstudiante);
            }
            else
            {
                var cargarForm = formulariosEstudiantes.Last();
                if (cargarForm.agregado)
                {
                    formulariosEstudiantes.Remove(cargarForm);
                    cargarForm.Close();
                    FrmAgregarEstudiante nuevoEstudiante = new FrmAgregarEstudiante();
                    nuevoEstudiante.TopLevel = false;
                    pnlDisplay.Controls.Add(nuevoEstudiante);
                    nuevoEstudiante.Show();
                    formulariosEstudiantes.Add(nuevoEstudiante);
                }
                else
                {
                    cargarForm.Show();
                }

            }

        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            if (formulariosEstudiantes.Count() > 0)
            {
                var cargarForm = formulariosEstudiantes.Last();
                cargarForm.Hide();
                MostrarSubMenu(pnlSubMenuGE);
            }
            listaDeCursos.ActualizarLista();
            listaDeCursos.Show();

        }



        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            listaDeCursos.Hide();
            EsconderSubMenus();
            if (formulariosCursos.Count() == 0)
            {
                FrmAgregarCurso nuevoCurso = new FrmAgregarCurso();
                nuevoCurso.TopLevel = false;
                pnlDisplay.Controls.Add(nuevoCurso);
                nuevoCurso.Show();
                formulariosCursos.Add(nuevoCurso);
            }
            else
            {
                var cargarForm = formulariosCursos.Last();
                if (cargarForm.agregado)
                {
                    formulariosCursos.Remove(cargarForm);
                    cargarForm.Close();
                    FrmAgregarCurso nuevoCurso = new FrmAgregarCurso();
                    nuevoCurso.TopLevel = false;
                    pnlDisplay.Controls.Add(nuevoCurso);
                    nuevoCurso.Show();
                    formulariosCursos.Add(nuevoCurso);
                }
                else
                {
                    cargarForm.Show();
                }

            }
        }

        //SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere salir?";
            string titulo = "Salir";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
