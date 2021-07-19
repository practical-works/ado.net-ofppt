using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_2_TP03
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        DataTable table = new DataTable();
        DataTable datatable_tous = new DataTable();//chargement load et utilisation bout Afficher

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
                table.Clear();

                //command.Connection = connection;
                command.CommandText = "select * from Stagiaires";
                reader = command.ExecuteReader();

                table.Load(reader);
                reader.Close();
                dataGridView_stagiaires.DataSource = table;
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

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable_recherche = new DataTable();//chargement ici et utilisation 
                //command.Connection = connection;
                command.CommandText = string.Format("select * from Stagiaires where Nom like '%{0}%'", textBox1.Text);
                reader = command.ExecuteReader();
                dataGridView_stagiaires.DataSource = table;
                table.Load(reader);
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //methode chargement DGV (select, dt)
        }

    }
}
