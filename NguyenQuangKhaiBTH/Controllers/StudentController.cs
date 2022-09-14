using Microsoft.AspNetCore.Mvc;
using NguyenQuangKhaiBTH.Models;

namespace NguyenQuangKhaiBTH.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // khoi tao 1 list student 
            List<Student> stdList = new List<Student>()
            {
                new Student{StudentID = 1, StudentName="Nguyen Quang Khai", StudentAge = 19},
                new Student{StudentID = 2, StudentName="Nguyen Quang Kha", StudentAge = 19},
                new Student{StudentID = 3, StudentName="Nguyen Quang Khoi", StudentAge = 19},
                new Student{StudentID = 4, StudentName="Nguyen Quang Khi", StudentAge = 19},
                new Student{StudentID = 5, StudentName="Nguyen Quang Khiu", StudentAge = 19}

            };
            ViewData["Student"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        //     public IActionResult Index(string StudentID, string StudentName, string StudentAge)
        //     {
        //         // ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
        //         ViewBag.mess = "Mã sinh viên: " + StudentID + " ; " + "  Tên sinh viên: " + StudentName + " ; " + "Tuổi: " + StudentAge;
        //         return View();
        //     }
        // }

        public IActionResult Create(Student std)
        {
            string message = std.StudentID + "-";
            message += std.StudentName + "-";
            message += std.StudentAge;
            ViewBag.TT = message;
            return View();
        }
    }
}