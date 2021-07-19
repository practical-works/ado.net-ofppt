using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO6
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

        private void adherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Adherents());
        }

        private void ouvragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Ouvrages());
        }

        private void empruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Emprunts());
        }

        private void retoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Retours());
        }

        private void button_ADH_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Adherents());
        }

        private void button_OUV_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Ouvrages());
        }

        private void button_EMP_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Emprunts());
        }

        private void button_RET_Click(object sender, EventArgs e)
        {
            FormOpen(new Form_Retours());
        }

        private void FORM_MAIN_Load(object sender, EventArgs e)
        {
            FormOpen(new Form_Message());
        }
    }
}
