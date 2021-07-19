namespace ADO_EFM_2014_DERDOURI
{
    partial class Form_Principal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_stagiaires = new System.Windows.Forms.ToolStripButton();
            this.button_rapports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_groupes = new System.Windows.Forms.ToolStripDropDownButton();
            this.button_miseajour_groupes = new System.Windows.Forms.ToolStripMenuItem();
            this.button_stagiaires_par_groupe = new System.Windows.Forms.ToolStripMenuItem();
            this.button_rechercher_groupe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_stagiaires,
            this.button_groupes,
            this.toolStripSeparator1,
            this.button_rapports});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_stagiaires
            // 
            this.button_stagiaires.Image = global::ADO_EFM_2014_DERDOURI.Properties.Resources.user_student;
            this.button_stagiaires.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_stagiaires.Name = "button_stagiaires";
            this.button_stagiaires.Size = new System.Drawing.Size(140, 22);
            this.button_stagiaires.Text = "Gestion des stagiaires";
            this.button_stagiaires.Click += new System.EventHandler(this.button_stagiaires_Click);
            // 
            // button_rapports
            // 
            this.button_rapports.Image = global::ADO_EFM_2014_DERDOURI.Properties.Resources.reports;
            this.button_rapports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_rapports.Name = "button_rapports";
            this.button_rapports.Size = new System.Drawing.Size(157, 22);
            this.button_rapports.Text = "Rapports et Diagrammes";
            this.button_rapports.Click += new System.EventHandler(this.button_rapports_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_groupes
            // 
            this.button_groupes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_miseajour_groupes,
            this.button_rechercher_groupe,
            this.button_stagiaires_par_groupe});
            this.button_groupes.Image = global::ADO_EFM_2014_DERDOURI.Properties.Resources.group;
            this.button_groupes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_groupes.Name = "button_groupes";
            this.button_groupes.Size = new System.Drawing.Size(143, 22);
            this.button_groupes.Text = "Gestion des groupes";
            this.button_groupes.Click += new System.EventHandler(this.button_groupes_Click);
            // 
            // button_miseajour_groupes
            // 
            this.button_miseajour_groupes.Name = "button_miseajour_groupes";
            this.button_miseajour_groupes.Size = new System.Drawing.Size(191, 22);
            this.button_miseajour_groupes.Text = "Mise à jour";
            this.button_miseajour_groupes.Click += new System.EventHandler(this.button_miseajour_groupes_Click);
            // 
            // button_stagiaires_par_groupe
            // 
            this.button_stagiaires_par_groupe.Name = "button_stagiaires_par_groupe";
            this.button_stagiaires_par_groupe.Size = new System.Drawing.Size(191, 22);
            this.button_stagiaires_par_groupe.Text = "Stagiaires par groupe";
            this.button_stagiaires_par_groupe.Click += new System.EventHandler(this.button_stagiaires_par_groupe_Click);
            // 
            // button_rechercher_groupe
            // 
            this.button_rechercher_groupe.Name = "button_rechercher_groupe";
            this.button_rechercher_groupe.Size = new System.Drawing.Size(191, 22);
            this.button_rechercher_groupe.Text = "Rechercher un groupe";
            this.button_rechercher_groupe.Click += new System.EventHandler(this.button_rechercher_groupe_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 570);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de l\'institut";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_rapports;
        private System.Windows.Forms.ToolStripButton button_stagiaires;
        private System.Windows.Forms.ToolStripDropDownButton button_groupes;
        private System.Windows.Forms.ToolStripMenuItem button_miseajour_groupes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem button_stagiaires_par_groupe;
        private System.Windows.Forms.ToolStripMenuItem button_rechercher_groupe;
    }
}

