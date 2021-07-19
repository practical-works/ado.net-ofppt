namespace Exercice_2_TP07
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
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.radioButton_Numéro = new System.Windows.Forms.RadioButton();
            this.radioButton_Prénom = new System.Windows.Forms.RadioButton();
            this.radioButton_Nom = new System.Windows.Forms.RadioButton();
            this.radioButton_Téléphone = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Téléphone);
            this.groupBox1.Controls.Add(this.radioButton_Nom);
            this.groupBox1.Controls.Add(this.radioButton_Prénom);
            this.groupBox1.Controls.Add(this.radioButton_Numéro);
            this.groupBox1.Controls.Add(this.textBox_Téléphone);
            this.groupBox1.Controls.Add(this.textBox_Nom);
            this.groupBox1.Controls.Add(this.textBox_Prénom);
            this.groupBox1.Controls.Add(this.textBox_Numéro);
            this.groupBox1.Controls.Add(this.button_Rechercher);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veuillez choisir le critère de recherche";
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(249, 113);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 0;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(147, 30);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(124, 20);
            this.textBox_Numéro.TabIndex = 1;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Location = new System.Drawing.Point(147, 69);
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(124, 20);
            this.textBox_Prénom.TabIndex = 2;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(436, 30);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(124, 20);
            this.textBox_Nom.TabIndex = 3;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(436, 69);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(124, 20);
            this.textBox_Téléphone.TabIndex = 4;
            // 
            // radioButton_Numéro
            // 
            this.radioButton_Numéro.AutoSize = true;
            this.radioButton_Numéro.Location = new System.Drawing.Point(31, 31);
            this.radioButton_Numéro.Name = "radioButton_Numéro";
            this.radioButton_Numéro.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Numéro.TabIndex = 5;
            this.radioButton_Numéro.TabStop = true;
            this.radioButton_Numéro.Text = "Numéro";
            this.radioButton_Numéro.UseVisualStyleBackColor = true;
            this.radioButton_Numéro.CheckedChanged += new System.EventHandler(this.radioButton_Numéro_CheckedChanged);
            // 
            // radioButton_Prénom
            // 
            this.radioButton_Prénom.AutoSize = true;
            this.radioButton_Prénom.Location = new System.Drawing.Point(31, 70);
            this.radioButton_Prénom.Name = "radioButton_Prénom";
            this.radioButton_Prénom.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Prénom.TabIndex = 6;
            this.radioButton_Prénom.TabStop = true;
            this.radioButton_Prénom.Text = "Prénom";
            this.radioButton_Prénom.UseVisualStyleBackColor = true;
            this.radioButton_Prénom.CheckedChanged += new System.EventHandler(this.radioButton_Prénom_CheckedChanged);
            // 
            // radioButton_Nom
            // 
            this.radioButton_Nom.AutoSize = true;
            this.radioButton_Nom.Location = new System.Drawing.Point(323, 31);
            this.radioButton_Nom.Name = "radioButton_Nom";
            this.radioButton_Nom.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nom.TabIndex = 7;
            this.radioButton_Nom.TabStop = true;
            this.radioButton_Nom.Text = "Nom";
            this.radioButton_Nom.UseVisualStyleBackColor = true;
            this.radioButton_Nom.CheckedChanged += new System.EventHandler(this.radioButton_Nom_CheckedChanged);
            // 
            // radioButton_Téléphone
            // 
            this.radioButton_Téléphone.AutoSize = true;
            this.radioButton_Téléphone.Location = new System.Drawing.Point(323, 70);
            this.radioButton_Téléphone.Name = "radioButton_Téléphone";
            this.radioButton_Téléphone.Size = new System.Drawing.Size(76, 17);
            this.radioButton_Téléphone.TabIndex = 8;
            this.radioButton_Téléphone.TabStop = true;
            this.radioButton_Téléphone.Text = "Téléphone";
            this.radioButton_Téléphone.UseVisualStyleBackColor = true;
            this.radioButton_Téléphone.CheckedChanged += new System.EventHandler(this.radioButton_Téléphone_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Téléphone;
        private System.Windows.Forms.RadioButton radioButton_Nom;
        private System.Windows.Forms.RadioButton radioButton_Prénom;
        private System.Windows.Forms.RadioButton radioButton_Numéro;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

