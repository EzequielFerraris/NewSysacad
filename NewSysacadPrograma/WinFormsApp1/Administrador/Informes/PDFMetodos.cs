using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysacadFront
{
    static public class PDFMetodos
    {
        public static iText.Layout.Document CrearPdf(PdfDocument pdf, string titulo, string cuerpo, Table tabla)
        {
            var doc = new iText.Layout.Document(pdf, iText.Kernel.Geom.PageSize.A4);
            doc.SetMargins(25, 50, 50, 25);

            Paragraph p0 =
                       new Paragraph(titulo)
                                .SetFontSize(20)
                                .SetMargins(0, 0, 0, 0)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                                .SetTextAlignment(TextAlignment.CENTER);

            doc.Add(p0);

            Paragraph p1 =
                       new Paragraph(cuerpo)
                                .SetFontSize(12)
                                .SetMargins(50, 50, 0, 50)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                .SetTextAlignment(TextAlignment.JUSTIFIED);


            doc.Add(p1);

            if (tabla.GetNumberOfRows() > 0)
            {
                tabla.SetMargins(50, 50, 0, 50);
                doc.Add(tabla);
            }

            return doc;
        }
        static public Table TablaPDFdesdeDGV(DataGridView dgv, float[] anchoColumnas, int porcentaje)
        {
            // Columnas y filas del dataGrid
            int cantidadFilas = dgv.Rows.Count;
            int cantidadColumnas = dgv.Columns.Count;

            // Settear la tabla
            Table table = new Table(anchoColumnas);
            table.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(porcentaje));

            // Pasar el header del dgv a la tabla
            for (int i = 0; i < cantidadColumnas; i++)
            {
                Cell headerCeldas = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

                //headerCells.SetNextRenderer(new RoundedCornersCellRenderer(headerCells));
                var getCell = headerCeldas.Add(new Paragraph(dgv.Columns[i].HeaderText));
                table.AddHeaderCell(getCell);
            }

            // Pasar las celdas del dgv a la tabla
            for (int i = 0; i < cantidadFilas; i++)
            {
                for (int c = 0; c < cantidadColumnas; c++)
                {
                    Cell cells = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

                    var gteCell = cells.Add(new Paragraph(dgv.Rows[i].Cells[dgv.Columns[c].HeaderText].Value.ToString()));
                    table.AddCell(gteCell);
                }
            }
            return table;
        }

    }
}
