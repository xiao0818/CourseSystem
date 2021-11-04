using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    public class CourseManagementFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        bool _isSaveCourseDataButton;
        bool _isAddCourseDataButton;
        const string MODIFY_SUCCESSFUL = "編輯成功";
        const string MODIFY_NOT_SUCCESSFUL = "編輯失敗";
        const string ERROR_MESSAGE = "\n此編輯會導致已選課程發生:";
        public CourseManagementFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadCourseManagementForm;
            _isAddCourseDataButton = true;
            _isSaveCourseDataButton = false;
        }

        //Get
        public List<CourseInfo> GetComputerScience3CourseList
        {
            get
            {
                return _presentationModel.GetComputerScience3CourseList;
            }
        }

        //Get
        public List<CourseInfo> GetElectronicEngineering3CourseList
        {
            get
            {
                return _presentationModel.GetElectronicEngineering3CourseList;
            }
        }

        //Get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _presentationModel.GetSelectedCourseList;
            }
        }

        //GetCourseInfoBySelectedIndex
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            return _presentationModel.GetCourseInfoBySelectedIndex(selectedIndex);
        }

        //GetCourseDepartmentBySelectedIndex
        public Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            return _presentationModel.GetCourseDepartmentBySelectedIndex(selectedIndex);
        }

        //AddIntoSelectedCourseList
        private void AddIntoSelectedCourseList(CourseInfo course, int department)
        {
            _presentationModel.AddIntoSelectedCourseList(course, department);
        }

        //AddIntoComputerScience3CourseList
        public void AddIntoComputerScience3CourseList(CourseInfo course)
        {
            _presentationModel.AddIntoComputerScience3CourseList(course);
        }

        //AddIntoElectronicEngineering3CourseList
        private void AddIntoElectronicEngineering3CourseList(CourseInfo course)
        {
            _presentationModel.AddIntoElectronicEngineering3CourseList(course);
        }

        //remove
        private void RemoveCourseFromComputerScience3(int index)
        {
            _presentationModel.RemoveCourseFromComputerScience3(index);
        }

        //remove
        private void RemoveCourseFromElectronicEngineering3(int index)
        {
            _presentationModel.RemoveCourseFromElectronicEngineering3(index);
        }

        //CheckCourseList
        private string CheckCourseList(CourseInfo selectedCourse, List<CourseInfo> selectedCourseList)
        {
            List<CourseInfo> selectingCourseList = new List<CourseInfo>();
            selectingCourseList.Add(selectedCourse);
            return _presentationModel.CheckCourseList(selectingCourseList, selectedCourseList);
        }

        //RemoveCourseFromTabDictionary
        private void RemoveCourseFromTabDictionary(int index)
        {
            _presentationModel.RemoveCourseFromTabDictionary(index);
        }

        //IsSaveCourseDataButton
        public bool IsSaveCourseDataButton
        {
            get
            {
                return _isSaveCourseDataButton;
            }
        }

        //IsAddCourseDataButton
        public bool IsAddCourseDataButton
        {
            get
            {
                return _isAddCourseDataButton;
            }
        }

        //ResetAllButton
        public void ResetAllButton()
        {
            _isSaveCourseDataButton = false;
            _isAddCourseDataButton = true;
        }

        //SelectListBox
        public void SelectListBox()
        {
            _isSaveCourseDataButton = false;
            _isAddCourseDataButton = true;
        }

        //ClickAddButton
        public void ClickAddButton()
        {
            _isSaveCourseDataButton = false;
            _isAddCourseDataButton = false;
        }

        //ChangeTextSuccessfully
        public void ChangeContentEnabled()
        {
            _isSaveCourseDataButton = true;
            _isAddCourseDataButton = false;
        }

        //ChangeTextUnsuccessfully
        public void ChangeContentNotEnabled()
        {
            _isSaveCourseDataButton = false;
            _isAddCourseDataButton = false;
        }

        //SaveModifyCoursePartOne
        public void SaveModifyCoursePartOne(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            if (department.Item1 == (int)ListName.ComputerScience3)
            {
                RemoveCourseFromComputerScience3(department.Item3);
            }
            else if (department.Item1 == (int)ListName.ElectronicEngineering3)
            {
                RemoveCourseFromElectronicEngineering3(department.Item3);
            }
            if (listNameIndex == (int)ListName.ComputerScience3)
            {
                AddIntoComputerScience3CourseList(newCourse);
            }
            else if (listNameIndex == (int)ListName.ElectronicEngineering3)
            {
                AddIntoElectronicEngineering3CourseList(newCourse);
            }
            MessageBox.Show(MODIFY_SUCCESSFUL);
        }

        //SaveModifyCoursePartTwo
        public void SaveModifyCoursePartTwo(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList;
            RemoveCourseFromTabDictionary(department.Item3);
            selectedCourseList.RemoveAt(department.Item3);
            string checkedMessage = CheckCourseList(newCourse, selectedCourseList);
            if (checkedMessage == "")
            {
                MessageBox.Show(MODIFY_SUCCESSFUL);
                AddIntoSelectedCourseList(newCourse, listNameIndex);
            }
            else
            {
                MessageBox.Show(MODIFY_NOT_SUCCESSFUL + ERROR_MESSAGE + checkedMessage);
                AddIntoSelectedCourseList(course, department.Item2);
            }
        }

        //UpdataCourseSelectionResultForm
        public void ReloadCourseManagementForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            _presentationModel.ReloadAllForm();
        }

        //NotifyObservers
        public void NotifyObserver()
        {
            if (_presentationModelChanged != null)
            {
                _presentationModelChanged();
            }
        }
    }
}
