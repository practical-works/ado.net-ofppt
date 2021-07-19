namespace ADO6
{
    partial class FORM_MAIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OUV = new System.Windows.Forms.Button();
            this.button_EMP = new System.Windows.Forms.Button();
            this.button_RET = new System.Windows.Forms.Button();
            this.button_ADH = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adherentsToolStripMenuItem,
            this.ouvragesToolStripMenuItem,
            this.empruntsToolStripMenuItem,
            this.retoursToolStripMenuItem});
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionToolStripMenuItem.Image = global::ADO6.Properties.Resources.book_keeping;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.gestionToolStripMenuItem.Text = "Gestion de la bibliothèque";
            // 
            // adherentsToolStripMenuItem
            // 
            this.adherentsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adherentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adherentsToolStripMenuItem.Image = global::ADO6.Properties.Resources.user1;
            this.adherentsToolStripMenuItem.Name = "adherentsToolStripMenuItem";
            this.adherentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.adherentsToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.adherentsToolStripMenuItem.Text = "Gestion des Adherents";
            this.adherentsToolStripMenuItem.Click += new System.EventHandler(this.adherentsToolStripMenuItem_Click);
            // 
            // ouvragesToolStripMenuItem
            // 
            this.ouvragesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ouvragesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ouvragesToolStripMenuItem.Image = global::ADO6.Properties.Resources.book_picture1;
            this.ouvragesToolStripMenuItem.Name = "ouvragesToolStripMenuItem";
            this.ouvragesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ouvragesToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.ouvragesToolStripMenuItem.Text = "Gestion des Ouvrages";
            this.ouvragesToolStripMenuItem.Click += new System.EventHandler(this.ouvragesToolStripMenuItem_Click);
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empruntsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.empruntsToolStripMenuItem.Image = global::ADO6.Properties.Resources.hand1;
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.empruntsToolStripMenuItem.Text = "Gestion des Emprunts des ouvrages";
            this.empruntsToolStripMenuItem.Click += new System.EventHandler(this.empruntsToolStripMenuItem_Click);
            // 
            // retoursToolStripMenuItem
            // 
            this.retoursToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.retoursToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.retoursToolStripMenuItem.Image = global::ADO6.Properties.Resources.hand_property1;
            this.retoursToolStripMenuItem.Name = "retoursToolStripMenuItem";
            this.retoursToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.retoursToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.retoursToolStripMenuItem.Text = "Gestion des Retours des ouvrages";
            this.retoursToolStripMenuItem.Click += new System.EventHandler(this.retoursToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_OUV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_EMP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_RET, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ADH, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 559);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 58);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button_OUV
            // 
            this.button_OUV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OUV.BackColor = System.Drawing.Color.Gray;
            this.button_OUV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OUV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_OUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OUV.Image = global::ADO6.Properties.Resources.book_picture;
            this.button_OUV.Location = new System.Drawing.Point(349, 5);
            this.button_OUV.Name = "button_OUV";
            this.button_OUV.Size = new System.Drawing.Size(111, 48);
            this.button_OUV.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_OUV, "Gestion des Ouvrages");
            this.button_OUV.UseVisualStyleBackColor = false;
            this.button_OUV.Click += new System.EventHandler(this.button_OUV_Click);
            // 
            // button_EMP
            // 
            this.button_EMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_EMP.BackColor = System.Drawing.Color.Gray;
            this.button_EMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EMP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_EMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EMP.Image = global::ADO6.Properties.Resources.hand;
            this.button_EMP.Location = new System.Drawing.Point(619, 5);
            this.button_EMP.Name = "button_EMP";
            this.button_EMP.Size = new System.Drawing.Size(111, 48);
            this.button_EMP.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_EMP, "Gestion des Emprunts");
            this.button_EMP.UseVisualStyleBackColor = false;
            this.button_EMP.Click += new System.EventHandler(this.button_EMP_Click);
            // 
            // button_RET
            // 
            this.button_RET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_RET.BackColor = System.Drawing.Color.Gray;
            this.button_RET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RET.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RET.Image = global::ADO6.Properties.Resources.hand_property;
            this.button_RET.Location = new System.Drawing.Point(891, 5);
            this.button_RET.Name = "button_RET";
            this.button_RET.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_RET.Size = new System.Drawing.Size(111, 48);
            this.button_RET.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_RET, "Gestion des Retours");
            this.button_RET.UseVisualStyleBackColor = false;
            this.button_RET.Click += new System.EventHandler(this.button_RET_Click);
            // 
            // button_ADH
            // 
            this.button_ADH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ADH.BackColor = System.Drawing.Color.Gray;
            this.button_ADH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ADH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADH.Image = global::ADO6.Properties.Resources.user;
            this.button_ADH.Location = new System.Drawing.Point(79, 5);
            this.button_ADH.Name = "button_ADH";
            this.button_ADH.Size = new System.Drawing.Size(111, 48);
            this.button_ADH.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_ADH, "Gestion des Adhérents");
            this.button_ADH.UseVisualStyleBackColor = false;
            this.button_ADH.Click += new System.EventHandler(this.button_ADH_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADO6.Properties.Resources._1348675224_Library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de Bibliothèque";
            this.Load += new System.EventHandler(this.FORM_MAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retoursToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_OUV;
        private System.Windows.Forms.Button button_EMP;
        private System.Windows.Forms.Button button_RET;
        private System.Windows.Forms.Button button_ADH;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

