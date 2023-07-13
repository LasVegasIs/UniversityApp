using System.Collections.Generic;
using UniversityApp.DAL.Models;

namespace UniversityApp.DAL.Abstract
{
    public interface ITeacherRepository
    {
        List<TeacherReport> GetTeachersWithStudentCount();
    }
}
