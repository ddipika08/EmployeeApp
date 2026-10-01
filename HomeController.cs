using Microsoft.AspNetCore.Mvc;
using EmployeeExtensionApp.Models;
using EmployeeExtensionApp.Extensions;

namespace EmployeeExtensionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Dhandhukiya Dipika",
                Department = "CE",
                Salary = 45000
            };

            // Using the extension method
            string employeeInfo = employee.GetEmployeeInfo();

            ViewBag.EmployeeInfo = employeeInfo;

            return View(employee);
        }
    }
}