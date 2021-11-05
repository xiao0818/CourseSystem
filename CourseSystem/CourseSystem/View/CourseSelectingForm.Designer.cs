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
            this._courseDataGridView = new System.Windows.Forms.DataGridView();
            this._courseCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._courseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseCourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassTime6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseNumberOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseNumberOfDropStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseTeachingAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseOutline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseAttachStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseExperiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._electronicEngineering3TabPage = new System.Windows.Forms.TabPage();
            this._selectingTabControl.SuspendLayout();
            this._computerScience3TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).BeginInit();
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
            // _selectingTabControl
            // 
            this._selectingTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._selectingTabControl.Location = new System.Drawing.Point(0, 0);
            this._selectingTabControl.Margin = new System.Windows.Forms.Padding(4);
            this._selectingTabControl.Name = "_selectingTabControl";
            this._selectingTabControl.SelectedIndex = 0;
            this._selectingTabControl.Size = new System.Drawing.Size(1200, 543);
            this._selectingTabControl.TabIndex = 3;
            this._selectingTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedSelectingTabControl);
            // 
            // _courseDataGridView
            // 
            this._courseDataGridView.AllowUserToAddRows = false;
            this._courseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._courseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._courseCheckBoxColumn,
            this._courseNumber,
            this._courseName,
            this._courseStage,
            this._courseCredit,
            this._courseHour,
            this._courseCourseType,
            this._courseTeacher,
            this._courseClassTime0,
            this._courseClassTime1,
            this._courseClassTime2,
            this._courseClassTime3,
            this._courseClassTime4,
            this._courseClassTime5,
            this._courseClassTime6,
            this._courseClassroom,
            this._courseNumberOfStudent,
            this._courseNumberOfDropStudent,
            this._courseTeachingAssistant,
            this._courseLanguage,
            this._courseOutline,
            this._courseNote,
            this._courseAttachStudent,
            this._courseExperiment});
            this._courseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this._courseDataGridView.Location = new System.Drawing.Point(4, 4);
            this._courseDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._courseDataGridView.Name = "_courseDataGridView";
            this._courseDataGridView.ReadOnly = true;
            this._courseDataGridView.RowHeadersVisible = false;
            this._courseDataGridView.RowHeadersWidth = 62;
            this._courseDataGridView.RowTemplate.Height = 24;
            this._courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseDataGridView.Size = new System.Drawing.Size(1184, 503);
            this._courseDataGridView.TabIndex = 1;
            this._courseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellDataGridView);
            this._courseDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangedCellValueAllDataGridView);
            // 
            // _courseCheckBoxColumn
            // 
            this._courseCheckBoxColumn.HeaderText = "選";
            this._courseCheckBoxColumn.MinimumWidth = 8;
            this._courseCheckBoxColumn.Name = "_courseCheckBoxColumn";
            this._courseCheckBoxColumn.ReadOnly = true;
            this._courseCheckBoxColumn.Width = 32;
            // 
            // _courseNumber
            // 
            this._courseNumber.DataPropertyName = "number";
            this._courseNumber.HeaderText = "課號";
            this._courseNumber.MinimumWidth = 8;
            this._courseNumber.Name = "_courseNumber";
            this._courseNumber.ReadOnly = true;
            this._courseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseNumber.Width = 45;
            // 
            // _courseName
            // 
            this._courseName.DataPropertyName = "name";
            this._courseName.HeaderText = "課程名稱";
            this._courseName.MinimumWidth = 8;
            this._courseName.Name = "_courseName";
            this._courseName.ReadOnly = true;
            this._courseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseName.Width = 61;
            // 
            // _courseStage
            // 
            this._courseStage.DataPropertyName = "stage";
            this._courseStage.HeaderText = "階段";
            this._courseStage.MinimumWidth = 8;
            this._courseStage.Name = "_courseStage";
            this._courseStage.ReadOnly = true;
            this._courseStage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseStage.Width = 45;
            // 
            // _courseCredit
            // 
            this._courseCredit.DataPropertyName = "credit";
            this._courseCredit.HeaderText = "學分";
            this._courseCredit.MinimumWidth = 8;
            this._courseCredit.Name = "_courseCredit";
            this._courseCredit.ReadOnly = true;
            this._courseCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseCredit.Width = 45;
            // 
            // _courseHour
            // 
            this._courseHour.DataPropertyName = "hour";
            this._courseHour.HeaderText = "時數";
            this._courseHour.MinimumWidth = 8;
            this._courseHour.Name = "_courseHour";
            this._courseHour.ReadOnly = true;
            this._courseHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseHour.Width = 45;
            // 
            // _courseCourseType
            // 
            this._courseCourseType.DataPropertyName = "courseType";
            this._courseCourseType.HeaderText = "修";
            this._courseCourseType.MinimumWidth = 8;
            this._courseCourseType.Name = "_courseCourseType";
            this._courseCourseType.ReadOnly = true;
            this._courseCourseType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseCourseType.Width = 32;
            // 
            // _courseTeacher
            // 
            this._courseTeacher.DataPropertyName = "teacher";
            this._courseTeacher.HeaderText = "老師";
            this._courseTeacher.MinimumWidth = 8;
            this._courseTeacher.Name = "_courseTeacher";
            this._courseTeacher.ReadOnly = true;
            this._courseTeacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseTeacher.Width = 45;
            // 
            // _courseClassTime0
            // 
            this._courseClassTime0.DataPropertyName = "classTime0";
            this._courseClassTime0.HeaderText = "日";
            this._courseClassTime0.MinimumWidth = 8;
            this._courseClassTime0.Name = "_courseClassTime0";
            this._courseClassTime0.ReadOnly = true;
            this._courseClassTime0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime0.Width = 32;
            // 
            // _courseClassTime1
            // 
            this._courseClassTime1.DataPropertyName = "classTime1";
            this._courseClassTime1.HeaderText = "一";
            this._courseClassTime1.MinimumWidth = 8;
            this._courseClassTime1.Name = "_courseClassTime1";
            this._courseClassTime1.ReadOnly = true;
            this._courseClassTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime1.Width = 32;
            // 
            // _courseClassTime2
            // 
            this._courseClassTime2.DataPropertyName = "classTime2";
            this._courseClassTime2.HeaderText = "二";
            this._courseClassTime2.MinimumWidth = 8;
            this._courseClassTime2.Name = "_courseClassTime2";
            this._courseClassTime2.ReadOnly = true;
            this._courseClassTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime2.Width = 32;
            // 
            // _courseClassTime3
            // 
            this._courseClassTime3.DataPropertyName = "classTime3";
            this._courseClassTime3.HeaderText = "三";
            this._courseClassTime3.MinimumWidth = 8;
            this._courseClassTime3.Name = "_courseClassTime3";
            this._courseClassTime3.ReadOnly = true;
            this._courseClassTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime3.Width = 32;
            // 
            // _courseClassTime4
            // 
            this._courseClassTime4.DataPropertyName = "classTime4";
            this._courseClassTime4.HeaderText = "四";
            this._courseClassTime4.MinimumWidth = 8;
            this._courseClassTime4.Name = "_courseClassTime4";
            this._courseClassTime4.ReadOnly = true;
            this._courseClassTime4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime4.Width = 32;
            // 
            // _courseClassTime5
            // 
            this._courseClassTime5.DataPropertyName = "classTime5";
            this._courseClassTime5.HeaderText = "五";
            this._courseClassTime5.MinimumWidth = 8;
            this._courseClassTime5.Name = "_courseClassTime5";
            this._courseClassTime5.ReadOnly = true;
            this._courseClassTime5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime5.Width = 32;
            // 
            // _courseClassTime6
            // 
            this._courseClassTime6.DataPropertyName = "classTime6";
            this._courseClassTime6.HeaderText = "六";
            this._courseClassTime6.MinimumWidth = 8;
            this._courseClassTime6.Name = "_courseClassTime6";
            this._courseClassTime6.ReadOnly = true;
            this._courseClassTime6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassTime6.Width = 32;
            // 
            // _courseClassroom
            // 
            this._courseClassroom.DataPropertyName = "classroom";
            this._courseClassroom.HeaderText = "教室";
            this._courseClassroom.MinimumWidth = 8;
            this._courseClassroom.Name = "_courseClassroom";
            this._courseClassroom.ReadOnly = true;
            this._courseClassroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseClassroom.Width = 45;
            // 
            // _courseNumberOfStudent
            // 
            this._courseNumberOfStudent.DataPropertyName = "numberOfStudent";
            this._courseNumberOfStudent.HeaderText = "人";
            this._courseNumberOfStudent.MinimumWidth = 8;
            this._courseNumberOfStudent.Name = "_courseNumberOfStudent";
            this._courseNumberOfStudent.ReadOnly = true;
            this._courseNumberOfStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseNumberOfStudent.Width = 32;
            // 
            // _courseNumberOfDropStudent
            // 
            this._courseNumberOfDropStudent.DataPropertyName = "numberOfDropStudent";
            this._courseNumberOfDropStudent.HeaderText = "撤";
            this._courseNumberOfDropStudent.MinimumWidth = 8;
            this._courseNumberOfDropStudent.Name = "_courseNumberOfDropStudent";
            this._courseNumberOfDropStudent.ReadOnly = true;
            this._courseNumberOfDropStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseNumberOfDropStudent.Width = 32;
            // 
            // _courseTeachingAssistant
            // 
            this._courseTeachingAssistant.DataPropertyName = "teachingAssistant";
            this._courseTeachingAssistant.HeaderText = "教學助理";
            this._courseTeachingAssistant.MinimumWidth = 8;
            this._courseTeachingAssistant.Name = "_courseTeachingAssistant";
            this._courseTeachingAssistant.ReadOnly = true;
            this._courseTeachingAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseTeachingAssistant.Width = 61;
            // 
            // _courseLanguage
            // 
            this._courseLanguage.DataPropertyName = "language";
            this._courseLanguage.HeaderText = "授課語言";
            this._courseLanguage.MinimumWidth = 8;
            this._courseLanguage.Name = "_courseLanguage";
            this._courseLanguage.ReadOnly = true;
            this._courseLanguage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseLanguage.Width = 61;
            // 
            // _courseOutline
            // 
            this._courseOutline.DataPropertyName = "outline";
            this._courseOutline.HeaderText = "教學大綱與進度表";
            this._courseOutline.MinimumWidth = 8;
            this._courseOutline.Name = "_courseOutline";
            this._courseOutline.ReadOnly = true;
            this._courseOutline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseOutline.Width = 94;
            // 
            // _courseNote
            // 
            this._courseNote.DataPropertyName = "note";
            this._courseNote.HeaderText = "備註";
            this._courseNote.MinimumWidth = 8;
            this._courseNote.Name = "_courseNote";
            this._courseNote.ReadOnly = true;
            this._courseNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseNote.Width = 45;
            // 
            // _courseAttachStudent
            // 
            this._courseAttachStudent.DataPropertyName = "attachStudent";
            this._courseAttachStudent.HeaderText = "隨班附讀";
            this._courseAttachStudent.MinimumWidth = 8;
            this._courseAttachStudent.Name = "_courseAttachStudent";
            this._courseAttachStudent.ReadOnly = true;
            this._courseAttachStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseAttachStudent.Width = 61;
            // 
            // _courseExperiment
            // 
            this._courseExperiment.DataPropertyName = "experiment";
            this._courseExperiment.HeaderText = "實驗實習";
            this._courseExperiment.MinimumWidth = 8;
            this._courseExperiment.Name = "_courseExperiment";
            this._courseExperiment.ReadOnly = true;
            this._courseExperiment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseExperiment.Width = 61;
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
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.Button _checkButton;
        private System.Windows.Forms.TabControl _selectingTabControl;
        private System.Windows.Forms.TabPage _computerScience3TabPage;
        private System.Windows.Forms.DataGridView _courseDataGridView;
        private System.Windows.Forms.TabPage _electronicEngineering3TabPage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _courseCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseCourseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime0;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassTime6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseNumberOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseNumberOfDropStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseTeachingAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseOutline;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseAttachStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseExperiment;
    }
}

