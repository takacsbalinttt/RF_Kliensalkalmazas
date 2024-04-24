using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiSample
{
    public class Termek
    {
        public int id;
        //public string nev;
        public int keszlet;
        public string inventory_id;
        public string nev { get; set; }

        public bool TartalmazSpeciálisKaraktereket()
        {
            string pattern = @"[!@#$%^&*()_+={}\[\]:;""'<>,.?\\/|`~-]";
            return Regex.IsMatch(nev, pattern);
        }

    }


}
