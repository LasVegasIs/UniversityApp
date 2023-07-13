using System;
using System.Collections.Generic;
using UniversityApp.BL.Models;

namespace UniversityApp.BL.Abstract
{
    public interface IPdfGenerationService
    {
        byte[] GenerateStudentsPdfReport(List<TeacherReportDto> students);
    }
}
