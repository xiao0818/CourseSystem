using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CourseSystem
{
    public partial class CourseSelectingForm : Form
    {
        int _index = 0;
        CourseSelectingFormPresentationModel _courseSelectingFormPresentationModel;
        CourseSelectionResultForm _courseSelectionResultForm;
        StartUpForm _startUpForm;
        int _classNameCount;
        const int TAB_SET = 2;
        public CourseSelectingForm(StartUpForm startUpForm, CourseSelectingFormPresentationModel courseSelectingFormPresentationModel, CourseSelectionResultFormPresentationModel courseSelectionResultFormPresentationModel)
        {
            _courseSelectingFormPresentationModel = courseSelectingFormPresentationModel;
            _courseSelectionResultForm = new CourseSelectionResultForm(this, courseSelectionResultFormPresentationModel);
            _courseSelectingFormPresentationModel._presentationModelChanged += LoadForm;
            _startUpForm = startUpForm;
            InitializeComponent();
            _courseSelectingFormPresentationModel.UpdateCourseListInfo((int)Department.ComputerScience3 / TAB_SET);
            _courseSelectingFormPresentationModel.UpdateCourseListInfo((int)Department.ElectronicEngineering3 / TAB_SET);
            _selectingTabControl.TabPages.Add(AddTabPage(_courseSelectingFormPresentationModel.GetClassNameList[(int)Department.ComputerScience3 / TAB_SET], (int)Department.ComputerScience3 / TAB_SET));
            _selectingTabControl.TabPages.Add(AddTabPage(_courseSelectingFormPresentationModel.GetClassNameList[(int)Department.ElectronicEngineering3 / TAB_SET], (int)Department.ElectronicEngineering3 / TAB_SET));
            _selectingTabControl.SelectedTab.Controls.Add(this._courseDataGridView);
            _courseSelectionResultForm.Show();
            _courseSelectionResultForm.Close();
            _classNameCount = _courseSelectingFormPresentationModel.GetClassNameList.Count();
        }

        //AddTabPage
        private TabPage AddTabPage(string text, int index)
        {
            TabPage tabPage = new TabPage();
            tabPage.Size = new System.Drawing.Size(1192, 511);
            tabPage.TabIndex = index;
            tabPage.Text = text;
            tabPage.UseVisualStyleBackColor = true;
            return tabPage;
        }

        //載入視窗
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            LoadForm();
            LoadNewTab();
        }

        //load
        private void LoadForm()
        {
            if (_courseSelectingFormPresentationModel.IsLoadComputerScienceCourseTab == true)
            {
                FinishLoadComputerScienceCourseTabButton();
                LoadComputerScienceCourseTab("資工三");
                LoadComputerScienceCourseTab("資工一");
                LoadComputerScienceCourseTab("資工二");
                LoadComputerScienceCourseTab("資工四");
                LoadComputerScienceCourseTab("資工所");
                _classNameCount = GetClassNameListCount;
            }
            else
                LoadNewTab();
            _courseDataGridView.Rows.Clear();
            List<CourseInfo> courseList = _courseSelectingFormPresentationModel.GetCourseList(_index);
            LoadDataGridView(courseList, _courseDataGridView);
        }

        //GetClassNameListCount
        private int GetClassNameListCount
        {
            get
            {
                return _courseSelectingFormPresentationModel.GetClassNameList.Count();
            }
        }

        //FinishLoadComputerScienceCourseTabButton
        private void FinishLoadComputerScienceCourseTabButton()
        {
            _courseSelectingFormPresentationModel.FinishLoadComputerScienceCourseTabButton();
        }

        //LoadComputerScienceCourseTab
        private void LoadComputerScienceCourseTab(string className)
        {
            if (_classNameCount != GetClassNameListCount)
            {
                TabPage tabpage = AddTabPage(className, GetClassNameListCount - 1);
                if (!_selectingTabControl.TabPages.Contains(tabpage))
                    _selectingTabControl.TabPages.Add(tabpage);
            }
            _courseSelectingFormPresentationModel.UpdateCourseListInfo(GetClassNameIndex(className));
            _courseSelectingFormPresentationModel.WaitSeconds(1);
            UpdateAllForm();
        }

        //GetClassNameIndex
        private int GetClassNameIndex(string className)
        {
            return _courseSelectingFormPresentationModel.GetClassNameList.IndexOf(className);
        }

        //LoadDataGridView
        private void LoadDataGridView(List<CourseInfo> courseList, DataGridView courseDataGridView)
        {
            foreach (CourseInfo course in courseList)
            {
                DataGridViewRow row = new DataGridViewRow();
                foreach (string info in course.GetCourseInfoString)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell
                    {
                        Value = info
                    });
                }
                row.Cells.Insert(0, new DataGridViewCheckBoxCell());
                courseDataGridView.Rows.Add(row);
            }
        }

        //EndEditDataGridView
        private void EndEditDataGridView()
        {
            _courseDataGridView.EndEdit();
        }

        //ChangedCellValueAllDataGridView
        private void ChangedCellValueAllDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            EndEditDataGridView();
            CheckDataGridViewCheckBox();
            _submitButton.Enabled = _courseSelectingFormPresentationModel.IsSubmitButtonEnabled;
        }

        //CheckDataGridViewCheckBox
        private void CheckDataGridViewCheckBox()
        {
            _courseSelectingFormPresentationModel.ResetSubmitButton();
            foreach (DataGridViewRow row in _courseDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    _courseSelectingFormPresentationModel.HasEnabledCheckBox();
                    break;
                }
            }
        }

        //ClickCellDataGridView
        private void ClickCellDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(_courseDataGridView.Rows[e.RowIndex].Cells[0].Value) == true)
                    _courseDataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                else
                    _courseDataGridView.Rows[e.RowIndex].Cells[0].Value = true;
            }
        }

        //ClickCheckButton
        private void ClickCheckButton(object sender, EventArgs e)
        {
            _courseSelectingFormPresentationModel.ClickCheckButton();
            _checkButton.Enabled = _courseSelectingFormPresentationModel.IsCheckButtonEnabled;
            _courseSelectionResultForm.Show();
        }

        //SubmitDataGridView
        private void SubmitDataGridView()
        {
            int numberOfCourse = _courseDataGridView.RowCount;
            for (int index = 0; index < numberOfCourse; index++)
            {
                DataGridViewRow row = _courseDataGridView.Rows[numberOfCourse - index - 1];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    CourseInfo selectingCourse = new CourseInfo
                    (
                        row.Cells[(int)CourseInfoHeaderText.Number + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Name + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Stage + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Credit + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Hour + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.CourseType + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Teacher + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime0 + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.ClassTime1 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime2 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime3 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime4 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime5 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime6 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Classroom + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.NumberOfStudent + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.NumberOfDropStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.TeachingAssistant + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Language + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Outline + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Note + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.AttachStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Experiment + 1].Value.ToString()
                    );
                    _courseSelectingFormPresentationModel.AddSelectedCourse(selectingCourse);
                    _courseSelectingFormPresentationModel.RemoveFromCourseListAndAddInToSelectedTab(_index, row.Index);
                }
            }
        }

        //GetSelectedCourseList
        private List<CourseInfo> GetSelectedCourseList(List<CourseInfo> selectedCourseList)
        {
            return selectedCourseList;
        }

        //ClickSummitButton
        private void ClickSubmitButton(object sender, EventArgs e)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList(_courseSelectingFormPresentationModel.GetSelectedCourseList);
            List<CourseInfo> checkedCourseList = new List<CourseInfo>();
            checkedCourseList = TakeOutCheckedCourseListFromDataGridView(checkedCourseList, _courseDataGridView);
            string checkedMessage = _courseSelectingFormPresentationModel.CheckCourseList(checkedCourseList, selectedCourseList);
            SubmitCourseSelectionResult(checkedMessage);
            UpdateAllForm();
        }

        //TakeOutCheckedCourseListFromDataGridView
        private List<CourseInfo> TakeOutCheckedCourseListFromDataGridView(List<CourseInfo> checkedCourseList, DataGridView dataGridView)
        {
            int numberOfCourse = dataGridView.RowCount;
            for (int index = 0; index < numberOfCourse; index++)
            {
                DataGridViewRow row = dataGridView.Rows[numberOfCourse - index - 1];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    CourseInfo selectedCourse = new CourseInfo
                    (
                        row.Cells[(int)CourseInfoHeaderText.Number + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Name + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Stage + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Credit + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Hour + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.CourseType + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Teacher + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime0 + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.ClassTime1 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime2 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime3 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime4 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime5 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime6 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Classroom + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.NumberOfStudent + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.NumberOfDropStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.TeachingAssistant + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Language + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Outline + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Note + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.AttachStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Experiment + 1].Value.ToString()
                    );
                    checkedCourseList.Add(selectedCourse);
                }
            }
            return checkedCourseList;
        }

        //Submit
        private void SubmitCourseSelectionResult(string checkedMessage)
        {
            if (checkedMessage == "")
            {
                SubmitDataGridView();
                MessageBox.Show("加選成功");
                _courseSelectingFormPresentationModel.ResetSubmitButton();
                _submitButton.Enabled = _courseSelectingFormPresentationModel.IsSubmitButtonEnabled;
                
            }
            else
                MessageBox.Show("加選失敗" + checkedMessage);
        }

        //ResetCheckButton()
        public void ResetCheckButton()
        {
            _courseSelectingFormPresentationModel.ResetCheckButton();
            _checkButton.Enabled = _courseSelectingFormPresentationModel.IsCheckButtonEnabled;
        }

        //ClosingFormCourseSelectingForm
        private void ClosingFormCourseSelectingForm(object sender, FormClosingEventArgs e)
        {
            _courseSelectionResultForm.Close();
            _startUpForm.ResetCourseSelectingFormButton();
            e.Cancel = true;
            this.Hide();
        }
        
        //UpdateAllForm
        private void UpdateAllForm()
        {
            _courseSelectingFormPresentationModel.ReloadAllForm();
        }

        //SelectedIndexChangedSelectingTabControl
        private void SelectedIndexChangedSelectingTabControl(object sender, EventArgs e)
        {
            _selectingTabControl.SelectedTab.Controls.Add(this._courseDataGridView);
            _index = _selectingTabControl.SelectedIndex;
            LoadForm();
        }

        //load
        private void LoadNewTab()
        {
            if (_classNameCount != GetClassNameListCount)
            {
                int count = 0;
                string tabText = _courseSelectingFormPresentationModel.GetClassNameList[GetClassNameListCount - 1];
                foreach (TabPage tabPage in _selectingTabControl.TabPages)
                {
                    if (tabText == tabPage.Text)
                        count++;
                }
                if (count == 0)
                    _selectingTabControl.TabPages.Add(AddTabPage(_courseSelectingFormPresentationModel.GetClassNameList[_courseSelectingFormPresentationModel.GetClassNameList.Count() - 1], _courseSelectingFormPresentationModel.GetClassNameList.Count() - 1));
                _classNameCount = _courseSelectingFormPresentationModel.GetClassNameList.Count();
            }
        }
    }
}
