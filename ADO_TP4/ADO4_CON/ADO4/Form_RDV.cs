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
    public partial class Form_RDV : Form
    {
        public Form_RDV()
        {
            InitializeComponent();
        }

        private void button_verifier_Click(object sender, EventArgs e)
        {
            try
            {
                RDV.Verifier(textBox_numero, dateTimePicker_dateRDV, maskedTextBox_heure, comboBox_medecin, comboBox_patient);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            try
            {
                RDV.Nouveau(textBox_numero, dateTimePicker_dateRDV, maskedTextBox_heure, comboBox_medecin, comboBox_patient);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                RDV.Enregistrer(textBox_numero, dateTimePicker_dateRDV, maskedTextBox_heure, comboBox_medecin, comboBox_patient);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                RDV.Supprimer(textBox_numero, dateTimePicker_dateRDV, maskedTextBox_heure, comboBox_medecin, comboBox_patient);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                RDV.Modifier(textBox_numero, dateTimePicker_dateRDV, maskedTextBox_heure, comboBox_medecin, comboBox_patient);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

        private void Form_RDV_Load(object sender, EventArgs e)
        {
            Medecin.Afficher(comboBox_medecin);
            Patient.Afficher(comboBox_patient);
        }
    }
}
