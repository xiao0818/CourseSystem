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
    public partial class CourseManagementForm : Form
    {
        CourseManagementFormPresentationModel _courseManagementFormPresentationModel;
        StartUpForm _startUpForm;
        public CourseManagementForm(StartUpForm startUpForm, CourseManagementFormPresentationModel courseManagementFormPresentationModel)
        {
            _courseManagementFormPresentationModel = courseManagementFormPresentationModel;
            _startUpForm = startUpForm;
            InitializeComponent();
        }

        //ClosingFormCourseManagementForm
        private void ClosingFormCourseManagementForm(object sender, FormClosingEventArgs e)
        {
            _startUpForm.ResetCourseManagementFormButton();
            e.Cancel = true;
            Hide();
        }

        //LoadCourseManagementForm
        private void LoadCourseManagementForm(object sender, EventArgs e)
        {
            LoadListBox();
            AddRowsInClassTimeDataGridView();
        }

        //LoadListBox
        private void LoadListBox()
        {
            _courseListBox.Items.Clear();
            List<CourseInfo> computerScience3CourseList = _courseManagementFormPresentationModel.GetComputerScience3CourseList;
            List<CourseInfo> electronicEngineering3CourseList = _courseManagementFormPresentationModel.GetElectronicEngineering3CourseList;
            List<CourseInfo> selectedCourseList = _courseManagementFormPresentationModel.GetSelectedCourseList;
            foreach (CourseInfo course in computerScience3CourseList)
            {
                _courseListBox.Items.Add(course.Name);
            }
            foreach (CourseInfo course in electronicEngineering3CourseList)
            {
                _courseListBox.Items.Add(course.Name);
            }
            foreach (CourseInfo course in selectedCourseList)
            {
                _courseListBox.Items.Add(course.Name);
            }
        }

        //AddRowsInClassTimeDataGridView
        private void AddRowsInClassTimeDataGridView()
        {
            string classTimeChar = "1234N56789ABCD";
            _classTimeDataGridView.Rows.Clear();
            foreach (char timeChar in classTimeChar)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int index = 0; index < 7; index++)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell
                    {
                        Value = false
                    });
                }
                row.Cells.Insert(0, new DataGridViewTextBoxCell
                {
                    Value = timeChar
                });
                _classTimeDataGridView.Rows.Add(row);
            }
        }

        //ChangedSelectedIndexCourseListBox
        private void ChangedSelectedIndexCourseListBox(object sender, EventArgs e)
        {
            _classDataGroupBox.Text = "編輯課程";
            CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
            int department = _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
            LoadContext(department, course);
        }

        //LoadContext
        private void LoadContext(int department, CourseInfo course)
        {
            _courseEnabledComboBox.Text = "開課";
            _courseNumberTextBox.Text = course.Number;
            _courseNameTextBox.Text = course.Name;
            _courseStageTextBox.Text = course.Stage;
            _courseCreditTextBox.Text = course.Credit;
            _courseTeacherTextBox.Text = course.Teacher;
            _courseTypeSelectionComboBox.Text = course.CourseType;
            _courseTeachingAssistantTextBox.Text = course.TeachingAssistant;
            _courseLanguageTextBox.Text = course.Language;
            _courseNoteTextBox.Text = course.Note;
            _classTimeSelectionComboBox.Text = course.Hour;
            if (department == 0)
            {
                _courseSelectionComboBox.Text = "資工三";
            }
            else if (department == 1)
            {
                _courseSelectionComboBox.Text = "電子三甲";
            }
            AddRowsInClassTimeDataGridView();
            foreach (Tuple<int, string> time in course.GetCourseClassTime())
            {
                _classTimeDataGridView.Rows[TranslateClassTimeToIndex(time.Item2)].Cells[time.Item1 + 1].Value = Enabled;
            }
            SetAllObjectInGroupBoxEnabled();
        }

        //TranslateClassTimeToIndex
        private int TranslateClassTimeToIndex(string time)
        {
            int count = 0;
            string classTimeChar = "1234N56789ABCD";
            foreach (char timeChar in classTimeChar)
            {
                if (time == timeChar.ToString())
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

        //SetAllObjectInGroupBoxEnabled
        private void SetAllObjectInGroupBoxEnabled()
        {
            _courseEnabledComboBox.Enabled = true;
            _courseNumberTextBox.Enabled = true;
            _courseNameTextBox.Enabled = true;
            _courseStageTextBox.Enabled = true;
            _courseCreditTextBox.Enabled = true;
            _courseTeacherTextBox.Enabled = true;
            _courseTypeSelectionComboBox.Enabled = true;
            _courseTeachingAssistantTextBox.Enabled = true;
            _courseLanguageTextBox.Enabled = true;
            _courseNoteTextBox.Enabled = true;
            _classTimeSelectionComboBox.Enabled = true;
            _courseSelectionComboBox.Enabled = true;
            _classTimeDataGridView.Enabled = true;
        }

        //ReloadManagementForm
        public void ReloadManagementForm()
        {
            LoadListBox();
            SetAllObjectInGroupBoxEmpty();
            AddRowsInClassTimeDataGridView();
        }

        //SetAllObjectInGroupBoxEmpty
        private void SetAllObjectInGroupBoxEmpty()
        {
            _courseEnabledComboBox.Text = "";
            _courseNumberTextBox.Text = "";
            _courseNameTextBox.Text = "";
            _courseStageTextBox.Text = "";
            _courseCreditTextBox.Text = "";
            _courseTeacherTextBox.Text = "";
            _courseTypeSelectionComboBox.Text = "";
            _courseTeachingAssistantTextBox.Text = "";
            _courseLanguageTextBox.Text = "";
            _courseNoteTextBox.Text = "";
            _classTimeSelectionComboBox.Text = "";
            _courseSelectionComboBox.Text = "";
        }

        //ClickAddCourseButton
        private void ClickAddCourseButton(object sender, EventArgs e)
        {
            _classDataGroupBox.Text = "新增課程";
            SetAllObjectInGroupBoxEmpty();
            AddRowsInClassTimeDataGridView();
            SetAllObjectInGroupBoxEnabled();
        }
    }
}
