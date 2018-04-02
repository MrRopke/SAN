using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAdd.Model
{
    public class ProCons
    {
        public int PCId { get; set; }
        public string Overskrift { get; set; }
        public string Kommentar { get; set; }
        public int Likes { get; set; }
        public int LøsningId { get; set; }
        public string ProEllerCon { get; set; }
    }
}
