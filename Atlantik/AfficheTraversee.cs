using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        private int GetQuantiteEnregistree(int notraversee, string lettrecategorie)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            maCo.Open();
            try
            {
                string requête = "SELECT sum(quantitereservee) FROM reservation r INNER JOIN enregistrer e ON (e.noreservation = r.noreservation) WHERE r.notraversee = @notraversee and e.lettrecategorie = @lettrecategorie";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);

                maCde.Parameters.AddWithValue("@notraversee", notraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);

                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                jeuEnregistrements.Read();

                if (jeuEnregistrements["sum(quantitereservee)"] == DBNull.Value)
                {
                    return 0;
                }
                else
                {
                    int quantitereservee = Convert.ToInt32(jeuEnregistrements["sum(quantitereservee)"]);
                    return quantitereservee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                maCo.Close();
            }

        }

        private int GetCapaciteMaximale(int notraversee, string lettrecategorie)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            maCo.Open();
            try
            {
                string requête = "SELECT capacitemax FROM contenir c INNER JOIN traversee t ON (c.nobateau = t.nobateau) WHERE t.notraversee = @notraversee and c.lettrecategorie = @lettrecategorie";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@notraversee", notraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();

                jeuEnregistrements.Read();

                int quantitereservee = Convert.ToInt32(jeuEnregistrements["capacitemax"].ToString());

                return quantitereservee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                maCo.Close();
            }
        }

