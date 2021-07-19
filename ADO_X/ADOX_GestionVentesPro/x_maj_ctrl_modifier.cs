private void modifierToolStripButton_Click(object sender, EventArgs e)
{
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
            MemoryStream Flux = new MemoryStream();
            byte[] ImageEnOctets;
            foreach (Image image in listView_images.LargeImageList.Images)
            {
                image.Save(Flux, image.RawFormat);
                ImageEnOctets = Flux.ToArray();
                if (!GESTION_IMAGES_PRODUITS.Modifier(null, ImageEnOctets, textBox_Ref_Produit.Text.Trim()))
                {
                    MessageBox.Show("Une erreur s'est produite.", "Image non sauvegardée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            GESTION_PRODUITS.Enregistrer();
            GESTION_IMAGES_PRODUITS.Enregistrer();
            NOMBRE_MISE_À_JOURS++;
            ActualiserCompteurs();
            ActualiserDateMiseÀJour(DateTime.Now);
            ActualiserCommentateur(string.Format("Produit de référence [{0}] modifié avec succés",
                textBox_Ref_Produit.Text.Trim()), Color.Green);
            NaviguerVersCléPrimaire();
        }
    }
}
