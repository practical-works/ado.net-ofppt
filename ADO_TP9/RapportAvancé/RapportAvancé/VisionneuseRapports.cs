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
    public partial class VisionneuseRapports : Form
    {
        public VisionneuseRapports()
        {
            InitializeComponent();
            this.MdiParent = EntréePrincipale.ActiveForm;         
        }
    }
}