/*
        private List<Categories> GetLesCategories()
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            maCo.Open();
            try
            {
                List<Categories> LesCategories = new List<Categories>();
                foreach (Categories c in LesCategories)
                {
                    string requete = "SELECT * FROM categorie";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();

                    while (jeuEnregistrements != null)
                    {
                        string lettreCategorie = (string)jeuEnregistrements["lettrecategorie"];
                        string libelle = (string)jeuEnregistrements["libelle"];
                        Categories cat = new Categories(lettreCategorie, libelle);
                        LesCategories.Add(cat);
                    }
                    jeuEnregistrements.Close();
                }
                return LesCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                List<Categories> LesCategories = new List<Categories>();
                return LesCategories;
            }
            finally
            {
                maCo.Close();
            }
        }
*/
/*
        private List<Traversees> GetLesTraverseesBateaux(int noliaison, string datetraversee)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            maCo.Open();
            try
            {
                List<Traversees> lestraversees = new List<Traversees>();
                foreach (Traversees t in lestraversees)
                {
                    string requete = "Select notraversee, nom, dateheuredepart from traversee t inner join bateau b on (t.nobateau = b.nobateau) where noliaison = @noliaison and dateheuredepart = @dateheuredepart;";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@noliaison", noliaison);
                    maCde.Parameters.AddWithValue("@dateheuredepart", datetraversee);
                    MySqlDataReader jeuEnregistrements;
                    jeuEnregistrements = maCde.ExecuteReader();
                    while (jeuEnregistrements.Read())
                    {
                        int notraverse = (int)jeuEnregistrements["notraversee"];
                        string nom = (string)jeuEnregistrements["nom"];
                        string dateheuredepart = (string)jeuEnregistrements["dateheuredepart"];
                        Traversees trav = new Traversees(notraverse, nom, dateheuredepart);
                        lestraversees.Add(trav);
                    }
                    jeuEnregistrements.Close();
                }
                return lestraversees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                List<Traversees> lestraversees = new List<Traversees>();
                return lestraversees;
            }
            finally
            {
                maCo.Close();
            }
        }
*/
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
                    //MessageBox.Show("ici c'est ok 1 !");

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
            
            
            
     
        }

        private void Lstsect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                int idSecteur = ((Secteur)Lstsect.SelectedItem).GetNoSecteur();
                string requêteliai = "SELECT noliaison, p.NOM, po.NOM as pNOM FROM liaison l INNER JOIN port p ON (l.NOPORT_DEPART = p.NOPORT) INNER JOIN port po ON (l.NOPORT_ARRIVEE = po.NOPORT) WHERE nosecteur = @idsect ";
                MySqlCommand maCdeliai = new MySqlCommand(requêteliai, maCo);
                maCdeliai.Parameters.AddWithValue("@idsect", idSecteur);
                MySqlDataReader jeuEnregistrementsliai = maCdeliai.ExecuteReader();
                Cbxliaison.Items.Clear();
                while (jeuEnregistrementsliai.Read())
                {
                    //MessageBox.Show("ici c'est ok 2 !");

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
            /////// récupération de NoLiaison ///////////////////////////
            Liaison recupnoliaison = (Liaison)Cbxliaison.SelectedItem;
            int noliaison = recupnoliaison.GetNoLiaison();
            /////// récupération de la date /////////////////////////////
            string date = (Dtpdate.Text).ToString();
            date = ("%" +  date + "%");

            List<Categories> LesCategories = new List<Categories>();
            List<LettreCategorie> LetCat = new List<LettreCategorie>();
            List<Traversees> lestraversees = new List<Traversees>();

            LvTraversee.Items.Clear();
            LvTraversee.Columns.Clear();

            LvTraversee.View = View.Details;
            LvTraversee.GridLines = true;
            LvTraversee.FullRowSelect = true;

            LvTraversee.Columns.Add("N°", 50);
            LvTraversee.Columns.Add("Heure", 70);
            LvTraversee.Columns.Add("Bateau", 70);


            ///////////////// categorie ///////////////////////

            maCo.Open();
            try
            {
                string requete = "SELECT * FROM categorie";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                

                while (jeuEnregistrements.Read())
                {
                    //MessageBox.Show("ici c'est ok 3 !");
                    string lettreCategorie = (string)jeuEnregistrements["lettrecategorie"];
                    string libelle = (string)jeuEnregistrements["libelle"];
                    Categories cat = new Categories(lettreCategorie,libelle);
                    LettreCategorie letcat = new LettreCategorie(lettreCategorie);
                    LesCategories.Add(cat);
                    LetCat.Add(letcat);
                }
                jeuEnregistrements.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }

            ///// Ajout dynamiquement des lettres catégories et des libelles /////////////

            foreach (Categories liste in LesCategories)
            {
                LvTraversee.Columns.Add(liste.ToString(), 100);
            }

            ///////////////// traversee /////////////////////// 
            maCo.Open();
            try
            {

                string requete = "Select notraversee, nom, dateheuredepart from traversee t inner join bateau b on (t.nobateau = b.nobateau) where noliaison = @noliaison and dateheuredepart like @heure";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@noliaison", noliaison);
                maCde.Parameters.AddWithValue("@heure", date);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    //MessageBox.Show("ici c'est ok 4 !");

                    int notraverse = (int)jeuEnregistrements["notraversee"];
                    string nom = (string)jeuEnregistrements["nom"];
                    string dateheuredepart = (jeuEnregistrements["dateheuredepart"]).ToString();
                    Traversees trav = new Traversees(notraverse, nom, dateheuredepart);
                    lestraversees.Add(trav);
                }
                jeuEnregistrements.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }

            ///////////////// resultat ///////////////////////
            try
            {
                maCo.Open();

                string requête = "SELECT notraversee, b.nom as NOM, DATE_FORMAT(DATEHEUREDEPART, '%H:%i') as HEURE FROM traversee t INNER JOIN bateau b ON(t.nobateau = b.nobateau) WHERE noliaison = @noliaison and t.dateheuredepart like @date";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);

                maCde.Parameters.AddWithValue("@noliaison", noliaison);
                maCde.Parameters.AddWithValue("@date", date);

                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();

                var TabItem = new string[6];
                //int notrav = Convert.ToInt32(jeuEnregistrements["notraversee"]);
                while (jeuEnregistrements.Read())
                {
                    int notrav = Convert.ToInt32(jeuEnregistrements["notraversee"]);
                    //string letcat = jeuEnregistrements["c.lettrecategorie"].ToString();
                    foreach (Traversees liste in lestraversees)
                    {
                        TabItem[0] = jeuEnregistrements["notraversee"].ToString();
                        TabItem[1] = jeuEnregistrements["HEURE"].ToString();
                        TabItem[2] = jeuEnregistrements["NOM"].ToString();
                        int compteur = 3;
                        foreach (LettreCategorie lstcate in LetCat)
                        {
                            TabItem[compteur] = (GetCapaciteMaximale(notrav, lstcate.ToString()) - GetQuantiteEnregistree(notrav, lstcate.ToString())).ToString();
                            compteur++;
                        }
                        break;
                    }
                    LvTraversee.Items.Add(new ListViewItem(TabItem));
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
