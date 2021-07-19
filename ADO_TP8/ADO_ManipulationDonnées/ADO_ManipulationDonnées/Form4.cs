using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_ManipulationDonnées
{
    public partial class Form4 : Form
    {
        // Déclarer une source de liaison
        private BindingSource LIAISON = new BindingSource();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Charger les données
            Program.ADAPTEUR.Fill(Program.BASE_LOCALE, "Exemple");
            /* ou Program.ADAPTEUR.Fill(Program.BASE_LOCALE.Tables["Exemple"]); */

            // Lier les données à la source de liaision
            LIAISON.DataSource = Program.BASE_LOCALE.Tables["Exemple"];
            
            // Lier les contrôles du formulaire à la source de liaison
            textBox1.DataBindings.Add("Text", LIAISON, "Code");
            textBox2.DataBindings.Add("Text", LIAISON, "Nom");
            textBox3.DataBindings.Add("Text", LIAISON, "Valeur");
            checkBox1.DataBindings.Add("Checked", LIAISON, "Mode");

            // Lier la grille à la source de liaison
            dataGridView1.DataSource = LIAISON;

            // Lier le navigateur à la source de liaison 
            bindingNavigator1.BindingSource = LIAISON;
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            // Naviguer vers le dernier enregistrement
            LIAISON.MoveLast();
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            // Naviguer vers l'enregistrement suivant
            LIAISON.MoveNext();
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            // Naviguer vers l'enregistrement précédent
            LIAISON.MovePrevious();
        }

        private void button_premier_Click(object sender, EventArgs e)
        {
            // Naviguer vers le premier enregistrement
            LIAISON.MoveFirst();
        }
    }
}
