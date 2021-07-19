using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionAbonnementsCTRL
{
    class GestionAbonnés
    {
        private AccésDonnées ACCES_DONNEES;
        private string NOM_TABLE;
        private DataTable TABLE;
        private DataView VIEW;

        public DataTable Table
        {
            get { return TABLE; }
        }

        public GestionAbonnés()
        {
            ACCES_DONNEES = new AccésDonnées();
            NOM_TABLE = "Abonne";          
            ACCES_DONNEES.Charger("select * from " + NOM_TABLE, NOM_TABLE);
            TABLE = ACCES_DONNEES.Obtenir(NOM_TABLE);
            DataColumn[] PK = { TABLE.Columns["ID"] };
            TABLE.PrimaryKey = PK;
            VIEW = new DataView(TABLE);
        }

        public DataView Trier(bool Croissant, string NomChamps)
        {
            string Mode = "ASC";
            if (!Croissant) Mode = "DESC";
            if (NomChamps == "") VIEW.Sort = "";
            else VIEW.Sort = NomChamps + " " + Mode;
            return VIEW;
        }

        public DataView Filtrer(string MotsCles)
        {
            VIEW.RowFilter = "ID+Nom like '%" + MotsCles + "%'";
            return VIEW;
        }

        public bool Ajouter(params object[] Champs)
        {
            DataRow LigneAjouter = TABLE.Rows.Find(Champs[0]);
            if (LigneAjouter == null)
            {
                TABLE.Rows.Add(Champs);
                return true;
            }  
            return false;
        }

        public bool Modifier(params object[] Champs)
        {
            DataRow LigneAModifier = TABLE.Rows.Find(Champs[0]);
            if (LigneAModifier != null)
            {
                LigneAModifier["Nom"] = Champs[1];
                LigneAModifier["Tel"] = Champs[2];
                return true;
            }
            return false;
        }

        public bool Supprimer(object ID)
        {
            DataRow LigneASupprimer = TABLE.Rows.Find(ID);
            if (LigneASupprimer != null)
            {
                LigneASupprimer.Delete();
                return true;
            }
            return false;
        }

        public void Enregistrer()
        {
            ACCES_DONNEES.Enregistrer(TABLE.TableName);
        }
    }
}
