using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_2_TP05
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        SqlDataAdapter dataAdapter_stagiaires;
        SqlDataAdapter dataAdapter_notes;
        DataSet dataSet = new DataSet();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //stagiaires
            dataAdapter_stagiaires = new SqlDataAdapter("select * from stagiaires", connection);
            dataAdapter_stagiaires.Fill(dataSet, "stagiaires");
            
            //notes
            dataAdapter_notes = new SqlDataAdapter("select * from notes", connection);
            dataAdapter_stagiaires.Fill(dataSet, "notes");

            SqlCommandBuilder SqlCommandBuilder_stagiaires = new SqlCommandBuilder(dataAdapter_stagiaires);
            SqlCommandBuilder SqlCommandBuilder_notes = new SqlCommandBuilder(dataAdapter_stagiaires);

            //comboBox_Numero.SelectedIndexChanged += new EventHandler(comboBox_Numero_SelectedIndexChanged);
            
            foreach (DataRow ligne in dataSet.Tables["stagiaires"].Rows)
            {
                comboBox_Numero.Items.Add(ligne["numéro"]);
            }
            comboBox_Numero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Numero.SelectedIndex = 0;
        }

        private void comboBox_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // a rechercher ********
            //comboBox_Numero.SelectionChangeCommitted

            DataRow ligne = dataSet.Tables["stagiaires"].Rows[comboBox_Numero.SelectedIndex];

            textBox_Nom.Text = ligne["nom"].ToString();
            textBox_Prenom.Text = ligne["prénom"].ToString();
            textBox_Tel.Text = ligne["téléphone"].ToString();
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            //comboBox_Numero.SelectedIndexChanged -= new EventHandler(comboBox_Numero_SelectedIndexChanged);

            DataRow ligne = dataSet.Tables["stagiaires"].Rows[comboBox_Numero.SelectedIndex];

            //dataTable
            ligne["nom"] =   textBox_Nom.Text ;
            ligne["prénom"] = textBox_Prenom.Text;
            ligne["téléphone"]= textBox_Tel.Text;
            
            //dataBase
            dataAdapter_stagiaires.Update(dataSet.Tables["stagiaires"]);

           // comboBox_Numero.SelectedIndexChanged += new EventHandler(comboBox_Numero_SelectedIndexChanged);

        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            //dataTable
            DataRow ligne = dataSet.Tables["satgiaies"].Rows[comboBox_Numero.SelectedIndex];
            ligne.Delete(); //marquer la ligne comme supprimée

            // attetion : supprimer définitivement dataTable et reste dans comboBox
            //dataSet.Tables["stagiaires"].Rows.RemoveAt(comboBox_Numero.SelectedIndex);

            //dataBase
            dataAdapter_stagiaires.Update(dataSet.Tables["stagiaires"]);

            //ou bien
            //DataRow ligne = dataSet.Tables["satgiaies"].Rows[comboBox_Numero.SelectedIndex];
            //ligne.Delete();
            //dataSet.Tables["stagiaires"].Rows[comboBox_Numero.SelectedIndex].Delete();
            //comboBox_Numero.Items.RemoveAt(comboBox_Numero.SelectedIndex);
            //comboBox_Numero.SelectedIndex = 0;

            début : //etiquette
            foreach (DataRow lignes in dataSet.Tables["notes"].Rows)
            {
                if (lignes["stagiaires"].ToString() == comboBox_Numero.Text)
                {
                    lignes.Delete();
                    goto début;
                }
            }
        }
    }
}
