using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_2017
{
    public partial class Question_C5 : Form
    {
        static SqlDataAdapter Adapteur = new SqlDataAdapter("", Program.Connexion);
        SqlCommandBuilder GénérateurCommandes = new SqlCommandBuilder(Adapteur);
        DataTable Table_Consultation = new DataTable();

        public Question_C5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adapteur.SelectCommand.CommandText = string.Format("select * from Consultation where date_consultation between '{0}' and '{1}'",
                dateTimePicker1.Value, dateTimePicker2.Value);
            Adapteur.Fill(Table_Consultation);
            CrystalReport_Question_C51.SetDataSource(Table_Consultation);
            crystalReportViewer1.ReportSource = CrystalReport_Question_C51;
            crystalReportViewer1.Refresh();
        }
    }
}
