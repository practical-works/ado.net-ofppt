using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO_EFM_2014_DERDOURI
{
    public partial class Form_Principal : Form
    {
        Form_Groupes GestionGroupes;
        Form_Stagiaires GestionStagiaires;
        Form_GroupesStagiaires GroupesStagiaires;
        Form_RechercheGroupes RechercheGroupes;
        Form_VisionneuseRapports Rapports;
        
        public Form_Principal()
        {
            InitializeComponent();
        }

        private bool FormExiste(Form F)
        {
            if (F == null || F.IsDisposed)
                return false;
            return true;
        }

        private void FormOpen(Form F)
        {
            F.StartPosition = FormStartPosition.CenterScreen;
            F.MdiParent = this;
            F.Show();
            F.Focus();
        }

        private void button_groupes_Click(object sender, EventArgs e)
        {
            
        }

        private void button_miseajour_groupes_Click(object sender, EventArgs e)
        {
            if (!FormExiste(GestionGroupes))
                GestionGroupes = new Form_Groupes();
            FormOpen(GestionGroupes);
        }

        private void button_stagiaires_par_groupe_Click(object sender, EventArgs e)
        {
            if (!FormExiste(GroupesStagiaires))
                GroupesStagiaires = new Form_GroupesStagiaires();
            FormOpen(GroupesStagiaires);
        }

        private void button_rechercher_groupe_Click(object sender, EventArgs e)
        {
            if (!FormExiste(RechercheGroupes))
                RechercheGroupes = new Form_RechercheGroupes();
            FormOpen(RechercheGroupes);
        }

        private void button_stagiaires_Click(object sender, EventArgs e)
        {
            if (!FormExiste(GestionStagiaires))
                GestionStagiaires = new Form_Stagiaires();
            FormOpen(GestionStagiaires);
        }

        private void button_rapports_Click(object sender, EventArgs e)
        {
            if (!FormExiste(Rapports))
                Rapports = new Form_VisionneuseRapports();
            FormOpen(Rapports);
        }
    }
}
