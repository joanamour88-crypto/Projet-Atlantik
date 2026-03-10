using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Atlantik
{
    public partial class AfficheTraversee : Form
    {
        public AfficheTraversee()
        {
            InitializeComponent();
        }

        private void AfficheTraversee_Load(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                // Affichage liste de secteur /////////////////////////////////////////////////

                string requêtesect = "SELECT nosecteur, nom FROM secteur";
                MySqlCommand maCdesect = new MySqlCommand(requêtesect, maCo);
                MySqlDataReader jeuEnregistrementssect = maCdesect.ExecuteReader();

                while (jeuEnregistrementssect.Read())
                {
                    int idsect = Convert.ToInt32(jeuEnregistrementssect["nosecteur"]);
                    string nomsect = jeuEnregistrementssect["nom"].ToString();

                    Secteur s = new Secteur(idsect, nomsect);

                    Lstsect.Items.Add(s);
                }
                jeuEnregistrementssect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }

            LvTraversee.View = View.Details;
            LvTraversee.GridLines = true;
            LvTraversee.FullRowSelect = true;

            LvTraversee.Columns.Add("N°", 50);
            LvTraversee.Columns.Add("Heure", 70);
            LvTraversee.Columns.Add("Bateau", 70);
            LvTraversee.Columns.Add("A" + "\n" + " Passager", 100);
            LvTraversee.Columns.Add("B" + "\n" + " Véh.inf.2m", 100);
            LvTraversee.Columns.Add("C Véh.sup.2m", 100);
        }

        private void Lstsect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                int idSecteur = ((Secteur)Lstsect.SelectedItem).GetNoSecteur();
                string requêteliai = "SELECT noliaison, p.NOM, po.NOM as \"pNOM\" FROM liaison l INNER JOIN port p ON (l.NOPORT_DEPART = p.NOPORT) INNER JOIN port po ON (l.NOPORT_ARRIVEE = po.NOPORT) WHERE nosecteur = @idsect ";
                MySqlCommand maCdeliai = new MySqlCommand(requêteliai, maCo);
                maCdeliai.Parameters.AddWithValue("@idsect", idSecteur);
                MySqlDataReader jeuEnregistrementsliai = maCdeliai.ExecuteReader();
                Cbxliaison.Items.Clear();
                while (jeuEnregistrementsliai.Read())
                {
                    int noliaison = Convert.ToInt32(jeuEnregistrementsliai["noliaison"]);
                    string nomportdep = jeuEnregistrementsliai["NOM"].ToString();
                    string nomportarr = jeuEnregistrementsliai["pNOM"].ToString();
                    Liaison l = new Liaison(noliaison, nomportdep, nomportarr);
                    Cbxliaison.Items.Add(l);
                }
                jeuEnregistrementsliai.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }

        private void Btnafftraverse_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                Liaison recupnoliaison = (Liaison)Cbxliaison.SelectedItem;
                int noliaison = recupnoliaison.GetNoLiaison();

                MySqlCommand maCde;
                string requête = "SELECT notraversee FROM traversee WHERE noliaison = @noliaison";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@noliaison", noliaison);

                MySqlDataReader jeuEnregistrementslab = maCde.ExecuteReader();

                var TabItem = new string[6];
                ListViewItem unItem;

                while (jeuEnregistrementslab.Read())
                {
                    TabItem[0] = jeuEnregistrementslab["notraversee"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }

        private void LvTraversee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
