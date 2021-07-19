using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO3
{
    static class Client
    {
        private static SqlDataAdapter ADAPATEUR = new SqlDataAdapter("select * from Client", Program.CONNEXION);
        private static SqlCommandBuilder GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPATEUR);
        public static DataTable TABLE { get; set; }
        public static DataView VUE { get; set; }

        static Client()
        {
            TABLE = new DataTable("CLIENT");
            VUE = new DataView(TABLE);
            ADAPATEUR.Fill(TABLE);
        }

        public static int Rechercher(int ID)
        {
            foreach (DataRow Ligne in TABLE.Rows)
            {
                if (Ligne.RowState != DataRowState.Deleted && ID == (int)Ligne["id_client"])
                {
                    return TABLE.Rows.IndexOf(Ligne);
                }
            }
            return -1;
        }

        public static DataView Filtrer(string Nom)
        {
            VUE.RowFilter = string.Format("nom_client like '%{0}%'", Nom);
            return VUE;
        }

        public static bool Ajouter(int ID, string Nom, string Adresse, string Telephone)
        {
            int index = Rechercher(ID);
            if (index != -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows.Add(ID, Nom, Adresse, Telephone);
                return true;
            }
        }

        public static bool Modifier(int ID, string Nom, string Adresse, string Telephone)
        {
            int index = Rechercher(ID);
            if (index == -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows[index]["nom_client"] = Nom;
                TABLE.Rows[index]["adresse_client"] = Adresse;
                TABLE.Rows[index]["tel_client"] = Telephone;
                return true;
            }
        }

        public static bool Supprimer(int ID)
        {
            int index = Rechercher(ID);
            if (index == -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows[index].Delete();
                return true;
            }
        }
    }
}
