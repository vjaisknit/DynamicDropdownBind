using DynamicDropdownBind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDropdownBind.Controllers
{
    public class CountryMasterController : Controller
    {
        DatabaseContext _db = new DatabaseContext();

        public ActionResult CountryList()
        {
            var countryList = _db.Countrys.ToArray();
            return View(countryList);
        }

        [HttpGet]
        public ActionResult CreateCountry()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult CreateCountry(Country country)
        {
            _db.Countrys.Add(country);
            _db.SaveChanges();
            return RedirectToAction("CountryList");
        }

    }
}