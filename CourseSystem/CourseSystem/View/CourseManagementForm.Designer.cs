
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
            this._courseSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._courseSelectionLabel = new System.Windows.Forms.Label();
            this._classTimeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._classTimeSelectionLabel = new System.Windows.Forms.Label();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this._noteLabel = new System.Windows.Forms.Label();
            this._languageTextBox = new System.Windows.Forms.TextBox();
            this._languageLabel = new System.Windows.Forms.Label();
            this._teachingAssistantTextBox = new System.Windows.Forms.TextBox();
            this._teachingAssistantLabel = new System.Windows.Forms.Label();
            this._courseTypeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._courseTypeSelectionLabel = new System.Windows.Forms.Label();
            this._teacherTextBox = new System.Windows.Forms.TextBox();
            this._teacherLabel = new System.Windows.Forms.Label();
            this._creditTextBox = new System.Windows.Forms.TextBox();
            this._creditLabel = new System.Windows.Forms.Label();
            this._stageTextBox = new System.Windows.Forms.TextBox();
            this._stageLabel = new System.Windows.Forms.Label();
            this._courseNameTextBox = new System.Windows.Forms.TextBox();
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._courseNumberTextBox = new System.Windows.Forms.TextBox();
            this._courseNumberLabel = new System.Windows.Forms.Label();
            this._courseEnabledComboBox = new System.Windows.Forms.ComboBox();
            this._saveCourseDataButton = new System.Windows.Forms.Button();
            this._addCourseButton = new System.Windows.Forms.Button();
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
            // managementTabControl
            // 
            this._managementTabControl.Controls.Add(this._courseManagementTabPage);
            this._managementTabControl.Controls.Add(this._classManagementTabPage);
            this._managementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._managementTabControl.Location = new System.Drawing.Point(0, 0);
            this._managementTabControl.Name = "managementTabControl";
            this._managementTabControl.SelectedIndex = 0;
            this._managementTabControl.Size = new System.Drawing.Size(800, 450);
            this._managementTabControl.TabIndex = 0;
            // 
            // courseManagementTabPage
            // 
            this._courseManagementTabPage.Controls.Add(this._classDataGroupBox);
            this._courseManagementTabPage.Controls.Add(this._saveCourseDataButton);
            this._courseManagementTabPage.Controls.Add(this._addCourseButton);
            this._courseManagementTabPage.Controls.Add(this._courseListBox);
            this._courseManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._courseManagementTabPage.Name = "courseManagementTabPage";
            this._courseManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._courseManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this._courseManagementTabPage.TabIndex = 0;
            this._courseManagementTabPage.Text = "課程管理";
            this._courseManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this._classDataGroupBox.Controls.Add(this._classTimeDataGridView);
            this._classDataGroupBox.Controls.Add(this._courseSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._courseSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._classTimeSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._classTimeSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._noteTextBox);
            this._classDataGroupBox.Controls.Add(this._noteLabel);
            this._classDataGroupBox.Controls.Add(this._languageTextBox);
            this._classDataGroupBox.Controls.Add(this._languageLabel);
            this._classDataGroupBox.Controls.Add(this._teachingAssistantTextBox);
            this._classDataGroupBox.Controls.Add(this._teachingAssistantLabel);
            this._classDataGroupBox.Controls.Add(this._courseTypeSelectionComboBox);
            this._classDataGroupBox.Controls.Add(this._courseTypeSelectionLabel);
            this._classDataGroupBox.Controls.Add(this._teacherTextBox);
            this._classDataGroupBox.Controls.Add(this._teacherLabel);
            this._classDataGroupBox.Controls.Add(this._creditTextBox);
            this._classDataGroupBox.Controls.Add(this._creditLabel);
            this._classDataGroupBox.Controls.Add(this._stageTextBox);
            this._classDataGroupBox.Controls.Add(this._stageLabel);
            this._classDataGroupBox.Controls.Add(this._courseNameTextBox);
            this._classDataGroupBox.Controls.Add(this._courseNameLabel);
            this._classDataGroupBox.Controls.Add(this._courseNumberTextBox);
            this._classDataGroupBox.Controls.Add(this._courseNumberLabel);
            this._classDataGroupBox.Controls.Add(this._courseEnabledComboBox);
            this._classDataGroupBox.Location = new System.Drawing.Point(180, 6);
            this._classDataGroupBox.Name = "groupBox1";
            this._classDataGroupBox.Size = new System.Drawing.Size(612, 352);
            this._classDataGroupBox.TabIndex = 3;
            this._classDataGroupBox.TabStop = false;
            this._classDataGroupBox.Text = "編輯課程";
            // 
            // dataGridView1
            // 
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
            this._classTimeDataGridView.Location = new System.Drawing.Point(8, 152);
            this._classTimeDataGridView.Name = "dataGridView1";
            this._classTimeDataGridView.RowHeadersVisible = false;
            this._classTimeDataGridView.RowTemplate.Height = 24;
            this._classTimeDataGridView.Size = new System.Drawing.Size(598, 194);
            this._classTimeDataGridView.TabIndex = 23;
            // 
            // Column1
            // 
            this._classTimeColumn.HeaderText = "節數";
            this._classTimeColumn.Name = "classTimeColumn";
            this._classTimeColumn.ReadOnly = true;
            this._classTimeColumn.Width = 70;
            // 
            // Column2
            // 
            this._classTime0Column.HeaderText = "日";
            this._classTime0Column.Name = "classTime0Column";
            this._classTime0Column.ReadOnly = true;
            this._classTime0Column.Width = 75;
            // 
            // Column3
            // 
            this._classTime1Column.HeaderText = "一";
            this._classTime1Column.Name = "classTime1Column";
            this._classTime1Column.ReadOnly = true;
            this._classTime1Column.Width = 75;
            // 
            // Column4
            // 
            this._classTime2Column.HeaderText = "二";
            this._classTime2Column.Name = "classTime2Column";
            this._classTime2Column.ReadOnly = true;
            this._classTime2Column.Width = 75;
            // 
            // Column5
            // 
            this._classTime3Column.HeaderText = "三";
            this._classTime3Column.Name = "classTime3Column";
            this._classTime3Column.ReadOnly = true;
            this._classTime3Column.Width = 75;
            // 
            // Column6
            // 
            this._classTime4Column.HeaderText = "四";
            this._classTime4Column.Name = "classTime4Column";
            this._classTime4Column.ReadOnly = true;
            this._classTime4Column.Width = 75;
            // 
            // Column7
            // 
            this._classTime5Column.HeaderText = "五";
            this._classTime5Column.Name = "classTime5Column";
            this._classTime5Column.ReadOnly = true;
            this._classTime5Column.Width = 75;
            // 
            // Column8
            // 
            this._classTime6Column.HeaderText = "六";
            this._classTime6Column.Name = "classTime6Column";
            this._classTime6Column.ReadOnly = true;
            this._classTime6Column.Width = 75;
            // 
            // comboBox4
            // 
            this._courseSelectionComboBox.FormattingEnabled = true;
            this._courseSelectionComboBox.Items.AddRange(new object[] {
            "資工三",
            "電子三甲"});
            this._courseSelectionComboBox.Location = new System.Drawing.Point(197, 124);
            this._courseSelectionComboBox.Name = "comboBox4";
            this._courseSelectionComboBox.Size = new System.Drawing.Size(87, 20);
            this._courseSelectionComboBox.TabIndex = 22;
            // 
            // label11
            // 
            this._courseSelectionLabel.AutoSize = true;
            this._courseSelectionLabel.Location = new System.Drawing.Point(148, 127);
            this._courseSelectionLabel.Name = "label11";
            this._courseSelectionLabel.Size = new System.Drawing.Size(43, 12);
            this._courseSelectionLabel.TabIndex = 21;
            this._courseSelectionLabel.Text = "班級(*)";
            // 
            // comboBox3
            // 
            this._classTimeSelectionComboBox.FormattingEnabled = true;
            this._classTimeSelectionComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this._classTimeSelectionComboBox.Location = new System.Drawing.Point(55, 124);
            this._classTimeSelectionComboBox.Name = "comboBox3";
            this._classTimeSelectionComboBox.Size = new System.Drawing.Size(87, 20);
            this._classTimeSelectionComboBox.TabIndex = 20;
            // 
            // label10
            // 
            this._classTimeSelectionLabel.AutoSize = true;
            this._classTimeSelectionLabel.Location = new System.Drawing.Point(8, 127);
            this._classTimeSelectionLabel.Name = "label10";
            this._classTimeSelectionLabel.Size = new System.Drawing.Size(43, 12);
            this._classTimeSelectionLabel.TabIndex = 19;
            this._classTimeSelectionLabel.Text = "時數(*)";
            // 
            // textBox8
            // 
            this._noteTextBox.Location = new System.Drawing.Point(43, 96);
            this._noteTextBox.Name = "textBox8";
            this._noteTextBox.Size = new System.Drawing.Size(563, 22);
            this._noteTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this._noteLabel.AutoSize = true;
            this._noteLabel.Location = new System.Drawing.Point(8, 99);
            this._noteLabel.Name = "label9";
            this._noteLabel.Size = new System.Drawing.Size(29, 12);
            this._noteLabel.TabIndex = 17;
            this._noteLabel.Text = "備註";
            // 
            // textBox7
            // 
            this._languageTextBox.Location = new System.Drawing.Point(365, 68);
            this._languageTextBox.Name = "textBox7";
            this._languageTextBox.Size = new System.Drawing.Size(241, 22);
            this._languageTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this._languageLabel.AutoSize = true;
            this._languageLabel.Location = new System.Drawing.Point(306, 71);
            this._languageLabel.Name = "label8";
            this._languageLabel.Size = new System.Drawing.Size(53, 12);
            this._languageLabel.TabIndex = 15;
            this._languageLabel.Text = "授課語言";
            // 
            // textBox6
            // 
            this._teachingAssistantTextBox.Location = new System.Drawing.Point(65, 68);
            this._teachingAssistantTextBox.Name = "textBox6";
            this._teachingAssistantTextBox.Size = new System.Drawing.Size(235, 22);
            this._teachingAssistantTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this._teachingAssistantLabel.AutoSize = true;
            this._teachingAssistantLabel.Location = new System.Drawing.Point(6, 73);
            this._teachingAssistantLabel.Name = "label7";
            this._teachingAssistantLabel.Size = new System.Drawing.Size(53, 12);
            this._teachingAssistantLabel.TabIndex = 13;
            this._teachingAssistantLabel.Text = "教學助理";
            // 
            // comboBox2
            // 
            this._courseTypeSelectionComboBox.FormattingEnabled = true;
            this._courseTypeSelectionComboBox.Items.AddRange(new object[] {
            "○",
            "△",
            "☆",
            "●",
            "▲",
            "★"});
            this._courseTypeSelectionComboBox.Location = new System.Drawing.Point(508, 42);
            this._courseTypeSelectionComboBox.Name = "comboBox2";
            this._courseTypeSelectionComboBox.Size = new System.Drawing.Size(98, 20);
            this._courseTypeSelectionComboBox.TabIndex = 12;
            // 
            // label6
            // 
            this._courseTypeSelectionLabel.AutoSize = true;
            this._courseTypeSelectionLabel.Location = new System.Drawing.Point(471, 45);
            this._courseTypeSelectionLabel.Name = "label6";
            this._courseTypeSelectionLabel.Size = new System.Drawing.Size(31, 12);
            this._courseTypeSelectionLabel.TabIndex = 11;
            this._courseTypeSelectionLabel.Text = "修(*)";
            // 
            // textBox5
            // 
            this._teacherTextBox.Location = new System.Drawing.Point(365, 42);
            this._teacherTextBox.Name = "textBox5";
            this._teacherTextBox.Size = new System.Drawing.Size(100, 22);
            this._teacherTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this._teacherLabel.AutoSize = true;
            this._teacherLabel.Location = new System.Drawing.Point(316, 45);
            this._teacherLabel.Name = "label5";
            this._teacherLabel.Size = new System.Drawing.Size(43, 12);
            this._teacherLabel.TabIndex = 9;
            this._teacherLabel.Text = "教師(*)";
            // 
            // textBox4
            // 
            this._creditTextBox.Location = new System.Drawing.Point(210, 42);
            this._creditTextBox.Name = "textBox4";
            this._creditTextBox.Size = new System.Drawing.Size(100, 22);
            this._creditTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this._creditLabel.AutoSize = true;
            this._creditLabel.Location = new System.Drawing.Point(161, 45);
            this._creditLabel.Name = "label4";
            this._creditLabel.Size = new System.Drawing.Size(43, 12);
            this._creditLabel.TabIndex = 7;
            this._creditLabel.Text = "學分(*)";
            // 
            // textBox3
            // 
            this._stageTextBox.Location = new System.Drawing.Point(55, 42);
            this._stageTextBox.Name = "textBox3";
            this._stageTextBox.Size = new System.Drawing.Size(100, 22);
            this._stageTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this._stageLabel.AutoSize = true;
            this._stageLabel.Location = new System.Drawing.Point(6, 45);
            this._stageLabel.Name = "label3";
            this._stageLabel.Size = new System.Drawing.Size(43, 12);
            this._stageLabel.TabIndex = 5;
            this._stageLabel.Text = "階段(*)";
            // 
            // textBox2
            // 
            this._courseNameTextBox.Location = new System.Drawing.Point(365, 16);
            this._courseNameTextBox.Name = "textBox2";
            this._courseNameTextBox.Size = new System.Drawing.Size(241, 22);
            this._courseNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Location = new System.Drawing.Point(292, 19);
            this._courseNameLabel.Name = "label2";
            this._courseNameLabel.Size = new System.Drawing.Size(67, 12);
            this._courseNameLabel.TabIndex = 3;
            this._courseNameLabel.Text = "課程名稱(*)";
            // 
            // textBox1
            // 
            this._courseNumberTextBox.Location = new System.Drawing.Point(148, 16);
            this._courseNumberTextBox.Name = "textBox1";
            this._courseNumberTextBox.Size = new System.Drawing.Size(138, 22);
            this._courseNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this._courseNumberLabel.AutoSize = true;
            this._courseNumberLabel.Location = new System.Drawing.Point(101, 19);
            this._courseNumberLabel.Name = "label1";
            this._courseNumberLabel.Size = new System.Drawing.Size(43, 12);
            this._courseNumberLabel.TabIndex = 1;
            this._courseNumberLabel.Text = "課號(*)";
            // 
            // comboBox1
            // 
            this._courseEnabledComboBox.FormattingEnabled = true;
            this._courseEnabledComboBox.Items.AddRange(new object[] {
            "開課",
            "停開"});
            this._courseEnabledComboBox.Location = new System.Drawing.Point(8, 16);
            this._courseEnabledComboBox.Name = "comboBox1";
            this._courseEnabledComboBox.Size = new System.Drawing.Size(87, 20);
            this._courseEnabledComboBox.TabIndex = 0;
            // 
            // button2
            // 
            this._saveCourseDataButton.Location = new System.Drawing.Point(665, 371);
            this._saveCourseDataButton.Name = "button2";
            this._saveCourseDataButton.Size = new System.Drawing.Size(127, 53);
            this._saveCourseDataButton.TabIndex = 2;
            this._saveCourseDataButton.Text = "儲存";
            this._saveCourseDataButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this._addCourseButton.Location = new System.Drawing.Point(0, 371);
            this._addCourseButton.Name = "button1";
            this._addCourseButton.Size = new System.Drawing.Size(174, 53);
            this._addCourseButton.TabIndex = 1;
            this._addCourseButton.Text = "新增課程";
            this._addCourseButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this._courseListBox.FormattingEnabled = true;
            this._courseListBox.ItemHeight = 12;
            this._courseListBox.Location = new System.Drawing.Point(0, 6);
            this._courseListBox.Name = "listBox1";
            this._courseListBox.Size = new System.Drawing.Size(174, 352);
            this._courseListBox.TabIndex = 0;
            // 
            // classManagementTabPage
            // 
            this._classManagementTabPage.Controls.Add(this._comingSoonLabel);
            this._classManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._classManagementTabPage.Name = "classManagementTabPage";
            this._classManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._classManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this._classManagementTabPage.TabIndex = 1;
            this._classManagementTabPage.Text = "班級管理";
            this._classManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // comingSoonLabel
            // 
            this._comingSoonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comingSoonLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._comingSoonLabel.Location = new System.Drawing.Point(3, 3);
            this._comingSoonLabel.Name = "comingSoonLabel";
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
        private System.Windows.Forms.Button _addCourseButton;
        private System.Windows.Forms.ListBox _courseListBox;
        private System.Windows.Forms.Button _saveCourseDataButton;
        private System.Windows.Forms.GroupBox _classDataGroupBox;
        private System.Windows.Forms.TextBox _courseNameTextBox;
        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.TextBox _courseNumberTextBox;
        private System.Windows.Forms.Label _courseNumberLabel;
        private System.Windows.Forms.DataGridView _classTimeDataGridView;
        private System.Windows.Forms.ComboBox _courseSelectionComboBox;
        private System.Windows.Forms.Label _courseSelectionLabel;
        private System.Windows.Forms.ComboBox _classTimeSelectionComboBox;
        private System.Windows.Forms.Label _classTimeSelectionLabel;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.Label _noteLabel;
        private System.Windows.Forms.TextBox _languageTextBox;
        private System.Windows.Forms.Label _languageLabel;
        private System.Windows.Forms.TextBox _teachingAssistantTextBox;
        private System.Windows.Forms.Label _teachingAssistantLabel;
        private System.Windows.Forms.ComboBox _courseTypeSelectionComboBox;
        private System.Windows.Forms.Label _courseTypeSelectionLabel;
        private System.Windows.Forms.TextBox _teacherTextBox;
        private System.Windows.Forms.Label _teacherLabel;
        private System.Windows.Forms.TextBox _creditTextBox;
        private System.Windows.Forms.Label _creditLabel;
        private System.Windows.Forms.TextBox _stageTextBox;
        private System.Windows.Forms.Label _stageLabel;
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