using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Liaison
    {
        private int noliaison;
        private string portdep;
        private string portarr;

        public Liaison(int noliaison, string portdep, string portarr) 
        {
            this.noliaison = noliaison;
            this.portdep = portdep;
            this.portarr = portarr;
        }

        public int GetNoLiaison()
        {
            return noliaison;
        }

        public override string ToString()
        {
            return noliaison + " - " + portdep + "  -  " + portarr;
        }
    }
}
