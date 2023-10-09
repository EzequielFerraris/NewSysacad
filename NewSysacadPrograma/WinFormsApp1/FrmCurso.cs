﻿using BibliotecaNewSysacad;
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
        public FrmCurso(Curso curso, FrmListaDeCursos lista)
        {
            InitializeComponent();
            cursoObj = curso;
            lblNombre.Text = cursoObj.Nombre;
            lblCodigo.Text = $"{cursoObj.Codigo}";
            lblCupo.Text = $"{cursoObj.CantidadInscriptos()}/{curso.CupoMaximo}";
            lblDescripcion.Text = cursoObj.Descripcion;
            lblDia.Text = cursoObj.DiaCursada.ToString();
            lblTurno.Text = cursoObj.TurnoCursada.ToString();
            listaPadre = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarCurso nuevaEdicion = new FrmEditarCurso(cursoObj, listaPadre);
            nuevaEdicion.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que quiere ELIMINAR este curso?";
            string titulo = "Eliminar curso";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {

                if (NewSysacad.EliminarCurso(cursoObj, out string error))
                {
                    string mensaje1 = "Curso eliminado.";
                    string titulo1 = "Eliminar";
                    DialogResult result1 = MessageBox.Show(mensaje, titulo);


                    listaPadre.ActualizarLista();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    string mensaje2 = $"{error}";
                    string titulo2 = "Eliminar";
                    DialogResult result2 = MessageBox.Show(mensaje, titulo);
                }

            }
        }

    }
}