using Microsoft.AspNetCore.Mvc;
using EmployeeTask.Models;

namespace EmployeeTask.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmployeeInfo()
        {
            Employee emp = new Employee();
            emp = emp.GetEmployee();
            return View(emp);
        }
        public IActionResult AllEmployeeInfo()
        {
            List<Employee> empList = Employee.GetAllEmployee();
            return View(empList);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
