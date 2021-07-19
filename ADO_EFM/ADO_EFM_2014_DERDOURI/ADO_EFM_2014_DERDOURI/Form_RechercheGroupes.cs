using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_EFM_2014_DERDOURI
{
    public partial class Form_RechercheGroupes : Form
    {
        SqlDataAdapter Adapteur = new SqlDataAdapter("select * from Groupes", Program.Connexion);
        static DataTable Table = new DataTable();
        DataView Vue = new DataView(Table);

        public Form_RechercheGroupes()
        {
            InitializeComponent();
            Adapteur.Fill(Table);
        }

        private string ObtenirCritères()
        {
            List<string> Critères = new List<string>();
            for (int i = 0; i < checkedListBox_criteres.CheckedItems.Count; i++)
            {
                Critères.Add(checkedListBox_criteres.CheckedItems[i].ToString());
            }
            return string.Join("+", Critères);
        }

        private void Rechercher()
        {
            if (textBox_recherche.Text.Trim() == "" || ObtenirCritères() == "")
            {
                Vue.RowFilter = "";
                dataGridView_groupes.DataSource = null;
            }   
            else
            {
                Vue.RowFilter = string.Format("{0} like '%{1}%'", ObtenirCritères(), textBox_recherche.Text.Trim());
                dataGridView_groupes.DataSource = Vue;
            }
            
        }

        private void textBox_recherche_TextChanged(object sender, EventArgs e)
        {
            Rechercher();
        }

        private void checkedListBox_criteres_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Rechercher();
        }
    }
}
