namespace ADO5
{
    partial class Form_Notes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.comboBox_module = new System.Windows.Forms.ComboBox();
            this.comboBox_stagiaire = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_apercu = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_notes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_moyenne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DES NOTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_note);
            this.panel1.Controls.Add(this.comboBox_module);
            this.panel1.Controls.Add(this.comboBox_stagiaire);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 138);
            this.panel1.TabIndex = 2;
            // 
            // textBox_note
            // 
            this.textBox_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_note.Location = new System.Drawing.Point(114, 87);
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(213, 20);
            this.textBox_note.TabIndex = 3;
            // 
            // comboBox_module
            // 
            this.comboBox_module.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_module.FormattingEnabled = true;
            this.comboBox_module.Location = new System.Drawing.Point(114, 58);
            this.comboBox_module.Name = "comboBox_module";
            this.comboBox_module.Size = new System.Drawing.Size(213, 21);
            this.comboBox_module.TabIndex = 2;
            this.comboBox_module.SelectedIndexChanged += new System.EventHandler(this.comboBox_module_SelectedIndexChanged);
            // 
            // comboBox_stagiaire
            // 
            this.comboBox_stagiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_stagiaire.FormattingEnabled = true;
            this.comboBox_stagiaire.Location = new System.Drawing.Point(114, 29);
            this.comboBox_stagiaire.Name = "comboBox_stagiaire";
            this.comboBox_stagiaire.Size = new System.Drawing.Size(213, 21);
            this.comboBox_stagiaire.TabIndex = 1;
            this.comboBox_stagiaire.SelectedIndexChanged += new System.EventHandler(this.comboBox_stagiaire_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom et Prénom";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_apercu);
            this.panel2.Controls.Add(this.button_modifier);
            this.panel2.Controls.Add(this.button_enregistrer);
            this.panel2.Controls.Add(this.button_nouveau);
            this.panel2.Location = new System.Drawing.Point(378, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 223);
            this.panel2.TabIndex = 3;
            // 
            // button_apercu
            // 
            this.button_apercu.Image = global::ADO5.Properties.Resources.page_magnifier;
            this.button_apercu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_apercu.Location = new System.Drawing.Point(18, 162);
            this.button_apercu.Name = "button_apercu";
            this.button_apercu.Size = new System.Drawing.Size(192, 40);
            this.button_apercu.TabIndex = 7;
            this.button_apercu.Text = "Aperçu";
            this.button_apercu.UseVisualStyleBackColor = true;
            this.button_apercu.Click += new System.EventHandler(this.button_apercu_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Image = global::ADO5.Properties.Resources.save_as;
            this.button_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier.Location = new System.Drawing.Point(18, 114);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(192, 40);
            this.button_modifier.TabIndex = 6;
            this.button_modifier.Text = "Modifier Note";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Image = global::ADO5.Properties.Resources.diskette;
            this.button_enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_enregistrer.Location = new System.Drawing.Point(18, 66);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(192, 40);
            this.button_enregistrer.TabIndex = 5;
            this.button_enregistrer.Text = "Enregistrer Note";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Image = global::ADO5.Properties.Resources.page_white1;
            this.button_nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nouveau.Location = new System.Drawing.Point(18, 18);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(192, 40);
            this.button_nouveau.TabIndex = 4;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView_notes);
            this.panel3.Location = new System.Drawing.Point(16, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 141);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView_notes
            // 
            this.dataGridView_notes.AllowUserToAddRows = false;
            this.dataGridView_notes.AllowUserToDeleteRows = false;
            this.dataGridView_notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_notes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_notes.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_notes.MultiSelect = false;
            this.dataGridView_notes.Name = "dataGridView_notes";
            this.dataGridView_notes.ReadOnly = true;
            this.dataGridView_notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_notes.Size = new System.Drawing.Size(585, 132);
            this.dataGridView_notes.TabIndex = 9;
            this.dataGridView_notes.SelectionChanged += new System.EventHandler(this.dataGridView_notes_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox_moyenne);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(16, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 79);
            this.panel4.TabIndex = 5;
            // 
            // textBox_moyenne
            // 
            this.textBox_moyenne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_moyenne.Location = new System.Drawing.Point(87, 28);
            this.textBox_moyenne.Name = "textBox_moyenne";
            this.textBox_moyenne.ReadOnly = true;
            this.textBox_moyenne.Size = new System.Drawing.Size(237, 20);
            this.textBox_moyenne.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moyenne";
            // 
            // Form_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 467);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Notes";
            this.Text = "Gestion des Notes";
            this.Load += new System.EventHandler(this.Form_Notes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.ComboBox comboBox_module;
        private System.Windows.Forms.ComboBox comboBox_stagiaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_apercu;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.DataGridView dataGridView_notes;
        private System.Windows.Forms.TextBox textBox_moyenne;
        private System.Windows.Forms.Label label5;
    }
}