﻿using BibliotecaNewSysacad;
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
    public partial class FrmHomeEstudiante : Form
    {
        public Estudiante usuario;
        public FrmListaCursosEstudiante listaDeCursos;
        public FrmHorario horarioAlumno;
        private FrmPagosPendientes pagosPendientes;
        private FrmPagosRealizados realizados;
        private FrmListaNotificaciones listaNotificaciones;
        private FrmPreferenciasUsuario preferencias;

        public FrmListaNotificaciones ListaNotificaciones { get => listaNotificaciones; set => listaNotificaciones = value; }

        public FrmHomeEstudiante(string nombreUsuarioEstudiante)
        {
            InitializeComponent();
            EstadoMenusPorDefecto();

            usuario = NewSysacad.ObtenerEstudiante(nombreUsuarioEstudiante);

            lbNombreEstudiante.Text = $"Usuario: {usuario.NombreUsuario} \n";

            listaDeCursos = new FrmListaCursosEstudiante(usuario);
            listaDeCursos.TopLevel = false;
            pnlDisplay.Controls.Add(listaDeCursos);

            horarioAlumno = new FrmHorario(usuario);
            horarioAlumno.TopLevel = false;
            pnlDisplay.Controls.Add(horarioAlumno);
            horarioAlumno.Hide();

            pagosPendientes = new FrmPagosPendientes(usuario);
            pagosPendientes.TopLevel = false;
            pnlDisplay.Controls.Add(pagosPendientes);
            pagosPendientes.Hide();

            realizados = new FrmPagosRealizados(usuario);
            realizados.TopLevel = false;
            pnlDisplay.Controls.Add(realizados);
            realizados.Hide();

            ListaNotificaciones = new FrmListaNotificaciones(usuario, this);
            ListaNotificaciones.TopLevel = false;
            pnlDisplay.Controls.Add(ListaNotificaciones);
            ListaNotificaciones.Hide();

            preferencias = new FrmPreferenciasUsuario(usuario, this);
            preferencias.TopLevel = false;
            pnlDisplay.Controls.Add(preferencias);
            preferencias.Hide();

            CampanaNotificaciones();

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

        private void btnInscripcionCursos_Click(object sender, EventArgs e)
        {
            horarioAlumno.Hide();
            listaDeCursos.ActualizarLista();
            EsconderSubMenus();
            pagosPendientes.Hide();
            realizados.Hide();
            ListaNotificaciones.Hide();
            preferencias.Hide();
            listaDeCursos.Show();
        }

        private void btnConsultarHorario_Click(object sender, EventArgs e)
        {
            listaDeCursos.Hide();
            EsconderSubMenus();
            pagosPendientes.Hide();
            realizados.Hide();
            ListaNotificaciones.Hide();
            preferencias.Hide();
            horarioAlumno.ActualizarHorario();
            horarioAlumno.Show();
        }

        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuGE);
        }

        private void btnPagosPendientes_Click(object sender, EventArgs e)
        {
            horarioAlumno.Hide();
            listaDeCursos.Hide();
            realizados.Hide();
            ListaNotificaciones.Hide();
            preferencias.Hide();
            pagosPendientes.ActualizarLista();
            pagosPendientes.Show();
            EsconderSubMenus();


        }
        private void btnPagosRealizados_Click(object sender, EventArgs e)
        {
            horarioAlumno.Hide();
            listaDeCursos.Hide();
            pagosPendientes.Hide();
            ListaNotificaciones.Hide();
            preferencias.Hide();
            realizados.ActualizarLista();
            realizados.Show();
            EsconderSubMenus();
        }

        private void pbxNotificaciones_Click(object sender, EventArgs e)
        {

            horarioAlumno.Hide();
            listaDeCursos.Hide();
            pagosPendientes.Hide();
            realizados.Hide();
            preferencias.Hide();
            ListaNotificaciones.Show();
            EsconderSubMenus();
        }

        public void CampanaNotificaciones()
        {
            if (ListaNotificaciones.notificacionesNoLeidas.Count() > 0)
            {
                this.pbxNotificaciones.Image = Properties.Resources.notificationPending;
                this.pbxNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                this.pbxNotificaciones.Image = Properties.Resources.notificationClear;
                this.pbxNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPreferencias_Click(object sender, EventArgs e)
        {
            horarioAlumno.Hide();
            listaDeCursos.Hide();
            pagosPendientes.Hide();
            realizados.Hide();
            ListaNotificaciones.Hide();
            EsconderSubMenus();

            preferencias.Show();
        }
    }


}


