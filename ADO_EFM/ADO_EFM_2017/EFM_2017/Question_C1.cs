using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_2017
{
    public partial class Question_C1 : Form
    {
        public Question_C1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Confirmer = MessageBox.Show("Supprimer patient ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Confirmer == DialogResult.Yes)
            {
                SqlCommand Commande = new SqlCommand("delete from Patient where numSS = " + numericUpDown1.Value, Program.Connexion);
                Program.Connexion.Open();
                Commande.ExecuteNonQuery();
                Program.Connexion.Close();
            }
        }
    }
}
