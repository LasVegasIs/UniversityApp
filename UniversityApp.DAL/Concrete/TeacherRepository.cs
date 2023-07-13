using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniversityApp.DAL.Abstract;
using UniversityApp.DAL.Models;

namespace UniversityApp.DAL.Concrete
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly UniveristyContext _dbContext;
        public TeacherRepository(UniveristyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TeacherReport> GetTeachersWithStudentCount()
        {
            string query = @"
            SELECT st.IdTeacher, t.Fio, COUNT(*) as studentsCount
            FROM [UniversityDB].[dbo].[Student_Teacher_Subject] st
            LEFT JOIN dbo.Teachers t ON t.Id = st.IdTeacher 
            GROUP BY st.IdTeacher, t.Fio";

            var teacherReports = _dbContext.TeacherReports.FromSqlRaw(query).ToList();

            return teacherReports;
        }
    }
}
