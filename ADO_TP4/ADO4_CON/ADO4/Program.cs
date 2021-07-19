using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO4
{
    static class Program
    {
        public static SqlConnection connexion = new SqlConnection(@"Data Source=localhost\AMBRATOLM_SQL;Initial Catalog=HopitalDb;Integrated Security=True");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
        public static void ErrorMessage(Exception exc)
        {
            MessageBox.Show("Une erreur s'est produite!\n\nInformations techniques de l'erreur:\n\n" + exc.Message,
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Program.connexion.Close();
        }
    }
}
