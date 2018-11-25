using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDropdownBind.Models
{
    public class EmployeeDTO
    {
        public Employee EmployeeMst { get; set; }
        public List<Country> CountryList { get; set; }

    }
}