namespace Synthèse
{
    partial class Produits___Ajout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.textBox_Libellé = new System.Windows.Forms.TextBox();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.textBox_Origine = new System.Windows.Forms.TextBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libellé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Origine :";
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(105, 26);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numéro.TabIndex = 4;
            // 
            // textBox_Libellé
            // 
            this.textBox_Libellé.Location = new System.Drawing.Point(286, 26);
            this.textBox_Libellé.Name = "textBox_Libellé";
            this.textBox_Libellé.Size = new System.Drawing.Size(100, 20);
            this.textBox_Libellé.TabIndex = 5;
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(286, 90);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prix.TabIndex = 6;
            // 
            // textBox_Origine
            // 
            this.textBox_Origine.Location = new System.Drawing.Point(105, 90);
            this.textBox_Origine.Name = "textBox_Origine";
            this.textBox_Origine.Size = new System.Drawing.Size(100, 20);
            this.textBox_Origine.TabIndex = 7;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(173, 133);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 8;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // Produits___Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 167);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.textBox_Origine);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.textBox_Libellé);
            this.Controls.Add(this.textBox_Numéro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produits___Ajout";
            this.Text = "Produits - Ajout";
            this.Load += new System.EventHandler(this.Produits___Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.TextBox textBox_Libellé;
        private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.TextBox textBox_Origine;
        private System.Windows.Forms.Button button_Ajouter;
    }
}