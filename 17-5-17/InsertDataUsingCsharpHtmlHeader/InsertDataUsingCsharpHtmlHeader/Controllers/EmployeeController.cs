using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsertDataUsingCsharpHtmlHeader.Models;

namespace InsertDataUsingCsharpHtmlHeader.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            ViewBag.Departments = GetAllDepartmentList();
            return View();
        }

        public ActionResult Save()
        {
            return View()
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            ViewBag.Departments = GetAllDepartmentList();
            return View();
        }

        public List<Department> GetAllDepartmentList()
        {
            return new List<Department>()
            {
                new Department(){ Code = "HR", Name = "Human Resource"},
                new Department(){ Code = "IT", Name = "Information Tecnology"},
                new Department(){ Code = "AI", Name = "Artificial Inteligence"}
            };
        }
	}
}