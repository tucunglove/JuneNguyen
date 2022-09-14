using Microsoft.AspNetCore.Mvc;
using NguyenQuangKhaiBTH.Models;

namespace NguyenQuangKhaiBTH.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            // khoi tao 1 list Employee 
            List<Employee> stdList = new List<Employee>()
            {
                new Employee{EmployeeID = 1, EmployeeName="Nguyen Quang Khai", EmployeeAge = 19},
                new Employee{EmployeeID = 2, EmployeeName="Nguyen Quang Kha", EmployeeAge = 19},
                new Employee{EmployeeID = 3, EmployeeName="Nguyen Quang Khoi", EmployeeAge = 19},
                new Employee{EmployeeID = 4, EmployeeName="Nguyen Quang Khi", EmployeeAge = 19},
                new Employee{EmployeeID = 5, EmployeeName="Nguyen Quang Khiu", EmployeeAge = 19}

            };
            ViewData["Employee"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        //     public IActionResult Index(string EmployeeID, string EmployeeName, string EmployeeAge)
        //     {
        //         // ViewBag.mess = std.EmployeeID + "-" + std.EmployeeName + "-" + std.EmployeeAge;
        //         ViewBag.mess = "Mã sinh viên: " + EmployeeID + " ; " + "  Tên sinh viên: " + EmployeeName + " ; " + "Tuổi: " + EmployeeAge;
        //         return View();
        //     }
        // }

        public IActionResult Create(Employee std)
        {
            string message = std.EmployeeID + "-";
            message += std.EmployeeName + "-";
            message += std.EmployeeAge;
            ViewBag.TT = message;
            return View();
        }
    }
}