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
    public partial class Form_Abonnes : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        private static int INDEX = 0;

        public Form_Abonnes()
        {
            InitializeComponent();
        }

        public void MISE_A_JOUR()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Abonne";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }

        public void NAVIGUER(string Position)
        {
            MISE_A_JOUR();
            if (Program.CONNEXION.State != ConnectionState.Open) Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Abonne";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            if (Position == "First")
            {
                INDEX = 0;
                numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
            }
            if (Position == "Last")
            {
                INDEX = Table.Rows.Count - 1;
                numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
            }
            if (Position == "Next")
            {
                if (INDEX < Table.Rows.Count - 1)
                {
                    INDEX++;
                    numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                    textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                    textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                    maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
                }
                else
                {
                    INDEX = 0;
                    numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                    textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                    textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                    maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
                }
            }
            if (Position == "Previous")
            {
                if (INDEX > 0)
                {
                    INDEX--;
                    numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                    textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                    textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                    maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
                }
                else
                {
                    INDEX = Table.Rows.Count - 1;
                    numericUpDown_codeAbo.Value = Convert.ToDecimal(Table.Rows[INDEX]["CodeAbo"]);
                    textBox_nom.Text = Table.Rows[INDEX]["Nom"].ToString();
                    textBox_adresse.Text = Table.Rows[INDEX]["Adresse"].ToString();
                    maskedTextBox_telephone.Text = Table.Rows[INDEX]["Tel"].ToString();
                }
            }
            Program.CONNEXION.Close();
        }

        private void button_afficher_Click(object sender, EventArgs e)
        {
            MISE_A_JOUR();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (numericUpDown_codeAbo.Value <= 0 || textBox_nom.Text=="" || textBox_adresse.Text=="" ||
                maskedTextBox_telephone.MaskFull==false)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Abonne where CodeAbo='{0}'", numericUpDown_codeAbo.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (LECTEUR.HasRows)
                {
                    MessageBox.Show("Existe déjà !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("insert into Abonne values ({0},'{1}','{2}','{3}')",
                                        numericUpDown_codeAbo.Value, textBox_nom.Text, textBox_adresse.Text, maskedTextBox_telephone.Text);
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
                MISE_A_JOUR();
            }

        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (numericUpDown_codeAbo.Value <= 0 || textBox_nom.Text == "" || textBox_adresse.Text == "" ||
                maskedTextBox_telephone.MaskFull == false)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Abonne where CodeAbo='{0}'", numericUpDown_codeAbo.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (!LECTEUR.HasRows)
                {
                    MessageBox.Show("N'existe pas !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format(@"update Abonne set 
                        Nom='{1}', Adresse='{2}', Tel='{3}' where CodeAbo={0}",
                         numericUpDown_codeAbo.Value, textBox_nom.Text, textBox_adresse.Text, maskedTextBox_telephone.Text);
                    LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                    if (LIGNES_AFFECTEES == 0)
                    {
                        MessageBox.Show("Erreur!");
                    }
                    else
                    {
                        MessageBox.Show("Modifié !");
                    }
                }
                Program.CONNEXION.Close();
                MISE_A_JOUR();
            }

        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (numericUpDown_codeAbo.Value <= 0)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Abonne where CodeAbo='{0}'", numericUpDown_codeAbo.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (!LECTEUR.HasRows)
                {
                    MessageBox.Show("N'existe pas !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("delete from Abonne where CodeAbo={0}", numericUpDown_codeAbo.Value);
                    LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                    if (LIGNES_AFFECTEES == 0)
                    {
                        MessageBox.Show("Erreur!");
                    }
                    else
                    {
                        MessageBox.Show("Supprimé !");
                    }
                }
                Program.CONNEXION.Close();
                MISE_A_JOUR();
            }

        }

        private void button_premier_Click(object sender, EventArgs e)
        {
            NAVIGUER("First");
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            NAVIGUER("Previous");
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            NAVIGUER("Next");
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            NAVIGUER("Last");
        }

    }
}
