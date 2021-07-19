using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Exercice_1_TP06
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet.Tables["stagiaires"]);
                dataGridView_Stagiaires.DataSource = dataSet;

                //foreach (DataRow item in dataSet.Tables["stagiaires"].Rows)
                //{
                //    dataGridView_Stagiaires.Rows.Add(item["Numéro"], item["Nom"], item["Prénom"], item["Téléphone"]);
                  
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdapter = new SqlDataAdapter("select * from stagiaires", connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet, "stagiaires");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Effacer_Click(object sender, EventArgs e)
        {
            //dataAdapter.Update(dataSet.Tables["Stagiaires"]);
            //dataGridView_Stagiaires.Rows.Clear();
            dataGridView_Stagiaires.DataSource = null;
        }
    }
}
