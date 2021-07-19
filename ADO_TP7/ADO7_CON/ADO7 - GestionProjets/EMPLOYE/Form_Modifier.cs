using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO7___GestionProjets.EMPLOYE
{
    public partial class Form_Modifier : Form
    {
        public Form_Modifier()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (comboBox_NumEmp.SelectedIndex==-1 || textBox_Nom.Text=="" || textBox_Prenom.Text=="" ||
                (!radioButton_Sexe_M.Checked && !radioButton_Sexe_F.Checked) || 
                dateTimePicker_DNaiss.Value >= DateTime.Now || textBox_Fonction.Text=="")
            {
                Messages.Invalide();
            }
            else
            {
                string Sexe = "";
                if (radioButton_Sexe_M.Checked) Sexe = "M"; else Sexe = "F";
                Employe.RemplirChamps((int)comboBox_NumEmp.SelectedItem, textBox_Nom.Text, textBox_Prenom.Text,
                    Sexe, dateTimePicker_DNaiss.Value, textBox_Fonction.Text);
                if (Employe.Modifier())
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

        private void comboBox_NumEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.CONNEXION.Open();
            SqlCommand Commande = new SqlCommand("", Program.CONNEXION);
            Commande.CommandText = string.Format("select * from Employe where NumEmp={0}", comboBox_NumEmp.SelectedItem);
            SqlDataReader Lecteur = Commande.ExecuteReader();
            Lecteur.Read();
            textBox_Nom.Text = Lecteur["Nom"].ToString();
            textBox_Prenom.Text = Lecteur["Prenom"].ToString();
            if (Lecteur["Sexe"].ToString() == "M") radioButton_Sexe_M.Checked = true;
            else radioButton_Sexe_F.Checked = true;
            dateTimePicker_DNaiss.Value = Convert.ToDateTime(Lecteur["DNaiss"].ToString());
            textBox_Fonction.Text = Lecteur["Fonction"].ToString();
            Program.CONNEXION.Close();
        }

        private void Form_Modifier_Load(object sender, EventArgs e)
        {
            Employe.comboBox = comboBox_NumEmp;
            Employe.AfficherMembre("NumEmp");
        }
    }
}
