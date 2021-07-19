namespace Exercice_2_TP03
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_afficherTous = new System.Windows.Forms.Button();
            this.button_Effacer = new System.Windows.Forms.Button();
            this.dataGridView_stagiaires = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom :";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(456, 39);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_afficherTous
            // 
            this.button_afficherTous.Location = new System.Drawing.Point(288, 236);
            this.button_afficherTous.Name = "button_afficherTous";
            this.button_afficherTous.Size = new System.Drawing.Size(131, 23);
            this.button_afficherTous.TabIndex = 8;
            this.button_afficherTous.Text = "Afficher Tous";
            this.button_afficherTous.UseVisualStyleBackColor = true;
            this.button_afficherTous.Click += new System.EventHandler(this.button_afficherTous_Click);
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(477, 236);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 7;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // dataGridView_stagiaires
            // 
            this.dataGridView_stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stagiaires.Location = new System.Drawing.Point(45, 66);
            this.dataGridView_stagiaires.Name = "dataGridView_stagiaires";
            this.dataGridView_stagiaires.Size = new System.Drawing.Size(671, 150);
            this.dataGridView_stagiaires.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 290);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_afficherTous);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.dataGridView_stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_afficherTous;
        private System.Windows.Forms.Button button_Effacer;
        private System.Windows.Forms.DataGridView dataGridView_stagiaires;
    }
}

