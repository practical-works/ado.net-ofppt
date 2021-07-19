using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_2_TP02
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
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
                connection.Open();
                command.Connection = connection;
                Mis();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Mis()
        {
            command.CommandText = "select numéro from stagiaires";
            reader = command.ExecuteReader();
            comboBox_Numero.DropDownStyle = ComboBoxStyle.DropDownList;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox_Numero.Items.Add(string.Format("{0}", reader[0]));
                }
                reader.Close();
                comboBox_Numero.SelectedIndex = 0;
            }
            else MessageBox.Show("Table vide !!!");
        }

        private void comboBox_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            command.CommandText = string.Format("select * from stagiaires where numéro ='{0}'", comboBox_Numero.Text);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                textBox_Nom.Text = reader[1].ToString();
                textBox_Prenom.Text = reader[2].ToString();
                textBox_Tel.Text = reader[3].ToString();
            }
            else MessageBox.Show("Table vide !!!");
            reader.Close();
            //}
            //catch (Exception ex)
            //{
            //  MessageBox.Show(ex.Message);
            //}
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = string.Format("update stagiaires set Téléphone = '{0}', Nom = '{1}' ,  prénom ='{2}' where Numéro = '{3}'", textBox_Tel.Text, textBox_Nom.Text, textBox_Prenom.Text, comboBox_Numero.Text);
                if (command.ExecuteNonQuery() == 0)
                    MessageBox.Show("N'existe pas !!!");
                else MessageBox.Show("OK");
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

                command.CommandText = string.Format("delete stagiaires where Numéro = '{0}'", comboBox_Numero.Text);
                command.ExecuteNonQuery();
                Mis();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
