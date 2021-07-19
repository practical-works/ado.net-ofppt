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
    public partial class Produits___Modification : Form
    {
        SqlDataReader dataReader;
        
        public Produits___Modification()
        {
            InitializeComponent();
        }

        private void Produits___Modification_Load(object sender, EventArgs e)
        {
            try
            {
              
                Program.command.Connection = Program.connection;
                misAjour();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_Numéro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // command.Connection = connection;
                Program.command.CommandText = string.Format("select * from Produits where Numéro = '{0}'", comboBox_Numéro.Text);
                dataReader = Program.command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    textBox_Libellé.Text = dataReader[1].ToString();
                    textBox_Origine.Text = dataReader[2].ToString();
                    textBox_Prix.Text = dataReader[3].ToString();
                }
                else MessageBox.Show("Table vide !!");
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                Program.command.CommandText = string.Format("update Produits set Libellé = '{0}', Origine = '{1}', Prix = '{2}' where Numéro = '{3}'", textBox_Libellé.Text, textBox_Origine.Text, textBox_Prix.Text, comboBox_Numéro.Text);
                if (Program.command.ExecuteNonQuery() == 0)
                    MessageBox.Show("N'existe pas");
                else
                    MessageBox.Show("Modifié !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void misAjour()
        {
            try
            {

                Program.command.CommandText = "Select Numéro from Produits";
                dataReader = Program.command.ExecuteReader();
                comboBox_Numéro.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        comboBox_Numéro.Items.Add(string.Format("{0}", dataReader[0]));
                    }
                    dataReader.Close();
                    comboBox_Numéro.SelectedIndex = -1;
                }
                else MessageBox.Show("Table vide !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
