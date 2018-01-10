using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class StatusZamow
    {
        public int IDStatusu { get; set; }
        public String NazwaStatusu { get; set; }

        public class StatusZamowDBContext : DbContext
        {
            public StatusZamowDBContext()
            { }
            public DbSet<StatusZamow> Statusy { get; set; }
        }
    }
}