namespace ADO2_DEC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CIN = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Tel = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_ajouter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_modifier, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_supprimer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_rechercher, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_enregistrer, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 323);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_ajouter.BackColor = System.Drawing.Color.Silver;
            this.button_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ajouter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.ForeColor = System.Drawing.Color.Black;
            this.button_ajouter.Location = new System.Drawing.Point(4, 12);
            this.button_ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(141, 34);
            this.button_ajouter.TabIndex = 0;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_modifier.BackColor = System.Drawing.Color.Silver;
            this.button_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modifier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_modifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.ForeColor = System.Drawing.Color.Black;
            this.button_modifier.Location = new System.Drawing.Point(154, 12);
            this.button_modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(141, 34);
            this.button_modifier.TabIndex = 1;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_supprimer.BackColor = System.Drawing.Color.Silver;
            this.button_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_supprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.ForeColor = System.Drawing.Color.Black;
            this.button_supprimer.Location = new System.Drawing.Point(304, 12);
            this.button_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(141, 34);
            this.button_supprimer.TabIndex = 2;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_rechercher.BackColor = System.Drawing.Color.Silver;
            this.button_rechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rechercher.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_rechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_rechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rechercher.ForeColor = System.Drawing.Color.Black;
            this.button_rechercher.Location = new System.Drawing.Point(454, 12);
            this.button_rechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(141, 34);
            this.button_rechercher.TabIndex = 3;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = false;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_enregistrer.BackColor = System.Drawing.Color.Green;
            this.button_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_enregistrer.FlatAppearance.BorderSize = 2;
            this.button_enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enregistrer.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistrer.ForeColor = System.Drawing.Color.White;
            this.button_enregistrer.Location = new System.Drawing.Point(639, 5);
            this.button_enregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(157, 47);
            this.button_enregistrer.TabIndex = 4;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.37931F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.62069F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox_CIN, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Nom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Prenom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Ville, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBox_Tel, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 292);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphone";
            // 
            // textBox_CIN
            // 
            this.textBox_CIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_CIN.BackColor = System.Drawing.Color.Silver;
            this.textBox_CIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CIN.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CIN.Location = new System.Drawing.Point(117, 13);
            this.textBox_CIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_CIN.Name = "textBox_CIN";
            this.textBox_CIN.Size = new System.Drawing.Size(226, 32);
            this.textBox_CIN.TabIndex = 5;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Nom.BackColor = System.Drawing.Color.Silver;
            this.textBox_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Nom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom.Location = new System.Drawing.Point(117, 71);
            this.textBox_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(226, 32);
            this.textBox_Nom.TabIndex = 6;
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Prenom.BackColor = System.Drawing.Color.Silver;
            this.textBox_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Prenom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prenom.Location = new System.Drawing.Point(117, 129);
            this.textBox_Prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(226, 32);
            this.textBox_Prenom.TabIndex = 7;
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Ville.BackColor = System.Drawing.Color.Silver;
            this.textBox_Ville.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ville.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ville.Location = new System.Drawing.Point(117, 187);
            this.textBox_Ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(226, 32);
            this.textBox_Ville.TabIndex = 8;
            // 
            // maskedTextBox_Tel
            // 
            this.maskedTextBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBox_Tel.BackColor = System.Drawing.Color.Silver;
            this.maskedTextBox_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_Tel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Tel.Location = new System.Drawing.Point(117, 246);
            this.maskedTextBox_Tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox_Tel.Mask = "\\06000";
            this.maskedTextBox_Tel.Name = "maskedTextBox_Tel";
            this.maskedTextBox_Tel.Size = new System.Drawing.Size(226, 32);
            this.maskedTextBox_Tel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(388, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 293);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(836, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Clients (Mode déconnecté)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CIN;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Tel;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_enregistrer;
    }
}

