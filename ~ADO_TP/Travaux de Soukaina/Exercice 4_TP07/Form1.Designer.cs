namespace Exercice_4_TP07
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Examens = new System.Windows.Forms.CheckedListBox();
            this.checkBox_CocherDécocherTous = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Décroissant = new System.Windows.Forms.RadioButton();
            this.radioButton_Croissant = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox_Examens);
            this.groupBox1.Controls.Add(this.checkBox_CocherDécocherTous);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrage ";
            // 
            // checkedListBox_Examens
            // 
            this.checkedListBox_Examens.FormattingEnabled = true;
            this.checkedListBox_Examens.Location = new System.Drawing.Point(17, 63);
            this.checkedListBox_Examens.Name = "checkedListBox_Examens";
            this.checkedListBox_Examens.Size = new System.Drawing.Size(224, 169);
            this.checkedListBox_Examens.TabIndex = 2;
            // 
            // checkBox_CocherDécocherTous
            // 
            this.checkBox_CocherDécocherTous.AutoSize = true;
            this.checkBox_CocherDécocherTous.Location = new System.Drawing.Point(17, 26);
            this.checkBox_CocherDécocherTous.Name = "checkBox_CocherDécocherTous";
            this.checkBox_CocherDécocherTous.Size = new System.Drawing.Size(145, 17);
            this.checkBox_CocherDécocherTous.TabIndex = 0;
            this.checkBox_CocherDécocherTous.Text = "Cocher / Décocher Tous";
            this.checkBox_CocherDécocherTous.UseVisualStyleBackColor = true;
            this.checkBox_CocherDécocherTous.CheckedChanged += new System.EventHandler(this.checkBox_CocherDécocherTous_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Décroissant);
            this.groupBox2.Controls.Add(this.radioButton_Croissant);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tri (par examen)";
            // 
            // radioButton_Décroissant
            // 
            this.radioButton_Décroissant.AutoSize = true;
            this.radioButton_Décroissant.Location = new System.Drawing.Point(142, 29);
            this.radioButton_Décroissant.Name = "radioButton_Décroissant";
            this.radioButton_Décroissant.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Décroissant.TabIndex = 1;
            this.radioButton_Décroissant.TabStop = true;
            this.radioButton_Décroissant.Text = "Décroissant";
            this.radioButton_Décroissant.UseVisualStyleBackColor = true;
            // 
            // radioButton_Croissant
            // 
            this.radioButton_Croissant.AutoSize = true;
            this.radioButton_Croissant.Location = new System.Drawing.Point(17, 29);
            this.radioButton_Croissant.Name = "radioButton_Croissant";
            this.radioButton_Croissant.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Croissant.TabIndex = 0;
            this.radioButton_Croissant.TabStop = true;
            this.radioButton_Croissant.Text = "Croissant";
            this.radioButton_Croissant.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_Examens;
        private System.Windows.Forms.CheckBox checkBox_CocherDécocherTous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Décroissant;
        private System.Windows.Forms.RadioButton radioButton_Croissant;
        private System.Windows.Forms.DataGridView dataGridView1;

        public System.EventHandler checkBox_CocherDécocherTous_CheckedChanged { get; set; }
    }
}

