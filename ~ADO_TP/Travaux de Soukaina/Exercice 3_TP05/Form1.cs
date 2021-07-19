using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Exercice_3_TP05
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //stagiaires
                dataAdapter = new SqlDataAdapter("select * from stagiaires", connection);
                dataAdapter.Fill(dataSet, "stagiaires");
                comboBox_stagiaires.DisplayMember = "numéro";
                comboBox_stagiaires.DataSource = dataSet.Tables["stagiaires"];
                comboBox_stagiaires.DropDownStyle = ComboBoxStyle.DropDownList;

                //examens
                dataAdapter = new SqlDataAdapter("select * from examens", connection);
                dataAdapter.Fill(dataSet, "examens");
                comboBox_Examens.DisplayMember = "Id";
                comboBox_Examens.DataSource = dataSet.Tables["examens"];
                comboBox_Examens.DropDownStyle = ComboBoxStyle.DropDownList;

                //notes
                dataAdapter = new SqlDataAdapter("select * from notes", connection);
                dataAdapter.Fill(dataSet, "notes");
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AfficherNote()
        {
            foreach (DataRow ligne in dataSet.Tables["notes"].Rows)
            {
                if (ligne["stagiaires"].ToString() == comboBox_stagiaires.Text && ligne["examens"].ToString() == comboBox_Examens.Text)
                {
                    textBox_NoteAModifier.Text = ligne["notes"].ToString();
                    return;
                }
            }
            textBox_NoteAModifier.Text = "stagiaire absent !!!";
        }

        private void button_ModifierLaNote_Click(object sender, EventArgs e)
        {
            dataAdapter.FillSchema(dataSet, SchemaType.Source, "stagiaires");
            dataAdapter.Fill(dataSet, "stagiaires");

            DataRow examen = dataSet.Tables["examens"].Rows[comboBox_Examens.SelectedIndex];
            foreach (DataRow lignes in dataSet.Tables["examens"].Rows)
            {
                if (examen["stagiaires"].ToString() == comboBox_stagiaires.Text && examen["examens"].ToString() == comboBox_Examens.Text)
                {
                    textBox_NoteAModifier.Text = examen["notes"].ToString();
                    return;
                }
                
            }

        }


        private void comboBox_stagiaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherNote();
        }

        private void comboBox_Examens_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherNote();
        }
    }
}
