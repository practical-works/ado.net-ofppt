using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RapportsVols
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports FVR = new Form_VisionneuseRapports();
            FVR.CrystalReport_Passagers1.SetParameterValue("Ville", textBox1.Text.Trim());
            FVR.crystalReportViewer1.ReportSource = FVR.CrystalReport_Passagers1;
            FVR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports FVR = new Form_VisionneuseRapports();
            FVR.CrystalReport_Vol1.SetParameterValue("vol#", (int)numericUpDown1.Value);
            FVR.crystalReportViewer1.ReportSource = FVR.CrystalReport_Vol1;
            FVR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports FVR = new Form_VisionneuseRapports();
            FVR.crystalReportViewer1.ReportSource = FVR.CrystalReport_VolHisto1;
            FVR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports FVR = new Form_VisionneuseRapports();
            FVR.crystalReportViewer1.ReportSource = FVR.CrystalReport_ChiffreAffHisto1;
            FVR.Show();
        }
    }
}
