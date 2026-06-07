using Microsoft.AspNetCore.Mvc;
using WebGIS46.Models;

namespace WebGIS46.Controllers
{
    public class StudentController : Controller
    {
        StudentBL StudentBL = new StudentBL();
        public IActionResult All()
        {
            List<Student> students = StudentBL.GetAllStudents();

            return View("ShowAll",students);
        }
    }
}
