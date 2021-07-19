using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_1_TP07
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"");
        
      
        
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();
        DataView dataView;

        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_Croissant.Checked = true;

            dataAdapter = new SqlDataAdapter("select * from notes", connection);
            dataAdapter.Fill(dataSet, "notes");

            dataView = new DataView(dataSet.Tables["notes"]);
            dataView.RowFilter = "1 = 0";

            dataGridView_Stagiaires.DataSource = dataView;
            dataGridView_Stagiaires.Columns[1].Visible = false;
            dataGridView_Stagiaires.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            dataView.RowFilter = string.Format("examen = '{0}'", textBox_Examen.Text);

            if (dataView.Count == 0)
                MessageBox.Show("problème !!!");
        }

        private void button_Trier_Click(object sender, EventArgs e)
        {
            if (radioButton_Croissant.Checked)
                dataView.Sort = "note asc";
            else
                dataView.Sort = "note desc";
        }
    }
}
