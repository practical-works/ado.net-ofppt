namespace ADOX_GestionVentesPro.Interfaces.Fichier
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_SeConnecter = new System.Windows.Forms.Button();
            this.checkBox_IdSave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider_login = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel_compte = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "moder",
            "user"});
            this.textBox_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Id.Location = new System.Drawing.Point(29, 40);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(198, 20);
            this.textBox_Id.TabIndex = 0;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(29, 79);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '•';
            this.textBox_Pass.Size = new System.Drawing.Size(198, 20);
            this.textBox_Pass.TabIndex = 1;
            this.textBox_Pass.Text = "123";
            // 
            // button_SeConnecter
            // 
            this.button_SeConnecter.Image = global::ADOX_GestionVentesPro.Properties.Resources.accept_button;
            this.button_SeConnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SeConnecter.Location = new System.Drawing.Point(29, 128);
            this.button_SeConnecter.Name = "button_SeConnecter";
            this.button_SeConnecter.Size = new System.Drawing.Size(198, 23);
            this.button_SeConnecter.TabIndex = 2;
            this.button_SeConnecter.Text = "Se connecter";
            this.button_SeConnecter.UseVisualStyleBackColor = true;
            this.button_SeConnecter.Click += new System.EventHandler(this.button_SeConnecter_Click);
            // 
            // checkBox_IdSave
            // 
            this.checkBox_IdSave.AutoSize = true;
            this.checkBox_IdSave.Checked = true;
            this.checkBox_IdSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IdSave.Location = new System.Drawing.Point(29, 105);
            this.checkBox_IdSave.Name = "checkBox_IdSave";
            this.checkBox_IdSave.Size = new System.Drawing.Size(162, 17);
            this.checkBox_IdSave.TabIndex = 4;
            this.checkBox_IdSave.Text = "Se rappeler de l\'identificateur";
            this.checkBox_IdSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SeConnecter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox_IdSave);
            this.groupBox1.Controls.Add(this.textBox_Pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // errorProvider_login
            // 
            this.errorProvider_login.BlinkRate = 200;
            this.errorProvider_login.ContainerControl = this;
            this.errorProvider_login.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_login.Icon")));
            // 
            // linkLabel_compte
            // 
            this.linkLabel_compte.AutoSize = true;
            this.linkLabel_compte.Location = new System.Drawing.Point(49, 203);
            this.linkLabel_compte.Name = "linkLabel_compte";
            this.linkLabel_compte.Size = new System.Drawing.Size(185, 13);
            this.linkLabel_compte.TabIndex = 3;
            this.linkLabel_compte.TabStop = true;
            this.linkLabel_compte.Text = "Créer un nouveau compte d\'utilisateur";
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_SeConnecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 230);
            this.Controls.Add(this.linkLabel_compte);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_SeConnecter;
        private System.Windows.Forms.CheckBox checkBox_IdSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider_login;
        private System.Windows.Forms.LinkLabel linkLabel_compte;
    }
}