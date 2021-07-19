private GestionDonnées GESTION_PRODUITS;
private GestionDonnées GESTION_IMAGES_PRODUITS;
private DataView VUE_PRODUITS;

private int NOMBRE_PRODUITS;
private int NOMBRE_IMAGES_PRODUITS;
private int NOMBRE_MISE_À_JOURS;
private int INDEX_POSITION;

private bool DÉCLENCHER_GRILLE;
private bool DÉFILER_GRILLE;
private bool SÉLECTIONNER_GRILLE;

private void Initialiser()
{
    // Initialiser les attributs
    GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);
    GESTION_IMAGES_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.ImageProduit);
    VUE_PRODUITS = new DataView(GESTION_PRODUITS.Table);
    
    NOMBRE_PRODUITS = GESTION_PRODUITS.Table.Rows.Count;
    NOMBRE_IMAGES_PRODUITS = GESTION_IMAGES_PRODUITS.Table.Rows.Count;
    NOMBRE_MISE_À_JOURS = 0; 
    INDEX_POSITION = 0;
    
    DÉCLENCHER_GRILLE = true;
    DÉFILER_GRILLE = true;
    SÉLECTIONNER_GRILLE = true;

    // Maximiser les champs numériques
    Utilitaires.MaximiserNumericUpDownValue(numericUpDown_Quantité, numericUpDown_Seuil_Minimum,
        numericUpDown_Seuil_Maximum, numericUpDown_Prix_Unitaire);

    // Actualiser la grille, les competeurs, et la date de dernière mise à jour
    ActualiserGrille();
    ActualiserCompteurs();
    ActualiserDateMiseÀJour(Settings.Default.Date_MiseAJour_Produits);

    // Initialiser la liste d'images
    listView_images.LargeImageList = new ImageList();

    // Aficher le premier élément
    Naviguer(Utilitaires.POSITIONS.Premier);
}

private void ActualiserDateMiseÀJour(DateTime DateMiseÀJour)
{
    if (Settings.Default.Date_MiseAJour_Produits != DateMiseÀJour)
        Settings.Default.Date_MiseAJour_Produits = DateMiseÀJour;
    dateMiseÀJourToolStripStatusLabel.Text = string.Format(dateMiseÀJourToolStripStatusLabel.Text,
        DateMiseÀJour.ToLongDateString(), DateMiseÀJour.ToLongTimeString());
}