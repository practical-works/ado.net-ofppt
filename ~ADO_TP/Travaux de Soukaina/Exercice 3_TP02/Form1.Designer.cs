namespace Exercice_3_TP02
{
    partial class Form1
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
            this.comboBox_Stagiaires = new System.Windows.Forms.ComboBox();
            this.comboBox_Examens = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ChargerLesListes = new System.Windows.Forms.Button();
            this.button_AfficherLaNote = new System.Windows.Forms.Button();
            this.button_ModifierLaNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Stagiaires
            // 
            this.comboBox_Stagiaires.FormattingEnabled = true;
            this.comboBox_Stagiaires.Location = new System.Drawing.Point(163, 26);
            this.comboBox_Stagiaires.Name = "comboBox_Stagiaires";
            this.comboBox_Stagiaires.Size = new System.Drawing.Size(167, 21);
            this.comboBox_Stagiaires.TabIndex = 0;
            // 
            // comboBox_Examens
            // 
            this.comboBox_Examens.FormattingEnabled = true;
            this.comboBox_Examens.Location = new System.Drawing.Point(163, 53);
            this.comboBox_Examens.Name = "comboBox_Examens";
            this.comboBox_Examens.Size = new System.Drawing.Size(167, 21);
            this.comboBox_Examens.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stagiaires :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Examens :";
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(163, 99);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(137, 20);
            this.textBox_Note.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note :";
            // 
            // button_ChargerLesListes
            // 
            this.button_ChargerLesListes.Location = new System.Drawing.Point(131, 155);
            this.button_ChargerLesListes.Name = "button_ChargerLesListes";
            this.button_ChargerLesListes.Size = new System.Drawing.Size(139, 23);
            this.button_ChargerLesListes.TabIndex = 6;
            this.button_ChargerLesListes.Text = "Charger les listes";
            this.button_ChargerLesListes.UseVisualStyleBackColor = true;
            this.button_ChargerLesListes.Click += new System.EventHandler(this.button_ChargerLesListes_Click);
            // 
            // button_AfficherLaNote
            // 
            this.button_AfficherLaNote.Location = new System.Drawing.Point(131, 198);
            this.button_AfficherLaNote.Name = "button_AfficherLaNote";
            this.button_AfficherLaNote.Size = new System.Drawing.Size(139, 23);
            this.button_AfficherLaNote.TabIndex = 7;
            this.button_AfficherLaNote.Text = "Afficher la note";
            this.button_AfficherLaNote.UseVisualStyleBackColor = true;
            this.button_AfficherLaNote.Click += new System.EventHandler(this.button_AfficherLaNote_Click);
            // 
            // button_ModifierLaNote
            // 
            this.button_ModifierLaNote.Location = new System.Drawing.Point(131, 242);
            this.button_ModifierLaNote.Name = "button_ModifierLaNote";
            this.button_ModifierLaNote.Size = new System.Drawing.Size(139, 23);
            this.button_ModifierLaNote.TabIndex = 8;
            this.button_ModifierLaNote.Text = "Modifier la note";
            this.button_ModifierLaNote.UseVisualStyleBackColor = true;
            this.button_ModifierLaNote.Click += new System.EventHandler(this.button_ModifierLaNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 308);
            this.Controls.Add(this.button_ModifierLaNote);
            this.Controls.Add(this.button_AfficherLaNote);
            this.Controls.Add(this.button_ChargerLesListes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Examens);
            this.Controls.Add(this.comboBox_Stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Stagiaires;
        private System.Windows.Forms.ComboBox comboBox_Examens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ChargerLesListes;
        private System.Windows.Forms.Button button_AfficherLaNote;
        private System.Windows.Forms.Button button_ModifierLaNote;
    }
}

