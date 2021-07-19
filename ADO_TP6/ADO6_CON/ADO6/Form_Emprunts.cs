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
    public partial class Form_Emprunts : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        private static int INDEX = 0;
        private static DataTable TABLE_ADH = new DataTable();
        private static DataTable TABLE_OUV = new DataTable();

        public Form_Emprunts()
        {
            InitializeComponent();
        }

        public void NOUVEAU()
        {
            numericUpDown_NUMEMP.Value = Program.Identity_Emprunt;
            comboBox_CODADH.SelectedIndex = comboBox_CODOUV.SelectedIndex = -1;
            dateTimePicker_DATEMP.Value = dateTimePicker_DATRET.Value = DateTime.Today;
        }

        public void MISE_A_JOUR()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Emprunt";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_ADH()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Adherent";
            LECTEUR = COMMANDE.ExecuteReader();
            //comboBox_CODADH.DataSource = TABLE_ADH;
            //comboBox_CODADH.DisplayMember = "CODADH";
            comboBox_CODADH.Items.Clear();
            while (LECTEUR.Read())
            {
                comboBox_CODADH.Items.Add(LECTEUR[0]);
            }
            LECTEUR.Close();
            SqlDataReader lecteur = COMMANDE.ExecuteReader();
            TABLE_ADH.Load(lecteur);
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_OUV()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = @"select * from Ouvrage where CODOUV not in 
                                    (select CODOUV from Emprunt where DATRET is null)";
            LECTEUR = COMMANDE.ExecuteReader();
            //comboBox_CODOUV.DataSource = TABLE_OUV;
            //comboBox_CODOUV.DisplayMember = "CODOUV";
            comboBox_CODOUV.Items.Clear();
            while (LECTEUR.Read())
            {
                comboBox_CODOUV.Items.Add(LECTEUR[0]);
            }
            LECTEUR.Close();
            SqlDataReader lecteur = COMMANDE.ExecuteReader();
            TABLE_OUV.Load(lecteur);
            Program.CONNEXION.Close();
        }

        private void Form_Emprunts_Load(object sender, EventArgs e)
        {
            MISE_A_JOUR();
            MISE_A_JOUR_ADH();
            MISE_A_JOUR_OUV();
            MAJ_Id_Emprunt(true, true);
        }

        private void comboBox_CODADH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CODADH.SelectedIndex != -1)
            {
                textBox_ADH.Text = TABLE_ADH.Rows[comboBox_CODADH.SelectedIndex]["NOMADH"].ToString();
            }
        }

        private void comboBox_CODOUV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CODOUV.SelectedIndex != -1)
            {
                textBox_OUV.Text = TABLE_OUV.Rows[comboBox_CODOUV.SelectedIndex]["TITOUV"].ToString();
            }
        }

        private void checkBox_Retour_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PasEncoreRetourne.Checked)
            {
                dateTimePicker_DATRET.Enabled = false;
            }
            else
            {
                dateTimePicker_DATRET.Enabled = true;
            }
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            if (numericUpDown_NUMEMP.Value<=0 || comboBox_CODADH.SelectedIndex==-1 || comboBox_CODOUV.SelectedIndex==-1 ||
                dateTimePicker_DATEMP.Value>DateTime.Now || 
                (!checkBox_PasEncoreRetourne.Checked && dateTimePicker_DATRET.Value<dateTimePicker_DATEMP.Value))
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Emprunt where NUMEMP='{0}'", numericUpDown_NUMEMP.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (LECTEUR.HasRows)
                {
                    MessageBox.Show("Existe déjà !");
                }
                else
                {
                    LECTEUR.Close();
                    if (checkBox_PasEncoreRetourne.Checked)
                    {
                        COMMANDE.CommandText = string.Format("insert into Emprunt values ({0},{1},{2},'{3}',null)",
                        numericUpDown_NUMEMP.Value, comboBox_CODADH.SelectedItem, comboBox_CODOUV.SelectedItem,
                        dateTimePicker_DATEMP.Value);
                    }
                    else
                    {
                        COMMANDE.CommandText = string.Format("insert into Emprunt values ({0},{1},{2},'{3}','{4}')",
                        numericUpDown_NUMEMP.Value, comboBox_CODADH.SelectedItem, comboBox_CODOUV.SelectedItem,
                        dateTimePicker_DATEMP.Value, dateTimePicker_DATRET.Value);
                    }
                    LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                    if (LIGNES_AFFECTEES == 0)
                    {
                        MessageBox.Show("Erreur!");
                    }
                    else
                    {
                        MessageBox.Show("Ajouté !");
                        comboBox_CODOUV.Text = "";
                        MAJ_Id_Emprunt(true, false);
                    }
                }
                Program.CONNEXION.Close();
                MISE_A_JOUR();
                MISE_A_JOUR_OUV();
            }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (numericUpDown_NUMEMP.Value <= 0)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Emprunt where NUMEMP='{0}'", numericUpDown_NUMEMP.Value);
                LECTEUR = COMMANDE.ExecuteReader();
                if (!LECTEUR.HasRows)
                {
                    MessageBox.Show("N'existe pas !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("delete from Emprunt where NUMEMP={0}", numericUpDown_NUMEMP.Value);
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

        public void MAJ_Id_Emprunt(bool Incrementer, bool Charger)
        {
            if (Charger)
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = "select NUMEMP from Emprunt";
                LECTEUR = COMMANDE.ExecuteReader();
                DataTable Table = new DataTable();
                Table.Load(LECTEUR);
                INDEX = Table.Rows.Count - 1;
                if (INDEX != -1) Program.Identity_Emprunt = Convert.ToInt32(Table.Rows[INDEX]["NUMEMP"]);
                Program.CONNEXION.Close();
            }
            if (Incrementer) Program.Identity_Emprunt++;
            numericUpDown_NUMEMP.Value = Program.Identity_Emprunt;            
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            NOUVEAU();
        }
    }
}
