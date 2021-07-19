using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ADO_ManipulationDonnées
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Charger les données
            Program.ADAPTEUR.Fill(Program.BASE_LOCALE, "Exemple");
            dataGridView1.DataSource = Program.BASE_LOCALE.Tables["Exemple"];

            // Ajouter une colonne avec ComboBox
            DataGridViewComboBoxColumn ColonneCMBX = new DataGridViewComboBoxColumn();
            ColonneCMBX.HeaderText = "Choix";
            ColonneCMBX.Items.AddRange("Choix 1", "Choix 2 ", "Choix 3", "Choix 4", "Choix 5");
            dataGridView1.Columns.Add(ColonneCMBX);

            DataGridViewCheckBoxColumn ColonneCKBX = new DataGridViewCheckBoxColumn();
            ColonneCKBX.HeaderText = "Sélectionner";
            dataGridView1.Columns.Add(ColonneCKBX);

            // Récupérer la date de mise à jour dans depuis un fichier
            Stream S = File.OpenRead("date_mise_a_jour");
            if (S.Length != 0)
            {
                BinaryFormatter B = new BinaryFormatter();
                DateTime date = (DateTime)B.Deserialize(S);
                    label_date_lignes.Text = string.Format("Mis à jour le {0} à {1}.\n0 lignes affectées.",
                    date.ToShortDateString(), date.ToLongTimeString());
                S.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Appliquer la mise à jour sur la base de données
                int nbr_lignes = Program.ADAPTEUR.Update(Program.BASE_LOCALE, "Exemple");
                
                // Afficher la date de mise à jour et le nombre de lignes affectées
                DateTime date = DateTime.Now;
                label_date_lignes.Text = string.Format("Mis à jour le {0} à {1}.\n{2} lignes affectées.",
                    date.ToShortDateString(), date.ToLongTimeString(), nbr_lignes);

                // Mémoriser la date de mise à jour dans un fichier
                Stream S = File.OpenWrite("date_mise_a_jour");
                BinaryFormatter B = new BinaryFormatter();
                B.Serialize(S, date);
                S.Close();
            }
            catch (Exception exp)
            {
                // Afficher le message de l'exception
                MessageBox.Show(exp.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            // Recharger les donnée
            Program.BASE_LOCALE.Clear();
            Program.ADAPTEUR.Fill(Program.BASE_LOCALE, "Exemple");
            dataGridView1.DataSource = Program.BASE_LOCALE.Tables["Exemple"];
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if ((bool)dataGridView1.Rows[i].Cells[5].Value == true)
            //    {
            //        dataGridView1.Rows.RemoveAt(i);
            //    }
            //}
        }

    }
}
