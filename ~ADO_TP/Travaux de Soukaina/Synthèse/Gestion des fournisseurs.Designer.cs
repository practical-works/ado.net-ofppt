namespace Synthèse
{
    partial class Gestion_des_fournisseurs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.dataGridView_Fournisseurs = new System.Windows.Forms.DataGridView();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Supprimer);
            this.panel1.Controls.Add(this.button_Modifier);
            this.panel1.Controls.Add(this.button_Ajouter);
            this.panel1.Location = new System.Drawing.Point(95, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 60);
            this.panel1.TabIndex = 4;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(262, 17);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(71, 23);
            this.button_Supprimer.TabIndex = 2;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(167, 17);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 1;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(71, 17);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 0;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // dataGridView_Fournisseurs
            // 
            this.dataGridView_Fournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fournisseurs.Location = new System.Drawing.Point(25, 178);
            this.dataGridView_Fournisseurs.Name = "dataGridView_Fournisseurs";
            this.dataGridView_Fournisseurs.Size = new System.Drawing.Size(567, 190);
            this.dataGridView_Fournisseurs.TabIndex = 5;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(141, 26);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(118, 20);
            this.textBox_Numéro.TabIndex = 6;
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(141, 67);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(118, 20);
            this.textBox_Ville.TabIndex = 7;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(377, 29);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(126, 20);
            this.textBox_Nom.TabIndex = 8;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(377, 67);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(126, 20);
            this.textBox_Téléphone.TabIndex = 9;
            // 
            // Gestion_des_fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 380);
            this.Controls.Add(this.textBox_Téléphone);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.textBox_Numéro);
            this.Controls.Add(this.dataGridView_Fournisseurs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_des_fournisseurs";
            this.Text = "Gestion_des_fournisseurs";
            this.Load += new System.EventHandler(this.Gestion_des_fournisseurs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.DataGridView dataGridView_Fournisseurs;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Téléphone;
    }
}