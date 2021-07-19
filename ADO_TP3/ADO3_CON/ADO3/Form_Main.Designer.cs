namespace ADO3
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_client = new System.Windows.Forms.TabPage();
            this.button_refresh_clients = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_nouveau_client = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button_afficher_client = new System.Windows.Forms.Button();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.button_precedent_client = new System.Windows.Forms.Button();
            this.button_premier_client = new System.Windows.Forms.Button();
            this.button_suivant_client = new System.Windows.Forms.Button();
            this.button_dernier_client = new System.Windows.Forms.Button();
            this.button_supprimer_client = new System.Windows.Forms.Button();
            this.button_modifier_client = new System.Windows.Forms.Button();
            this.button_ajouter_client = new System.Windows.Forms.Button();
            this.button_rechercher_client = new System.Windows.Forms.Button();
            this.text_telephone_client = new System.Windows.Forms.MaskedTextBox();
            this.text_adresse_client = new System.Windows.Forms.TextBox();
            this.text_afficher_nom_client = new System.Windows.Forms.TextBox();
            this.text_nom_client = new System.Windows.Forms.TextBox();
            this.num_id_client = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_reservation = new System.Windows.Forms.TabPage();
            this.button_refresh_reservations = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateFin_reservation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateDebut_reservation = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_pension_reservation = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_date_reservation = new System.Windows.Forms.DateTimePicker();
            this.comboBox_clients = new System.Windows.Forms.ComboBox();
            this.num_code_reservation = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_nouveau_reservation = new System.Windows.Forms.Button();
            this.button_precedent_reservation = new System.Windows.Forms.Button();
            this.button_premier_reservation = new System.Windows.Forms.Button();
            this.button_suivant_reservation = new System.Windows.Forms.Button();
            this.button_dernier_reservation = new System.Windows.Forms.Button();
            this.button_annuler_reservation = new System.Windows.Forms.Button();
            this.button_modifier_reservation = new System.Windows.Forms.Button();
            this.button_ajouter_reservation = new System.Windows.Forms.Button();
            this.button_client_apercu = new System.Windows.Forms.Button();
            this.button_afficher_reservations = new System.Windows.Forms.Button();
            this.button_rechercher_reservation = new System.Windows.Forms.Button();
            this.tabControl_reservations = new System.Windows.Forms.TabControl();
            this.tabPage_reservations = new System.Windows.Forms.TabPage();
            this.dataGridView_reservations = new System.Windows.Forms.DataGridView();
            this.tabPage_reservations_annulees = new System.Windows.Forms.TabPage();
            this.dataGridView_reservations_annulees = new System.Windows.Forms.DataGridView();
            this.tabPage_sejour = new System.Windows.Forms.TabPage();
            this.button_refresh_sejours = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label_nombre_reservations = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_date_sejour = new System.Windows.Forms.DateTimePicker();
            this.comboBox_type_sejour = new System.Windows.Forms.ComboBox();
            this.comboBox_type_reservation = new System.Windows.Forms.ComboBox();
            this.comboBox_reservations = new System.Windows.Forms.ComboBox();
            this.dataGridView_sejours = new System.Windows.Forms.DataGridView();
            this.num_duree_sejour = new System.Windows.Forms.NumericUpDown();
            this.num_sejour = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_precedent_sejour = new System.Windows.Forms.Button();
            this.button_premier_sejour = new System.Windows.Forms.Button();
            this.button_suivant_sejour = new System.Windows.Forms.Button();
            this.button_dernier_sejour = new System.Windows.Forms.Button();
            this.button_nouveau_sejour = new System.Windows.Forms.Button();
            this.button_supprimer_sejour = new System.Windows.Forms.Button();
            this.button_modifier_sejour = new System.Windows.Forms.Button();
            this.button_ajouter_sejour = new System.Windows.Forms.Button();
            this.button_reservation_apercu = new System.Windows.Forms.Button();
            this.button_afficher_reservations_type = new System.Windows.Forms.Button();
            this.button_rechercher_sejour = new System.Windows.Forms.Button();
            this.tabControl_main.SuspendLayout();
            this.tabPage_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_id_client)).BeginInit();
            this.tabPage_reservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_code_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl_reservations.SuspendLayout();
            this.tabPage_reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservations)).BeginInit();
            this.tabPage_reservations_annulees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservations_annulees)).BeginInit();
            this.tabPage_sejour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sejours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_duree_sejour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sejour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_client);
            this.tabControl_main.Controls.Add(this.tabPage_reservation);
            this.tabControl_main.Controls.Add(this.tabPage_sejour);
            this.tabControl_main.Location = new System.Drawing.Point(12, 12);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(720, 394);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_client
            // 
            this.tabPage_client.Controls.Add(this.button_refresh_clients);
            this.tabPage_client.Controls.Add(this.label16);
            this.tabPage_client.Controls.Add(this.pictureBox1);
            this.tabPage_client.Controls.Add(this.button_nouveau_client);
            this.tabPage_client.Controls.Add(this.label17);
            this.tabPage_client.Controls.Add(this.button_afficher_client);
            this.tabPage_client.Controls.Add(this.dataGridView_clients);
            this.tabPage_client.Controls.Add(this.button_precedent_client);
            this.tabPage_client.Controls.Add(this.button_premier_client);
            this.tabPage_client.Controls.Add(this.button_suivant_client);
            this.tabPage_client.Controls.Add(this.button_dernier_client);
            this.tabPage_client.Controls.Add(this.button_supprimer_client);
            this.tabPage_client.Controls.Add(this.button_modifier_client);
            this.tabPage_client.Controls.Add(this.button_ajouter_client);
            this.tabPage_client.Controls.Add(this.button_rechercher_client);
            this.tabPage_client.Controls.Add(this.text_telephone_client);
            this.tabPage_client.Controls.Add(this.text_adresse_client);
            this.tabPage_client.Controls.Add(this.text_afficher_nom_client);
            this.tabPage_client.Controls.Add(this.text_nom_client);
            this.tabPage_client.Controls.Add(this.num_id_client);
            this.tabPage_client.Controls.Add(this.label4);
            this.tabPage_client.Controls.Add(this.label3);
            this.tabPage_client.Controls.Add(this.label2);
            this.tabPage_client.Controls.Add(this.label1);
            this.tabPage_client.Location = new System.Drawing.Point(4, 22);
            this.tabPage_client.Name = "tabPage_client";
            this.tabPage_client.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_client.Size = new System.Drawing.Size(712, 368);
            this.tabPage_client.TabIndex = 0;
            this.tabPage_client.Text = "     Client     ";
            this.tabPage_client.UseVisualStyleBackColor = true;
            // 
            // button_refresh_clients
            // 
            this.button_refresh_clients.Image = global::ADO3.Properties.Resources.arrow_refresh1;
            this.button_refresh_clients.Location = new System.Drawing.Point(643, 14);
            this.button_refresh_clients.Name = "button_refresh_clients";
            this.button_refresh_clients.Size = new System.Drawing.Size(47, 31);
            this.button_refresh_clients.TabIndex = 11;
            this.button_refresh_clients.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(331, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 31);
            this.label16.TabIndex = 17;
            this.label16.Text = "Clients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADO3.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(293, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button_nouveau_client
            // 
            this.button_nouveau_client.Image = global::ADO3.Properties.Resources.page;
            this.button_nouveau_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nouveau_client.Location = new System.Drawing.Point(26, 326);
            this.button_nouveau_client.Name = "button_nouveau_client";
            this.button_nouveau_client.Size = new System.Drawing.Size(245, 23);
            this.button_nouveau_client.TabIndex = 10;
            this.button_nouveau_client.Text = "Nouveau client";
            this.button_nouveau_client.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(291, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Avec nom";
            // 
            // button_afficher_client
            // 
            this.button_afficher_client.Image = global::ADO3.Properties.Resources.accept_button;
            this.button_afficher_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_afficher_client.Location = new System.Drawing.Point(582, 326);
            this.button_afficher_client.Name = "button_afficher_client";
            this.button_afficher_client.Size = new System.Drawing.Size(108, 23);
            this.button_afficher_client.TabIndex = 14;
            this.button_afficher_client.Text = "Afficher";
            this.button_afficher_client.UseVisualStyleBackColor = true;
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AllowUserToAddRows = false;
            this.dataGridView_clients.AllowUserToDeleteRows = false;
            this.dataGridView_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_clients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(293, 52);
            this.dataGridView_clients.MultiSelect = false;
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.ReadOnly = true;
            this.dataGridView_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_clients.Size = new System.Drawing.Size(397, 256);
            this.dataGridView_clients.TabIndex = 12;
            // 
            // button_precedent_client
            // 
            this.button_precedent_client.Image = global::ADO3.Properties.Resources.resultset_previous;
            this.button_precedent_client.Location = new System.Drawing.Point(80, 193);
            this.button_precedent_client.Name = "button_precedent_client";
            this.button_precedent_client.Size = new System.Drawing.Size(48, 40);
            this.button_precedent_client.TabIndex = 6;
            this.button_precedent_client.UseVisualStyleBackColor = true;
            // 
            // button_premier_client
            // 
            this.button_premier_client.Image = global::ADO3.Properties.Resources.resultset_first;
            this.button_premier_client.Location = new System.Drawing.Point(26, 193);
            this.button_premier_client.Name = "button_premier_client";
            this.button_premier_client.Size = new System.Drawing.Size(48, 40);
            this.button_premier_client.TabIndex = 6;
            this.button_premier_client.UseVisualStyleBackColor = true;
            // 
            // button_suivant_client
            // 
            this.button_suivant_client.Image = global::ADO3.Properties.Resources.resultset_next;
            this.button_suivant_client.Location = new System.Drawing.Point(169, 193);
            this.button_suivant_client.Name = "button_suivant_client";
            this.button_suivant_client.Size = new System.Drawing.Size(48, 40);
            this.button_suivant_client.TabIndex = 6;
            this.button_suivant_client.UseVisualStyleBackColor = true;
            // 
            // button_dernier_client
            // 
            this.button_dernier_client.Image = global::ADO3.Properties.Resources.resultset_last;
            this.button_dernier_client.Location = new System.Drawing.Point(223, 193);
            this.button_dernier_client.Name = "button_dernier_client";
            this.button_dernier_client.Size = new System.Drawing.Size(48, 40);
            this.button_dernier_client.TabIndex = 6;
            this.button_dernier_client.UseVisualStyleBackColor = true;
            // 
            // button_supprimer_client
            // 
            this.button_supprimer_client.Image = global::ADO3.Properties.Resources.delete;
            this.button_supprimer_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimer_client.Location = new System.Drawing.Point(26, 297);
            this.button_supprimer_client.Name = "button_supprimer_client";
            this.button_supprimer_client.Size = new System.Drawing.Size(245, 23);
            this.button_supprimer_client.TabIndex = 9;
            this.button_supprimer_client.Text = "Supprimer le client";
            this.button_supprimer_client.UseVisualStyleBackColor = true;
            // 
            // button_modifier_client
            // 
            this.button_modifier_client.Image = global::ADO3.Properties.Resources.update;
            this.button_modifier_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier_client.Location = new System.Drawing.Point(26, 268);
            this.button_modifier_client.Name = "button_modifier_client";
            this.button_modifier_client.Size = new System.Drawing.Size(245, 23);
            this.button_modifier_client.TabIndex = 8;
            this.button_modifier_client.Text = "Modifier le client";
            this.button_modifier_client.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_client
            // 
            this.button_ajouter_client.Image = global::ADO3.Properties.Resources.add;
            this.button_ajouter_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouter_client.Location = new System.Drawing.Point(26, 239);
            this.button_ajouter_client.Name = "button_ajouter_client";
            this.button_ajouter_client.Size = new System.Drawing.Size(245, 23);
            this.button_ajouter_client.TabIndex = 7;
            this.button_ajouter_client.Text = "Ajouter le client";
            this.button_ajouter_client.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_client
            // 
            this.button_rechercher_client.Image = global::ADO3.Properties.Resources.zoom;
            this.button_rechercher_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher_client.Location = new System.Drawing.Point(163, 18);
            this.button_rechercher_client.Name = "button_rechercher_client";
            this.button_rechercher_client.Size = new System.Drawing.Size(108, 23);
            this.button_rechercher_client.TabIndex = 2;
            this.button_rechercher_client.Text = "Rechercher";
            this.button_rechercher_client.UseVisualStyleBackColor = true;
            // 
            // text_telephone_client
            // 
            this.text_telephone_client.Location = new System.Drawing.Point(99, 130);
            this.text_telephone_client.Mask = "\\0600000000";
            this.text_telephone_client.Name = "text_telephone_client";
            this.text_telephone_client.Size = new System.Drawing.Size(172, 20);
            this.text_telephone_client.TabIndex = 5;
            // 
            // text_adresse_client
            // 
            this.text_adresse_client.Location = new System.Drawing.Point(99, 78);
            this.text_adresse_client.Multiline = true;
            this.text_adresse_client.Name = "text_adresse_client";
            this.text_adresse_client.Size = new System.Drawing.Size(172, 45);
            this.text_adresse_client.TabIndex = 4;
            // 
            // text_afficher_nom_client
            // 
            this.text_afficher_nom_client.Location = new System.Drawing.Point(358, 327);
            this.text_afficher_nom_client.Name = "text_afficher_nom_client";
            this.text_afficher_nom_client.Size = new System.Drawing.Size(212, 20);
            this.text_afficher_nom_client.TabIndex = 13;
            // 
            // text_nom_client
            // 
            this.text_nom_client.Location = new System.Drawing.Point(99, 49);
            this.text_nom_client.Name = "text_nom_client";
            this.text_nom_client.Size = new System.Drawing.Size(172, 20);
            this.text_nom_client.TabIndex = 3;
            // 
            // num_id_client
            // 
            this.num_id_client.Location = new System.Drawing.Point(99, 21);
            this.num_id_client.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_id_client.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_id_client.Name = "num_id_client";
            this.num_id_client.Size = new System.Drawing.Size(58, 20);
            this.num_id_client.TabIndex = 1;
            this.num_id_client.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom/Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificateur";
            // 
            // tabPage_reservation
            // 
            this.tabPage_reservation.Controls.Add(this.button_refresh_reservations);
            this.tabPage_reservation.Controls.Add(this.label18);
            this.tabPage_reservation.Controls.Add(this.label9);
            this.tabPage_reservation.Controls.Add(this.dateTimePicker_dateFin_reservation);
            this.tabPage_reservation.Controls.Add(this.dateTimePicker_dateDebut_reservation);
            this.tabPage_reservation.Controls.Add(this.label5);
            this.tabPage_reservation.Controls.Add(this.checkBox_pension_reservation);
            this.tabPage_reservation.Controls.Add(this.dateTimePicker_date_reservation);
            this.tabPage_reservation.Controls.Add(this.comboBox_clients);
            this.tabPage_reservation.Controls.Add(this.num_code_reservation);
            this.tabPage_reservation.Controls.Add(this.label6);
            this.tabPage_reservation.Controls.Add(this.label7);
            this.tabPage_reservation.Controls.Add(this.label8);
            this.tabPage_reservation.Controls.Add(this.pictureBox2);
            this.tabPage_reservation.Controls.Add(this.button_nouveau_reservation);
            this.tabPage_reservation.Controls.Add(this.button_precedent_reservation);
            this.tabPage_reservation.Controls.Add(this.button_premier_reservation);
            this.tabPage_reservation.Controls.Add(this.button_suivant_reservation);
            this.tabPage_reservation.Controls.Add(this.button_dernier_reservation);
            this.tabPage_reservation.Controls.Add(this.button_annuler_reservation);
            this.tabPage_reservation.Controls.Add(this.button_modifier_reservation);
            this.tabPage_reservation.Controls.Add(this.button_ajouter_reservation);
            this.tabPage_reservation.Controls.Add(this.button_client_apercu);
            this.tabPage_reservation.Controls.Add(this.button_afficher_reservations);
            this.tabPage_reservation.Controls.Add(this.button_rechercher_reservation);
            this.tabPage_reservation.Controls.Add(this.tabControl_reservations);
            this.tabPage_reservation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reservation.Name = "tabPage_reservation";
            this.tabPage_reservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reservation.Size = new System.Drawing.Size(712, 368);
            this.tabPage_reservation.TabIndex = 3;
            this.tabPage_reservation.Text = "     Réservation     ";
            this.tabPage_reservation.UseVisualStyleBackColor = true;
            // 
            // button_refresh_reservations
            // 
            this.button_refresh_reservations.Image = global::ADO3.Properties.Resources.arrow_refresh1;
            this.button_refresh_reservations.Location = new System.Drawing.Point(643, 34);
            this.button_refresh_reservations.Name = "button_refresh_reservations";
            this.button_refresh_reservations.Size = new System.Drawing.Size(47, 31);
            this.button_refresh_reservations.TabIndex = 27;
            this.button_refresh_reservations.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(331, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 31);
            this.label18.TabIndex = 19;
            this.label18.Text = "Réservations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "et";
            // 
            // dateTimePicker_dateFin_reservation
            // 
            this.dateTimePicker_dateFin_reservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateFin_reservation.Location = new System.Drawing.Point(469, 326);
            this.dateTimePicker_dateFin_reservation.Name = "dateTimePicker_dateFin_reservation";
            this.dateTimePicker_dateFin_reservation.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker_dateFin_reservation.TabIndex = 31;
            // 
            // dateTimePicker_dateDebut_reservation
            // 
            this.dateTimePicker_dateDebut_reservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateDebut_reservation.Location = new System.Drawing.Point(331, 326);
            this.dateTimePicker_dateDebut_reservation.Name = "dateTimePicker_dateDebut_reservation";
            this.dateTimePicker_dateDebut_reservation.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker_dateDebut_reservation.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Entre";
            // 
            // checkBox_pension_reservation
            // 
            this.checkBox_pension_reservation.AutoSize = true;
            this.checkBox_pension_reservation.Location = new System.Drawing.Point(26, 132);
            this.checkBox_pension_reservation.Name = "checkBox_pension_reservation";
            this.checkBox_pension_reservation.Size = new System.Drawing.Size(196, 17);
            this.checkBox_pension_reservation.TabIndex = 21;
            this.checkBox_pension_reservation.Text = "Réservation avec pension complète";
            this.checkBox_pension_reservation.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_date_reservation
            // 
            this.dateTimePicker_date_reservation.Location = new System.Drawing.Point(99, 105);
            this.dateTimePicker_date_reservation.Name = "dateTimePicker_date_reservation";
            this.dateTimePicker_date_reservation.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker_date_reservation.TabIndex = 20;
            // 
            // comboBox_clients
            // 
            this.comboBox_clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clients.FormattingEnabled = true;
            this.comboBox_clients.Location = new System.Drawing.Point(99, 48);
            this.comboBox_clients.Name = "comboBox_clients";
            this.comboBox_clients.Size = new System.Drawing.Size(172, 21);
            this.comboBox_clients.TabIndex = 18;
            // 
            // num_code_reservation
            // 
            this.num_code_reservation.Location = new System.Drawing.Point(99, 21);
            this.num_code_reservation.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_code_reservation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_code_reservation.Name = "num_code_reservation";
            this.num_code_reservation.Size = new System.Drawing.Size(58, 20);
            this.num_code_reservation.TabIndex = 16;
            this.num_code_reservation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Code";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ADO3.Properties.Resources.timeline_marker;
            this.pictureBox2.Location = new System.Drawing.Point(293, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // button_nouveau_reservation
            // 
            this.button_nouveau_reservation.Image = global::ADO3.Properties.Resources.page;
            this.button_nouveau_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nouveau_reservation.Location = new System.Drawing.Point(26, 325);
            this.button_nouveau_reservation.Name = "button_nouveau_reservation";
            this.button_nouveau_reservation.Size = new System.Drawing.Size(245, 23);
            this.button_nouveau_reservation.TabIndex = 26;
            this.button_nouveau_reservation.Text = "Nouvelle réservation";
            this.button_nouveau_reservation.UseVisualStyleBackColor = true;
            // 
            // button_precedent_reservation
            // 
            this.button_precedent_reservation.Image = global::ADO3.Properties.Resources.resultset_previous;
            this.button_precedent_reservation.Location = new System.Drawing.Point(80, 192);
            this.button_precedent_reservation.Name = "button_precedent_reservation";
            this.button_precedent_reservation.Size = new System.Drawing.Size(48, 40);
            this.button_precedent_reservation.TabIndex = 22;
            this.button_precedent_reservation.UseVisualStyleBackColor = true;
            // 
            // button_premier_reservation
            // 
            this.button_premier_reservation.Image = global::ADO3.Properties.Resources.resultset_first;
            this.button_premier_reservation.Location = new System.Drawing.Point(26, 192);
            this.button_premier_reservation.Name = "button_premier_reservation";
            this.button_premier_reservation.Size = new System.Drawing.Size(48, 40);
            this.button_premier_reservation.TabIndex = 22;
            this.button_premier_reservation.UseVisualStyleBackColor = true;
            // 
            // button_suivant_reservation
            // 
            this.button_suivant_reservation.Image = global::ADO3.Properties.Resources.resultset_next;
            this.button_suivant_reservation.Location = new System.Drawing.Point(169, 192);
            this.button_suivant_reservation.Name = "button_suivant_reservation";
            this.button_suivant_reservation.Size = new System.Drawing.Size(48, 40);
            this.button_suivant_reservation.TabIndex = 22;
            this.button_suivant_reservation.UseVisualStyleBackColor = true;
            // 
            // button_dernier_reservation
            // 
            this.button_dernier_reservation.Image = global::ADO3.Properties.Resources.resultset_last;
            this.button_dernier_reservation.Location = new System.Drawing.Point(223, 192);
            this.button_dernier_reservation.Name = "button_dernier_reservation";
            this.button_dernier_reservation.Size = new System.Drawing.Size(48, 40);
            this.button_dernier_reservation.TabIndex = 22;
            this.button_dernier_reservation.UseVisualStyleBackColor = true;
            // 
            // button_annuler_reservation
            // 
            this.button_annuler_reservation.Image = global::ADO3.Properties.Resources.unmark_to_download;
            this.button_annuler_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_annuler_reservation.Location = new System.Drawing.Point(26, 296);
            this.button_annuler_reservation.Name = "button_annuler_reservation";
            this.button_annuler_reservation.Size = new System.Drawing.Size(245, 23);
            this.button_annuler_reservation.TabIndex = 25;
            this.button_annuler_reservation.Text = "Annuler la réservation";
            this.button_annuler_reservation.UseVisualStyleBackColor = true;
            // 
            // button_modifier_reservation
            // 
            this.button_modifier_reservation.Image = global::ADO3.Properties.Resources.update;
            this.button_modifier_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier_reservation.Location = new System.Drawing.Point(26, 267);
            this.button_modifier_reservation.Name = "button_modifier_reservation";
            this.button_modifier_reservation.Size = new System.Drawing.Size(245, 23);
            this.button_modifier_reservation.TabIndex = 24;
            this.button_modifier_reservation.Text = "Modifier la réservation";
            this.button_modifier_reservation.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_reservation
            // 
            this.button_ajouter_reservation.Image = global::ADO3.Properties.Resources.add;
            this.button_ajouter_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouter_reservation.Location = new System.Drawing.Point(26, 238);
            this.button_ajouter_reservation.Name = "button_ajouter_reservation";
            this.button_ajouter_reservation.Size = new System.Drawing.Size(245, 23);
            this.button_ajouter_reservation.TabIndex = 23;
            this.button_ajouter_reservation.Text = "Ajouter la réservation";
            this.button_ajouter_reservation.UseVisualStyleBackColor = true;
            // 
            // button_client_apercu
            // 
            this.button_client_apercu.Image = global::ADO3.Properties.Resources.information1;
            this.button_client_apercu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_client_apercu.Location = new System.Drawing.Point(99, 75);
            this.button_client_apercu.Name = "button_client_apercu";
            this.button_client_apercu.Size = new System.Drawing.Size(172, 23);
            this.button_client_apercu.TabIndex = 19;
            this.button_client_apercu.Text = "Aperçu du client";
            this.button_client_apercu.UseVisualStyleBackColor = true;
            // 
            // button_afficher_reservations
            // 
            this.button_afficher_reservations.Image = global::ADO3.Properties.Resources.accept_button;
            this.button_afficher_reservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_afficher_reservations.Location = new System.Drawing.Point(582, 325);
            this.button_afficher_reservations.Name = "button_afficher_reservations";
            this.button_afficher_reservations.Size = new System.Drawing.Size(108, 23);
            this.button_afficher_reservations.TabIndex = 32;
            this.button_afficher_reservations.Text = "Afficher";
            this.button_afficher_reservations.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_reservation
            // 
            this.button_rechercher_reservation.Image = global::ADO3.Properties.Resources.zoom;
            this.button_rechercher_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher_reservation.Location = new System.Drawing.Point(163, 18);
            this.button_rechercher_reservation.Name = "button_rechercher_reservation";
            this.button_rechercher_reservation.Size = new System.Drawing.Size(108, 23);
            this.button_rechercher_reservation.TabIndex = 17;
            this.button_rechercher_reservation.Text = "Rechercher";
            this.button_rechercher_reservation.UseVisualStyleBackColor = true;
            // 
            // tabControl_reservations
            // 
            this.tabControl_reservations.Controls.Add(this.tabPage_reservations);
            this.tabControl_reservations.Controls.Add(this.tabPage_reservations_annulees);
            this.tabControl_reservations.Location = new System.Drawing.Point(293, 52);
            this.tabControl_reservations.Name = "tabControl_reservations";
            this.tabControl_reservations.SelectedIndex = 0;
            this.tabControl_reservations.Size = new System.Drawing.Size(397, 256);
            this.tabControl_reservations.TabIndex = 29;
            // 
            // tabPage_reservations
            // 
            this.tabPage_reservations.Controls.Add(this.dataGridView_reservations);
            this.tabPage_reservations.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reservations.Name = "tabPage_reservations";
            this.tabPage_reservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reservations.Size = new System.Drawing.Size(389, 230);
            this.tabPage_reservations.TabIndex = 0;
            this.tabPage_reservations.Text = "Toute les réservations";
            this.tabPage_reservations.UseVisualStyleBackColor = true;
            // 
            // dataGridView_reservations
            // 
            this.dataGridView_reservations.AllowUserToAddRows = false;
            this.dataGridView_reservations.AllowUserToDeleteRows = false;
            this.dataGridView_reservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_reservations.Location = new System.Drawing.Point(1, 1);
            this.dataGridView_reservations.MultiSelect = false;
            this.dataGridView_reservations.Name = "dataGridView_reservations";
            this.dataGridView_reservations.ReadOnly = true;
            this.dataGridView_reservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reservations.Size = new System.Drawing.Size(387, 229);
            this.dataGridView_reservations.TabIndex = 28;
            // 
            // tabPage_reservations_annulees
            // 
            this.tabPage_reservations_annulees.Controls.Add(this.dataGridView_reservations_annulees);
            this.tabPage_reservations_annulees.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reservations_annulees.Name = "tabPage_reservations_annulees";
            this.tabPage_reservations_annulees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reservations_annulees.Size = new System.Drawing.Size(389, 230);
            this.tabPage_reservations_annulees.TabIndex = 1;
            this.tabPage_reservations_annulees.Text = "Réservations annulées";
            this.tabPage_reservations_annulees.UseVisualStyleBackColor = true;
            // 
            // dataGridView_reservations_annulees
            // 
            this.dataGridView_reservations_annulees.AllowUserToAddRows = false;
            this.dataGridView_reservations_annulees.AllowUserToDeleteRows = false;
            this.dataGridView_reservations_annulees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reservations_annulees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_reservations_annulees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_reservations_annulees.Location = new System.Drawing.Point(1, 1);
            this.dataGridView_reservations_annulees.MultiSelect = false;
            this.dataGridView_reservations_annulees.Name = "dataGridView_reservations_annulees";
            this.dataGridView_reservations_annulees.ReadOnly = true;
            this.dataGridView_reservations_annulees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reservations_annulees.Size = new System.Drawing.Size(387, 229);
            this.dataGridView_reservations_annulees.TabIndex = 8;
            // 
            // tabPage_sejour
            // 
            this.tabPage_sejour.Controls.Add(this.button_refresh_sejours);
            this.tabPage_sejour.Controls.Add(this.label19);
            this.tabPage_sejour.Controls.Add(this.label_nombre_reservations);
            this.tabPage_sejour.Controls.Add(this.label10);
            this.tabPage_sejour.Controls.Add(this.label11);
            this.tabPage_sejour.Controls.Add(this.dateTimePicker_date_sejour);
            this.tabPage_sejour.Controls.Add(this.comboBox_type_sejour);
            this.tabPage_sejour.Controls.Add(this.comboBox_type_reservation);
            this.tabPage_sejour.Controls.Add(this.comboBox_reservations);
            this.tabPage_sejour.Controls.Add(this.dataGridView_sejours);
            this.tabPage_sejour.Controls.Add(this.num_duree_sejour);
            this.tabPage_sejour.Controls.Add(this.num_sejour);
            this.tabPage_sejour.Controls.Add(this.label15);
            this.tabPage_sejour.Controls.Add(this.label12);
            this.tabPage_sejour.Controls.Add(this.label21);
            this.tabPage_sejour.Controls.Add(this.label20);
            this.tabPage_sejour.Controls.Add(this.label13);
            this.tabPage_sejour.Controls.Add(this.label14);
            this.tabPage_sejour.Controls.Add(this.pictureBox3);
            this.tabPage_sejour.Controls.Add(this.button_precedent_sejour);
            this.tabPage_sejour.Controls.Add(this.button_premier_sejour);
            this.tabPage_sejour.Controls.Add(this.button_suivant_sejour);
            this.tabPage_sejour.Controls.Add(this.button_dernier_sejour);
            this.tabPage_sejour.Controls.Add(this.button_nouveau_sejour);
            this.tabPage_sejour.Controls.Add(this.button_supprimer_sejour);
            this.tabPage_sejour.Controls.Add(this.button_modifier_sejour);
            this.tabPage_sejour.Controls.Add(this.button_ajouter_sejour);
            this.tabPage_sejour.Controls.Add(this.button_reservation_apercu);
            this.tabPage_sejour.Controls.Add(this.button_afficher_reservations_type);
            this.tabPage_sejour.Controls.Add(this.button_rechercher_sejour);
            this.tabPage_sejour.Location = new System.Drawing.Point(4, 22);
            this.tabPage_sejour.Name = "tabPage_sejour";
            this.tabPage_sejour.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sejour.Size = new System.Drawing.Size(712, 368);
            this.tabPage_sejour.TabIndex = 4;
            this.tabPage_sejour.Text = "    Séjour     ";
            this.tabPage_sejour.UseVisualStyleBackColor = true;
            // 
            // button_refresh_sejours
            // 
            this.button_refresh_sejours.Image = global::ADO3.Properties.Resources.arrow_refresh1;
            this.button_refresh_sejours.Location = new System.Drawing.Point(643, 14);
            this.button_refresh_sejours.Name = "button_refresh_sejours";
            this.button_refresh_sejours.Size = new System.Drawing.Size(47, 31);
            this.button_refresh_sejours.TabIndex = 20;
            this.button_refresh_sejours.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(331, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 31);
            this.label19.TabIndex = 19;
            this.label19.Text = "Séjours";
            // 
            // label_nombre_reservations
            // 
            this.label_nombre_reservations.AutoSize = true;
            this.label_nombre_reservations.Location = new System.Drawing.Point(653, 301);
            this.label_nombre_reservations.Name = "label_nombre_reservations";
            this.label_nombre_reservations.Size = new System.Drawing.Size(37, 13);
            this.label_nombre_reservations.TabIndex = 15;
            this.label_nombre_reservations.Text = "00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nombre de réservations :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Par type";
            // 
            // dateTimePicker_date_sejour
            // 
            this.dateTimePicker_date_sejour.Location = new System.Drawing.Point(99, 105);
            this.dateTimePicker_date_sejour.Name = "dateTimePicker_date_sejour";
            this.dateTimePicker_date_sejour.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker_date_sejour.TabIndex = 9;
            // 
            // comboBox_type_sejour
            // 
            this.comboBox_type_sejour.FormattingEnabled = true;
            this.comboBox_type_sejour.Items.AddRange(new object[] {
            "Journalier",
            "Semaine",
            "Weekend"});
            this.comboBox_type_sejour.Location = new System.Drawing.Point(99, 131);
            this.comboBox_type_sejour.Name = "comboBox_type_sejour";
            this.comboBox_type_sejour.Size = new System.Drawing.Size(172, 21);
            this.comboBox_type_sejour.TabIndex = 8;
            // 
            // comboBox_type_reservation
            // 
            this.comboBox_type_reservation.FormattingEnabled = true;
            this.comboBox_type_reservation.Location = new System.Drawing.Point(348, 326);
            this.comboBox_type_reservation.Name = "comboBox_type_reservation";
            this.comboBox_type_reservation.Size = new System.Drawing.Size(222, 21);
            this.comboBox_type_reservation.TabIndex = 8;
            // 
            // comboBox_reservations
            // 
            this.comboBox_reservations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_reservations.FormattingEnabled = true;
            this.comboBox_reservations.Location = new System.Drawing.Point(99, 48);
            this.comboBox_reservations.Name = "comboBox_reservations";
            this.comboBox_reservations.Size = new System.Drawing.Size(172, 21);
            this.comboBox_reservations.TabIndex = 8;
            // 
            // dataGridView_sejours
            // 
            this.dataGridView_sejours.AllowUserToAddRows = false;
            this.dataGridView_sejours.AllowUserToDeleteRows = false;
            this.dataGridView_sejours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sejours.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_sejours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sejours.Location = new System.Drawing.Point(293, 52);
            this.dataGridView_sejours.MultiSelect = false;
            this.dataGridView_sejours.Name = "dataGridView_sejours";
            this.dataGridView_sejours.ReadOnly = true;
            this.dataGridView_sejours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sejours.Size = new System.Drawing.Size(397, 238);
            this.dataGridView_sejours.TabIndex = 7;
            // 
            // num_duree_sejour
            // 
            this.num_duree_sejour.Location = new System.Drawing.Point(99, 158);
            this.num_duree_sejour.Name = "num_duree_sejour";
            this.num_duree_sejour.Size = new System.Drawing.Size(58, 20);
            this.num_duree_sejour.TabIndex = 1;
            // 
            // num_sejour
            // 
            this.num_sejour.Location = new System.Drawing.Point(99, 21);
            this.num_sejour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_sejour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_sejour.Name = "num_sejour";
            this.num_sejour.Size = new System.Drawing.Size(58, 20);
            this.num_sejour.TabIndex = 1;
            this.num_sejour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(166, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "jours";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Durée";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Réservation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Numéro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ADO3.Properties.Resources.house;
            this.pictureBox3.Location = new System.Drawing.Point(293, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // button_precedent_sejour
            // 
            this.button_precedent_sejour.Image = global::ADO3.Properties.Resources.resultset_previous;
            this.button_precedent_sejour.Location = new System.Drawing.Point(80, 192);
            this.button_precedent_sejour.Name = "button_precedent_sejour";
            this.button_precedent_sejour.Size = new System.Drawing.Size(48, 40);
            this.button_precedent_sejour.TabIndex = 6;
            this.button_precedent_sejour.UseVisualStyleBackColor = true;
            // 
            // button_premier_sejour
            // 
            this.button_premier_sejour.Image = global::ADO3.Properties.Resources.resultset_first;
            this.button_premier_sejour.Location = new System.Drawing.Point(26, 192);
            this.button_premier_sejour.Name = "button_premier_sejour";
            this.button_premier_sejour.Size = new System.Drawing.Size(48, 40);
            this.button_premier_sejour.TabIndex = 6;
            this.button_premier_sejour.UseVisualStyleBackColor = true;
            // 
            // button_suivant_sejour
            // 
            this.button_suivant_sejour.Image = global::ADO3.Properties.Resources.resultset_next;
            this.button_suivant_sejour.Location = new System.Drawing.Point(169, 192);
            this.button_suivant_sejour.Name = "button_suivant_sejour";
            this.button_suivant_sejour.Size = new System.Drawing.Size(48, 40);
            this.button_suivant_sejour.TabIndex = 6;
            this.button_suivant_sejour.UseVisualStyleBackColor = true;
            // 
            // button_dernier_sejour
            // 
            this.button_dernier_sejour.Image = global::ADO3.Properties.Resources.resultset_last;
            this.button_dernier_sejour.Location = new System.Drawing.Point(223, 192);
            this.button_dernier_sejour.Name = "button_dernier_sejour";
            this.button_dernier_sejour.Size = new System.Drawing.Size(48, 40);
            this.button_dernier_sejour.TabIndex = 6;
            this.button_dernier_sejour.UseVisualStyleBackColor = true;
            // 
            // button_nouveau_sejour
            // 
            this.button_nouveau_sejour.Image = global::ADO3.Properties.Resources.page;
            this.button_nouveau_sejour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nouveau_sejour.Location = new System.Drawing.Point(26, 325);
            this.button_nouveau_sejour.Name = "button_nouveau_sejour";
            this.button_nouveau_sejour.Size = new System.Drawing.Size(245, 23);
            this.button_nouveau_sejour.TabIndex = 5;
            this.button_nouveau_sejour.Text = "Nouveau séjour";
            this.button_nouveau_sejour.UseVisualStyleBackColor = true;
            // 
            // button_supprimer_sejour
            // 
            this.button_supprimer_sejour.Image = global::ADO3.Properties.Resources.delete;
            this.button_supprimer_sejour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimer_sejour.Location = new System.Drawing.Point(26, 296);
            this.button_supprimer_sejour.Name = "button_supprimer_sejour";
            this.button_supprimer_sejour.Size = new System.Drawing.Size(245, 23);
            this.button_supprimer_sejour.TabIndex = 5;
            this.button_supprimer_sejour.Text = "Supprimer le séjour";
            this.button_supprimer_sejour.UseVisualStyleBackColor = true;
            // 
            // button_modifier_sejour
            // 
            this.button_modifier_sejour.Image = global::ADO3.Properties.Resources.update;
            this.button_modifier_sejour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier_sejour.Location = new System.Drawing.Point(26, 267);
            this.button_modifier_sejour.Name = "button_modifier_sejour";
            this.button_modifier_sejour.Size = new System.Drawing.Size(245, 23);
            this.button_modifier_sejour.TabIndex = 5;
            this.button_modifier_sejour.Text = "Modifier le séjour";
            this.button_modifier_sejour.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_sejour
            // 
            this.button_ajouter_sejour.Image = global::ADO3.Properties.Resources.add;
            this.button_ajouter_sejour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouter_sejour.Location = new System.Drawing.Point(26, 238);
            this.button_ajouter_sejour.Name = "button_ajouter_sejour";
            this.button_ajouter_sejour.Size = new System.Drawing.Size(245, 23);
            this.button_ajouter_sejour.TabIndex = 5;
            this.button_ajouter_sejour.Text = "Ajouter le séjour";
            this.button_ajouter_sejour.UseVisualStyleBackColor = true;
            // 
            // button_reservation_apercu
            // 
            this.button_reservation_apercu.Image = global::ADO3.Properties.Resources.information1;
            this.button_reservation_apercu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reservation_apercu.Location = new System.Drawing.Point(99, 75);
            this.button_reservation_apercu.Name = "button_reservation_apercu";
            this.button_reservation_apercu.Size = new System.Drawing.Size(172, 23);
            this.button_reservation_apercu.TabIndex = 4;
            this.button_reservation_apercu.Text = "Aperçu de la réservation";
            this.button_reservation_apercu.UseVisualStyleBackColor = true;
            // 
            // button_afficher_reservations_type
            // 
            this.button_afficher_reservations_type.Image = global::ADO3.Properties.Resources.accept_button;
            this.button_afficher_reservations_type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_afficher_reservations_type.Location = new System.Drawing.Point(582, 325);
            this.button_afficher_reservations_type.Name = "button_afficher_reservations_type";
            this.button_afficher_reservations_type.Size = new System.Drawing.Size(108, 23);
            this.button_afficher_reservations_type.TabIndex = 4;
            this.button_afficher_reservations_type.Text = "Afficher";
            this.button_afficher_reservations_type.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_sejour
            // 
            this.button_rechercher_sejour.Image = global::ADO3.Properties.Resources.zoom;
            this.button_rechercher_sejour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher_sejour.Location = new System.Drawing.Point(163, 18);
            this.button_rechercher_sejour.Name = "button_rechercher_sejour";
            this.button_rechercher_sejour.Size = new System.Drawing.Size(108, 23);
            this.button_rechercher_sejour.TabIndex = 4;
            this.button_rechercher_sejour.Text = "Rechercher";
            this.button_rechercher_sejour.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 418);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des Réservations et des Séjours";
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_client.ResumeLayout(false);
            this.tabPage_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_id_client)).EndInit();
            this.tabPage_reservation.ResumeLayout(false);
            this.tabPage_reservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_code_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl_reservations.ResumeLayout(false);
            this.tabPage_reservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservations)).EndInit();
            this.tabPage_reservations_annulees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservations_annulees)).EndInit();
            this.tabPage_sejour.ResumeLayout(false);
            this.tabPage_sejour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sejours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_duree_sejour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sejour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_client;
        private System.Windows.Forms.MaskedTextBox text_telephone_client;
        private System.Windows.Forms.TextBox text_adresse_client;
        private System.Windows.Forms.TextBox text_nom_client;
        private System.Windows.Forms.NumericUpDown num_id_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dernier_client;
        private System.Windows.Forms.Button button_supprimer_client;
        private System.Windows.Forms.Button button_modifier_client;
        private System.Windows.Forms.Button button_ajouter_client;
        private System.Windows.Forms.Button button_rechercher_client;
        private System.Windows.Forms.Button button_precedent_client;
        private System.Windows.Forms.Button button_premier_client;
        private System.Windows.Forms.Button button_suivant_client;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.TabPage tabPage_reservation;
        private System.Windows.Forms.CheckBox checkBox_pension_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_reservation;
        private System.Windows.Forms.ComboBox comboBox_clients;
        private System.Windows.Forms.DataGridView dataGridView_reservations;
        private System.Windows.Forms.Button button_precedent_reservation;
        private System.Windows.Forms.Button button_premier_reservation;
        private System.Windows.Forms.Button button_suivant_reservation;
        private System.Windows.Forms.Button button_dernier_reservation;
        private System.Windows.Forms.Button button_annuler_reservation;
        private System.Windows.Forms.Button button_modifier_reservation;
        private System.Windows.Forms.Button button_ajouter_reservation;
        private System.Windows.Forms.Button button_client_apercu;
        private System.Windows.Forms.Button button_rechercher_reservation;
        private System.Windows.Forms.NumericUpDown num_code_reservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateFin_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateDebut_reservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_afficher_reservations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage_sejour;
        private System.Windows.Forms.Label label_nombre_reservations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_sejour;
        private System.Windows.Forms.ComboBox comboBox_type_sejour;
        private System.Windows.Forms.ComboBox comboBox_type_reservation;
        private System.Windows.Forms.ComboBox comboBox_reservations;
        private System.Windows.Forms.DataGridView dataGridView_sejours;
        private System.Windows.Forms.Button button_precedent_sejour;
        private System.Windows.Forms.Button button_premier_sejour;
        private System.Windows.Forms.Button button_suivant_sejour;
        private System.Windows.Forms.Button button_dernier_sejour;
        private System.Windows.Forms.Button button_supprimer_sejour;
        private System.Windows.Forms.Button button_modifier_sejour;
        private System.Windows.Forms.Button button_ajouter_sejour;
        private System.Windows.Forms.Button button_reservation_apercu;
        private System.Windows.Forms.Button button_afficher_reservations_type;
        private System.Windows.Forms.Button button_rechercher_sejour;
        private System.Windows.Forms.NumericUpDown num_sejour;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_afficher_client;
        private System.Windows.Forms.TextBox text_afficher_nom_client;
        private System.Windows.Forms.Button button_nouveau_sejour;
        private System.Windows.Forms.Button button_nouveau_client;
        private System.Windows.Forms.Button button_nouveau_reservation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown num_duree_sejour;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button_refresh_clients;
        private System.Windows.Forms.Button button_refresh_reservations;
        private System.Windows.Forms.Button button_refresh_sejours;
        private System.Windows.Forms.TabControl tabControl_reservations;
        private System.Windows.Forms.TabPage tabPage_reservations;
        private System.Windows.Forms.TabPage tabPage_reservations_annulees;
        private System.Windows.Forms.DataGridView dataGridView_reservations_annulees;
    }
}

