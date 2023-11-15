using BibliotecaNewSysacad;
using iText.Kernel.Pdf;
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
    public partial class FrmReporteIngresos : Form
    {
        Administrador admin;
        public FrmReporteIngresos(Administrador admin, DateTime inicio, DateTime final, string categoria)
        {
            InitializeComponent();
            this.admin = admin;
            this.lblFechaInicio.Text = inicio.ToShortDateString();
            this.lblFechaFinal.Text = final.ToShortDateString();
            this.lblConcepto.Text = categoria;
            if (categoria == "Ingresos totales")
            {
                lblMontoTotal.Text = '$' + admin.ObtenerSumaMontoTotal(inicio, final).ToString();
                this.dgvPagos.DataSource = admin.ObtenerPagosPeriodo(inicio, final);
            }
            else
            {
                lblMontoTotal.Text = '$' + admin.ObtenerSumaMonto(inicio, final, categoria).ToString();
                this.dgvPagos.DataSource = admin.ObtenerPagosPorCategoria(inicio, final, categoria);
            }


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
            cuerpo += this.lbl3.Text + "    " + this.lblConcepto.Text + '\n';
            cuerpo += this.lbl4.Text + "    " + this.lblMontoTotal.Text + '\n';

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + "ingresos" + ".pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = guardar.FileName;
                string path = Path.GetFullPath(guardar.FileName);
                var exportar = Path.Combine(path, nombreArchivo);

                using (var writer = new PdfWriter(exportar))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var doc = InformesConsultas.CrearPdf(pdf, titulo, cuerpo);

                    }
                }
            }
        }
    }
}
