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
    public partial class Question_C4 : Form
    {
        static SqlDataAdapter Adapteur = new SqlDataAdapter("", Program.Connexion);
        SqlCommandBuilder GénérateurCommandes = new SqlCommandBuilder(Adapteur);
        DataTable Table_Patient = new DataTable();

        public Question_C4()
        {
            InitializeComponent();
        }


        private void Question_C4_Load(object sender, EventArgs e)
        {
            Adapteur.SelectCommand.CommandText = "select * from Patient";
            Adapteur.Fill(Table_Patient);
            comboBox_patient.DataSource = Table_Patient;
            comboBox_patient.DisplayMember = "nomP";
            comboBox_patient.ValueMember = "numSS";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_patient.SelectedIndex != -1)
            {
                SqlCommand Commande = new SqlCommand("DerniDateConsultation", Program.Connexion);
                Commande.CommandType = CommandType.StoredProcedure;
                Commande.Parameters.Add("@numSS", SqlDbType.Int).Value = comboBox_patient.SelectedValue;
                Commande.Parameters.Add("@date_derniere_consultation", SqlDbType.Date);
                Commande.Parameters["@date_derniere_consultation"].Direction = ParameterDirection.Output;
                Program.Connexion.Open();
                Commande.ExecuteNonQuery();
                label_date.Text = Commande.Parameters["date_derniere_consultation"].Value.ToString();
                Program.Connexion.Close();
            }
        }
    }
}
