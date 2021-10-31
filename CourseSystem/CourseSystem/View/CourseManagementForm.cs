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
        const string CLASS_TIME_CHAR = "1234N56789ABCD";
        const string DOT = ".";
        const string MODIFY_COURSE = "編輯課程";
        const string ADD_SUCCESSFUL = "新增成功";
        public CourseManagementForm(StartUpForm startUpForm, CourseManagementFormPresentationModel courseManagementFormPresentationModel)
        {
            _courseManagementFormPresentationModel = courseManagementFormPresentationModel;
            _startUpForm = startUpForm;
            _courseManagementFormPresentationModel._presentationModelChanged += LoadManagementForm;
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
            LoadManagementForm();
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
            _classTimeDataGridView.Rows.Clear();
            foreach (char timeChar in CLASS_TIME_CHAR)
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
            _saveCourseDataButton.Text = "儲存";
            CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
            Tuple<int, int, int> department = GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
            LoadContext(department, course);
            _courseManagementFormPresentationModel.SelectListBox();
            _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
            _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
        }

        //LoadContext
        private void LoadContext(Tuple<int, int, int> department, CourseInfo course)
        {
            LoadTextBoxAndComboBox(course);
            if (department.Item2 == 0)
            {
                _courseClassSelectionComboBox.Text = "資工三";
            }
            else if (department.Item2 == 1)
            {
                _courseClassSelectionComboBox.Text = "電子三甲";
            }
            AddRowsInClassTimeDataGridView();
            foreach (Tuple<int, string> time in course.GetCourseClassTime())
            {
                _classTimeDataGridView.Rows[TranslateClassTimeToIndex(time.Item2)].Cells[time.Item1 + 1].Value = Enabled;
            }
            SetAllObjectInGroupBoxEnabled(true);
        }

        //LoadTextBoxAndComboBox
        private void LoadTextBoxAndComboBox(CourseInfo course)
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
            _courseClassTimeSelectionComboBox.Text = course.Hour;
        }

        //TranslateClassTimeToIndex
        private int TranslateClassTimeToIndex(string time)
        {
            int count = 0;
            foreach (char timeChar in CLASS_TIME_CHAR)
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
        private void SetAllObjectInGroupBoxEnabled(bool enable)
        {
            _courseEnabledComboBox.Enabled = enable;
            _courseNumberTextBox.Enabled = enable;
            _courseNameTextBox.Enabled = enable;
            _courseStageTextBox.Enabled = enable;
            _courseCreditTextBox.Enabled = enable;
            _courseTeacherTextBox.Enabled = enable;
            _courseTypeSelectionComboBox.Enabled = enable;
            _courseTeachingAssistantTextBox.Enabled = enable;
            _courseLanguageTextBox.Enabled = enable;
            _courseNoteTextBox.Enabled = enable;
            _courseClassTimeSelectionComboBox.Enabled = enable;
            _courseClassSelectionComboBox.Enabled = enable;
            _classTimeDataGridView.Enabled = enable;
        }

        //LoadManagementForm
        public void LoadManagementForm()
        {
            LoadListBox();
            SetAllObjectInGroupBoxEmpty();
            AddRowsInClassTimeDataGridView();
            SetAllObjectInGroupBoxEnabled(false);
            _courseManagementFormPresentationModel.ResetAllButton();
            _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
            _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
            _classTimeDataGridView.ClearSelection();
        }

        //SetAllObjectInGroupBoxEmpty
        private void SetAllObjectInGroupBoxEmpty()
        {
            _courseEnabledComboBox.SelectedIndex = -1;
            _courseNumberTextBox.Text = "";
            _courseNameTextBox.Text = "";
            _courseStageTextBox.Text = "";
            _courseCreditTextBox.Text = "";
            _courseTeacherTextBox.Text = "";
            _courseTypeSelectionComboBox.SelectedIndex = -1;
            _courseTeachingAssistantTextBox.Text = "";
            _courseLanguageTextBox.Text = "";
            _courseNoteTextBox.Text = "";
            _courseClassTimeSelectionComboBox.SelectedIndex = -1;
            _courseClassSelectionComboBox.SelectedIndex = -1;
        }

        //ClickAddCourseButton
        private void ClickAddCourseButton(object sender, EventArgs e)
        {
            _classDataGroupBox.Text = "新增課程";
            _saveCourseDataButton.Text = "新增";
            _addCourseDataButton.Enabled = false;
            SetAllObjectInGroupBoxEmpty();
            AddRowsInClassTimeDataGridView();
            SetAllObjectInGroupBoxEnabled(true);
            _courseClassSelectionComboBox.SelectedIndex = 0;
            _courseClassTimeSelectionComboBox.SelectedIndex = 0;
            _courseEnabledComboBox.SelectedIndex = 0;
            _courseTypeSelectionComboBox.SelectedIndex = 0;
            _saveCourseDataButton.Enabled = false;
            _courseManagementFormPresentationModel.ClickAddButton();
            _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
            _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
        }

        //ClickCellClassTimeDataGridView
        private void ClickCellClassTimeDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                if (Convert.ToBoolean(_classTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                {
                    _classTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    _classTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
            }
        }

        //KeyInLimit
        private void KeyInLimit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == DOT)
            {
                foreach (char i in (sender as TextBox).Text)
                {
                    if (i.ToString() == DOT)
                        e.Handled = true;
                }
                return;
            }
            if (e.KeyChar != (Char)48 && e.KeyChar != (Char)49 && e.KeyChar != (Char)50 && e.KeyChar != (Char)51 && e.KeyChar != (Char)52 && e.KeyChar != (Char)53 &&
                e.KeyChar != (Char)54 && e.KeyChar != (Char)55 && e.KeyChar != (Char)56 && e.KeyChar != (Char)57 && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        //ClickSaveCourseDataButton
        private void ClickSaveCourseDataButton(object sender, EventArgs e)
        {
            _classTimeDataGridView.EndEdit();
            if (_classDataGroupBox.Text == MODIFY_COURSE)
            {
                SaveModifyCourse();
            }
            else
            {
                SaveAddCourse();
            }
            UpdateAllForm();
        }

        //SaveModifyCourse
        private void SaveModifyCourse()
        {
            CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
            Tuple<int, int, int> department = GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
            List<string> classTimeStringList = _courseManagementFormPresentationModel.TakeOutClassTimeFromDataGridView(_classTimeDataGridView.Rows);
            CourseInfo newCourse = new CourseInfo(
                _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                classTimeStringList[(int)Day.Sunday].Trim(), classTimeStringList[(int)Day.Monday].Trim(), classTimeStringList[(int)Day.Tuesday].Trim(), classTimeStringList[(int)Day.Wednesday].Trim(), classTimeStringList[(int)Day.Thursday].Trim(), classTimeStringList[(int)Day.Friday].Trim(), classTimeStringList[(int)Day.Saturday].Trim(), course.Classroom,
                course.NumberOfStudent, course.NumberOfDropStudent, _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, course.Outline, _courseNoteTextBox.Text, course.AttachStudent, course.Experiment);
            if (department.Item1 == (int)ListName.ComputerScience3 || department.Item1 == (int)ListName.ElectronicEngineering3)
            {
                SaveModifyCoursePartOne(department, newCourse, _courseClassSelectionComboBox.SelectedIndex);
            }
            else if (department.Item1 == (int)ListName.SelectedList)
            {
                SaveModifyCoursePartTwo(department, newCourse, course, _courseClassSelectionComboBox.SelectedIndex);
            }
        }

        //GetCourseDepartmentBySelectedIndex
        private Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            return _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(selectedIndex);
        }

        //SaveModifyCoursePartOne
        public void SaveModifyCoursePartOne(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            _courseManagementFormPresentationModel.SaveModifyCoursePartOne(department, newCourse, _courseClassSelectionComboBox.SelectedIndex);
        }

        //SaveModifyCoursePartTwo
        public void SaveModifyCoursePartTwo(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            _courseManagementFormPresentationModel.SaveModifyCoursePartTwo(department, newCourse, course, _courseClassSelectionComboBox.SelectedIndex);
        }

        //SaveAddCourse
        private void SaveAddCourse()
        {
            List<string> classTimeStringList = _courseManagementFormPresentationModel.TakeOutClassTimeFromDataGridView(_classTimeDataGridView.Rows);
            CourseInfo course = new CourseInfo(
                _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                classTimeStringList[0].Trim(), classTimeStringList[1].Trim(), classTimeStringList[2].Trim(), classTimeStringList[3].Trim(), classTimeStringList[4].Trim(), classTimeStringList[5].Trim(), classTimeStringList[6].Trim(), "",
                "", "", _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, "", _courseNoteTextBox.Text, "", "");
            if (_courseClassSelectionComboBox.SelectedIndex == (int)Department.ComputerScience3)
            {
                _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(course);
                MessageBox.Show(ADD_SUCCESSFUL);
            }
            else if (_courseClassSelectionComboBox.SelectedIndex == (int)Department.ElectronicEngineering3)
            {
                _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(course);
                MessageBox.Show(ADD_SUCCESSFUL);
            }
        }

        //ChangedText
        private void ChangedText(object sender, EventArgs e)
        {
            ChangedGroupBox();
        }

        //ChangedCellValueClassTimeDataGridView
        private void ChangedCellValueClassTimeDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            _classTimeDataGridView.EndEdit();
            ChangedGroupBox();
        }

        //ChangedGroupBox
        private void ChangedGroupBox()
        {
            int count = GetClassTimeTotal(_classTimeDataGridView.Rows);
            if (count.ToString() != _courseClassTimeSelectionComboBox.Text || _courseNumberTextBox.Text == "" || _courseNameTextBox.Text == "" || _courseStageTextBox.Text == "" || _courseCreditTextBox.Text == "" ||
                _courseTeacherTextBox.Text == "" || _courseTypeSelectionComboBox.Text == "" || _courseClassTimeSelectionComboBox.Text == "" || _courseClassSelectionComboBox.Text == "")
            {
                _courseManagementFormPresentationModel.ChangeContentNotEnabled();
            }
            else
            {
                _courseManagementFormPresentationModel.ChangeContentEnabled();
            }
            _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
            _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
        }

        //GetClassTimeTotal
        private int GetClassTimeTotal(DataGridViewRowCollection rows)
        {
            return _courseManagementFormPresentationModel.GetClassTimeTotal(_classTimeDataGridView.Rows);
        }

        //UpdateAllForm
        public void UpdateAllForm()
        {
            _courseManagementFormPresentationModel.ReloadAllForm();
        }
    }
}
