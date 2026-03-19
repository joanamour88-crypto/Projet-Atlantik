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
    public partial class AfficheDetailsReservation : Form
    {
        public AfficheDetailsReservation()
        {
            InitializeComponent();
        }

        private void Affichedetailsreservation_Load(object sender, EventArgs e)
        {
             string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            maCo.Open();

            List<int> Noliaison = new List<int>();  

            lvdetailreserv.Items.Clear();
            lvdetailreserv.Columns.Clear();

            lvdetailreserv.View = View.Details;
            lvdetailreserv.GridLines = true;
            lvdetailreserv.FullRowSelect = true;

            lvdetailreserv.Columns.Add("N° Réservation", 100);
            lvdetailreserv.Columns.Add("Liaison", 100);
            lvdetailreserv.Columns.Add("n° Traversee", 100);
            lvdetailreserv.Columns.Add("Date départ", 100);

            try
            {
                string requete = "SELECT nom, prenom FROM client";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    string nom = jeuEnregistrements["nom"].ToString();
                    string prenom = jeuEnregistrements["prenom"].ToString();
                    cmbnomclient.Items.Add(nom + " " + prenom);
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

            //try
            //{
            //    string requete = "SELECT noliaison FROM reservation";
            //    MySqlCommand maCde = new MySqlCommand(requete, maCo);
            //    MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
            //    while (jeuEnregistrements.Read())
            //    {
            //        int liai = Convert.ToInt32(jeuEnregistrements["noliaison"]);
            //        Noliaison.Add(liai);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    maCo.Close();
            //}

        }

        private void Cbxnomclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            string nomprenom = cmbnomclient.SelectedItem.ToString();
            string[] nompren = nomprenom.Split(' ');
            string recupnom = nompren[0];
            string recupprenom = nompren[1];

            List<int> nocli = new List<int>();
            List<Liaison> nomliaison = new List<Liaison>();
            //// recuperation de la liaison /////////////////
            try
            {
                maCo.Open();

                string requêteliai = "SELECT noliaison, p.NOM, po.NOM as pNOM FROM liaison l INNER JOIN port p ON (l.NOPORT_DEPART = p.NOPORT) INNER JOIN port po ON (l.NOPORT_ARRIVEE = po.NOPORT)";
                MySqlCommand maCdeliai = new MySqlCommand(requêteliai, maCo);
                MySqlDataReader jeuEnregistrementsliai = maCdeliai.ExecuteReader();
                while (jeuEnregistrementsliai.Read())
                {
                    int noliaison = Convert.ToInt32(jeuEnregistrementsliai["noliaison"]);
                    string nomportdep = jeuEnregistrementsliai["NOM"].ToString();
                    string nomportarr = jeuEnregistrementsliai["pNOM"].ToString();
                    Liaison l = new Liaison(noliaison, nomportdep, nomportarr);
                    nomliaison.Add(l);
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

            //// recuperation du no client ////////////////////////////////////////////
            try
            {
                maCo.Open();
                string requete = "SELECT noclient FROM client WHERE nom = @nom and prenom = @prenom";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@nom", recupnom);
                maCde.Parameters.AddWithValue("@prenom", recupprenom);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    int idclient = Convert.ToInt32(jeuEnregistrements["noclient"]);
                    nocli.Add(idclient);
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
            /// affichage noreservation, notraversee, dateheuredepart /////
            try
            {
                maCo.Open();
                foreach (int idclient in nocli)
                {
                    string requete2 = "SELECT noreservation, l.noliaison, t.notraversee, t.dateheuredepart FROM reservation r INNER JOIN traversee t ON(r.NOTRAVERSEE = t.NOTRAVERSEE) INNER JOIN liaison l ON(t.NOLIAISON = l.NOLIAISON) WHERE noclient = @idclient";
                    MySqlCommand maCde2 = new MySqlCommand(requete2, maCo);
                    maCde2.Parameters.AddWithValue("@idclient", idclient);
                    MySqlDataReader jeuEnregistrements2 = maCde2.ExecuteReader();
                    var TabItem = new string[4];
                    while (jeuEnregistrements2.Read())
                    {
                        foreach (Liaison l in nomliaison)
                        {
                            if (l.GetNoLiaison() == Convert.ToInt32(jeuEnregistrements2["noliaison"]))
                            {
                                int noreservation = Convert.ToInt32(jeuEnregistrements2["noreservation"]);
                                string noliaison = l.Getliaison();
                                int notraversee = Convert.ToInt32(jeuEnregistrements2["notraversee"]);
                                string dateheuredepart = jeuEnregistrements2["dateheuredepart"].ToString();

                                TabItem[0] = noreservation.ToString();
                                TabItem[1] = noliaison.ToString();
                                TabItem[2] = notraversee.ToString();
                                TabItem[3] = dateheuredepart;
                                lvdetailreserv.Items.Add(new ListViewItem(TabItem));
                            }
                        }
                        //lvdetailreserv.Items.Add(new ListViewItem(TabItem));
                    }
                    //lvdetailreserv.Items.Add(new ListViewItem(TabItem));
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

        private void Lbxdetailreserv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Lvdetailreserv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            maCo.Open();

            if(lvdetailreserv.SelectedItems.Count != 0 )
            {
                string noreservation = lvdetailreserv.SelectedItems[0].Text;

                try
                {
                    Label libelle;
                    Label nbdepers;
                    int i = 1;
                    string requete = "SELECT * FROM enregistrer e INNER JOIN reservation r ON e.noreservation = r.NORESERVATION INNER JOIN type t ON e.LETTRECATEGORIE = t.LETTRECATEGORIE AND e.NOTYPE = t.NOTYPE WHERE r.noreservation = @noreservation";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@noreservation", noreservation);
                    MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                    gbxreservation.Controls.Clear();
                    while (jeuEnregistrements.Read())
                    {
                        string libe = jeuEnregistrements["libelle"].ToString();
                        int nbpers = Convert.ToInt32(jeuEnregistrements["quantitereservee"]);

                        libelle = new Label();
                        libelle.Text = libe;
                        libelle.Location = new Point(5, i * 25);
                        gbxreservation.Controls.Add(libelle);

                        nbdepers = new Label();
                        nbdepers.Text = ":" + nbpers.ToString();
                        nbdepers.Location = new Point(125, i * 25);
                        gbxreservation.Controls.Add(nbdepers);
                        i = i + 1;
                    }
                    Label label = new Label();
                    Label montant = new Label();

                    label.Text = "Montant total";
                    label.Location = new Point(5, i * 25);
                    gbxreservation.Controls.Add(label);

                    string montantt = jeuEnregistrements["montanttotal"].ToString();

                    montant = new Label();
                    montant.Text = ":" + montantt.ToString() + "€";
                    montant.Location = new Point(125, i * 25);
                    gbxreservation.Controls.Add(montant);
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
            }
            
        }
    }
}
