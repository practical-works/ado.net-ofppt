using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionAbonnements
{
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        public void FormOpen(Form F)
        {
            F.MdiParent = this;
            F.Show();
        }

        private void abonnésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Abonnes());
        }

        private void contratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Contrat());
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Produits());
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
