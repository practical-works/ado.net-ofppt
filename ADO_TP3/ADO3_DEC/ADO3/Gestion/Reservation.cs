using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO3
{
    class Reservation
    {
        private static SqlDataAdapter ADAPATEUR = new SqlDataAdapter("select * from Reservation", Program.CONNEXION);
        private static SqlCommandBuilder GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPATEUR);
        public static DataTable TABLE { get; set; }
        public static DataView VUE { get; set; }

        static Reservation()
        {
            TABLE = new DataTable("RESERVATION");
            VUE = new DataView(TABLE);
            ADAPATEUR.Fill(TABLE);
        }

        public static int Rechercher(int ID)
        {
            foreach (DataRow Ligne in TABLE.Rows)
            {
                if (Ligne.RowState != DataRowState.Deleted && ID == (int)Ligne["code_reservation"])
                {
                    return TABLE.Rows.IndexOf(Ligne);
                }
            }
            return -1;
        }

        public static DataView Filtrer(DateTime DateDebut, DateTime DateFin)
        {
            VUE.RowFilter = string.Format("date_reservation between {0} and {1}", DateDebut, DateFin);
            return VUE;
        }

        public static bool Ajouter(int CODE, int ID_Client, DateTime Date, bool PensionComplete)
        {
            int index = Rechercher(CODE);
            if (index != -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows.Add(CODE, ID_Client, Date, PensionComplete);
                return true;
            }
        }

        public static bool Modifier(int CODE, int ID_Client, DateTime Date, bool PensionComplete)
        {
            int index = Rechercher(CODE);
            if (index == -1)
            {
                return false;
            }
            else
            {
                TABLE.Rows[index]["id_client"] = ID_Client;
                TABLE.Rows[index]["date_reservation"] = Date;
                TABLE.Rows[index]["pension_complete"] = PensionComplete;
                return true;
            }
        }

        public static bool Supprimer(int CODE)
        {
            int index = Rechercher(CODE);
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
