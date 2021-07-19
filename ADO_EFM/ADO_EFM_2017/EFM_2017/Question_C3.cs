using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_2017
{
    public partial class Question_C3 : Form
    {
        static SqlDataAdapter Adapteur = new SqlDataAdapter("", Program.Connexion);
        SqlCommandBuilder GénérateurCommandes = new SqlCommandBuilder(Adapteur);
        DataTable Table_Médecin = new DataTable();
        DataTable Table_Patient = new DataTable();
        DataTable Table_Consultation = new DataTable();
        int Position = 0;

        public Question_C3()
        {
            InitializeComponent();
            DataColumn[] ClésPrimaires = new DataColumn[1];
            
        }

        private void Question_C3_Load(object sender, EventArgs e)
        {
            Adapteur.SelectCommand.CommandText = "select * from Médecin";
            Adapteur.Fill(Table_Médecin);
            comboBox_medecin.DataSource = Table_Médecin;
            comboBox_medecin.DisplayMember = "nomM";
            comboBox_medecin.ValueMember = "matricule";

            Adapteur.SelectCommand.CommandText = "select * from Patient";
            Adapteur.Fill(Table_Patient);
            comboBox_patient.DataSource = Table_Patient;
            comboBox_patient.DisplayMember = "nomP";
            comboBox_patient.ValueMember = "numSS";

            Adapteur.SelectCommand.CommandText = "select * from Consultation";
            Adapteur.Fill(Table_Consultation);
            dataGridView1.DataSource = Table_Consultation;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (comboBox_medecin.SelectedIndex == -1 || comboBox_patient.SelectedIndex == -1)
            {
                MessageBox.Show("Remplir champs requis !");
            }
            else
            {
                Table_Consultation.Rows.Add(numericUpDown_numConsult.Value, dateTimePicker_date.Value,
                    comboBox_medecin.SelectedValue, comboBox_patient.SelectedValue, textBox_desc.Text);
                Adapteur.Update(Table_Consultation);
            }
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            int Dernière_Position = Table_Consultation.Rows.Count - 1;
            if (Position == Dernière_Position)
            {
                Position = 0;
            }
            else
            {
                Position++;
            }
            numericUpDown_numConsult.Value = Convert.ToDecimal(Table_Consultation.Rows[Position][0]);
            dateTimePicker_date.Value = Convert.ToDateTime(Table_Consultation.Rows[Position][1]);
            comboBox_medecin.SelectedValue = Convert.ToInt32(Table_Consultation.Rows[Position][2]);
            comboBox_patient.SelectedValue = Convert.ToInt32(Table_Consultation.Rows[Position][3]);
            textBox_desc.Text = Convert.ToString(Table_Consultation.Rows[Position][4]);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[Position].Selected = true;
        }
    }
}
