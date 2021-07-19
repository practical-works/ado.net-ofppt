using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ADO7___GestionProjets.EMPLOYE
{
    static class Employe
    {
        private static SqlCommand Commande = new SqlCommand("", Program.CONNEXION);
        private static SqlDataReader Lecteur;
        private static DataTable Table = new DataTable();
        private static int Index = 0;

        // CONTROLE D'AFFICHAGE
        public static DataGridView dataGridView = new DataGridView();
        public static ComboBox comboBox = new ComboBox();
        
        // CHAMPS
        public static int NumEmp;
        public static string Nom;
        public static string Prenom;
        public static string Sexe;
        public static DateTime DNaiss;
        public static string Fonction;
        public static void RemplirChamps(int NumEmp, string Nom, string Prenom, string Sexe, DateTime DNaiss, string Fonction)
        {
            Employe.NumEmp = NumEmp;
            Employe.Nom = Nom;
            Employe.Prenom = Prenom; 
            Employe.Sexe = Sexe;
            Employe.DNaiss = DNaiss;
            Employe.Fonction = Fonction;
        }

        // OPERATIONS
        public static void Afficher()
        {
            Program.CONNEXION.Open();
            Commande.CommandText = "select * from Employe";
            Lecteur = Commande.ExecuteReader();
            Table.Clear();
            Table.Load(Lecteur);
            dataGridView.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public static void AfficherMembre(string Membre)
        {
            Program.CONNEXION.Open();
            Commande.CommandText = "select * from Employe";
            Lecteur = Commande.ExecuteReader();
            comboBox.Items.Clear();
            while (Lecteur.Read())
            {
                comboBox.Items.Add(Lecteur[Membre]);
            }
            Program.CONNEXION.Close();
        }
        public static void AfficherAvecFiltre(string Champs, string Filtre)
        {
            Program.CONNEXION.Open();
            Commande.CommandText = string.Format("select * from Employe where {0} like '%{1}%'", Champs, Filtre);
            Lecteur = Commande.ExecuteReader();
            Table.Clear();
            Table.Load(Lecteur);
            dataGridView.DataSource = null;
            dataGridView.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public static void AfficherAvecOrdre(string Ordre)
        {
            Program.CONNEXION.Open();
            Commande.CommandText = string.Format("select * from Employe order by {0}", Ordre);
            Lecteur = Commande.ExecuteReader();
            Table.Clear();
            Table.Load(Lecteur);
            dataGridView.DataSource = null;
            dataGridView.DataSource = Table;
            Program.CONNEXION.Close();
        }
        public static bool Ajouter()
        {
            bool OK = false;
            
            if (Rechercher())
            {
                Messages.ExisteDeja();
            }
            else
            {
                Program.CONNEXION.Open();
                Commande.CommandText = string.Format("insert into Employe values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')",
                    NumEmp, Nom, Prenom, Sexe, DNaiss, Fonction);
                Index = Commande.ExecuteNonQuery();
                if (Index == 0)
                {
                    Messages.NonAjoute();
                }
                else
                {
                    OK = true;
                    Messages.Ajoute();
                }
            }
            Program.CONNEXION.Close();
            return OK;
        }
        public static bool Modifier()
        {
            bool OK = false;            
            if (!Rechercher())
            {
                Messages.NExistePas();
            }
            else
            {
                Program.CONNEXION.Open();
                Commande.CommandText = string.Format(@"update Employe set 
                Nom='{1}', Prenom='{2}', Sexe='{3}', DNaiss='{4}', Fonction='{5}' where NumEmp={0}",
                    NumEmp, Nom, Prenom, Sexe, DNaiss, Fonction);
                Index = Commande.ExecuteNonQuery();
                if (Index == 0)
                {
                    Messages.NonModifie();
                }
                else
                {
                    OK = true;
                    Messages.Modifie();
                }
            }
            Program.CONNEXION.Close();
            return OK;
        }
        public static bool Supprimer()
        {
            bool OK = false;
            if (!Rechercher())
            {
                Messages.NExistePas();
            }
            else
            {
                Program.CONNEXION.Open();
                Commande.CommandText = string.Format("delete from Employe where NumEmp={0}", NumEmp);
                Index = Commande.ExecuteNonQuery();
                if (Index == 0)
                {
                    Messages.NonSupprime();
                }
                else
                {
                    OK = true;
                    Messages.Supprime();
                }
            }
            Program.CONNEXION.Close();
            return OK;
        }
        public static bool Rechercher()
        {
            bool OK = false;
            if (Program.CONNEXION.State != ConnectionState.Open) Program.CONNEXION.Open();
            Commande.CommandText = string.Format("select * from Employe where NumEmp={0}", NumEmp);
            Lecteur = Commande.ExecuteReader();
            if (Lecteur.HasRows) OK = true;
            Program.CONNEXION.Close();
            return OK;
        }
    }
}
