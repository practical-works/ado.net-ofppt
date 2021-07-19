using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO7___GestionProjets.EMPLOYE
{
    public partial class Form_Rechercher : Form
    {
        private string Filtre = "";

        public Form_Rechercher()
        {
            InitializeComponent();
        }

        private void Form_Rechercher_Load(object sender, EventArgs e)
        {
            Employe.dataGridView = dataGridView_employes;
        }
     
        private void Afficher()
        {
            Filtre = textBox1.Text.Trim();
            if (comboBox1.SelectedIndex == 0) //Nom
            {
                Employe.AfficherAvecFiltre("Nom", Filtre);
            }
            if (comboBox1.SelectedIndex == 1) //Prénom
            {
                Employe.AfficherAvecFiltre("Prenom", Filtre);
            }
            if (comboBox1.SelectedIndex == 2) //Fonction
            {
                Employe.AfficherAvecFiltre("Fonction", Filtre);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            Afficher();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Afficher();
        }
    }
}
