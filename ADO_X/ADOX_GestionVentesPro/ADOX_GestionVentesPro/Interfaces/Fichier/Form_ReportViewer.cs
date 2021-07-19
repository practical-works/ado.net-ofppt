using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADOX_GestionVentesPro.Interfaces.Fichier
{
    public partial class Form_ReportViewer : Form
    {
        public Form_ReportViewer()
        {
            InitializeComponent();
        }

        public Form_ReportViewer(object Rapport) : this()
        {
            crystalReportViewer1.ReportSource = Rapport;
        }
    }
}
