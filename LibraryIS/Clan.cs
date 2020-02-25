using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS
{
    public class Clan
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public Clan(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
