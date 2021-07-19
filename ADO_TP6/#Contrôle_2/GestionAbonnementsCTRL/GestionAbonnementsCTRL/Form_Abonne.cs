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
    public partial class Form_Abonne : Form
    {
        private GestionAbonnés GESTION_ABONNES;
        private bool ToutCoche;

        public Form_Abonne()
        {
            InitializeComponent();
            ToutCoche = false;
            GESTION_ABONNES = new GestionAbonnés();
            dataGridView_abonnes.DataSource = GESTION_ABONNES.Table;
            
            // Ajouter les colonnes de cases à cocher
            DataGridViewCheckBoxColumn ColonneSelection = new DataGridViewCheckBoxColumn();
            ColonneSelection.Name = "ColonneSelection";
            ColonneSelection.HeaderText = "Sélectionner";
            dataGridView_abonnes.Columns.Add(ColonneSelection);
        }

        private void button_cocherTout_Click(object sender, EventArgs e)
        {
            if (ToutCoche)
            {
                button_cocherTout.Text = "Cocher Tout";
                foreach (DataGridViewRow Ligne in dataGridView_abonnes.Rows)
                {
                    Ligne.Cells["ColonneSelection"].Value = false;
                }
                ToutCoche = false;
            }
            else
            {
                button_cocherTout.Text = "Décocher Tout";
                foreach (DataGridViewRow Ligne in dataGridView_abonnes.Rows)
                {
                    Ligne.Cells["ColonneSelection"].Value = true;
                }
                ToutCoche = true;
            } 
        }

        private void button_supprCoche_Click(object sender, EventArgs e)
        {
            DataGridViewRow Ligne = new DataGridViewRow();
            for (int i = 0; i < dataGridView_abonnes.Rows.Count; i++)
            {
                Ligne = dataGridView_abonnes.Rows[i];
                if (Convert.ToBoolean(Ligne.Cells[0].Value))
                {
                    dataGridView_abonnes.Rows.Remove(Ligne);
                    i--;
                }
            }  
        }

        private void textBox_filtre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_filtre.Text.Trim() == "")
            {
                dataGridView_abonnes.DataSource = GESTION_ABONNES.Table;
                GESTION_ABONNES.Filtrer("");
            }
            else
            {
                dataGridView_abonnes.DataSource = GESTION_ABONNES.Filtrer(textBox_filtre.Text.Trim());
            }
        }
    }
}
