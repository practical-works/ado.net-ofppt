using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO7___GestionProjets
{
    static class Program
    {
        public static SqlConnection CONNEXION = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ProjetsDb;Integrated Security=True");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
    }
}
