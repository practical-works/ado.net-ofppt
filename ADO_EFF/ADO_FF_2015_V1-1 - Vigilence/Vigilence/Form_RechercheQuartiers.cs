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
    public partial class Form_RechercheQuartiers : Form
    {
        private static Form_RechercheQuartiers Form;
        public static Form_RechercheQuartiers Formulaire
        {
            get 
            {
                if (Form == null || Form.IsDisposed)
                    Form = new Form_RechercheQuartiers();
                return Form;
            }
        }

        private SqlDataAdapter Adapateur;
        private SqlCommandBuilder GénérateurCommandes;
        private DataTable TableQuartier;
        private DataTable TableVille;
        private DataTable TableBienImmobilier;
        private DataTable TableSyndic;
        
        public Form_RechercheQuartiers()
        {
            InitializeComponent();
            InitialiserChamps();
            Adapateur = new SqlDataAdapter("", Program.Connexion);
            GénérateurCommandes = new SqlCommandBuilder(Adapateur);
            TableQuartier = new DataTable();
            TableVille = new DataTable();
            TableBienImmobilier = new DataTable();
            TableSyndic = new DataTable();

            Adapateur.SelectCommand.CommandText = "select * from Quartier";
            Adapateur.Fill(TableQuartier);
            Adapateur.SelectCommand.CommandText = "select * from Ville";
            Adapateur.Fill(TableVille);

            combo_ville.DataSource = TableVille;
            combo_ville.ValueMember = "code_ville";
            combo_ville.DisplayMember = "nom_ville";
        }

        private void InitialiserChamps()
        {
            num_rechercher.Minimum = num_code.Minimum = 1;
            num_population.Minimum = num_total.Maximum = 0;
            num_rechercher.Maximum = num_code.Maximum = num_population.Maximum = num_total.Maximum = decimal.MaxValue;
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

        private bool AfficherQuartier()
        {
            int Index = Rechercher(num_rechercher.Value, TableQuartier);
            if (Index == -1)
            {
                return false;
            }
            else
            {
                num_code.Value = Convert.ToDecimal(TableQuartier.Rows[Index][0]);
                txt_nom.Text = TableQuartier.Rows[Index][1].ToString();
                num_population.Value = Convert.ToDecimal(TableQuartier.Rows[Index][2]);
                combo_ville.SelectedValue = TableQuartier.Rows[Index][3].ToString();
                num_total.Value = Convert.ToDecimal(TableQuartier.Rows[Index][4]);

                Program.Connexion.Open();
                Adapateur.SelectCommand.CommandText = string.Format(@"
                    select count(*) from Contrat where code_bien in (
	                    select code_bien from Bien_immobilier where code_quartier = {0})
	                    and
	                    datecontrat >= '01-01-' + convert(varchar(4), datepart(year, getdate()));
                ", num_rechercher.Value);
                label_nbr_contrats.Text = Adapateur.SelectCommand.ExecuteScalar().ToString();

                Adapateur.SelectCommand.CommandText = string.Format(@"
                    select sum(total_quartier) from Quartier where code_quartier = {0}
                    and code_quartier in (select code_quartier from Bien_immobilier where code_bien in (
                    select code_bien from Contrat where 
                    datecontrat >= '01-01-' + convert(varchar(4), datepart(year, getdate()))));
                ", num_rechercher.Value);
                if (Adapateur.SelectCommand.ExecuteScalar() != DBNull.Value)
                    label_chiffre_affaires.Text = Adapateur.SelectCommand.ExecuteScalar().ToString() + " DH";
                else
                    label_chiffre_affaires.Text = "0 DH";

                Adapateur.SelectCommand.CommandText = string.Format(@"
                    select count(*) from Syndic where code_syndic in (
	                select code_syndic from Contrat where 
	                code_bien in (select code_bien from Bien_immobilier where code_quartier = {0})
	                and 
	                datecontrat >= '01-01-' + convert(varchar(4), datepart(year, getdate()))
                    );
                ", num_rechercher.Value);
                label_nbr_syndics.Text = Adapateur.SelectCommand.ExecuteScalar().ToString();
                Program.Connexion.Close();

                return true;
            }
        }

        private void button_biens_immobilier_Click(object sender, EventArgs e)
        {
            if (!AfficherQuartier())
            {
                MessageBox.Show("Introuvable !");
            }
            else
            {
                Adapateur.SelectCommand.CommandText = string.Format("select * from Bien_immobilier where code_quartier = {0}",
                    num_rechercher.Value);
                TableBienImmobilier.Clear();
                Adapateur.Fill(TableBienImmobilier);
                dataGridView1.DataSource = TableBienImmobilier;
                label_liste.Text = "Liste des biens immobiliers du quartier :";
            }
        }

        private void button_syndics_Click(object sender, EventArgs e)
        {
            if (!AfficherQuartier())
            {
                MessageBox.Show("Introuvable !");
            }
            else
            {
                Adapateur.SelectCommand.CommandText = string.Format(@"
                    select * from Syndic where code_syndic in ( 
	                    select code_syndic from Contrat where code_bien in (
		                    select code_bien from Bien_immobilier where code_quartier = {0} 
                                and type_bien='Appartement' ))",
                    num_rechercher.Value);
                TableSyndic.Clear();
                Adapateur.Fill(TableSyndic);
                dataGridView1.DataSource = TableSyndic;
                label_liste.Text = "Liste des syndics des appartements du quartier :";
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Trim() == "" || combo_ville.SelectedIndex == -1)
            {
                MessageBox.Show("Champs incomplets");
            }
            else
            {
                int Index = Rechercher(num_code.Value, TableQuartier);
                if (Index != -1)
                {
                    TableQuartier.Rows[Index][1] = txt_nom.Text;
                    TableQuartier.Rows[Index][2] = num_population.Value;
                    TableQuartier.Rows[Index][3] = combo_ville.SelectedValue;
                    TableQuartier.Rows[Index][4] = num_total.Value;
                    Adapateur.SelectCommand.CommandText = "select * from Quartier";
                    Adapateur.Update(TableQuartier);
                }
                else
                {
                    MessageBox.Show("N'existe pas !");
                }
            }
        }
    }
}
