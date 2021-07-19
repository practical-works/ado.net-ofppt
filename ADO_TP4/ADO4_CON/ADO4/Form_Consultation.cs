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
    public partial class Form_Consultation : Form
    {
        public Form_Consultation()
        {
            InitializeComponent();
        }

        private void radioButton_medecins_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_medecins.Checked)
                {
                    Medecin.Afficher(dataGridView_main);
                }
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void radioButton_rdvs_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_rdvs.Checked)
                {
                    RDV.Afficher(dataGridView_main);
                }
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void radioButton_patients_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_patients.Checked)
                {
                    Patient.Afficher(dataGridView_main);
                }
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }
    }
}
