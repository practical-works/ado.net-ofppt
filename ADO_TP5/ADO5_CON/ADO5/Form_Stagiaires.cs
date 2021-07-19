using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO5
{
    public partial class Form_Stagiaires : Form
    {
        private SqlCommand Commande = new SqlCommand("", Program.Connexion);
        private SqlDataReader Lecteur;
        private static Form_Stagiaires instance;
        public static Form_Stagiaires Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form_Stagiaires();
                }
                return instance;
            }
        }

        public Form_Stagiaires()
        {
            InitializeComponent();
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            textBox_num_sta.Clear();
            textBox_nom_sta.Clear();
            textBox_pre_sta.Clear();
            maskedTextBox_date_sta.Clear();
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta) || textBox_nom_sta.Text=="" || textBox_pre_sta.Text=="" ||
                !maskedTextBox_date_sta.MaskFull)
            {
                Program.Message("Des entrées sont invalides !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire where num_sta=" + num_sta;
                Lecteur = Commande.ExecuteReader();
                if (Lecteur.HasRows)
                {
                    Program.Message("Stagiaire existe déjà !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = string.Format("insert into Stagiaire values ({0},'{1}','{2}','{3}')",
                    num_sta, textBox_nom_sta.Text, textBox_pre_sta.Text, maskedTextBox_date_sta.Text);
                    int nbr_lignes = Commande.ExecuteNonQuery();
                    if (nbr_lignes == 0)
                    {
                        Program.Message("Stagiaire NON ajouté !", "E");
                    }
                    else
                    {
                        Program.Message("Stagiaire BIEN ajouté !", "OK");
                    }
                }
                Program.Connexion.Close();
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta) || textBox_nom_sta.Text == "" || textBox_pre_sta.Text == "" ||
                !maskedTextBox_date_sta.MaskFull)
            {
                Program.Message("Des entrées sont invalides !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire where num_sta=" + num_sta;
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Stagiaire n'existe pas !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = string.Format("update Stagiaire set nom_sta='{0}',pre_sta='{1}',date_sta='{2}' where num_sta={3}",
                    textBox_nom_sta.Text, textBox_pre_sta.Text, maskedTextBox_date_sta.Text, num_sta);
                    int nbr_lignes = Commande.ExecuteNonQuery();
                    if (nbr_lignes == 0)
                    {
                        Program.Message("Stagiaire NON modifié !", "E");
                    }
                    else
                    {
                        Program.Message("Stagiaire BIEN modifié !", "OK");
                    }
                }
                Program.Connexion.Close();
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta))
            {
                Program.Message("Numéro invalide !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire where num_sta=" + num_sta;
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Stagiaire n'existe pas !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = "delete from Stagiaire where num_sta=" + num_sta;
                    int nbr_lignes = Commande.ExecuteNonQuery();
                    if (nbr_lignes == 0)
                    {
                        Program.Message("Stagiaire NON supprimé !", "E");
                    }
                    else
                    {
                        Program.Message("Stagiaire BIEN supprimé !", "OK");
                    }
                }
                Program.Connexion.Close();
            }
        }

        private void button_moyenne_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta))
            {
                Program.Message("Numéro invalide !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire where num_sta=" + num_sta;
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Stagiaire n'existe pas !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = "select avg(note) from note where num_sta=" + num_sta;
                    if (Commande.ExecuteScalar() == DBNull.Value || Commande.ExecuteScalar() == null)
                    {
                        Program.Message("Données NON disponibles !", "E");
                    }
                    else
                    {
                        double moyenne = (double)Commande.ExecuteScalar();
                        Program.Message("Moyenne: " + moyenne, "OK");
                    }
                    
                }
                Program.Connexion.Close();
            }
        }

        private void button_rechercher_num_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta))
            {
                Program.Message("Numéro invalide !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire where num_sta=" + num_sta;
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Stagiaire n'existe pas !", "I");
                }
                else
                {
                   if (Lecteur.Read())
                   {
                        textBox_nom_sta.Text = Lecteur[1].ToString();
                        textBox_pre_sta.Text = Lecteur[2].ToString();
                        maskedTextBox_date_sta.Text = Lecteur[3].ToString();
                   }
                }
                Program.Connexion.Close();
            }
        }

        private void button_rechercher_nom_Click(object sender, EventArgs e)
        {
            if (textBox_nom_sta.Text=="" || textBox_pre_sta.Text=="")
            {
                Program.Message("Des entrées sont invalides !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = string.Format("select * from Stagiaire where nom_sta='{0}' and pre_sta='{1}'",
                    textBox_nom_sta.Text, textBox_pre_sta.Text);
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Stagiaire n'existe pas !", "I");
                }
                else
                {
                    if (Lecteur.Read())
                    {
                        textBox_num_sta.Text = Lecteur[0].ToString();
                        maskedTextBox_date_sta.Text = Lecteur[3].ToString();
                    }
                }
                Program.Connexion.Close();
            }
        }

        private void maskedTextBox_date_sta_Validating(object sender, CancelEventArgs e)
        {
            DateTime date_sta;
            if (!DateTime.TryParse(maskedTextBox_date_sta.Text, out date_sta))
            {
                Program.Message("Date incorrecte !", "I");
                maskedTextBox_date_sta.Focus();
                maskedTextBox_date_sta.SelectAll();
            }
            else if (date_sta > DateTime.Now)
            {
                Program.Message("Date de naissance invalide !\nLa date de naissance ne peut avoir lieu dans le futur.", "I");
                maskedTextBox_date_sta.Focus();
                maskedTextBox_date_sta.SelectAll();
            }
        }

        private void button_premier_Click(object sender, EventArgs e)
        {       
            Program.Connexion.Open();
            Commande.CommandText = "select * from Stagiaire";
            Lecteur = Commande.ExecuteReader();
            if (Lecteur.Read())
            {
                textBox_num_sta.Text = Lecteur[0].ToString();
                textBox_nom_sta.Text = Lecteur[1].ToString();
                textBox_pre_sta.Text = Lecteur[2].ToString();
                maskedTextBox_date_sta.Text = Lecteur[3].ToString();
            }
            Program.Connexion.Close();
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta))
            {
                Program.Message("Numéro invalide !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire";
                Lecteur = Commande.ExecuteReader();
                while (Lecteur.Read())
                {
                    if (int.Parse(Lecteur[0].ToString()) != num_sta)
                    {
                        textBox_num_sta.Text = Lecteur[0].ToString();
                        textBox_nom_sta.Text = Lecteur[1].ToString();
                        textBox_pre_sta.Text = Lecteur[2].ToString();
                        maskedTextBox_date_sta.Text = Lecteur[3].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Program.Connexion.Close();
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            int num_sta;
            if (!int.TryParse(textBox_num_sta.Text, out num_sta))
            {
                Program.Message("Numéro invalide !", "I");
            }
            else
            {
                Program.Connexion.Open();
                Commande.CommandText = "select * from Stagiaire";
                Lecteur = Commande.ExecuteReader();
                while (Lecteur.Read())
                {
                    if (int.Parse(Lecteur[0].ToString()) == num_sta)
                    {
                        if (Lecteur.Read())
                        {
                            textBox_num_sta.Text = Lecteur[0].ToString();
                            textBox_nom_sta.Text = Lecteur[1].ToString();
                            textBox_pre_sta.Text = Lecteur[2].ToString();
                            maskedTextBox_date_sta.Text = Lecteur[3].ToString();
                        }
                    }
                }
            }
            Program.Connexion.Close();
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            Program.Connexion.Open();
            Commande.CommandText = "select * from Stagiaire";
            Lecteur = Commande.ExecuteReader();
            while (Lecteur.Read())
            {
                textBox_num_sta.Text = Lecteur[0].ToString();
                textBox_nom_sta.Text = Lecteur[1].ToString();
                textBox_pre_sta.Text = Lecteur[2].ToString();
                maskedTextBox_date_sta.Text = Lecteur[3].ToString();
            }
            Program.Connexion.Close();
        }

        private void Form_Stagiaires_Load(object sender, EventArgs e)
        {
            textBox_num_sta.Focus();
            textBox_num_sta.Select();
        }
    }
}
