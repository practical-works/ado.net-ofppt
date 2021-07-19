using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionAbonnements
{
    static class Program
    {
        public static SqlConnection CONNEXION = new SqlConnection(@"Data Source=LOCALHOST\AMBRATOLM_SQL;Initial Catalog=AbonnementDb;Integrated Security=True");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FORM_MAIN());
        }
    }
}
