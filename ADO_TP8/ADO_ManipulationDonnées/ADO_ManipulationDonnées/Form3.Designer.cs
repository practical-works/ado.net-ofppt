namespace ADO_ManipulationDonnées
{
    partial class Form3
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label valeurLabel;
            System.Windows.Forms.Label modeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.exempleDbDataSet = new ADO_ManipulationDonnées.ExempleDbDataSet();
            this.exempleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exempleTableAdapter = new ADO_ManipulationDonnées.ExempleDbDataSetTableAdapters.ExempleTableAdapter();
            this.tableAdapterManager = new ADO_ManipulationDonnées.ExempleDbDataSetTableAdapters.TableAdapterManager();
            this.exempleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exempleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.valeurTextBox = new System.Windows.Forms.TextBox();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.exempleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            codeLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            valeurLabel = new System.Windows.Forms.Label();
            modeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exempleDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exempleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exempleBindingNavigator)).BeginInit();
            this.exempleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exempleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(20, 58);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(50, 19);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "code:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(20, 92);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(44, 19);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "nom:";
            // 
            // valeurLabel
            // 
            valeurLabel.AutoSize = true;
            valeurLabel.Location = new System.Drawing.Point(20, 126);
            valeurLabel.Name = "valeurLabel";
            valeurLabel.Size = new System.Drawing.Size(56, 19);
            valeurLabel.TabIndex = 5;
            valeurLabel.Text = "valeur:";
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new System.Drawing.Point(20, 162);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new System.Drawing.Size(54, 19);
            modeLabel.TabIndex = 7;
            modeLabel.Text = "mode:";
            // 
            // exempleDbDataSet
            // 
            this.exempleDbDataSet.DataSetName = "ExempleDbDataSet";
            this.exempleDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exempleBindingSource
            // 
            this.exempleBindingSource.DataMember = "Exemple";
            this.exempleBindingSource.DataSource = this.exempleDbDataSet;
            // 
            // exempleTableAdapter
            // 
            this.exempleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExempleTableAdapter = this.exempleTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADO_ManipulationDonnées.ExempleDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exempleBindingNavigator
            // 
            this.exempleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.exempleBindingNavigator.BindingSource = this.exempleBindingSource;
            this.exempleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.exempleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.exempleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.exempleBindingNavigatorSaveItem});
            this.exempleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.exempleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.exempleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.exempleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.exempleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.exempleBindingNavigator.Name = "exempleBindingNavigator";
            this.exempleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.exempleBindingNavigator.Size = new System.Drawing.Size(787, 25);
            this.exempleBindingNavigator.TabIndex = 0;
            this.exempleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exempleBindingNavigatorSaveItem
            // 
            this.exempleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exempleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("exempleBindingNavigatorSaveItem.Image")));
            this.exempleBindingNavigatorSaveItem.Name = "exempleBindingNavigatorSaveItem";
            this.exempleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.exempleBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.exempleBindingNavigatorSaveItem.Click += new System.EventHandler(this.exempleBindingNavigatorSaveItem_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exempleBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(81, 53);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(138, 24);
            this.codeTextBox.TabIndex = 2;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exempleBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(81, 87);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(138, 24);
            this.nomTextBox.TabIndex = 4;
            // 
            // valeurTextBox
            // 
            this.valeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exempleBindingSource, "valeur", true));
            this.valeurTextBox.Location = new System.Drawing.Point(81, 121);
            this.valeurTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valeurTextBox.Name = "valeurTextBox";
            this.valeurTextBox.Size = new System.Drawing.Size(138, 24);
            this.valeurTextBox.TabIndex = 6;
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.exempleBindingSource, "mode", true));
            this.modeCheckBox.Location = new System.Drawing.Point(81, 155);
            this.modeCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(138, 32);
            this.modeCheckBox.TabIndex = 8;
            this.modeCheckBox.Text = "OK";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            // 
            // exempleDataGridView
            // 
            this.exempleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exempleDataGridView.AutoGenerateColumns = false;
            this.exempleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exempleDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.exempleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exempleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.exempleDataGridView.DataSource = this.exempleBindingSource;
            this.exempleDataGridView.Location = new System.Drawing.Point(240, 53);
            this.exempleDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exempleDataGridView.Name = "exempleDataGridView";
            this.exempleDataGridView.Size = new System.Drawing.Size(522, 220);
            this.exempleDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn1.HeaderText = "code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valeur";
            this.dataGridViewTextBoxColumn3.HeaderText = "valeur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "mode";
            this.dataGridViewCheckBoxColumn1.HeaderText = "mode";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 301);
            this.Controls.Add(this.exempleDataGridView);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(valeurLabel);
            this.Controls.Add(this.valeurTextBox);
            this.Controls.Add(modeLabel);
            this.Controls.Add(this.modeCheckBox);
            this.Controls.Add(this.exempleBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindingSource par Assisstant";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.exempleDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exempleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exempleBindingNavigator)).EndInit();
            this.exempleBindingNavigator.ResumeLayout(false);
            this.exempleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exempleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExempleDbDataSet exempleDbDataSet;
        private System.Windows.Forms.BindingSource exempleBindingSource;
        private ExempleDbDataSetTableAdapters.ExempleTableAdapter exempleTableAdapter;
        private ExempleDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator exempleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton exempleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox valeurTextBox;
        private System.Windows.Forms.CheckBox modeCheckBox;
        private System.Windows.Forms.DataGridView exempleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;




    }
}