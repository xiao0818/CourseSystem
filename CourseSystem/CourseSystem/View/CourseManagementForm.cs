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
        const int DAY_PER_WEEK = 7;
        const string DOT = ".";
        const string MODIFY_COURSE = "編輯課程";
        const string MODIFY_SUCCESSFUL = "編輯成功";
        const string MODIFY_NOT_SUCCESSFUL = "編輯失敗";
        const string ADD_SUCCESSFUL = "新增成功";
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
            ReloadManagementForm();
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
            Tuple<int, int, int> department = _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
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

        //ReloadManagementForm
        public void ReloadManagementForm()
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

        //TakeOutClassTimeFromDataGridView
        private List<string> TakeOutClassTimeFromDataGridView(DataGridViewRowCollection rows)
        {
            List<string> classTimeStringList = new List<string>
                {
                    "", "", "", "", "", "", ""
                };
            for (int day = 0; day < DAY_PER_WEEK; day++)
            {
                foreach (DataGridViewRow row in _classTimeDataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                    {
                        classTimeStringList[day] = classTimeStringList[day] + row.Cells[0].Value + " ";
                    }
                    classTimeStringList[day] = classTimeStringList[day];
                }
            }
            return classTimeStringList;
        }

        //ClickSaveCourseDataButton
        private void ClickSaveCourseDataButton(object sender, EventArgs e)
        {
            _classTimeDataGridView.EndEdit();
            if (_classDataGroupBox.Text == MODIFY_COURSE)
            {
                CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
                Tuple<int, int, int> department = _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
                List<string> ClassTimeStringList = TakeOutClassTimeFromDataGridView(_classTimeDataGridView.Rows);
                CourseInfo newCourse = new CourseInfo(
                    _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                    ClassTimeStringList[(int)Day.Sunday].Trim(), ClassTimeStringList[(int)Day.Monday].Trim(), ClassTimeStringList[(int)Day.Tuesday].Trim(), ClassTimeStringList[(int)Day.Wednesday].Trim(), ClassTimeStringList[(int)Day.Thursday].Trim(), ClassTimeStringList[(int)Day.Friday].Trim(), ClassTimeStringList[(int)Day.Saturday].Trim(), course.Classroom,
                    course.NumberOfStudent, course.NumberOfDropStudent, _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, course.Outline, _courseNoteTextBox.Text, course.AttachStudent, course.Experiment);
                SaveModifyCourse(department, newCourse, course);
            }
            else
            {
                SaveAddCourse();
            }
            _startUpForm.ReloadAllForm();
        }

        //SaveModifyCourse
        private void SaveModifyCourse(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course)
        {
            if (department.Item1 == (int)ListName.ComputerScience3 || department.Item1 == (int)ListName.ElectronicEngineering3)
            {
                SaveModifyCoursePartOne(department, newCourse);
            }
            else if (department.Item1 == (int)ListName.SelectedList)
            {
                SaveModifyCoursePartTwo(department, newCourse, course);
            }
        }

        //SaveModifyCoursePartOne
        private void SaveModifyCoursePartOne(Tuple<int, int, int> department, CourseInfo newCourse)
        {
            if (department.Item1 == (int)ListName.ComputerScience3)
            {
                _courseManagementFormPresentationModel.RemoveCourseFromComputerScience3(department.Item3);
            }
            else if (department.Item1 == (int)ListName.ElectronicEngineering3)
            {
                _courseManagementFormPresentationModel.RemoveCourseFromElectronicEngineering3(department.Item3);
            }
            if (_courseClassSelectionComboBox.SelectedIndex == (int)ListName.ComputerScience3)
            {
                _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(newCourse);
            }
            else if (_courseClassSelectionComboBox.SelectedIndex == (int)ListName.ElectronicEngineering3)
            {
                _courseManagementFormPresentationModel.AddIntoElectronicEngineering3CourseList(newCourse);
            }
            MessageBox.Show(MODIFY_SUCCESSFUL);
        }

        //SaveModifyCoursePartTwo
        private void SaveModifyCoursePartTwo(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course)
        {
            List<CourseInfo> selectedCourseList = _courseManagementFormPresentationModel.GetSelectedCourseList;
            _courseManagementFormPresentationModel.RemoveCourseFromTabDictionary(department.Item3);
            selectedCourseList.RemoveAt(department.Item3);
            string checkedMessage = _courseManagementFormPresentationModel.CheckCourseList(newCourse, selectedCourseList);
            if (checkedMessage == "")
            {
                MessageBox.Show(MODIFY_SUCCESSFUL);
                _courseManagementFormPresentationModel.AddIntoSelectedCourseList(newCourse, _courseClassSelectionComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show(MODIFY_NOT_SUCCESSFUL + "\n此編輯會導致已選課程發生:" + checkedMessage);
                _courseManagementFormPresentationModel.AddIntoSelectedCourseList(course, department.Item2);
            }
        }

        //SaveAddCourse
        private void SaveAddCourse()
        {
            List<string> classTimeStringList = TakeOutClassTimeFromDataGridView(_classTimeDataGridView.Rows);
            CourseInfo course = new CourseInfo(
                _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                classTimeStringList[0].Trim(), classTimeStringList[1].Trim(), classTimeStringList[2].Trim(), classTimeStringList[3].Trim(), classTimeStringList[4].Trim(), classTimeStringList[5].Trim(), classTimeStringList[6].Trim(), "",
                "", "", _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, "", _courseNoteTextBox.Text, "", "");
            if (_courseClassSelectionComboBox.Text == Department.ComputerScience3.ToString())
            {
                _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(course);
                MessageBox.Show(ADD_SUCCESSFUL);
            }
            else if (_courseClassSelectionComboBox.Text == Department.ElectronicEngineering3.ToString())
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
            int count = GetClassTimeTotal();
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
        private int GetClassTimeTotal()
        {
            int count = 0;
            for (int day = 0; day < DAY_PER_WEEK; day++)
            {
                foreach (DataGridViewRow row in _classTimeDataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
