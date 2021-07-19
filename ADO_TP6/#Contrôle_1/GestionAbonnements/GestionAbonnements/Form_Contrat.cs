using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionAbonnements
{
    public partial class Form_Contrat : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        private static DataTable TABLE_ABONNES = new DataTable();
        private static DataTable TABLE_PRODUITS = new DataTable();
        private static List<int> REFERENCES_PRODUITS = new List<int>();

        public Form_Contrat()
        {
            InitializeComponent();
        }

        public void MISE_A_JOUR_ABONNES()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Abonne";
            LECTEUR = COMMANDE.ExecuteReader();
            comboBox_codeAbo.Items.Clear();
            while (LECTEUR.Read())
            {
                comboBox_codeAbo.Items.Add(LECTEUR[0]); //colonne du code
            }
            LECTEUR.Close();
            SqlDataReader lecteur = COMMANDE.ExecuteReader();
            TABLE_ABONNES.Load(lecteur);
            Program.CONNEXION.Close();
        }

        public void MISE_A_JOUR_PRODUITS()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Produit";
            LECTEUR = COMMANDE.ExecuteReader();
            comboBox_LibelleProduit.Items.Clear();
            while (LECTEUR.Read())
            {
                comboBox_LibelleProduit.Items.Add(LECTEUR[1]); //colonne du libellé
                REFERENCES_PRODUITS.Add(Convert.ToInt32(LECTEUR[0])); //sauvegarde de la colonne références
            }
            LECTEUR.Close();
            SqlDataReader lecteur = COMMANDE.ExecuteReader();
            TABLE_PRODUITS.Load(lecteur);
            Program.CONNEXION.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown_codeContrat.Value<=0 || comboBox_codeAbo.SelectedIndex==-1 || comboBox_LibelleProduit.SelectedIndex==-1
                || numericUpDown_Quantite.Value<=0 || dateTimePicker_date.Value>DateTime.Now)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Contrat where CodeCon='{0}'", numericUpDown_codeContrat.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (LECTEUR.HasRows)
                {
                    MessageBox.Show("Existe déjà !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("insert into Contrat values ({0},{1},{2},{3},'{4}')",
                                        numericUpDown_codeContrat.Value, 
                                        comboBox_codeAbo.SelectedItem, 
                                        REFERENCES_PRODUITS[comboBox_LibelleProduit.SelectedIndex], 
                                        numericUpDown_Quantite.Value, 
                                        dateTimePicker_date.Value);
                    LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                    if (LIGNES_AFFECTEES == 0)
                    {
                        MessageBox.Show("Erreur!");
                    }
                    else
                    {
                        MessageBox.Show("Ajouté !");
                    }
                }
                Program.CONNEXION.Close();
            }

        }

        private void Form_Contrat_Load(object sender, EventArgs e)
        {
            MISE_A_JOUR_ABONNES();
            MISE_A_JOUR_PRODUITS();
        }

    }
}
