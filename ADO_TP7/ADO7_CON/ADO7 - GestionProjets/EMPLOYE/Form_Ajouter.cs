using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO7___GestionProjets.EMPLOYE
{
    public partial class Form_Ajouter : Form
    {
        public Form_Ajouter()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (numericUpDown_NumEmp.Value <= 0 || textBox_Nom.Text=="" || textBox_Prenom.Text=="" ||
                (!radioButton_Sexe_M.Checked && !radioButton_Sexe_F.Checked) || 
                dateTimePicker_DNaiss.Value >= DateTime.Now || textBox_Fonction.Text=="")
            {
                Messages.Invalide();
            }
            else
            {
                string Sexe = "";
                if (radioButton_Sexe_M.Checked) Sexe = "M"; else Sexe = "F";
                Employe.RemplirChamps((int)numericUpDown_NumEmp.Value, textBox_Nom.Text, textBox_Prenom.Text,
                    Sexe, dateTimePicker_DNaiss.Value, textBox_Fonction.Text);
                if (Employe.Ajouter())
                {
                    Employe.Afficher();
                    this.Close();
                }
            }
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
