using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Client
    {
        private int noclient;

        public Client(int noclient)
        {
            this.noclient = noclient;
        }

        public int getnoclient()
        {
            return noclient;
        }
    }
}
