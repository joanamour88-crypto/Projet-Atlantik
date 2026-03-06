using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Atlantik
{
    public partial class AjoutTarifs : Form
    {
        public AjoutTarifs()
        {
            InitializeComponent();

        }

        private void AjoutTarifs_Load(object sender, EventArgs e)
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

                    LstsectAjTar.Items.Add(s);
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

            // Affichage Tarif par catégorie /////////////////////////////////////////////////

            try
            {
                maCo.Open();

                Label lab;
                TextBox txt;
                int i = 1;
                string requêtelab = "SELECT * FROM type";
                MySqlCommand maCdelab = new MySqlCommand(requêtelab, maCo);
                MySqlDataReader jeuEnregistrementslab = maCdelab.ExecuteReader();

                while (jeuEnregistrementslab.Read())
                {
                    string letcat = jeuEnregistrementslab["lettrecategorie"].ToString();
                    int notype = Convert.ToInt32(jeuEnregistrementslab["notype"]);
                    string libelle = jeuEnregistrementslab["libelle"].ToString();

                    //TarifParCategorie s = new TarifParCategorie(letcat, notype, libelle);

                    lab = new Label();
                    //lab.Text = s.ToString();
                    lab.Text = letcat + notype.ToString() + "-" + libelle;
                    lab.Location = new Point(5, i * 25);
                    GbxTarif.Controls.Add(lab);

                    txt = new TextBox();
                    txt.Location = new Point(125, i * 25);
                    //txt.Tag = s.GetLettreCategorie() + ";" + s.GetNoType();
                    txt.Tag = letcat + ";" + notype;
                    txt.Width = 100;
                    GbxTarif.Controls.Add(txt);
                    i = i + 1;
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

            // Affichage Periode /////////////////////////////////////////////////

            try
            {
                maCo.Open();

                string requêteper = "SELECT * FROM periode";
                MySqlCommand maCdelab = new MySqlCommand(requêteper, maCo);
                MySqlDataReader jeuEnregistrementsper = maCdelab.ExecuteReader();

                while (jeuEnregistrementsper.Read())
                {
                    int noperiode = Convert.ToInt32(jeuEnregistrementsper["noperiode"]);
                    string datedebut = jeuEnregistrementsper["datedebut"].ToString();
                    string datearrivee = jeuEnregistrementsper["datefin"].ToString();
                    Periode p = new Periode(noperiode, datedebut, datearrivee);
                    Cbxpériode.Items.Add(p);
                }
                jeuEnregistrementsper.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void LstsectAjTar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                int idSecteur = ((Secteur)LstsectAjTar.SelectedItem).GetNoSecteur();
                string requêteliai = "SELECT noliaison, p.NOM, po.NOM as \"pNOM\" FROM liaison l INNER JOIN port p ON (l.NOPORT_DEPART = p.NOPORT) INNER JOIN port po ON (l.NOPORT_ARRIVEE = po.NOPORT) WHERE nosecteur = @idsect ";
                MySqlCommand maCdeliai = new MySqlCommand(requêteliai, maCo);
                maCdeliai.Parameters.AddWithValue("@idsect", idSecteur);
                MySqlDataReader jeuEnregistrementsliai = maCdeliai.ExecuteReader();
                Cbxlaision.Items.Clear();
                while (jeuEnregistrementsliai.Read())
                {
                    int noliaison = Convert.ToInt32(jeuEnregistrementsliai["noliaison"]);
                    string nomportdep = jeuEnregistrementsliai["NOM"].ToString();
                    string nomportarr = jeuEnregistrementsliai["pNOM"].ToString();
                    Liaison l = new Liaison(noliaison, nomportdep, nomportarr);
                    Cbxlaision.Items.Add(l);
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

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {

                maCo.Open();
                foreach(Control c in GbxTarif.Controls)
                {
                    if (c is TextBox tbx)
                    {
                        MySqlCommand maCde;
                        TextBox txt = (TextBox)c;

                        string tab;
                        tab = (tbx.Tag).ToString();
                        tab.Split(';');

                        Periode recupnoperiode = (Periode)Cbxpériode.SelectedItem;

                        string letcat = tab[0].ToString();
                        int notype = int.Parse(tab[2].ToString());
                        double tarif = int.Parse(tbx.Text);

                        Liaison recupnoliaison = (Liaison)Cbxlaision.SelectedItem; ;

                        int noperiode = recupnoperiode.GetNoPeriode();
                        int noliaison = recupnoliaison.GetNoLiaison();

                        string requête = "INSERT INTO tarifer(noperiode, lettrecategorie, notype, noliaison, tarif) VALUES (@noperiode, @letcat, @notype, @noliaison, @tarif)";
                        maCde = new MySqlCommand(requête, maCo);

                        maCde.Parameters.AddWithValue("@noperiode", noperiode);
                        maCde.Parameters.AddWithValue("@letcat", letcat);
                        maCde.Parameters.AddWithValue("@notype", notype);
                        maCde.Parameters.AddWithValue("@noliaison", noliaison);
                        maCde.Parameters.AddWithValue("@tarif", tarif);

                        int nb = maCde.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Nouveau Tarif ajouter !");
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
