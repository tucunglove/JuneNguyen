using Microsoft.AspNetCore.Mvc;
using NguyenQuangKhaiBTH.Models;

namespace NguyenQuangKhaiBTH.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string StudentID, string StudentName, string StudentAge)
        {
            // ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            ViewBag.mess = "Mã sinh viên: " + StudentID + " ; " + "  Tên sinh viên: " + StudentName + " ; " + "Tuổi: " + StudentAge;
            return View();
        }
    }

}