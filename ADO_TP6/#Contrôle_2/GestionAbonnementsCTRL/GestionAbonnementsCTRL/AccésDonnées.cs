using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionAbonnementsCTRL
{
    class AccésDonnées
    {
        private SqlConnection CONNEXION;
        private SqlCommand COMMANDE;
        private SqlDataAdapter ADAPTEUR;
        private SqlCommandBuilder GENERATEUR_COMMANDES;
        private DataSet SET_DONNEES;

        /// <summary>
        /// Initialise les attributs de la couche d'accés aux données
        /// </summary>
        public AccésDonnées()
        {
            CONNEXION = new SqlConnection(Program.CHAINE_CONNEXION);
            COMMANDE = new SqlCommand("", CONNEXION);
            ADAPTEUR = new SqlDataAdapter(COMMANDE);
            GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPTEUR);
            SET_DONNEES = new DataSet();
        }

        /// <summary>
        /// Retourne la table demandée depuis le DataSet
        /// </summary>
        /// <param name="NomTable"></param>
        /// <returns></returns>
        public DataTable Obtenir(string NomTable)
        {
            return SET_DONNEES.Tables[NomTable];
        }

        /// <summary>
        /// Charge une table depuis la base de données et la mis dans une table du DataSet et la retourne
        /// </summary>
        /// <param name="TexteCommande"></param>
        /// <param name="NomTable"></param>
        /// <returns></returns>
        public DataTable Charger(string TexteCommande, string NomTable)
        {
            COMMANDE.CommandText = TexteCommande;
            ADAPTEUR.Fill(SET_DONNEES, NomTable);
            return SET_DONNEES.Tables[NomTable];
        }

        /// <summary>
        /// Mis à jour la base de données avec les modifications apportées au DataSet
        /// </summary>
        /// <param name="NomTable"></param>
        /// <returns></returns>
        public int Enregistrer(string NomTable)
        {
            return ADAPTEUR.Update(SET_DONNEES.Tables[NomTable]);
        }
    }
}
