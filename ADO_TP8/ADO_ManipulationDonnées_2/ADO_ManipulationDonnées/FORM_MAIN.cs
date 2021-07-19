using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO_ManipulationDonnées
{
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void FormOpen(Form F)
        {
            F.MdiParent = this;
            F.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOpen(new Form1());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormOpen(new Form2());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormOpen(new Form3());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormOpen(new Form4());
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copierLeScriptDeLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            richTextBox1.SelectAll();
            MessageBox.Show("Script copié vers le Presse-papiers!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
