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

namespace ADOX_GestionVentesPro.Interfaces.Utilisateurs
{
    public partial class Form_GestionUtilisateurs : Form
    {
        // Attribut statique du formulaire pour son unification
        private static Form_GestionUtilisateurs FORM;
        public static Form_GestionUtilisateurs Form
        {
            get { if (!Utilitaires.FormulaireExiste(FORM)) FORM = new Form_GestionUtilisateurs(); return FORM; }
        }

        // Attributs d'accées et de gestion des données
        private GestionDonnées GESTION_PRODUITS;
        private GestionDonnées GESTION_IMAGES_PRODUITS;

        public Form_GestionUtilisateurs()
        {
            InitializeComponent();

            // Initialiser des instances d'accées et de gestion des données
            GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);
            GESTION_IMAGES_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.ImageProduit);
        }      
    }
}
