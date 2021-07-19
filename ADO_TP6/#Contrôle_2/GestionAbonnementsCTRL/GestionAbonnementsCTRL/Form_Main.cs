using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionAbonnementsCTRL
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void OuvrirForm(Form F)
        {
            try
            {
                F.MdiParent = this;
                F.Show();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        private void abonnésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm(new Form_Abonne());
        }

        private void abonnementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm(new Form_Abonnement());
        }

        private void consommationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm(new Form_Consommation());
        }
    }
}
