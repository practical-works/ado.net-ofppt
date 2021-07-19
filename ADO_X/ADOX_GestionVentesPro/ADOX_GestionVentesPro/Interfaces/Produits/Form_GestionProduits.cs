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
using ADOX_GestionVentesPro.Interfaces.Fichier;

namespace ADOX_GestionVentesPro.Interfaces.Produits
{
    public partial class Form_GestionProduits : Form
    {
        #region Attributs et Propriétés

        // Attribut statique du formulaire pour son unification
        private static Form_GestionProduits FORM;
        public static Form_GestionProduits Form
        {
            get { if (!Utilitaires.FormulaireExiste(FORM)) FORM = new Form_GestionProduits(); return FORM; }
        }

        // Attributs d'accées et de gestion des données
        private GestionDonnées GESTION_PRODUITS;
        private GestionDonnées GESTION_IMAGES_PRODUITS;

        // Vue d'affichage
        private DataView VUE_PRODUITS;
        private DataView VUE_IMAGES_PRODUIT;

        // Attributs de comptage
        private int NOMBRE_PRODUITS;
        private int NOMBRE_MISE_À_JOURS;

        // Attributs de navigation
        private int? INDEX_POSITION;

        #endregion

        #region Constructeurs

        public Form_GestionProduits()
        {
            //-----------------------------
            // • Initialiser
            //-----------------------------

            // Méthode d'initialisation du design
            InitializeComponent();

            // Maximiser les valeurs autorisés par les zones numériques
            Utilitaires.MaximiserNumericUpDownValue(numericUpDown_Quantité, numericUpDown_Seuil_Minimum,
                numericUpDown_Seuil_Maximum, numericUpDown_Prix_Unitaire);

            // Initialiser des instances d'accées et de gestion des données
            GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);
            GESTION_IMAGES_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.ImageProduit);

            // Initialiser la liste d'images
            listView_images.LargeImageList = new ImageList();
            listView_images.LargeImageList.ImageSize = new Size(64, 64);

            // Initialiser les vues d'affichage
            VUE_PRODUITS = new DataView(GESTION_PRODUITS.Table);
            VUE_IMAGES_PRODUIT = new DataView(GESTION_IMAGES_PRODUITS.Table);

            // Initialiser les compteurs
            ActualiserCompteurs(true);

            // Initier la navigation (Commencer par le premier élément)
            Naviguer(Utilitaires.POSITIONS.Premier);

            // Afficher les données dans la grille
            ActualiserGrille(false);
  
