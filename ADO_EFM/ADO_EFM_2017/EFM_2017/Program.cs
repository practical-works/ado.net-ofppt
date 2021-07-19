using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_2017
{
    static class Program
    {
        public static SqlConnection Connexion = new SqlConnection(@"Data Source=.\AMBRATOLM_SQL;Initial Catalog=EFM_2017;Integrated Security=True");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Question_C3());
        }
    }
}
