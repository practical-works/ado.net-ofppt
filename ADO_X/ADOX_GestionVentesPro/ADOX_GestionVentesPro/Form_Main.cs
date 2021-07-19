using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADOX_GestionVentesPro.Interfaces.Fichier;
using ADOX_GestionVentesPro.Interfaces.Produits;
using ADOX_GestionVentesPro.Interfaces.Ventes;
using ADOX_GestionVentesPro.Interfaces.Utilisateurs;

namespace ADOX_GestionVentesPro
{
    public partial class Form_Main : Form
    {
        // Attribut statique du formulaire pour accéder à l'instance active
        public static Form_Main Form;

        public Form_Main()
        {
            InitializeComponent();

            // Affecter l'instance actuelle à l'attribut statique du formulaire
            Form = this;

            // Désactiver les menus de l'application
            ActiverMenus(false, false);
        }

        /// <summary>
        /// Active ou désactive les menus de l'applications.
        /// </summary>
        /// <param name="Activer">Si vrai active les menus de gestion, sinon les désactive.</param>
        /// <param name="ModeAdmin">Si vrai active aussi les menus d'utilisateurs.</param>
        public void ActiverMenus(bool Activer, bool ModeAdmin)
        {
            créerUneSauvegardeToolStripMenuItem.Enabled = Activer;
            restaurerUneSauvegardeToolStripMenuItem.Enabled = Activer;
            produitsToolStripMenuItem.Enabled = Activer;
            ventesToolStripMenuItem.Enabled = Activer;
            utilisateursToolStripMenuItem.Visible = ModeAdmin;
            utilisateursToolStripMenuItem.Enabled = ModeAdmin;
        }

        /// <summary>
        /// Affiche un formulaire avec les paramètres determinés.
        /// Valable seulement pour le formulaire actuel.
        /// </summary>
        /// <param name="Formulaire">Formulaire à afficher.</param>
        private void OuvrirFormulaire(Form Formulaire)
        {
            Formulaire.MdiParent = this;
            Formulaire.StartPosition = FormStartPosition.CenterScreen;
            Formulaire.Show();
            Formulaire.Focus();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_Login.Form);
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_Login.Form);
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Déconnexion
            //-----------------------------
            // Fermer tous les formulaires enfants
            foreach (Form formulaire in this.MdiChildren)
            {
                formulaire.Close();
            }
            // Empêcher l'accés aux menus de gestions
            ActiverMenus(false, false);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_GestionProduits.Form);
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_GestionClients.Form);
        }

        private void gestionDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_GestionCommandes.Form);
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_GestionUtilisateurs.Form);
        }
    }
}
