using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Synthèse
{
  
  public static class Program 
    {
      public static SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        public static SqlCommand command = new SqlCommand();
        //public static SqlDataReader dataReader;
        //public static DataTable datatable = new DataTable();
      
      
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MenuPrincipal());
        }
    }
}
