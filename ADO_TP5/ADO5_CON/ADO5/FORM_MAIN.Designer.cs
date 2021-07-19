namespace ADO5
{
    partial class FORM_MAIN
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
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(894, 24);
            this.menuStrip_main.TabIndex = 1;
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStagiairesToolStripMenuItem,
            this.gestionDesNotesToolStripMenuItem});
            this.gestionToolStripMenuItem.Image = global::ADO5.Properties.Resources.manage_sources;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesStagiairesToolStripMenuItem
            // 
            this.gestionDesStagiairesToolStripMenuItem.Image = global::ADO5.Properties.Resources.user;
            this.gestionDesStagiairesToolStripMenuItem.Name = "gestionDesStagiairesToolStripMenuItem";
            this.gestionDesStagiairesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.gestionDesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDesStagiairesToolStripMenuItem.Text = "Gestion des Stagiaires";
            this.gestionDesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesStagiairesToolStripMenuItem_Click);
            // 
            // gestionDesNotesToolStripMenuItem
            // 
            this.gestionDesNotesToolStripMenuItem.Image = global::ADO5.Properties.Resources.note;
            this.gestionDesNotesToolStripMenuItem.Name = "gestionDesNotesToolStripMenuItem";
            this.gestionDesNotesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.gestionDesNotesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionDesNotesToolStripMenuItem.Text = "Gestion des Notes";
            this.gestionDesNotesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesNotesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::ADO5.Properties.Resources.cancel;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 560);
            this.Controls.Add(this.menuStrip_main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des notes des stagiaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_MAIN_FormClosing);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

