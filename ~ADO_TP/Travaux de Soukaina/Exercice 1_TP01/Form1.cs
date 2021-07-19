using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_1_TP01
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
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox_Stagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                    }

                }
                else MessageBox.Show("Erreur !!");
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
    }
}
