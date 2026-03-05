using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Periode
    {
        private int noperiode;
        private string datedebut;
        private string datearrivee;

        public Periode(int noperiode, string datedebut, string datearrivee)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datearrivee = datearrivee;
        }

        public int GetNoPeriode()
        {
            return noperiode;
        }
        public override string ToString()
        {
            return datedebut + "  -  " + datearrivee;
        }
    }
}
