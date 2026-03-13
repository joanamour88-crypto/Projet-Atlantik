using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class LettreCategorie
    {
        private string lettrecategorie;

        public LettreCategorie(string lettrecategorie)
        {
            this.lettrecategorie = lettrecategorie;
        }

        public override string ToString()
        {
            return lettrecategorie;
        }
    }
}
