using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicDropdownBind.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Country> Countrys { get; set; }
    }
}