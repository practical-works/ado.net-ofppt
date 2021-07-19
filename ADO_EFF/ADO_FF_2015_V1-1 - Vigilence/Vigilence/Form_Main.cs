using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vigilence
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void OuvrirFormulaire(Form Formulaire)
        {
            Formulaire.MdiParent = this;
            Formulaire.StartPosition = FormStartPosition.CenterParent;
            Formulaire.Show();
            Formulaire.Focus();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quartiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_Quartiers.Formulaire);
        }

        private void rechercheDeQuartierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(Form_RechercheQuartiers.Formulaire);
        }
    }
}
