namespace Exercice_1_TP07
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
            this.groupBox_Recherche = new System.Windows.Forms.GroupBox();
            this.groupBox_tri = new System.Windows.Forms.GroupBox();
            this.dataGridView_Stagiaires = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Examen = new System.Windows.Forms.TextBox();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.radioButton_Croissant = new System.Windows.Forms.RadioButton();
            this.radioButton_Décroissant = new System.Windows.Forms.RadioButton();
            this.button_Trier = new System.Windows.Forms.Button();
            this.groupBox_Recherche.SuspendLayout();
            this.groupBox_tri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Recherche
            // 
            this.groupBox_Recherche.Controls.Add(this.button_Rechercher);
            this.groupBox_Recherche.Controls.Add(this.textBox_Examen);
            this.groupBox_Recherche.Controls.Add(this.label1);
            this.groupBox_Recherche.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Recherche.Name = "groupBox_Recherche";
            this.groupBox_Recherche.Size = new System.Drawing.Size(245, 122);
            this.groupBox_Recherche.TabIndex = 0;
            this.groupBox_Recherche.TabStop = false;
            this.groupBox_Recherche.Text = "Recherche";
            // 
            // groupBox_tri
            // 
            this.groupBox_tri.Controls.Add(this.button_Trier);
            this.groupBox_tri.Controls.Add(this.radioButton_Décroissant);
            this.groupBox_tri.Controls.Add(this.radioButton_Croissant);
            this.groupBox_tri.Location = new System.Drawing.Point(263, 12);
            this.groupBox_tri.Name = "groupBox_tri";
            this.groupBox_tri.Size = new System.Drawing.Size(205, 122);
            this.groupBox_tri.TabIndex = 0;
            this.groupBox_tri.TabStop = false;
            this.groupBox_tri.Text = "Tri (par note)";
            // 
            // dataGridView_Stagiaires
            // 
            this.dataGridView_Stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stagiaires.Location = new System.Drawing.Point(17, 156);
            this.dataGridView_Stagiaires.Name = "dataGridView_Stagiaires";
            this.dataGridView_Stagiaires.Size = new System.Drawing.Size(451, 284);
            this.dataGridView_Stagiaires.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen :";
            // 
            // textBox_Examen
            // 
            this.textBox_Examen.Location = new System.Drawing.Point(81, 36);
            this.textBox_Examen.Name = "textBox_Examen";
            this.textBox_Examen.Size = new System.Drawing.Size(127, 20);
            this.textBox_Examen.TabIndex = 1;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(72, 81);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(97, 23);
            this.button_Rechercher.TabIndex = 2;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // radioButton_Croissant
            // 
            this.radioButton_Croissant.AutoSize = true;
            this.radioButton_Croissant.Location = new System.Drawing.Point(39, 26);
            this.radioButton_Croissant.Name = "radioButton_Croissant";
            this.radioButton_Croissant.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Croissant.TabIndex = 0;
            this.radioButton_Croissant.TabStop = true;
            this.radioButton_Croissant.Text = "Croissant";
            this.radioButton_Croissant.UseVisualStyleBackColor = true;
            // 
            // radioButton_Décroissant
            // 
            this.radioButton_Décroissant.AutoSize = true;
            this.radioButton_Décroissant.Location = new System.Drawing.Point(39, 49);
            this.radioButton_Décroissant.Name = "radioButton_Décroissant";
            this.radioButton_Décroissant.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Décroissant.TabIndex = 1;
            this.radioButton_Décroissant.TabStop = true;
            this.radioButton_Décroissant.Text = "Décroissant";
            this.radioButton_Décroissant.UseVisualStyleBackColor = true;
            // 
            // button_Trier
            // 
            this.button_Trier.Location = new System.Drawing.Point(71, 81);
            this.button_Trier.Name = "button_Trier";
            this.button_Trier.Size = new System.Drawing.Size(75, 23);
            this.button_Trier.TabIndex = 2;
            this.button_Trier.Text = "Trier";
            this.button_Trier.UseVisualStyleBackColor = true;
            this.button_Trier.Click += new System.EventHandler(this.button_Trier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 452);
            this.Controls.Add(this.dataGridView_Stagiaires);
            this.Controls.Add(this.groupBox_tri);
            this.Controls.Add(this.groupBox_Recherche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Recherche.ResumeLayout(false);
            this.groupBox_Recherche.PerformLayout();
            this.groupBox_tri.ResumeLayout(false);
            this.groupBox_tri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stagiaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Recherche;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.TextBox textBox_Examen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_tri;
        private System.Windows.Forms.Button button_Trier;
        private System.Windows.Forms.RadioButton radioButton_Décroissant;
        private System.Windows.Forms.RadioButton radioButton_Croissant;
        private System.Windows.Forms.DataGridView dataGridView_Stagiaires;
    }
}

