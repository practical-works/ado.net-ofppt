using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO_EFM_2014_DERDOURI
{
    public partial class UserControl_CouleursFond : UserControl
    {
        public UserControl_CouleursFond()
        {
            InitializeComponent();
        }

        private void ColorierFondParent(Color Couleur)
        {
            this.Parent.BackColor = Couleur;
        }

        private void radioButton_defaut_CheckedChanged(object sender, EventArgs e)
        {
            ColorierFondParent(Control.DefaultBackColor);
        }

        private void radioButton_lavender_CheckedChanged(object sender, EventArgs e)
        {
            ColorierFondParent(Color.Lavender);
        }

        private void radioButton_cyan_CheckedChanged(object sender, EventArgs e)
        {
            ColorierFondParent(Color.LightCyan);
        }

        private void radioButton_pink_CheckedChanged(object sender, EventArgs e)
        {
            ColorierFondParent(Color.LightPink);
        }
    }
}
