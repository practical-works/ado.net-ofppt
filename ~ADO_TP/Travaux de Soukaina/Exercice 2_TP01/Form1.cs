using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_2_TP01
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
                command.CommandText = "select * from stagiaires";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_Stagiaires.Items.Clear();
                command.CommandText = "select * from stagiaires";
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                    }
                }
                else MessageBox.Show("erreur !!!");

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Effacer_Click(object sender, EventArgs e)
        {
            listBox_Stagiaires.Items.Clear();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_Stagiaires.Items.Clear();

                reader = command.ExecuteReader();

                //******num

                if (radioButton_Numéro.Checked)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == textBox_valeur.Text)

                                listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    else MessageBox.Show("erreur !!!");

                    reader.Close();
                }


                //******Nom

                else if (radioButton_Nom.Checked)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[1].ToString() == textBox_valeur.Text)


                                listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    else MessageBox.Show("erreur !!!");

                    reader.Close();
                }
                //******prénom

                else if (radioButton_Prénom.Checked)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[2].ToString() == textBox_valeur.Text)
                                
                                listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    else MessageBox.Show("erreur !!!");

                    reader.Close();
                }
                //*******tél

                else if (radioButton_Téléphone.Checked)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[3].ToString() == textBox_valeur.Text)
                                listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    else MessageBox.Show("erreur !!!");

                    reader.Close();
                }

                //string champ = "Numéro";
                //if (radioButton_Nom.Checked)
                //    champ = "Nom";
                //else if (radioButton_Prénom.Checked)
                //    champ = "Prénom";
                //else if (radioButton_Téléphone.Checked)
                //    champ = "Téléphone";

                //listBox_Stagiaires.Items.Clear();

                //command.CommandText = string.Format("select * from stagiaires where {0} = '{1}'", champ, textBox1.Text);
                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                //    }

                //}
                //reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Stagiaire introuvable");
            }        
        }
    }
}
