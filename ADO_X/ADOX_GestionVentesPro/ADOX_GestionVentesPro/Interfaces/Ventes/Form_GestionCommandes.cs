using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADOX_GestionVentesPro.Données;
using ADOX_GestionVentesPro.Properties;

namespace ADOX_GestionVentesPro.Interfaces.Ventes
{
    public partial class Form_GestionCommandes : Form
    {
        // Attribut statique du formulaire pour son unification
        private static Form_GestionCommandes FORM;
        public static Form_GestionCommandes Form
        {
            get { if (!Utilitaires.FormulaireExiste(FORM)) FORM = new Form_GestionCommandes(); return FORM; }
        }

        // Attributs d'accées et de gestion des données
        private GestionDonnées GESTION_COMMANDES;
        private GestionDonnées GESTION_PRODUITS;

        public Form_GestionCommandes()
        {
            InitializeComponent();

            // Initialiser des instances d'accées et de gestion des données
            GESTION_COMMANDES = new GestionDonnées(Configuration.INFOS_TABLES.Commande);
            GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);

            dataGridView1.DataSource = GESTION_COMMANDES.Table;
            dataGridView_produits.DataSource = GESTION_PRODUITS.Table;

            DataGridViewTextBoxColumn ColonneQuantité = new DataGridViewTextBoxColumn();
            ColonneQuantité.Name = "Quantité_Commandée";
            ColonneQuantité.HeaderText = "Quantité Commandée";
            ColonneQuantité.ValueType = typeof(int);
            dataGridView_produits.Columns.Add(ColonneQuantité);
        }

        private void actualiserToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterAuPanierToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ligne in dataGridView_produits.Rows)
            {
                if (ligne != null)
                {
                    int Quantité_Commandée = Convert.ToInt32(ligne.Cells["Quantité_Commandée"].Value);
                    

                    if (Quantité_Commandée > 0)
                    {
                        string[] l = { ligne.Cells["Ref_Produit"].Value.ToString(), ligne.Cells["Quantité_Commandée"].Value.ToString() };
                        ListViewItem item = new ListViewItem(l);
                        listView_produitsCommandés.Items.Add(item);
                    }
                    else
                    {
                       
                        listView_produitsCommandés.Items.Remove(item);
                    }
                }
            }
        }      
    }
}
