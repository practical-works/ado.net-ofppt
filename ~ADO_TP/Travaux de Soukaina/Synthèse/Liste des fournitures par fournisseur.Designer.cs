namespace Synthèse
{
    partial class Liste_des_fournitures_par_fournisseur
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
            this.comboBox_Fournisseur = new System.Windows.Forms.ComboBox();
            this.dataGridView_Produit = new System.Windows.Forms.DataGridView();
            this.dataGridView_nbrFournituresParProduit = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_trier = new System.Windows.Forms.Button();
            this.comboBox_Clé = new System.Windows.Forms.ComboBox();
            this.comboBox_Ordre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nbrFournituresParProduit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fournisseur :";
            // 
            // comboBox_Fournisseur
            // 
            this.comboBox_Fournisseur.FormattingEnabled = true;
            this.comboBox_Fournisseur.Location = new System.Drawing.Point(188, 21);
            this.comboBox_Fournisseur.Name = "comboBox_Fournisseur";
            this.comboBox_Fournisseur.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Fournisseur.TabIndex = 3;
            this.comboBox_Fournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBox_Fournisseur_SelectedIndexChanged);
            // 
            // dataGridView_Produit
            // 
            this.dataGridView_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produit.Location = new System.Drawing.Point(18, 57);
            this.dataGridView_Produit.Name = "dataGridView_Produit";
            this.dataGridView_Produit.Size = new System.Drawing.Size(390, 150);
            this.dataGridView_Produit.TabIndex = 5;
            this.dataGridView_Produit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Produit_CellContentClick);
            // 
            // dataGridView_nbrFournituresParProduit
            // 
            this.dataGridView_nbrFournituresParProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nbrFournituresParProduit.Location = new System.Drawing.Point(6, 31);
            this.dataGridView_nbrFournituresParProduit.Name = "dataGridView_nbrFournituresParProduit";
            this.dataGridView_nbrFournituresParProduit.Size = new System.Drawing.Size(390, 166);
            this.dataGridView_nbrFournituresParProduit.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_nbrFournituresParProduit);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombres de fournitures par produit ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_trier);
            this.groupBox2.Controls.Add(this.comboBox_Clé);
            this.groupBox2.Controls.Add(this.comboBox_Ordre);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 64);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordre :";
            // 
            // button_trier
            // 
            this.button_trier.Location = new System.Drawing.Point(303, 19);
            this.button_trier.Name = "button_trier";
            this.button_trier.Size = new System.Drawing.Size(75, 23);
            this.button_trier.TabIndex = 2;
            this.button_trier.Text = "Trier";
            this.button_trier.UseVisualStyleBackColor = true;
            this.button_trier.Click += new System.EventHandler(this.button_trier_Click);
            // 
            // comboBox_Clé
            // 
            this.comboBox_Clé.FormattingEnabled = true;
            this.comboBox_Clé.Location = new System.Drawing.Point(178, 19);
            this.comboBox_Clé.Name = "comboBox_Clé";
            this.comboBox_Clé.Size = new System.Drawing.Size(119, 21);
            this.comboBox_Clé.TabIndex = 1;
            // 
            // comboBox_Ordre
            // 
            this.comboBox_Ordre.FormattingEnabled = true;
            this.comboBox_Ordre.Location = new System.Drawing.Point(51, 19);
            this.comboBox_Ordre.Name = "comboBox_Ordre";
            this.comboBox_Ordre.Size = new System.Drawing.Size(87, 21);
            this.comboBox_Ordre.TabIndex = 0;
            // 
            // Liste_des_fournitures_par_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Produit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Fournisseur);
            this.Name = "Liste_des_fournitures_par_fournisseur";
            this.Text = "Liste_des_fournitures_par_fournisseur";
            this.Load += new System.EventHandler(this.Liste_des_fournitures_par_fournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nbrFournituresParProduit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Fournisseur;
        private System.Windows.Forms.DataGridView dataGridView_Produit;
        private System.Windows.Forms.DataGridView dataGridView_nbrFournituresParProduit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_trier;
        private System.Windows.Forms.ComboBox comboBox_Clé;
        private System.Windows.Forms.ComboBox comboBox_Ordre;
    }
}