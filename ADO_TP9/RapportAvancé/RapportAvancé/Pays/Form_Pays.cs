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

namespace RapportAvancé
{
    public partial class Form_Pays : Form
    {
        SqlConnection Connexion;
        SqlDataAdapter Adapteur;
        DataTable Table;
        DataView Vue;

        public Form_Pays()
        {
            InitializeComponent();
            Connexion = new SqlConnection(@"Data Source = .\AMBRATOLM_SQL; Initial Catalog = PAYS; Integrated Security = true");
            Adapteur = new SqlDataAdapter("select * from Pays", Connexion);
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
                Vue.RowFilter = string.Format("id+code+alpha2+alpha3+nom_en_gb+nom_fr_fr like '%{0}%'",
                    toolStripTextBox1.Text);
                dataGridView1.DataSource = Vue;
                label_nbr_elements.Text = Vue.Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = Table;
                label_nbr_elements.Text = Table.Rows.Count.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VisionneuseRapports Afficheur = new VisionneuseRapports();
            CrystalReport_Pays Rapport = new CrystalReport_Pays();
            Rapport.SetDataSource(Vue);
            Afficheur.crystalReportViewer1.ReportSource = Rapport;
            Afficheur.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            VisionneuseRapports Afficheur = new VisionneuseRapports();
            CrystalReport_Diag Rapport = new CrystalReport_Diag();
            Rapport.SetDataSource(Vue);
            Afficheur.crystalReportViewer1.ReportSource = Rapport;
            Afficheur.Show();
        }
    }
}
