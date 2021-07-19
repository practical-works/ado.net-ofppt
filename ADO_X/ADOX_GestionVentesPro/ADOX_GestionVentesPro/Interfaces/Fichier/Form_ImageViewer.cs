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
    public partial class Form_ImageViewer : Form
    {
        public Form_ImageViewer()
        {
            InitializeComponent();
        }

        public Form_ImageViewer(Image Image) : this()
        {
            pictureBox1.Image = Image;
        }
    }
}
