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
    public partial class Produits___Ajout : Form
    {
        SqlDataReader dataReader;

        public Produits___Ajout()
        {
            InitializeComponent();
        }

        //private void Produits___Ajout_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Program.connection.Open();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Program.command.Connection = Program.connection;
                Program.command.CommandText = string.Format("insert into Produits values('{0}','{1}','{2}','{3}')", textBox_Numéro.Text, textBox_Libellé.Text, textBox_Origine.Text, textBox_Prix.Text);
                dataReader = Program.command.ExecuteReader();
                dataReader.Close();
                MessageBox.Show("Le produit a été ajouté avec succès","confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Produits___Ajout_Load(object sender, EventArgs e)
        {

        }
    }
}
