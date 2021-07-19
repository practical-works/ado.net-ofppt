using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO1_Ex1_Ex2_Ex3
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public void Afficher(string cin, string ville)
        {
            try
            {
                cnx.Open();
                string cmdstr = "select * from Client ";
                if (cin != "" && ville != "")
                {
                    cmdstr += "where CIN=" + cin + "and Ville=" + "'" + ville + "'";
                }
                else if (cin != "")
                {
                    cmdstr += "where CIN=" + cin;
                }
                else if (ville != "")
                {
                    cmdstr += "where Ville=" + "'" + ville + "'";
                }
                SqlCommand cmd = new SqlCommand(cmdstr, cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0] + "  " + dr[1] + " " + dr[2] + " (" + dr[3] + ")");
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Erreur!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cnx.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afficher(textBox_CIN.Text, textBox_ville.Text);
        }
    }
}
