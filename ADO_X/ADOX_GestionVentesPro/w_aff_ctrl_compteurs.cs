private void ActualiserCompteurs()
{
    // Afficher le nombre de produits
    CountToolStripLabel.Text = string.Format(CountToolStripLabel.Text, NOMBRE_PRODUITS);
    // Afficher le nombre d'images sélectionnées et total
    if (listView_images.SelectedIndices.Count == 0)
    {
        CountImagesToolStripLabel.Text = "Aucune image";
    }
    else
    {
        CountImagesToolStripLabel.Text = string.Format("{0} sur {1}",
        listView_images.SelectedIndices[0], listView_images.Items.Count);
    }
    // Afficher le nombre de mises à jour
    AffectationsToolStripStatusLabel.Text = string.Format("Affectations : {0}", NOMBRE_MISE_À_JOURS);
}