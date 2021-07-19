using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO0_Ex0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Open)
            {
                MessageBox.Show("Connexion déjà ouverte");
            }
            else if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
                listBox1.Enabled = true;
                textBox1.ForeColor = Color.Green;
                textBox1.Text = "Connecté.";
            }
            else
            {              
                MessageBox.Show("La Connexion n’a pas pu s’établir");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (cnx.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connexion déjà fermée");
            }
            else
            {
                cnx.Close();
                listBox1.Enabled = false;
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Déconnecté.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Client", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (dr.Read())
                {
                    listBox1.Items.Add("#" + dr[0] + " : " + dr[1] + " " + dr[2] + " ; " + dr[3] + " ; " + dr[4]);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("La connexion doit être ouverte !");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
