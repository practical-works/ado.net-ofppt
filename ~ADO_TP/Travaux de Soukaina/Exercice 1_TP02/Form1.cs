using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exercice_1_TP02
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
                //command.ExecuteReader();

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

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = string.Format("insert into stagiaires values ('{0}', '{1}', '{2}', '{3}')", textBox_Numéro.Text, textBox_Nom.Text, textBox4_Prénom.Text, textBox_Téléphone.Text);

                command.ExecuteNonQuery();

                RemplirLaListe();

                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {

            try
            {
                command.CommandText = string.Format("update stagiaires set Téléphone = '{0}' where Numéro = '{1}'", textBox_TélAModifier.Text, textBox_NumAModifier);

                if (command.ExecuteNonQuery() == 0)
                    MessageBox.Show("N'existe pas !!!");
                else MessageBox.Show("OK");

                RemplirLaListe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = string.Format("delete stagiaires where Numéro = '{0}'", textBox_NumASupprimer.Text);
                command.ExecuteNonQuery();

                RemplirLaListe();

                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemplirLaListe()
        {
            try
            {
                listBox1.Items.Clear();

                command.CommandText = "select * from stagiaires";

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(string.Format("{0} : {1} {2}, {3}", reader["Numéro"], reader["Nom"], reader["Prénom"], reader["Téléphone"]));
                    }
                }
                else MessageBox.Show("Table vide !!!");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        