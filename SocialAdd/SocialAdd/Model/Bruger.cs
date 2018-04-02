using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAdd.Model
{
    public class Bruger
    {
        public int BrugerId { get; set; }
        public string Brugernavn { get; set; }
        public string Email { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Relation { get; set; }
        public int Alder { get; set; }
        public string BorI { get; set; }

    }
}
