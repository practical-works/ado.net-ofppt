using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionAbonnementsCTRL
{
    static class Program
    {
        /// <summary>
        /// chaîne de connexion à la base de données utilisée dans le programme
        /// </summary>
        public static string CHAINE_CONNEXION = @"Data Source=.\AMBRATOLM_SQL;
                                                 Initial Catalog=GestionAboDb;
                                                 Integrated Security=True";
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
    }
}
