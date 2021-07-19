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
    public partial class Form_GestionClients : Form
    {
        // Attribut statique du formulaire pour son unification
        private static Form_GestionClients FORM;
        public static Form_GestionClients Form
        {
            get { if (!Utilitaires.FormulaireExiste(FORM)) FORM = new Form_GestionClients(); return FORM; }
        }

        // Attributs d'accées et de gestion des données
        private GestionDonnées GESTION_CLIENTS;
        private GestionDonnées GESTION_COMMANDES;

        public Form_GestionClients()
        {
            InitializeComponent();

            // Initialiser des instances d'accées et de gestion des données
            GESTION_CLIENTS = new GestionDonnées(Configuration.INFOS_TABLES.Client);
            GESTION_COMMANDES = new GestionDonnées(Configuration.INFOS_TABLES.Commande);
        }      
    }
}
