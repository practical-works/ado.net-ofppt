using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Synthèse
{
    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Program.connection.Open();
                //DeconnexionToolStripMenuItem.Enabled = false;
                //gestionDesProduitsToolStripMenuItem.Enabled = false;
                //gestionDesFournisseursToolStripMenuItem.Enabled = false;
                //gestionDesFournituresToolStripMenuItem.Enabled = false;

                Program.command.Connection = Program.connection;
                this.WindowState = FormWindowState.Maximized;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authentification aut = new Authentification();
            aut.Show();
        }

        private void DeconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Program.connection.Close();

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Produits___Ajout ajout = new Produits___Ajout();
                ajout.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Produits___Modification Modification = new Produits___Modification();
                Modification.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Produits___Suppression suppression = new Produits___Suppression();
                suppression.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produits___Liste liste = new Produits___Liste();
            IsMdiContainer = true;
            liste.MdiParent = this;
            liste.Show();
        }

        private void gestionDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_des_fournisseurs fournisseurs = new Gestion_des_fournisseurs();
            fournisseurs.Show();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment quitter l'application ?","Quitter", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            Application.Exit();
        }

        private void gestionDesFournituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_des_fournitures fourniture = new Gestion_des_fournitures();
            fourniture.Show();
        }

        public void Activer()
        {
            DeconnexionToolStripMenuItem.Enabled = true;
            gestionDesProduitsToolStripMenuItem.Enabled = true;
            gestionDesFournisseursToolStripMenuItem.Enabled = true;
            gestionDesFournituresToolStripMenuItem.Enabled = true;
            
        }
        
    }
}
