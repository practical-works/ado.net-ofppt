namespace ADO_CrystalReport_DEC
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.numericUpDown_max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_valeurs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.button_nom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 33);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(869, 543);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // numericUpDown_max
            // 
            this.numericUpDown_max.Location = new System.Drawing.Point(186, 7);
            this.numericUpDown_max.Name = "numericUpDown_max";
            this.numericUpDown_max.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_max.TabIndex = 7;
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.Location = new System.Drawing.Point(120, 7);
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_min.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Intervalle de valeurs";
            // 
            // button_valeurs
            // 
            this.button_valeurs.Location = new System.Drawing.Point(252, 4);
            this.button_valeurs.Name = "button_valeurs";
            this.button_valeurs.Size = new System.Drawing.Size(58, 23);
            this.button_valeurs.TabIndex = 5;
            this.button_valeurs.Text = "OK";
            this.button_valeurs.UseVisualStyleBackColor = true;
            this.button_valeurs.Click += new System.EventHandler(this.button_valeurs_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nom.Location = new System.Drawing.Point(693, 6);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 10;
            // 
            // button_nom
            // 
            this.button_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nom.Location = new System.Drawing.Point(799, 4);
            this.button_nom.Name = "button_nom";
            this.button_nom.Size = new System.Drawing.Size(58, 23);
            this.button_nom.TabIndex = 9;
            this.button_nom.Text = "OK";
            this.button_nom.UseVisualStyleBackColor = true;
            this.button_nom.Click += new System.EventHandler(this.button_nom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.button_nom);
            this.Controls.Add(this.numericUpDown_max);
            this.Controls.Add(this.numericUpDown_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_valeurs);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal Report Exemple (Mode Déconnecté)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_max;
        private System.Windows.Forms.NumericUpDown numericUpDown_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_valeurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Button button_nom;


    }
}

