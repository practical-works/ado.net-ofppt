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
    public partial class Liste_des_fournitures_par_fournisseur : Form
    {
        SqlDataReader dataReader;

        public Liste_des_fournitures_par_fournisseur()
        {
            InitializeComponent();
        }

        private void dataGridView_Produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Liste_des_fournitures_par_fournisseur_Load(object sender, EventArgs e)
        {
            #region fournisseurs

            Program.command.CommandText = @"select numéro from fournisseurs";
            dataReader = Program.command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox_Fournisseur.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            comboBox_Fournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Fournisseur.SelectedIndex = 0;
            
            #endregion

            #region ordre

            comboBox_Ordre.Items.AddRange(new string[] { "Croissant", "Décroissant" });
            comboBox_Ordre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Ordre.SelectedIndex = 0;
            
            #endregion

            #region clé

            comboBox_Clé.Items.AddRange(new object[] { "Numéro de produit", "Date", "Quantité" });
            comboBox_Clé.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Clé.SelectedIndex = 0;
            
            #endregion

        }

        private void comboBox_Fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable datatable_fournisseurs = new DataTable();
            Program.command.CommandText = string.Format("select produit, date, quantité from fournir where fournisseur = '{0}'", comboBox_Fournisseur.Text);
            dataReader = Program.command.ExecuteReader();
            datatable_fournisseurs.Load(dataReader);
            dataReader.Close();
            dataGridView_Produit.DataSource = datatable_fournisseurs;

            DataTable datatable_nbrFournisseurs = new DataTable();
            Program.command.CommandText = string.Format(@"select produit, count(*) as [nbr.F]
                                                          from fournir
                                                           where fournisseur = '{0}'
                                                           group by produit", comboBox_Fournisseur.Text);
            dataReader = Program.command.ExecuteReader();
            datatable_nbrFournisseurs.Load(dataReader);
            dataReader.Close();
            dataGridView_nbrFournituresParProduit.DataSource = datatable_nbrFournisseurs;

          
        }

        private void button_trier_Click(object sender, EventArgs e)
        {
            DataTable datatable_fournisseurs = new DataTable();
            Program.command.CommandText = string.Format("select produit, date, quantité from fournir where fournisseur = '{0}'", comboBox_Fournisseur.Text);
            dataReader = Program.command.ExecuteReader();
            datatable_fournisseurs.Load(dataReader);
            dataReader.Close();
            dataGridView_Produit.DataSource = datatable_fournisseurs;

            string ordre = (comboBox_Ordre.SelectedIndex == 0) ? "ASC" : "DESC";
            string clé = string.Empty;

            switch (comboBox_Clé.SelectedIndex)
            {
                case 0:
                    clé = "Produit";
                    break;
                case 1:
                    clé = "Date";
                    break;
                default :
                    clé = "Quantité";
                    break;
            }

            Program.command.CommandText = string.Format(@"select produit, date, quantité 
                                                          from fournir where fournisseur = '{0}'
                                                          group by '{1}' '{2}'", comboBox_Fournisseur.Text, clé, ordre);
        }
    }
}
