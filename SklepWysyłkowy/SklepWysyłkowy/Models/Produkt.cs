using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Produkt
    {
        public int IDKlienta { get; set; }
        public String NazwaProduktu { get; set; }
        public int IDKategorii { get; set; }

        public class ProduktDBContext : DbContext
        {
            public ProduktDBContext()
            { }
            public DbSet<Produkt> Produkty { get; set; }
        }
    }
}