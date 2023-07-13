using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Collections.Generic;
using System.IO;
using UniversityApp.BL.Abstract;
using UniversityApp.BL.Models;

namespace UniversityApp.BL.Services
{
    public class PdfGenerationService : IPdfGenerationService
    {
        public byte[] GenerateStudentsPdfReport(List<TeacherReportDto> teacherReports)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(ms);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                foreach (var teacherReport in teacherReports)
                {
                    document.Add(new Paragraph($"Teacher ID: {teacherReport.IdTeacher}"));
                    document.Add(new Paragraph($"FIO: {teacherReport.Fio}"));
                    document.Add(new Paragraph($"Students count: {teacherReport.StudentsCount}"));
                    document.Add(new Paragraph(""));
                }

                document.Close();

                return ms.ToArray();
            }
        }
    }
}
