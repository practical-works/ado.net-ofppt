namespace ADOX_GestionVentesPro.Interfaces.Produits
{
    partial class Form_GestionProduits
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionProduits));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_grille = new System.Windows.Forms.GroupBox();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.rechercherToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.actualiserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.nouveauToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ajouterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.modifierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.supprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rapportsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.produitSélectionnéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.premierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.precedentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.positionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.CountToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.suivantToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dernierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox_formulaire = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Ref_Produit = new System.Windows.Forms.TextBox();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.numericUpDown_Quantité = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Seuil_Minimum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Seuil_Maximum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Prix_Unitaire = new System.Windows.Forms.NumericUpDown();
            this.groupBox_images = new System.Windows.Forms.GroupBox();
            this.toolStrip_images = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.importerImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SupprimerImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SélectionnerToutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CountImagesToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.listView_images = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommentateurToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AffectationsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateMiseÀJourToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider_main = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_grille.SuspendLayout();
            this.toolStrip_main.SuspendLayout();
            this.groupBox_formulaire.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantité)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seuil_Minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seuil_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prix_Unitaire)).BeginInit();
            this.groupBox_images.SuspendLayout();
            this.toolStrip_images.SuspendLayout();
            this.statusStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox_grille
            // 
            this.groupBox_grille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_grille.Controls.Add(this.dataGridView1);
            this.groupBox_grille.Location = new System.Drawing.Point(13, 352);
            this.groupBox_grille.Name = "groupBox_grille";
            this.groupBox_grille.Size = new System.Drawing.Size(808, 171);
            this.groupBox_grille.TabIndex = 1;
            this.groupBox_grille.TabStop = false;
            this.groupBox_grille.Text = "Liste des produits";
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.AutoSize = false;
            this.toolStrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.rechercherToolStripTextBox,
            this.toolStripSeparator1,
            this.actualiserToolStripButton,
            this.toolStripSeparator4,
            this.nouveauToolStripButton,
            this.ajouterToolStripButton,
            this.modifierToolStripButton,
            this.supprimerToolStripButton,
            this.toolStripSeparator2,
            this.rapportsToolStripDropDownButton,
            this.toolStripSeparator3,
            this.premierToolStripButton,
            this.precedentToolStripButton,
            this.positionToolStripTextBox,
            this.CountToolStripLabel,
            this.suivantToolStripButton,
            this.dernierToolStripButton});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(835, 40);
            this.toolStrip_main.TabIndex = 3;
            this.toolStrip_main.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 37);
            this.toolStripLabel1.Text = "  Rechercher :";
            // 
            // rechercherToolStripTextBox
            // 
            this.rechercherToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rechercherToolStripTextBox.Name = "rechercherToolStripTextBox";
            this.rechercherToolStripTextBox.Size = new System.Drawing.Size(150, 40);
            this.rechercherToolStripTextBox.ToolTipText = "Rechercher un produit";
            this.rechercherToolStripTextBox.TextChanged += new System.EventHandler(this.rechercherToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // actualiserToolStripButton
            // 
            this.actualiserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualiserToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.update;
            this.actualiserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualiserToolStripButton.Name = "actualiserToolStripButton";
            this.actualiserToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.actualiserToolStripButton.Text = "Actualiser";
            this.actualiserToolStripButton.Click += new System.EventHandler(this.actualiserToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // nouveauToolStripButton
            // 
            this.nouveauToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.page_white;
            this.nouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripButton.Name = "nouveauToolStripButton";
            this.nouveauToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nouveauToolStripButton.Size = new System.Drawing.Size(75, 37);
            this.nouveauToolStripButton.Text = "Nouveau";
            this.nouveauToolStripButton.ToolTipText = "Créer un nouveau produit";
            this.nouveauToolStripButton.Click += new System.EventHandler(this.nouveauToolStripButton_Click);
            // 
            // ajouterToolStripButton
            // 
            this.ajouterToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.add;
            this.ajouterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajouterToolStripButton.Name = "ajouterToolStripButton";
            this.ajouterToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ajouterToolStripButton.Size = new System.Drawing.Size(66, 37);
            this.ajouterToolStripButton.Text = "Ajouter";
            this.ajouterToolStripButton.ToolTipText = "Ajouter un nouveau produit";
            this.ajouterToolStripButton.Click += new System.EventHandler(this.ajouterToolStripButton_Click);
            // 
            // modifierToolStripButton
            // 
            this.modifierToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.pencil;
            this.modifierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifierToolStripButton.Name = "modifierToolStripButton";
            this.modifierToolStripButton.Size = new System.Drawing.Size(72, 37);
            this.modifierToolStripButton.Text = "Modifier";
            this.modifierToolStripButton.ToolTipText = "Modifier le produit sélectionné";
            this.modifierToolStripButton.Click += new System.EventHandler(this.modifierToolStripButton_Click);
            // 
            // supprimerToolStripButton
            // 
            this.supprimerToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.delete;
            this.supprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supprimerToolStripButton.Name = "supprimerToolStripButton";
            this.supprimerToolStripButton.Size = new System.Drawing.Size(82, 37);
            this.supprimerToolStripButton.Text = "Supprimer";
            this.supprimerToolStripButton.ToolTipText = "Supprimer le produit sélectionné";
            this.supprimerToolStripButton.Click += new System.EventHandler(this.supprimerToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // rapportsToolStripDropDownButton
            // 
            this.rapportsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitSélectionnéToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem});
            this.rapportsToolStripDropDownButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.reports;
            this.rapportsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rapportsToolStripDropDownButton.Name = "rapportsToolStripDropDownButton";
            this.rapportsToolStripDropDownButton.Size = new System.Drawing.Size(83, 37);
            this.rapportsToolStripDropDownButton.Text = "Rapports";
            this.rapportsToolStripDropDownButton.ToolTipText = "Générer des rapports pour les produits";
            // 
            // produitSélectionnéToolStripMenuItem
            // 
            this.produitSélectionnéToolStripMenuItem.Image = global::ADOX_GestionVentesPro.Properties.Resources.report;
            this.produitSélectionnéToolStripMenuItem.Name = "produitSélectionnéToolStripMenuItem";
            this.produitSélectionnéToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.produitSélectionnéToolStripMenuItem.Text = "Produit sélectionné";
            this.produitSélectionnéToolStripMenuItem.ToolTipText = "Générer un rapport pour l\'élément actuellement sélectioné";
            this.produitSélectionnéToolStripMenuItem.Click += new System.EventHandler(this.produitSélectionnéToolStripMenuItem_Click);
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = global::ADOX_GestionVentesPro.Properties.Resources.report;
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des produits";
            this.listeDesProduitsToolStripMenuItem.ToolTipText = "Générer un rapport pour tous les éléments";
            this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProduitsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // premierToolStripButton
            // 
            this.premierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.premierToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_first;
            this.premierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.premierToolStripButton.Name = "premierToolStripButton";
            this.premierToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.premierToolStripButton.Text = "Premier";
            this.premierToolStripButton.Click += new System.EventHandler(this.premierToolStripButton_Click);
            // 
            // precedentToolStripButton
            // 
            this.precedentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.precedentToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_previous;
            this.precedentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.precedentToolStripButton.Name = "precedentToolStripButton";
            this.precedentToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.precedentToolStripButton.Text = "Précédent";
            this.precedentToolStripButton.Click += new System.EventHandler(this.precedentToolStripButton_Click);
            // 
            // positionToolStripTextBox
            // 
            this.positionToolStripTextBox.Name = "positionToolStripTextBox";
            this.positionToolStripTextBox.Size = new System.Drawing.Size(30, 40);
            this.positionToolStripTextBox.Text = "0";
            // 
            // CountToolStripLabel
            // 
            this.CountToolStripLabel.Name = "CountToolStripLabel";
            this.CountToolStripLabel.Size = new System.Drawing.Size(40, 37);
            this.CountToolStripLabel.Text = "sur {0}";
            // 
            // suivantToolStripButton
            // 
            this.suivantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suivantToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_next;
            this.suivantToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.suivantToolStripButton.Name = "suivantToolStripButton";
            this.suivantToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.suivantToolStripButton.Text = "Suivant";
            this.suivantToolStripButton.Click += new System.EventHandler(this.suivantToolStripButton_Click);
            // 
            // dernierToolStripButton
            // 
            this.dernierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dernierToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_last;
            this.dernierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dernierToolStripButton.Name = "dernierToolStripButton";
            this.dernierToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.dernierToolStripButton.Text = "Dernier";
            this.dernierToolStripButton.Click += new System.EventHandler(this.dernierToolStripButton_Click);
            // 
            // groupBox_formulaire
            // 
            this.groupBox_formulaire.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_formulaire.Location = new System.Drawing.Point(13, 45);
            this.groupBox_formulaire.Name = "groupBox_formulaire";
            this.groupBox_formulaire.Size = new System.Drawing.Size(351, 301);
            this.groupBox_formulaire.TabIndex = 4;
            this.groupBox_formulaire.TabStop = false;
            this.groupBox_formulaire.Text = "Données du produit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.7299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.2701F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Ref_Produit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Quantité, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Seuil_Minimum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Seuil_Maximum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Prix_Unitaire, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.50191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.68966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.195402F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.26054F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence du produit :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité en stock :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seuil Minimum en stock :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seuil Maximum en stock :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix unitaire (DH) :";
            // 
            // textBox_Ref_Produit
            // 
            this.textBox_Ref_Produit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Ref_Produit.Location = new System.Drawing.Point(145, 5);
            this.textBox_Ref_Produit.MaxLength = 50;
            this.textBox_Ref_Produit.Name = "textBox_Ref_Produit";
            this.textBox_Ref_Produit.Size = new System.Drawing.Size(158, 20);
            this.textBox_Ref_Produit.TabIndex = 6;
            this.textBox_Ref_Produit.TextChanged += new System.EventHandler(this.textBox_Ref_Produit_TextChanged);
            // 
            // textBox_Label
            // 
            this.textBox_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Label.Location = new System.Drawing.Point(145, 36);
            this.textBox_Label.MaxLength = 50;
            this.textBox_Label.Multiline = true;
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Label.Size = new System.Drawing.Size(158, 65);
            this.textBox_Label.TabIndex = 7;
            // 
            // numericUpDown_Quantité
            // 
            this.numericUpDown_Quantité.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Quantité.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Quantité.Location = new System.Drawing.Point(145, 122);
            this.numericUpDown_Quantité.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Quantité.Name = "numericUpDown_Quantité";
            this.numericUpDown_Quantité.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown_Quantité.TabIndex = 8;
            // 
            // numericUpDown_Seuil_Minimum
            // 
            this.numericUpDown_Seuil_Minimum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Seuil_Minimum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Seuil_Minimum.Location = new System.Drawing.Point(145, 161);
            this.numericUpDown_Seuil_Minimum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Seuil_Minimum.Name = "numericUpDown_Seuil_Minimum";
            this.numericUpDown_Seuil_Minimum.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown_Seuil_Minimum.TabIndex = 9;
            // 
            // numericUpDown_Seuil_Maximum
            // 
            this.numericUpDown_Seuil_Maximum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Seuil_Maximum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Seuil_Maximum.Location = new System.Drawing.Point(145, 186);
            this.numericUpDown_Seuil_Maximum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Seuil_Maximum.Name = "numericUpDown_Seuil_Maximum";
            this.numericUpDown_Seuil_Maximum.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown_Seuil_Maximum.TabIndex = 10;
            // 
            // numericUpDown_Prix_Unitaire
            // 
            this.numericUpDown_Prix_Unitaire.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_Prix_Unitaire.DecimalPlaces = 2;
            this.numericUpDown_Prix_Unitaire.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Prix_Unitaire.Location = new System.Drawing.Point(145, 226);
            this.numericUpDown_Prix_Unitaire.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Prix_Unitaire.Name = "numericUpDown_Prix_Unitaire";
            this.numericUpDown_Prix_Unitaire.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown_Prix_Unitaire.TabIndex = 10;
            this.numericUpDown_Prix_Unitaire.ThousandsSeparator = true;
            // 
            // groupBox_images
            // 
            this.groupBox_images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_images.Controls.Add(this.toolStrip_images);
            this.groupBox_images.Controls.Add(this.listView_images);
            this.groupBox_images.Location = new System.Drawing.Point(370, 45);
            this.groupBox_images.Name = "groupBox_images";
            this.groupBox_images.Size = new System.Drawing.Size(451, 301);
            this.groupBox_images.TabIndex = 5;
            this.groupBox_images.TabStop = false;
            this.groupBox_images.Text = "Images du produit";
            // 
            // toolStrip_images
            // 
            this.toolStrip_images.AutoSize = false;
            this.toolStrip_images.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_images.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.importerImageToolStripButton,
            this.SupprimerImageToolStripButton,
            this.toolStripSeparator5,
            this.SélectionnerToutToolStripButton,
            this.toolStripSeparator6,
            this.CountImagesToolStripLabel});
            this.toolStrip_images.Location = new System.Drawing.Point(3, 16);
            this.toolStrip_images.Name = "toolStrip_images";
            this.toolStrip_images.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_images.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_images.Size = new System.Drawing.Size(445, 31);
            this.toolStrip_images.TabIndex = 3;
            this.toolStrip_images.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 28);
            this.toolStripLabel2.Text = "  ";
            // 
            // importerImageToolStripButton
            // 
            this.importerImageToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.image_add;
            this.importerImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importerImageToolStripButton.Name = "importerImageToolStripButton";
            this.importerImageToolStripButton.Size = new System.Drawing.Size(73, 28);
            this.importerImageToolStripButton.Text = "Importer";
            this.importerImageToolStripButton.Click += new System.EventHandler(this.importerImageToolStripButton_Click);
            // 
            // SupprimerImageToolStripButton
            // 
            this.SupprimerImageToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.image_delete;
            this.SupprimerImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SupprimerImageToolStripButton.Name = "SupprimerImageToolStripButton";
            this.SupprimerImageToolStripButton.Size = new System.Drawing.Size(82, 28);
            this.SupprimerImageToolStripButton.Text = "Supprimer";
            this.SupprimerImageToolStripButton.Click += new System.EventHandler(this.SupprimerImageToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // SélectionnerToutToolStripButton
            // 
            this.SélectionnerToutToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.select;
            this.SélectionnerToutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SélectionnerToutToolStripButton.Name = "SélectionnerToutToolStripButton";
            this.SélectionnerToutToolStripButton.Size = new System.Drawing.Size(117, 28);
            this.SélectionnerToutToolStripButton.Text = "Sélectionner tout";
            this.SélectionnerToutToolStripButton.Click += new System.EventHandler(this.SélectionnerToutToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // CountImagesToolStripLabel
            // 
            this.CountImagesToolStripLabel.Name = "CountImagesToolStripLabel";
            this.CountImagesToolStripLabel.Size = new System.Drawing.Size(57, 28);
            this.CountImagesToolStripLabel.Text = "{0} sur {1}";
            // 
            // listView_images
            // 
            this.listView_images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_images.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_images.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_images.Location = new System.Drawing.Point(11, 50);
            this.listView_images.Name = "listView_images";
            this.listView_images.Size = new System.Drawing.Size(429, 233);
            this.listView_images.TabIndex = 1;
            this.listView_images.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Image";
            this.columnHeader1.Width = 200;
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.AutoSize = false;
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.CommentateurToolStripStatusLabel,
            this.AffectationsToolStripStatusLabel,
            this.dateMiseÀJourToolStripStatusLabel});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 526);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip_main.Size = new System.Drawing.Size(835, 40);
            this.statusStrip_main.TabIndex = 6;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::ADOX_GestionVentesPro.Properties.Resources.action;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 35);
            this.toolStripStatusLabel1.Text = "Activité :";
            // 
            // CommentateurToolStripStatusLabel
            // 
            this.CommentateurToolStripStatusLabel.BackColor = System.Drawing.Color.White;
            this.CommentateurToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.CommentateurToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CommentateurToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CommentateurToolStripStatusLabel.Image = global::ADOX_GestionVentesPro.Properties.Resources.help;
            this.CommentateurToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommentateurToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CommentateurToolStripStatusLabel.Name = "CommentateurToolStripStatusLabel";
            this.CommentateurToolStripStatusLabel.Size = new System.Drawing.Size(467, 40);
            this.CommentateurToolStripStatusLabel.Spring = true;
            this.CommentateurToolStripStatusLabel.Text = "Aucune";
            this.CommentateurToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommentateurToolStripStatusLabel.ToolTipText = "Message qui décrit la dernière action effectuée";
            // 
            // AffectationsToolStripStatusLabel
            // 
            this.AffectationsToolStripStatusLabel.Image = global::ADOX_GestionVentesPro.Properties.Resources.database_refresh;
            this.AffectationsToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.AffectationsToolStripStatusLabel.Name = "AffectationsToolStripStatusLabel";
            this.AffectationsToolStripStatusLabel.Size = new System.Drawing.Size(110, 35);
            this.AffectationsToolStripStatusLabel.Text = "Affectations : {0}";
            this.AffectationsToolStripStatusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // dateMiseÀJourToolStripStatusLabel
            // 
            this.dateMiseÀJourToolStripStatusLabel.AutoToolTip = true;
            this.dateMiseÀJourToolStripStatusLabel.Image = global::ADOX_GestionVentesPro.Properties.Resources.date;
            this.dateMiseÀJourToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.dateMiseÀJourToolStripStatusLabel.Name = "dateMiseÀJourToolStripStatusLabel";
            this.dateMiseÀJourToolStripStatusLabel.Size = new System.Drawing.Size(139, 35);
            this.dateMiseÀJourToolStripStatusLabel.Text = "Mis à jour : Le {0} à {1}";
            // 
            // errorProvider_main
            // 
            this.errorProvider_main.BlinkRate = 300;
            this.errorProvider_main.ContainerControl = this;
            this.errorProvider_main.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_main.Icon")));
            // 
            // Form_GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 566);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.groupBox_images);
            this.Controls.Add(this.groupBox_formulaire);
            this.Controls.Add(this.toolStrip_main);
            this.Controls.Add(this.groupBox_grille);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GestionProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des produits";
            this.Load += new System.EventHandler(this.Form_GestionProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_grille.ResumeLayout(false);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.groupBox_formulaire.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantité)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seuil_Minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seuil_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prix_Unitaire)).EndInit();
            this.groupBox_images.ResumeLayout(false);
            this.toolStrip_images.ResumeLayout(false);
            this.toolStrip_images.PerformLayout();
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_grille;
        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripButton ajouterToolStripButton;
        private System.Windows.Forms.ToolStripButton modifierToolStripButton;
        private System.Windows.Forms.ToolStripButton supprimerToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton rapportsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem produitSélectionnéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton actualiserToolStripButton;
        private System.Windows.Forms.GroupBox groupBox_formulaire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Ref_Produit;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantité;
        private System.Windows.Forms.NumericUpDown numericUpDown_Seuil_Minimum;
        private System.Windows.Forms.NumericUpDown numericUpDown_Seuil_Maximum;
        private System.Windows.Forms.NumericUpDown numericUpDown_Prix_Unitaire;
        private System.Windows.Forms.GroupBox groupBox_images;
        private System.Windows.Forms.ListView listView_images;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripButton nouveauToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel dateMiseÀJourToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton premierToolStripButton;
        private System.Windows.Forms.ToolStripButton precedentToolStripButton;
        private System.Windows.Forms.ToolStripTextBox positionToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel CountToolStripLabel;
        private System.Windows.Forms.ToolStripButton suivantToolStripButton;
        private System.Windows.Forms.ToolStripButton dernierToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel CommentateurToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox rechercherToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip_images;
        private System.Windows.Forms.ToolStripButton importerImageToolStripButton;
        private System.Windows.Forms.ToolStripButton SupprimerImageToolStripButton;
        private System.Windows.Forms.ToolStripButton SélectionnerToutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel CountImagesToolStripLabel;
        private System.Windows.Forms.ErrorProvider errorProvider_main;
        private System.Windows.Forms.ToolStripStatusLabel AffectationsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}