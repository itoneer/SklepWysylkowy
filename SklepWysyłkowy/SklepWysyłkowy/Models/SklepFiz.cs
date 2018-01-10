using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class SklepFiz
    {
        public int IDSklepu { get; set; }
        public String NazwaSklepu { get; set; }
        public String AdresSklepu { get; set; }
        public int IDMiasta { get; set; }

        public class SklepFizDBContext : DbContext
        {
            public KlientDBContext()
            { }
            public DbSet<SklepFiz> Sklepy { get; set; }
        }
    }
}