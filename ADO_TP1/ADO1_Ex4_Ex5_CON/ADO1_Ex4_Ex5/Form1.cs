using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO1_Ex4_Ex5
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            ActualiserCIN();
            ActualiserTout();
        }

        public void ActualiserCIN()
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from Client", cnx);
                SqlDataReader da = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (da.Read())
                {
                    comboBox1.Items.Add(da[0]);
                }
                cnx.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualiserTout()
        {
            try
            {
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Client", cnx);
                DataSet ds = new DataSet();
                da.Fill(ds, "Client");
                dataGridView1.DataSource = ds.Tables["Client"];
                cnx.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualiserSelection()
        {
            try
            {
                string cin = comboBox1.SelectedItem.ToString();
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Client where CIN=" + cin, cnx);
                DataSet ds = new DataSet();
                da.Fill(ds, "Client");
                dataGridView1.DataSource = ds.Tables["Client"];
                cnx.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualiserTout();
            ActualiserCIN();
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserSelection();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value + " - " +
                            dataGridView1.CurrentRow.Cells[1].Value + " " +
                            dataGridView1.CurrentRow.Cells[2].Value + " ";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value + " - " +
                            dataGridView1.CurrentRow.Cells[1].Value + " " +
                            dataGridView1.CurrentRow.Cells[2].Value + " ";
        }
    }
}
