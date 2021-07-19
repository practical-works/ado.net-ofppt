using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO6
{
    public partial class Form_Adherents : Form
    {
        private static SqlCommand COMMANDE = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader LECTEUR;
        private static int LIGNES_AFFECTEES = 0;
        private static int INDEX = 0;

        public Form_Adherents()
        {
            InitializeComponent();
        }

        public void NOUVEAU()
        {
            NAVIGUER("Last");
            numericUpDown_CODADH.Value++;
            textBox_NOMADH.Clear();
            textBox_ADRADH.Clear();
            comboBox_TYPADH.SelectedIndex = -1;
            textBox_CINADH.Clear();
            dateTimePicker_DNADH.Value = DateTime.Now;
            textBox_NOMADH.Focus();
        }

        public void MISE_A_JOUR()
        {
            if (!radioButton1.Checked) radioButton1.Checked = true;
            Program.CONNEXION.Open();
            COMMANDE.CommandText = "select * from Adherent";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public void MISE_A_JOUR_FILTREE()
        {
            Program.CONNEXION.Open();
            COMMANDE.CommandText = string.Format("select * from Adherent where NOMADH like '{0}%'", textBox1.Text);
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            dataGridView1.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public void NAVIGUER(string Position)
        {
            MISE_A_JOUR();
            if (Program.CONNEXION.State != ConnectionState.Open) Program.CONNEXION.Open(); 
            COMMANDE.CommandText = "select * from Adherent";
            LECTEUR = COMMANDE.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(LECTEUR);
            if (Position == "First")
            {
                INDEX = 0;
                numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[INDEX].Selected = true;
            }
            if (Position == "Last")
            {
                INDEX = Table.Rows.Count - 1;
                numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[INDEX].Selected = true;
            }
            if (Position == "Next")
            {
                if (INDEX < Table.Rows.Count - 1)
                {
                    INDEX++;
                    numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                    textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                    textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                    comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                    textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                    dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[INDEX].Selected = true;
                }
                else
                {
                    INDEX = 0;
                    numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                    textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                    textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                    comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                    textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                    dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[INDEX].Selected = true;
                }
            }
            if (Position == "Previous")
            {
                if (INDEX > 0)
                {
                    INDEX--;
                    numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                    textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                    textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                    comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                    textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                    dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[INDEX].Selected = true;
                }
                else
                {
                    INDEX = Table.Rows.Count - 1;
                    numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                    textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                    textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                    comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                    textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                    dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[INDEX].Selected = true;
                }
            }
            if (Position == "Selection")
            {
                INDEX = dataGridView1.CurrentRow.Index;
                numericUpDown_CODADH.Value = Convert.ToDecimal(Table.Rows[INDEX]["CODADH"]);
                textBox_NOMADH.Text = Table.Rows[INDEX]["NOMADH"].ToString();
                textBox_ADRADH.Text = Table.Rows[INDEX]["ADRADH"].ToString();
                comboBox_TYPADH.SelectedItem = Table.Rows[INDEX]["TYPADH"].ToString();
                textBox_CINADH.Text = Table.Rows[INDEX]["CINADH"].ToString();
                dateTimePicker_DNADH.Value = Convert.ToDateTime(Table.Rows[INDEX]["DNADH"]);
            }
            Program.CONNEXION.Close();
        }

        // ======================================================
        // ======================================================
        // ======================================================

        private void Form_Adherents_Load(object sender, EventArgs e)
        {
            MISE_A_JOUR();
            NAVIGUER("Last");
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            if (textBox_NOMADH.Text=="" || textBox_ADRADH.Text=="" || comboBox_TYPADH.SelectedIndex==-1 ||
                textBox_CINADH.Text=="" || dateTimePicker_DNADH.Value>DateTime.Now)
            {
                MessageBox.Show("Données invalides !");
            }
            else
            {
                Program.CONNEXION.Open();
                COMMANDE.CommandText = string.Format("select * from Adherent where CINADH='{0}'", textBox_CINADH.Text);
                LECTEUR = COMMANDE.ExecuteReader();
                if (LECTEUR.HasRows)
                {
                    MessageBox.Show("Existe déjà !");
                }
                else
                {
                    LECTEUR.Close();
                    COMMANDE.CommandText = string.Format("insert into Adherent values ('{0}','{1}','{2}','{3}','{4}')",
                                        textBox_NOMADH.Text, textBox_ADRADH.Text, comboBox_TYPADH.SelectedItem,
                                        textBox_CINADH.Text, dateTimePicker_DNADH.Value);
                    LIGNES_AFFECTEES = COMMANDE.ExecuteNonQuery();
                    if (LIGNES_AFFECTEES == 0)
                    {
                        MessageBox.Show("Erreur!");
                    }
                    else
                    {
                        MessageBox.Show("Ajouté !");
                    }
                }
                Program.CONNEXION.Close();
                MISE_A_JOUR();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAVIGUER("First");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NAVIGUER("Previous");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NAVIGUER("Next");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NAVIGUER("Last");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MISE_A_JOUR_FILTREE();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MISE_A_JOUR();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MISE_A_JOUR_FILTREE();
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {

        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            NOUVEAU();
        }
    }
}
