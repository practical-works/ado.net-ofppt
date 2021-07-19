using System;
using System.Data;
using System.Windows.Forms;
using ADOX_GestionVentesPro.Données;
using ADOX_GestionVentesPro.Properties;

namespace ADOX_GestionVentesPro.Interfaces.Fichier
{
    public partial class Form_Login : Form
    {
        // Attribut statique du formulaire pour son unification
        private static Form_Login FORM;
        public static Form_Login Form
        {
            get { if (!Utilitaires.FormulaireExiste(FORM)) FORM = new Form_Login(); return FORM; }
        }        

        // Attribut d'accées et de gestion pour la table des utilisateurs
        private GestionDonnées GESTION_UTILISATEURS;

        // Constructeur d'initialisation du formulaire
        public Form_Login()
        {
            InitializeComponent();
            
            // Initialiser une instance d'accées et de gestion pour la table des utilisateurs
            GESTION_UTILISATEURS = new GestionDonnées(Configuration.INFOS_TABLES.Utilisateur);
            
            // Charger l'identificateur sauvegardé dans la zone de texte
            textBox_Id.Text = Settings.Default.Id_Utilisateur;
        }

        private void button_SeConnecter_Click(object sender, EventArgs e)
        {
            string Id_Utilisateur = textBox_Id.Text.Trim();
            string Mot_Passe = textBox_Pass.Text.Trim();
            string Rôle = "";

            // Tester la validité des champs d'authentifcation
            if (Id_Utilisateur == "")
            {
                errorProvider_login.SetError(textBox_Id, "Veuillez saisir un identificateur.");
            } else if (Mot_Passe == "")
	        {
                errorProvider_login.SetError(textBox_Pass, "Veuillez saisir le mot de passe.");
	        }
            else
            {
                // Créer une vue à partir de la table utlisateur et la filtrer strictement
                // selon l'identificateur et le mot de passe entrée
                DataView Vue = new DataView(GESTION_UTILISATEURS.Table);
                Vue.RowFilter = string.Format("Id_Utilisateur = '{0}' and Mot_Passe = '{1}'",
                    Id_Utilisateur, Mot_Passe); ;
                
                // Vérifier le nombre d'éléments de la vue filtrée
                // Si les champs saisies existent la vue contiendra 1 élément sinon 0
                if (Vue.Count == 0)
                {
                    //-----------------------------
                    // • Accès refusé !
                    //-----------------------------

                    // Afficher un message de prévention
                    MessageBox.Show("La combinaison d'identificateur et de mot de passe entrée ne correspond à aucun utilisateur.", 
                                    "Échec de connexion!",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    //-----------------------------
                    // • Accès autorisé [OK]
                    //-----------------------------

                    // Sauvegarder la chaîne de l'identificateur dans les paramètres si demandé
                    Settings.Default.Id_Utilisateur = (checkBox_IdSave.Checked) ? textBox_Id.Text : "";
                    Settings.Default.Save();
                    
                    // Mettre à jour la date de dernière connexion de l'utilisateur
                    Rôle = Convert.ToString(Vue[0]["Rôle"]);
                    GESTION_UTILISATEURS.Modifier(Id_Utilisateur, Mot_Passe, Rôle, DateTime.Now);
                    GESTION_UTILISATEURS.Enregistrer();
                    
                    // Autoriser l'accés aux menus de gestions selon les rôles
                    if (Rôle == "Administrateur" || Rôle == "Modérateur") 
                        Form_Main.Form.ActiverMenus(true, true);
                    else
                        Form_Main.Form.ActiverMenus(true, false);
                     
                    // Fermer le fermulaire
                    this.Close();
                }
            }
        }
    }
}
