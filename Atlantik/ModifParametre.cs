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
    public partial class ModifParametre : Form
    {
        public ModifParametre()
        {
            InitializeComponent();
        }

        private void ModifParametre_Load(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                string requête = "SELECT * FROM parametres";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements = maCde.ExecuteReader();
                jeuEnregistrements.Read();
                tbxsite.Text = jeuEnregistrements["site_pb"].ToString();
                tbxrang.Text = jeuEnregistrements["rang_pb"].ToString();
                tbxidentifiant.Text = jeuEnregistrements["identifiant_pb"].ToString();
                tbxclehmac.Text = jeuEnregistrements["clehmac_pb"].ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            string site = tbxsite.Text;
            string rang = tbxrang.Text;
            string identifiant = tbxidentifiant.Text;
            string clehmac = tbxclehmac.Text;
            int enprod = Convert.ToInt32(cbxenrpod.Checked);
            string mail = tbxmail.Text;
            try
            {
                maCo.Open();

                string requête = "UPDATE parametres SET site_pb = @site, rang_pb = @rang, identifiant_pb = @identifiant, clehmac_pb = @clehmac, enproduction = @enprod, melsite = @mail";
                MySqlCommand maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@site", site);
                maCde.Parameters.AddWithValue("@rang", rang);
                maCde.Parameters.AddWithValue("@identifiant", identifiant);
                maCde.Parameters.AddWithValue("@clehmac", clehmac);
                maCde.Parameters.AddWithValue("@enprod", enprod);
                maCde.Parameters.AddWithValue("@mail", mail);

                int nb = maCde.ExecuteNonQuery();

                MessageBox.Show("Paramètres modifiés avec succès !");
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

        private void tbxsite_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxrang_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxidentifiant_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxsite_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbxsite.Text);

            if (!resultatTest.Success)
            {
                tbxsite.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                tbxsite.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }

        private void tbxrang_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbxrang.Text);

            if (!resultatTest.Success)
            {
                tbxrang.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                tbxrang.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }

        private void tbxidentifiant_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbxidentifiant.Text);

            if (!resultatTest.Success)
            {
                tbxidentifiant.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                tbxidentifiant.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }

        private void tbxclehmac_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9A-Z]*$");
            var resultatTest = objetRegEx.Match(tbxclehmac.Text);

            if (!resultatTest.Success)
            {
                tbxclehmac.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                tbxclehmac.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }

        private void tbxmail_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex(@"^[a-zA-Z.]+@[a-z]+\.[a-z]*$");
            var resultatTest = objetRegEx.Match(tbxmail.Text);

            if (!resultatTest.Success)
            {
                tbxmail.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                tbxmail.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }
    }
}
