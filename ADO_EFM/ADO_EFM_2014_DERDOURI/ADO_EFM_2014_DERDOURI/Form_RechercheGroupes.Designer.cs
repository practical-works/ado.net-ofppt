namespace ADO_EFM_2014_DERDOURI
{
    partial class Form_RechercheGroupes
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
            this.checkedListBox_criteres = new System.Windows.Forms.CheckedListBox();
            this.dataGridView_groupes = new System.Windows.Forms.DataGridView();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Critère :";
            // 
            // checkedListBox_criteres
            // 
            this.checkedListBox_criteres.CheckOnClick = true;
            this.checkedListBox_criteres.FormattingEnabled = true;
            this.checkedListBox_criteres.Items.AddRange(new object[] {
            "Code",
            "Filière",
            "Année",
            "Responsable"});
            this.checkedListBox_criteres.Location = new System.Drawing.Point(82, 41);
            this.checkedListBox_criteres.MultiColumn = true;
            this.checkedListBox_criteres.Name = "checkedListBox_criteres";
            this.checkedListBox_criteres.Size = new System.Drawing.Size(327, 34);
            this.checkedListBox_criteres.TabIndex = 2;
            this.checkedListBox_criteres.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_criteres_ItemCheck);
            // 
            // dataGridView_groupes
            // 
            this.dataGridView_groupes.AllowUserToAddRows = false;
            this.dataGridView_groupes.AllowUserToDeleteRows = false;
            this.dataGridView_groupes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_groupes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_groupes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groupes.Location = new System.Drawing.Point(18, 90);
            this.dataGridView_groupes.Name = "dataGridView_groupes";
            this.dataGridView_groupes.ReadOnly = true;
            this.dataGridView_groupes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_groupes.Size = new System.Drawing.Size(391, 304);
            this.dataGridView_groupes.TabIndex = 13;
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Location = new System.Drawing.Point(82, 11);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(327, 20);
            this.textBox_recherche.TabIndex = 0;
            this.textBox_recherche.TextChanged += new System.EventHandler(this.textBox_recherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mots clés :";
            // 
            // Form_RechercheGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 405);
            this.Controls.Add(this.dataGridView_groupes);
            this.Controls.Add(this.checkedListBox_criteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RechercheGroupes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher un groupe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox_criteres;
        private System.Windows.Forms.DataGridView dataGridView_groupes;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.Label label2;
    }
}