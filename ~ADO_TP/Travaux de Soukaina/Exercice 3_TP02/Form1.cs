using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_3_TP02
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                command.Connection = cnx;
                button_ChargerLesListes.Enabled = true;
                button_AfficherLaNote.Enabled = false;
                button_ModifierLaNote.Enabled = false;
                comboBox_Examens.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox_Stagiaires.DropDownStyle = ComboBoxStyle.DropDownList;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
               
            }

        }

        private void button_ChargerLesListes_Click(object sender, EventArgs e)
        {
            ChargerLescombobox();
            button_ChargerLesListes.Enabled = false;
            button_AfficherLaNote.Enabled = true;
            button_ModifierLaNote.Enabled = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnx.Close();
        }

        private void ChargerLescombobox()
        {
            try
            {

                // combobox stagiaires
                command.CommandText = "select Numéro from Stagiaires";

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox_Stagiaires.Items.Add(string.Format("{0}", reader[0]));
                    }
                    reader.Close();
                    comboBox_Stagiaires.SelectedIndex = -1;

                }
                else MessageBox.Show("erreur!!");
                

                // combobox examens

                command.CommandText = "select ID from Examens";

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox_Examens.Items.Add(string.Format("{0}", reader[0]));
                    }
                    reader.Close();
                    comboBox_Examens.SelectedIndex = -1;

                }
                else MessageBox.Show("erreur!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        
        }

        private void button_AfficherLaNote_Click(object sender, EventArgs e)
        {
            
            
            //command.CommandText = string.Format("select * from Notes where Stagiaire ='{0}'", comboBox_Stagiaires.Text);
            command.CommandText = string.Format("select Note from Notes where Examen ='{0}' and Stagiaire ='{1}' ", comboBox_Examens.Text, comboBox_Stagiaires.Text);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBox_Note.Text = reader[0].ToString();
            }
            else MessageBox.Show("Stagiaire absent!!!");
            reader.Close();
        }

        private void button_ModifierLaNote_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = string.Format("select Note from Notes where Examen ='{0}' and Stagiaire ='{1}' ", comboBox_Examens.Text, comboBox_Stagiaires.Text);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    command.CommandText = string.Format("update Notes set Note = '{0}' where Stagiaire = '{1}' and Examen = '{2}'", textBox_Note.Text, comboBox_Stagiaires.Text, comboBox_Examens.Text);

                    command.ExecuteNonQuery();
                }
                else
                    reader.Close();
                command.CommandText = string.Format("insert into Stagiaires values ('{0}','{1}','{2}')", comboBox_Stagiaires.Text, comboBox_Examens.Text, textBox_Note.Text);
                command.ExecuteNonQuery();
                  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}