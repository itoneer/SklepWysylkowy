using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Kategoria
    {
        public int IDKategorii { get; set; }
        public String NazwaKategorii { get; set; }

        public class KategoriaDBContext : DbContext
        {
            public KategoriaDBContext()
            { }
            public DbSet<Kategoria> Kategorie { get; set; }
        }
    }
}