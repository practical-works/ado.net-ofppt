using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Vigilence
{
    static class Program
    {
        public static SqlConnection Connexion = new SqlConnection(@"Data Source=.\AMBRATOLM_SQL;Initial Catalog=VigilenceDb;Integrated Security=True");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
    }
}
