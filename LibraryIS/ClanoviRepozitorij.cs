using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS
{
    public class ClanoviRepozitorij
    {
        public string GenerirajKorisnickoIme(Clan clan)
        {
            if (clan == null)
            {
                throw new ArgumentNullException("Član ne može biti null!");
            }

            if (clan.Ime == "" || clan.Prezime == "")
            {
                return "";
            }

            int maxDuljina = 8;
            int minDuljina = 6;
            string korisnickoIme = "";
            korisnickoIme += clan.Ime.Substring(0, 1);
            korisnickoIme += clan.Prezime;

            if (korisnickoIme.Length > maxDuljina)
            {
                korisnickoIme = korisnickoIme.Substring(0, maxDuljina);
            }
            else if (korisnickoIme.Length < minDuljina)
            {
                int brojZnakovaKojiFale = minDuljina - korisnickoIme.Length;
                Random r = new Random();
                for (int i = 0; i < brojZnakovaKojiFale; i++)
                {
                    korisnickoIme += r.Next(0, 9);
                }
            }
            return korisnickoIme.ToLower();

        }
    }
}
