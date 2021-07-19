using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_1_TP03
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
                this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

                dataGridView_Stagiaires.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                command.Connection = connection;
                command.CommandText = "select * from stagiaires";

                reader = command.ExecuteReader();

                table.Load(reader);

                reader.Close();
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

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            dataGridView_Stagiaires.DataSource = table;
        }

        private void button_Effacer_Click(object sender, EventArgs e)
        {
            dataGridView_Stagiaires.DataSource = null;
        }
    }
}
