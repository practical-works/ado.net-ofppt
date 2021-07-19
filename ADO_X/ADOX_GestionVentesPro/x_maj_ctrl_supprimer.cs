private void supprimerToolStripButton_Click(object sender, EventArgs e)
{
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
            ActualiserCompteurs();
            ActualiserDateMiseÀJour(DateTime.Now);
            ActualiserCommentateur(string.Format("Produit de référence [{0}] supprimé avec succés",
                textBox_Ref_Produit.Text.Trim()), Color.Green);
            nouveauToolStripButton.PerformClick();
        }
    }
}