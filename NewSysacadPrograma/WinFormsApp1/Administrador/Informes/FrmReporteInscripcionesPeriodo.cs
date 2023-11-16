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
using System.IO;
using iText;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System.Diagnostics;
using iText.Layout.Element;

namespace NewSysacadFront
{
    public partial class FrmReporteInscripcionesPeriodo : Form
    {
        public FrmReporteInscripcionesPeriodo(Administrador admin, DateTime inicio, DateTime fin)
        {
            InitializeComponent();

            int inscriptos = admin.ObtenerNumeroInscripcionesPeriodo(inicio, fin);

            this.lblFechaInicio.Text = inicio.ToShortDateString();
            this.lblFechaFinal.Text = fin.ToShortDateString();
            this.lblCantidadInscriptos.Text = inscriptos.ToString();
            this.dgvInscripciones.DataSource = admin.CompletarListaInscripcionesPeriodo(inicio, fin);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {

            string titulo = this.lblTitulo.Text;
            string cuerpo = this.lbl1.Text + "    " + this.lblFechaInicio.Text + '\n';
            cuerpo += this.lbl2.Text + "    " + this.lblFechaFinal.Text + '\n';
            cuerpo += this.lbl3.Text + "    " + this.lblCantidadInscriptos.Text + '\n';

            Table tablaDatos = PDFMetodos.TablaPDFdesdeDGV(this.dgvInscripciones, new float[] { 1, 1, 1, 1 }, 100);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + "inscriptosPorPeriodo" + ".pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = guardar.FileName;
                string path = System.IO.Path.GetFullPath(guardar.FileName);
                var exportar = System.IO.Path.Combine(path, nombreArchivo);

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
