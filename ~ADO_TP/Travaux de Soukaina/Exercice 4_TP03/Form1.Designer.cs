namespace Exercice_4_TP03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Ok = new System.Windows.Forms.Button();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_afficherTous = new System.Windows.Forms.Button();
            this.button_Effacer = new System.Windows.Forms.Button();
            this.dataGridView_stagiaires = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Ok);
            this.panel1.Controls.Add(this.textBox_Téléphone);
            this.panel1.Controls.Add(this.textBox_Nom);
            this.panel1.Controls.Add(this.textBox_Prénom);
            this.panel1.Controls.Add(this.textBox_Numéro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 146);
            this.panel1.TabIndex = 13;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(280, 112);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 8;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(451, 76);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Téléphone.TabIndex = 7;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(451, 33);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 6;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Location = new System.Drawing.Point(101, 76);
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prénom.TabIndex = 5;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(101, 33);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numéro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // button_afficherTous
            // 
            this.button_afficherTous.Location = new System.Drawing.Point(235, 391);
            this.button_afficherTous.Name = "button_afficherTous";
            this.button_afficherTous.Size = new System.Drawing.Size(131, 23);
            this.button_afficherTous.TabIndex = 12;
            this.button_afficherTous.Text = "Afficher Tous";
            this.button_afficherTous.UseVisualStyleBackColor = true;
            this.button_afficherTous.Click += new System.EventHandler(this.button_afficherTous_Click);
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(424, 391);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 11;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // dataGridView_stagiaires
            // 
            this.dataGridView_stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stagiaires.Location = new System.Drawing.Point(29, 183);
            this.dataGridView_stagiaires.Name = "dataGridView_stagiaires";
            this.dataGridView_stagiaires.Size = new System.Drawing.Size(671, 185);
            this.dataGridView_stagiaires.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_afficherTous);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.dataGridView_stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_afficherTous;
        private System.Windows.Forms.Button button_Effacer;
        private System.Windows.Forms.DataGridView dataGridView_stagiaires;
    }
}

