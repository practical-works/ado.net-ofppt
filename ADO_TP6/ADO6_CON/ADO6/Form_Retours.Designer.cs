namespace ADO6
{
    partial class Form_Retours
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_NUMEMP = new System.Windows.Forms.ComboBox();
            this.comboBox_CODADH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ADH = new System.Windows.Forms.TextBox();
            this.label_nbrEmprunts = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Valider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_NUMEMP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_CODADH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ADH, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_nbrEmprunts, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 92);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // comboBox_NUMEMP
            // 
            this.comboBox_NUMEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_NUMEMP.BackColor = System.Drawing.Color.Silver;
            this.comboBox_NUMEMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NUMEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NUMEMP.FormattingEnabled = true;
            this.comboBox_NUMEMP.Location = new System.Drawing.Point(126, 55);
            this.comboBox_NUMEMP.Name = "comboBox_NUMEMP";
            this.comboBox_NUMEMP.Size = new System.Drawing.Size(117, 21);
            this.comboBox_NUMEMP.TabIndex = 6;
            this.comboBox_NUMEMP.SelectedIndexChanged += new System.EventHandler(this.comboBox_NUMEMP_SelectedIndexChanged);
            // 
            // comboBox_CODADH
            // 
            this.comboBox_CODADH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_CODADH.BackColor = System.Drawing.Color.Silver;
            this.comboBox_CODADH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CODADH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CODADH.FormattingEnabled = true;
            this.comboBox_CODADH.Location = new System.Drawing.Point(126, 9);
            this.comboBox_CODADH.Name = "comboBox_CODADH";
            this.comboBox_CODADH.Size = new System.Drawing.Size(117, 21);
            this.comboBox_CODADH.TabIndex = 5;
            this.comboBox_CODADH.SelectedIndexChanged += new System.EventHandler(this.comboBox_CODADH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéros des emprunts non encore retournés";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de l’adhèrent";
            // 
            // textBox_ADH
            // 
            this.textBox_ADH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ADH.BackColor = System.Drawing.Color.Gray;
            this.textBox_ADH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ADH.ForeColor = System.Drawing.Color.White;
            this.textBox_ADH.Location = new System.Drawing.Point(250, 10);
            this.textBox_ADH.Name = "textBox_ADH";
            this.textBox_ADH.ReadOnly = true;
            this.textBox_ADH.Size = new System.Drawing.Size(119, 20);
            this.textBox_ADH.TabIndex = 13;
            // 
            // label_nbrEmprunts
            // 
            this.label_nbrEmprunts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_nbrEmprunts.AutoSize = true;
            this.label_nbrEmprunts.Location = new System.Drawing.Point(250, 59);
            this.label_nbrEmprunts.Name = "label_nbrEmprunts";
            this.label_nbrEmprunts.Size = new System.Drawing.Size(65, 13);
            this.label_nbrEmprunts.TabIndex = 14;
            this.label_nbrEmprunts.Text = "0 emprunt(s)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.button_Valider, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(11, 109);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 57);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // button_Valider
            // 
            this.button_Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Valider.BackColor = System.Drawing.Color.Gray;
            this.button_Valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Valider.Enabled = false;
            this.button_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Valider.Location = new System.Drawing.Point(34, 8);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(303, 40);
            this.button_Valider.TabIndex = 0;
            this.button_Valider.Text = "Valider le retour";
            this.button_Valider.UseVisualStyleBackColor = false;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // Form_Retours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 176);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Retours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Retours";
            this.Load += new System.EventHandler(this.Form_Retours_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_NUMEMP;
        private System.Windows.Forms.ComboBox comboBox_CODADH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ADH;
        private System.Windows.Forms.Label label_nbrEmprunts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_Valider;
    }
}