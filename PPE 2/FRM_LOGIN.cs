using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_2
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            string nom = TXT_NOM.Text;
            string mdp = TXT_MDP.Text;
            try
            {
                MySqlConnection connection = new MySqlConnection("SERVER=51.83.42.191; UID=Theo;PASSWORD=12345; DATABASE=BDDTESTPPETHEO"); //mettre mes identifiants admin et faire une requete pour charger les admins
                connection.Open();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur");
                MessageBox.Show(ex.ToString());
            }
            MySqlConnection connection1 = new MySqlConnection("SERVER=51.83.42.191; UID=Theo;PASSWORD=12345; DATABASE=BDDTESTPPETHEO");
            connection1.Open();
           
            string commande = "SELECT NvauHabilitation FROM PERSONNEL WHERE Nom = '" + TXT_NOM.Text+"' AND Password ='"+TXT_MDP.Text+"'";
            MySqlCommand readerselect = new MySqlCommand(commande, connection1);
            MySqlDataReader reader1 = readerselect.ExecuteReader();
            if (reader1.Read())
            {
                string resultathabil = reader1.GetString("NvauHabilitation");
                switch (resultathabil)
                {
                    case "1":
                        FRM_ADMIN frm_admin = new FRM_ADMIN();
                        frm_admin.ShowDialog();
                        break;
                    case "3":
                        FRM_SECRETAIRE frm_secretaire = new FRM_SECRETAIRE();
                        frm_secretaire.ShowDialog();
                        break;
                    case "4":
                        FRM_TECHNICIEN frm_technicien = new FRM_TECHNICIEN();
                        frm_technicien.ShowDialog();
                        break;
                }
            }
            connection1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXT_NOM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_NOM_Click(object sender, EventArgs e)
        {
            TXT_NOM.ForeColor = Color.Black;
            TXT_NOM.Clear();
        }

        private void TXT_MDP_TextChanged(object sender, EventArgs e)
        {
            TXT_MDP.PasswordChar = '·';
        }

        private void TXT_MDP_Click(object sender, EventArgs e)
        {
            TXT_MDP.Clear();
            TXT_MDP.ForeColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TXT_NOM_Leave(object sender, EventArgs e)
        {
            if(TXT_NOM.Text == "")
            {
                TXT_NOM.Text = "Nom d'utilisateur";
                TXT_NOM.ForeColor = Color.DimGray;
            }
        }

        private void TXT_MDP_Leave(object sender, EventArgs e)
        {
            if(TXT_MDP.Text=="")
            {
                TXT_MDP.Text = "Mot de passe";
                TXT_MDP.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_LOGIN_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
