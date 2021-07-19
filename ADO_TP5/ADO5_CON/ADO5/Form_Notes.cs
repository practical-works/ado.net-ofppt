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
    public partial class Form_Notes : Form
    {
        private List<int> numeros_sta = new List<int>();
        private List<int> numeros_mod = new List<int>();
        private SqlCommand Commande = new SqlCommand("", Program.Connexion);
        private SqlDataReader Lecteur;
        private static Form_Notes instance;
        public static Form_Notes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form_Notes();
                }
                return instance;
            }
        }

        public Form_Notes()
        {
            InitializeComponent();
        }

        private void Form_Notes_Load(object sender, EventArgs e)
        {
            Program.Connexion.Open();

            // Remplir la liste des stagiaires
            Commande.CommandText = "select * from Stagiaire";
            Lecteur = Commande.ExecuteReader();
            comboBox_stagiaire.Items.Clear();
            while (Lecteur.Read())
            {
                comboBox_stagiaire.Items.Add(Lecteur[1] + " " + Lecteur[2]);
                numeros_sta.Add(int.Parse(Lecteur[0].ToString()));
            }
            Lecteur.Close();
            
            // Remplir la liste des modules
            Commande.CommandText = "select * from Module";
            Lecteur = Commande.ExecuteReader();
            comboBox_module.Items.Clear();
            while (Lecteur.Read())
            {
                comboBox_module.Items.Add(Lecteur[1]);
                numeros_mod.Add(int.Parse(Lecteur[0].ToString()));
            }
            Lecteur.Close();
            Program.Connexion.Close();
        }

        private void comboBox_stagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherNote();
            // Remplir la liste des notes (dataGridView)
            int p = comboBox_stagiaire.SelectedIndex;
            if (p != -1)
            {
                Program.Connexion.Open();
                Commande.CommandText = "select Module.num_mod, Module.nom_mod, Note.note " +
                                    "from Module inner join Note " +
                                    "on Module.num_mod = Note.num_mod " +
                                    "where Note.num_sta =" + numeros_sta[p];
                Lecteur = Commande.ExecuteReader();
                dataGridView_notes.Columns.Clear();
                dataGridView_notes.Rows.Clear();
                dataGridView_notes.Columns.Add("num_mod", "Numéro Module");
                dataGridView_notes.Columns.Add("nom_mod", "Nom Module");
                dataGridView_notes.Columns.Add("note", "Note Module");
                while (Lecteur.Read())
                {
                    dataGridView_notes.Rows.Add(Lecteur[0], Lecteur[1], Lecteur[2]);
                }
                Program.Connexion.Close();
            }
        }

        private void comboBox_module_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherNote();
        }

        public void AfficherNote()
        {
            int p_sta = comboBox_stagiaire.SelectedIndex;
            int p_mod = comboBox_module.SelectedIndex;
            if (p_sta != -1 && p_mod != -1)
            {
                Program.Connexion.Open();
                Commande.CommandText = string.Format("select note from Note where num_sta={0} and num_mod={1}",
                numeros_sta[p_sta], numeros_mod[p_mod]);
                if (Commande.ExecuteScalar() == DBNull.Value || Commande.ExecuteScalar() == null)
                {
                    textBox_note.Text = "Données NON disponibles !";
                }
                else
                {
                    textBox_note.Text = Commande.ExecuteScalar().ToString();
                }
                Lecteur.Close();
                Commande.CommandText = "select avg(note) from note where num_sta=" + numeros_sta[p_sta];
                if (Commande.ExecuteScalar() == DBNull.Value || Commande.ExecuteScalar() == null)
                {
                    textBox_moyenne.Text = "Données NON disponibles !";
                }
                else
                {
                    textBox_moyenne.Text = Commande.ExecuteScalar().ToString();
                }
                Program.Connexion.Close();
            }
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            comboBox_stagiaire.SelectedIndex = comboBox_module.SelectedIndex = -1;
            textBox_note.Clear(); textBox_moyenne.Clear();
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            double note;
            if (comboBox_stagiaire.SelectedIndex == -1 || comboBox_module.SelectedIndex == -1 || 
                !double.TryParse(textBox_note.Text, out note) || note > 20 || note < 0)
            {
                Program.Message("Des entrées sont invalides !", "I");
            }
            else
            {
                int p_sta = comboBox_stagiaire.SelectedIndex;
                int p_mod = comboBox_module.SelectedIndex;
                Program.Connexion.Open();
                Commande.CommandText = string.Format("select * from Note where num_sta={0} and num_mod={1}",
                    numeros_sta[p_sta],numeros_mod[p_mod]);
                Lecteur = Commande.ExecuteReader();
                if (Lecteur.HasRows)
                {
                    Program.Message("Note existe déjà !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = string.Format("insert into Note values ({0},{1},{2})",
                    numeros_sta[p_sta], numeros_mod[p_mod], note);
                    int nbr_lignes = Commande.ExecuteNonQuery();
                    if (nbr_lignes == 0)
                    {
                        Program.Message("Note NON ajouté !", "E");
                    }
                    else
                    {
                        Program.Message("Note BIEN ajouté !", "OK");
                    }
                }
                Program.Connexion.Close();
                AfficherNote();
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            double note;
            if (comboBox_stagiaire.SelectedIndex == -1 || comboBox_module.SelectedIndex == -1 ||
                !double.TryParse(textBox_note.Text, out note) || note > 20 || note < 0)
            {
                Program.Message("Des entrées sont invalides !", "I");
            }
            else
            {
                int p_sta = comboBox_stagiaire.SelectedIndex;
                int p_mod = comboBox_module.SelectedIndex;
                Program.Connexion.Open();
                Commande.CommandText = string.Format("select * from Note where num_sta={0} and num_mod={1}",
                    numeros_sta[p_sta], numeros_mod[p_mod]);
                Lecteur = Commande.ExecuteReader();
                if (!Lecteur.HasRows)
                {
                    Program.Message("Note n'existe pas !", "I");
                }
                else
                {
                    Lecteur.Close();
                    Commande.CommandText = string.Format("update Note set note={0}", note);
                    int nbr_lignes = Commande.ExecuteNonQuery();
                    if (nbr_lignes == 0)
                    {
                        Program.Message("Note NON modifié !", "E");
                    }
                    else
                    {
                        Program.Message("Note BIEN modifié !", "OK");
                    }
                }
                Program.Connexion.Close();
                AfficherNote();
            }
        }

        private void button_apercu_Click(object sender, EventArgs e)
        {
            AfficherNote();
        }

        private void dataGridView_notes_SelectionChanged(object sender, EventArgs e)
        {
            int p = dataGridView_notes.CurrentRow.Index;
            if (p != -1)
            {
                comboBox_module.SelectedItem = dataGridView_notes.CurrentRow.Cells[1].ToString();
            }
        }

    }
}
