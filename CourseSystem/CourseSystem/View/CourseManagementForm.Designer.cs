﻿
namespace CourseSystem
{
    partial class CourseManagementForm
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
            this._managementTabControl = new System.Windows.Forms.TabControl();
            this._courseManagementTabPage = new System.Windows.Forms.TabPage();
            this._classDataGroupBox = new System.Windows.Forms.GroupBox();
            this._classTimeDataGridView = new System.Windows.Forms.DataGridView();
            this._classTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._classTime0Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime1Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime2Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime3Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime4Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime5Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classTime6Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._courseClassSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._courseSelectionLabel = new System.Windows.Forms.Label();
            this._courseClassTimeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._classTimeSelectionLabel = new System.Windows.Forms.Label();
            this._courseNoteTextBox = new System.Windows.Forms.TextBox();
            this._courseNoteLabel = new System.Windows.Forms.Label();
            this._courseLanguageTextBox = new System.Windows.Forms.TextBox();
            this._courseLanguageLabel = new System.Windows.Forms.Label();
            this._courseTeachingAssistantTextBox = new System.Windows.Forms.TextBox();
            this._courseTeachingAssistantLabel = new System.Windows.Forms.Label();
            this._courseTypeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._courseTypeSelectionLabel = new System.Windows.Forms.Label();
            this._courseTeacherTextBox = new System.Windows.Forms.TextBox();
            this._courseTeacherLabel = new System.Windows.Forms.Label();
            this._courseCreditTextBox = new System.Windows.Forms.TextBox();
            this._courseCreditLabel = new System.Windows.Forms.Label();
            this._courseStageTextBox = new System.Windows.Forms.TextBox();
            this._courseStageLabel = new System.Windows.Forms.Label();
            this._courseNameTextBox = new System.Windows.Forms.TextBox();
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._courseNumberTextBox = new System.Windows.Forms.TextBox();
            this._courseNumberLabel = new System.Windows.Forms.Label();
            this._courseEnabledComboBox = new System.Windows.Forms.ComboBox();
            this._saveCourseDataButton = new System.Windows.Forms.Button();
            this._addCourseDataButton = new System.Windows.Forms.Button();
            this._courseListBox = new System.Windows.Forms.ListBox();
            this._classManagementTabPage = new System.Windows.Forms.TabPage();
            this._comingSoonLabel = new System.Windows.Forms.Label();
            this._managementTabControl.SuspendLayout();
            this._courseManagementTabPage.SuspendLayout();
            this._classDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._classTimeDataGridView)).BeginInit();
            this._classManagementTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _managementTabControl
            // 
            this._managementTabControl.Controls.Add(this._courseManagementTabPage);
            this._managementTabControl.Controls.Add(this._classManagementTabPage);
            this._managementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._managementTabControl.Location = new System.Drawing.Point(0, 0);
            this._managementTabControl.Name = "_managementTabControl";
            this._managementTabControl.SelectedIndex = 0;
            this._managementTabControl.Size = new System.Drawing.Size(800, 450);
            this._managementTabControl.TabIndex = 0;
            // 
            // _courseManagementTabPage
            // 
            this._courseManagementTabPage.Controls.Add(this._classDataGroupBox);
            this._courseManagementTabPage.Controls.Add(this._saveCourseDataButton);
            this._courseManagementTabPage.Controls.Add(this._addCourseDataButton);
            this._courseManagementTabPage.Controls.Add(this._courseListBox);
            this._courseManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._courseManagementTabPage.Name = "_courseManagementTabPage";
            this._courseManagementTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._courseManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this._courseManagementTabPage.TabIndex = 0;
            this._courseManagementTabPage.Text = "課程管理";
            this._courseManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // _classDataGroupBox
            // 
            this._classDataGroupBox.Controls.Add(this._classTimeDataGridView);
            this._classDataGroupBox.Controls.Add(this._courseClassSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._courseSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._courseClassTimeSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._classTimeSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._courseNoteTextBox);
            this._classDataGroupBox.Controls.Add(this._courseNoteLabel);
            this._classDataGroupBox.Controls.Add(this._courseLanguageTextBox);
            this._classDataGroupBox.Controls.Add(this._courseLanguageLabel);
            this._classDataGroupBox.Controls.Add(this._courseTeachingAssistantTextBox);
            this._classDataGroupBox.Controls.Add(this._courseTeachingAssistantLabel);
            this._classDataGroupBox.Controls.Add(this._courseTypeSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._courseTypeSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._courseTeacherTextBox);
            this._classDataGroupBox.Controls.Add(this._courseTeacherLabel);
            this._classDataGroupBox.Controls.Add(this._courseCreditTextBox);
            this._classDataGroupBox.Controls.Add(this._courseCreditLabel);
            this._classDataGroupBox.Controls.Add(this._courseStageTextBox);
            this._classDataGroupBox.Controls.Add(this._courseStageLabel);
            this._classDataGroupBox.Controls.Add(this._courseNameTextBox);
            this._classDataGroupBox.Controls.Add(this._courseNameLabel);
            this._classDataGroupBox.Controls.Add(this._courseNumberTextBox);
            this._classDataGroupBox.Controls.Add(this._courseNumberLabel);
            this._classDataGroupBox.Controls.Add(this._courseEnabledComboBox);
            this._classDataGroupBox.Location = new System.Drawing.Point(180, 6);
            this._classDataGroupBox.Name = "_classDataGroupBox";
            this._classDataGroupBox.Size = new System.Drawing.Size(612, 352);
            this._classDataGroupBox.TabIndex = 3;
            this._classDataGroupBox.TabStop = false;
            this._classDataGroupBox.Text = "編輯課程";
            // 
            // _classTimeDataGridView
            // 
            this._classTimeDataGridView.AllowUserToAddRows = false;
            this._classTimeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._classTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._classTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._classTimeColumn,
            this._classTime0Column,
            this._classTime1Column,
            this._classTime2Column,
            this._classTime3Column,
            this._classTime4Column,
            this._classTime5Column,
            this._classTime6Column});
            this._classTimeDataGridView.Enabled = false;
            this._classTimeDataGridView.Location = new System.Drawing.Point(8, 152);
            this._classTimeDataGridView.Name = "_classTimeDataGridView";
            this._classTimeDataGridView.RowHeadersVisible = false;
            this._classTimeDataGridView.RowHeadersWidth = 62;
            this._classTimeDataGridView.RowTemplate.Height = 24;
            this._classTimeDataGridView.Size = new System.Drawing.Size(598, 194);
            this._classTimeDataGridView.TabIndex = 23;
            this._classTimeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellClassTimeDataGridView);
            this._classTimeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangedCellValueClassTimeDataGridView);
            // 
            // classTimeColumn
            // 
            this._classTimeColumn.HeaderText = "節數";
            this._classTimeColumn.MinimumWidth = 8;
            this._classTimeColumn.Name = "classTimeColumn";
            this._classTimeColumn.ReadOnly = true;
            // 
            // classTime0Column
            // 
            this._classTime0Column.HeaderText = "日";
            this._classTime0Column.MinimumWidth = 8;
            this._classTime0Column.Name = "classTime0Column";
            this._classTime0Column.ReadOnly = true;
            // 
            // classTime1Column
            // 
            this._classTime1Column.HeaderText = "一";
            this._classTime1Column.MinimumWidth = 8;
            this._classTime1Column.Name = "classTime1Column";
            this._classTime1Column.ReadOnly = true;
            // 
            // classTime2Column
            // 
            this._classTime2Column.HeaderText = "二";
            this._classTime2Column.MinimumWidth = 8;
            this._classTime2Column.Name = "classTime2Column";
            this._classTime2Column.ReadOnly = true;
            // 
            // classTime3Column
            // 
            this._classTime3Column.HeaderText = "三";
            this._classTime3Column.MinimumWidth = 8;
            this._classTime3Column.Name = "classTime3Column";
            this._classTime3Column.ReadOnly = true;
            // 
            // classTime4Column
            // 
            this._classTime4Column.HeaderText = "四";
            this._classTime4Column.MinimumWidth = 8;
            this._classTime4Column.Name = "classTime4Column";
            this._classTime4Column.ReadOnly = true;
            // 
            // classTime5Column
            // 
            this._classTime5Column.HeaderText = "五";
            this._classTime5Column.MinimumWidth = 8;
            this._classTime5Column.Name = "classTime5Column";
            this._classTime5Column.ReadOnly = true;
            // 
            // classTime6Column
            // 
            this._classTime6Column.HeaderText = "六";
            this._classTime6Column.MinimumWidth = 8;
            this._classTime6Column.Name = "classTime6Column";
            this._classTime6Column.ReadOnly = true;
            // 
            // _courseClassSelectionComboBox
            // 
            this._courseClassSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseClassSelectionComboBox.Enabled = false;
            this._courseClassSelectionComboBox.FormattingEnabled = true;
            this._courseClassSelectionComboBox.Items.AddRange(new object[] {
            "資工三",
            "電子三甲"});
            this._courseClassSelectionComboBox.Location = new System.Drawing.Point(197, 124);
            this._courseClassSelectionComboBox.Name = "_courseClassSelectionComboBox";
            this._courseClassSelectionComboBox.Size = new System.Drawing.Size(87, 20);
            this._courseClassSelectionComboBox.TabIndex = 22;
            this._courseClassSelectionComboBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseSelectionLabel
            // 
            this._courseSelectionLabel.AutoSize = true;
            this._courseSelectionLabel.Location = new System.Drawing.Point(148, 127);
            this._courseSelectionLabel.Name = "_courseSelectionLabel";
            this._courseSelectionLabel.Size = new System.Drawing.Size(43, 12);
            this._courseSelectionLabel.TabIndex = 21;
            this._courseSelectionLabel.Text = "班級(*)";
            // 
            // _courseClassTimeSelectionComboBox
            // 
            this._courseClassTimeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseClassTimeSelectionComboBox.Enabled = false;
            this._courseClassTimeSelectionComboBox.FormattingEnabled = true;
            this._courseClassTimeSelectionComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this._courseClassTimeSelectionComboBox.Location = new System.Drawing.Point(55, 124);
            this._courseClassTimeSelectionComboBox.Name = "_courseClassTimeSelectionComboBox";
            this._courseClassTimeSelectionComboBox.Size = new System.Drawing.Size(87, 20);
            this._courseClassTimeSelectionComboBox.TabIndex = 20;
            this._courseClassTimeSelectionComboBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _classTimeSelectionLabel
            // 
            this._classTimeSelectionLabel.AutoSize = true;
            this._classTimeSelectionLabel.Location = new System.Drawing.Point(8, 127);
            this._classTimeSelectionLabel.Name = "_classTimeSelectionLabel";
            this._classTimeSelectionLabel.Size = new System.Drawing.Size(43, 12);
            this._classTimeSelectionLabel.TabIndex = 19;
            this._classTimeSelectionLabel.Text = "時數(*)";
            // 
            // _courseNoteTextBox
            // 
            this._courseNoteTextBox.Enabled = false;
            this._courseNoteTextBox.Location = new System.Drawing.Point(43, 96);
            this._courseNoteTextBox.Name = "_courseNoteTextBox";
            this._courseNoteTextBox.Size = new System.Drawing.Size(563, 22);
            this._courseNoteTextBox.TabIndex = 18;
            this._courseNoteTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseNoteLabel
            // 
            this._courseNoteLabel.AutoSize = true;
            this._courseNoteLabel.Location = new System.Drawing.Point(8, 99);
            this._courseNoteLabel.Name = "_courseNoteLabel";
            this._courseNoteLabel.Size = new System.Drawing.Size(29, 12);
            this._courseNoteLabel.TabIndex = 17;
            this._courseNoteLabel.Text = "備註";
            // 
            // _courseLanguageTextBox
            // 
            this._courseLanguageTextBox.Enabled = false;
            this._courseLanguageTextBox.Location = new System.Drawing.Point(365, 68);
            this._courseLanguageTextBox.Name = "_courseLanguageTextBox";
            this._courseLanguageTextBox.Size = new System.Drawing.Size(241, 22);
            this._courseLanguageTextBox.TabIndex = 16;
            this._courseLanguageTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseLanguageLabel
            // 
            this._courseLanguageLabel.AutoSize = true;
            this._courseLanguageLabel.Location = new System.Drawing.Point(306, 71);
            this._courseLanguageLabel.Name = "_courseLanguageLabel";
            this._courseLanguageLabel.Size = new System.Drawing.Size(53, 12);
            this._courseLanguageLabel.TabIndex = 15;
            this._courseLanguageLabel.Text = "授課語言";
            // 
            // _courseTeachingAssistantTextBox
            // 
            this._courseTeachingAssistantTextBox.Enabled = false;
            this._courseTeachingAssistantTextBox.Location = new System.Drawing.Point(65, 68);
            this._courseTeachingAssistantTextBox.Name = "_courseTeachingAssistantTextBox";
            this._courseTeachingAssistantTextBox.Size = new System.Drawing.Size(235, 22);
            this._courseTeachingAssistantTextBox.TabIndex = 14;
            this._courseTeachingAssistantTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseTeachingAssistantLabel
            // 
            this._courseTeachingAssistantLabel.AutoSize = true;
            this._courseTeachingAssistantLabel.Location = new System.Drawing.Point(6, 73);
            this._courseTeachingAssistantLabel.Name = "_courseTeachingAssistantLabel";
            this._courseTeachingAssistantLabel.Size = new System.Drawing.Size(53, 12);
            this._courseTeachingAssistantLabel.TabIndex = 13;
            this._courseTeachingAssistantLabel.Text = "教學助理";
            // 
            // _courseTypeSelectionComboBox
            // 
            this._courseTypeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseTypeSelectionComboBox.Enabled = false;
            this._courseTypeSelectionComboBox.FormattingEnabled = true;
            this._courseTypeSelectionComboBox.Items.AddRange(new object[] {
            "○",
            "△",
            "☆",
            "●",
            "▲",
            "★"});
            this._courseTypeSelectionComboBox.Location = new System.Drawing.Point(508, 42);
            this._courseTypeSelectionComboBox.Name = "_courseTypeSelectionComboBox";
            this._courseTypeSelectionComboBox.Size = new System.Drawing.Size(98, 20);
            this._courseTypeSelectionComboBox.TabIndex = 12;
            this._courseTypeSelectionComboBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseTypeSelectionLabel
            // 
            this._courseTypeSelectionLabel.AutoSize = true;
            this._courseTypeSelectionLabel.Location = new System.Drawing.Point(471, 45);
            this._courseTypeSelectionLabel.Name = "_courseTypeSelectionLabel";
            this._courseTypeSelectionLabel.Size = new System.Drawing.Size(31, 12);
            this._courseTypeSelectionLabel.TabIndex = 11;
            this._courseTypeSelectionLabel.Text = "修(*)";
            // 
            // _courseTeacherTextBox
            // 
            this._courseTeacherTextBox.Enabled = false;
            this._courseTeacherTextBox.Location = new System.Drawing.Point(365, 42);
            this._courseTeacherTextBox.Name = "_courseTeacherTextBox";
            this._courseTeacherTextBox.Size = new System.Drawing.Size(100, 22);
            this._courseTeacherTextBox.TabIndex = 10;
            this._courseTeacherTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseTeacherLabel
            // 
            this._courseTeacherLabel.AutoSize = true;
            this._courseTeacherLabel.Location = new System.Drawing.Point(316, 45);
            this._courseTeacherLabel.Name = "_courseTeacherLabel";
            this._courseTeacherLabel.Size = new System.Drawing.Size(43, 12);
            this._courseTeacherLabel.TabIndex = 9;
            this._courseTeacherLabel.Text = "教師(*)";
            // 
            // _courseCreditTextBox
            // 
            this._courseCreditTextBox.Enabled = false;
            this._courseCreditTextBox.Location = new System.Drawing.Point(210, 42);
            this._courseCreditTextBox.Name = "_courseCreditTextBox";
            this._courseCreditTextBox.Size = new System.Drawing.Size(100, 22);
            this._courseCreditTextBox.TabIndex = 8;
            this._courseCreditTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            this._courseCreditTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyInLimit);
            // 
            // _courseCreditLabel
            // 
            this._courseCreditLabel.AutoSize = true;
            this._courseCreditLabel.Location = new System.Drawing.Point(161, 45);
            this._courseCreditLabel.Name = "_courseCreditLabel";
            this._courseCreditLabel.Size = new System.Drawing.Size(43, 12);
            this._courseCreditLabel.TabIndex = 7;
            this._courseCreditLabel.Text = "學分(*)";
            // 
            // _courseStageTextBox
            // 
            this._courseStageTextBox.Enabled = false;
            this._courseStageTextBox.Location = new System.Drawing.Point(55, 42);
            this._courseStageTextBox.Name = "_courseStageTextBox";
            this._courseStageTextBox.Size = new System.Drawing.Size(100, 22);
            this._courseStageTextBox.TabIndex = 6;
            this._courseStageTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            this._courseStageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyInLimit);
            // 
            // _courseStageLabel
            // 
            this._courseStageLabel.AutoSize = true;
            this._courseStageLabel.Location = new System.Drawing.Point(6, 45);
            this._courseStageLabel.Name = "_courseStageLabel";
            this._courseStageLabel.Size = new System.Drawing.Size(43, 12);
            this._courseStageLabel.TabIndex = 5;
            this._courseStageLabel.Text = "階段(*)";
            // 
            // _courseNameTextBox
            // 
            this._courseNameTextBox.Enabled = false;
            this._courseNameTextBox.Location = new System.Drawing.Point(365, 16);
            this._courseNameTextBox.Name = "_courseNameTextBox";
            this._courseNameTextBox.Size = new System.Drawing.Size(241, 22);
            this._courseNameTextBox.TabIndex = 4;
            this._courseNameTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _courseNameLabel
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Location = new System.Drawing.Point(292, 19);
            this._courseNameLabel.Name = "_courseNameLabel";
            this._courseNameLabel.Size = new System.Drawing.Size(67, 12);
            this._courseNameLabel.TabIndex = 3;
            this._courseNameLabel.Text = "課程名稱(*)";
            // 
            // _courseNumberTextBox
            // 
            this._courseNumberTextBox.Enabled = false;
            this._courseNumberTextBox.Location = new System.Drawing.Point(148, 16);
            this._courseNumberTextBox.Name = "_courseNumberTextBox";
            this._courseNumberTextBox.Size = new System.Drawing.Size(138, 22);
            this._courseNumberTextBox.TabIndex = 2;
            this._courseNumberTextBox.TextChanged += new System.EventHandler(this.ChangedText);
            this._courseNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyInLimit);
            // 
            // _courseNumberLabel
            // 
            this._courseNumberLabel.AutoSize = true;
            this._courseNumberLabel.Location = new System.Drawing.Point(101, 19);
            this._courseNumberLabel.Name = "_courseNumberLabel";
            this._courseNumberLabel.Size = new System.Drawing.Size(43, 12);
            this._courseNumberLabel.TabIndex = 1;
            this._courseNumberLabel.Text = "課號(*)";
            // 
            // _courseEnabledComboBox
            // 
            this._courseEnabledComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseEnabledComboBox.Enabled = false;
            this._courseEnabledComboBox.FormattingEnabled = true;
            this._courseEnabledComboBox.Items.AddRange(new object[] {
            "開課",
            "停開"});
            this._courseEnabledComboBox.Location = new System.Drawing.Point(8, 16);
            this._courseEnabledComboBox.Name = "_courseEnabledComboBox";
            this._courseEnabledComboBox.Size = new System.Drawing.Size(87, 20);
            this._courseEnabledComboBox.TabIndex = 0;
            this._courseEnabledComboBox.TextChanged += new System.EventHandler(this.ChangedText);
            // 
            // _saveCourseDataButton
            // 
            this._saveCourseDataButton.Enabled = false;
            this._saveCourseDataButton.Location = new System.Drawing.Point(665, 371);
            this._saveCourseDataButton.Name = "_saveCourseDataButton";
            this._saveCourseDataButton.Size = new System.Drawing.Size(127, 53);
            this._saveCourseDataButton.TabIndex = 2;
            this._saveCourseDataButton.Text = "儲存";
            this._saveCourseDataButton.UseVisualStyleBackColor = true;
            this._saveCourseDataButton.Click += new System.EventHandler(this.ClickSaveCourseDataButton);
            // 
            // _addCourseButton
            // 
            this._addCourseDataButton.Location = new System.Drawing.Point(0, 371);
            this._addCourseDataButton.Name = "_addCourseButton";
            this._addCourseDataButton.Size = new System.Drawing.Size(174, 53);
            this._addCourseDataButton.TabIndex = 1;
            this._addCourseDataButton.Text = "新增課程";
            this._addCourseDataButton.UseVisualStyleBackColor = true;
            this._addCourseDataButton.Click += new System.EventHandler(this.ClickAddCourseButton);
            // 
            // _courseListBox
            // 
            this._courseListBox.FormattingEnabled = true;
            this._courseListBox.ItemHeight = 12;
            this._courseListBox.Location = new System.Drawing.Point(0, 6);
            this._courseListBox.Name = "_courseListBox";
            this._courseListBox.Size = new System.Drawing.Size(174, 352);
            this._courseListBox.TabIndex = 0;
            this._courseListBox.SelectedIndexChanged += new System.EventHandler(this.ChangedSelectedIndexCourseListBox);
            // 
            // _classManagementTabPage
            // 
            this._classManagementTabPage.Controls.Add(this._comingSoonLabel);
            this._classManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._classManagementTabPage.Name = "_classManagementTabPage";
            this._classManagementTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._classManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this._classManagementTabPage.TabIndex = 1;
            this._classManagementTabPage.Text = "班級管理";
            this._classManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // _comingSoonLabel
            // 
            this._comingSoonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comingSoonLabel.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comingSoonLabel.Location = new System.Drawing.Point(3, 3);
            this._comingSoonLabel.Name = "_comingSoonLabel";
            this._comingSoonLabel.Size = new System.Drawing.Size(786, 418);
            this._comingSoonLabel.TabIndex = 0;
            this._comingSoonLabel.Text = "coming soon";
            this._comingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._managementTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseManagementForm";
            this.Text = "課程管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCourseManagementForm);
            this.Load += new System.EventHandler(this.LoadCourseManagementForm);
            this._managementTabControl.ResumeLayout(false);
            this._courseManagementTabPage.ResumeLayout(false);
            this._classDataGroupBox.ResumeLayout(false);
            this._classDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._classTimeDataGridView)).EndInit();
            this._classManagementTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _managementTabControl;
        private System.Windows.Forms.TabPage _courseManagementTabPage;
        private System.Windows.Forms.TabPage _classManagementTabPage;
        private System.Windows.Forms.Label _comingSoonLabel;
        private System.Windows.Forms.Button _addCourseDataButton;
        private System.Windows.Forms.ListBox _courseListBox;
        private System.Windows.Forms.Button _saveCourseDataButton;
        private System.Windows.Forms.GroupBox _classDataGroupBox;
        private System.Windows.Forms.TextBox _courseNameTextBox;
        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.TextBox _courseNumberTextBox;
        private System.Windows.Forms.Label _courseNumberLabel;
        private System.Windows.Forms.DataGridView _classTimeDataGridView;
        private System.Windows.Forms.ComboBox _courseClassSelectionComboBox;
        private System.Windows.Forms.Label _courseSelectionLabel;
        private System.Windows.Forms.ComboBox _courseClassTimeSelectionComboBox;
        private System.Windows.Forms.Label _classTimeSelectionLabel;
        private System.Windows.Forms.TextBox _courseNoteTextBox;
        private System.Windows.Forms.Label _courseNoteLabel;
        private System.Windows.Forms.TextBox _courseLanguageTextBox;
        private System.Windows.Forms.Label _courseLanguageLabel;
        private System.Windows.Forms.TextBox _courseTeachingAssistantTextBox;
        private System.Windows.Forms.Label _courseTeachingAssistantLabel;
        private System.Windows.Forms.ComboBox _courseTypeSelectionComboBox;
        private System.Windows.Forms.Label _courseTypeSelectionLabel;
        private System.Windows.Forms.TextBox _courseTeacherTextBox;
        private System.Windows.Forms.Label _courseTeacherLabel;
        private System.Windows.Forms.TextBox _courseCreditTextBox;
        private System.Windows.Forms.Label _courseCreditLabel;
        private System.Windows.Forms.TextBox _courseStageTextBox;
        private System.Windows.Forms.Label _courseStageLabel;
        private System.Windows.Forms.ComboBox _courseEnabledComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _classTimeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime0Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime1Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime2Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime3Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime4Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime5Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _classTime6Column;
    }
}