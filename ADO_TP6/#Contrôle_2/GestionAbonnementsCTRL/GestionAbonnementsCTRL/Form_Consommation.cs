using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionAbonnementsCTRL
{
    public partial class Form_Consommation : Form
    {
        private GestionConsommations GESTION_CONSOMMATION;

        public Form_Consommation()
        {
            InitializeComponent();
            GESTION_CONSOMMATION = new GestionConsommations();
            dataGridView_consommations.DataSource = GESTION_CONSOMMATION.Table;
        }

        private void Form_Consommation_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Ligne in dataGridView_consommations.Rows)
            {
                if (Convert.ToInt32(Ligne.Cells[2].Value) > 3000)
                {
                    dataGridView_consommations.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
