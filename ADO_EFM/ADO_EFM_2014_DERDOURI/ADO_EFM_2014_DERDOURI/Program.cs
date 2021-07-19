using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using ADO_EFM_2014_DERDOURI.Properties;

namespace ADO_EFM_2014_DERDOURI
{
    static class Program
    {
        public static SqlConnection Connexion = new SqlConnection(Settings.Default.ChaîneConnexion);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Principal());
        }
    }
}
