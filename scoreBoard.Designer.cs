namespace WindowsFormsApplication1
{
    partial class scoreBoard
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
            this.scoreDataSet = new WindowsFormsApplication1.scoreDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication1.scoreDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.scoreDataSetTableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newEntryLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateIDEntry = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteIDEntry = new System.Windows.Forms.TextBox();
            this.finalScore = new System.Windows.Forms.TextBox();
            this.finaScoreLabel = new System.Windows.Forms.Label();
            this.showAllScoresButton = new System.Windows.Forms.Button();
            this.showUserScoresButton = new System.Windows.Forms.Button();
            this.fNameTextBox2 = new System.Windows.Forms.TextBox();
            this.lNameTextBox2 = new System.Windows.Forms.TextBox();
            this.lNameLabel2 = new System.Windows.Forms.Label();
            this.fNameLabel2 = new System.Windows.Forms.Label();
            this.saveYourScoreRadioButton = new System.Windows.Forms.RadioButton();
            this.manageDataBaseRadioButton = new System.Windows.Forms.RadioButton();
            this.viewScoresRadioButton = new System.Windows.Forms.RadioButton();
            this.idNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreDataSet
            // 
            this.scoreDataSet.DataSetName = "scoreDataSet";
            this.scoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.scoreDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.scoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(12, 87);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(443, 183);
            this.tableDataGridView.TabIndex = 8;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn2.HeaderText = "fName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lName";
            this.dataGridViewTextBoxColumn3.HeaderText = "lName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn4.HeaderText = "score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // newEntryLabel
            // 
            this.newEntryLabel.AutoSize = true;
            this.newEntryLabel.Location = new System.Drawing.Point(461, 87);
            this.newEntryLabel.Name = "newEntryLabel";
            this.newEntryLabel.Size = new System.Drawing.Size(445, 34);
            this.newEntryLabel.TabIndex = 9;
            this.newEntryLabel.Text = "To Create a new entry, enter your fist and last name then click \"Save\"\r\n\r\n";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(584, 122);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(461, 121);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lNameTextBox.Location = new System.Drawing.Point(587, 152);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lNameTextBox.TabIndex = 15;
            this.lNameTextBox.TextChanged += new System.EventHandler(this.lNameTextBox_TextChanged);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fNameTextBox.Location = new System.Drawing.Point(464, 152);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.fNameTextBox.TabIndex = 14;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(715, 151);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(142, 23);
            this.enterButton.TabIndex = 13;
            this.enterButton.Text = "Save";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.SystemColors.Info;
            this.updateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.updateLabel.Location = new System.Drawing.Point(461, 200);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(409, 17);
            this.updateLabel.TabIndex = 20;
            this.updateLabel.Text = "To update your score, enter your ID number then click \"Update\"";
            // 
            // updateIDEntry
            // 
            this.updateIDEntry.Location = new System.Drawing.Point(461, 248);
            this.updateIDEntry.Name = "updateIDEntry";
            this.updateIDEntry.Size = new System.Drawing.Size(100, 22);
            this.updateIDEntry.TabIndex = 19;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(602, 247);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteLabel.Location = new System.Drawing.Point(458, 43);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(258, 17);
            this.deleteLabel.TabIndex = 23;
            this.deleteLabel.Text = "To delete an entry, enter the ID number";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(573, 83);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteIDEntry
            // 
            this.deleteIDEntry.Location = new System.Drawing.Point(461, 84);
            this.deleteIDEntry.Name = "deleteIDEntry";
            this.deleteIDEntry.Size = new System.Drawing.Size(100, 22);
            this.deleteIDEntry.TabIndex = 21;
            this.deleteIDEntry.TextChanged += new System.EventHandler(this.deleteIDEntry_TextChanged);
            // 
            // finalScore
            // 
            this.finalScore.Location = new System.Drawing.Point(548, 15);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(100, 22);
            this.finalScore.TabIndex = 24;
            // 
            // finaScoreLabel
            // 
            this.finaScoreLabel.AutoSize = true;
            this.finaScoreLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaScoreLabel.Location = new System.Drawing.Point(368, 9);
            this.finaScoreLabel.Name = "finaScoreLabel";
            this.finaScoreLabel.Size = new System.Drawing.Size(155, 30);
            this.finaScoreLabel.TabIndex = 25;
            this.finaScoreLabel.Text = "Final Score";
            // 
            // showAllScoresButton
            // 
            this.showAllScoresButton.Location = new System.Drawing.Point(461, 312);
            this.showAllScoresButton.Name = "showAllScoresButton";
            this.showAllScoresButton.Size = new System.Drawing.Size(150, 35);
            this.showAllScoresButton.TabIndex = 26;
            this.showAllScoresButton.Text = "Show All Scores";
            this.showAllScoresButton.UseVisualStyleBackColor = true;
            this.showAllScoresButton.Click += new System.EventHandler(this.showAllScoresButton_Click);
            // 
            // showUserScoresButton
            // 
            this.showUserScoresButton.Location = new System.Drawing.Point(15, 310);
            this.showUserScoresButton.Name = "showUserScoresButton";
            this.showUserScoresButton.Size = new System.Drawing.Size(150, 37);
            this.showUserScoresButton.TabIndex = 27;
            this.showUserScoresButton.Text = "Show My Scores";
            this.showUserScoresButton.UseVisualStyleBackColor = true;
            this.showUserScoresButton.Click += new System.EventHandler(this.showUserScoresButton_Click);
            // 
            // fNameTextBox2
            // 
            this.fNameTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fNameTextBox2.Location = new System.Drawing.Point(189, 325);
            this.fNameTextBox2.Name = "fNameTextBox2";
            this.fNameTextBox2.Size = new System.Drawing.Size(100, 22);
            this.fNameTextBox2.TabIndex = 28;
            // 
            // lNameTextBox2
            // 
            this.lNameTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lNameTextBox2.Location = new System.Drawing.Point(321, 325);
            this.lNameTextBox2.Name = "lNameTextBox2";
            this.lNameTextBox2.Size = new System.Drawing.Size(100, 22);
            this.lNameTextBox2.TabIndex = 29;
            // 
            // lNameLabel2
            // 
            this.lNameLabel2.AutoSize = true;
            this.lNameLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lNameLabel2.Location = new System.Drawing.Point(318, 298);
            this.lNameLabel2.Name = "lNameLabel2";
            this.lNameLabel2.Size = new System.Drawing.Size(76, 17);
            this.lNameLabel2.TabIndex = 31;
            this.lNameLabel2.Text = "Last Name";
            // 
            // fNameLabel2
            // 
            this.fNameLabel2.AutoSize = true;
            this.fNameLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fNameLabel2.Location = new System.Drawing.Point(186, 298);
            this.fNameLabel2.Name = "fNameLabel2";
            this.fNameLabel2.Size = new System.Drawing.Size(76, 17);
            this.fNameLabel2.TabIndex = 30;
            this.fNameLabel2.Text = "First Name";
            // 
            // saveYourScoreRadioButton
            // 
            this.saveYourScoreRadioButton.AutoSize = true;
            this.saveYourScoreRadioButton.Location = new System.Drawing.Point(15, 13);
            this.saveYourScoreRadioButton.Name = "saveYourScoreRadioButton";
            this.saveYourScoreRadioButton.Size = new System.Drawing.Size(206, 21);
            this.saveYourScoreRadioButton.TabIndex = 32;
            this.saveYourScoreRadioButton.TabStop = true;
            this.saveYourScoreRadioButton.Text = "Save Or Update Your Score";
            this.saveYourScoreRadioButton.UseVisualStyleBackColor = true;
            this.saveYourScoreRadioButton.CheckedChanged += new System.EventHandler(this.saveYourScoreRadioButton_CheckedChanged);
            // 
            // manageDataBaseRadioButton
            // 
            this.manageDataBaseRadioButton.AutoSize = true;
            this.manageDataBaseRadioButton.Location = new System.Drawing.Point(15, 39);
            this.manageDataBaseRadioButton.Name = "manageDataBaseRadioButton";
            this.manageDataBaseRadioButton.Size = new System.Drawing.Size(179, 21);
            this.manageDataBaseRadioButton.TabIndex = 33;
            this.manageDataBaseRadioButton.TabStop = true;
            this.manageDataBaseRadioButton.Text = "Manage The Data Base";
            this.manageDataBaseRadioButton.UseVisualStyleBackColor = true;
            this.manageDataBaseRadioButton.CheckedChanged += new System.EventHandler(this.manageDataBaseRadioButton_CheckedChanged);
            // 
            // viewScoresRadioButton
            // 
            this.viewScoresRadioButton.AutoSize = true;
            this.viewScoresRadioButton.Location = new System.Drawing.Point(216, 39);
            this.viewScoresRadioButton.Name = "viewScoresRadioButton";
            this.viewScoresRadioButton.Size = new System.Drawing.Size(106, 21);
            this.viewScoresRadioButton.TabIndex = 34;
            this.viewScoresRadioButton.TabStop = true;
            this.viewScoresRadioButton.Text = "View Scores";
            this.viewScoresRadioButton.UseVisualStyleBackColor = true;
            this.viewScoresRadioButton.CheckedChanged += new System.EventHandler(this.viewScoresRadioButton_CheckedChanged);
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idNumberLabel.Location = new System.Drawing.Point(461, 228);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(122, 17);
            this.idNumberLabel.TabIndex = 35;
            this.idNumberLabel.Text = "Score \"id\" number";
            // 
            // scoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 400);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.viewScoresRadioButton);
            this.Controls.Add(this.manageDataBaseRadioButton);
            this.Controls.Add(this.saveYourScoreRadioButton);
            this.Controls.Add(this.lNameLabel2);
            this.Controls.Add(this.fNameLabel2);
            this.Controls.Add(this.lNameTextBox2);
            this.Controls.Add(this.fNameTextBox2);
            this.Controls.Add(this.showUserScoresButton);
            this.Controls.Add(this.showAllScoresButton);
            this.Controls.Add(this.finaScoreLabel);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteIDEntry);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.updateIDEntry);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.newEntryLabel);
            this.Controls.Add(this.tableDataGridView);
            this.Name = "scoreBoard";
            this.Text = " ";
            this.Load += new System.EventHandler(this.scoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private scoreDataSet scoreDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private scoreDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private scoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label newEntryLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.TextBox updateIDEntry;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteIDEntry;
        private System.Windows.Forms.TextBox finalScore;
        private System.Windows.Forms.Label finaScoreLabel;
        private System.Windows.Forms.Button showAllScoresButton;
        private System.Windows.Forms.Button showUserScoresButton;
        private System.Windows.Forms.TextBox fNameTextBox2;
        private System.Windows.Forms.TextBox lNameTextBox2;
        private System.Windows.Forms.Label lNameLabel2;
        private System.Windows.Forms.Label fNameLabel2;
        private System.Windows.Forms.RadioButton saveYourScoreRadioButton;
        private System.Windows.Forms.RadioButton manageDataBaseRadioButton;
        private System.Windows.Forms.RadioButton viewScoresRadioButton;
        private System.Windows.Forms.Label idNumberLabel;
    }
}