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
    public partial class AjoutBateau : Form
    {
        public AjoutBateau()
        {
            InitializeComponent();
        }

        private void AjoutBateau_Load(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

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
                    gbxcapmax.Controls.Add(lab);

                    txt = new TextBox();
                    txt.Location = new Point(125, i * 25);
                    txt.Tag = letcat;
                    txt.Width = 75;
                    txt.TextChanged += tbxCapaMax_TextChanged;
                    gbxcapmax.Controls.Add(txt);
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
        }

        private void BtnAjBateau_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                if(tbxnombateau.Text == "" || tbxnombateau.BackColor == Color.Red)
                {
                    MessageBox.Show("veuillez donner le nom du bateau !");
                }
                else
                {
                    MySqlCommand maCdeinsbateau;
                    string nombateau = tbxnombateau.Text;
                    string requêteinsbateau = "INSERT INTO bateau(nom) VALUES (@nombateau)";
                    maCdeinsbateau = new MySqlCommand(requêteinsbateau, maCo);
                    maCdeinsbateau.Parameters.AddWithValue("@nombateau", nombateau);
                    int nbinsbateau = maCdeinsbateau.ExecuteNonQuery();

                    int nobateau = (int)maCdeinsbateau.LastInsertedId;

                    foreach (Control c in gbxcapmax.Controls)
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

                            string requête = "INSERT INTO contenir(lettrecategorie, nobateau, capacitemax) VALUES (@letcat, @nobateau, @capacitemax)";
                            maCde = new MySqlCommand(requête, maCo);

                            maCde.Parameters.AddWithValue("@letcat", letcat);
                            maCde.Parameters.AddWithValue("@nobateau", nobateau);
                            maCde.Parameters.AddWithValue("@capacitemax", capamax);

                            int nb = maCde.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Nouveau bateau ajouter !");
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
                btnajbateau.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.LightGreen;
                btnajbateau.Enabled = true;
            }
        }

        private void tbxnombateau_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultat = objetRegEx.Match(tbxnombateau.Text);

            if (!résultat.Success || tbxnombateau.Text == null)
            {
                tbxnombateau.BackColor = Color.OrangeRed;
                btnajbateau.Enabled = false;
            }
            else
            {
                tbxnombateau.BackColor = Color.LightGreen;
                btnajbateau.Enabled = true;
            }
        }
    }
}
