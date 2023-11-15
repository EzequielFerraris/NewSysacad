using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            QuestPDF.Fluent.Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("Informe")
                        .SemiBold()
                        .FontSize(30);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(Placeholders.LoremIpsum());
                        }
                        );

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {  
                                  x.Span("Pagina ");
                                  x.CurrentPageNumber();
                                  x.AlignRight();
                        });
                });
            }).GeneratePdf();
        }
    }
}