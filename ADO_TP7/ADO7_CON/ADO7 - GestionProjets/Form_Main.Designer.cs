namespace ADO7___GestionProjets
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
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_employe = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button_trier_employe = new System.Windows.Forms.Button();
            this.button_rechercher_employe = new System.Windows.Forms.Button();
            this.button_supprimer_employe = new System.Windows.Forms.Button();
            this.button_modifier_employe = new System.Windows.Forms.Button();
            this.button_ajouter_employe = new System.Windows.Forms.Button();
            this.dataGridView_employes = new System.Windows.Forms.DataGridView();
            this.tabPage_projets = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button_trier_projet = new System.Windows.Forms.Button();
            this.button_rechercher_projet = new System.Windows.Forms.Button();
            this.button_supprimer_projet = new System.Windows.Forms.Button();
            this.button_modifier_projet = new System.Windows.Forms.Button();
            this.button_ajouter_projet = new System.Windows.Forms.Button();
            this.dataGridView_projets = new System.Windows.Forms.DataGridView();
            this.tabPage_inscriptions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button_trier_inscription = new System.Windows.Forms.Button();
            this.button_rechercher_inscription = new System.Windows.Forms.Button();
            this.button_supprimer_inscription = new System.Windows.Forms.Button();
            this.button_modifier_inscription = new System.Windows.Forms.Button();
            this.button_ajouter_inscription = new System.Windows.Forms.Button();
            this.dataGridView_inscriptions = new System.Windows.Forms.DataGridView();
            this.tabControl_main.SuspendLayout();
            this.tabPage_employe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employes)).BeginInit();
            this.tabPage_projets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projets)).BeginInit();
            this.tabPage_inscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tabControl_main.Controls.Add(this.tabPage_employe);
            this.tabControl_main.Controls.Add(this.tabPage_projets);
            this.tabControl_main.Controls.Add(this.tabPage_inscriptions);
            this.tabControl_main.Location = new System.Drawing.Point(10, 11);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(447, 333);
            this.tabControl_main.TabIndex = 1;
            // 
            // tabPage_employe
            // 
            this.tabPage_employe.Controls.Add(this.label1);
            this.tabPage_employe.Controls.Add(this.button_trier_employe);
            this.tabPage_employe.Controls.Add(this.button_rechercher_employe);
            this.tabPage_employe.Controls.Add(this.button_supprimer_employe);
            this.tabPage_employe.Controls.Add(this.button_modifier_employe);
            this.tabPage_employe.Controls.Add(this.button_ajouter_employe);
            this.tabPage_employe.Controls.Add(this.dataGridView_employes);
            this.tabPage_employe.Location = new System.Drawing.Point(4, 22);
            this.tabPage_employe.Name = "tabPage_employe";
            this.tabPage_employe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_employe.Size = new System.Drawing.Size(439, 307);
            this.tabPage_employe.TabIndex = 0;
            this.tabPage_employe.Text = "Employés";
            this.tabPage_employe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::ADO7___GestionProjets.Properties.Resources.user_silhouette;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "      Employés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_trier_employe
            // 
            this.button_trier_employe.Image = global::ADO7___GestionProjets.Properties.Resources.sort;
            this.button_trier_employe.Location = new System.Drawing.Point(344, 63);
            this.button_trier_employe.Name = "button_trier_employe";
            this.button_trier_employe.Size = new System.Drawing.Size(75, 23);
            this.button_trier_employe.TabIndex = 1;
            this.button_trier_employe.Text = "Trier";
            this.button_trier_employe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trier_employe.UseVisualStyleBackColor = true;
            this.button_trier_employe.Click += new System.EventHandler(this.button_trier_employe_Click);
            // 
            // button_rechercher_employe
            // 
            this.button_rechercher_employe.Image = global::ADO7___GestionProjets.Properties.Resources.magnifier;
            this.button_rechercher_employe.Location = new System.Drawing.Point(263, 63);
            this.button_rechercher_employe.Name = "button_rechercher_employe";
            this.button_rechercher_employe.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher_employe.TabIndex = 1;
            this.button_rechercher_employe.Text = "Recher.";
            this.button_rechercher_employe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_rechercher_employe.UseVisualStyleBackColor = true;
            this.button_rechercher_employe.Click += new System.EventHandler(this.button_rechercher_employe_Click);
            // 
            // button_supprimer_employe
            // 
            this.button_supprimer_employe.Image = global::ADO7___GestionProjets.Properties.Resources.delete;
            this.button_supprimer_employe.Location = new System.Drawing.Point(182, 63);
            this.button_supprimer_employe.Name = "button_supprimer_employe";
            this.button_supprimer_employe.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer_employe.TabIndex = 1;
            this.button_supprimer_employe.Text = "Suppr.";
            this.button_supprimer_employe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_supprimer_employe.UseVisualStyleBackColor = true;
            this.button_supprimer_employe.Click += new System.EventHandler(this.button_supprimer_employe_Click);
            // 
            // button_modifier_employe
            // 
            this.button_modifier_employe.Image = global::ADO7___GestionProjets.Properties.Resources.edit_button;
            this.button_modifier_employe.Location = new System.Drawing.Point(101, 63);
            this.button_modifier_employe.Name = "button_modifier_employe";
            this.button_modifier_employe.Size = new System.Drawing.Size(75, 23);
            this.button_modifier_employe.TabIndex = 1;
            this.button_modifier_employe.Text = "Modifier";
            this.button_modifier_employe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_modifier_employe.UseVisualStyleBackColor = true;
            this.button_modifier_employe.Click += new System.EventHandler(this.button_modifier_employe_Click);
            // 
            // button_ajouter_employe
            // 
            this.button_ajouter_employe.Image = global::ADO7___GestionProjets.Properties.Resources.add;
            this.button_ajouter_employe.Location = new System.Drawing.Point(20, 63);
            this.button_ajouter_employe.Name = "button_ajouter_employe";
            this.button_ajouter_employe.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_employe.TabIndex = 1;
            this.button_ajouter_employe.Text = "Ajouter";
            this.button_ajouter_employe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ajouter_employe.UseVisualStyleBackColor = true;
            this.button_ajouter_employe.Click += new System.EventHandler(this.button_ajouter_employe_Click);
            // 
            // dataGridView_employes
            // 
            this.dataGridView_employes.AllowUserToAddRows = false;
            this.dataGridView_employes.AllowUserToDeleteRows = false;
            this.dataGridView_employes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employes.Location = new System.Drawing.Point(20, 92);
            this.dataGridView_employes.MultiSelect = false;
            this.dataGridView_employes.Name = "dataGridView_employes";
            this.dataGridView_employes.ReadOnly = true;
            this.dataGridView_employes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employes.Size = new System.Drawing.Size(399, 197);
            this.dataGridView_employes.TabIndex = 0;
            // 
            // tabPage_projets
            // 
            this.tabPage_projets.Controls.Add(this.label2);
            this.tabPage_projets.Controls.Add(this.button_trier_projet);
            this.tabPage_projets.Controls.Add(this.button_rechercher_projet);
            this.tabPage_projets.Controls.Add(this.button_supprimer_projet);
            this.tabPage_projets.Controls.Add(this.button_modifier_projet);
            this.tabPage_projets.Controls.Add(this.button_ajouter_projet);
            this.tabPage_projets.Controls.Add(this.dataGridView_projets);
            this.tabPage_projets.Location = new System.Drawing.Point(4, 22);
            this.tabPage_projets.Name = "tabPage_projets";
            this.tabPage_projets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_projets.Size = new System.Drawing.Size(439, 307);
            this.tabPage_projets.TabIndex = 3;
            this.tabPage_projets.Text = "Projets";
            this.tabPage_projets.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ADO7___GestionProjets.Properties.Resources.flag_flyaway_pointed;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(157, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "      Projets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_trier_projet
            // 
            this.button_trier_projet.Image = global::ADO7___GestionProjets.Properties.Resources.sort;
            this.button_trier_projet.Location = new System.Drawing.Point(344, 63);
            this.button_trier_projet.Name = "button_trier_projet";
            this.button_trier_projet.Size = new System.Drawing.Size(75, 23);
            this.button_trier_projet.TabIndex = 1;
            this.button_trier_projet.Text = "Trier";
            this.button_trier_projet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trier_projet.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_projet
            // 
            this.button_rechercher_projet.Image = global::ADO7___GestionProjets.Properties.Resources.magnifier;
            this.button_rechercher_projet.Location = new System.Drawing.Point(263, 63);
            this.button_rechercher_projet.Name = "button_rechercher_projet";
            this.button_rechercher_projet.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher_projet.TabIndex = 1;
            this.button_rechercher_projet.Text = "Recher.";
            this.button_rechercher_projet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_rechercher_projet.UseVisualStyleBackColor = true;
            // 
            // button_supprimer_projet
            // 
            this.button_supprimer_projet.Image = global::ADO7___GestionProjets.Properties.Resources.delete;
            this.button_supprimer_projet.Location = new System.Drawing.Point(182, 63);
            this.button_supprimer_projet.Name = "button_supprimer_projet";
            this.button_supprimer_projet.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer_projet.TabIndex = 1;
            this.button_supprimer_projet.Text = "Suppr.";
            this.button_supprimer_projet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_supprimer_projet.UseVisualStyleBackColor = true;
            // 
            // button_modifier_projet
            // 
            this.button_modifier_projet.Image = global::ADO7___GestionProjets.Properties.Resources.edit_button;
            this.button_modifier_projet.Location = new System.Drawing.Point(101, 63);
            this.button_modifier_projet.Name = "button_modifier_projet";
            this.button_modifier_projet.Size = new System.Drawing.Size(75, 23);
            this.button_modifier_projet.TabIndex = 1;
            this.button_modifier_projet.Text = "Modifier";
            this.button_modifier_projet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_modifier_projet.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_projet
            // 
            this.button_ajouter_projet.Image = global::ADO7___GestionProjets.Properties.Resources.add;
            this.button_ajouter_projet.Location = new System.Drawing.Point(20, 63);
            this.button_ajouter_projet.Name = "button_ajouter_projet";
            this.button_ajouter_projet.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_projet.TabIndex = 1;
            this.button_ajouter_projet.Text = "Ajouter";
            this.button_ajouter_projet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ajouter_projet.UseVisualStyleBackColor = true;
            // 
            // dataGridView_projets
            // 
            this.dataGridView_projets.AllowUserToAddRows = false;
            this.dataGridView_projets.AllowUserToDeleteRows = false;
            this.dataGridView_projets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_projets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projets.Location = new System.Drawing.Point(20, 92);
            this.dataGridView_projets.MultiSelect = false;
            this.dataGridView_projets.Name = "dataGridView_projets";
            this.dataGridView_projets.ReadOnly = true;
            this.dataGridView_projets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_projets.Size = new System.Drawing.Size(399, 197);
            this.dataGridView_projets.TabIndex = 0;
            // 
            // tabPage_inscriptions
            // 
            this.tabPage_inscriptions.Controls.Add(this.label3);
            this.tabPage_inscriptions.Controls.Add(this.button_trier_inscription);
            this.tabPage_inscriptions.Controls.Add(this.button_rechercher_inscription);
            this.tabPage_inscriptions.Controls.Add(this.button_supprimer_inscription);
            this.tabPage_inscriptions.Controls.Add(this.button_modifier_inscription);
            this.tabPage_inscriptions.Controls.Add(this.button_ajouter_inscription);
            this.tabPage_inscriptions.Controls.Add(this.dataGridView_inscriptions);
            this.tabPage_inscriptions.Location = new System.Drawing.Point(4, 22);
            this.tabPage_inscriptions.Name = "tabPage_inscriptions";
            this.tabPage_inscriptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_inscriptions.Size = new System.Drawing.Size(439, 307);
            this.tabPage_inscriptions.TabIndex = 4;
            this.tabPage_inscriptions.Text = "Inscriptions";
            this.tabPage_inscriptions.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::ADO7___GestionProjets.Properties.Resources.pencil;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(134, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "      Inscriptions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_trier_inscription
            // 
            this.button_trier_inscription.Image = global::ADO7___GestionProjets.Properties.Resources.sort;
            this.button_trier_inscription.Location = new System.Drawing.Point(344, 63);
            this.button_trier_inscription.Name = "button_trier_inscription";
            this.button_trier_inscription.Size = new System.Drawing.Size(75, 23);
            this.button_trier_inscription.TabIndex = 1;
            this.button_trier_inscription.Text = "Trier";
            this.button_trier_inscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trier_inscription.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_inscription
            // 
            this.button_rechercher_inscription.Image = global::ADO7___GestionProjets.Properties.Resources.magnifier;
            this.button_rechercher_inscription.Location = new System.Drawing.Point(263, 63);
            this.button_rechercher_inscription.Name = "button_rechercher_inscription";
            this.button_rechercher_inscription.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher_inscription.TabIndex = 1;
            this.button_rechercher_inscription.Text = "Recher.";
            this.button_rechercher_inscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_rechercher_inscription.UseVisualStyleBackColor = true;
            // 
            // button_supprimer_inscription
            // 
            this.button_supprimer_inscription.Image = global::ADO7___GestionProjets.Properties.Resources.delete;
            this.button_supprimer_inscription.Location = new System.Drawing.Point(182, 63);
            this.button_supprimer_inscription.Name = "button_supprimer_inscription";
            this.button_supprimer_inscription.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer_inscription.TabIndex = 1;
            this.button_supprimer_inscription.Text = "Suppr.";
            this.button_supprimer_inscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_supprimer_inscription.UseVisualStyleBackColor = true;
            // 
            // button_modifier_inscription
            // 
            this.button_modifier_inscription.Image = global::ADO7___GestionProjets.Properties.Resources.edit_button;
            this.button_modifier_inscription.Location = new System.Drawing.Point(101, 63);
            this.button_modifier_inscription.Name = "button_modifier_inscription";
            this.button_modifier_inscription.Size = new System.Drawing.Size(75, 23);
            this.button_modifier_inscription.TabIndex = 1;
            this.button_modifier_inscription.Text = "Modifier";
            this.button_modifier_inscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_modifier_inscription.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_inscription
            // 
            this.button_ajouter_inscription.Image = global::ADO7___GestionProjets.Properties.Resources.add;
            this.button_ajouter_inscription.Location = new System.Drawing.Point(20, 63);
            this.button_ajouter_inscription.Name = "button_ajouter_inscription";
            this.button_ajouter_inscription.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_inscription.TabIndex = 1;
            this.button_ajouter_inscription.Text = "Ajouter";
            this.button_ajouter_inscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ajouter_inscription.UseVisualStyleBackColor = true;
            // 
            // dataGridView_inscriptions
            // 
            this.dataGridView_inscriptions.AllowUserToAddRows = false;
            this.dataGridView_inscriptions.AllowUserToDeleteRows = false;
            this.dataGridView_inscriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_inscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inscriptions.Location = new System.Drawing.Point(20, 92);
            this.dataGridView_inscriptions.MultiSelect = false;
            this.dataGridView_inscriptions.Name = "dataGridView_inscriptions";
            this.dataGridView_inscriptions.ReadOnly = true;
            this.dataGridView_inscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_inscriptions.Size = new System.Drawing.Size(399, 197);
            this.dataGridView_inscriptions.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 354);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des affectations de projets";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_employe.ResumeLayout(false);
            this.tabPage_employe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employes)).EndInit();
            this.tabPage_projets.ResumeLayout(false);
            this.tabPage_projets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projets)).EndInit();
            this.tabPage_inscriptions.ResumeLayout(false);
            this.tabPage_inscriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_employe;
        private System.Windows.Forms.DataGridView dataGridView_employes;
        private System.Windows.Forms.Button button_trier_employe;
        private System.Windows.Forms.Button button_rechercher_employe;
        private System.Windows.Forms.Button button_supprimer_employe;
        private System.Windows.Forms.Button button_modifier_employe;
        private System.Windows.Forms.Button button_ajouter_employe;
        private System.Windows.Forms.TabPage tabPage_projets;
        private System.Windows.Forms.Button button_trier_projet;
        private System.Windows.Forms.Button button_rechercher_projet;
        private System.Windows.Forms.Button button_supprimer_projet;
        private System.Windows.Forms.Button button_modifier_projet;
        private System.Windows.Forms.Button button_ajouter_projet;
        private System.Windows.Forms.DataGridView dataGridView_projets;
        private System.Windows.Forms.TabPage tabPage_inscriptions;
        private System.Windows.Forms.Button button_trier_inscription;
        private System.Windows.Forms.Button button_rechercher_inscription;
        private System.Windows.Forms.Button button_supprimer_inscription;
        private System.Windows.Forms.Button button_modifier_inscription;
        private System.Windows.Forms.Button button_ajouter_inscription;
        private System.Windows.Forms.DataGridView dataGridView_inscriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

