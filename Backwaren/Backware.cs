using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backwaren
{

    class Backware
    {
        public string Bezeichnung { get; set; }
        public decimal Preis { get; set; }
        public int Kalorien { get; set; }

        public Backware(string bezeichnung, decimal preis, int kal)
        {
            Bezeichnung = bezeichnung;
            Preis = preis;
            Kalorien = kal;
        }
    }
}
