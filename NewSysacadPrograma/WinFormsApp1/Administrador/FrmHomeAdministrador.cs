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
    public partial class FrmHomeAdministrador : Form
    {
        private FrmListaDeCursos listaDeCursos;
        private Administrador admin;
        private FrmAgregarEstudiante formAgregarEstudiante;
        private FrmAgregarCurso formAgregarCurso;
        private FrmControlReportes frmControlReportes;
        private FrmListaDeRequisitos listaDeRequisitos;
        private FrmCursosConListaDeEspera cursosConListaDeEspera;
        private FrmCrearNotificacion agregarNotificacion;
        private List<Task> listaDeTareas;
        

        public FrmHomeAdministrador(Administrador admin)
        {

            InitializeComponent();
            EstadoMenusPorDefecto();
            this.admin = admin;
            listaDeTareas = new List<Task>();

        

            lbNombreAdmin.Text = admin.Nombre;
            listaDeCursos = new FrmListaDeCursos(admin);
            listaDeCursos.TopLevel = false;
            pnlDisplay.Controls.Add(listaDeCursos);

            frmControlReportes = new FrmControlReportes(admin);
            frmControlReportes.TopLevel = false;
            pnlDisplay.Controls.Add(frmControlReportes);
            frmControlReportes.Hide();

            formAgregarEstudiante = new FrmAgregarEstudiante(admin, listaDeTareas);
            formAgregarEstudiante.TopLevel = false;
            pnlDisplay.Controls.Add(formAgregarEstudiante);
            formAgregarEstudiante.Hide();

            formAgregarCurso = new FrmAgregarCurso(admin);
            formAgregarCurso.TopLevel = false;
            pnlDisplay.Controls.Add(formAgregarCurso);
            formAgregarCurso.Hide();

            listaDeRequisitos = new FrmListaDeRequisitos(admin);
            listaDeRequisitos.TopLevel = false;
            pnlDisplay.Controls.Add(listaDeRequisitos);
            listaDeRequisitos.Hide();

            cursosConListaDeEspera = new FrmCursosConListaDeEspera(admin);
            cursosConListaDeEspera.TopLevel = false;
            pnlDisplay.Controls.Add(cursosConListaDeEspera);
            cursosConListaDeEspera.Hide();

            agregarNotificacion = new FrmCrearNotificacion(admin);
            agregarNotificacion.TopLevel = false;
            pnlDisplay.Controls.Add(agregarNotificacion);
            agregarNotificacion.Hide();

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
            frmControlReportes.Hide();
            formAgregarCurso.Hide();
            listaDeRequisitos.Hide();
            cursosConListaDeEspera.Hide();
            agregarNotificacion.Hide();

            if (formAgregarEstudiante.agregado)
            {
                formAgregarEstudiante = new FrmAgregarEstudiante(admin, listaDeTareas);
                formAgregarEstudiante.TopLevel = false;
                pnlDisplay.Controls.Add(formAgregarEstudiante);
            }

            formAgregarEstudiante.Show();

        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuGE);
            formAgregarEstudiante.Hide();
            frmControlReportes.Hide();
            listaDeRequisitos.Hide();
            cursosConListaDeEspera.Hide();
            listaDeCursos.ActualizarLista();
            agregarNotificacion.Hide();
            listaDeCursos.Show();

        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            listaDeCursos.Hide();
            EsconderSubMenus();

            if (formAgregarCurso.agregado)
            {
                formAgregarCurso = new FrmAgregarCurso(admin);
                formAgregarCurso.TopLevel = false;
                pnlDisplay.Controls.Add(formAgregarCurso);
            }

            formAgregarCurso.Show();

        }

        //REPORTES
        private void btnReportes_Click(object sender, EventArgs e)
        {
            EsconderSubMenus(); //Esconde los submenus
            listaDeCursos.Hide(); //Esconde la lista de cursos
            formAgregarEstudiante.Hide();
            formAgregarCurso.Hide();
            listaDeRequisitos.Hide();
            cursosConListaDeEspera.Hide();
            agregarNotificacion.Hide();
            frmControlReportes.Show();
        }

        private void btnRequisitosAcademicos_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            listaDeCursos.Hide();
            formAgregarEstudiante.Hide();
            formAgregarCurso.Hide();
            frmControlReportes.Hide();
            cursosConListaDeEspera.Hide();
            agregarNotificacion.Hide();
            listaDeRequisitos.ActualizarLista();
            listaDeRequisitos.Show();
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
                bool tareasTerminadas = true;
                foreach (Task tarea in listaDeTareas)
                {
                    if (tarea.Status == TaskStatus.Running)
                    {
                        tareasTerminadas = false;
                        break;
                    }
                }

                if (!tareasTerminadas)
                {
                    string mensaje1 = "Hay acciones que aún no se han terminado de cargar en el sistema y cerrar la aplicación podría dejarlas incompletas. \n ¿Desea salir de todos modos?";
                    string titulo1 = "Salir";
                    MessageBoxButtons botones1 = MessageBoxButtons.YesNo;
                    DialogResult result1 = MessageBox.Show(mensaje1, titulo1, botones1);
                    if (result1 == DialogResult.Yes)
                    {
                        Application.Exit();
                    }

                }
                else
                {
                    Application.Exit();
                }

            }
        }

        private void btnListasEspera_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            listaDeCursos.Hide();
            formAgregarEstudiante.Hide();
            formAgregarCurso.Hide();
            frmControlReportes.Hide();
            listaDeRequisitos.Hide();
            agregarNotificacion.Hide();
            cursosConListaDeEspera.Show();
        }

        private void btnGenerarNotificacion_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            listaDeCursos.Hide();
            formAgregarEstudiante.Hide();
            formAgregarCurso.Hide();
            frmControlReportes.Hide();
            listaDeRequisitos.Hide();
            cursosConListaDeEspera.Hide();
            agregarNotificacion.Show();
        }

        
    }
}
