namespace Exercice_3_TP07
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Téléphone);
            this.panel1.Controls.Add(this.textBox_Nom);
            this.panel1.Controls.Add(this.textBox_Prénom);
            this.panel1.Controls.Add(this.textBox_Numéro);
            this.panel1.Controls.Add(this.button_Rechercher);
            this.panel1.Location = new System.Drawing.Point(49, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 115);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numéro :";
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(328, 48);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(124, 20);
            this.textBox_Téléphone.TabIndex = 22;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(328, 9);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(124, 20);
            this.textBox_Nom.TabIndex = 21;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Location = new System.Drawing.Point(70, 48);
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(124, 20);
            this.textBox_Prénom.TabIndex = 20;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(70, 9);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(124, 20);
            this.textBox_Numéro.TabIndex = 19;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(202, 82);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 18;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

