namespace GestionAbonnements
{
    partial class Form_Abonnes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_afficher = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_premier = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_dernier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_codeAbo = new System.Windows.Forms.NumericUpDown();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codeAbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_afficher
            // 
            this.button_afficher.Location = new System.Drawing.Point(22, 275);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(143, 54);
            this.button_afficher.TabIndex = 0;
            this.button_afficher.Text = "Afficher";
            this.button_afficher.UseVisualStyleBackColor = true;
            this.button_afficher.Click += new System.EventHandler(this.button_afficher_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(171, 275);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 54);
            this.button_ajouter.TabIndex = 0;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(320, 275);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 54);
            this.button_modifier.TabIndex = 0;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(469, 275);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(143, 54);
            this.button_supprimer.TabIndex = 0;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_premier
            // 
            this.button_premier.Location = new System.Drawing.Point(22, 201);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(57, 46);
            this.button_premier.TabIndex = 1;
            this.button_premier.Text = "<<";
            this.button_premier.UseVisualStyleBackColor = true;
            this.button_premier.Click += new System.EventHandler(this.button_premier_Click);
            // 
            // button_precedent
            // 
            this.button_precedent.Location = new System.Drawing.Point(85, 201);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(57, 46);
            this.button_precedent.TabIndex = 1;
            this.button_precedent.Text = "<";
            this.button_precedent.UseVisualStyleBackColor = true;
            this.button_precedent.Click += new System.EventHandler(this.button_precedent_Click);
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(148, 201);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(57, 46);
            this.button_suivant.TabIndex = 1;
            this.button_suivant.Text = ">";
            this.button_suivant.UseVisualStyleBackColor = true;
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // button_dernier
            // 
            this.button_dernier.Location = new System.Drawing.Point(211, 201);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(57, 46);
            this.button_dernier.TabIndex = 1;
            this.button_dernier.Text = ">>";
            this.button_dernier.UseVisualStyleBackColor = true;
            this.button_dernier.Click += new System.EventHandler(this.button_dernier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Téléphone";
            // 
            // numericUpDown_codeAbo
            // 
            this.numericUpDown_codeAbo.Location = new System.Drawing.Point(115, 15);
            this.numericUpDown_codeAbo.Name = "numericUpDown_codeAbo";
            this.numericUpDown_codeAbo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_codeAbo.TabIndex = 3;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(115, 54);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(120, 20);
            this.textBox_nom.TabIndex = 4;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(115, 80);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(120, 79);
            this.textBox_adresse.TabIndex = 4;
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(115, 165);
            this.maskedTextBox_telephone.Mask = "\\0600000000";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox_telephone.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(324, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form_Abonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.numericUpDown_codeAbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_dernier);
            this.Controls.Add(this.button_suivant);
            this.Controls.Add(this.button_precedent);
            this.Controls.Add(this.button_premier);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_afficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Abonnes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des abonnés";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codeAbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_codeAbo;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}