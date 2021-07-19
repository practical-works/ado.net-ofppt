using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_4_TP02
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select numéro from Stagiaires";
            dataReader = command.ExecuteReader();
            comboBox_stagiaires.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Examens.DropDownStyle = ComboBoxStyle.DropDownList;

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    comboBox_stagiaires.Items.Add(string.Format("{0}", dataReader[0]));
                }
                dataReader.Close();
                comboBox_stagiaires.SelectedIndex = 0;
            }
            command.CommandText = "select Id from Examens";
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    comboBox_Examens.Items.Add(string.Format("{0}", dataReader[0]));
                }
                dataReader.Close();
                comboBox_Examens.SelectedIndex = 0;
            }


        }

        private void comboBox_stagiaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_NoteAModifier.Text = string.Empty;
            command.CommandText = string.Format("select note from notes where Examen='{0}' and stagiaire ='{1}'", comboBox_Examens.Text, comboBox_stagiaires.Text);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                textBox_NoteAModifier.Text = dataReader[0].ToString() + "/20";
            }
            else textBox_NoteAModifier.Text = "stagiaire absent!!!";
            dataReader.Close();

        }

        private void comboBox_Examens_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_stagiaires_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void button_ModifierLaNote_Click(object sender, EventArgs e)
        {

            try
            {
                command.CommandText = string.Format("update Notes set Note = '{0}' where Stagiaire = '{1}' and Examen = '{2}'", textBox_NoteAModifier.Text, comboBox_stagiaires.Text, comboBox_Examens.Text);
                if (command.ExecuteNonQuery() == 0)
                    MessageBox.Show("N'existe pas !!!");
                else MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
