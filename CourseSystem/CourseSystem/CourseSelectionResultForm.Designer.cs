
namespace CourseSystem
{
    partial class CourseSelectionResultForm
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
            this._courseResultDataGridView = new System.Windows.Forms.DataGridView();
            this._courseResultButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._courseResultNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultCourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassTime6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultNumberOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultNumberOfDropStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultTeachingAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultOutline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultAttachStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseResultExperiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._courseResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseResultDataGridView
            // 
            this._courseResultDataGridView.AllowUserToAddRows = false;
            this._courseResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._courseResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._courseResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._courseResultButtonColumn,
            this._courseResultNumber,
            this._courseResultName,
            this._courseResultStage,
            this._courseResultCredit,
            this._courseResultHour,
            this._courseResultCourseType,
            this._courseResultTeacher,
            this._courseResultClassTime0,
            this._courseResultClassTime1,
            this._courseResultClassTime2,
            this._courseResultClassTime3,
            this._courseResultClassTime4,
            this._courseResultClassTime5,
            this._courseResultClassTime6,
            this._courseResultClassroom,
            this._courseResultNumberOfStudent,
            this._courseResultNumberOfDropStudent,
            this._courseResultTeachingAssistant,
            this._courseResultLanguage,
            this._courseResultOutline,
            this._courseResultNote,
            this._courseResultAttachStudent,
            this._courseResultExperiment});
            this._courseResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseResultDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this._courseResultDataGridView.Location = new System.Drawing.Point(0, 0);
            this._courseResultDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._courseResultDataGridView.Name = "_courseResultDataGridView";
            this._courseResultDataGridView.ReadOnly = true;
            this._courseResultDataGridView.RowHeadersVisible = false;
            this._courseResultDataGridView.RowHeadersWidth = 62;
            this._courseResultDataGridView.RowTemplate.Height = 24;
            this._courseResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseResultDataGridView.Size = new System.Drawing.Size(1200, 675);
            this._courseResultDataGridView.TabIndex = 2;
            this._courseResultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContentCourseResultDataGridView);
            // 
            // _courseResultButtonColumn
            // 
            this._courseResultButtonColumn.HeaderText = "退";
            this._courseResultButtonColumn.MinimumWidth = 8;
            this._courseResultButtonColumn.Name = "_courseResultButtonColumn";
            this._courseResultButtonColumn.ReadOnly = true;
            this._courseResultButtonColumn.Text = "退選";
            this._courseResultButtonColumn.Width = 32;
            // 
            // _courseResultNumber
            // 
            this._courseResultNumber.DataPropertyName = "number";
            this._courseResultNumber.HeaderText = "課號";
            this._courseResultNumber.MinimumWidth = 8;
            this._courseResultNumber.Name = "_courseResultNumber";
            this._courseResultNumber.ReadOnly = true;
            this._courseResultNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultNumber.Width = 45;
            // 
            // _courseResultName
            // 
            this._courseResultName.DataPropertyName = "name";
            this._courseResultName.HeaderText = "課程名稱";
            this._courseResultName.MinimumWidth = 8;
            this._courseResultName.Name = "_courseResultName";
            this._courseResultName.ReadOnly = true;
            this._courseResultName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultName.Width = 61;
            // 
            // _courseResultStage
            // 
            this._courseResultStage.DataPropertyName = "stage";
            this._courseResultStage.HeaderText = "階段";
            this._courseResultStage.MinimumWidth = 8;
            this._courseResultStage.Name = "_courseResultStage";
            this._courseResultStage.ReadOnly = true;
            this._courseResultStage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultStage.Width = 45;
            // 
            // _courseResultCredit
            // 
            this._courseResultCredit.DataPropertyName = "credit";
            this._courseResultCredit.HeaderText = "學分";
            this._courseResultCredit.MinimumWidth = 8;
            this._courseResultCredit.Name = "_courseResultCredit";
            this._courseResultCredit.ReadOnly = true;
            this._courseResultCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultCredit.Width = 45;
            // 
            // _courseResultHour
            // 
            this._courseResultHour.DataPropertyName = "hour";
            this._courseResultHour.HeaderText = "時數";
            this._courseResultHour.MinimumWidth = 8;
            this._courseResultHour.Name = "_courseResultHour";
            this._courseResultHour.ReadOnly = true;
            this._courseResultHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultHour.Width = 45;
            // 
            // _courseResultCourseType
            // 
            this._courseResultCourseType.DataPropertyName = "courseType";
            this._courseResultCourseType.HeaderText = "修";
            this._courseResultCourseType.MinimumWidth = 8;
            this._courseResultCourseType.Name = "_courseResultCourseType";
            this._courseResultCourseType.ReadOnly = true;
            this._courseResultCourseType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultCourseType.Width = 32;
            // 
            // _courseResultTeacher
            // 
            this._courseResultTeacher.DataPropertyName = "teacher";
            this._courseResultTeacher.HeaderText = "老師";
            this._courseResultTeacher.MinimumWidth = 8;
            this._courseResultTeacher.Name = "_courseResultTeacher";
            this._courseResultTeacher.ReadOnly = true;
            this._courseResultTeacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultTeacher.Width = 45;
            // 
            // _courseResultClassTime0
            // 
            this._courseResultClassTime0.DataPropertyName = "classTime0";
            this._courseResultClassTime0.HeaderText = "日";
            this._courseResultClassTime0.MinimumWidth = 8;
            this._courseResultClassTime0.Name = "_courseResultClassTime0";
            this._courseResultClassTime0.ReadOnly = true;
            this._courseResultClassTime0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime0.Width = 32;
            // 
            // _courseResultClassTime1
            // 
            this._courseResultClassTime1.DataPropertyName = "classTime1";
            this._courseResultClassTime1.HeaderText = "一";
            this._courseResultClassTime1.MinimumWidth = 8;
            this._courseResultClassTime1.Name = "_courseResultClassTime1";
            this._courseResultClassTime1.ReadOnly = true;
            this._courseResultClassTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime1.Width = 32;
            // 
            // _courseResultClassTime2
            // 
            this._courseResultClassTime2.DataPropertyName = "classTime2";
            this._courseResultClassTime2.HeaderText = "二";
            this._courseResultClassTime2.MinimumWidth = 8;
            this._courseResultClassTime2.Name = "_courseResultClassTime2";
            this._courseResultClassTime2.ReadOnly = true;
            this._courseResultClassTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime2.Width = 32;
            // 
            // _courseResultClassTime3
            // 
            this._courseResultClassTime3.DataPropertyName = "classTime3";
            this._courseResultClassTime3.HeaderText = "三";
            this._courseResultClassTime3.MinimumWidth = 8;
            this._courseResultClassTime3.Name = "_courseResultClassTime3";
            this._courseResultClassTime3.ReadOnly = true;
            this._courseResultClassTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime3.Width = 32;
            // 
            // _courseResultClassTime4
            // 
            this._courseResultClassTime4.DataPropertyName = "classTime4";
            this._courseResultClassTime4.HeaderText = "四";
            this._courseResultClassTime4.MinimumWidth = 8;
            this._courseResultClassTime4.Name = "_courseResultClassTime4";
            this._courseResultClassTime4.ReadOnly = true;
            this._courseResultClassTime4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime4.Width = 32;
            // 
            // _courseResultClassTime5
            // 
            this._courseResultClassTime5.DataPropertyName = "classTime5";
            this._courseResultClassTime5.HeaderText = "五";
            this._courseResultClassTime5.MinimumWidth = 8;
            this._courseResultClassTime5.Name = "_courseResultClassTime5";
            this._courseResultClassTime5.ReadOnly = true;
            this._courseResultClassTime5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime5.Width = 32;
            // 
            // _courseResultClassTime6
            // 
            this._courseResultClassTime6.DataPropertyName = "classTime6";
            this._courseResultClassTime6.HeaderText = "六";
            this._courseResultClassTime6.MinimumWidth = 8;
            this._courseResultClassTime6.Name = "_courseResultClassTime6";
            this._courseResultClassTime6.ReadOnly = true;
            this._courseResultClassTime6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassTime6.Width = 32;
            // 
            // _courseResultClassroom
            // 
            this._courseResultClassroom.DataPropertyName = "classroom";
            this._courseResultClassroom.HeaderText = "教室";
            this._courseResultClassroom.MinimumWidth = 8;
            this._courseResultClassroom.Name = "_courseResultClassroom";
            this._courseResultClassroom.ReadOnly = true;
            this._courseResultClassroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultClassroom.Width = 45;
            // 
            // _courseResultNumberOfStudent
            // 
            this._courseResultNumberOfStudent.DataPropertyName = "numberOfStudent";
            this._courseResultNumberOfStudent.HeaderText = "人";
            this._courseResultNumberOfStudent.MinimumWidth = 8;
            this._courseResultNumberOfStudent.Name = "_courseResultNumberOfStudent";
            this._courseResultNumberOfStudent.ReadOnly = true;
            this._courseResultNumberOfStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultNumberOfStudent.Width = 32;
            // 
            // _courseResultNumberOfDropStudent
            // 
            this._courseResultNumberOfDropStudent.DataPropertyName = "numberOfDropStudent";
            this._courseResultNumberOfDropStudent.HeaderText = "撤";
            this._courseResultNumberOfDropStudent.MinimumWidth = 8;
            this._courseResultNumberOfDropStudent.Name = "_courseResultNumberOfDropStudent";
            this._courseResultNumberOfDropStudent.ReadOnly = true;
            this._courseResultNumberOfDropStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultNumberOfDropStudent.Width = 32;
            // 
            // _courseResultTeachingAssistant
            // 
            this._courseResultTeachingAssistant.DataPropertyName = "teachingAssistant";
            this._courseResultTeachingAssistant.HeaderText = "教學助理";
            this._courseResultTeachingAssistant.MinimumWidth = 8;
            this._courseResultTeachingAssistant.Name = "_courseResultTeachingAssistant";
            this._courseResultTeachingAssistant.ReadOnly = true;
            this._courseResultTeachingAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultTeachingAssistant.Width = 61;
            // 
            // _courseResultLanguage
            // 
            this._courseResultLanguage.DataPropertyName = "language";
            this._courseResultLanguage.HeaderText = "授課語言";
            this._courseResultLanguage.MinimumWidth = 8;
            this._courseResultLanguage.Name = "_courseResultLanguage";
            this._courseResultLanguage.ReadOnly = true;
            this._courseResultLanguage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultLanguage.Width = 61;
            // 
            // _courseResultOutline
            // 
            this._courseResultOutline.DataPropertyName = "outline";
            this._courseResultOutline.HeaderText = "教學大綱與進度表";
            this._courseResultOutline.MinimumWidth = 8;
            this._courseResultOutline.Name = "_courseResultOutline";
            this._courseResultOutline.ReadOnly = true;
            this._courseResultOutline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultOutline.Width = 94;
            // 
            // _courseResultNote
            // 
            this._courseResultNote.DataPropertyName = "note";
            this._courseResultNote.HeaderText = "備註";
            this._courseResultNote.MinimumWidth = 8;
            this._courseResultNote.Name = "_courseResultNote";
            this._courseResultNote.ReadOnly = true;
            this._courseResultNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultNote.Width = 45;
            // 
            // _courseResultAttachStudent
            // 
            this._courseResultAttachStudent.DataPropertyName = "attachStudent";
            this._courseResultAttachStudent.HeaderText = "隨班附讀";
            this._courseResultAttachStudent.MinimumWidth = 8;
            this._courseResultAttachStudent.Name = "_courseResultAttachStudent";
            this._courseResultAttachStudent.ReadOnly = true;
            this._courseResultAttachStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultAttachStudent.Width = 61;
            // 
            // _courseResultExperiment
            // 
            this._courseResultExperiment.DataPropertyName = "experiment";
            this._courseResultExperiment.HeaderText = "實驗實習";
            this._courseResultExperiment.MinimumWidth = 8;
            this._courseResultExperiment.Name = "_courseResultExperiment";
            this._courseResultExperiment.ReadOnly = true;
            this._courseResultExperiment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._courseResultExperiment.Width = 61;
            // 
            // CourseSelectionResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this._courseResultDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseSelectionResultForm";
            this.Text = "CourseSelectionResultForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCourseSelectionResultForm);
            this.Load += new System.EventHandler(this.LoadCourseSelectionResultForm);
            ((System.ComponentModel.ISupportInitialize)(this._courseResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseResultDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn _courseResultButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultCourseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime0;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassTime6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultNumberOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultNumberOfDropStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultTeachingAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultOutline;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultAttachStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseResultExperiment;
    }
}