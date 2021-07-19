using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO2_DEC
{
    public partial class Form1 : Form
    {
        DataTable Client_Table = new DataTable("Client");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.ADAPTEUR_Client.Fill(Program.BASE_DONNES_LOCALE, "Client");
            Client_Table = Program.BASE_DONNES_LOCALE.Tables["Client"];
            dataGridView1.DataSource = Client_Table;
        }

        private bool ControleSaisie()
        {
            if (textBox_CIN.Text=="" || textBox_Nom.Text=="" || textBox_Prenom.Text=="" || textBox_Ville.Text=="" ||
                maskedTextBox_Tel.MaskFull==false)
            {
                return false;
            }
            return true;
        }
        private void MessageErreur()
        {
            MessageBox.Show("Les données entrées semblent invalides!","Attention!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private void MessageExiste(bool Existe)
        {
            if (Existe)
            {
                MessageBox.Show("Le code entré existe déjà!", "Code existent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Le code entré n'existe pas!", "Code introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int Rechercher()
        {
            foreach (DataRow Ligne in Client_Table.Rows)
            {
                if (textBox_CIN.Text == Ligne["CIN"].ToString())
                {
                    return Client_Table.Rows.IndexOf(Ligne);
                }
            }
            return -1;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (!ControleSaisie())
            {
                MessageErreur();
            }
            else
            {
                int index = Rechercher();
                if (index != -1)
                {
                    MessageExiste(true);
                }
                else
                {
                    Client_Table.Rows.Add(textBox_CIN.Text, textBox_Nom.Text, textBox_Prenom.Text, textBox_Ville.Text, maskedTextBox_Tel.Text);
                }
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (!ControleSaisie())
            {
                MessageErreur();
            }
            else
            {
                int index = Rechercher();
                if (index == -1)
                {
                    MessageExiste(false);
                }
                else
                {
                    Client_Table.Rows[index]["Nom"] = textBox_Nom.Text;
                    Client_Table.Rows[index]["Prenom"] = textBox_Prenom.Text;
                    Client_Table.Rows[index]["Ville"] = textBox_Ville.Text;
                    Client_Table.Rows[index]["Tel"] = maskedTextBox_Tel.Text;
                }
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (textBox_CIN.Text == "")
            {
                MessageErreur();
            }
            else
            {
                int index = Rechercher();
                if (index == -1)
                {
                    MessageExiste(false);
                }
                else
                {
                    Client_Table.Rows[index].Delete();
                    textBox_CIN.Clear();
                    textBox_Nom.Clear();
                    textBox_Prenom.Clear();
                    textBox_Ville.Clear();
                    maskedTextBox_Tel.Clear();
                }
            }
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            if (textBox_CIN.Text=="")
            {
                MessageErreur();
            }
            else
            {
                int index = Rechercher();
                if (index == -1)
                {
                    MessageExiste(false);
                }
                else
                {
                    textBox_Nom.Text = Client_Table.Rows[index]["Nom"].ToString();
                    textBox_Prenom.Text = Client_Table.Rows[index]["Prenom"].ToString();
                    textBox_Ville.Text = Client_Table.Rows[index]["Ville"].ToString();
                    textBox_Nom.Text = Client_Table.Rows[index]["Nom"].ToString();
                    maskedTextBox_Tel.Text = Client_Table.Rows[index]["Tel"].ToString();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (Client_Table.Rows[index].RowState != DataRowState.Deleted)
            {
                textBox_CIN.Text = Client_Table.Rows[index]["CIN"].ToString();
                textBox_Nom.Text = Client_Table.Rows[index]["Nom"].ToString();
                textBox_Prenom.Text = Client_Table.Rows[index]["Prenom"].ToString();
                textBox_Ville.Text = Client_Table.Rows[index]["Ville"].ToString();
                maskedTextBox_Tel.Text = Client_Table.Rows[index]["Tel"].ToString();
            }
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            int I = Program.ADAPTEUR_Client.Update(Client_Table);
            MessageBox.Show("   " + I + "   ligne(s) affectée(s).","Mise à jour",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
