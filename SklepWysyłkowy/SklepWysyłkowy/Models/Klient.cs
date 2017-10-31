using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Klient
    {
        public int IDKlienta { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String AdresKlienta { get; set; }
        public int IDMiasta { get; set; }

        public class KlientDBContext : DbContext
        {
            public KlientDBContext()
            { }
            public DbSet<Klient> Klienci { get; set; }
        }
    }
}