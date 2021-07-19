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
    public partial class Produits___Suppression : Form
    {

        SqlDataReader dataReader;
        public Produits___Suppression()
        {
            InitializeComponent();
        }

        private void Produits___Suppression_Load(object sender, EventArgs e)
        {
            try
            {


                Program.command.Connection = Program.connection;
                Program.command.CommandText = "Select Numéro from Produits";

                dataReader = Program.command.ExecuteReader();
                
                comboBox_NuméroASupprimer.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        comboBox_NuméroASupprimer.Items.Add(string.Format("{0}", dataReader[0]));
                    }
                    dataReader.Close();
                    comboBox_NuméroASupprimer.SelectedIndex = -1;
                }
                else MessageBox.Show("Table vide !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Voulez vous vraiment supprimer ce produit","confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                Program.command.CommandText = string.Format("delete Produits where Numéro = '{0}'", comboBox_NuméroASupprimer.Text);
                Program.command.ExecuteNonQuery();

                

                MessageBox.Show("Produit supprimé !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
