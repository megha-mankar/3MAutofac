using AutfacDemo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacDemo.Frontend.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _iEmployee;
        public EmployeeController(IEmployee iEmployee)
        {
            this._iEmployee = iEmployee;
        }

        // GET: Employee
        public ActionResult Index()
        {
           var employee = _iEmployee.GetEmployee(1);

            return View();
        }
    }
}