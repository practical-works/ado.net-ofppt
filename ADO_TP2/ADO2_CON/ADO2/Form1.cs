using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace ADO2
{
    public partial class Form_Clients : Form
    {
        public Form_Clients()
        {
            InitializeComponent();
            ActualiserListe();
            textBox_CIN.Select();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");
        private void ActualiserListe()
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from Client", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                listView1.Clear();
                while (dr.Read())
                {
                    listView1.Items.Add(dr[0] + ") " + dr[1] + " " + dr[2] + " - " + dr[3] + " " + dr[4]);
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cnx.Close();
            }
        }

        private void button_insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Client values(" +
                                  textBox_CIN.Text + "," +
                                  "'" + textBox_Nom.Text + "'" + "," +
                                  "'" + textBox_Prenom.Text + "'" + "," +
                                  "'" + textBox_Ville.Text + "'" + "," +
                                  "'" + textBox_Tel.Text + "'" + ")";
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();
                cnx.Close();
                ActualiserListe();
                int cin = int.Parse(textBox_CIN.Text);
                cin++;
                textBox_CIN.Text = cin.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cnx.Close();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Client set " +
                                  "Nom='" + textBox_Nom.Text + "'," +
                                  "Prenom='" + textBox_Prenom.Text + "'," +
                                  "Ville='" + textBox_Ville.Text + "'," +
                                  "Tel='" + textBox_Tel.Text + "' where CIN=" + textBox_CIN.Text;
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();
                cnx.Close();
                ActualiserListe();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Client where CIN=" + textBox_CIN.Text;
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();
                cnx.Close();
                ActualiserListe();
                int cin = int.Parse(textBox_CIN.Text);
                cin++;
                textBox_CIN.Text = cin.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            foreach (Control C in groupBox1.Controls)
            {
                if (C is TextBox)
                {
                    TextBox T = (TextBox)C;
                    T.Clear();
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from Client where CIN="+textBox_CIN.Text, cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MessageBox.Show("Information du client recherché:\n\nCIN: " + dr[0] + "\nNom: " + dr[1] + "\nPrénom: " + dr[2] + "\nVille: " + dr[3] + "\nTéléphone: " + dr[4],
                            "Client trouvé !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun résultat.", "Client introuvable !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                
                dr.Close();
                cnx.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("osk.exe");
        }

    }
}
