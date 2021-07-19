using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO7___GestionProjets
{
    static class Messages
    {
        public static void Invalide()
        {
            MessageBox.Show("Les informations demandées ne semblent pas tous être correctement entrées. Vérifiez que tous les champs sont remplis et que les information sont en format valide.",
                        "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public static void ExisteDeja()
        {
            MessageBox.Show("L'élément que vous essayer d'ajouter existe déjà.\nAssurez-vous que l'identifiant choisi est correcte.",
                "Attention!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public static void NExistePas()
        {
            MessageBox.Show("L'élément que vous essayer de modifier ou supprimer n'existe pas.\nAssurez-vous que l'identifiant choisi est correcte.", 
                "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Ajoute()
        {
            MessageBox.Show("Le nouveau élément a été ajouté avec succés.", "Elément bien ajouté!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void NonAjoute()
        {
            MessageBox.Show("Une erreur s'est produite.\nLe nouveau élément n'a pas été ajouté.\nVeuillez réessayer ou signaler le problème.", 
                "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Modifie()
        {
            MessageBox.Show("L'élément a été modifié avec succés.", "Elément bien modifié!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void NonModifie()
        {
            MessageBox.Show("Une erreur s'est produite.\nL'élément n'a pas été modifié.\nVeuillez réessayer ou signaler le problème.",
                "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Supprime()
        {
            MessageBox.Show("L'élément a été supprimé avec succés.", "Elément bien supprimé!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void NonSupprime()
        {
            MessageBox.Show("Une erreur s'est produite.\nL'élément n'a pas été supprimé.\nVeuillez réessayer ou signaler le problème.",
                "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
