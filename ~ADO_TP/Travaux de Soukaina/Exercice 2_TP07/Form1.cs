using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_2_TP07
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();
        DataView dataView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("select * from stagiaires", connection);
            dataAdapter.Fill(dataSet, "stagiaires");

            dataView = new DataView(dataSet.Tables["stagiaires"]);
            dataGridView1.DataSource = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //radioButton_Numéro.Checked = true;
            //textBox_Numéro.Enabled = true;
            //textBox_Nom.Enabled = false;
            //textBox_Prénom.Enabled = false;
            //textBox_Téléphone.Enabled = false;  
            

        }

        private void radioButton_Numéro_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Numéro.Enabled = true;
            textBox_Nom.Enabled = false;
            textBox_Prénom.Enabled = false;
            textBox_Téléphone.Enabled = false;

            

        }

        private void radioButton_Prénom_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Numéro.Enabled = false;
            textBox_Nom.Enabled = false;
            textBox_Prénom.Enabled = true;
            textBox_Téléphone.Enabled = false;
        }

        private void radioButton_Nom_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Numéro.Enabled = false;
            textBox_Nom.Enabled = true;
            textBox_Prénom.Enabled = false;
            textBox_Téléphone.Enabled = false;

        }

        private void radioButton_Téléphone_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Numéro.Enabled = false;
            textBox_Nom.Enabled = false;
            textBox_Prénom.Enabled = false;
            textBox_Téléphone.Enabled = true;

        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            if (textBox_Numéro.Text != string.Empty)
            { 
                dataView.RowFilter = string.Format("numéro='{0}'", textBox_Numéro.Text);
                dataGridView1.DataSource = dataView;
            }
            else if (textBox_Nom.Text != string.Empty)
            {
                dataView.RowFilter = string.Format("nom like'%{0}%'", textBox_Nom.Text);
                dataGridView1.DataSource = dataView;
            }
            else if (textBox_Prénom.Text != string.Empty)
            {
                dataView.RowFilter = string.Format("Prénom like'%{0}%'", textBox_Prénom.Text);
                dataGridView1.DataSource = dataView;
            }
            else if (textBox_Téléphone.Text != string.Empty)
            {
                dataView.RowFilter = string.Format("téléphone like'%{0}'%", textBox_Téléphone.Text);
                dataGridView1.DataSource = dataView;
            }
        }

    }
}
