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
    public partial class Gestion_des_fournitures : Form
    {
        SqlDataReader dataReader;
        
        public Gestion_des_fournitures()
        {
            InitializeComponent();
        }

        private void button_Liste_Click(object sender, EventArgs e)
        {

            Liste_des_fournitures_par_fournisseur liste = new Liste_des_fournitures_par_fournisseur();
            liste.MdiParent = this.MdiParent;
            liste.Show();
        }

        private void Gestion_des_fournitures_Load(object sender, EventArgs e)
        {
            try
            {
                Program.command.CommandText = "select numéro from fournisseurs select numéro from produits";
                dataReader = Program.command.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBox_Fournisseur.Items.Add(dataReader[0]);
                }
                dataReader.NextResult();

                while (dataReader.Read())
                {
                    comboBox_Produit.Items.Add(dataReader[0]);
                }

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
                Program.command.CommandText = string.Format(@"set dateformat dmy insert into fournir values('{0}','{1}','{2}',{3})", comboBox_Fournisseur.Text, comboBox_Produit.Text, dateTimePicker_Date.Value, textBox_Quantité.Text);
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Bien ajouté");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
