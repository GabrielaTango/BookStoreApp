using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using Document = QuestPDF.Fluent.Document;
using IContainer = QuestPDF.Infrastructure.IContainer;
using QuestPDF.Companion;
using QuestPDF.Elements;
using System.Xml.Linq;

namespace BL
{
    public class ComprobantePDFGenerator
    {
        
        public static void GenerarComprobantePDF(Comprobante comprobante, List<ComprobanteDetalle> detalles, string outputPath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header().Element(GenerarEncabezado(comprobante));
                    page.Content().Element(GenerarDetalle(detalles));
                    page.Footer().Element(GenerarFooter(comprobante));
                    
                });
            }).ShowInCompanionAsync(); //GeneratePdf(outputPath);
        }

        private static Action<IContainer> GenerarFooter(Comprobante c) => container =>
        {
            container.Column(col =>
            {
                col.Item().AlignRight().Text($"TOTAL: ${c.Total:N2}").Bold();
                col.Item().PaddingVertical(10).LineHorizontal(1);
                col.Item().Text($"CAE {c.CAE}{c.VTO?.ToString("dd-MM-yyyy")}").Bold().FontSize(12);



            });
        };

        private static Action<IContainer> GenerarEncabezado(Comprobante c) => container =>
        {
            container.Column(col =>
            {
                col.Item().Text($"COMPROBANTE TIPO {c.TipoComprobante}").Bold().FontSize(16);
                col.Item().Text($"Nº: {c.NumeroComprobante}");
                col.Item().Text($"Fecha: {c.Fecha:dd/MM/yyyy}");
                col.Item().Text($"Cliente ID: {c.ClienteId}");
                col.Item().PaddingVertical(10).LineHorizontal(1);
            });
        };

        private static Action<IContainer> GenerarDetalle(List<ComprobanteDetalle> detalles) => container =>
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(60);  // Cantidad
                    columns.RelativeColumn();  // Cantidad
                    columns.RelativeColumn();    // Precio Unitario
                    columns.RelativeColumn();    // Subtotal
                });

                table.Header(header =>
                {
                    header.Cell().Text("Cantidad").Bold();
                    header.Cell().Text("Decripcion").Bold();
                    header.Cell().Text("Precio Unitario").Bold();
                    header.Cell().Text("Subtotal").Bold();
                });

                foreach (var d in detalles)
                {
                    table.Cell().Text(d.Cantidad.ToString());
                    table.Cell().Text(d.Descripcion.ToString());
                    table.Cell().Text($"${d.PrecioUnitario:N2}");
                    table.Cell().Text($"${d.Subtotal:N2}");
                }
            });
        };
    }
}