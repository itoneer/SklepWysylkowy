using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Zamowienie
    {
        public int IDZamowienia { get; set; }
        public int IDKlienta { get; set; }
        public int IDProduktu { get; set; }
        public DateTime DataZamowienia { get; set; }
        public int IDStatusu { get; set; }

        public class ZamowDBContext : DbContext
        {
            public ZamowDBContext()
            { }
            public DbSet<Zamowienie> Zamowienia { get; set; }
        }

    }
}