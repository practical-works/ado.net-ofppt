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
    public partial class Form_Ouvrages : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        //private static int INDEX = 0;

        public Form_Ouvrages()
        {
            InitializeComponent();
        }

        public void NOUVEAU()
        {
            numericUpDown_CODOUV.Select();
            textBox_TITOUV.Clear();
            textBox_NOMAUT.Clear();
            comboBox_TYPOUV.SelectedIndex = -1;
            dateTimePicker_DATEDIT.Value = dateTimePicker_DATACH.Value = DateTime.Today;
            numericUpDown_NBPAGE.Value = numericUpDown_NBPAGE.Minimum;
        }

        public void MISE_A_JOUR()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Ouvrage";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            if (numericUpDown_CODOUV.Value<=0 || textBox_TITOUV.Text=="" || textBox_NOMAUT.Text=="" ||
                comboBox_TYPOUV.SelectedIndex==-1 || dateTimePicker_DATEDIT.Value>DateTime.Now ||
                dateTimePicker_DATACH.Value>DateTime.Now || numericUpDown_NBPAGE.Value<=0)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Ouvrage where CODOUV='{0}'", numericUpDown_CODOUV.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (LECTEUR.HasRows)
                {
                    MessageBox.Show("Existe déjà !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format(@"insert into Ouvrage values ({0},'{1}','{2}','{3}','{4}','{5}',{6})",
                        numericUpDown_CODOUV.Value, textBox_TITOUV.Text, textBox_NOMAUT.Text, comboBox_TYPOUV.SelectedItem, 
                        dateTimePicker_DATEDIT.Value, dateTimePicker_DATACH.Value, numericUpDown_NBPAGE.Value);
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
            if (numericUpDown_CODOUV.Value <= 0 || textBox_TITOUV.Text == "" || textBox_NOMAUT.Text == "" ||
                comboBox_TYPOUV.SelectedIndex == -1 || dateTimePicker_DATEDIT.Value > DateTime.Now ||
                dateTimePicker_DATACH.Value > DateTime.Now || numericUpDown_NBPAGE.Value <= 0)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Ouvrage where CODOUV='{0}'", numericUpDown_CODOUV.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (!LECTEUR.HasRows)
                {
                    MessageBox.Show("N'existe pas !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format(@"update Ouvrage set 
                        TITOUV='{1}', NOMAUT='{2}', TYPOUV='{3}', DATEDIT='{4}', DATACH='{5}', NBPAGE={6}
                        where CODOUV={0}",
                         numericUpDown_CODOUV.Value, textBox_TITOUV.Text, textBox_NOMAUT.Text, comboBox_TYPOUV.SelectedItem,
                         dateTimePicker_DATEDIT.Value, dateTimePicker_DATACH.Value, numericUpDown_NBPAGE.Value);
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

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (numericUpDown_CODOUV.Value <= 0)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Ouvrage where CODOUV='{0}'", numericUpDown_CODOUV.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (!LECTEUR.HasRows)
                {
                    MessageBox.Show("N'existe pas !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("delete from Ouvrage where CODOUV={0}", numericUpDown_CODOUV.Value);
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

        private void Form_Ouvrages_Load(object sender, EventArgs e)
        {
            MISE_A_JOUR();
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            NOUVEAU();
        }


    }
}
