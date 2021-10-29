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
            _saveCourseDataButton.Enabled = false;
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
            const string CLASS_TIME_CHAR = "1234N56789ABCD";
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
            CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
            Tuple<int, int, int> department = _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
            LoadContext(department, course);
            _addCourseButton.Enabled = true;
        }

        //LoadContext
        private void LoadContext(Tuple<int, int, int> department, CourseInfo course)
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
            if (department.Item2 == 0)
            {
                _courseSelectionComboBox.Text = "資工三";
            }
            else if (department.Item2 == 1)
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
            const string CLASS_TIME_CHAR = "1234N56789ABCD";
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
            _saveCourseDataButton.Enabled = false;
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
            _classTimeSelectionComboBox.SelectedIndex = -1;
            _courseSelectionComboBox.SelectedIndex = -1;
        }

        //ClickAddCourseButton
        private void ClickAddCourseButton(object sender, EventArgs e)
        {
            _classDataGroupBox.Text = "新增課程";
            _addCourseButton.Enabled = false;
            SetAllObjectInGroupBoxEmpty();
            AddRowsInClassTimeDataGridView();
            SetAllObjectInGroupBoxEnabled();
            _saveCourseDataButton.Enabled = false;
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
            if (e.KeyChar == '.')
            {
                foreach (char i in (sender as TextBox).Text)
                {
                    if (i == '.')
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
            if (_classDataGroupBox.Text == "編輯課程")
            {
                CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
                Tuple<int, int, int> department = _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
                //開課班級
                List<string> ClassTimeStringList = new List<string>
                {
                    "" ,"" ,"" ,"" ,"" ,"" ,""
                };
                const int DAY_PER_WEEK = 7;
                for (int day = 0; day < DAY_PER_WEEK; day++)
                {
                    foreach (DataGridViewRow row in _classTimeDataGridView.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                        {
                            ClassTimeStringList[day] += row.Cells[0].Value;
                            ClassTimeStringList[day] += " ";
                        }
                        ClassTimeStringList[day] = ClassTimeStringList[day];
                    }
                }
                CourseInfo newCourse = new CourseInfo(
                    _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _classTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                    ClassTimeStringList[0].Trim(), ClassTimeStringList[1].Trim(), ClassTimeStringList[2].Trim(), ClassTimeStringList[3].Trim(), ClassTimeStringList[4].Trim(), ClassTimeStringList[5].Trim(), ClassTimeStringList[6].Trim(), course.Classroom,
                    course.NumberOfStudent, course.NumberOfDropStudent, _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, course.Outline, _courseNoteTextBox.Text, course.AttachStudent, course.Experiment);
                if (department.Item1 == (int)Department.ComputerScience3)
                {
                    _courseManagementFormPresentationModel.RemoveCourseFromComputerScience3(department.Item3);
                    if (_courseSelectionComboBox.SelectedIndex == (int)Department.ComputerScience3)
                    {
                        _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(newCourse);
                    }
                    else if (_courseSelectionComboBox.SelectedIndex == (int)Department.ElectronicEngineering3)
                    {
                        _courseManagementFormPresentationModel.AddIntoElectronicEngineering3CourseList(newCourse);
                    }
                    MessageBox.Show("編輯成功");
                    _startUpForm.ReloadAllForm();
                }
                else if (department.Item1 == (int)Department.ElectronicEngineering3)
                {
                    _courseManagementFormPresentationModel.RemoveCourseFromElectronicEngineering3(department.Item3);
                    if (_courseSelectionComboBox.SelectedIndex == (int)Department.ComputerScience3)
                    {
                        _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(newCourse);
                    }
                    else if (_courseSelectionComboBox.SelectedIndex == (int)Department.ElectronicEngineering3)
                    {
                        _courseManagementFormPresentationModel.AddIntoElectronicEngineering3CourseList(newCourse);
                    }
                    MessageBox.Show("編輯成功");
                    _startUpForm.ReloadAllForm();
                }
                else
                {
                    List<CourseInfo> selectedCourseList = _courseManagementFormPresentationModel.GetSelectedCourseList;
                    selectedCourseList.RemoveAt(department.Item3);
                    string checkedMessage = _courseManagementFormPresentationModel.CheckCourseList(newCourse, selectedCourseList);
                    if (checkedMessage == "")
                    {
                        MessageBox.Show("編輯成功");
                        _courseManagementFormPresentationModel.RemoveCourseFromTabDictionary(department.Item3);
                        _courseManagementFormPresentationModel.AddIntoSelectedCourseList(newCourse, department.Item1);
                        _startUpForm.ReloadAllForm();
                    }
                    else
                    {
                        MessageBox.Show("編輯失敗" + checkedMessage);
                    }
                }
            }
            else
            {
                List<string> ClassTimeStringList = new List<string> 
                {
                    "", "", "", "", "", "", ""
                };
                const int DAY_PER_WEEK = 7;
                for (int day = 0; day < DAY_PER_WEEK; day++)
                {
                    foreach (DataGridViewRow row in _classTimeDataGridView.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                        {
                            ClassTimeStringList[day] += row.Cells[0].Value;
                            ClassTimeStringList[day] += " ";
                        }
                        ClassTimeStringList[day] = ClassTimeStringList[day];
                    }
                }
                CourseInfo course = new CourseInfo(
                    _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _classTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                    ClassTimeStringList[0].Trim(), ClassTimeStringList[1].Trim(), ClassTimeStringList[2].Trim(), ClassTimeStringList[3].Trim(), ClassTimeStringList[4].Trim(), ClassTimeStringList[5].Trim(), ClassTimeStringList[6].Trim(), "",
                    "", "", _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, "", _courseNoteTextBox.Text, "", "");
                if (_courseSelectionComboBox.Text == Department.ComputerScience3.ToString())
                {
                    _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(course);
                    MessageBox.Show("新增成功");
                    _startUpForm.ReloadAllForm();
                }
                else if (_courseSelectionComboBox.Text == Department.ElectronicEngineering3.ToString())
                {
                    _courseManagementFormPresentationModel.AddIntoComputerScience3CourseList(course);
                    MessageBox.Show("新增成功");
                    _startUpForm.ReloadAllForm();
                }
            }
        }

        //ChangedText
        private void ChangedText(object sender, EventArgs e)
        {
            _saveCourseDataButton.Enabled = true;
        }
    }
}
