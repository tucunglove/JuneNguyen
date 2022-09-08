using Microsoft.AspNetCore.Mvc;
using NguyenQuangKhaiBTH.Models;

namespace NguyenQuangKhaiBTH.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string PersonID, string PersonName, string PersonAge)
        {
            // ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            ViewBag.mess = "Mã người dùng: " + PersonID + " ; " + "  Tên người dùng: " + PersonName + " ; " + "Tuổi: " + PersonAge;
            return View();
        }
    }

}