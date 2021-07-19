namespace GestionAbonnements
{
    partial class Form_Contrat
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
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_codeContrat = new System.Windows.Forms.NumericUpDown();
            this.comboBox_codeAbo = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Quantite = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_LibelleProduit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codeContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abonné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // numericUpDown_codeContrat
            // 
            this.numericUpDown_codeContrat.Location = new System.Drawing.Point(87, 31);
            this.numericUpDown_codeContrat.Name = "numericUpDown_codeContrat";
            this.numericUpDown_codeContrat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_codeContrat.TabIndex = 1;
            // 
            // comboBox_codeAbo
            // 
            this.comboBox_codeAbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_codeAbo.FormattingEnabled = true;
            this.comboBox_codeAbo.Location = new System.Drawing.Point(87, 63);
            this.comboBox_codeAbo.Name = "comboBox_codeAbo";
            this.comboBox_codeAbo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_codeAbo.TabIndex = 2;
            // 
            // numericUpDown_Quantite
            // 
            this.numericUpDown_Quantite.Location = new System.Drawing.Point(87, 125);
            this.numericUpDown_Quantite.Name = "numericUpDown_Quantite";
            this.numericUpDown_Quantite.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Quantite.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(87, 155);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_date.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_LibelleProduit
            // 
            this.comboBox_LibelleProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LibelleProduit.FormattingEnabled = true;
            this.comboBox_LibelleProduit.Location = new System.Drawing.Point(87, 98);
            this.comboBox_LibelleProduit.Name = "comboBox_LibelleProduit";
            this.comboBox_LibelleProduit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_LibelleProduit.TabIndex = 3;
            // 
            // Form_Contrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.numericUpDown_Quantite);
            this.Controls.Add(this.comboBox_LibelleProduit);
            this.Controls.Add(this.comboBox_codeAbo);
            this.Controls.Add(this.numericUpDown_codeContrat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Contrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des contrats";
            this.Load += new System.EventHandler(this.Form_Contrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codeContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_codeContrat;
        private System.Windows.Forms.ComboBox comboBox_codeAbo;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantite;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_LibelleProduit;
    }
}