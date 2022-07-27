using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCfirstproject.Models;

namespace MVCfirstproject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET:Employee
        public ActionResult Employeeinfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 216648,
                Employeename = "Bhanupriya G",
                Employeelocation = "Bangalure"
            };
            return View(employee);
        }

    }
}
