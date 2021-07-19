namespace Synthèse
{
    partial class Form_MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFournituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDonnéesToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem,
            this.gestionDesFournisseursToolStripMenuItem,
            this.gestionDesFournituresToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseDeDonnéesToolStripMenuItem
            // 
            this.baseDeDonnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnexionToolStripMenuItem,
            this.DeconnexionToolStripMenuItem});
            this.baseDeDonnéesToolStripMenuItem.Name = "baseDeDonnéesToolStripMenuItem";
            this.baseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.baseDeDonnéesToolStripMenuItem.Text = "Base de données";
            // 
            // ConnexionToolStripMenuItem
            // 
            this.ConnexionToolStripMenuItem.Name = "ConnexionToolStripMenuItem";
            this.ConnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ConnexionToolStripMenuItem.Text = "Connexion";
            this.ConnexionToolStripMenuItem.Click += new System.EventHandler(this.ConnexionToolStripMenuItem_Click);
            // 
            // DeconnexionToolStripMenuItem
            // 
            this.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem";
            this.DeconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.DeconnexionToolStripMenuItem.Text = "Deconnexion";
            this.DeconnexionToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.suppressionToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion des produits";
            this.gestionDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesProduitsToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.modificationToolStripMenuItem_Click);
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.suppressionToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // gestionDesFournisseursToolStripMenuItem
            // 
            this.gestionDesFournisseursToolStripMenuItem.Name = "gestionDesFournisseursToolStripMenuItem";
            this.gestionDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.gestionDesFournisseursToolStripMenuItem.Text = "Gestion des fournisseurs";
            this.gestionDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesFournisseursToolStripMenuItem_Click);
            // 
            // gestionDesFournituresToolStripMenuItem
            // 
            this.gestionDesFournituresToolStripMenuItem.Name = "gestionDesFournituresToolStripMenuItem";
            this.gestionDesFournituresToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.gestionDesFournituresToolStripMenuItem.Text = "Gestion des fournitures";
            this.gestionDesFournituresToolStripMenuItem.Click += new System.EventHandler(this.gestionDesFournituresToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 483);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MenuPrincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFournituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

