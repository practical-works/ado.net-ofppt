namespace ADOX_GestionVentesPro
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.créerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.ventesToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip_main";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem,
            this.toolStripSeparator1,
            this.créerUneSauvegardeToolStripMenuItem,
            this.restaurerUneSauvegardeToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // créerUneSauvegardeToolStripMenuItem
            // 
            this.créerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.créerUneSauvegardeToolStripMenuItem.Name = "créerUneSauvegardeToolStripMenuItem";
            this.créerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.créerUneSauvegardeToolStripMenuItem.Text = "Créer une sauvegarde";
            // 
            // restaurerUneSauvegardeToolStripMenuItem
            // 
            this.restaurerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.restaurerUneSauvegardeToolStripMenuItem.Name = "restaurerUneSauvegardeToolStripMenuItem";
            this.restaurerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.restaurerUneSauvegardeToolStripMenuItem.Text = "Restaurer une sauvegarde";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesProduitsToolStripMenuItem});
            this.produitsToolStripMenuItem.Enabled = false;
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion des produits";
            this.gestionDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesProduitsToolStripMenuItem_Click);
            // 
            // ventesToolStripMenuItem
            // 
            this.ventesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClientsToolStripMenuItem,
            this.toolStripSeparator4,
            this.gestionDesCommandesToolStripMenuItem});
            this.ventesToolStripMenuItem.Enabled = false;
            this.ventesToolStripMenuItem.Name = "ventesToolStripMenuItem";
            this.ventesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventesToolStripMenuItem.Text = "Ventes";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            this.gestionDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCommandesToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Enabled = false;
            this.utilisateursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.utilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Visible = false;
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gestionDesUtilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 456);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG ~ Gestionnaire des Ventes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem créerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
    }
}

