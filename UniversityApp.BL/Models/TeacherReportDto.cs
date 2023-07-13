using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.BL.Models
{
    public class TeacherReportDto
    {
        public int IdTeacher { get; set; }
        public string Fio { get; set; }
        public int StudentsCount { get; set; }
    }
}
