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
    public partial class FrmCurso : Form
    {
        private FrmListaDeCursos listaPadre;
        private Curso cursoObj;
        private Administrador admin;
        public FrmCurso(Curso curso, FrmListaDeCursos lista, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            cursoObj = curso;
            lblNombre.Text = cursoObj.Nombre;
            lblCodigo.Text = $"{cursoObj.Codigo}";
            lblCupo.Text = $"{cursoObj.CantidadInscriptos()}/{curso.CupoMaximo}";
            txbDescripcion.Text = cursoObj.Descripcion;
            lblDia.Text = cursoObj.DiaCursada.ToString();
            lblTurno.Text = cursoObj.TurnoCursada.ToString();
            lblCarrera.Text = cursoObj.Carrera.ToString();
            listaPadre = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarCurso nuevaEdicion = new FrmEditarCurso(cursoObj, listaPadre, admin);
            nuevaEdicion.Show();
            nuevaEdicion.TurnoCambiado += NotificarCambioCursoTurno;
            nuevaEdicion.DiaCambiado += NotificarCambioCursoDia;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere ELIMINAR este curso?";
            string titulo = "Eliminar curso";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {

                if (cursoObj.EliminarDeBD())
                {
                    string mensaje1 = "Curso eliminado.";
                    string titulo1 = "Eliminar";
                    DialogResult result1 = MessageBox.Show(mensaje1, titulo1);


                    listaPadre.ActualizarLista();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    string mensaje2 = $"Curso inexistente. Reinicie el programa para ver los cambios.";
                    string titulo2 = "Eliminar";
                    DialogResult result2 = MessageBox.Show(mensaje2, titulo2);
                }

            }
        }

        
        public void NotificarCambioCursoTurno(Curso curso, InfoCursoEventArgs e)
        {
            string titulo = $"Cambio en el TURNO de {curso.Nombre}.";
            string cuerpo = $"El TURNO para el curso {curso.Nombre}, ha sido modificado a {curso.TurnoCursada} el {DateTime.Now}.\nSi este cambio lo afecta, comuníquese con Administración." +
                $"\nSaludos,\n" + "Administración UTNFRA.";
            Carrera carrera = curso.Carrera;
            DateTime fecha = DateTime.Now;

            Notificacion notificacion = new Notificacion();

            notificacion.Titulo = titulo;
            notificacion.Cuerpo = cuerpo;
            notificacion.Carrera = carrera;
            notificacion.FechaCreacion = fecha;

            notificacion.AgregarABD(out string error);

        }
       
        public void NotificarCambioCursoDia(Curso curso, InfoCursoEventArgs e)
        {
            string titulo = $"Cambio en el DIA de {curso.Nombre}.";
            string cuerpo = $"El DIA para el curso {curso.Nombre}, ha sido modificado a {curso.DiaCursada} el {DateTime.Now}.\nSi este cambio lo afecta, comuníquese con Administración.\nSaludos,\n"
                + "Administración UTNFRA.";
            Carrera carrera = curso.Carrera;
            DateTime fecha = DateTime.Now;

            Notificacion notificacion = new Notificacion();

            notificacion.Titulo = titulo;
            notificacion.Cuerpo = cuerpo;
            notificacion.Carrera = carrera;
            notificacion.FechaCreacion = fecha;

            notificacion.AgregarABD(out string error);
        }
        
    }
}
