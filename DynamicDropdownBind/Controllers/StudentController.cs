using DynamicDropdownBind.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDropdownBind.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentMst student)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            return View();
        }
    }
}