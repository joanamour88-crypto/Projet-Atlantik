using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Secteur
    {
        private int nosecteur;
        private string nomsecteur;

        public Secteur(int nosecteur, string nomsecteur)
        {
            this.nosecteur = nosecteur;
            this.nomsecteur = nomsecteur;
        }

        public int GetNoSecteur()
        {
            return nosecteur;
        }

        public string GetNomSecteur()
        {
            return nomsecteur;
        }

        public override string ToString()
        {
            return nomsecteur;
        }
    }
}
