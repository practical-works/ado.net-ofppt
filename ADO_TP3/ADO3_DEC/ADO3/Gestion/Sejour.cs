using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO3
{
    class Sejour
    {
        private static SqlDataAdapter ADAPATEUR = new SqlDataAdapter("select * from Sejour", Program.CONNEXION);
        private static SqlCommandBuilder GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPATEUR);
        public static DataTable TABLE { get; set; }
        public static DataView VUE { get; set; }

        static Sejour()
        {
            TABLE = new DataTable("SEJOUR");
            VUE = new DataView(TABLE);
            ADAPATEUR.Fill(TABLE);
        }

        public static int Rechercher(int NUM)
        {
            foreach (DataRow Ligne in TABLE.Rows)
            {
                if (Ligne.RowState != DataRowState.Deleted && NUM == (int)Ligne["num_sejour"])
                {
                    return TABLE.Rows.IndexOf(Ligne);
                }
            }
            return -1;
        }

        public static DataView Filtrer(string Type)
        {
            VUE.RowFilter = string.Format("type_sejour = {0}", Type);
            return VUE;
        }

        public static bool Ajouter(int NUM, int CODE_Reservation, DateTime Date, string Type, int Duree)
        {
            int index = Rechercher(NUM);
            if (index != -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows.Add(NUM, CODE_Reservation, Date, Type, Duree);
                return true;
            }
        }

        public static bool Modifier(int NUM, int CODE_Reservation, DateTime Date, string Type, int Duree)
        {
            int index = Rechercher(NUM);
            if (index == -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows[index]["nom_client"] = CODE_Reservation;
                TABLE.Rows[index]["adresse_client"] = Date;
                TABLE.Rows[index]["type_sejour"] = Type;
                TABLE.Rows[index]["duree_sejour"] = Duree;
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
