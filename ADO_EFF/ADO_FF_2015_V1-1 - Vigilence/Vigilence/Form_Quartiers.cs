using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vigilence
{
    public partial class Form_Quartiers : Form
    {
        private static Form_Quartiers Form;
        public static Form_Quartiers Formulaire
        {
            get
            {
                if (Form == null || Form.IsDisposed)
                    Form = new Form_Quartiers();
                return Form;
            }
        }

        private SqlDataAdapter Adapateur;
        private SqlCommandBuilder GénérateurCommandes;
        private DataTable TableQuartier;
        private DataTable TableVille;

        private enum PositionNaviagtion { Premier, Précédent, Suivant, Dernier }
        private int IndexPosition;

        public Form_Quartiers()
        {
            InitializeComponent();
            InitialiserChamps();
            Adapateur = new SqlDataAdapter("", Program.Connexion);
            GénérateurCommandes = new SqlCommandBuilder(Adapateur);
            TableQuartier = new DataTable();
            TableVille = new DataTable();
            IndexPosition = 0;

            Adapateur.SelectCommand.CommandText = "select * from Quartier";
            Adapateur.Fill(TableQuartier);
            Adapateur.SelectCommand.CommandText = "select * from Ville";
            Adapateur.Fill(TableVille);

            dataGridView1.DataSource = TableQuartier;
            combo_ville.DataSource = TableVille;
            combo_ville.ValueMember = "code_ville";
            combo_ville.DisplayMember = "nom_ville";
        }

        private void InitialiserChamps()
        {
            num_code.Minimum = 1;
            num_population.Minimum = num_total.Maximum = 0;
            num_code.Maximum = num_population.Maximum = num_total.Maximum = decimal.MaxValue;
        }
        private void ViderChamps()
        {
            txt_nom.Clear();
            combo_ville.SelectedIndex = -1;
            num_code.Value = num_code.Minimum;
            num_population.Value = num_population.Minimum;
            num_total.Value = num_total.Minimum;
        }

        private int Rechercher(object Code, DataTable Table)
        {
            foreach (DataRow ligne in Table.Rows)
            {
                if (ligne[0].ToString() == Code.ToString() && ligne.RowState != DataRowState.Deleted)
                {
                    return Table.Rows.IndexOf(ligne);
                }
            }
            return -1;
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            ViderChamps();
            num_code.Focus();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Trim() == "" || combo_ville.SelectedIndex == -1)
            {
                MessageBox.Show("Champs incomplets");
            }
            else
            {
                int Index = Rechercher(num_code.Value, TableQuartier);
                if (Index == -1)
                {
                    TableQuartier.Rows.Add(num_code.Value, txt_nom.Text, num_population.Value,
                        combo_ville.SelectedValue, num_total.Value);
                }
                else
                {
                    MessageBox.Show("Existe déjà !");
                }
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int Index = Rechercher(num_code.Value, TableQuartier);
            if (Index != -1)
            {
                TableQuartier.Rows[Index].Delete();
                ViderChamps();
            }
            else
            {
                MessageBox.Show("N'existe pas !");
            }
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            Adapateur.SelectCommand.CommandText = "select * from Quartier";
            Adapateur.Update(TableQuartier);
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Naviguer(PositionNaviagtion Position)
        {
            int IndexPositionDernier = TableQuartier.Rows.Count - 1;
            switch (Position)
            {
                case PositionNaviagtion.Premier:
                    IndexPosition = 0;
                    break;
                case PositionNaviagtion.Précédent:
                    if (IndexPosition != 0) IndexPosition--;
                    else IndexPosition = IndexPositionDernier;
                    break;
                case PositionNaviagtion.Suivant:
                    if (IndexPosition != IndexPositionDernier) IndexPosition++;
                    else IndexPosition = 0;
                    break;
                case PositionNaviagtion.Dernier:
                    IndexPosition = IndexPositionDernier;
                    break;
                default:
                    throw new Exception("Position invalide");
            }
            num_code.Value = Convert.ToDecimal(TableQuartier.Rows[IndexPosition][0]);
            txt_nom.Text = TableQuartier.Rows[IndexPosition][1].ToString();
            num_population.Value = Convert.ToDecimal(TableQuartier.Rows[IndexPosition][2]);
            combo_ville.SelectedValue = TableQuartier.Rows[IndexPosition][3].ToString();
            num_total.Value = Convert.ToDecimal(TableQuartier.Rows[IndexPosition][4]);
        }

        private void button_premier_Click(object sender, EventArgs e)
        {
            Naviguer(PositionNaviagtion.Premier);
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            Naviguer(PositionNaviagtion.Précédent);
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            Naviguer(PositionNaviagtion.Suivant);
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            Naviguer(PositionNaviagtion.Dernier);
        }

        private void Form_Quartiers_Load(object sender, EventArgs e)
        {
            Naviguer(PositionNaviagtion.Premier);
        }
    }
}
