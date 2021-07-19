namespace ADO6
{
    partial class Form_Emprunts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_NUMEMP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_CODOUV = new System.Windows.Forms.ComboBox();
            this.comboBox_CODADH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_DATEMP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DATRET = new System.Windows.Forms.DateTimePicker();
            this.textBox_ADH = new System.Windows.Forms.TextBox();
            this.textBox_OUV = new System.Windows.Forms.TextBox();
            this.checkBox_PasEncoreRetourne = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NUMEMP)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_NUMEMP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_CODOUV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_CODADH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_DATEMP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_DATRET, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ADH, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_OUV, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_PasEncoreRetourne, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 205);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // numericUpDown_NUMEMP
            // 
            this.numericUpDown_NUMEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_NUMEMP.BackColor = System.Drawing.Color.Silver;
            this.numericUpDown_NUMEMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_NUMEMP.Enabled = false;
            this.numericUpDown_NUMEMP.Location = new System.Drawing.Point(127, 10);
            this.numericUpDown_NUMEMP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_NUMEMP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NUMEMP.Name = "numericUpDown_NUMEMP";
            this.numericUpDown_NUMEMP.ReadOnly = true;
            this.numericUpDown_NUMEMP.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown_NUMEMP.TabIndex = 12;
            this.numericUpDown_NUMEMP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numéro d’emprunt";
            // 
            // comboBox_CODOUV
            // 
            this.comboBox_CODOUV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_CODOUV.BackColor = System.Drawing.Color.Silver;
            this.comboBox_CODOUV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CODOUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CODOUV.FormattingEnabled = true;
            this.comboBox_CODOUV.Location = new System.Drawing.Point(127, 89);
            this.comboBox_CODOUV.Name = "comboBox_CODOUV";
            this.comboBox_CODOUV.Size = new System.Drawing.Size(117, 21);
            this.comboBox_CODOUV.TabIndex = 6;
            this.comboBox_CODOUV.SelectedIndexChanged += new System.EventHandler(this.comboBox_CODOUV_SelectedIndexChanged);
            // 
            // comboBox_CODADH
            // 
            this.comboBox_CODADH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_CODADH.BackColor = System.Drawing.Color.Silver;
            this.comboBox_CODADH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CODADH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CODADH.FormattingEnabled = true;
            this.comboBox_CODADH.Location = new System.Drawing.Point(127, 49);
            this.comboBox_CODADH.Name = "comboBox_CODADH";
            this.comboBox_CODADH.Size = new System.Drawing.Size(117, 21);
            this.comboBox_CODADH.TabIndex = 5;
            this.comboBox_CODADH.SelectedIndexChanged += new System.EventHandler(this.comboBox_CODADH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de retour";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date d’emprunt";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code de l’ouvrage emprunté";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de l’adhèrent";
            // 
            // dateTimePicker_DATEMP
            // 
            this.dateTimePicker_DATEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_DATEMP.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePicker_DATEMP.CalendarTitleBackColor = System.Drawing.Color.Silver;
            this.dateTimePicker_DATEMP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DATEMP.Location = new System.Drawing.Point(127, 130);
            this.dateTimePicker_DATEMP.Name = "dateTimePicker_DATEMP";
            this.dateTimePicker_DATEMP.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_DATEMP.TabIndex = 7;
            // 
            // dateTimePicker_DATRET
            // 
            this.dateTimePicker_DATRET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_DATRET.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePicker_DATRET.CalendarTitleBackColor = System.Drawing.Color.Silver;
            this.dateTimePicker_DATRET.Checked = false;
            this.dateTimePicker_DATRET.Enabled = false;
            this.dateTimePicker_DATRET.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DATRET.Location = new System.Drawing.Point(127, 172);
            this.dateTimePicker_DATRET.Name = "dateTimePicker_DATRET";
            this.dateTimePicker_DATRET.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_DATRET.TabIndex = 8;
            // 
            // textBox_ADH
            // 
            this.textBox_ADH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ADH.BackColor = System.Drawing.Color.Gray;
            this.textBox_ADH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ADH.ForeColor = System.Drawing.Color.White;
            this.textBox_ADH.Location = new System.Drawing.Point(251, 50);
            this.textBox_ADH.Name = "textBox_ADH";
            this.textBox_ADH.ReadOnly = true;
            this.textBox_ADH.Size = new System.Drawing.Size(118, 20);
            this.textBox_ADH.TabIndex = 13;
            // 
            // textBox_OUV
            // 
            this.textBox_OUV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OUV.BackColor = System.Drawing.Color.Gray;
            this.textBox_OUV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_OUV.ForeColor = System.Drawing.Color.White;
            this.textBox_OUV.Location = new System.Drawing.Point(251, 90);
            this.textBox_OUV.Name = "textBox_OUV";
            this.textBox_OUV.ReadOnly = true;
            this.textBox_OUV.Size = new System.Drawing.Size(118, 20);
            this.textBox_OUV.TabIndex = 13;
            // 
            // checkBox_PasEncoreRetourne
            // 
            this.checkBox_PasEncoreRetourne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_PasEncoreRetourne.AutoSize = true;
            this.checkBox_PasEncoreRetourne.Checked = true;
            this.checkBox_PasEncoreRetourne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PasEncoreRetourne.Location = new System.Drawing.Point(251, 174);
            this.checkBox_PasEncoreRetourne.Name = "checkBox_PasEncoreRetourne";
            this.checkBox_PasEncoreRetourne.Size = new System.Drawing.Size(80, 17);
            this.checkBox_PasEncoreRetourne.TabIndex = 14;
            this.checkBox_PasEncoreRetourne.Text = "Pas encore";
            this.checkBox_PasEncoreRetourne.UseVisualStyleBackColor = true;
            this.checkBox_PasEncoreRetourne.CheckedChanged += new System.EventHandler(this.checkBox_Retour_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.button_Ajouter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_modifier, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Supprimer, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Nouveau, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 284);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(871, 57);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Ajouter.BackColor = System.Drawing.Color.Gray;
            this.button_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajouter.Location = new System.Drawing.Point(7, 8);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(202, 40);
            this.button_Ajouter.TabIndex = 0;
            this.button_Ajouter.Text = "Ajouter (Emprunter)";
            this.button_Ajouter.UseVisualStyleBackColor = false;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_modifier.BackColor = System.Drawing.Color.Gray;
            this.button_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modifier.Enabled = false;
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.Location = new System.Drawing.Point(224, 8);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(202, 40);
            this.button_modifier.TabIndex = 0;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Supprimer.BackColor = System.Drawing.Color.Gray;
            this.button_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.Location = new System.Drawing.Point(441, 8);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(202, 40);
            this.button_Supprimer.TabIndex = 0;
            this.button_Supprimer.Text = "Supprimer (Annuler Emprunt)";
            this.button_Supprimer.UseVisualStyleBackColor = false;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Nouveau
            // 
            this.button_Nouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Nouveau.BackColor = System.Drawing.Color.Gray;
            this.button_Nouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Nouveau.Location = new System.Drawing.Point(660, 8);
            this.button_Nouveau.Name = "button_Nouveau";
            this.button_Nouveau.Size = new System.Drawing.Size(202, 40);
            this.button_Nouveau.TabIndex = 0;
            this.button_Nouveau.Text = "Nouveau";
            this.button_Nouveau.UseVisualStyleBackColor = false;
            this.button_Nouveau.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(391, 11);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 267);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(9, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Emprunts";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 222);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 56);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(115, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(208, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(301, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form_Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 353);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Emprunts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Emprunts";
            this.Load += new System.EventHandler(this.Form_Emprunts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NUMEMP)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_NUMEMP;
        private System.Windows.Forms.ComboBox comboBox_CODOUV;
        private System.Windows.Forms.ComboBox comboBox_CODADH;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATEMP;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATRET;
        private System.Windows.Forms.TextBox textBox_ADH;
        private System.Windows.Forms.TextBox textBox_OUV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox_PasEncoreRetourne;
    }
}