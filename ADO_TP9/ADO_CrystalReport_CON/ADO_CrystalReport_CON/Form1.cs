using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO_CrystalReport_CON
{
    public partial class Form1 : Form
    {
        private static CrystalReport_Exemple rapport = new CrystalReport_Exemple();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rapport.SetParameterValue("valeur_min", 0);
            rapport.SetParameterValue("valeur_max", 100);
            rapport.SetParameterValue("nom", "%");
            crystalReportViewer1.ReportSource = rapport;
        }

        private void button_valeurs_Click(object sender, EventArgs e)
        {
            rapport.SetParameterValue("valeur_min", numericUpDown_min.Value);
            rapport.SetParameterValue("valeur_max", numericUpDown_max.Value);
            rapport.SetParameterValue("nom", "%");
            crystalReportViewer1.ReportSource = rapport;
        }

        private void button_nom_Click(object sender, EventArgs e)
        {
            rapport.SetParameterValue("valeur_min", 0);
            rapport.SetParameterValue("valeur_max", 100);
            rapport.SetParameterValue("nom", textBox_nom.Text);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
