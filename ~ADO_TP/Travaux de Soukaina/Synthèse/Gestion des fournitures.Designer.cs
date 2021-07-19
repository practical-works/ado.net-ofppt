namespace Synthèse
{
    partial class Gestion_des_fournitures
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
            this.comboBox_Fournisseur = new System.Windows.Forms.ComboBox();
            this.comboBox_Produit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_Quantité = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Liste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Fournisseur
            // 
            this.comboBox_Fournisseur.FormattingEnabled = true;
            this.comboBox_Fournisseur.Location = new System.Drawing.Point(172, 42);
            this.comboBox_Fournisseur.Name = "comboBox_Fournisseur";
            this.comboBox_Fournisseur.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Fournisseur.TabIndex = 0;
            // 
            // comboBox_Produit
            // 
            this.comboBox_Produit.FormattingEnabled = true;
            this.comboBox_Produit.Location = new System.Drawing.Point(495, 42);
            this.comboBox_Produit.Name = "comboBox_Produit";
            this.comboBox_Produit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Produit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fournisseur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produit :";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(132, 93);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 4;
            // 
            // textBox_Quantité
            // 
            this.textBox_Quantité.Location = new System.Drawing.Point(495, 96);
            this.textBox_Quantité.Name = "textBox_Quantité";
            this.textBox_Quantité.Size = new System.Drawing.Size(121, 20);
            this.textBox_Quantité.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date :";
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(257, 147);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 8;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_Liste
            // 
            this.button_Liste.Location = new System.Drawing.Point(357, 147);
            this.button_Liste.Name = "button_Liste";
            this.button_Liste.Size = new System.Drawing.Size(75, 23);
            this.button_Liste.TabIndex = 9;
            this.button_Liste.Text = "Liste";
            this.button_Liste.UseVisualStyleBackColor = true;
            this.button_Liste.Click += new System.EventHandler(this.button_Liste_Click);
            // 
            // Gestion_des_fournitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 194);
            this.Controls.Add(this.button_Liste);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quantité);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Produit);
            this.Controls.Add(this.comboBox_Fournisseur);
            this.Name = "Gestion_des_fournitures";
            this.Text = "Gestion_des_fournitures";
            this.Load += new System.EventHandler(this.Gestion_des_fournitures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Fournisseur;
        private System.Windows.Forms.ComboBox comboBox_Produit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_Quantité;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Liste;
    }
}