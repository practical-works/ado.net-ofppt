using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO4
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void médecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Medecin P_Medecin = new Form_Medecin();
            P_Medecin.MdiParent = this;
            P_Medecin.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Patient P_Patient = new Form_Patient();
            P_Patient.MdiParent = this;
            P_Patient.Show();
        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RDV P_RDV = new Form_RDV();
            P_RDV.MdiParent = this;
            P_RDV.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Consultation P_Consultation = new Form_Consultation();
            P_Consultation.MdiParent = this;
            P_Consultation.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
