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
    public partial class AjoutSecteur : Form
    {
        public AjoutSecteur()
        {
            InitializeComponent();
        }

        private void BtnAjoutSect_Click(object sender, EventArgs e)
        {
            string requête;
            object nomsect;
            MySqlConnection maCo;
            MySqlCommand maCde;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=Atlantik;Uid=root;pwd=;";
            maCo = new MySqlConnection(CHAINECONNEXION);
            nomsect = Tbxnomsect.Text;
            Console.Beep();
            try
            {
                maCo.Open();

                requête = "INSERT INTO secteur(NOM) VALUES (@Sect)";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@Sect", nomsect);
                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Nouveau secteur Ajouter !");

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

        private void AjoutSecteur_Load(object sender, EventArgs e)
        {

        }

        private void Tbxnomsect_Validating(object sender, CancelEventArgs e)
        {

            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultat = objetRegEx.Match(Tbxnomsect.Text);

            if (!résultat.Success || Tbxnomsect.Text == null)
            {
                Tbxnomsect.BackColor = Color.OrangeRed;
                e.Cancel = true;
            }
            else
            {
                Tbxnomsect.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
        }
    }
}
