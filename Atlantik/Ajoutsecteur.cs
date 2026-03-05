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
            nomsect = TbxNomsect.Text;
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
    }
}
