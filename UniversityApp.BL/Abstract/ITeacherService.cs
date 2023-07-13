using System.Collections.Generic;
using UniversityApp.BL.Models;

namespace UniversityApp.BL.Abstract
{
    public interface ITeacherService
    {
        List<TeacherReportDto> GetTeachersReport();
        byte[] GenerateTeachersPdfReport();
    }
}
