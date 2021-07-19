namespace ADOX_GestionVentesPro.Interfaces.Ventes
{
    partial class Form_GestionClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionClients));
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
            this.textBox_Id_Client = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.groupBox_images = new System.Windows.Forms.GroupBox();
            this.dataGridView_commandes = new System.Windows.Forms.DataGridView();
            this.toolStrip_images = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SélectionnerToutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CountCommandesToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommentateurToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AffectationsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateMiseÀJourToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider_main = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_grille.SuspendLayout();
            this.toolStrip_main.SuspendLayout();
            this.groupBox_formulaire.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).BeginInit();
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
            this.groupBox_grille.Text = "Liste des clients";
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
            // 
            // modifierToolStripButton
            // 
            this.modifierToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.pencil;
            this.modifierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifierToolStripButton.Name = "modifierToolStripButton";
            this.modifierToolStripButton.Size = new System.Drawing.Size(72, 37);
            this.modifierToolStripButton.Text = "Modifier";
            this.modifierToolStripButton.ToolTipText = "Modifier le produit sélectionné";
            // 
            // supprimerToolStripButton
            // 
            this.supprimerToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.delete;
            this.supprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supprimerToolStripButton.Name = "supprimerToolStripButton";
            this.supprimerToolStripButton.Size = new System.Drawing.Size(82, 37);
            this.supprimerToolStripButton.Text = "Supprimer";
            this.supprimerToolStripButton.ToolTipText = "Supprimer le produit sélectionné";
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
            this.produitSélectionnéToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.produitSélectionnéToolStripMenuItem.Text = "Client sélectionné";
            this.produitSélectionnéToolStripMenuItem.ToolTipText = "Générer un rapport pour l\'élément actuellement sélectioné";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = global::ADOX_GestionVentesPro.Properties.Resources.report;
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des clients";
            this.listeDesProduitsToolStripMenuItem.ToolTipText = "Générer un rapport pour tous les éléments";
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
            // 
            // precedentToolStripButton
            // 
            this.precedentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.precedentToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_previous;
            this.precedentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.precedentToolStripButton.Name = "precedentToolStripButton";
            this.precedentToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.precedentToolStripButton.Text = "Précédent";
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
            // 
            // dernierToolStripButton
            // 
            this.dernierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dernierToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.resultset_last;
            this.dernierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dernierToolStripButton.Name = "dernierToolStripButton";
            this.dernierToolStripButton.Size = new System.Drawing.Size(23, 37);
            this.dernierToolStripButton.Text = "Dernier";
            // 
            // groupBox_formulaire
            // 
            this.groupBox_formulaire.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_formulaire.Location = new System.Drawing.Point(13, 45);
            this.groupBox_formulaire.Name = "groupBox_formulaire";
            this.groupBox_formulaire.Size = new System.Drawing.Size(324, 301);
            this.groupBox_formulaire.TabIndex = 4;
            this.groupBox_formulaire.TabStop = false;
            this.groupBox_formulaire.Text = "Données du client";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Id_Client, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Adresse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Nom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Prénom, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.0728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.40996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.55939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.95786F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant du client :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // textBox_Id_Client
            // 
            this.textBox_Id_Client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Id_Client.Location = new System.Drawing.Point(111, 17);
            this.textBox_Id_Client.MaxLength = 50;
            this.textBox_Id_Client.Name = "textBox_Id_Client";
            this.textBox_Id_Client.Size = new System.Drawing.Size(158, 20);
            this.textBox_Id_Client.TabIndex = 6;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Adresse.Location = new System.Drawing.Point(111, 140);
            this.textBox_Adresse.MaxLength = 50;
            this.textBox_Adresse.Multiline = true;
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Adresse.Size = new System.Drawing.Size(158, 107);
            this.textBox_Adresse.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom :";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Nom.Location = new System.Drawing.Point(111, 62);
            this.textBox_Nom.MaxLength = 50;
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(158, 20);
            this.textBox_Nom.TabIndex = 6;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Prénom.Location = new System.Drawing.Point(111, 98);
            this.textBox_Prénom.MaxLength = 50;
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(158, 20);
            this.textBox_Prénom.TabIndex = 6;
            // 
            // groupBox_images
            // 
            this.groupBox_images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_images.Controls.Add(this.dataGridView_commandes);
            this.groupBox_images.Controls.Add(this.toolStrip_images);
            this.groupBox_images.Location = new System.Drawing.Point(343, 45);
            this.groupBox_images.Name = "groupBox_images";
            this.groupBox_images.Size = new System.Drawing.Size(478, 301);
            this.groupBox_images.TabIndex = 5;
            this.groupBox_images.TabStop = false;
            this.groupBox_images.Text = "Commandes du produit";
            // 
            // dataGridView_commandes
            // 
            this.dataGridView_commandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_commandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_commandes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_commandes.Location = new System.Drawing.Point(13, 54);
            this.dataGridView_commandes.Name = "dataGridView_commandes";
            this.dataGridView_commandes.Size = new System.Drawing.Size(451, 233);
            this.dataGridView_commandes.TabIndex = 4;
            // 
            // toolStrip_images
            // 
            this.toolStrip_images.AutoSize = false;
            this.toolStrip_images.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_images.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.SélectionnerToutToolStripButton,
            this.toolStripSeparator5,
            this.CountCommandesToolStripLabel,
            this.toolStripSeparator7,
            this.toolStripLabel3});
            this.toolStrip_images.Location = new System.Drawing.Point(3, 16);
            this.toolStrip_images.Name = "toolStrip_images";
            this.toolStrip_images.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_images.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_images.Size = new System.Drawing.Size(472, 31);
            this.toolStrip_images.TabIndex = 3;
            this.toolStrip_images.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 28);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ADOX_GestionVentesPro.Properties.Resources.cross;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton1.Text = "Supprimer";
            // 
            // SélectionnerToutToolStripButton
            // 
            this.SélectionnerToutToolStripButton.Image = global::ADOX_GestionVentesPro.Properties.Resources.select;
            this.SélectionnerToutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SélectionnerToutToolStripButton.Name = "SélectionnerToutToolStripButton";
            this.SélectionnerToutToolStripButton.Size = new System.Drawing.Size(117, 28);
            this.SélectionnerToutToolStripButton.Text = "Sélectionner tout";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // CountCommandesToolStripLabel
            // 
            this.CountCommandesToolStripLabel.Name = "CountCommandesToolStripLabel";
            this.CountCommandesToolStripLabel.Size = new System.Drawing.Size(57, 28);
            this.CountCommandesToolStripLabel.Text = "{0} sur {1}";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(115, 28);
            this.toolStripLabel3.Text = "Total des achats : {0}";
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // Form_GestionClients
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
            this.Name = "Form_GestionClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_grille.ResumeLayout(false);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.groupBox_formulaire.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_images;
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
        private System.Windows.Forms.ToolStripButton SélectionnerToutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel CountCommandesToolStripLabel;
        private System.Windows.Forms.ErrorProvider errorProvider_main;
        private System.Windows.Forms.ToolStripStatusLabel AffectationsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox_Id_Client;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.DataGridView dataGridView_commandes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}