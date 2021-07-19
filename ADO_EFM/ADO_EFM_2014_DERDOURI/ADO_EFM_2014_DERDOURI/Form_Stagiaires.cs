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
    public partial class Form_Stagiaires : Form
    { 
        static SqlDataAdapter Adapteur = new SqlDataAdapter("", Program.Connexion);
        SqlCommandBuilder GénérateurCommandes = new SqlCommandBuilder(Adapteur);
        DataTable Table_Stagiaires = new DataTable();
        DataTable Table_Groupes = new DataTable();
        BindingSource Liaison = new BindingSource();

        public Form_Stagiaires()
        {
            InitializeComponent();

            Adapteur.SelectCommand.CommandText = "select *,Filière+'_'+convert(varchar,Code) as NomGroupe from Groupes";
            Adapteur.Fill(Table_Groupes);
            comboBox_groupe.DataSource = Table_Groupes;
            comboBox_groupe.DisplayMember = "NomGroupe";
            comboBox_groupe.ValueMember = "Code";

            Adapteur.SelectCommand.CommandText = "select * from Stagiaires";
            Adapteur.Fill(Table_Stagiaires);
            DataColumn[] CléPrimaires = new DataColumn[1];
            CléPrimaires[0] = Table_Stagiaires.Columns[0];
            Table_Stagiaires.PrimaryKey = CléPrimaires;

            Liaison.DataSource = Table_Stagiaires;
            dataGridView_stagiaires.DataSource = Liaison;

            numericUpDown_numero.DataBindings.Add("Value", Liaison, "Numéro");
            textBox_nom.DataBindings.Add("Text", Liaison, "Nom");
            textBox_prenom.DataBindings.Add("Text", Liaison, "Prénom");
            //radioButton_masculin.DataBindings.Add("Checked", Liaison, "Sexe");
            dateTimePicker_datenaissance.DataBindings.Add("Value", Liaison, "DateNaissance");
            comboBox_groupe.DataBindings.Add("SelectedValue", Liaison, "Groupe");

            Liaison.PositionChanged += new EventHandler(Liaison_PositionChanged);
            textBox_position.LostFocus += new EventHandler(textBox_position_LostFocus);
        }

        private void textBox_position_LostFocus(object sender, EventArgs e)
        {
            int Position;
            if (int.TryParse(textBox_position.Text.Trim(), out Position))
            {
                Liaison.Position = Position - 1;
            }
        }

        private void Liaison_PositionChanged(object sender, EventArgs e)
        {
            label_compte.Text = "/ " + Liaison.Count;
            int Position = Liaison.Position + 1;
            textBox_position.Text = Position.ToString();
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            numericUpDown_numero.Value = numericUpDown_numero.Minimum;
            textBox_nom.Clear(); textBox_prenom.Clear();
            radioButton_masculin.Checked = radioButton_feminin.Checked = false;
            dateTimePicker_datenaissance.Value = DateTime.Now;
            comboBox_groupe.SelectedIndex = -1;
            numericUpDown_numero.Focus();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            DataRow Ligne = Table_Stagiaires.Rows.Find(numericUpDown_numero.Value);
            if (Ligne != null)
            {
                MessageBox.Show("Existe déjà !");
            }
            else
            {
                string Sexe = (radioButton_masculin.Checked) ? "M" : "F";
                Table_Stagiaires.Rows.Add(numericUpDown_numero.Value, textBox_nom.Text, textBox_prenom.Text,
                    Sexe, dateTimePicker_datenaissance.Value, comboBox_groupe.SelectedValue);
                Adapteur.Update(Table_Stagiaires);
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            DataRow Ligne = Table_Stagiaires.Rows.Find(numericUpDown_numero.Value);
            if (Ligne == null)
            {
                MessageBox.Show("N'existe pas !");
            }
            else
            {
                Ligne[1] = (textBox_nom.Text.Trim() != "") ? textBox_nom.Text.Trim() :  "Aucun";
                Ligne[2] = (textBox_prenom.Text.Trim() != "") ? textBox_nom.Text.Trim() : "Aucun";
                Ligne[3] = (radioButton_masculin.Checked) ? "M" : "F";
                Ligne[4] = dateTimePicker_datenaissance.Value;
                Ligne[5] = (comboBox_groupe.SelectedValue != null) ? comboBox_groupe.SelectedValue : DBNull.Value;
                Adapteur.Update(Table_Stagiaires);
            }    
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DataRow Ligne = Table_Stagiaires.Rows.Find(numericUpDown_numero.Value);
            if (Ligne == null)
            {
                MessageBox.Show("N'existe pas !");
            }
            else
            {
                Ligne.Delete();
                Adapteur.Update(Table_Stagiaires);
            } 
        }

        private void button_premier_Click(object sender, EventArgs e)
        {
            Liaison.MoveFirst();
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            Liaison.MovePrevious();
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            Liaison.MoveNext();
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            Liaison.MoveLast();
        }
    }
}
