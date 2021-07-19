namespace GestionAbonnementsCTRL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonnésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonnementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consommationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonnésToolStripMenuItem,
            this.abonnementsToolStripMenuItem,
            this.consommationsToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // abonnésToolStripMenuItem
            // 
            this.abonnésToolStripMenuItem.Name = "abonnésToolStripMenuItem";
            this.abonnésToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.abonnésToolStripMenuItem.Text = "Abonnés";
            this.abonnésToolStripMenuItem.Click += new System.EventHandler(this.abonnésToolStripMenuItem_Click);
            // 
            // abonnementsToolStripMenuItem
            // 
            this.abonnementsToolStripMenuItem.Name = "abonnementsToolStripMenuItem";
            this.abonnementsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.abonnementsToolStripMenuItem.Text = "Abonnements";
            this.abonnementsToolStripMenuItem.Click += new System.EventHandler(this.abonnementsToolStripMenuItem_Click);
            // 
            // consommationsToolStripMenuItem
            // 
            this.consommationsToolStripMenuItem.Name = "consommationsToolStripMenuItem";
            this.consommationsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consommationsToolStripMenuItem.Text = "Consommations";
            this.consommationsToolStripMenuItem.Click += new System.EventHandler(this.consommationsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 515);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire d\'Abonnements";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonnésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonnementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consommationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

