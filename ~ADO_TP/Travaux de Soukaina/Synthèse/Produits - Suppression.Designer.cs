﻿namespace Synthèse
{
    partial class Produits___Suppression
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
            this.comboBox_NuméroASupprimer = new System.Windows.Forms.ComboBox();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // comboBox_NuméroASupprimer
            // 
            this.comboBox_NuméroASupprimer.FormattingEnabled = true;
            this.comboBox_NuméroASupprimer.Location = new System.Drawing.Point(125, 29);
            this.comboBox_NuméroASupprimer.Name = "comboBox_NuméroASupprimer";
            this.comboBox_NuméroASupprimer.Size = new System.Drawing.Size(114, 21);
            this.comboBox_NuméroASupprimer.TabIndex = 1;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(270, 27);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 2;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // Produits___Suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 81);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.comboBox_NuméroASupprimer);
            this.Controls.Add(this.label1);
            this.Name = "Produits___Suppression";
            this.Text = "Produits - Suppression";
            this.Load += new System.EventHandler(this.Produits___Suppression_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NuméroASupprimer;
        private System.Windows.Forms.Button button_Supprimer;
    }
}