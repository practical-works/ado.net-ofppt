using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_EFM_2014_DERDOURI
{
    public partial class Form_Groupes : Form
    {
        SqlCommand Commande = new SqlCommand("", Program.Connexion);
        SqlDataReader Lecteur;

        private void Connecter()
        {
            if (Program.Connexion.State != ConnectionState.Open) Program.Connexion.Open();
        }
         private void Déconnecter()
        {
            if (Program.Connexion.State != ConnectionState.Closed) Program.Connexion.Close();
        }

        public Form_Groupes()
        {
            InitializeComponent();

            dataGridView_groupes.Columns.Add("Code", "Code");
            dataGridView_groupes.Columns.Add("Filière", "Filière");
            dataGridView_groupes.Columns.Add("Année", "Année");
            dataGridView_groupes.Columns.Add("Responsable", "Responsable");

            Commande.CommandText = "select * from Groupes";
            Connecter();
            Lecteur = Commande.ExecuteReader();
            dataGridView_groupes.Rows.Clear();
            while (Lecteur.Read())
            {
                dataGridView_groupes.Rows.Add(Lecteur[0], Lecteur[1], Lecteur[2], Lecteur[3]);
            }
            Lecteur.Close();
            Commande.CommandText = "select Numéro from Stagiaires";
            Lecteur = Commande.ExecuteReader();
            comboBox_responsable.Items.Clear();
            while (Lecteur.Read())
            {
                comboBox_responsable.Items.Add(Lecteur[0]);
            }
            Déconnecter();
        }

        private void CréerParamètres()
        {
            Commande.Parameters.Add("@code", SqlDbType.Int);
            Commande.Parameters.Add("@filière", SqlDbType.VarChar);
            Commande.Parameters.Add("@année", SqlDbType.Int);
            Commande.Parameters.Add("@responsable", SqlDbType.Int);
        }
        private void SupprimerParamètres()
        {
            Commande.Parameters.Clear();
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            numericUpDown_code.Value = numericUpDown_code.Minimum;
            textBox_filiere.Clear();
            maskedTextBox_annee.Clear();
            comboBox_responsable.SelectedIndex = -1;
            numericUpDown_code.Focus();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (comboBox_responsable.SelectedIndex == -1)
            {
                MessageBox.Show("Données incomplètes !");
            }
            else
            {
                Commande.CommandText = "insert into Groupes values (@code, @filière, @année, @responsable)";
                CréerParamètres();
                Commande.Parameters["@code"].Value = numericUpDown_code.Value;
                Commande.Parameters["@filière"].Value = textBox_filiere.Text;
                Commande.Parameters["@année"].Value = maskedTextBox_annee.Text;
                Commande.Parameters["@responsable"].Value = comboBox_responsable.SelectedItem;
                Connecter();
                Commande.ExecuteNonQuery();
                Déconnecter();
                SupprimerParamètres();
            } 
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (comboBox_responsable.SelectedIndex == -1)
            {
                MessageBox.Show("Données incomplètes !");
            }
            else
            {
                Commande.CommandText = @"update Groupes set Filière=@filière, Année=@année, Responsabl=@responsable
                                            where Code=@code";
                CréerParamètres();
                Commande.Parameters["@code"].Value = numericUpDown_code.Value;
                Commande.Parameters["@filière"].Value = textBox_filiere.Text;
                Commande.Parameters["@année"].Value = maskedTextBox_annee.Text;
                Commande.Parameters["@responsable"].Value = comboBox_responsable.SelectedItem;
                Connecter();
                Commande.ExecuteNonQuery();
                Déconnecter();
                SupprimerParamètres();
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            Commande.CommandText = @"delete from Groupes where Code=@code";
            CréerParamètres();
            Commande.Parameters["@code"].Value = numericUpDown_code.Value;
            Connecter();
            Commande.ExecuteNonQuery();
            Déconnecter();
            SupprimerParamètres();
        }

        private enum Position { Permier, Précédent, Suivant, Dernier }
        private void Naviguer(Position P)
        {
            
        }
    }
}
