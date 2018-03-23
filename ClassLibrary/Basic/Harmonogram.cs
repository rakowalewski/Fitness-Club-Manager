using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Basic
{
    public class Harmonogram
    {
        public int IdHarmonogramu { get; set; }
        public int IdDzien { get; set; }
        public int IdTrener { get; set; }
        public string GodzinaRozpoczecia { get; set; }
        public string GodzinaZakonczenia { get; set; }
    }
}
