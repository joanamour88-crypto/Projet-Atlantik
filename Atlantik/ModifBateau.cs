using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class ModifBateau : Form
    {
        public ModifBateau()
        {
            InitializeComponent();
        }

        private void ModifBateau_Load(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            // Affichage Capamax dans groupe box /////////////////////////////////////////////////////////
            try
            {
                maCo.Open();

                Label lab;
                TextBox txt;
                int i = 1;
                string requête = "SELECT * FROM categorie";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();

                while (jeuEnregistrements.Read())
                {
                    string letcat = jeuEnregistrements["lettrecategorie"].ToString();
                    string libelle = jeuEnregistrements["libelle"].ToString();

                    lab = new Label();
                    lab.Text = letcat + " (" + libelle + ")";
                    lab.Location = new Point(5, i * 25);
                    GbxCapMax.Controls.Add(lab);

                    txt = new TextBox();
                    txt.Location = new Point(125, i * 25);
                    txt.Tag = letcat;
                    txt.Width = 75;
                    txt.TextChanged += tbxCapaMax_TextChanged;
                    GbxCapMax.Controls.Add(txt);
                    i = i + 1;
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
                    cbxnombateau.Items.Add(bat);
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

        private void Cbxnombateau_SelectedIndexChanged(object sender, EventArgs e)
        {

            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            Bateau b = ((Bateau)cbxnombateau.SelectedItem);
            int nobateau = b.GetNoBateau();

            try
            {
                maCo.Open();

                string requêtecapamax = "SELECT capacitemax, lettrecategorie from contenir where nobateau = @idbateau";

                MySqlCommand maCdecapamax = new MySqlCommand(requêtecapamax, maCo);
                maCdecapamax.Parameters.AddWithValue("@idbateau", nobateau);

                MySqlDataReader jeuEnregistrementscapamax = maCdecapamax.ExecuteReader();

                while (jeuEnregistrementscapamax.Read())
                {
                    string capamax = jeuEnregistrementscapamax["capacitemax"].ToString();
                    string letcat = jeuEnregistrementscapamax["lettrecategorie"].ToString();

                    foreach (Control c in GbxCapMax.Controls)
                    {
                        if (c is TextBox tbx)
                        {
                            if (tbx.Tag.ToString() == letcat)
                            tbx.Text = capamax.ToString();
                        }
                    }
                }
                //jeuEnregistrementscapamax.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Bouton Modifier ////////////////////////////////////////////////////////////

            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                if(cbxnombateau.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez renseigner toute les données nécessaire !");
                }
                else
                {
                    Bateau b = ((Bateau)cbxnombateau.SelectedItem);
                    int nobateau = b.GetNoBateau();

                    foreach (Control c in GbxCapMax.Controls)
                    {
                        if (c is TextBox tbx)
                        {
                            MySqlCommand maCde;
                            TextBox txt = (TextBox)c;

                            string tab;
                            tab = (tbx.Tag).ToString();
                            //tab.Split(';');

                            string letcat = tab[0].ToString();
                            int capamax = int.Parse(tbx.Text);

                            string requête = "UPDATE contenir SET capacitemax = @capacitemax WHERE lettrecategorie = @letcat AND  nobateau = @nobateau";
                            maCde = new MySqlCommand(requête, maCo);

                            maCde.Parameters.AddWithValue("@letcat", letcat);
                            maCde.Parameters.AddWithValue("@nobateau", nobateau);
                            maCde.Parameters.AddWithValue("@capacitemax", capamax);

                            int nb = maCde.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Donnée du bateau Modifier !");
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

        private void tbxCapaMax_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.OrangeRed;
                btnmodifier.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.LightGreen;
                btnmodifier.Enabled = true;
            }
        }
    }
}
