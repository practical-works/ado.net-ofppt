private void Naviguer(Utilitaires.POSITIONS Position)
{
    int DernièrePosition = VUE_PRODUITS.Table.Rows.Count - 1;
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
    DataRow LigneCiblée = VUE_PRODUITS.Table.Rows[INDEX_POSITION];
    textBox_Ref_Produit.Text = (string)LigneCiblée["Ref_Produit"];
    textBox_Label.Text = (string)LigneCiblée["Label"];
    numericUpDown_Quantité.Value = (int)LigneCiblée["Quantité"];
    numericUpDown_Seuil_Minimum.Value = (int)LigneCiblée["Seuil_Minimum"];
    numericUpDown_Seuil_Maximum.Value = (int)LigneCiblée["Seuil_Maximum"];
    numericUpDown_Prix_Unitaire.Value = (decimal)LigneCiblée["Prix_Unitaire"];
    SélectionnerCelluleGrille(INDEX_POSITION);
    int IndexPositionRéguliere = INDEX_POSITION + 1;
    positionToolStripTextBox.Text = IndexPositionRéguliere.ToString();
}

private void SélectionnerCelluleGrille(int Index)
{
    DÉCLENCHER_GRILLE = false;
    if (SÉLECTIONNER_GRILLE)
    {
        dataGridView1.ClearSelection();
        dataGridView1.Rows[Index].Selected = true;
    }
    if (DÉFILER_GRILLE) dataGridView1.FirstDisplayedScrollingRowIndex = Index;
    DÉCLENCHER_GRILLE = true;
}

private void NaviguerVersCléPrimaire()
{
    DataRow LigneActuelle = VUE_PRODUITS.Table.Rows.Find(textBox_Ref_Produit.Text);
    INDEX_POSITION = VUE_PRODUITS.Table.Rows.IndexOf(LigneActuelle);
    INDEX_POSITION--;
    Naviguer(Utilitaires.POSITIONS.Suivant);
}

private void premierToolStripButton_Click(object sender, EventArgs e)
{
    Naviguer(Utilitaires.POSITIONS.Premier);
}

private void precedentToolStripButton_Click(object sender, EventArgs e)
{
    Naviguer(Utilitaires.POSITIONS.Précédent);
}

private void suivantToolStripButton_Click(object sender, EventArgs e)
{
    Naviguer(Utilitaires.POSITIONS.Suivant);
}

private void dernierToolStripButton_Click(object sender, EventArgs e)
{
    Naviguer(Utilitaires.POSITIONS.Dernier);
}

private void positionToolStripTextBox_TextChanged(object sender, EventArgs e)
{
    int Index, DernièrePosition = GESTION_PRODUITS.Table.Rows.Count - 1;
    if (int.TryParse(positionToolStripTextBox.Text.Trim(), out Index))
    {
        Index--; // Transformer l'index régulier en index commençant par 0
        if (Index <= 0)
        {
            Naviguer(Utilitaires.POSITIONS.Premier);
        }
        else if (Index <= DernièrePosition)
        {
            INDEX_POSITION = Index - 1;
            Naviguer(Utilitaires.POSITIONS.Suivant);
        } 
        else
        {
            Naviguer(Utilitaires.POSITIONS.Dernier);
        }
    }
    else
    {
        positionToolStripTextBox.Clear();
    }
}

private void dataGridView1_SelectionChanged(object sender, EventArgs e)
{
    if (DÉCLENCHER_GRILLE && dataGridView1.CurrentCell != null)
    {
        INDEX_POSITION = dataGridView1.CurrentCell.RowIndex - 1;
        DÉFILER_GRILLE = SÉLECTIONNER_GRILLE = false;
        Naviguer(Utilitaires.POSITIONS.Suivant);
        DÉFILER_GRILLE = SÉLECTIONNER_GRILLE = true;
    }
}