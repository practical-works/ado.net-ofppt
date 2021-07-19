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
    public partial class Form_Patient : Form
    {
        public Form_Patient()
        {
            InitializeComponent();
        }

        private void button_verifier_Click(object sender, EventArgs e)
        {
            try
            {
                Patient.Verifier(textBox_code, textBox_nom, textBox_adresse, dateTimePicker_dateNaissance, radioButton_male, radioButton_femelle);
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
                Patient.Nouveau(textBox_code, textBox_nom, textBox_adresse, dateTimePicker_dateNaissance, radioButton_male, radioButton_femelle);
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
                Patient.Enregistrer(textBox_code, textBox_nom, textBox_adresse, dateTimePicker_dateNaissance, radioButton_male, radioButton_femelle);
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
                Patient.Supprimer(textBox_code, textBox_nom, textBox_adresse, dateTimePicker_dateNaissance, radioButton_male, radioButton_femelle);
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
                Patient.Modifier(textBox_code, textBox_nom, textBox_adresse, dateTimePicker_dateNaissance, radioButton_male, radioButton_femelle);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }
    }
}
