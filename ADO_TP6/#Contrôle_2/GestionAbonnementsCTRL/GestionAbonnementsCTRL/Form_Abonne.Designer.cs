namespace GestionAbonnementsCTRL
{
    partial class Form_Abonne
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
            this.dataGridView_abonnes = new System.Windows.Forms.DataGridView();
            this.button_cocherTout = new System.Windows.Forms.Button();
            this.button_supprCoche = new System.Windows.Forms.Button();
            this.textBox_filtre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_abonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_abonnes
            // 
            this.dataGridView_abonnes.AllowUserToAddRows = false;
            this.dataGridView_abonnes.AllowUserToDeleteRows = false;
            this.dataGridView_abonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_abonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_abonnes.Location = new System.Drawing.Point(12, 50);
            this.dataGridView_abonnes.Name = "dataGridView_abonnes";
            this.dataGridView_abonnes.Size = new System.Drawing.Size(546, 279);
            this.dataGridView_abonnes.TabIndex = 0;
            // 
            // button_cocherTout
            // 
            this.button_cocherTout.Location = new System.Drawing.Point(564, 265);
            this.button_cocherTout.Name = "button_cocherTout";
            this.button_cocherTout.Size = new System.Drawing.Size(167, 26);
            this.button_cocherTout.TabIndex = 1;
            this.button_cocherTout.Text = "Cocher Tout";
            this.button_cocherTout.UseVisualStyleBackColor = true;
            this.button_cocherTout.Click += new System.EventHandler(this.button_cocherTout_Click);
            // 
            // button_supprCoche
            // 
            this.button_supprCoche.Location = new System.Drawing.Point(564, 297);
            this.button_supprCoche.Name = "button_supprCoche";
            this.button_supprCoche.Size = new System.Drawing.Size(166, 32);
            this.button_supprCoche.TabIndex = 2;
            this.button_supprCoche.Text = "Supprimer les éléments cochés";
            this.button_supprCoche.UseVisualStyleBackColor = true;
            this.button_supprCoche.Click += new System.EventHandler(this.button_supprCoche_Click);
            // 
            // textBox_filtre
            // 
            this.textBox_filtre.Location = new System.Drawing.Point(111, 24);
            this.textBox_filtre.Name = "textBox_filtre";
            this.textBox_filtre.Size = new System.Drawing.Size(447, 20);
            this.textBox_filtre.TabIndex = 3;
            this.textBox_filtre.TextChanged += new System.EventHandler(this.textBox_filtre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tapez ID ou Nom";
            // 
            // Form_Abonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_filtre);
            this.Controls.Add(this.button_supprCoche);
            this.Controls.Add(this.button_cocherTout);
            this.Controls.Add(this.dataGridView_abonnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Abonne";
            this.Text = "Abonnés";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_abonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_abonnes;
        private System.Windows.Forms.Button button_cocherTout;
        private System.Windows.Forms.Button button_supprCoche;
        private System.Windows.Forms.TextBox textBox_filtre;
        private System.Windows.Forms.Label label1;
    }
}