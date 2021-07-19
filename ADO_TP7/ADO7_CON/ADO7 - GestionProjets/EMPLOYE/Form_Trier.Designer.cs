namespace ADO7___GestionProjets.EMPLOYE
{
    partial class Form_Trier
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Par Numéro (Par défaut)",
            "Par Nom",
            "Par Prénom",
            "Par Sexe",
            "Par Date de Naissance",
            "Par Fonction"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Image = global::ADO7___GestionProjets.Properties.Resources.accept_button;
            this.button_OK.Location = new System.Drawing.Point(92, 53);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "Trier";
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Image = global::ADO7___GestionProjets.Properties.Resources.cancel;
            this.button_Annuler.Location = new System.Drawing.Point(173, 53);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.button_Annuler.TabIndex = 3;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // Form_Trier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 88);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Trier";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trier les employés";
            this.Load += new System.EventHandler(this.Form_Trier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Annuler;
    }
}