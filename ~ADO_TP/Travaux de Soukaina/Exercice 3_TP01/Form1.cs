using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_3_TP01
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
		        reader = command.ExecuteReader();
                comboBox_Numero.DropDownStyle = ComboBoxStyle.DropDownList;
		        if(reader.HasRows)
		        {
			        while(reader.Read())
			        {
				        comboBox_Numero.Items.Add(reader[0]);
			        }
			        comboBox_Numero.SelectedIndex = 0;
		        }
                reader.Close();
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

        private void comboBox_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = string.Format("select Nom, Prénom, Téléphone from Stagiaires where Numéro = '{0}'", comboBox_Numero.Text);
                reader = command.ExecuteReader();
                reader.Read();
                textBox_Nom.Text = reader[0].ToString();
                textBox_Prenom.Text = reader[1].ToString();
                textBox_Tel.Text = reader[2].ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
