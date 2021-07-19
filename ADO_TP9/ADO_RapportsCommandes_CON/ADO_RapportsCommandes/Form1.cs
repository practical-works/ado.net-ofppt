using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ADO_RapportsCommandes.Properties;

namespace ADO_RapportsCommandes
{
    public partial class Form1 : Form
    {
        static SqlConnection CONNEXION = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=GestionMagasinDb;Integrated Security=True");
        static SqlCommand COMMANDE = new SqlCommand(Resources.TEXTE_COMMANDE, CONNEXION);
        static SqlDataAdapter ADAPTEUR = new SqlDataAdapter(COMMANDE);
        DataTable TABLE = new DataTable();
        BindingSource SOURCE_LIAISON = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            ADAPTEUR.Fill(TABLE);
            SOURCE_LIAISON.DataSource = TABLE;
            bindingNavigator1.BindingSource = SOURCE_LIAISON;
            toolStripTextBox1.TextBox.DataBindings.Add("Text", SOURCE_LIAISON, "ID_Commande");
        }

        private void RapportCommandes1_RefreshReport(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(toolStripTextBox1.Text);
            RapportCommandes1.SetParameterValue("ID", ID);
            RapportCommandes1.SetParameterValue("TVA", 0.75);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RapportCommandes1.Refresh();
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            RapportCommandes1.Refresh();
        }

       
    }
}
