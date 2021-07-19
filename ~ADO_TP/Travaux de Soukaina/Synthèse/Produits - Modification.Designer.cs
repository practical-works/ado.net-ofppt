namespace Synthèse
{
    partial class Produits___Modification
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
            this.textBox_Origine = new System.Windows.Forms.TextBox();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.textBox_Libellé = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Numéro = new System.Windows.Forms.ComboBox();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Origine
            // 
            this.textBox_Origine.Location = new System.Drawing.Point(110, 84);
            this.textBox_Origine.Name = "textBox_Origine";
            this.textBox_Origine.Size = new System.Drawing.Size(100, 20);
            this.textBox_Origine.TabIndex = 15;
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(291, 84);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prix.TabIndex = 14;
            // 
            // textBox_Libellé
            // 
            this.textBox_Libellé.Location = new System.Drawing.Point(291, 20);
            this.textBox_Libellé.Name = "textBox_Libellé";
            this.textBox_Libellé.Size = new System.Drawing.Size(100, 20);
            this.textBox_Libellé.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Origine :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Libellé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numéro :";
            // 
            // comboBox_Numéro
            // 
            this.comboBox_Numéro.FormattingEnabled = true;
            this.comboBox_Numéro.Location = new System.Drawing.Point(114, 20);
            this.comboBox_Numéro.Name = "comboBox_Numéro";
            this.comboBox_Numéro.Size = new System.Drawing.Size(96, 21);
            this.comboBox_Numéro.TabIndex = 16;
            this.comboBox_Numéro.SelectedIndexChanged += new System.EventHandler(this.comboBox_Numéro_SelectedIndexChanged);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(183, 132);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 17;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // Produits___Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 178);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.comboBox_Numéro);
            this.Controls.Add(this.textBox_Origine);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.textBox_Libellé);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produits___Modification";
            this.Text = "Produits - Modification";
            this.Load += new System.EventHandler(this.Produits___Modification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Origine;
        private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.TextBox textBox_Libellé;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Numéro;
        private System.Windows.Forms.Button button_Modifier;
    }
}