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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exempleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Appliquer les mises à jour à la base de données
            this.Validate();
            this.exempleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exempleDbDataSet);
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            // Charger les données
            this.exempleTableAdapter.Fill(this.exempleDbDataSet.Exemple);
        }
    }
}