            // Colorier les lignes de la grille
            ColorierGrille();
        }

        #endregion

        #region Méthodes internes

        private void ColorierGrille()
        {
            foreach (DataGridViewRow ligne in dataGridView1.Rows)
            {
                if (ligne != null)
                {
                    int Quantité = Convert.ToInt32(ligne.Cells["Quantité"].Value);
                    int Seuil_Minimum = Convert.ToInt32(ligne.Cells["Seuil_Minimum"].Value);
                    if (Quantité <= Seuil_Minimum)
                    {
                        ligne.DefaultCellStyle.BackColor = Color.Red;
                        ligne.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void ActualiserGrille(bool Initialiser)
        {
            //-----------------------------
            // • Vider et remplir la grille
            //-----------------------------

            // Vider la grile
            if (Initialiser)
            {
                GESTION_PRODUITS.Table.Clear();
                GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);
                VUE_PRODUITS = new DataView(GESTION_PRODUITS.Table);
            }
            
            // Remplir la grille
            dataGridView1.DataSource = VUE_PRODUITS;
        }

        private void ActualiserCompteurs(bool Initialiser)
        {
            //-----------------------------
            // • Réinitialiser les compteurs
            //-----------------------------

            // Actualiser et Afficher le nombre d'éléments
            NOMBRE_PRODUITS = VUE_PRODUITS.Count;
            CountToolStripLabel.Text = string.Format(CountToolStripLabel.Text, NOMBRE_PRODUITS);

            // Afficher le nombre d'éléments sélectionnés sur le nombre total
            if (listView_images.SelectedIndices.Count == 0)
                CountImagesToolStripLabel.Text = "Aucune image";
            else
            {
                CountImagesToolStripLabel.Text = string.Format("{0} sur {1}",
                listView_images.SelectedIndices[0], listView_images.Items.Count);
            }

            // Afficher le nombre de mises à jour
            if (Initialiser) NOMBRE_MISE_À_JOURS = 0;
            else NOMBRE_MISE_À_JOURS++;
            AffectationsToolStripStatusLabel.Text = string.Format("Affectations : {0}", NOMBRE_MISE_À_JOURS);

            // Afficher la date de dernière mise à jour
            DateTime DateMiseÀJour = Utilitaires.DateMiseÀJour(false);
            dateMiseÀJourToolStripStatusLabel.Text = string.Format(dateMiseÀJourToolStripStatusLabel.Text,
                DateMiseÀJour.ToLongDateString(), DateMiseÀJour.ToLongTimeString());
        }

        private void Naviguer(Utilitaires.POSITIONS Position)
        {
            //-----------------------------
            // • 
            //-----------------------------

            // Initialiser la position si non déjà fait
            if (!INDEX_POSITION.HasValue) INDEX_POSITION = 0;
            
            // Changer l'index de position selon la position
            int DernièrePosition = VUE_PRODUITS.Count - 1;

            switch (Position)
            {
                case Utilitaires.POSITIONS.Premier:
                    INDEX_POSITION = 0;
                    break;
                case Utilitaires.POSITIONS.Précédent:
                    if (INDEX_POSITION != 0) INDEX_POSITION--;
                    else INDEX_POSITION = DernièrePosition;
                    break;
                case Utilitaires.POSITIONS.Suivant:
                    if (INDEX_POSITION != DernièrePosition) INDEX_POSITION++;
                    else INDEX_POSITION = 0;
                    break;
                case Utilitaires.POSITIONS.Dernier:
                    INDEX_POSITION = DernièrePosition;
                    break;
                default:
                    break;
            }

            // Remplir les zones avec les valeurs à l'index correspondant
            DataRow LigneCiblée = VUE_PRODUITS.ToTable().Rows[INDEX_POSITION.Value];
            textBox_Ref_Produit.Text = (string)LigneCiblée["Ref_Produit"];
            textBox_Label.Text = (string)LigneCiblée["Label"];
            numericUpDown_Quantité.Value = (int)LigneCiblée["Quantité"];
            numericUpDown_Seuil_Minimum.Value = (int)LigneCiblée["Seuil_Minimum"];
            numericUpDown_Seuil_Maximum.Value = (int)LigneCiblée["Seuil_Maximum"];
            numericUpDown_Prix_Unitaire.Value = (decimal)LigneCiblée["Prix_Unitaire"];

            // Remplir la liste d'images de l'élément correspondant
            VUE_IMAGES_PRODUIT = GESTION_IMAGES_PRODUITS.Filtrer(textBox_Ref_Produit.Text, "Ref_Produit");
            listView_images.LargeImageList.Images.Clear();
            listView_images.Items.Clear();
            for (int i = 0; i < VUE_IMAGES_PRODUIT.Count; i++)
            {
                Image image = Utilitaires.ChampsEnImage(VUE_IMAGES_PRODUIT[i]["Fichier"]);
                string clé = i.ToString();
                listView_images.LargeImageList.Images.Add(clé, image);
                listView_images.Items.Add("Image_" + clé, clé);
            }
            
            // Afficher l'index (incrémenté) dans sa zone de texe
            int IndexPositionRéguliere = INDEX_POSITION.Value + 1;
            positionToolStripTextBox.Text = IndexPositionRéguliere.ToString();

            // Actualiser les compteurs
            ActualiserCompteurs(false);
        }

        private void Naviguer(int IndexPosition)
        {
            //-----------------------------
            // • 
            //-----------------------------

            int IndexDernièrePosition = VUE_PRODUITS.Count - 1;
            if (IndexPosition <= 0)
            {
                Naviguer(Utilitaires.POSITIONS.Premier);
            }
            else if (IndexPosition <= IndexDernièrePosition)
            {
                INDEX_POSITION = IndexPosition - 1;
                Naviguer(Utilitaires.POSITIONS.Suivant);
            }
            else
            {
                Naviguer(Utilitaires.POSITIONS.Dernier);
            }
        }

        private void Naviguer(object CléPrimaire)
        {
            //-----------------------------
            // • 
            //-----------------------------

            DataRow LigneActuelle = VUE_PRODUITS.Table.Rows.Find(CléPrimaire);
            Naviguer(VUE_PRODUITS.Table.Rows.IndexOf(LigneActuelle));
        }

        #endregion

        #region Méthodes d'événements

        private void premierToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Premier
            //-----------------------------

            Naviguer(Utilitaires.POSITIONS.Premier);
        }

        private void precedentToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Précédent
            //-----------------------------

            Naviguer(Utilitaires.POSITIONS.Précédent);
        }

        private void suivantToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Suivant
            //-----------------------------

            Naviguer(Utilitaires.POSITIONS.Suivant);
        }

        private void dernierToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Dernier
            //-----------------------------

            Naviguer(Utilitaires.POSITIONS.Dernier);
        }

        private void rechercherToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            //-----------------------------
            // • Rechercher
            //-----------------------------

            // Obtenir le texte de recherche saisi en tant que mots clés
            string MotsClés = rechercherToolStripTextBox.Text.Trim();
            
            // 
            if (MotsClés == "")
                ActualiserGrille(true);
            else
            {
                VUE_PRODUITS = GESTION_PRODUITS.Filtrer(MotsClés, "Ref_Produit", "Label",
                    "Quantité", "Seuil_Minimum", "Seuil_Maximum", "Prix_Unitaire");
                ActualiserGrille(false);
                Naviguer(Utilitaires.POSITIONS.Premier);
            }
        }

        private void importerImageToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Importer Image
            //-----------------------------

            OpenFileDialog Explorateur = new OpenFileDialog();
            Explorateur.Filter = "Fichiers image (*.jpg)|*.jpg; *.jpeg; *.png; *.gif *.bmp;";
            Explorateur.Multiselect = true;
            if (Explorateur.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < Explorateur.FileNames.Length; i++)
                {
                    string nom = i + "_" + Explorateur.SafeFileNames[i];
                    Image image = Image.FromFile(Explorateur.FileNames[i]);

                    listView_images.LargeImageList.Images.Add(nom, image);
                    listView_images.Items.Add(nom, nom);
                }
            }
        }

        private void ajouterToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Ajouter
            //-----------------------------

            if (textBox_Ref_Produit.Text.Trim() == "")
            {
                errorProvider_main.SetError(textBox_Ref_Produit, "Veuillez entrer la référence du produit.");
            }
            else
            {
                errorProvider_main.Clear();
                if (!GESTION_PRODUITS.Ajouter(textBox_Ref_Produit.Text.Trim(), textBox_Label.Text.Trim(),
                    numericUpDown_Quantité.Value, numericUpDown_Seuil_Minimum.Value, numericUpDown_Seuil_Maximum.Value,
                    numericUpDown_Prix_Unitaire.Value))
                {
                    errorProvider_main.SetError(textBox_Ref_Produit, "Cette référence de produit existe déjà.");
                }
                else
                {
                    MemoryStream Flux = new MemoryStream();
                    byte[] ImageEnOctets;
                    foreach (Image image in listView_images.LargeImageList.Images)
                    {
                        image.Save(Flux, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ImageEnOctets = Flux.ToArray();
                        Utilitaires.DéfinirAutoIncrémentation(GESTION_IMAGES_PRODUITS, "Num_Image",
                            GESTION_IMAGES_PRODUITS.Table.Rows.Count, 1);
                        if (!GESTION_IMAGES_PRODUITS.Ajouter(null, ImageEnOctets, textBox_Ref_Produit.Text.Trim()))
                        {
                            MessageBox.Show("Une erreur s'est produite.", "Image non sauvegardée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    GESTION_PRODUITS.Enregistrer();
                    GESTION_IMAGES_PRODUITS.Enregistrer();
                    NOMBRE_MISE_À_JOURS++;                    
                }
            }
        }

        private void modifierToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Modifier
            //-----------------------------

            if (textBox_Ref_Produit.Text.Trim() == "")
            {
                errorProvider_main.SetError(textBox_Ref_Produit, "Veuillez entrer la référence du produit.");
            }
            else
            {
                errorProvider_main.Clear();
                if (!GESTION_PRODUITS.Modifier(textBox_Ref_Produit.Text.Trim(), textBox_Label.Text.Trim(),
                    numericUpDown_Quantité.Value, numericUpDown_Seuil_Minimum.Value, numericUpDown_Seuil_Maximum.Value,
                    numericUpDown_Prix_Unitaire.Value))
                {
                    errorProvider_main.SetError(textBox_Ref_Produit, "Cette référence de produit n'existe pas.");
                }
                else
                {
                    DataView ImagesProduit = GESTION_IMAGES_PRODUITS.Filtrer(textBox_Ref_Produit.Text.Trim(), "Ref_Produit");
                    foreach (DataRowView ligne in ImagesProduit)
                    {
                        ligne.Delete();
                    }
                    MemoryStream Flux = new MemoryStream();
                    byte[] ImageEnOctets;
                    foreach (Image image in listView_images.LargeImageList.Images)
                    {
                        ImageEnOctets = Utilitaires.ImageEnOctects(image);
                        Utilitaires.DéfinirAutoIncrémentation(GESTION_IMAGES_PRODUITS, "Num_Image",
                            GESTION_IMAGES_PRODUITS.Table.Rows.Count, 1);
                        if (!GESTION_IMAGES_PRODUITS.Ajouter(null, ImageEnOctets, textBox_Ref_Produit.Text.Trim()))
                        {
                            MessageBox.Show("Une erreur s'est produite.", "Image non sauvegardée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    GESTION_PRODUITS.Enregistrer();
                    GESTION_IMAGES_PRODUITS.Enregistrer();

                    ActualiserCompteurs(false);
                }
            }
        }

        private void supprimerToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Supprimer
            //-----------------------------

            if (textBox_Ref_Produit.Text.Trim() == "")
            {
                errorProvider_main.SetError(textBox_Ref_Produit, "Veuillez entrer la référence du produit.");
            }
            else
            {
                errorProvider_main.Clear();
                if (!GESTION_PRODUITS.Supprimer(textBox_Ref_Produit.Text.Trim()))
                {
                    errorProvider_main.SetError(textBox_Ref_Produit, "Cette référence de produit n'existe pas.");
                }
                else
                {
                    GESTION_PRODUITS.Enregistrer();
                    GESTION_IMAGES_PRODUITS.Enregistrer();
                    NOMBRE_MISE_À_JOURS++;
                    
                    nouveauToolStripButton.PerformClick();
                }
            }
        }

        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Nouveau
            //-----------------------------
            
            // Vider le formulaire
            Utilitaires.InitialiserTextBoxText(textBox_Ref_Produit, textBox_Label);
            Utilitaires.InitialiserNumericUpDownValue(numericUpDown_Quantité, numericUpDown_Seuil_Minimum,
                numericUpDown_Seuil_Maximum, numericUpDown_Prix_Unitaire);
            
            // Vider la liste d'images
            Utilitaires.InitialiserListView(listView_images);
            
            // Reprendre le focus sur la première zone texte
            textBox_Ref_Produit.Focus();

            // Enlever l'index de position affiché
            positionToolStripTextBox.Clear();
        }

        private void actualiserToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Actualiser
            //-----------------------------

            ActualiserGrille(true);
            ActualiserCompteurs(false);
            ColorierGrille();
        }

        private void produitSélectionnéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Rapport Un élément sélectionné
            //-----------------------------
            Form_ReportViewer VisionneurRapport = new Form_ReportViewer();
            VisionneurRapport.Show();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Rapport Liste des éléments 
            //-----------------------------
            Form_ReportViewer VisionneurRapport = new Form_ReportViewer();
            VisionneurRapport.Show();
        }

        private void SupprimerImageToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Supprimer Image
            //-----------------------------
            foreach (ListViewItem item in listView_images.SelectedItems)
            {
                item.Remove();
            }
        }

        private void SélectionnerToutToolStripButton_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // • Sélectionner Tout
            //-----------------------------
            foreach (ListViewItem item in listView_images.Items)
            {
                item.Selected = true;
            }
        }

        private void textBox_Ref_Produit_TextChanged(object sender, EventArgs e)
        {
            //-----------------------------
            // • Enlever notification d'erreur
            //-----------------------------
            errorProvider_main.Clear();
        }

        #endregion

        private void Form_GestionProduits_Load(object sender, EventArgs e)
        {
            ColorierGrille();
        }
    }
}
