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
    public partial class AjoutLiaison : Form
    {
        public AjoutLiaison()
        {
            InitializeComponent();
        }

        private void AjoutLiaison_Load(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            try
            {
                maCo.Open();

                // Affichage port de départ et port d'arriver /////////////////////////////////////////////////

                string requête = "SELECT NOPORT, NOM FROM port";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();

                while (jeuEnregistrements.Read())
                {
                    int id = Convert.ToInt32(jeuEnregistrements["noport"]);
                    string nom = jeuEnregistrements["nom"].ToString();

                    Port p = new Port(id, nom);

                    cmbdepart.Items.Add(p);
                    cmbarrivee.Items.Add(p);
                }
                jeuEnregistrements.Close();

                // Affichage des secteurs /////////////////////////////////////////////////

                string requêtesect = "SELECT nosecteur, nom FROM secteur";
                MySqlCommand maCdesect = new MySqlCommand(requêtesect, maCo);
                MySqlDataReader jeuEnregistrementssect = maCdesect.ExecuteReader();

                while (jeuEnregistrementssect.Read())
                {
                    int idsect = Convert.ToInt32(jeuEnregistrementssect["nosecteur"]);
                    string nomsect = jeuEnregistrementssect["nom"].ToString();

                    Secteur s = new Secteur(idsect, nomsect);

                    lbxsect.Items.Add(s);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CbxArrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            MySqlCommand maCde;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            if(lbxsect.SelectedItem == null || cmbdepart.SelectedItem == null || cmbarrivee.SelectedItem == null || tbxdist.Text == "")
            {
                MessageBox.Show("Veuillez renseigner toutes les données nécessaires !");
            }
            else
            {
                Secteur sect = (Secteur)lbxsect.SelectedItem;
                Port dep = (Port)cmbdepart.SelectedItem;
                Port arr = (Port)cmbarrivee.SelectedItem;
                int idSecteur = sect.GetNoSecteur();
                int idDepart = dep.GetNoPort();
                int idArrivé = dep.GetNoPort();
                double dist = int.Parse(tbxdist.Text);

                //MessageBox.Show(tbxdist.Text.ToString());

                try
                {
                    maCo.Open();

                    if (dep == arr)
                    {
                        MessageBox.Show("C'est le même départ et arriver, change ça vite mon Grand !!");
                    }
                    else
                    {
                        string requête = "INSERT INTO liaison(noport_depart, nosecteur, noport_arrivee, distance) VALUES (@dep, @sect, @arr, @dist)";
                        maCde = new MySqlCommand(requête, maCo);
                        maCde.Parameters.AddWithValue("@dep", idDepart);
                        maCde.Parameters.AddWithValue("@sect", idSecteur);
                        maCde.Parameters.AddWithValue("@arr", idArrivé);
                        maCde.Parameters.AddWithValue("@dist", dist);
                        int nb = maCde.ExecuteNonQuery();
                        MessageBox.Show("Nouvelle liaison ajouter !");
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
        }

        private void Tbxvalid_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxDist_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var résultat = objetRegEx.Match(tbxdist.Text);

            if (!résultat.Success || tbxdist.Text == "")
            {
                tbxdist.BackColor = Color.Red;
                e.Cancel = true;
                MessageBox.Show("Veuillez saisir un nombre pour la distance !!");
                //ErrorProvider.SetError(TbxDist, "Saisir un nombre ! ");
            }
            else
            {
                tbxdist.BackColor = Color.Green;
                //ErrorProvider.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxdist_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var résultat = objetRegEx.Match(tbxdist.Text);

            if (!résultat.Success || tbxdist.Text == null)
            {
                tbxdist.BackColor = Color.OrangeRed;
                BtnAjout.Enabled = false;
            }
            else
            {
                tbxdist.BackColor = Color.LightGreen;
                BtnAjout.Enabled = true;
            }
        }
    }
}
