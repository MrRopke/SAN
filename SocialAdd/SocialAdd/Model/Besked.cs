using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAdd.Model
{
    class Besked
    {
        public int BeskedId { get; set; }
        public string Beskeden { get; set; }
        public string AfsenderNavn { get; set; }
        public int AfsenderId { get; set; }
        public int ModtagerId { get; set; }
    }
}
