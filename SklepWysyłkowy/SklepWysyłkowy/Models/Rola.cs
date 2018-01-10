using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Rola
    {
        public int IDRoli { get; set; }
        public String NazwaRoli { get; set; }

        public class RolaDBContext : DbContext
        {
            public RolaDBContext()
            { }
            public DbSet<Rola> Role { get; set; }
        }
    }
}