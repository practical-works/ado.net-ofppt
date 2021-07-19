namespace Exercice_2_TP01
{
    partial class Form1
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
            this.button_Effacer = new System.Windows.Forms.Button();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.listBox_Stagiaires = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Numéro = new System.Windows.Forms.RadioButton();
            this.radioButton_Nom = new System.Windows.Forms.RadioButton();
            this.radioButton_Prénom = new System.Windows.Forms.RadioButton();
            this.radioButton_Téléphone = new System.Windows.Forms.RadioButton();
            this.textBox_valeur = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(346, 211);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 5;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(221, 211);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 4;
            this.button_Afficher.Text = "Afficher";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // listBox_Stagiaires
            // 
            this.listBox_Stagiaires.FormattingEnabled = true;
            this.listBox_Stagiaires.Location = new System.Drawing.Point(56, 12);
            this.listBox_Stagiaires.Name = "listBox_Stagiaires";
            this.listBox_Stagiaires.Size = new System.Drawing.Size(554, 186);
            this.listBox_Stagiaires.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Ok);
            this.groupBox1.Controls.Add(this.textBox_valeur);
            this.groupBox1.Controls.Add(this.radioButton_Téléphone);
            this.groupBox1.Controls.Add(this.radioButton_Prénom);
            this.groupBox1.Controls.Add(this.radioButton_Nom);
            this.groupBox1.Controls.Add(this.radioButton_Numéro);
            this.groupBox1.Location = new System.Drawing.Point(56, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // radioButton_Numéro
            // 
            this.radioButton_Numéro.AutoSize = true;
            this.radioButton_Numéro.Location = new System.Drawing.Point(125, 33);
            this.radioButton_Numéro.Name = "radioButton_Numéro";
            this.radioButton_Numéro.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Numéro.TabIndex = 0;
            this.radioButton_Numéro.TabStop = true;
            this.radioButton_Numéro.Text = "Numéro";
            this.radioButton_Numéro.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nom
            // 
            this.radioButton_Nom.AutoSize = true;
            this.radioButton_Nom.Location = new System.Drawing.Point(226, 33);
            this.radioButton_Nom.Name = "radioButton_Nom";
            this.radioButton_Nom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton_Nom.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nom.TabIndex = 1;
            this.radioButton_Nom.TabStop = true;
            this.radioButton_Nom.Text = "Nom";
            this.radioButton_Nom.UseVisualStyleBackColor = true;
            // 
            // radioButton_Prénom
            // 
            this.radioButton_Prénom.AutoSize = true;
            this.radioButton_Prénom.Location = new System.Drawing.Point(327, 33);
            this.radioButton_Prénom.Name = "radioButton_Prénom";
            this.radioButton_Prénom.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Prénom.TabIndex = 2;
            this.radioButton_Prénom.TabStop = true;
            this.radioButton_Prénom.Text = "Prénom";
            this.radioButton_Prénom.UseVisualStyleBackColor = true;
            // 
            // radioButton_Téléphone
            // 
            this.radioButton_Téléphone.AutoSize = true;
            this.radioButton_Téléphone.Location = new System.Drawing.Point(428, 33);
            this.radioButton_Téléphone.Name = "radioButton_Téléphone";
            this.radioButton_Téléphone.Size = new System.Drawing.Size(76, 17);
            this.radioButton_Téléphone.TabIndex = 3;
            this.radioButton_Téléphone.TabStop = true;
            this.radioButton_Téléphone.Text = "Téléphone";
            this.radioButton_Téléphone.UseVisualStyleBackColor = true;
            // 
            // textBox_valeur
            // 
            this.textBox_valeur.Location = new System.Drawing.Point(125, 75);
            this.textBox_valeur.Name = "textBox_valeur";
            this.textBox_valeur.Size = new System.Drawing.Size(306, 20);
            this.textBox_valeur.TabIndex = 4;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(450, 72);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 5;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Champ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valeur :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.listBox_Stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Effacer;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.ListBox listBox_Stagiaires;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox_valeur;
        private System.Windows.Forms.RadioButton radioButton_Téléphone;
        private System.Windows.Forms.RadioButton radioButton_Prénom;
        private System.Windows.Forms.RadioButton radioButton_Nom;
        private System.Windows.Forms.RadioButton radioButton_Numéro;
    }
}

