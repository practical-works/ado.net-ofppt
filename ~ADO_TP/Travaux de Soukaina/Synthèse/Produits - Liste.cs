using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Synthèse
{
    public partial class Produits___Liste : Form
    {
        SqlDataReader dataReader;
        public Produits___Liste()
        {
            InitializeComponent();
        }

        private void Produits___Liste_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable = new DataTable();

//              Program.command.Connection = Program.connection;
                Program.command.CommandText = "select * from Produits";

                dataReader = Program.command.ExecuteReader();

                datatable.Load(dataReader);

                dataGridView_Produits.DataSource = datatable;

                dataGridView_Produits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataReader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
