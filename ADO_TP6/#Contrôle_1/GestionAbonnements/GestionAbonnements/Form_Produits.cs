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
    public partial class Form_Produits : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;

        public Form_Produits()
        {
            InitializeComponent();
        }

        public void MISE_A_JOUR()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Produit";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_PAR_LIBELLE()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = string.Format("select * from Produit where Libelle like '{0}%'", textBox_libelle.Text);
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_PAR_PRIX()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = string.Format("select * from Produit where Prix={0}", numericUpDown_prix.Value);
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }

        private void radioButton_tous_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_tous.Checked)
            {
                MISE_A_JOUR();
            }
        }

        private void radioButton_libelle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_libelle.Checked)
            {
                MISE_A_JOUR_PAR_LIBELLE();
            }
        }

        private void radioButton_prix_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_prix.Checked)
            {
                MISE_A_JOUR_PAR_PRIX();
            }
        }

        private void Form_Produits_Load(object sender, EventArgs e)
        {

        }

        private void textBox_libelle_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_libelle.Checked)
            {
                MISE_A_JOUR_PAR_LIBELLE();
            }
        }

        private void numericUpDown_prix_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton_prix.Checked)
            {
                MISE_A_JOUR_PAR_PRIX();
            }
        }
    }
}
