namespace ADOX_GestionVentesPro.Interfaces.Utilisateurs
{
    partial class Form_GestionUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionUtilisateurs));
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
            this.textBox_Id_Utilisateur = new System.Windows.Forms.TextBox();
            this.textBox_Mot_Passe = new System.Windows.Forms.TextBox();
            this.comboBox_Rôle = new System.Windows.Forms.ComboBox();
            this.label_Date_Dernière_Connexion = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(425, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox_grille
            // 
            this.groupBox_grille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_grille.Controls.Add(this.dataGridView1);
            this.groupBox_grille.Location = new System.Drawing.Point(370, 45);
            this.groupBox_grille.Name = "groupBox_grille";
            this.groupBox_grille.Size = new System.Drawing.Size(453, 301);
            this.groupBox_grille.TabIndex = 1;
            this.groupBox_grille.TabStop = false;
            this.groupBox_grille.Text = "Liste des utilisateurs";
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
            this.produitSélectionnéToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.produitSélectionnéToolStripMenuItem.Text = "Produit sélectionné";
            this.produitSélectionnéToolStripMenuItem.ToolTipText = "Générer un rapport pour l\'élément actuellement sélectioné";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = global::ADOX_GestionVentesPro.Properties.Resources.report;
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des produits";
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
            this.groupBox_formulaire.Size = new System.Drawing.Size(351, 301);
            this.groupBox_formulaire.TabIndex = 4;
            this.groupBox_formulaire.TabStop = false;
            this.groupBox_formulaire.Text = "Données de l\'utilisateur";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.07692F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Id_Utilisateur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Mot_Passe, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Rôle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Date_Dernière_Connexion, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63218F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant de l\'utilisateur :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rôle :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de la dernière connexion :";
            // 
            // textBox_Id_Utilisateur
            // 
            this.textBox_Id_Utilisateur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Id_Utilisateur.Location = new System.Drawing.Point(175, 6);
            this.textBox_Id_Utilisateur.MaxLength = 50;
            this.textBox_Id_Utilisateur.Name = "textBox_Id_Utilisateur";
            this.textBox_Id_Utilisateur.Size = new System.Drawing.Size(147, 20);
            this.textBox_Id_Utilisateur.TabIndex = 6;
            // 
            // textBox_Mot_Passe
            // 
            this.textBox_Mot_Passe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Mot_Passe.Location = new System.Drawing.Point(175, 44);
            this.textBox_Mot_Passe.MaxLength = 50;
            this.textBox_Mot_Passe.Name = "textBox_Mot_Passe";
            this.textBox_Mot_Passe.Size = new System.Drawing.Size(147, 20);
            this.textBox_Mot_Passe.TabIndex = 6;
            // 
            // comboBox_Rôle
            // 
            this.comboBox_Rôle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Rôle.FormattingEnabled = true;
            this.comboBox_Rôle.Location = new System.Drawing.Point(175, 113);
            this.comboBox_Rôle.Name = "comboBox_Rôle";
            this.comboBox_Rôle.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Rôle.TabIndex = 7;
            // 
            // label_Date_Dernière_Connexion
            // 
            this.label_Date_Dernière_Connexion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Date_Dernière_Connexion.AutoSize = true;
            this.label_Date_Dernière_Connexion.Location = new System.Drawing.Point(175, 209);
            this.label_Date_Dernière_Connexion.Name = "label_Date_Dernière_Connexion";
            this.label_Date_Dernière_Connexion.Size = new System.Drawing.Size(21, 13);
            this.label_Date_Dernière_Connexion.TabIndex = 8;
            this.label_Date_Dernière_Connexion.Text = "{0}";
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.AutoSize = false;
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.CommentateurToolStripStatusLabel,
            this.AffectationsToolStripStatusLabel,
            this.dateMiseÀJourToolStripStatusLabel});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 357);
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
            // Form_GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 397);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.groupBox_formulaire);
            this.Controls.Add(this.toolStrip_main);
            this.Controls.Add(this.groupBox_grille);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GestionUtilisateurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_grille.ResumeLayout(false);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.groupBox_formulaire.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_Id_Utilisateur;
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
        private System.Windows.Forms.ErrorProvider errorProvider_main;
        private System.Windows.Forms.ToolStripStatusLabel AffectationsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox_Mot_Passe;
        private System.Windows.Forms.ComboBox comboBox_Rôle;
        private System.Windows.Forms.Label label_Date_Dernière_Connexion;
    }
}