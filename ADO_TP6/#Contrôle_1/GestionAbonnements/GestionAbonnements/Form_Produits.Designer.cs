namespace GestionAbonnements
{
    partial class Form_Produits
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton_libelle = new System.Windows.Forms.RadioButton();
            this.radioButton_prix = new System.Windows.Forms.RadioButton();
            this.radioButton_tous = new System.Windows.Forms.RadioButton();
            this.numericUpDown_prix = new System.Windows.Forms.NumericUpDown();
            this.textBox_libelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // radioButton_libelle
            // 
            this.radioButton_libelle.AutoSize = true;
            this.radioButton_libelle.Location = new System.Drawing.Point(139, 19);
            this.radioButton_libelle.Name = "radioButton_libelle";
            this.radioButton_libelle.Size = new System.Drawing.Size(70, 17);
            this.radioButton_libelle.TabIndex = 1;
            this.radioButton_libelle.TabStop = true;
            this.radioButton_libelle.Text = "Par libellé";
            this.radioButton_libelle.UseVisualStyleBackColor = true;
            this.radioButton_libelle.CheckedChanged += new System.EventHandler(this.radioButton_libelle_CheckedChanged);
            // 
            // radioButton_prix
            // 
            this.radioButton_prix.AutoSize = true;
            this.radioButton_prix.Location = new System.Drawing.Point(341, 19);
            this.radioButton_prix.Name = "radioButton_prix";
            this.radioButton_prix.Size = new System.Drawing.Size(60, 17);
            this.radioButton_prix.TabIndex = 1;
            this.radioButton_prix.TabStop = true;
            this.radioButton_prix.Text = "Par prix";
            this.radioButton_prix.UseVisualStyleBackColor = true;
            this.radioButton_prix.CheckedChanged += new System.EventHandler(this.radioButton_prix_CheckedChanged);
            // 
            // radioButton_tous
            // 
            this.radioButton_tous.AutoSize = true;
            this.radioButton_tous.Location = new System.Drawing.Point(58, 19);
            this.radioButton_tous.Name = "radioButton_tous";
            this.radioButton_tous.Size = new System.Drawing.Size(49, 17);
            this.radioButton_tous.TabIndex = 1;
            this.radioButton_tous.TabStop = true;
            this.radioButton_tous.Text = "Tous";
            this.radioButton_tous.UseVisualStyleBackColor = true;
            this.radioButton_tous.CheckedChanged += new System.EventHandler(this.radioButton_tous_CheckedChanged);
            // 
            // numericUpDown_prix
            // 
            this.numericUpDown_prix.Location = new System.Drawing.Point(407, 19);
            this.numericUpDown_prix.Name = "numericUpDown_prix";
            this.numericUpDown_prix.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_prix.TabIndex = 2;
            this.numericUpDown_prix.ValueChanged += new System.EventHandler(this.numericUpDown_prix_ValueChanged);
            // 
            // textBox_libelle
            // 
            this.textBox_libelle.Location = new System.Drawing.Point(215, 16);
            this.textBox_libelle.Name = "textBox_libelle";
            this.textBox_libelle.Size = new System.Drawing.Size(100, 20);
            this.textBox_libelle.TabIndex = 3;
            this.textBox_libelle.TextChanged += new System.EventHandler(this.textBox_libelle_TextChanged);
            // 
            // Form_Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 281);
            this.Controls.Add(this.textBox_libelle);
            this.Controls.Add(this.numericUpDown_prix);
            this.Controls.Add(this.radioButton_prix);
            this.Controls.Add(this.radioButton_tous);
            this.Controls.Add(this.radioButton_libelle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Produits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des produits";
            this.Load += new System.EventHandler(this.Form_Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_libelle;
        private System.Windows.Forms.RadioButton radioButton_prix;
        private System.Windows.Forms.RadioButton radioButton_tous;
        private System.Windows.Forms.NumericUpDown numericUpDown_prix;
        private System.Windows.Forms.TextBox textBox_libelle;
    }
}