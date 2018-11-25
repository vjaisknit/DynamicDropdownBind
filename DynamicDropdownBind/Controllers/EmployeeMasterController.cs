using DynamicDropdownBind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDropdownBind.Controllers
{
    public class EmployeeMasterController : Controller
    {
        DatabaseContext _db = new DatabaseContext();
        // GET: EmployeeMaster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            EmployeeDTO empDtp = new EmployeeDTO()
            {
                CountryList = _db.Countrys.ToList()
            };
            return View(empDtp);
        }
            
    }
}
    
