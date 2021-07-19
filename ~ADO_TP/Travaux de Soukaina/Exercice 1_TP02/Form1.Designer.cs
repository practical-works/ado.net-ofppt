namespace Exercice_1_TP02
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox4_Prénom = new System.Windows.Forms.TextBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NumAModifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TélAModifier = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NumASupprimer = new System.Windows.Forms.TextBox();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(607, 186);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_Ajouter);
            this.groupBox1.Controls.Add(this.textBox4_Prénom);
            this.groupBox1.Controls.Add(this.textBox_Téléphone);
            this.groupBox1.Controls.Add(this.textBox_Nom);
            this.groupBox1.Controls.Add(this.textBox_Numéro);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(470, 19);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 2;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(135, 19);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numéro.TabIndex = 3;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(470, 45);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Téléphone.TabIndex = 4;
            // 
            // textBox4_Prénom
            // 
            this.textBox4_Prénom.Location = new System.Drawing.Point(135, 45);
            this.textBox4_Prénom.Name = "textBox4_Prénom";
            this.textBox4_Prénom.Size = new System.Drawing.Size(100, 20);
            this.textBox4_Prénom.TabIndex = 5;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(270, 71);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 6;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Téléphone :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Modifier);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_TélAModifier);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_NumAModifier);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numéro :";
            // 
            // textBox_NumAModifier
            // 
            this.textBox_NumAModifier.Location = new System.Drawing.Point(135, 33);
            this.textBox_NumAModifier.Name = "textBox_NumAModifier";
            this.textBox_NumAModifier.Size = new System.Drawing.Size(100, 20);
            this.textBox_NumAModifier.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Téléphone :";
            // 
            // textBox_TélAModifier
            // 
            this.textBox_TélAModifier.Location = new System.Drawing.Point(470, 29);
            this.textBox_TélAModifier.Name = "textBox_TélAModifier";
            this.textBox_TélAModifier.Size = new System.Drawing.Size(100, 20);
            this.textBox_TélAModifier.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Supprimer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_NumASupprimer);
            this.groupBox3.Location = new System.Drawing.Point(12, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suppression";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Numéro :";
            // 
            // textBox_NumASupprimer
            // 
            this.textBox_NumASupprimer.Location = new System.Drawing.Point(213, 29);
            this.textBox_NumASupprimer.Name = "textBox_NumASupprimer";
            this.textBox_NumASupprimer.Size = new System.Drawing.Size(100, 20);
            this.textBox_NumASupprimer.TabIndex = 8;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(396, 27);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 10;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(270, 66);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 13;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.TextBox textBox4_Prénom;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TélAModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NumAModifier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_NumASupprimer;
    }
}

