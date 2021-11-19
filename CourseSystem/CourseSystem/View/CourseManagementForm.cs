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
        ImportCourseProgressForm _importCourseProgressForm;
        ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        CourseManagementFormPresentationModel _courseManagementFormPresentationModel;
        StartUpForm _startUpForm;
        int _index;
        const int DAY_PER_WEEK = 7;
        const string SPACE = " ";
        const string CLASS_TIME_CHAR = "1234N56789ABCD";
        const string DOT = ".";
        const string MODIFY_COURSE = "編輯課程";
        const string ADD_SUCCESSFUL = "新增成功";
        const string ENABLED = "開課";
        const string NOT_ENABLED = "停開";
        const int COUNT_OF_TAB = 6;
        public CourseManagementForm(StartUpForm startUpForm, CourseManagementFormPresentationModel courseManagementFormPresentationModel, ImportCourseProgressFormPresentationModel importCourseProgressFormPresentationModel)
        {
            _index = 0;
            _courseManagementFormPresentationModel = courseManagementFormPresentationModel;
            _startUpForm = startUpForm;
            _importCourseProgressFormPresentationModel = importCourseProgressFormPresentationModel;
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
        private void LoadCourseListBox()
        {
            _courseListBox.Items.Clear();
            foreach (List<CourseInfo> courseList in _courseManagementFormPresentationModel.GetCourseListCollection)
            {
                foreach (CourseInfo course in courseList)
                {
                    _courseListBox.Items.Add(course.Name);
                }
            }
            foreach (CourseInfo course in _courseManagementFormPresentationModel.GetSelectedCourseList)
            {
                _courseListBox.Items.Add(course.Name);
            }
            foreach (CourseInfo course in _courseManagementFormPresentationModel.GetNotEnabledCourseList)
            {
                _courseListBox.Items.Add(course.Name);
            }
        }

        //AddRowsInClassTimeDataGridView
        private void AddRowsInClassTimeDataGridView()
        {
            _courseTimeDataGridView.Rows.Clear();
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
                _courseTimeDataGridView.Rows.Add(row);
            }
        }

        //ChangedSelectedIndexCourseListBox
        private void ChangedSelectedIndexCourseListBox(object sender, EventArgs e)
        {
            _courseDataGroupBox.Text = "編輯課程";
            _saveCourseDataButton.Text = "儲存";
            CourseInfo course = _courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex);
            Tuple<int, int, int> department = GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex);
            LoadCourseContext(department, course);
            _courseManagementFormPresentationModel.SelectListBox();
            _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
            _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
        }

        //LoadContext
        private void LoadCourseContext(Tuple<int, int, int> department, CourseInfo course)
        {
            LoadTextBoxAndComboBox(course);
            LoadClassComboBox(department);
            LoadEnabledComboBox(department);
            AddRowsInClassTimeDataGridView();
            foreach (Tuple<int, string> time in course.GetCourseClassTime())
            {
                _courseTimeDataGridView.Rows[TranslateClassTimeToIndex(time.Item2)].Cells[time.Item1 + 1].Value = Enabled;
            }
            SetAllObjectInGroupBoxEnabled(true);
        }

        //LoadClassComboBox
        private void LoadClassComboBox(Tuple<int, int, int> department)
        {
            List<string> classNameList = _courseManagementFormPresentationModel.GetClassNameList;
            _courseClassSelectionComboBox.Text = classNameList[department.Item2 % COUNT_OF_TAB];
        }

        //LoadEnabledComboBox
        private void LoadEnabledComboBox(Tuple<int, int, int> department)
        {
            if (department.Item1 == (int)Department.NotEnabledList)
            {
                _courseEnabledComboBox.Text = NOT_ENABLED;
            }
            else
            {
                _courseEnabledComboBox.Text = ENABLED;
            }
        }

        //LoadTextBoxAndComboBox
        private void LoadTextBoxAndComboBox(CourseInfo course)
        {
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
            _courseTimeDataGridView.Enabled = enable;
        }

        //LoadManagementForm
        private void LoadManagementForm()
        {
            if (_index == 0)
            {
                LoadCourseListBox();
                SetAllObjectInGroupBoxEmpty();
                AddRowsInClassTimeDataGridView();
                SetAllObjectInGroupBoxEnabled(false);
                _courseManagementFormPresentationModel.ResetAllButton();
                _saveCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsSaveCourseDataButton;
                _addCourseDataButton.Enabled = _courseManagementFormPresentationModel.IsAddCourseDataButton;
                _loadComputerScienceButton.Enabled = _courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton;
                _courseTimeDataGridView.ClearSelection();
                UpdateCourseClassSelectionComboBox();
            }
            else
            {
                LoadClassListBox();
                _classNameTextBox.Text = "";
                _courseInClassListBox.Items.Clear();
                _courseInClassListBox.ClearSelected();
                _classListBox.ClearSelected();
            }
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
            _courseDataGroupBox.Text = "新增課程";
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
                if (Convert.ToBoolean(_courseTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                {
                    _courseTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    _courseTimeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
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
            _courseTimeDataGridView.EndEdit();
            if (_courseDataGroupBox.Text == MODIFY_COURSE)
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
            List<string> classTimeStringList = TakeOutClassTimeFromDataGridView(_courseTimeDataGridView.Rows);
            CourseInfo newCourse = new CourseInfo(
                _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                classTimeStringList[(int)Day.Sunday].Trim(), classTimeStringList[(int)Day.Monday].Trim(), classTimeStringList[(int)Day.Tuesday].Trim(), classTimeStringList[(int)Day.Wednesday].Trim(), classTimeStringList[(int)Day.Thursday].Trim(), classTimeStringList[(int)Day.Friday].Trim(), classTimeStringList[(int)Day.Saturday].Trim(), course.Classroom,
                course.NumberOfStudent, course.NumberOfDropStudent, _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, course.Outline, _courseNoteTextBox.Text, course.AttachStudent, course.Experiment);
            if (_courseEnabledComboBox.Text == ENABLED)
            {
                MessageBox.Show(_courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(department, newCourse, course, _courseClassSelectionComboBox.SelectedIndex));
            }
            else
            {
                MessageBox.Show(_courseManagementFormPresentationModel.SaveModifyCourseMainForNotEnabled(department, newCourse, _courseClassSelectionComboBox.SelectedIndex));
            }
        }

        //GetCourseDepartmentBySelectedIndex
        private Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            return _courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(selectedIndex);
        }

        //SaveAddCourse
        private void SaveAddCourse()
        {
            List<string> classTimeStringList = TakeOutClassTimeFromDataGridView(_courseTimeDataGridView.Rows);
            CourseInfo course = new CourseInfo(
                _courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text, _courseClassTimeSelectionComboBox.Text, _courseTypeSelectionComboBox.Text, _courseTeacherTextBox.Text,
                classTimeStringList[0].Trim(), classTimeStringList[1].Trim(), classTimeStringList[2].Trim(), classTimeStringList[3].Trim(), classTimeStringList[4].Trim(), classTimeStringList[5].Trim(), classTimeStringList[6].Trim(), "",
                "", "", _courseTeachingAssistantTextBox.Text, _courseLanguageTextBox.Text, "", _courseNoteTextBox.Text, "", "");
            if (_courseEnabledComboBox.Text == ENABLED)
            {
                _courseManagementFormPresentationModel.AddIntoCourseList(course, _courseClassSelectionComboBox.SelectedIndex);
            }
            else if (_courseEnabledComboBox.Text == NOT_ENABLED)
            {
                _courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(course, _courseClassSelectionComboBox.SelectedIndex);
            }
            MessageBox.Show(ADD_SUCCESSFUL);
        }

        //ChangedText
        private void ChangedText(object sender, EventArgs e)
        {
            ChangedGroupBox();
        }

        //ChangedCellValueClassTimeDataGridView
        private void ChangedCellValueClassTimeDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            _courseTimeDataGridView.EndEdit();
            ChangedGroupBox();
        }

        //ChangedGroupBox
        private void ChangedGroupBox()
        {
            int count = GetClassTimeTotal(_courseTimeDataGridView.Rows);
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

        //TakeOutClassTimeFromDataGridView
        private List<string> TakeOutClassTimeFromDataGridView(DataGridViewRowCollection rows)
        {
            List<string> classTimeStringList = new List<string>();
            for (int day = 0; day < DAY_PER_WEEK; day++)
            {
                classTimeStringList.Add("");
                foreach (DataGridViewRow row in rows)
                {
                    if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                    {
                        classTimeStringList[day] = classTimeStringList[day] + row.Cells[0].Value + SPACE;
                    }
                    classTimeStringList[day] = classTimeStringList[day];
                }
            }
            return classTimeStringList;
        }

        //GetClassTimeTotal
        private int GetClassTimeTotal(DataGridViewRowCollection rows)
        {
            int count = 0;
            for (int day = 0; day < DAY_PER_WEEK; day++)
            {
                foreach (DataGridViewRow row in rows)
                {
                    if (Convert.ToBoolean(row.Cells[day + 1].Value) == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //ClickLoadComputerScienceButton
        private void ClickLoadComputerScienceButton(object sender, EventArgs e)
        {
            AddClassName("資工三");
            AddClassName("資工一");
            AddClassName("資工二");
            AddClassName("資工四");
            AddClassName("資工所");
            _courseManagementFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
            _importCourseProgressForm = new ImportCourseProgressForm(_importCourseProgressFormPresentationModel, this);
            _importCourseProgressForm.ShowDialog();
            _courseManagementFormPresentationModel.ReloadAllForm();
        }

        //FinishLoadComputerScienceCourse
        public void FinishLoadComputerScienceCourse()
        {
            _courseManagementFormPresentationModel.FinishLoadComputerScienceCourse();
            _loadComputerScienceButton.Enabled = _courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton;
        }

        //UpdateAllForm
        private void UpdateAllForm()
        {
            _courseManagementFormPresentationModel.ReloadAllForm();
        }

        //ChangedSelectedIndexManagementTabControl
        private void ChangedSelectedIndexManagementTabControl(object sender, EventArgs e)
        {
            _index = _managementTabControl.SelectedIndex;
            LoadManagementForm();
        }

        //LoadClassListBox
        private void LoadClassListBox()
        {
            _classListBox.Items.Clear();
            foreach (string className in _courseManagementFormPresentationModel.GetClassNameList)
            {
                _classListBox.Items.Add(className);
            }
        }

        //ChangedSelectedIndexClassListBox
        private void ChangedSelectedIndexClassListBox(object sender, EventArgs e)
        {
            _classGroupBox.Text = "班級";
            _addClassButton.Enabled = true;
            _saveAddClassButton.Enabled = false;
            _classNameTextBox.ReadOnly = true;
            _classNameTextBox.Text = (string)_classListBox.SelectedItem;
            _courseInClassListBox.Items.Clear();
            foreach (CourseInfo course in _courseManagementFormPresentationModel.GetClassListForSelectedIndex(_classListBox.SelectedIndex))
            {
                _courseInClassListBox.Items.Add(course.Name);
            }
        }

        //UpdateCourseClassSelectionComboBox
        private void UpdateCourseClassSelectionComboBox()
        {
            _courseClassSelectionComboBox.Items.Clear();
            foreach (string className in _courseManagementFormPresentationModel.GetClassNameList)
            {
                _courseClassSelectionComboBox.Items.Add(className);
            }
        }

        //AddClassName
        private void AddClassName(string className)
        {
            _courseManagementFormPresentationModel.AddClassNameList(className);
            //if (_courseManagementFormPresentationModel.GetClassNameList.Contains(className) == false)
            //{
            //    _courseManagementFormPresentationModel.AddClassNameList(className);
            //    MessageBox.Show("新增成功");
            //}
            //else
            //{
            //    MessageBox.Show("新增失敗\n" + className + "已存在");
            //}
        }

        //ClickSaveAddClassButton
        private void ClickSaveAddClassButton(object sender, EventArgs e)
        {
            AddClassName(_classNameTextBox.Text);
        }

        //ClickAddClassButton
        private void ClickAddClassButton(object sender, EventArgs e)
        {
            _classGroupBox.Text = "新增班級";
            _addClassButton.Enabled = false;
            _saveAddClassButton.Enabled = false;
            _classNameTextBox.ReadOnly = false;
            _classNameTextBox.Text = "";
            _courseInClassListBox.Items.Clear();
        }

        //TextChangedClassNameTextBox
        private void TextChangedClassNameTextBox(object sender, EventArgs e)
        {
            if (_classNameTextBox.Text != "" && _classGroupBox.Text == "新增班級" && !_courseManagementFormPresentationModel.GetClassNameList.Contains(_classNameTextBox.Text))
            {
                _saveAddClassButton.Enabled = true;
            }
            else
            {
                _saveAddClassButton.Enabled = false;

            }
        }
    }
}
