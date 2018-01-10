using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Miasto
    {
        public int IDMiasta { get; set; }
        public String NazwaMiasta { get; set; }

        public class MiastoDBContext : DbContext
        {
            public MiastoDBContext()
            { }
            public DbSet<Miasto> Miasta { get; set; }
        }
    }
}