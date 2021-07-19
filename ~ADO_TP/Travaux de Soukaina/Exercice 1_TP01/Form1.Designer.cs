namespace Exercice_1_TP01
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
            this.listBox_Stagiaires = new System.Windows.Forms.ListBox();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.button_Effacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Stagiaires
            // 
            this.listBox_Stagiaires.FormattingEnabled = true;
            this.listBox_Stagiaires.Location = new System.Drawing.Point(32, 12);
            this.listBox_Stagiaires.Name = "listBox_Stagiaires";
            this.listBox_Stagiaires.Size = new System.Drawing.Size(554, 186);
            this.listBox_Stagiaires.TabIndex = 0;
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(197, 211);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 1;
            this.button_Afficher.Text = "Afficher";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // button_Effacer
            // 
            this.button_Effacer.Location = new System.Drawing.Point(322, 211);
            this.button_Effacer.Name = "button_Effacer";
            this.button_Effacer.Size = new System.Drawing.Size(75, 23);
            this.button_Effacer.TabIndex = 2;
            this.button_Effacer.Text = "Effacer";
            this.button_Effacer.UseVisualStyleBackColor = true;
            this.button_Effacer.Click += new System.EventHandler(this.button_Effacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 262);
            this.Controls.Add(this.button_Effacer);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.listBox_Stagiaires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Stagiaires;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.Button button_Effacer;
    }
}

