namespace Synthèse
{
    partial class Authentification
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_motDePasse = new System.Windows.Forms.TextBox();
            this.button_Connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(192, 33);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(168, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_motDePasse
            // 
            this.textBox_motDePasse.Location = new System.Drawing.Point(192, 79);
            this.textBox_motDePasse.Name = "textBox_motDePasse";
            this.textBox_motDePasse.Size = new System.Drawing.Size(168, 20);
            this.textBox_motDePasse.TabIndex = 3;
            // 
            // button_Connexion
            // 
            this.button_Connexion.Location = new System.Drawing.Point(153, 134);
            this.button_Connexion.Name = "button_Connexion";
            this.button_Connexion.Size = new System.Drawing.Size(75, 23);
            this.button_Connexion.TabIndex = 4;
            this.button_Connexion.Text = "Connexion";
            this.button_Connexion.UseVisualStyleBackColor = true;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 169);
            this.Controls.Add(this.button_Connexion);
            this.Controls.Add(this.textBox_motDePasse);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_motDePasse;
        private System.Windows.Forms.Button button_Connexion;
    }
}