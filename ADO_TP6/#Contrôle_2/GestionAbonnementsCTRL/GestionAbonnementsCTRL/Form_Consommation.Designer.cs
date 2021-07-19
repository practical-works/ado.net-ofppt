namespace GestionAbonnementsCTRL
{
    partial class Form_Consommation
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
            this.dataGridView_consommations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consommations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_consommations
            // 
            this.dataGridView_consommations.AllowUserToAddRows = false;
            this.dataGridView_consommations.AllowUserToDeleteRows = false;
            this.dataGridView_consommations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_consommations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_consommations.Location = new System.Drawing.Point(14, 12);
            this.dataGridView_consommations.Name = "dataGridView_consommations";
            this.dataGridView_consommations.ReadOnly = true;
            this.dataGridView_consommations.Size = new System.Drawing.Size(556, 286);
            this.dataGridView_consommations.TabIndex = 0;
            // 
            // Form_Consommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 310);
            this.Controls.Add(this.dataGridView_consommations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Consommation";
            this.Text = "Form_Consommation";
            this.Load += new System.EventHandler(this.Form_Consommation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consommations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_consommations;
    }
}