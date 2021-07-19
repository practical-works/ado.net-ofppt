using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO6
{
    public partial class Form_Retours : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        //private static int INDEX = 0;
        private static DataTable TABLE_ADH = new DataTable();

        public Form_Retours()
        {
            InitializeComponent();
        }

        public void MISE_A_JOUR_ADH()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Adherent";
            LECTEUR = COMMANDE.ExecuteReader();
            //comboBox_CODADH.DataSource = TABLE_ADH;
            //comboBox_CODADH.DisplayMember = "CODADH";
            while (LECTEUR.Read())
            {
                comboBox_CODADH.Items.Add(LECTEUR[0]);
            }
            LECTEUR.Close();
            SqlDataReader lecteur = COMMANDE.ExecuteReader();
            TABLE_ADH.Load(lecteur);
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_EMP()
        {
            comboBox_NUMEMP.Text = "";
            if (Program.CONNEXION.State != ConnectionState.Open) Program.CONNEXION.Open();
            COMMANDE.CommandText = string.Format("select * from Emprunt where CODADH={0} and DATRET is null", 
                comboBox_CODADH.SelectedItem);
            LECTEUR = COMMANDE.ExecuteReader();
            //DataTable Table = new DataTable();
            //Table.Load(LECTEUR);
            //comboBox_NUMEMP.DataSource = Table;
            //comboBox_NUMEMP.DisplayMember = "NUMEMP";
            comboBox_NUMEMP.Items.Clear();
            while (LECTEUR.Read())
            {
                comboBox_NUMEMP.Items.Add(LECTEUR[0]);
            }
            Program.CONNEXION.Close();
            label_nbrEmprunts.Text = comboBox_NUMEMP.Items.Count + " emprunts";
        }

        private void comboBox_CODADH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CODADH.SelectedIndex != -1)
            {
                textBox_ADH.Text = TABLE_ADH.Rows[comboBox_CODADH.SelectedIndex]["NOMADH"].ToString();
                MISE_A_JOUR_EMP();
            }
        }

        private void Form_Retours_Load(object sender, EventArgs e)
        {
            MISE_A_JOUR_ADH();
        }

        private void button_Valider_Click(object sender, EventArgs e)
        {
            if (comboBox_NUMEMP.SelectedIndex != -1)
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("update Emprunt set DATRET='{0}' where NUMEMP={1}",
                DateTime.Today.ToShortDateString(), comboBox_NUMEMP.SelectedItem);
                LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                if (LIGNES_AFFECTEES == 0)
                {
                    MessageBox.Show("Erreur !");
                }
                else
                {
                    MessageBox.Show("Validé !");
                }
                Program.CONNEXION.Close();
                MISE_A_JOUR_ADH();
                MISE_A_JOUR_EMP();               
            }
            else
            {
                MessageBox.Show("Aucun emprunt choisi !");
            }
        }

        private void comboBox_NUMEMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_NUMEMP.SelectedIndex != -1) button_Valider.Enabled = true;
            else button_Valider.Enabled = false;
        }
    }
}
