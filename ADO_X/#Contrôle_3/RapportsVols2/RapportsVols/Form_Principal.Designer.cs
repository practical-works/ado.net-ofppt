namespace RapportsVols
{
    partial class Form_Principal
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
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AfficherPassagers = new System.Windows.Forms.Button();
            this.numericUpDown_Vol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AfficherVol = new System.Windows.Forms.Button();
            this.button_DiagVol = new System.Windows.Forms.Button();
            this.button_DiagChiffreAff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vol)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ville.ForeColor = System.Drawing.Color.Green;
            this.textBox_Ville.Location = new System.Drawing.Point(16, 31);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(277, 20);
            this.textBox_Ville.TabIndex = 2;
            this.textBox_Ville.Text = "Paris";
            this.textBox_Ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la ville :";
            // 
            // button_AfficherPassagers
            // 
            this.button_AfficherPassagers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_AfficherPassagers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AfficherPassagers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AfficherPassagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AfficherPassagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AfficherPassagers.Location = new System.Drawing.Point(17, 57);
            this.button_AfficherPassagers.Name = "button_AfficherPassagers";
            this.button_AfficherPassagers.Size = new System.Drawing.Size(276, 27);
            this.button_AfficherPassagers.TabIndex = 2;
            this.button_AfficherPassagers.Text = "Afficher les passagers de la ville";
            this.button_AfficherPassagers.UseVisualStyleBackColor = false;
            this.button_AfficherPassagers.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_Vol
            // 
            this.numericUpDown_Vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Vol.ForeColor = System.Drawing.Color.Green;
            this.numericUpDown_Vol.Location = new System.Drawing.Point(17, 30);
            this.numericUpDown_Vol.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Vol.Name = "numericUpDown_Vol";
            this.numericUpDown_Vol.Size = new System.Drawing.Size(275, 20);
            this.numericUpDown_Vol.TabIndex = 2;
            this.numericUpDown_Vol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Vol.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro du vol :";
            // 
            // button_AfficherVol
            // 
            this.button_AfficherVol.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_AfficherVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AfficherVol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AfficherVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AfficherVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AfficherVol.Location = new System.Drawing.Point(17, 56);
            this.button_AfficherVol.Name = "button_AfficherVol";
            this.button_AfficherVol.Size = new System.Drawing.Size(276, 27);
            this.button_AfficherVol.TabIndex = 2;
            this.button_AfficherVol.Text = "Afficher les détails du vol";
            this.button_AfficherVol.UseVisualStyleBackColor = false;
            this.button_AfficherVol.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_DiagVol
            // 
            this.button_DiagVol.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_DiagVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DiagVol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_DiagVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DiagVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DiagVol.Location = new System.Drawing.Point(15, 14);
            this.button_DiagVol.Name = "button_DiagVol";
            this.button_DiagVol.Size = new System.Drawing.Size(276, 39);
            this.button_DiagVol.TabIndex = 0;
            this.button_DiagVol.Text = "Afficher le diagramme des vols";
            this.button_DiagVol.UseVisualStyleBackColor = false;
            this.button_DiagVol.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_DiagChiffreAff
            // 
            this.button_DiagChiffreAff.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_DiagChiffreAff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DiagChiffreAff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_DiagChiffreAff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DiagChiffreAff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DiagChiffreAff.Location = new System.Drawing.Point(15, 59);
            this.button_DiagChiffreAff.Name = "button_DiagChiffreAff";
            this.button_DiagChiffreAff.Size = new System.Drawing.Size(276, 39);
            this.button_DiagChiffreAff.TabIndex = 1;
            this.button_DiagChiffreAff.Text = "Afficher le diagramme de chiffre d\'affaires";
            this.button_DiagChiffreAff.UseVisualStyleBackColor = false;
            this.button_DiagChiffreAff.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_DiagVol);
            this.panel1.Controls.Add(this.button_DiagChiffreAff);
            this.panel1.Location = new System.Drawing.Point(17, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 116);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown_Vol);
            this.panel2.Controls.Add(this.button_AfficherVol);
            this.panel2.Location = new System.Drawing.Point(17, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 101);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox_Ville);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_AfficherPassagers);
            this.panel3.Location = new System.Drawing.Point(17, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 103);
            this.panel3.TabIndex = 0;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AfficherPassagers;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AfficherVol;
        private System.Windows.Forms.Button button_DiagVol;
        private System.Windows.Forms.Button button_DiagChiffreAff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

