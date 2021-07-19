using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ADO_ManipulationDonnées
{
    static class Program
    {
        public static SqlConnection CONNEXION = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ExempleDb;Integrated Security=True");
        public static SqlDataAdapter ADAPTEUR = new SqlDataAdapter("select * from Exemple", CONNEXION);
        public static SqlCommandBuilder GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPTEUR);
        public static DataSet BASE_LOCALE = new DataSet("Base de données locale");
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FORM_MAIN());
        }
    }
}
