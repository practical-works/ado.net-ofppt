namespace Exercice_4_TP02
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NoteAModifier = new System.Windows.Forms.TextBox();
            this.comboBox_Examens = new System.Windows.Forms.ComboBox();
            this.comboBox_stagiaires = new System.Windows.Forms.ComboBox();
            this.button_ModifierLaNote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = " Note :";
            // 
            // textBox_NoteAModifier
            // 
            this.textBox_NoteAModifier.Location = new System.Drawing.Point(119, 160);
            this.textBox_NoteAModifier.Name = "textBox_NoteAModifier";
            this.textBox_NoteAModifier.Size = new System.Drawing.Size(100, 20);
            this.textBox_NoteAModifier.TabIndex = 6;
            // 
            // comboBox_Examens
            // 
            this.comboBox_Examens.FormattingEnabled = true;
            this.comboBox_Examens.Location = new System.Drawing.Point(119, 89);
            this.comboBox_Examens.Name = "comboBox_Examens";
            this.comboBox_Examens.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Examens.TabIndex = 5;
            this.comboBox_Examens.SelectedIndexChanged += new System.EventHandler(this.comboBox_Examens_SelectedIndexChanged);
            // 
            // comboBox_stagiaires
            // 
            this.comboBox_stagiaires.FormattingEnabled = true;
            this.comboBox_stagiaires.Location = new System.Drawing.Point(119, 46);
            this.comboBox_stagiaires.Name = "comboBox_stagiaires";
            this.comboBox_stagiaires.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stagiaires.TabIndex = 4;
            this.comboBox_stagiaires.Text = " ";
            this.comboBox_stagiaires.SelectedIndexChanged += new System.EventHandler(this.comboBox_stagiaires_SelectedIndexChanged);
            // 
            // button_ModifierLaNote
            // 
            this.button_ModifierLaNote.Location = new System.Drawing.Point(86, 216);
            this.button_ModifierLaNote.Name = "button_ModifierLaNote";
            this.button_ModifierLaNote.Size = new System.Drawing.Size(117, 23);
            this.button_ModifierLaNote.TabIndex = 8;
            this.button_ModifierLaNote.Text = "Modifier la note";
            this.button_ModifierLaNote.UseVisualStyleBackColor = true;
            this.button_ModifierLaNote.Click += new System.EventHandler(this.button_ModifierLaNote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stagiaires :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Examens :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ModifierLaNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NoteAModifier);
            this.Controls.Add(this.comboBox_Examens);
            this.Controls.Add(this.comboBox_stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NoteAModifier;
        private System.Windows.Forms.ComboBox comboBox_Examens;
        private System.Windows.Forms.ComboBox comboBox_stagiaires;
        private System.Windows.Forms.Button button_ModifierLaNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

