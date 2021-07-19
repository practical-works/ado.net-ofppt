using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_2017
{
    public partial class Question_C2 : Form
    {
        public Question_C2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("mat", "mat");
            dataGridView1.Columns.Add("nom", "nom");
            dataGridView1.Columns.Add("prenom", "prenom");
            dataGridView1.Columns.Add("tél", "tél");
            dataGridView1.Columns.Add("spéc", "spéc");
        }

        private void Question_C2_Load(object sender, EventArgs e)
        {
            SqlCommand Commande = new SqlCommand("select distinct spécialité from Médecin", Program.Connexion);
            Program.Connexion.Open();
            SqlDataReader Lecteur = Commande.ExecuteReader();
            comboBox1.Items.Clear();
            while (Lecteur.Read())
            {
                comboBox1.Items.Add(Lecteur[0]);
            }
            Lecteur.Close();
            Program.Connexion.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Commande = new SqlCommand("select * from Médecin where spécialité = '" + comboBox1.SelectedItem + "'", Program.Connexion);
            Program.Connexion.Open();
            SqlDataReader Lecteur = Commande.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (Lecteur.Read())
            {
                dataGridView1.Rows.Add(Lecteur[0],Lecteur[1],Lecteur[2],Lecteur[3],Lecteur[4]);
            }
            Lecteur.Close();
            Program.Connexion.Close();
        }
    }
}
