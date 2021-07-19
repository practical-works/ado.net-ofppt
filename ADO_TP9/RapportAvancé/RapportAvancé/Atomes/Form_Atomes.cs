using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RapportAvancé.Pays;
using RapportAvancé.Atomes;

namespace RapportAvancé
{
    public partial class Form_Atomes : Form
    {
        SqlConnection Connexion;
        SqlDataAdapter Adapteur;
        DataTable Table;
        DataView Vue;

        public Form_Atomes()
        {
            InitializeComponent();
            Connexion = new SqlConnection(@"Data Source = .\AMBRATOLM_SQL; Initial Catalog = ATOMES; Integrated Security = true");
            Adapteur = new SqlDataAdapter("select * from Atome", Connexion);
            Table = new DataTable();
            Vue = new DataView(Table);
            Adapteur.Fill(Table);
            dataGridView1.DataSource = Table;
            label_nbr_elements.Text = Table.Rows.Count.ToString();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim() != "")
            {
                Vue.RowFilter = string.Format("nom+slug like '%{0}%'",
                    toolStripTextBox1.Text);
                dataGridView1.DataSource = Vue;
                label_nbr_elements.Text = Vue.Count.ToString();
            }
            else
            {
                Vue.RowFilter = "";
                dataGridView1.DataSource = Table;
                label_nbr_elements.Text = Table.Rows.Count.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VisionneuseRapports Afficheur = new VisionneuseRapports();
            CrystalReport_Atome Rapport = new CrystalReport_Atome();
            Rapport.SetDataSource(Vue);
            Afficheur.crystalReportViewer1.ReportSource = Rapport;
            Afficheur.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            VisionneuseRapports Afficheur = new VisionneuseRapports();
            CrystalReport_AtoDiag Rapport = new CrystalReport_AtoDiag();
            Rapport.SetDataSource(Vue);
            Afficheur.crystalReportViewer1.ReportSource = Rapport;
            Afficheur.Show();
        }
    }
}
