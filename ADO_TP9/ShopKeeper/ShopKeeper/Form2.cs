using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopKeeper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopKeeperDbDataSet);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopKeeperDbDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'shopKeeperDbDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.shopKeeperDbDataSet.Client);

        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
