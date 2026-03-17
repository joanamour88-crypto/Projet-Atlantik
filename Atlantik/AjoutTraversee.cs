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

namespace Atlantik
{
    public partial class AjoutTraversee : Form
    {
        public AjoutTraversee()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                int idSecteur = ((Secteur)lbxsecteurs.SelectedItem).GetNoSecteur();
                string requêteliai = "SELECT noliaison, p.NOM, po.NOM as \"pNOM\" FROM liaison l INNER JOIN port p ON (l.NOPORT_DEPART = p.NOPORT) INNER JOIN port po ON (l.NOPORT_ARRIVEE = po.NOPORT) WHERE nosecteur = @idsect ";
                MySqlCommand maCdeliai = new MySqlCommand(requêteliai, maCo);
                maCdeliai.Parameters.AddWithValue("@idsect", idSecteur);
                MySqlDataReader jeuEnregistrementsliai = maCdeliai.ExecuteReader();
                cmbliaison.Items.Clear();
                while (jeuEnregistrementsliai.Read())
                {
                    int noliaison = Convert.ToInt32(jeuEnregistrementsliai["noliaison"]);
                    string nomportdep = jeuEnregistrementsliai["NOM"].ToString();
                    string nomportarr = jeuEnregistrementsliai["pNOM"].ToString();
                    Liaison l = new Liaison(noliaison, nomportdep, nomportarr);
                    cmbliaison.Items.Add(l);
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

        private void AjoutTraversee_Load(object sender, EventArgs e)
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

                    lbxsecteurs.Items.Add(s);
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

            // Affichage Nom bateau dans combobox ///////////////////////////////////////////////////////////

            try
            {
                maCo.Open();
                string requêtelab = "SELECT * FROM bateau";
                MySqlCommand maCdelab = new MySqlCommand(requêtelab, maCo);
                MySqlDataReader jeuEnregistrementslab = maCdelab.ExecuteReader();

                while (jeuEnregistrementslab.Read())
                {
                    string nombateau = jeuEnregistrementslab["nom"].ToString();
                    int nobateau = Convert.ToInt32(jeuEnregistrementslab["nobateau"]);
                    Bateau bat = new Bateau(nobateau, nombateau);
                    cmbnombateau.Items.Add(bat);
                }
                jeuEnregistrementslab.Close();
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

        private void Btnajout_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                if(cmbliaison.SelectedItem == null || cmbnombateau.SelectedItem == null || lbxsecteurs.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez renseigner toutes les données nécessaires !");
                }
                else
                {
                    MySqlCommand maCde;
                    Liaison recupnoliaison = (Liaison)cmbliaison.SelectedItem;
                    Bateau recupnobateau = (Bateau)cmbnombateau.SelectedItem;

                    int noliaison = recupnoliaison.GetNoLiaison();
                    int nobateau = recupnobateau.GetNoBateau();

                    DateTime datheurdepart = datedepart.Value;
                    DateTime datheurarrivee = dateparrivee.Value;

                    string requête = "INSERT INTO traversee(noliaison, nobateau, dateheuredepart, dateheurearrivee) VALUES (@noliaison, @nobateau, @datheudep, @datheuarr)";
                    maCde = new MySqlCommand(requête, maCo);

                    maCde.Parameters.AddWithValue("@noliaison", noliaison);
                    maCde.Parameters.AddWithValue("@nobateau", nobateau);
                    maCde.Parameters.AddWithValue("@datheudep", datheurdepart);
                    maCde.Parameters.AddWithValue("@datheuarr", datheurarrivee);

                    int nb = maCde.ExecuteNonQuery();

                    MessageBox.Show("Traversée ajouter !");
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

        private void Dtpdepart_ValueChanged(object sender, EventArgs e)
        {
            dateparrivee.MinDate = datedepart.Value;
        }
    }
}
