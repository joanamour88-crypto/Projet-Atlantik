using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Atlantik
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutSecteur ajoutsecteur = new AjoutSecteur();
            ajoutsecteur.ShowDialog();
        }

        private void unPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutPort ajoutport = new AjoutPort();
            ajoutport.ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutLiaison ajoutliaison = new AjoutLiaison();
            ajoutliaison.ShowDialog();
        }

        private void lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutTarifs ajouttarifs = new AjoutTarifs();
            ajouttarifs.ShowDialog();
        }

        private void unBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutBateau ajoutbateau = new AjoutBateau();
            ajoutbateau.ShowDialog();
        }

        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifBateau modifbateau = new ModifBateau();
            modifbateau.ShowDialog();
        }

        private void uneTraverserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutTraversee ajouttraversee = new AjoutTraversee();
            ajouttraversee.ShowDialog();
        }
    }
}
