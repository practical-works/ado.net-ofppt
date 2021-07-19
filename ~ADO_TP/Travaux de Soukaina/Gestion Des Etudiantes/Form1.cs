using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Des_Etudiantes
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGBD1_TP07;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet("select * from Etudiants");
        DataView dv;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
