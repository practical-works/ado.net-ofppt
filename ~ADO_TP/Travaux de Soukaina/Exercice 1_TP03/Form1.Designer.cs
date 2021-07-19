namespace Exercice_1_TP03
{
    partial class Form1
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
            this.button_Effacer = new System.Windows.Forms.Button();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.dataGridView_Stagiaires = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(274, 207);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 8;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(193, 207);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 7;
            this.button_Afficher.Text = "Afficher";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // dataGridView_Stagiaires
            // 
            this.dataGridView_Stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stagiaires.Location = new System.Drawing.Point(21, 33);
            this.dataGridView_Stagiaires.Name = "dataGridView_Stagiaires";
            this.dataGridView_Stagiaires.Size = new System.Drawing.Size(501, 168);
            this.dataGridView_Stagiaires.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 262);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.dataGridView_Stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stagiaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Effacer;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.DataGridView dataGridView_Stagiaires;
    }
}

