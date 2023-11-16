using BibliotecaNewSysacad;
using iText.Kernel.Pdf;
using iText.Layout.Element;
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
    public partial class FrmReporteInscripcionesCurso : Form
    {
        private Administrador admin;
        public FrmReporteInscripcionesCurso(Curso curso, Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.lblCurso.Text = curso.Nombre;
            this.lblCarrera.Text = curso.Carrera.ToString();
            this.lblCantidad.Text = admin.ObtenerNumeroInscripcionesCurso(curso).ToString();
            this.dgvInscripciones.DataSource = admin.CompletarListaInscripcionesCurso(curso);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            string titulo = this.lblTitulo.Text;
            string cuerpo = this.lbl1.Text + "    " + this.lblCurso.Text + '\n';
            cuerpo += this.lbl2.Text + "    " + this.lblCantidad.Text + '\n';
            cuerpo += this.lbl3.Text + "    " + this.lblCarrera.Text + '\n';
            cuerpo += this.lbl4.Text;

            Table tablaDatos = PDFMetodos.TablaPDFdesdeDGV(this.dgvInscripciones, new float[] { 1, 1, 1 }, 100);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + "inscriptosPorCurso" + ".pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = guardar.FileName;
                string path = Path.GetFullPath(guardar.FileName);
                var exportar = Path.Combine(path, nombreArchivo);

                using (var writer = new PdfWriter(exportar))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var doc = PDFMetodos.CrearPdf(pdf, titulo, cuerpo, tablaDatos);

                    }
                }
            }
        }
    }
}
