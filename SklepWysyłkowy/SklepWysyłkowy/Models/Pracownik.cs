using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepWysyłkowy.Models
{
    public class Pracownik
    {
        public int IDPracownika { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int IDRoli { get; set; }
		public int IDSklepu { get; set; }
		public int Pensja { get; set; }

        public class PracownikDBContext : DbContext
        {
            public PracownikDBContext()
            { }
            public DbSet<Pracownik> Pracownicy { get; set; }
        }
    }
}