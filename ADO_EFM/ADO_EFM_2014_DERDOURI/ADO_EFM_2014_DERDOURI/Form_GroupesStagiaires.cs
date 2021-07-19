using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_EFM_2014_DERDOURI
{
    public partial class Form_GroupesStagiaires : Form
    {
        SqlDataAdapter Adapteur = new SqlDataAdapter("", Program.Connexion);
        DataTable Table_Groupes = new DataTable();
        DataTable Table_Stagiaires = new DataTable();

        public Form_GroupesStagiaires()
        {
            InitializeComponent();
            ActualiserGroupes();
        }

        private void ActualiserGroupes()
        {
            Adapteur.SelectCommand.CommandText = @"select Code as Groupe,
                                                    count(*) as [Nombre de stagiaires]
                                                    from Stagiaires S inner join Groupes G
                                                    on S.Groupe = G.Code
                                                    group by Code";
            Table_Groupes.Clear();
            Adapteur.Fill(Table_Groupes);
            dataGridView_groupes.DataSource = Table_Groupes;
            DataGridViewLinkColumn Colonne_Suppression = new DataGridViewLinkColumn();
            Colonne_Suppression.Name = "Suppression";
            Colonne_Suppression.HeaderText = "Suppression";
            Colonne_Suppression.Text = "Supprimer";
            Colonne_Suppression.ToolTipText = "Supprimer le groupe et ses stagiaires";
            Colonne_Suppression.UseColumnTextForLinkValue = true;
            dataGridView_groupes.Columns.Insert(2, Colonne_Suppression);
        }

        private void dataGridView_groupes_SelectionChanged(object sender, EventArgs e)
        {
            int Num_Groupe = Convert.ToInt32(dataGridView_groupes.CurrentRow.Cells["Groupe"].Value);
            label_stagiaires.Text = "Stagiaires du groupe " + Num_Groupe + " :";
            Adapteur.SelectCommand.CommandText = @"select Numéro, Nom, Prénom, Sexe, DateNaissance
                                                    from Stagiaires where Groupe = " + Num_Groupe;
            Table_Stagiaires.Clear();
             Adapteur.Fill(Table_Stagiaires);
            dataGridView_stagiaires.DataSource = Table_Stagiaires;
        }

        private void dataGridView_groupes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DGV_Groupes = (DataGridView)sender;
            if (e.ColumnIndex == 2)
            {
                MessageBox.Show("Test");
                Table_Groupes.Rows[e.RowIndex].Delete();
                ActualiserGroupes();
            }
        }
    }
}
