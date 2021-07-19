namespace ADO_EFM_2014_DERDOURI
{
    partial class UserControl_CouleursFond
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_pink = new System.Windows.Forms.RadioButton();
            this.radioButton_defaut = new System.Windows.Forms.RadioButton();
            this.radioButton_lavender = new System.Windows.Forms.RadioButton();
            this.radioButton_cyan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButton_pink
            // 
            this.radioButton_pink.AutoSize = true;
            this.radioButton_pink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_pink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_pink.Location = new System.Drawing.Point(17, 84);
            this.radioButton_pink.Name = "radioButton_pink";
            this.radioButton_pink.Size = new System.Drawing.Size(71, 17);
            this.radioButton_pink.TabIndex = 0;
            this.radioButton_pink.TabStop = true;
            this.radioButton_pink.Text = "Light pink";
            this.radioButton_pink.UseVisualStyleBackColor = true;
            this.radioButton_pink.CheckedChanged += new System.EventHandler(this.radioButton_pink_CheckedChanged);
            // 
            // radioButton_defaut
            // 
            this.radioButton_defaut.AutoSize = true;
            this.radioButton_defaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_defaut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_defaut.Location = new System.Drawing.Point(17, 9);
            this.radioButton_defaut.Name = "radioButton_defaut";
            this.radioButton_defaut.Size = new System.Drawing.Size(74, 17);
            this.radioButton_defaut.TabIndex = 1;
            this.radioButton_defaut.TabStop = true;
            this.radioButton_defaut.Text = "Par défaut";
            this.radioButton_defaut.UseVisualStyleBackColor = true;
            this.radioButton_defaut.CheckedChanged += new System.EventHandler(this.radioButton_defaut_CheckedChanged);
            // 
            // radioButton_lavender
            // 
            this.radioButton_lavender.AutoSize = true;
            this.radioButton_lavender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_lavender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_lavender.Location = new System.Drawing.Point(17, 34);
            this.radioButton_lavender.Name = "radioButton_lavender";
            this.radioButton_lavender.Size = new System.Drawing.Size(70, 17);
            this.radioButton_lavender.TabIndex = 2;
            this.radioButton_lavender.TabStop = true;
            this.radioButton_lavender.Text = "Lavender";
            this.radioButton_lavender.UseVisualStyleBackColor = true;
            this.radioButton_lavender.CheckedChanged += new System.EventHandler(this.radioButton_lavender_CheckedChanged);
            // 
            // radioButton_cyan
            // 
            this.radioButton_cyan.AutoSize = true;
            this.radioButton_cyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_cyan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_cyan.Location = new System.Drawing.Point(17, 59);
            this.radioButton_cyan.Name = "radioButton_cyan";
            this.radioButton_cyan.Size = new System.Drawing.Size(74, 17);
            this.radioButton_cyan.TabIndex = 3;
            this.radioButton_cyan.TabStop = true;
            this.radioButton_cyan.Text = "Light cyan";
            this.radioButton_cyan.UseVisualStyleBackColor = true;
            this.radioButton_cyan.CheckedChanged += new System.EventHandler(this.radioButton_cyan_CheckedChanged);
            // 
            // UserControl_CouleursFond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.radioButton_defaut);
            this.Controls.Add(this.radioButton_cyan);
            this.Controls.Add(this.radioButton_lavender);
            this.Controls.Add(this.radioButton_pink);
            this.Name = "UserControl_CouleursFond";
            this.Size = new System.Drawing.Size(109, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_pink;
        private System.Windows.Forms.RadioButton radioButton_defaut;
        private System.Windows.Forms.RadioButton radioButton_lavender;
        private System.Windows.Forms.RadioButton radioButton_cyan;
    }
}
