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
    public partial class FrmHorario : Form
    {
        private Estudiante EstudianteUsuario;
        public FrmHorario(Estudiante usuario)
        {
            InitializeComponent();
            EstudianteUsuario = usuario;
            EstudianteUsuario.ActualizarCursosInscripto();
            ActualizarHorario();
        }

        public void ActualizarHorario()
        {
            foreach (Curso curso in EstudianteUsuario.ObtenerCursosInscripto())
            {
                dia dia = curso.DiaCursada;
                turno turno = curso.TurnoCursada;

                switch (dia)
                {
                    case dia.Lunes:
                        switch (turno)
                        {
                            case turno.Mañana:
                                lbl1_1.Text = curso.Nombre;
                                break;
                            case turno.Tarde:
                                lbl1_2.Text = curso.Nombre;
                                break;
                            case turno.Noche:
                                lbl1_3.Text = curso.Nombre;
                                break;
                        }
                        break;
                    case dia.Martes:
                        switch (turno)
                        {
                            case turno.Mañana:
                                lbl2_1.Text = curso.Nombre;
                                break;
                            case turno.Tarde:
                                lbl2_2.Text = curso.Nombre;
                                break;
                            case turno.Noche:
                                lbl2_3.Text = curso.Nombre;
                                break;
                        }
                        break;
                    case dia.Miércoles:
                        switch (turno)
                        {
                            case turno.Mañana:
                                lbl3_1.Text = curso.Nombre;
                                break;
                            case turno.Tarde:
                                lbl3_2.Text = curso.Nombre;
                                break;
                            case turno.Noche:
                                lbl3_3.Text = curso.Nombre;
                                break;
                        }
                        break;
                    case dia.Jueves:
                        switch (turno)
                        {
                            case turno.Mañana:
                                lbl4_1.Text = curso.Nombre;
                                break;
                            case turno.Tarde:
                                lbl4_2.Text = curso.Nombre;
                                break;
                            case turno.Noche:
                                lbl4_3.Text = curso.Nombre;
                                break;
                        }
                        break;
                    case dia.Viernes:
                        switch (turno)
                        {
                            case turno.Mañana:
                                lbl5_1.Text = curso.Nombre;
                                break;
                            case turno.Tarde:
                                lbl5_2.Text = curso.Nombre;
                                break;
                            case turno.Noche:
                                lbl5_3.Text = curso.Nombre;
                                break;
                        }
                        break;
                }
            }
        }
    }
}
