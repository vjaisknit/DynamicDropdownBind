using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDropdownBind.Common
{
    public class StudentMst
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="Student Name")]
        [Required]
        public string Name { get; set; }

        public string Class { get; set; }
    }
}