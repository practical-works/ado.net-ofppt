namespace Vigilence
{
    partial class Form_RechercheQuartiers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_nbr_syndics = new System.Windows.Forms.Label();
            this.label_chiffre_affaires = new System.Windows.Forms.Label();
            this.label_nbr_contrats = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.num_code = new System.Windows.Forms.NumericUpDown();
            this.combo_ville = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_population = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_rechercher = new System.Windows.Forms.NumericUpDown();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_biens_immobilier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_syndics = new System.Windows.Forms.Button();
            this.label_liste = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_total);
            this.groupBox1.Controls.Add(this.num_code);
            this.groupBox1.Controls.Add(this.combo_ville);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_population);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 279);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information du quartier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_nbr_syndics);
            this.groupBox2.Controls.Add(this.label_chiffre_affaires);
            this.groupBox2.Controls.Add(this.label_nbr_contrats);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(19, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 103);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depuis le début de l\'année en cours";
            // 
            // label_nbr_syndics
            // 
            this.label_nbr_syndics.AutoSize = true;
            this.label_nbr_syndics.Location = new System.Drawing.Point(124, 72);
            this.label_nbr_syndics.Name = "label_nbr_syndics";
            this.label_nbr_syndics.Size = new System.Drawing.Size(13, 13);
            this.label_nbr_syndics.TabIndex = 14;
            this.label_nbr_syndics.Text = "0";
            // 
            // label_chiffre_affaires
            // 
            this.label_chiffre_affaires.AutoSize = true;
            this.label_chiffre_affaires.Location = new System.Drawing.Point(103, 51);
            this.label_chiffre_affaires.Name = "label_chiffre_affaires";
            this.label_chiffre_affaires.Size = new System.Drawing.Size(13, 13);
            this.label_chiffre_affaires.TabIndex = 14;
            this.label_chiffre_affaires.Text = "0";
            // 
            // label_nbr_contrats
            // 
            this.label_nbr_contrats.AutoSize = true;
            this.label_nbr_contrats.Location = new System.Drawing.Point(124, 30);
            this.label_nbr_contrats.Name = "label_nbr_contrats";
            this.label_nbr_contrats.Size = new System.Drawing.Size(13, 13);
            this.label_nbr_contrats.TabIndex = 14;
            this.label_nbr_contrats.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nombre de syndics :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Chiffre d\'affaire :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre de contrats :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personnes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DH";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(81, 51);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(120, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // num_total
            // 
            this.num_total.Location = new System.Drawing.Point(81, 130);
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(67, 20);
            this.num_total.TabIndex = 8;
            // 
            // num_code
            // 
            this.num_code.Enabled = false;
            this.num_code.Location = new System.Drawing.Point(81, 26);
            this.num_code.Name = "num_code";
            this.num_code.ReadOnly = true;
            this.num_code.Size = new System.Drawing.Size(67, 20);
            this.num_code.TabIndex = 1;
            // 
            // combo_ville
            // 
            this.combo_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ville.FormattingEnabled = true;
            this.combo_ville.Location = new System.Drawing.Point(81, 105);
            this.combo_ville.Name = "combo_ville";
            this.combo_ville.Size = new System.Drawing.Size(121, 21);
            this.combo_ville.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Population :";
            // 
            // num_population
            // 
            this.num_population.Location = new System.Drawing.Point(81, 78);
            this.num_population.Name = "num_population";
            this.num_population.Size = new System.Drawing.Size(67, 20);
            this.num_population.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rechercher par code :";
            // 
            // num_rechercher
            // 
            this.num_rechercher.Location = new System.Drawing.Point(126, 16);
            this.num_rechercher.Name = "num_rechercher";
            this.num_rechercher.Size = new System.Drawing.Size(122, 20);
            this.num_rechercher.TabIndex = 13;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(12, 330);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(236, 23);
            this.button_modifier.TabIndex = 14;
            this.button_modifier.Text = "Enregistrer les modifications";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_biens_immobilier
            // 
            this.button_biens_immobilier.Location = new System.Drawing.Point(379, 15);
            this.button_biens_immobilier.Name = "button_biens_immobilier";
            this.button_biens_immobilier.Size = new System.Drawing.Size(217, 23);
            this.button_biens_immobilier.TabIndex = 15;
            this.button_biens_immobilier.Text = "Afficher Quartier et se biens immoblier";
            this.button_biens_immobilier.UseVisualStyleBackColor = true;
            this.button_biens_immobilier.Click += new System.EventHandler(this.button_biens_immobilier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 273);
            this.dataGridView1.TabIndex = 16;
            // 
            // button_syndics
            // 
            this.button_syndics.Location = new System.Drawing.Point(602, 16);
            this.button_syndics.Name = "button_syndics";
            this.button_syndics.Size = new System.Drawing.Size(204, 23);
            this.button_syndics.TabIndex = 15;
            this.button_syndics.Text = "Afficher Quartier et ses syndics";
            this.button_syndics.UseVisualStyleBackColor = true;
            this.button_syndics.Click += new System.EventHandler(this.button_syndics_Click);
            // 
            // label_liste
            // 
            this.label_liste.AutoSize = true;
            this.label_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_liste.Location = new System.Drawing.Point(255, 52);
            this.label_liste.Name = "label_liste";
            this.label_liste.Size = new System.Drawing.Size(53, 25);
            this.label_liste.TabIndex = 17;
            this.label_liste.Text = "Liste";
            // 
            // Form_RechercheQuartiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 365);
            this.Controls.Add(this.label_liste);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_syndics);
            this.Controls.Add(this.button_biens_immobilier);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_rechercher);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_RechercheQuartiers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher Quartiers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.NumericUpDown num_code;
        private System.Windows.Forms.ComboBox combo_ville;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_population;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_rechercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_biens_immobilier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_syndics;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_chiffre_affaires;
        private System.Windows.Forms.Label label_nbr_contrats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_nbr_syndics;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_liste;
    }
}