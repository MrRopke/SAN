using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAdd.Model
{
    public class Løsninger
    {
        public int Lid { get; set; }
        public string Overskrift { get; set; }
        public string Brødtekst { get; set; }
        public string Gruppe { get; set; }
        public string Forfatter { get; set; }
        public int AntalLikes { get; set; }
        public int FordeleKommentarer { get; set; }
        public int UlempeKommentarer { get; set; }
        public DateTimeOffset Dato { get; set; }
        public int Bid { get; set; }
    }
}
