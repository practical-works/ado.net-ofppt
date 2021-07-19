namespace ADO2
{
    partial class Form_Clients
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
            this.textBox_CIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CIN
            // 
            this.textBox_CIN.BackColor = System.Drawing.Color.Gray;
            this.textBox_CIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CIN.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CIN.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CIN.Location = new System.Drawing.Point(15, 41);
            this.textBox_CIN.Name = "textBox_CIN";
            this.textBox_CIN.Size = new System.Drawing.Size(110, 22);
            this.textBox_CIN.TabIndex = 1;
            this.textBox_CIN.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.BackColor = System.Drawing.Color.Gray;
            this.textBox_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Nom.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_Nom.Location = new System.Drawing.Point(15, 99);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(213, 22);
            this.textBox_Nom.TabIndex = 2;
            this.textBox_Nom.Text = "Shadoglu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.BackColor = System.Drawing.Color.Gray;
            this.textBox_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Prenom.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_Prenom.Location = new System.Drawing.Point(15, 144);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(213, 22);
            this.textBox_Prenom.TabIndex = 3;
            this.textBox_Prenom.Text = "Feride";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ville";
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.BackColor = System.Drawing.Color.Gray;
            this.textBox_Ville.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ville.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_Ville.Location = new System.Drawing.Point(15, 208);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(213, 22);
            this.textBox_Ville.TabIndex = 4;
            this.textBox_Ville.Text = "Marrakech";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(15, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Téléphone";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.BackColor = System.Drawing.Color.Gray;
            this.textBox_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Tel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_Tel.Location = new System.Drawing.Point(15, 255);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(213, 22);
            this.textBox_Tel.TabIndex = 5;
            this.textBox_Tel.Text = "+6100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_CIN);
            this.groupBox1.Controls.Add(this.textBox_Tel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_Nom);
            this.groupBox1.Controls.Add(this.textBox_Ville);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Prenom);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 300);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listView1.Location = new System.Drawing.Point(8, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(669, 215);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ADO2.Properties.Resources.input_keyboard;
            this.pictureBox1.Location = new System.Drawing.Point(131, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.DimGray;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_insert.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_insert.Image = global::ADO2.Properties.Resources.add;
            this.button_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_insert.Location = new System.Drawing.Point(143, 20);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(129, 22);
            this.button_insert.TabIndex = 7;
            this.button_insert.Text = "Ajouter";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click_1);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DimGray;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_clear.Image = global::ADO2.Properties.Resources.document_empty;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Location = new System.Drawing.Point(548, 20);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(129, 22);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Vider";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DimGray;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_delete.Image = global::ADO2.Properties.Resources.delete;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(413, 20);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(129, 22);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DimGray;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_update.Image = global::ADO2.Properties.Resources.edit_button;
            this.button_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_update.Location = new System.Drawing.Point(278, 20);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(129, 22);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "Modifier";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.DimGray;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_search.Image = global::ADO2.Properties.Resources.magnifier;
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_search.Location = new System.Drawing.Point(8, 20);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(129, 22);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Rechercher";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_clear);
            this.groupBox2.Controls.Add(this.button_search);
            this.groupBox2.Controls.Add(this.button_insert);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(258, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 52);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edition";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(258, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 242);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste";
            // 
            // Form_Clients
            // 
            this.AcceptButton = this.button_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(955, 328);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Clients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

