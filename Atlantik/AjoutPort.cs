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
    public partial class AjoutPort : Form
    {
        public AjoutPort()
        {
            InitializeComponent();
        }

        private void BtnAjoutPort_Click(object sender, EventArgs e)
        {
            string NomPort, requête;
            MySqlConnection maCo;
            MySqlCommand maCde;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            maCo = new MySqlConnection(CHAINECONNEXION);
            if(tbxajoutport.Text == "")
            {
                MessageBox.Show("Veuillez donner le nom du nouveau port !");
            }
            else
            {
                NomPort = tbxajoutport.Text;
                try
                {
                    maCo.Open();

                    requête = "INSERT INTO port(nom) VALUES (@port)";
                    maCde = new MySqlCommand(requête, maCo);
                    maCde.Parameters.AddWithValue("@port", NomPort);
                    int nb = maCde.ExecuteNonQuery();
                    MessageBox.Show("Nouveau Port Ajouté !");
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

        private void AjoutPort_Load(object sender, EventArgs e)
        {

        }

        private void TbxAjoutPort_Validating(object sender, CancelEventArgs e)
        {
            //var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            //var résultat = objetRegEx.Match(tbxajoutport.Text);

            //if (!résultat.Success)
            //{
            //    tbxajoutport.BackColor = Color.OrangeRed;
            //    e.Cancel = true;
            //}
            //else
            //{
            //    tbxajoutport.BackColor = Color.LightGreen; 
            //    e.Cancel = false;
            //}
        }

        private void tbxajoutport_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultat = objetRegEx.Match(tbxajoutport.Text);

            if (!résultat.Success || tbxajoutport.Text == null)
            {
                tbxajoutport.BackColor = Color.OrangeRed;
                btnAjoutPort.Enabled = false;
            }
            else
            {
                tbxajoutport.BackColor = Color.LightGreen;
                btnAjoutPort.Enabled = true;
            }
        }
    }
}
