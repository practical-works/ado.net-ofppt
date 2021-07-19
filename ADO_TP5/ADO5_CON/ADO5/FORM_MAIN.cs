using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO5
{
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void FormOpen(Form F)
        {
            F.Focus();
            F.MdiParent = this;
            F.Show();
        }

        private void gestionDesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(Form_Stagiaires.Instance);
        }

        private void gestionDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(Form_Notes.Instance);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Message("Voulez-vous quitter l'application ?", "Q") == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true; ;
            }
        }
    }
}
