namespace Synthèse
{
    partial class Produits___Liste
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
            this.dataGridView_Produits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Produits
            // 
            this.dataGridView_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produits.Location = new System.Drawing.Point(12, 24);
            this.dataGridView_Produits.Name = "dataGridView_Produits";
            this.dataGridView_Produits.Size = new System.Drawing.Size(509, 254);
            this.dataGridView_Produits.TabIndex = 0;
            // 
            // Produits___Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.dataGridView_Produits);
            this.Name = "Produits___Liste";
            this.Text = "Produits - Liste";
            this.Load += new System.EventHandler(this.Produits___Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Produits;
    }
}