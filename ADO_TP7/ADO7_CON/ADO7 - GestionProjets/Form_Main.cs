using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO7___GestionProjets
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void FormOpen(Form F)
        {
            F.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Employés
            EMPLOYE.Employe.dataGridView = dataGridView_employes;
            EMPLOYE.Employe.Afficher();
            // Projets
            /*Projet.Projet.dataGridView = dataGridView_projets;
            Projet.Projet.Afficher();*/
            // Inscriptions
            /*Inscription.Inscription.dataGridView = dataGridView_inscriptions;
            Inscription.Inscription.Afficher();*/
        }

        private void button_ajouter_employe_Click(object sender, EventArgs e)
        {
            FormOpen(new EMPLOYE.Form_Ajouter());
        }

        private void button_modifier_employe_Click(object sender, EventArgs e)
        {
            FormOpen(new EMPLOYE.Form_Modifier());
        }

        private void button_supprimer_employe_Click(object sender, EventArgs e)
        {
            FormOpen(new EMPLOYE.Form_Supprimer());
        }

        private void button_rechercher_employe_Click(object sender, EventArgs e)
        {
            FormOpen(new EMPLOYE.Form_Rechercher());
        }

        private void button_trier_employe_Click(object sender, EventArgs e)
        {
            FormOpen(new EMPLOYE.Form_Trier());
        }
    }
}
