using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniversityApp.BL.Abstract;
using UniversityApp.BL.Models;

namespace UniversityApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teachersService;

        public TeachersController(ITeacherService teacherService)
        {
            _teachersService = teacherService;
        }

        [HttpGet("GetTeachersReport/json")]
        public ActionResult<IEnumerable<StudentDto>> GetTeachersReport()
        {
            var report = _teachersService.GetTeachersReport();
            
            if (report == null | report.Count==0)
            {
                return NotFound();
            };

            return Ok(report);
        }

        [HttpGet("GetTeachersReport/pdf")]
        public ActionResult GenerateStudentsPdfReport(int teacherId)
        {
            byte[] pdfDoc = _teachersService.GenerateTeachersPdfReport();

            Response.Headers.Add("Content-Disposition", "inline; filename=students.pdf");

            return File(pdfDoc, "application/pdf");
        }

    }
}
