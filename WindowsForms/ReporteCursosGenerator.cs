using Entities;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Collections.Generic;

namespace WindowsForms
{
    public class ReporteCursosGenerator
    {
        public void CreatePDFReport(string filePath, List<CursoDto>? cursos)
        {
            try
            {
                // Verificar si la carpeta existe, si no, crearla
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory); // Crear la carpeta si no existe
                }

                // Crear un documento iTextSharp
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);

                // Crear un escritor de PDF para el archivo
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Abrir el documento para escribir
                document.Open();

                // Agregar un título
                var titleFont = FontFactory.GetFont("Arial", 16);
                document.Add(new Paragraph("Reporte de Cursos", titleFont));

                // Agregar una línea vacía
                document.Add(new Paragraph("\n"));

                // Crear una tabla con encabezados
                PdfPTable table = new PdfPTable(4); // Cuatro columnas: Materia, Comision, Año, Cupos
                table.WidthPercentage = 100;

                // Encabezados de la tabla
                AddCellToHeader(table, "Materia");
                AddCellToHeader(table, "Comisión");
                AddCellToHeader(table, "Año");
                AddCellToHeader(table, "Cupos");

                // Ajustar el ancho de las columnas de acuerdo a la longitud
                table.SetWidths(new float[] { 4f, 3f, 1f, 1f }); // Ajuste para 4 columnas, Año y Cupos más estrechos

                // Agregar los datos a la tabla
                foreach (var curso in cursos)
                {
                    string materiaConcatenada = $"{curso.Especialidad ?? "N/A"} - {curso.Plan ?? "N/A"} - {curso.Materia ?? "N/A"}";
                    AddCellToBody(table, materiaConcatenada);
                    AddCellToBody(table, curso.Comision ?? "N/A");
                    AddCellToBody(table, curso.anio_calendario.ToString());
                    AddCellToBody(table, curso.cupo.ToString());
                }

                // Agregar la tabla al documento
                document.Add(table);

                // Agregar un pie de página
                var footerFont = FontFactory.GetFont("Arial", 10);
                document.Add(new Paragraph("\nGenerado el " + DateTime.Now.ToString("dd/MM/yyyy"), footerFont));

                // Cerrar el documento
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCellToHeader(PdfPTable table, string text)
        {
            var font = FontFactory.GetFont("Arial", 12, BaseColor.WHITE);
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                BackgroundColor = BaseColor.DARK_GRAY,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
            table.AddCell(cell);
        }

        private void AddCellToBody(PdfPTable table, string text)
        {
            var font = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
            table.AddCell(cell);
        }
    }
}
