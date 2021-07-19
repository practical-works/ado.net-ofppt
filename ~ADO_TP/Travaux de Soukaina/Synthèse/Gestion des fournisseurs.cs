using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Synthèse
{
    public partial class Gestion_des_fournisseurs : Form
    {
        SqlDataReader dataReader;
        DataTable datatable = new DataTable();

        public Gestion_des_fournisseurs()
        {
            InitializeComponent();
        }

        private void Gestion_des_fournisseurs_Load(object sender, EventArgs e)
        {
            try
            {


                Program.command.Connection = Program.connection;
                Program.command.CommandText = "select * from Fournisseurs";

                dataReader = Program.command.ExecuteReader();

                datatable.Load(dataReader);

                dataGridView_Fournisseurs.DataSource = datatable;

                dataGridView_Fournisseurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                Program.command.Connection = Program.connection;
                Program.command.CommandText = string.Format("insert into Fournisseurs values ('{0}','{1}','{2}','{3}')", textBox_Numéro.Text, textBox_Nom.Text, textBox_Ville.Text, textBox_Téléphone.Text);
                
                Program.command.ExecuteNonQuery();
                Program.command.CommandText = "select * from Fournisseurs";
                dataReader = Program.command.ExecuteReader();
                
                dataGridView_Fournisseurs.DataSource = datatable;
                dataReader.Close();
                MessageBox.Show("Le fournisseur a été ajouté avec succès", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                












                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n hadi blast ajoute");
            }
        
        }

        private void Afficher()
        {
            dataGridView_Fournisseurs.DataSource = null;
            Program.command.CommandText = "select * from Fournisseurs";
            Program.command.ExecuteNonQuery();
            while (dataReader.Read())
            {
                dataGridView_Fournisseurs.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
            }
           

        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                Program.command.CommandText = string.Format("update Fournisseurs set Numéro = '{0}', Nom = '{1}' ,  Ville ='{2}' Téléphone = '{3}' where Numéro = '{4}'", textBox_Numéro.Text, textBox_Nom.Text, textBox_Ville.Text, textBox_Téléphone.Text, textBox_Numéro.Text);
                if (Program.command.ExecuteNonQuery() == 0)
                    MessageBox.Show("N'existe pas !!!");
                else MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
