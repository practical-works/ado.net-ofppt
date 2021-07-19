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
    public partial class Form_Trier : Form
    {
        public Form_Trier()
        {
            InitializeComponent();
        }

        private void Form_Trier_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedIndex == 0) //NumEmp
                {
                    Employe.AfficherAvecOrdre("NumEmp");
                }
                if (comboBox1.SelectedIndex == 1) //Nom
                {
                    Employe.AfficherAvecOrdre("Nom");
                }
                if (comboBox1.SelectedIndex == 2) //Prenom
                {
                    Employe.AfficherAvecOrdre("Prenom");
                }
                if (comboBox1.SelectedIndex == 3) //Sexe
	            {
                    Employe.AfficherAvecOrdre("Sexe");
	            }
                if (comboBox1.SelectedIndex == 4) //DNaiss
	            {
                    Employe.AfficherAvecOrdre("DNaiss");
	            }
                if (comboBox1.SelectedIndex == 5) //Fonction
	            {
                    Employe.AfficherAvecOrdre("Fonction");
	            }
                this.Close();
            }
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
