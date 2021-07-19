using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ADO2_DEC
{
    static class Program
    {
        public static SqlConnection CONNEXION = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");
        public static SqlDataAdapter ADAPTEUR_Client = new SqlDataAdapter("select * from Client", CONNEXION);
        public static SqlCommandBuilder GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPTEUR_Client);
        public static DataSet BASE_DONNES_LOCALE = new DataSet("ClientsDb");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
