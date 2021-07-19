namespace Exercice_2_TP05
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.comboBox_Numero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = " Tél :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = " Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = " Nom :";
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(208, 148);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(78, 23);
            this.button_Supprimer.TabIndex = 33;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(99, 148);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(78, 23);
            this.button_Modifier.TabIndex = 32;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Location = new System.Drawing.Point(248, 69);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(103, 20);
            this.textBox_Prenom.TabIndex = 31;
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(248, 97);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(103, 20);
            this.textBox_Tel.TabIndex = 30;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(248, 43);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(103, 20);
            this.textBox_Nom.TabIndex = 29;
            // 
            // comboBox_Numero
            // 
            this.comboBox_Numero.FormattingEnabled = true;
            this.comboBox_Numero.Location = new System.Drawing.Point(30, 40);
            this.comboBox_Numero.Name = "comboBox_Numero";
            this.comboBox_Numero.Size = new System.Drawing.Size(124, 21);
            this.comboBox_Numero.TabIndex = 28;
            this.comboBox_Numero.Text = " ";
            this.comboBox_Numero.SelectedIndexChanged += new System.EventHandler(this.comboBox_Numero_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.textBox_Prenom);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.comboBox_Numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.ComboBox comboBox_Numero;
    }
}

