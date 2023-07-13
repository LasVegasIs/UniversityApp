using System.Collections.Generic;
using System.Linq;
using UniversityApp.BL.Abstract;
using UniversityApp.BL.Models;
using UniversityApp.DAL.Abstract;
using UniversityApp.DAL.Models;

namespace UniversityApp.BL.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _studentRepository;
        private readonly IPdfGenerationService _pdfGenerationService;

        public TeacherService(ITeacherRepository studentRepository, IPdfGenerationService pdfGenerationService)
        {
            _studentRepository = studentRepository;
            _pdfGenerationService = pdfGenerationService;
        }

        public List<TeacherReportDto> GetTeachersReport()
        {
            var teacherReports = _studentRepository.GetTeachersWithStudentCount();

            List<TeacherReportDto> teacherReportsDtos = MapToDto(teacherReports);

            return teacherReportsDtos;
        }

        public byte[] GenerateTeachersPdfReport()
        {
            var teacherReport = GetTeachersReport();

            return _pdfGenerationService.GenerateStudentsPdfReport(teacherReport);
        }

        private List<TeacherReportDto> MapToDto(List<TeacherReport> students)
        {
            return students.Select(s => new TeacherReportDto { IdTeacher = s.IdTeacher, Fio = s.Fio, StudentsCount = s.StudentsCount }).ToList();
        }
    }
}
