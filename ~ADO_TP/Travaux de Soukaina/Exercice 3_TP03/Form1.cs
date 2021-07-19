using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_3_TP03
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                dataGridView_stagiaires.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button_afficherTous_Click(object sender, EventArgs e)
        {
            try
            {

                command.Connection = connection;
                command.CommandText = "select * from Stagiaires";
                reader = command.ExecuteReader();

                dataGridView_stagiaires.DataSource = table;
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Effacer_Click(object sender, EventArgs e)
        {
            dataGridView_stagiaires.DataSource = null;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                foreach (RadioButton radion in panel1.Controls)
                {
                    if (radion.Checked)
                    {
                        command.CommandText = string.Format("select * from Stagiaires where {0} like '%{1}%'", radion.Text, textBox1.Text);
                        break;
                    }
                }

                reader = command.ExecuteReader();
                dataGridView_stagiaires.DataSource = table;
                table.Load(reader);
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


    }
}
