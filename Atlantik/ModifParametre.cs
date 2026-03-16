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
                TbxSite.Text = jeuEnregistrements["site_pb"].ToString();
                TbxRang.Text = jeuEnregistrements["rang_pb"].ToString();
                TbxIdentifiant.Text = jeuEnregistrements["identifiant_pb"].ToString();
                TbxCleHMAC.Text = jeuEnregistrements["clehmac_pb"].ToString();
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

            string site = TbxSite.Text;
            string rang = TbxRang.Text;
            string identifiant = TbxIdentifiant.Text;
            string clehmac = TbxCleHMAC.Text;
            int enprod = Convert.ToInt32(Cbxenrpod.Checked);
            string mail = TbxMail.Text;
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
    }
}
