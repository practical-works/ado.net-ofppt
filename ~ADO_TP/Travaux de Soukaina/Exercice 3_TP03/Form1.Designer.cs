namespace Exercice_3_TP03
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
            this.button_afficherTous = new System.Windows.Forms.Button();
            this.button_Effacer = new System.Windows.Forms.Button();
            this.dataGridView_stagiaires = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Nom = new System.Windows.Forms.RadioButton();
            this.radioButton_Prénom = new System.Windows.Forms.RadioButton();
            this.radioButton_Numéro = new System.Windows.Forms.RadioButton();
            this.radioButton_Téléphone = new System.Windows.Forms.RadioButton();
            this.button_Ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_afficherTous
            // 
            this.button_afficherTous.Location = new System.Drawing.Point(318, 305);
            this.button_afficherTous.Name = "button_afficherTous";
            this.button_afficherTous.Size = new System.Drawing.Size(131, 23);
            this.button_afficherTous.TabIndex = 9;
            this.button_afficherTous.Text = "Afficher Tous";
            this.button_afficherTous.UseVisualStyleBackColor = true;
            this.button_afficherTous.Click += new System.EventHandler(this.button_afficherTous_Click);
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(507, 305);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 8;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // dataGridView_stagiaires
            // 
            this.dataGridView_stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stagiaires.Location = new System.Drawing.Point(75, 135);
            this.dataGridView_stagiaires.Name = "dataGridView_stagiaires";
            this.dataGridView_stagiaires.Size = new System.Drawing.Size(671, 150);
            this.dataGridView_stagiaires.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button_Ok);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Nom);
            this.panel1.Controls.Add(this.radioButton_Prénom);
            this.panel1.Controls.Add(this.radioButton_Numéro);
            this.panel1.Controls.Add(this.radioButton_Téléphone);
            this.panel1.Location = new System.Drawing.Point(142, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 37);
            this.panel1.TabIndex = 7;
            // 
            // radioButton_Nom
            // 
            this.radioButton_Nom.AutoSize = true;
            this.radioButton_Nom.Location = new System.Drawing.Point(166, 3);
            this.radioButton_Nom.Name = "radioButton_Nom";
            this.radioButton_Nom.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nom.TabIndex = 3;
            this.radioButton_Nom.TabStop = true;
            this.radioButton_Nom.Text = "Nom";
            this.radioButton_Nom.UseVisualStyleBackColor = true;
            // 
            // radioButton_Prénom
            // 
            this.radioButton_Prénom.AutoSize = true;
            this.radioButton_Prénom.Location = new System.Drawing.Point(290, 3);
            this.radioButton_Prénom.Name = "radioButton_Prénom";
            this.radioButton_Prénom.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Prénom.TabIndex = 4;
            this.radioButton_Prénom.TabStop = true;
            this.radioButton_Prénom.Text = "Prénom";
            this.radioButton_Prénom.UseVisualStyleBackColor = true;
            // 
            // radioButton_Numéro
            // 
            this.radioButton_Numéro.AutoSize = true;
            this.radioButton_Numéro.Location = new System.Drawing.Point(51, 3);
            this.radioButton_Numéro.Name = "radioButton_Numéro";
            this.radioButton_Numéro.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Numéro.TabIndex = 2;
            this.radioButton_Numéro.TabStop = true;
            this.radioButton_Numéro.Text = "Numéro";
            this.radioButton_Numéro.UseVisualStyleBackColor = true;
            // 
            // radioButton_Téléphone
            // 
            this.radioButton_Téléphone.AutoSize = true;
            this.radioButton_Téléphone.Location = new System.Drawing.Point(415, 3);
            this.radioButton_Téléphone.Name = "radioButton_Téléphone";
            this.radioButton_Téléphone.Size = new System.Drawing.Size(76, 17);
            this.radioButton_Téléphone.TabIndex = 5;
            this.radioButton_Téléphone.TabStop = true;
            this.radioButton_Téléphone.Text = "Téléphone";
            this.radioButton_Téléphone.UseVisualStyleBackColor = true;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(496, 62);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valeur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Champ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 352);
            this.Controls.Add(this.button_afficherTous);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.dataGridView_stagiaires);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_afficherTous;
        private System.Windows.Forms.Button button_Effacer;
        private System.Windows.Forms.DataGridView dataGridView_stagiaires;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Nom;
        private System.Windows.Forms.RadioButton radioButton_Prénom;
        private System.Windows.Forms.RadioButton radioButton_Numéro;
        private System.Windows.Forms.RadioButton radioButton_Téléphone;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

