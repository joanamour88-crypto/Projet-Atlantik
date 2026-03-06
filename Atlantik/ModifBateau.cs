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
                string requêtelab = "SELECT * FROM categorie";
                MySqlCommand maCdelab = new MySqlCommand(requêtelab, maCo);
                MySqlDataReader jeuEnregistrementslab = maCdelab.ExecuteReader();

                while (jeuEnregistrementslab.Read())
                {
                    string letcat = jeuEnregistrementslab["lettrecategorie"].ToString();
                    string libelle = jeuEnregistrementslab["libelle"].ToString();

                    lab = new Label();
                    lab.Text = letcat + " (" + libelle + ")";
                    lab.Location = new Point(5, i * 25);
                    GbxCapMax.Controls.Add(lab);

                    txt = new TextBox();
                    txt.Location = new Point(125, i * 25);
                    txt.Tag = letcat;
                    txt.Width = 75;
                    GbxCapMax.Controls.Add(txt);
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
                    Cbxnombateau.Items.Add(nombateau);
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

            try
            {
                maCo.Open();

                //int idBateau = ((Bateau)Cbxnombateau.SelectedItem).GetNoBateau();

                //string requêtecapamax = "SELECT c.capacitemax from bateau b INNER JOIN contenir c on (b.nobateau = c.nobateau)";
                //MySqlCommand maCdecapamax = new MySqlCommand(requêtecapamax, maCo);
                //MySqlDataReader jeuEnregistrementscapamax = maCdecapamax.ExecuteReader();
                //int capamax = int.Parse(jeuEnregistrementscapamax["capacitemax"]).ToString();

                int idBateau = ((Bateau)Cbxnombateau.SelectedItem).GetNoBateau();

                foreach (Control c in GbxCapMax.Controls)
                {
                    if (c is TextBox tbx)
                    {
                        TextBox txt = (TextBox)c;

                        string tab = (tbx.Tag).ToString();
                        //int idBateau = ((Bateau)Cbxnombateau.SelectedItem).GetNoBateau();

                        string requêtecapamax = "SELECT c.capacitemax from bateau b INNER JOIN contenir c on (b.nobateau = c.nobateau) where c.lettrecategorie = @tab AND c.nobateau = @idbateau";
                        MySqlCommand maCdecapamax = new MySqlCommand(requêtecapamax, maCo);
                        maCdecapamax.Parameters.AddWithValue("@tab", tab);
                        maCdecapamax.Parameters.AddWithValue("@idbateau", idBateau);
                        MySqlDataReader jeuEnregistrementscapamax = maCdecapamax.ExecuteReader();
                        object capamax = jeuEnregistrementscapamax["c.capacitemax"].ToString();

                        tbx.Text = capamax.ToString();
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
    }
}
