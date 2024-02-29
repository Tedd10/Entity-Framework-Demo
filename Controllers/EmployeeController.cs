using EFDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDEMO.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EFDEMOEntities entities = new EFDEMOEntities();

            // Get the list of employees from the database
            List<Employee> employees = entities.Employees.ToList();

            // Pass the list of employees to the view
            return View(employees);

        }
    }
}