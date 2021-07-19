using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO4
{
    public partial class Form_Medecin : Form
    {
        public Form_Medecin()
        {
            InitializeComponent();
        }

        private void button_verifier_Click(object sender, EventArgs e)
        {
            try
            {
                Medecin.Verifier(textBox_code, textBox_nom, maskedTextBox_telephone, dateTimePicker_dateEmbauche, textBox_specialite);
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
                Medecin.Nouveau(textBox_code, textBox_nom, maskedTextBox_telephone, dateTimePicker_dateEmbauche, textBox_specialite);
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
                Medecin.Enregistrer(textBox_code, textBox_nom, maskedTextBox_telephone, dateTimePicker_dateEmbauche, textBox_specialite);
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
                Medecin.Supprimer(textBox_code, textBox_nom, maskedTextBox_telephone, dateTimePicker_dateEmbauche, textBox_specialite);
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
                Medecin.Modifier(textBox_code, textBox_nom, maskedTextBox_telephone, dateTimePicker_dateEmbauche, textBox_specialite);
            }
            catch (Exception exc)
            {
                Program.ErrorMessage(exc);
            }
        }

    }
}
