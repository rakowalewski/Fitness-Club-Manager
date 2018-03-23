using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Basic
{
    public class Trening
    {
        public int IdTrening { get; set; }
        public int IdTrener { get; set; }
        public int IdKlient { get; set; }
        public DateTime DataGodzRozp { get; set; }
        public DateTime DataGodzZak { get; set; }
        public bool CzyZakonczono { get; set; }
        public int Kwota { get; set; }
    }
}
