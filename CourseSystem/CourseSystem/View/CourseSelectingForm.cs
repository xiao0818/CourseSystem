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
        CourseSelectingFormPresentationModel _courseSelectingFormPresentationModel;
        CourseSelectionResultForm _courseSelectionResultForm;
        StartUpForm _startUpForm;
        public CourseSelectingForm(StartUpForm startUpForm, CourseSelectingFormPresentationModel courseSelectingFormPresentationModel, CourseSelectionResultFormPresentationModel courseSelectionResultFormPresentationModel)
        {
            _courseSelectingFormPresentationModel = courseSelectingFormPresentationModel;
            _courseSelectionResultForm = new CourseSelectionResultForm(this, courseSelectionResultFormPresentationModel);
            _courseSelectingFormPresentationModel._presentationModelChanged += LoadForm;
            _startUpForm = startUpForm;
            InitializeComponent();
        }

        //載入視窗
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            LoadForm();
        }

        //load
        public void LoadForm()
        {
            _computerScience3DataGridView.Rows.Clear();
            _electronicEngineering3DataGridView.Rows.Clear();
            LoadDataGridView(_courseSelectingFormPresentationModel.GetComputerScience3CourseList, _computerScience3DataGridView);
            LoadDataGridView(_courseSelectingFormPresentationModel.GetElectronicEngineering3CourseList, _electronicEngineering3DataGridView);
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
            _computerScience3DataGridView.EndEdit();
            _electronicEngineering3DataGridView.EndEdit();
        }

        //ChangedCellValueAllDataGridView
        private void ChangedCellValueAllDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            EndEditDataGridView();
            _courseSelectingFormPresentationModel.CheckDataGridViewCheckBox(_computerScience3DataGridView, _electronicEngineering3DataGridView);
            _submitButton.Enabled = _courseSelectingFormPresentationModel.IsSubmitButtonEnabled;
        }

        //ClickCellComputerScienceThirdDataGridView
        private void ClickCellComputerScienceThirdDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(_computerScience3DataGridView.Rows[e.RowIndex].Cells[0].Value) == true)
                {
                    _computerScience3DataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    _computerScience3DataGridView.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        //ClickCellElectronicEngineeringThirdOneDataGridView
        private void ClickCellElectronicEngineeringThirdOneDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(_electronicEngineering3DataGridView.Rows[e.RowIndex].Cells[0].Value) == true)
                {
                    _electronicEngineering3DataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    _electronicEngineering3DataGridView.Rows[e.RowIndex].Cells[0].Value = true;
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

        //SubmitComputerScience3DataGridView
        private void SubmitComputerScience3DataGridView()
        {
            int numberOfCourse = _computerScience3DataGridView.RowCount;
            for (int index = 0; index < numberOfCourse; index++)
            {
                DataGridViewRow row = _computerScience3DataGridView.Rows[numberOfCourse - index - 1];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    CourseInfo selectingCourse = new CourseInfo
                    (
                        row.Cells[(int)CourseInfoHeaderText.Number + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Name + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Stage + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Credit + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Hour + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.CourseType + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Teacher + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime0 + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.ClassTime1 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime2 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime3 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime4 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime5 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime6 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Classroom + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.NumberOfStudent + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.NumberOfDropStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.TeachingAssistant + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Language + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Outline + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Note + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.AttachStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Experiment + 1].Value.ToString()
                    );
                    _courseSelectingFormPresentationModel.AddSelectedCourse(selectingCourse);
                    _courseSelectingFormPresentationModel.RemoveFromComputerScience3(row.Index);
                }
            }
        }

        //SubmitElectronicEngineering3DataGridView
        private void SubmitElectronicEngineering3DataGridView()
        {
            int numberOfCourse = _electronicEngineering3DataGridView.RowCount;
            for (int index = 0; index < numberOfCourse; index++)
            {
                DataGridViewRow row = _electronicEngineering3DataGridView.Rows[numberOfCourse - index - 1];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    CourseInfo selectingCourse = new CourseInfo
                    (
                        row.Cells[(int)CourseInfoHeaderText.Number + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Name + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Stage + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Credit + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Hour + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.CourseType + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Teacher + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime0 + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.ClassTime1 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime2 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime3 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime4 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime5 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime6 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Classroom + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.NumberOfStudent + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.NumberOfDropStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.TeachingAssistant + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Language + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Outline + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Note + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.AttachStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Experiment + 1].Value.ToString()
                    );
                    _courseSelectingFormPresentationModel.AddSelectedCourse(selectingCourse);
                    _courseSelectingFormPresentationModel.RemoveFromElectronicEngineering3(row.Index);
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
            checkedCourseList = TakeOutCheckedCourseListFromDataGridView(checkedCourseList, _computerScience3DataGridView);
            checkedCourseList = TakeOutCheckedCourseListFromDataGridView(checkedCourseList, _electronicEngineering3DataGridView);
            string checkedMessage = _courseSelectingFormPresentationModel.CheckCourseList(checkedCourseList, selectedCourseList);
            SubmitCourseSelectionResult(checkedMessage);
            UpdateAllForm();
        }

        //TakeOutCheckedCourseListFromDataGridView(checkedCourseList, _computerScience3DataGridView)
        private List<CourseInfo> TakeOutCheckedCourseListFromDataGridView(List<CourseInfo> checkedCourseList, DataGridView dataGridView)
        {
            return _courseSelectingFormPresentationModel.TakeOutCheckedCourseListFromDataGridView(checkedCourseList, _computerScience3DataGridView);
        }

        //Submit
        private void SubmitCourseSelectionResult(string checkedMessage)
        {
            if (checkedMessage == "")
            {
                SubmitComputerScience3DataGridView();
                SubmitElectronicEngineering3DataGridView();
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
    }
}
