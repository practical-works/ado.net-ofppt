namespace Vigilence
{
    partial class Form_Quartiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Quartiers));
            this.label1 = new System.Windows.Forms.Label();
            this.num_code = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_population = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_ville = new System.Windows.Forms.ComboBox();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_nouveau = new System.Windows.Forms.ToolStripLabel();
            this.button_ajouter = new System.Windows.Forms.ToolStripButton();
            this.button_supprimer = new System.Windows.Forms.ToolStripButton();
            this.button_enregistrer = new System.Windows.Forms.ToolStripButton();
            this.button_fermer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_premier = new System.Windows.Forms.ToolStripButton();
            this.button_precedent = new System.Windows.Forms.ToolStripButton();
            this.button_suivant = new System.Windows.Forms.ToolStripButton();
            this.button_dernier = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.num_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // num_code
            // 
            this.num_code.Location = new System.Drawing.Point(81, 26);
            this.num_code.Name = "num_code";
            this.num_code.Size = new System.Drawing.Size(67, 20);
            this.num_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(81, 51);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(120, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Population :";
            // 
            // num_population
            // 
            this.num_population.Location = new System.Drawing.Point(81, 78);
            this.num_population.Name = "num_population";
            this.num_population.Size = new System.Drawing.Size(67, 20);
            this.num_population.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville :";
            // 
            // combo_ville
            // 
            this.combo_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ville.FormattingEnabled = true;
            this.combo_ville.Location = new System.Drawing.Point(81, 105);
            this.combo_ville.Name = "combo_ville";
            this.combo_ville.Size = new System.Drawing.Size(121, 21);
            this.combo_ville.TabIndex = 7;
            // 
            // num_total
            // 
            this.num_total.Location = new System.Drawing.Point(81, 130);
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(67, 20);
            this.num_total.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_total);
            this.groupBox1.Controls.Add(this.num_code);
            this.groupBox1.Controls.Add(this.combo_ville);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_population);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information du quartier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personnes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DH";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_nouveau,
            this.button_ajouter,
            this.button_supprimer,
            this.button_enregistrer,
            this.button_fermer,
            this.toolStripSeparator1,
            this.button_premier,
            this.button_precedent,
            this.button_suivant,
            this.button_dernier});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_nouveau
            // 
            this.button_nouveau.ActiveLinkColor = System.Drawing.Color.Blue;
            this.button_nouveau.AutoToolTip = true;
            this.button_nouveau.IsLink = true;
            this.button_nouveau.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.button_nouveau.LinkColor = System.Drawing.Color.Black;
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(55, 22);
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_ajouter.Image = ((System.Drawing.Image)(resources.GetObject("button_ajouter.Image")));
            this.button_ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(50, 22);
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("button_supprimer.Image")));
            this.button_supprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(66, 22);
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("button_enregistrer.Image")));
            this.button_enregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(67, 22);
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_fermer.Image = ((System.Drawing.Image)(resources.GetObject("button_fermer.Image")));
            this.button_fermer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(48, 22);
            this.button_fermer.Text = "Fermer";
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_premier
            // 
            this.button_premier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_premier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_premier.Image = ((System.Drawing.Image)(resources.GetObject("button_premier.Image")));
            this.button_premier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(27, 22);
            this.button_premier.Text = "<<";
            this.button_premier.Click += new System.EventHandler(this.button_premier_Click);
            // 
            // button_precedent
            // 
            this.button_precedent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_precedent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_precedent.Image = ((System.Drawing.Image)(resources.GetObject("button_precedent.Image")));
            this.button_precedent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(23, 22);
            this.button_precedent.Text = "<";
            this.button_precedent.Click += new System.EventHandler(this.button_precedent_Click);
            // 
            // button_suivant
            // 
            this.button_suivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_suivant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_suivant.Image = ((System.Drawing.Image)(resources.GetObject("button_suivant.Image")));
            this.button_suivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(23, 22);
            this.button_suivant.Text = ">";
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // button_dernier
            // 
            this.button_dernier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_dernier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_dernier.Image = ((System.Drawing.Image)(resources.GetObject("button_dernier.Image")));
            this.button_dernier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(27, 22);
            this.button_dernier.Text = ">>";
            this.button_dernier.Click += new System.EventHandler(this.button_dernier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(505, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form_Quartiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 238);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Quartiers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Quartiers";
            this.Load += new System.EventHandler(this.Form_Quartiers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_population;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_ville;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_supprimer;
        private System.Windows.Forms.ToolStripButton button_ajouter;
        private System.Windows.Forms.ToolStripButton button_enregistrer;
        private System.Windows.Forms.ToolStripButton button_fermer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_premier;
        private System.Windows.Forms.ToolStripButton button_precedent;
        private System.Windows.Forms.ToolStripButton button_suivant;
        private System.Windows.Forms.ToolStripButton button_dernier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel button_nouveau;
    }
}