using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO5
{
    static class Program
    {
        public static SqlConnection Connexion = new SqlConnection(@"Data Source = LOCALHOST\AMBRATOLM_SQL;
                                                                    Initial Catalog = InstitutDb;
                                                                    Integrated Security = True");
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

        public static void Exception(Exception E)
        {
            MessageBox.Show("Une erreur s'est produite !\n" + "Informations:\n" + E.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Message(string message, string type)
        {
            if (type == "OK")
            {
                return MessageBox.Show(message, "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (type == "I")
            {
                return MessageBox.Show(message, "Informations invalides", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (type == "E")
            {
                return MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (type == "Q")
            {
                return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            return MessageBox.Show(message);
        }
    }
}
