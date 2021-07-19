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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Charger les données
            Program.ADAPTEUR.Fill(Program.BASE_LOCALE, "Exemple");

            // Définir les clés primaires
            /* ds.Tables[0].Columns[0].Unique = true; */
            DataColumn[] cles_primaires = { Program.BASE_LOCALE.Tables["Exemple"].Columns["Code"] };
            Program.BASE_LOCALE.Tables["Exemple"].PrimaryKey = cles_primaires;

            // Afficher les données
            dataGridView1.DataSource = Program.BASE_LOCALE.Tables["Exemple"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Appliquer les mise à jour à la base de données
            Program.ADAPTEUR.Update(Program.BASE_LOCALE.Tables["Exemple"]);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Déterminer le message d'erreur
            string message_erreur = "";
            switch (e.ColumnIndex)
            {
                // Cas de la colonne Code
                case 0: message_erreur = "Le CODE entré est incorrect !"; break;
                // Cas de la colonne valeur
                case 2: message_erreur = "La VALEUR entrée est incorrect !"; break;
                // Cas d'une autre colonne
                default: message_erreur = "Une erreur s'est produite !"; break;
            }

            // Ajouter des infos supplémentaires au message d'erreur
            
            //      • Afficher la valeur de la cellule
            message_erreur += "\n\nLa cellule contient : "
                           + dataGridView1.CurrentCell.Value;
            /*            ou dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value; */
            
            //      • Afficher la valeur saisie dans la cellule
            message_erreur += "\nVous avez saisi : "
                           + dataGridView1.CurrentCell.EditedFormattedValue;
            
            //      • Afficher le message de l'exception
            message_erreur += "\n\n" + e.Exception.Message;

            // Afficher le message d'erreur
            MessageBox.Show(message_erreur, dataGridView1.CurrentCell.OwningColumn.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            // Lancer l'erreur quand la condition est vérifié
            /* dataGridView1.CurrentCell.ColumnIndex = 2; ou dataGridView1.CurrentCell.OwningColumn.Name */
            if (dataGridView1.CurrentCell.OwningColumn.Name == "valeur" && (double)dataGridView1.CurrentCell.Value > 99)
            {
                DataGridViewDataErrorEventArgs E = new DataGridViewDataErrorEventArgs(new ValeurInvalideException(), e.ColumnIndex, e.RowIndex, DataGridViewDataErrorContexts.Commit);
                dataGridView1_DataError(sender, E);
            }
        }
    }
}
