using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Hurtownia
    {
        public int IDHurtowni { get; set; }
        public String NazwaHurtowni { get; set; }
        public String AdresHurtowni { get; set; }
        public int IDMiasta { get; set; }

        public class KlientDBContext : DbContext
        {
            public HurtowniaDBContext()
            { }
            public DbSet<Hurotwnia> Hurtownie { get; set; }
        }
    }
}