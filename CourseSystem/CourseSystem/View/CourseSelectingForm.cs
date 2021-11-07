using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    public partial class CourseSelectingForm : Form
    {
        int _index;
        CourseSelectingFormPresentationModel _courseSelectingFormPresentationModel;
        CourseSelectionResultForm _courseSelectionResultForm;
        StartUpForm _startUpForm;
        public CourseSelectingForm(StartUpForm startUpForm, CourseSelectingFormPresentationModel courseSelectingFormPresentationModel, CourseSelectionResultFormPresentationModel courseSelectionResultFormPresentationModel)
        {
            _courseSelectingFormPresentationModel = courseSelectingFormPresentationModel;
            _courseSelectionResultForm = new CourseSelectionResultForm(this, courseSelectionResultFormPresentationModel);
            _courseSelectingFormPresentationModel._presentationModelChanged += LoadForm;
            _startUpForm = startUpForm;
            _index = 0;
            InitializeComponent();
            _selectingTabControl.TabPages.Add(AddTabPage(_courseSelectingFormPresentationModel.GetClassNameList[(int)Department.ComputerScience3]));
            _selectingTabControl.TabPages.Add(AddTabPage(_courseSelectingFormPresentationModel.GetClassNameList[(int)Department.ElectronicEngineering3]));
            _selectingTabControl.SelectedTab.Controls.Add(this._courseDataGridView);
        }

        //AddTabPage
        private TabPage AddTabPage(string text)
        {
            TabPage tabPage = new TabPage();
            tabPage.Size = new System.Drawing.Size(1192, 511);
            tabPage.TabIndex = 0;
            tabPage.Text = text;
            tabPage.UseVisualStyleBackColor = true;
            return tabPage;
        }

        //載入視窗
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            LoadForm();
        }

        //load
        public void LoadForm()
        {
            _courseDataGridView.Rows.Clear();
            List<CourseInfo> courseList = _courseSelectingFormPresentationModel.GetCourseList(_index);
            LoadDataGridView(courseList, _courseDataGridView);
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
                {
                    _courseDataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    _courseDataGridView.Rows[e.RowIndex].Cells[0].Value = true;
                }
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
            {
                MessageBox.Show("加選失敗" + checkedMessage);
            }
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
        public void UpdateAllForm()
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
    }
}
