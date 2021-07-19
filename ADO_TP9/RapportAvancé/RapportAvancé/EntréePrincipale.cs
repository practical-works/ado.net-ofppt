using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RapportAvancé
{
    public partial class EntréePrincipale : Form
    {
        public EntréePrincipale()
        {
            InitializeComponent();
        }

        public void FormOpen(Form F)
        {
            F.MdiParent = this;
            F.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Pays());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Atomes());
        }
    }
}
