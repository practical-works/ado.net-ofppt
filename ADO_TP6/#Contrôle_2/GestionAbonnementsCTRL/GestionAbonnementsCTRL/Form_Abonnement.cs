using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionAbonnementsCTRL
{
    public partial class Form_Abonnement : Form
    {
        private GestionAbonnements GESTION_ABONNEMENTS;
        private GestionAbonnés GESTION_ABONNES;

        public Form_Abonnement()
        {
            InitializeComponent();
            GESTION_ABONNEMENTS = new GestionAbonnements();
            GESTION_ABONNES = new GestionAbonnés();
            dataGridView_abonnements.DataSource = GESTION_ABONNEMENTS.Table;

            // Charger les abonnés
            comboBox1.DataSource = GESTION_ABONNES.Table;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ID";
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Choisissez un abonné!");
            }
            else
            {
                if (!GESTION_ABONNEMENTS.Ajouter(numericUpDown1.Value, dateTimePicker1.Value, comboBox1.SelectedValue))
                {
                    MessageBox.Show("Existe déjà!");
                }
            }       
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Choisissez un abonné!");
            }
            else
            {
                if (!GESTION_ABONNEMENTS.Ajouter(numericUpDown1.Value, dateTimePicker1.Value, comboBox1.SelectedValue))
                {
                    MessageBox.Show("N'existe pas!");
                }
            }       
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (!GESTION_ABONNEMENTS.Supprimer(numericUpDown1.Value))
            {
                MessageBox.Show("N'existe pas!");
            }
        }
    }
}
