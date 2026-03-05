using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Port
    {
        private int noport;
        private string nomport;

        public Port(int noport, string nomport)
        {
            this.noport = noport;
            this.nomport = nomport;
        }

        public int GetNoPort()
        {
            return noport;
        }

        public string GetNomPort()
        {
            return nomport;
        }

        public override string ToString()
        {
            return nomport;
        }
    }
}
