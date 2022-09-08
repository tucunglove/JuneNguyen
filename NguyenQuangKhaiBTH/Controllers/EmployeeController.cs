using Microsoft.AspNetCore.Mvc;
using NguyenQuangKhaiBTH.Models;

namespace NguyenQuangKhaiBTH.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string EmployeeID, string EmployeeName, string EmployeeAge)
        {
            // ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            ViewBag.mess = "Mã nhân viên: " + EmployeeID + " ; " + "  Tên nhân viên: " + EmployeeName + " ; " + "Tuổi: " + EmployeeAge;
            return View();
        }
    }

}