using System.Collections.Generic;

namespace CourseSystem
{
    partial class CourseSelectingForm
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
            this._submitButton = new System.Windows.Forms.Button();
            this._checkButton = new System.Windows.Forms.Button();
            this._selectingTabControl = new System.Windows.Forms.TabControl();
            this._computerScience3TabPage = new System.Windows.Forms.TabPage();
            this._computerScience3DataGridView = new System.Windows.Forms.DataGridView();
            this._computerScience3CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._computerScience3Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3CourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3ClassTime6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3NumberOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3NumberOfDropStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3TeachingAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Outline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3attachStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._computerScience3Experiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineer3TabPage = new System.Windows.Forms.TabPage();
            this._electronicEngineering3DataGridView = new System.Windows.Forms.DataGridView();
            this._electronicEngineering3CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._electronicEngineering3Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3CourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3ClassTime6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3NumberOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3NumberOfDropStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3TeachingAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Outline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3AttachStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3Experiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._selectingTabControl.SuspendLayout();
            this._computerScience3TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._computerScience3DataGridView)).BeginInit();
            this._electronicEngineer3TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._electronicEngineering3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _submitButton
            // 
            this._submitButton.Enabled = false;
            this._submitButton.Location = new System.Drawing.Point(651, 552);
            this._submitButton.Margin = new System.Windows.Forms.Padding(4);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(261, 105);
            this._submitButton.TabIndex = 1;
            this._submitButton.Text = "確認送出";
            this._submitButton.UseVisualStyleBackColor = true;
            this._submitButton.Click += new System.EventHandler(this.ClickSubmitButton);
            // 
            // _checkButton
            // 
            this._checkButton.Location = new System.Drawing.Point(921, 552);
            this._checkButton.Margin = new System.Windows.Forms.Padding(4);
            this._checkButton.Name = "_checkButton";
            this._checkButton.Size = new System.Drawing.Size(261, 105);
            this._checkButton.TabIndex = 2;
            this._checkButton.Text = "查看選課結果";
            this._checkButton.UseVisualStyleBackColor = true;
            this._checkButton.Click += new System.EventHandler(this.ClickCheckButton);
            // 
            // _courseTabControl
            // 
            this._selectingTabControl.Controls.Add(this._computerScience3TabPage);
            this._selectingTabControl.Controls.Add(this._electronicEngineer3TabPage);
            this._selectingTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._selectingTabControl.Location = new System.Drawing.Point(0, 0);
            this._selectingTabControl.Margin = new System.Windows.Forms.Padding(4);
            this._selectingTabControl.Name = "_courseTabControl";
            this._selectingTabControl.SelectedIndex = 0;
            this._selectingTabControl.Size = new System.Drawing.Size(1200, 543);
            this._selectingTabControl.TabIndex = 3;
            // 
            // _computerScience3TabPage
            // 
            this._computerScience3TabPage.Controls.Add(this._computerScience3DataGridView);
            this._computerScience3TabPage.Location = new System.Drawing.Point(4, 28);
            this._computerScience3TabPage.Margin = new System.Windows.Forms.Padding(4);
            this._computerScience3TabPage.Name = "_computerScience3TabPage";
            this._computerScience3TabPage.Padding = new System.Windows.Forms.Padding(4);
            this._computerScience3TabPage.Size = new System.Drawing.Size(1192, 511);
            this._computerScience3TabPage.TabIndex = 0;
            this._computerScience3TabPage.Text = "資工三";
            this._computerScience3TabPage.UseVisualStyleBackColor = true;
            // 
            // _computerScience3DataGridView
            // 
            this._computerScience3DataGridView.AllowUserToAddRows = false;
            this._computerScience3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._computerScience3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._computerScience3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._computerScience3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._computerScience3CheckBoxColumn,
            this._computerScience3Number,
            this._computerScience3Name,
            this._computerScience3Stage,
            this._computerScience3Credit,
            this._computerScience3Hour,
            this._computerScience3CourseType,
            this._computerScience3Teacher,
            this._computerScience3ClassTime0,
            this._computerScience3ClassTime1,
            this._computerScience3ClassTime2,
            this._computerScience3ClassTime3,
            this._computerScience3ClassTime4,
            this._computerScience3ClassTime5,
            this._computerScience3ClassTime6,
            this._computerScience3Classroom,
            this._computerScience3NumberOfStudent,
            this._computerScience3NumberOfDropStudent,
            this._computerScience3TeachingAssistant,
            this._computerScience3Language,
            this._computerScience3Outline,
            this._computerScience3Note,
            this._computerScience3attachStudent,
            this._computerScience3Experiment});
            this._computerScience3DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._computerScience3DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this._computerScience3DataGridView.Location = new System.Drawing.Point(4, 4);
            this._computerScience3DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._computerScience3DataGridView.Name = "_computerScience3DataGridView";
            this._computerScience3DataGridView.ReadOnly = true;
            this._computerScience3DataGridView.RowHeadersVisible = false;
            this._computerScience3DataGridView.RowHeadersWidth = 62;
            this._computerScience3DataGridView.RowTemplate.Height = 24;
            this._computerScience3DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._computerScience3DataGridView.Size = new System.Drawing.Size(1184, 503);
            this._computerScience3DataGridView.TabIndex = 1;
            this._computerScience3DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellComputerScienceThirdDataGridView);
            this._computerScience3DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangedCellValueAllDataGridView);
            // 
            // _computerScience3CheckBoxColumn
            // 
            this._computerScience3CheckBoxColumn.HeaderText = "選";
            this._computerScience3CheckBoxColumn.MinimumWidth = 8;
            this._computerScience3CheckBoxColumn.Name = "_computerScience3CheckBoxColumn";
            this._computerScience3CheckBoxColumn.ReadOnly = true;
            this._computerScience3CheckBoxColumn.Width = 32;
            // 
            // _computerScience3Number
            // 
            this._computerScience3Number.DataPropertyName = "number";
            this._computerScience3Number.HeaderText = "課號";
            this._computerScience3Number.MinimumWidth = 8;
            this._computerScience3Number.Name = "_computerScience3Number";
            this._computerScience3Number.ReadOnly = true;
            this._computerScience3Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Number.Width = 45;
            // 
            // _computerScience3Name
            // 
            this._computerScience3Name.DataPropertyName = "name";
            this._computerScience3Name.HeaderText = "課程名稱";
            this._computerScience3Name.MinimumWidth = 8;
            this._computerScience3Name.Name = "_computerScience3Name";
            this._computerScience3Name.ReadOnly = true;
            this._computerScience3Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Name.Width = 61;
            // 
            // _computerScience3Stage
            // 
            this._computerScience3Stage.DataPropertyName = "stage";
            this._computerScience3Stage.HeaderText = "階段";
            this._computerScience3Stage.MinimumWidth = 8;
            this._computerScience3Stage.Name = "_computerScience3Stage";
            this._computerScience3Stage.ReadOnly = true;
            this._computerScience3Stage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Stage.Width = 45;
            // 
            // _computerScience3Credit
            // 
            this._computerScience3Credit.DataPropertyName = "credit";
            this._computerScience3Credit.HeaderText = "學分";
            this._computerScience3Credit.MinimumWidth = 8;
            this._computerScience3Credit.Name = "_computerScience3Credit";
            this._computerScience3Credit.ReadOnly = true;
            this._computerScience3Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Credit.Width = 45;
            // 
            // _computerScience3Hour
            // 
            this._computerScience3Hour.DataPropertyName = "hour";
            this._computerScience3Hour.HeaderText = "時數";
            this._computerScience3Hour.MinimumWidth = 8;
            this._computerScience3Hour.Name = "_computerScience3Hour";
            this._computerScience3Hour.ReadOnly = true;
            this._computerScience3Hour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Hour.Width = 45;
            // 
            // _computerScience3CourseType
            // 
            this._computerScience3CourseType.DataPropertyName = "courseType";
            this._computerScience3CourseType.HeaderText = "修";
            this._computerScience3CourseType.MinimumWidth = 8;
            this._computerScience3CourseType.Name = "_computerScience3CourseType";
            this._computerScience3CourseType.ReadOnly = true;
            this._computerScience3CourseType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3CourseType.Width = 32;
            // 
            // _computerScience3Teacher
            // 
            this._computerScience3Teacher.DataPropertyName = "teacher";
            this._computerScience3Teacher.HeaderText = "老師";
            this._computerScience3Teacher.MinimumWidth = 8;
            this._computerScience3Teacher.Name = "_computerScience3Teacher";
            this._computerScience3Teacher.ReadOnly = true;
            this._computerScience3Teacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Teacher.Width = 45;
            // 
            // _computerScience3ClassTime0
            // 
            this._computerScience3ClassTime0.DataPropertyName = "classTime0";
            this._computerScience3ClassTime0.HeaderText = "日";
            this._computerScience3ClassTime0.MinimumWidth = 8;
            this._computerScience3ClassTime0.Name = "_computerScience3ClassTime0";
            this._computerScience3ClassTime0.ReadOnly = true;
            this._computerScience3ClassTime0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime0.Width = 32;
            // 
            // _computerScience3ClassTime1
            // 
            this._computerScience3ClassTime1.DataPropertyName = "classTime1";
            this._computerScience3ClassTime1.HeaderText = "一";
            this._computerScience3ClassTime1.MinimumWidth = 8;
            this._computerScience3ClassTime1.Name = "_computerScience3ClassTime1";
            this._computerScience3ClassTime1.ReadOnly = true;
            this._computerScience3ClassTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime1.Width = 32;
            // 
            // _computerScience3ClassTime2
            // 
            this._computerScience3ClassTime2.DataPropertyName = "classTime2";
            this._computerScience3ClassTime2.HeaderText = "二";
            this._computerScience3ClassTime2.MinimumWidth = 8;
            this._computerScience3ClassTime2.Name = "_computerScience3ClassTime2";
            this._computerScience3ClassTime2.ReadOnly = true;
            this._computerScience3ClassTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime2.Width = 32;
            // 
            // _computerScience3ClassTime3
            // 
            this._computerScience3ClassTime3.DataPropertyName = "classTime3";
            this._computerScience3ClassTime3.HeaderText = "三";
            this._computerScience3ClassTime3.MinimumWidth = 8;
            this._computerScience3ClassTime3.Name = "_computerScience3ClassTime3";
            this._computerScience3ClassTime3.ReadOnly = true;
            this._computerScience3ClassTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime3.Width = 32;
            // 
            // _computerScience3ClassTime4
            // 
            this._computerScience3ClassTime4.DataPropertyName = "classTime4";
            this._computerScience3ClassTime4.HeaderText = "四";
            this._computerScience3ClassTime4.MinimumWidth = 8;
            this._computerScience3ClassTime4.Name = "_computerScience3ClassTime4";
            this._computerScience3ClassTime4.ReadOnly = true;
            this._computerScience3ClassTime4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime4.Width = 32;
            // 
            // _computerScience3ClassTime5
            // 
            this._computerScience3ClassTime5.DataPropertyName = "classTime5";
            this._computerScience3ClassTime5.HeaderText = "五";
            this._computerScience3ClassTime5.MinimumWidth = 8;
            this._computerScience3ClassTime5.Name = "_computerScience3ClassTime5";
            this._computerScience3ClassTime5.ReadOnly = true;
            this._computerScience3ClassTime5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime5.Width = 32;
            // 
            // _computerScience3ClassTime6
            // 
            this._computerScience3ClassTime6.DataPropertyName = "classTime6";
            this._computerScience3ClassTime6.HeaderText = "六";
            this._computerScience3ClassTime6.MinimumWidth = 8;
            this._computerScience3ClassTime6.Name = "_computerScience3ClassTime6";
            this._computerScience3ClassTime6.ReadOnly = true;
            this._computerScience3ClassTime6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3ClassTime6.Width = 32;
            // 
            // _computerScience3Classroom
            // 
            this._computerScience3Classroom.DataPropertyName = "classroom";
            this._computerScience3Classroom.HeaderText = "教室";
            this._computerScience3Classroom.MinimumWidth = 8;
            this._computerScience3Classroom.Name = "_computerScience3Classroom";
            this._computerScience3Classroom.ReadOnly = true;
            this._computerScience3Classroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Classroom.Width = 45;
            // 
            // _computerScience3NumberOfStudent
            // 
            this._computerScience3NumberOfStudent.DataPropertyName = "numberOfStudent";
            this._computerScience3NumberOfStudent.HeaderText = "人";
            this._computerScience3NumberOfStudent.MinimumWidth = 8;
            this._computerScience3NumberOfStudent.Name = "_computerScience3NumberOfStudent";
            this._computerScience3NumberOfStudent.ReadOnly = true;
            this._computerScience3NumberOfStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3NumberOfStudent.Width = 32;
            // 
            // _computerScience3NumberOfDropStudent
            // 
            this._computerScience3NumberOfDropStudent.DataPropertyName = "numberOfDropStudent";
            this._computerScience3NumberOfDropStudent.HeaderText = "撤";
            this._computerScience3NumberOfDropStudent.MinimumWidth = 8;
            this._computerScience3NumberOfDropStudent.Name = "_computerScience3NumberOfDropStudent";
            this._computerScience3NumberOfDropStudent.ReadOnly = true;
            this._computerScience3NumberOfDropStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3NumberOfDropStudent.Width = 32;
            // 
            // _computerScience3TeachingAssistant
            // 
            this._computerScience3TeachingAssistant.DataPropertyName = "teachingAssistant";
            this._computerScience3TeachingAssistant.HeaderText = "教學助理";
            this._computerScience3TeachingAssistant.MinimumWidth = 8;
            this._computerScience3TeachingAssistant.Name = "_computerScience3TeachingAssistant";
            this._computerScience3TeachingAssistant.ReadOnly = true;
            this._computerScience3TeachingAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3TeachingAssistant.Width = 61;
            // 
            // _computerScience3Language
            // 
            this._computerScience3Language.DataPropertyName = "language";
            this._computerScience3Language.HeaderText = "授課語言";
            this._computerScience3Language.MinimumWidth = 8;
            this._computerScience3Language.Name = "_computerScience3Language";
            this._computerScience3Language.ReadOnly = true;
            this._computerScience3Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Language.Width = 61;
            // 
            // _computerScience3Outline
            // 
            this._computerScience3Outline.DataPropertyName = "outline";
            this._computerScience3Outline.HeaderText = "教學大綱與進度表";
            this._computerScience3Outline.MinimumWidth = 8;
            this._computerScience3Outline.Name = "_computerScience3Outline";
            this._computerScience3Outline.ReadOnly = true;
            this._computerScience3Outline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Outline.Width = 94;
            // 
            // _computerScience3Note
            // 
            this._computerScience3Note.DataPropertyName = "note";
            this._computerScience3Note.HeaderText = "備註";
            this._computerScience3Note.MinimumWidth = 8;
            this._computerScience3Note.Name = "_computerScience3Note";
            this._computerScience3Note.ReadOnly = true;
            this._computerScience3Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Note.Width = 45;
            // 
            // _computerScience3ttachStudent
            // 
            this._computerScience3attachStudent.DataPropertyName = "attachStudent";
            this._computerScience3attachStudent.HeaderText = "隨班附讀";
            this._computerScience3attachStudent.MinimumWidth = 8;
            this._computerScience3attachStudent.Name = "_computerScience3ttachStudent";
            this._computerScience3attachStudent.ReadOnly = true;
            this._computerScience3attachStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3attachStudent.Width = 61;
            // 
            // _computerScience3Experiment
            // 
            this._computerScience3Experiment.DataPropertyName = "experiment";
            this._computerScience3Experiment.HeaderText = "實驗實習";
            this._computerScience3Experiment.MinimumWidth = 8;
            this._computerScience3Experiment.Name = "_computerScience3Experiment";
            this._computerScience3Experiment.ReadOnly = true;
            this._computerScience3Experiment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._computerScience3Experiment.Width = 61;
            // 
            // _electronicEngineer3TabPage
            // 
            this._electronicEngineer3TabPage.Controls.Add(this._electronicEngineering3DataGridView);
            this._electronicEngineer3TabPage.Location = new System.Drawing.Point(4, 28);
            this._electronicEngineer3TabPage.Margin = new System.Windows.Forms.Padding(4);
            this._electronicEngineer3TabPage.Name = "_electronicEngineer3TabPage";
            this._electronicEngineer3TabPage.Padding = new System.Windows.Forms.Padding(4);
            this._electronicEngineer3TabPage.Size = new System.Drawing.Size(1192, 511);
            this._electronicEngineer3TabPage.TabIndex = 1;
            this._electronicEngineer3TabPage.Text = "電子三甲";
            this._electronicEngineer3TabPage.UseVisualStyleBackColor = true;
            // 
            // _electronicEngineering3DataGridView
            // 
            this._electronicEngineering3DataGridView.AllowUserToAddRows = false;
            this._electronicEngineering3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._electronicEngineering3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._electronicEngineering3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._electronicEngineering3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._electronicEngineering3CheckBoxColumn,
            this._electronicEngineering3Number,
            this._electronicEngineering3Name,
            this._electronicEngineering3Stage,
            this._electronicEngineering3Credit,
            this._electronicEngineering3Hour,
            this._electronicEngineering3CourseType,
            this._electronicEngineering3Teacher,
            this._electronicEngineering3ClassTime0,
            this._electronicEngineering3ClassTime1,
            this._electronicEngineering3ClassTime2,
            this._electronicEngineering3ClassTime3,
            this._electronicEngineering3ClassTime4,
            this._electronicEngineering3ClassTime5,
            this._electronicEngineering3ClassTime6,
            this._electronicEngineering3Classroom,
            this._electronicEngineering3NumberOfStudent,
            this._electronicEngineering3NumberOfDropStudent,
            this._electronicEngineering3TeachingAssistant,
            this._electronicEngineering3Language,
            this._electronicEngineering3Outline,
            this._electronicEngineering3Note,
            this._electronicEngineering3AttachStudent,
            this._electronicEngineering3Experiment});
            this._electronicEngineering3DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._electronicEngineering3DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this._electronicEngineering3DataGridView.Location = new System.Drawing.Point(4, 4);
            this._electronicEngineering3DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._electronicEngineering3DataGridView.Name = "_electronicEngineering3DataGridView";
            this._electronicEngineering3DataGridView.ReadOnly = true;
            this._electronicEngineering3DataGridView.RowHeadersVisible = false;
            this._electronicEngineering3DataGridView.RowHeadersWidth = 62;
            this._electronicEngineering3DataGridView.RowTemplate.Height = 24;
            this._electronicEngineering3DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._electronicEngineering3DataGridView.Size = new System.Drawing.Size(1184, 503);
            this._electronicEngineering3DataGridView.TabIndex = 2;
            this._electronicEngineering3DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellElectronicEngineeringThirdOneDataGridView);
            this._electronicEngineering3DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangedCellValueAllDataGridView);
            // 
            // _electronicEngineering3CheckBoxColumn
            // 
            this._electronicEngineering3CheckBoxColumn.HeaderText = "選";
            this._electronicEngineering3CheckBoxColumn.MinimumWidth = 8;
            this._electronicEngineering3CheckBoxColumn.Name = "_electronicEngineering3CheckBoxColumn";
            this._electronicEngineering3CheckBoxColumn.ReadOnly = true;
            this._electronicEngineering3CheckBoxColumn.Width = 32;
            // 
            // _electronicEngineering3Number
            // 
            this._electronicEngineering3Number.DataPropertyName = "number";
            this._electronicEngineering3Number.HeaderText = "課號";
            this._electronicEngineering3Number.MinimumWidth = 8;
            this._electronicEngineering3Number.Name = "_electronicEngineering3Number";
            this._electronicEngineering3Number.ReadOnly = true;
            this._electronicEngineering3Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Number.Width = 45;
            // 
            // _electronicEngineering3Name
            // 
            this._electronicEngineering3Name.DataPropertyName = "name";
            this._electronicEngineering3Name.HeaderText = "課程名稱";
            this._electronicEngineering3Name.MinimumWidth = 8;
            this._electronicEngineering3Name.Name = "_electronicEngineering3Name";
            this._electronicEngineering3Name.ReadOnly = true;
            this._electronicEngineering3Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Name.Width = 61;
            // 
            // _electronicEngineering3Stage
            // 
            this._electronicEngineering3Stage.DataPropertyName = "stage";
            this._electronicEngineering3Stage.HeaderText = "階段";
            this._electronicEngineering3Stage.MinimumWidth = 8;
            this._electronicEngineering3Stage.Name = "_electronicEngineering3Stage";
            this._electronicEngineering3Stage.ReadOnly = true;
            this._electronicEngineering3Stage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Stage.Width = 45;
            // 
            // _electronicEngineering3Credit
            // 
            this._electronicEngineering3Credit.DataPropertyName = "credit";
            this._electronicEngineering3Credit.HeaderText = "學分";
            this._electronicEngineering3Credit.MinimumWidth = 8;
            this._electronicEngineering3Credit.Name = "_electronicEngineering3Credit";
            this._electronicEngineering3Credit.ReadOnly = true;
            this._electronicEngineering3Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Credit.Width = 45;
            // 
            // _electronicEngineering3Hour
            // 
            this._electronicEngineering3Hour.DataPropertyName = "hour";
            this._electronicEngineering3Hour.HeaderText = "時數";
            this._electronicEngineering3Hour.MinimumWidth = 8;
            this._electronicEngineering3Hour.Name = "_electronicEngineering3Hour";
            this._electronicEngineering3Hour.ReadOnly = true;
            this._electronicEngineering3Hour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Hour.Width = 45;
            // 
            // _electronicEngineering3CourseType
            // 
            this._electronicEngineering3CourseType.DataPropertyName = "courseType";
            this._electronicEngineering3CourseType.HeaderText = "修";
            this._electronicEngineering3CourseType.MinimumWidth = 8;
            this._electronicEngineering3CourseType.Name = "_electronicEngineering3CourseType";
            this._electronicEngineering3CourseType.ReadOnly = true;
            this._electronicEngineering3CourseType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3CourseType.Width = 32;
            // 
            // _electronicEngineering3Teacher
            // 
            this._electronicEngineering3Teacher.DataPropertyName = "teacher";
            this._electronicEngineering3Teacher.HeaderText = "老師";
            this._electronicEngineering3Teacher.MinimumWidth = 8;
            this._electronicEngineering3Teacher.Name = "_electronicEngineering3Teacher";
            this._electronicEngineering3Teacher.ReadOnly = true;
            this._electronicEngineering3Teacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Teacher.Width = 45;
            // 
            // _electronicEngineering3ClassTime0
            // 
            this._electronicEngineering3ClassTime0.DataPropertyName = "classTime0";
            this._electronicEngineering3ClassTime0.HeaderText = "日";
            this._electronicEngineering3ClassTime0.MinimumWidth = 8;
            this._electronicEngineering3ClassTime0.Name = "_electronicEngineering3ClassTime0";
            this._electronicEngineering3ClassTime0.ReadOnly = true;
            this._electronicEngineering3ClassTime0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime0.Width = 32;
            // 
            // _electronicEngineering3ClassTime1
            // 
            this._electronicEngineering3ClassTime1.DataPropertyName = "classTime1";
            this._electronicEngineering3ClassTime1.HeaderText = "一";
            this._electronicEngineering3ClassTime1.MinimumWidth = 8;
            this._electronicEngineering3ClassTime1.Name = "_electronicEngineering3ClassTime1";
            this._electronicEngineering3ClassTime1.ReadOnly = true;
            this._electronicEngineering3ClassTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime1.Width = 32;
            // 
            // _electronicEngineering3ClassTime2
            // 
            this._electronicEngineering3ClassTime2.DataPropertyName = "classTime2";
            this._electronicEngineering3ClassTime2.HeaderText = "二";
            this._electronicEngineering3ClassTime2.MinimumWidth = 8;
            this._electronicEngineering3ClassTime2.Name = "_electronicEngineering3ClassTime2";
            this._electronicEngineering3ClassTime2.ReadOnly = true;
            this._electronicEngineering3ClassTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime2.Width = 32;
            // 
            // _electronicEngineering3ClassTime3
            // 
            this._electronicEngineering3ClassTime3.DataPropertyName = "classTime3";
            this._electronicEngineering3ClassTime3.HeaderText = "三";
            this._electronicEngineering3ClassTime3.MinimumWidth = 8;
            this._electronicEngineering3ClassTime3.Name = "_electronicEngineering3ClassTime3";
            this._electronicEngineering3ClassTime3.ReadOnly = true;
            this._electronicEngineering3ClassTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime3.Width = 32;
            // 
            // _electronicEngineering3ClassTime4
            // 
            this._electronicEngineering3ClassTime4.DataPropertyName = "classTime4";
            this._electronicEngineering3ClassTime4.HeaderText = "四";
            this._electronicEngineering3ClassTime4.MinimumWidth = 8;
            this._electronicEngineering3ClassTime4.Name = "_electronicEngineering3ClassTime4";
            this._electronicEngineering3ClassTime4.ReadOnly = true;
            this._electronicEngineering3ClassTime4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime4.Width = 32;
            // 
            // _electronicEngineering3ClassTime5
            // 
            this._electronicEngineering3ClassTime5.DataPropertyName = "classTime5";
            this._electronicEngineering3ClassTime5.HeaderText = "五";
            this._electronicEngineering3ClassTime5.MinimumWidth = 8;
            this._electronicEngineering3ClassTime5.Name = "_electronicEngineering3ClassTime5";
            this._electronicEngineering3ClassTime5.ReadOnly = true;
            this._electronicEngineering3ClassTime5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime5.Width = 32;
            // 
            // _electronicEngineering3ClassTime6
            // 
            this._electronicEngineering3ClassTime6.DataPropertyName = "classTime6";
            this._electronicEngineering3ClassTime6.HeaderText = "六";
            this._electronicEngineering3ClassTime6.MinimumWidth = 8;
            this._electronicEngineering3ClassTime6.Name = "_electronicEngineering3ClassTime6";
            this._electronicEngineering3ClassTime6.ReadOnly = true;
            this._electronicEngineering3ClassTime6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3ClassTime6.Width = 32;
            // 
            // _electronicEngineering3Classroom
            // 
            this._electronicEngineering3Classroom.DataPropertyName = "classroom";
            this._electronicEngineering3Classroom.HeaderText = "教室";
            this._electronicEngineering3Classroom.MinimumWidth = 8;
            this._electronicEngineering3Classroom.Name = "_electronicEngineering3Classroom";
            this._electronicEngineering3Classroom.ReadOnly = true;
            this._electronicEngineering3Classroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Classroom.Width = 45;
            // 
            // _electronicEngineering3NumberOfStudent
            // 
            this._electronicEngineering3NumberOfStudent.DataPropertyName = "numberOfStudent";
            this._electronicEngineering3NumberOfStudent.HeaderText = "人";
            this._electronicEngineering3NumberOfStudent.MinimumWidth = 8;
            this._electronicEngineering3NumberOfStudent.Name = "_electronicEngineering3NumberOfStudent";
            this._electronicEngineering3NumberOfStudent.ReadOnly = true;
            this._electronicEngineering3NumberOfStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3NumberOfStudent.Width = 32;
            // 
            // _electronicEngineering3NumberOfDropStudent
            // 
            this._electronicEngineering3NumberOfDropStudent.DataPropertyName = "numberOfDropStudent";
            this._electronicEngineering3NumberOfDropStudent.HeaderText = "撤";
            this._electronicEngineering3NumberOfDropStudent.MinimumWidth = 8;
            this._electronicEngineering3NumberOfDropStudent.Name = "_electronicEngineering3NumberOfDropStudent";
            this._electronicEngineering3NumberOfDropStudent.ReadOnly = true;
            this._electronicEngineering3NumberOfDropStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3NumberOfDropStudent.Width = 32;
            // 
            // _electronicEngineering3TeachingAssistant
            // 
            this._electronicEngineering3TeachingAssistant.DataPropertyName = "teachingAssistant";
            this._electronicEngineering3TeachingAssistant.HeaderText = "教學助理";
            this._electronicEngineering3TeachingAssistant.MinimumWidth = 8;
            this._electronicEngineering3TeachingAssistant.Name = "_electronicEngineering3TeachingAssistant";
            this._electronicEngineering3TeachingAssistant.ReadOnly = true;
            this._electronicEngineering3TeachingAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3TeachingAssistant.Width = 61;
            // 
            // _electronicEngineering3Language
            // 
            this._electronicEngineering3Language.DataPropertyName = "language";
            this._electronicEngineering3Language.HeaderText = "授課語言";
            this._electronicEngineering3Language.MinimumWidth = 8;
            this._electronicEngineering3Language.Name = "_electronicEngineering3Language";
            this._electronicEngineering3Language.ReadOnly = true;
            this._electronicEngineering3Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Language.Width = 61;
            // 
            // _electronicEngineering3Outline
            // 
            this._electronicEngineering3Outline.DataPropertyName = "outline";
            this._electronicEngineering3Outline.HeaderText = "教學大綱與進度表";
            this._electronicEngineering3Outline.MinimumWidth = 8;
            this._electronicEngineering3Outline.Name = "_electronicEngineering3Outline";
            this._electronicEngineering3Outline.ReadOnly = true;
            this._electronicEngineering3Outline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Outline.Width = 94;
            // 
            // _electronicEngineering3Note
            // 
            this._electronicEngineering3Note.DataPropertyName = "note";
            this._electronicEngineering3Note.HeaderText = "備註";
            this._electronicEngineering3Note.MinimumWidth = 8;
            this._electronicEngineering3Note.Name = "_electronicEngineering3Note";
            this._electronicEngineering3Note.ReadOnly = true;
            this._electronicEngineering3Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Note.Width = 45;
            // 
            // _electronicEngineering3AttachStudent
            // 
            this._electronicEngineering3AttachStudent.DataPropertyName = "attachStudent";
            this._electronicEngineering3AttachStudent.HeaderText = "隨班附讀";
            this._electronicEngineering3AttachStudent.MinimumWidth = 8;
            this._electronicEngineering3AttachStudent.Name = "_electronicEngineering3AttachStudent";
            this._electronicEngineering3AttachStudent.ReadOnly = true;
            this._electronicEngineering3AttachStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3AttachStudent.Width = 61;
            // 
            // _electronicEngineering3Experiment
            // 
            this._electronicEngineering3Experiment.DataPropertyName = "experiment";
            this._electronicEngineering3Experiment.HeaderText = "實驗實習";
            this._electronicEngineering3Experiment.MinimumWidth = 8;
            this._electronicEngineering3Experiment.Name = "_electronicEngineering3Experiment";
            this._electronicEngineering3Experiment.ReadOnly = true;
            this._electronicEngineering3Experiment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._electronicEngineering3Experiment.Width = 61;
            // 
            // CourseSelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this._selectingTabControl);
            this.Controls.Add(this._checkButton);
            this.Controls.Add(this._submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseSelectingForm";
            this.Text = "選課";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCourseSelectingForm);
            this.Load += new System.EventHandler(this.LoadSelectCourseForm);
            this._selectingTabControl.ResumeLayout(false);
            this._computerScience3TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._computerScience3DataGridView)).EndInit();
            this._electronicEngineer3TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._electronicEngineering3DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.Button _checkButton;
        private System.Windows.Forms.TabControl _selectingTabControl;
        private System.Windows.Forms.TabPage _computerScience3TabPage;
        private System.Windows.Forms.DataGridView _computerScience3DataGridView;
        private System.Windows.Forms.TabPage _electronicEngineer3TabPage;
        private System.Windows.Forms.DataGridView _electronicEngineering3DataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _computerScience3CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3CourseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime0;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3ClassTime6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3NumberOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3NumberOfDropStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3TeachingAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Outline;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3attachStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _computerScience3Experiment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _electronicEngineering3CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3CourseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime0;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3ClassTime6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3NumberOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3NumberOfDropStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3TeachingAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Outline;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3AttachStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _electronicEngineering3Experiment;
    }
}

