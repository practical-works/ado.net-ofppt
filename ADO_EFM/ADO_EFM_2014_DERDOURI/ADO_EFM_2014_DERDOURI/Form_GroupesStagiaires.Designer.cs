namespace ADO_EFM_2014_DERDOURI
{
    partial class Form_GroupesStagiaires
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
            this.dataGridView_groupes = new System.Windows.Forms.DataGridView();
            this.dataGridView_stagiaires = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_stagiaires = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_groupes
            // 
            this.dataGridView_groupes.AllowUserToAddRows = false;
            this.dataGridView_groupes.AllowUserToDeleteRows = false;
            this.dataGridView_groupes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_groupes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_groupes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groupes.Location = new System.Drawing.Point(14, 23);
            this.dataGridView_groupes.Name = "dataGridView_groupes";
            this.dataGridView_groupes.ReadOnly = true;
            this.dataGridView_groupes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_groupes.Size = new System.Drawing.Size(634, 106);
            this.dataGridView_groupes.TabIndex = 13;
            this.dataGridView_groupes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_groupes_CellContentClick);
            this.dataGridView_groupes.SelectionChanged += new System.EventHandler(this.dataGridView_groupes_SelectionChanged);
            // 
            // dataGridView_stagiaires
            // 
            this.dataGridView_stagiaires.AllowUserToAddRows = false;
            this.dataGridView_stagiaires.AllowUserToDeleteRows = false;
            this.dataGridView_stagiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stagiaires.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stagiaires.Location = new System.Drawing.Point(14, 167);
            this.dataGridView_stagiaires.Name = "dataGridView_stagiaires";
            this.dataGridView_stagiaires.ReadOnly = true;
            this.dataGridView_stagiaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_stagiaires.Size = new System.Drawing.Size(634, 218);
            this.dataGridView_stagiaires.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Groupes :";
            // 
            // label_stagiaires
            // 
            this.label_stagiaires.AutoSize = true;
            this.label_stagiaires.Location = new System.Drawing.Point(14, 150);
            this.label_stagiaires.Name = "label_stagiaires";
            this.label_stagiaires.Size = new System.Drawing.Size(119, 13);
            this.label_stagiaires.TabIndex = 34;
            this.label_stagiaires.Text = "Stagiaires du groupe 0 :";
            // 
            // Form_GroupesStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 396);
            this.Controls.Add(this.label_stagiaires);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_stagiaires);
            this.Controls.Add(this.dataGridView_groupes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GroupesStagiaires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afficher les stagiaires de chaque groupe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_groupes;
        private System.Windows.Forms.DataGridView dataGridView_stagiaires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_stagiaires;
    }
}