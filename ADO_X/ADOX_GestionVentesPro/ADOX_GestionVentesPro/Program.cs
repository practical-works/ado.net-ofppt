using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// ----------------
using System.Drawing;
using System.IO;
using ADOX_GestionVentesPro.Interfaces.Produits;
using ADOX_GestionVentesPro.Interfaces.Ventes;
using ADOX_GestionVentesPro.Données;

namespace ADOX_GestionVentesPro
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Main());
            Application.Run(new Form_GestionCommandes());
        }
    }
}
