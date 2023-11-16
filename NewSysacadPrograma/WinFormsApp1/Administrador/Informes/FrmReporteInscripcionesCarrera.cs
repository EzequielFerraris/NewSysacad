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
    public partial class FrmReporteInscripcionesCarrera : Form
    {
        private Administrador admin;
        public FrmReporteInscripcionesCarrera(Administrador admin, Carrera carrera, DateTime inicio, DateTime final)
        {
            InitializeComponent();
            this.admin = admin;
            this.lblCarrera.Text = Enumerables.CarreraAString(carrera);
            this.lblFechaInicio.Text = inicio.ToShortDateString();
            this.lblFechaFinal.Text = final.ToShortDateString();
            this.lblAlumnosTotales.Text = admin.ObtenerNumeroInscripcionesCarrera(carrera).ToString();
            this.lblInscriptos.Text = admin.ObtenerInscripcionesCarreraPeriodo(inicio, final, carrera).ToString();
            this.dgvInscripciones.DataSource = admin.ListaInscriptosCarreraPeriodo(inicio, final, carrera);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            string titulo = this.lblTitulo.Text;
            string cuerpo = this.lbl1.Text + "    " + this.lblCarrera.Text + '\n';
            cuerpo += this.lbl2.Text + "    " + this.lblFechaInicio.Text + '\n';
            cuerpo += this.lbl3.Text + "    " + this.lblFechaFinal.Text + '\n';
            cuerpo += this.lbl4.Text + "    " + this.lblAlumnosTotales.Text + '\n';
            cuerpo += this.lbl5.Text + "    " + this.lblInscriptos.Text + '\n';

            Table tablaDatos = PDFMetodos.TablaPDFdesdeDGV(this.dgvInscripciones, new float[] { 1, 1, 1, 1 }, 100);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + "inscriptosCarrera" + ".pdf";

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
