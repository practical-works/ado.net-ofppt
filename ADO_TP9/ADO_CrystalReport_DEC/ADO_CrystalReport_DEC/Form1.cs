using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_CrystalReport_DEC
{
    public partial class Form1 : Form
    {
        private static SqlConnection connexion = new SqlConnection(@"Data Source=.\AMBRATOLM_SQL;Initial Catalog=ExempleDb;Integrated Security=True");
        private static SqlDataAdapter adapteur = new SqlDataAdapter("select * from Exemple", connexion);
        private static DataSet donnees = new DataSet();
        private static CrystalReport1 rapport = new CrystalReport1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapteur.Fill(donnees, "Exemple");          
            rapport.SetDataSource(donnees);
            crystalReportViewer1.ReportSource = rapport;
        }

        private void button_valeurs_Click(object sender, EventArgs e)
        {
            adapteur.SelectCommand.CommandText = string.Format("select * from Exemple where valeur between {0} and {1}", numericUpDown_min.Value, numericUpDown_max.Value);
            donnees.Clear();
            adapteur.Fill(donnees, "Exemple");
            rapport.SetDataSource(donnees);
            crystalReportViewer1.ReportSource = rapport;
        }

        private void button_nom_Click(object sender, EventArgs e)
        {
            adapteur.SelectCommand.CommandText = string.Format("select * from Exemple where nom like '%{0}%'", textBox_nom.Text);
            donnees.Clear();
            adapteur.Fill(donnees, "Exemple");
            rapport.SetDataSource(donnees);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
