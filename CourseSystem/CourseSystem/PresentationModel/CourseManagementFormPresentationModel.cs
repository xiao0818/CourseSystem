using System;
using System.Collections.Generic;

namespace CourseSystem
{
    public class CourseManagementFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        bool _isSaveCourseDataButton = false;
        bool _isAddCourseDataButton = true;
        bool _isLoadComputerScienceCourseButton = true;
        bool _isAddClassButton = true;
        bool _isSaveAddClassButton = false;
        const string MODIFY_SUCCESSFUL = "編輯成功";
        const string MODIFY_NOT_SUCCESSFUL = "編輯失敗";
        const string ERROR_MESSAGE = "\n此編輯會導致已選課程發生:";
        const int TAB_SET = 2;
        const int SELECTED_LIST_TAB = -2;
        const int NOT_ENABLED_TAB = -1;
        public CourseManagementFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadCourseManagementForm;
        }

        //Get
        public List<List<CourseInfo>> GetCourseListCollection
        {
            get
            {
                return _presentationModel.GetCourseListCollection;
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

        //Get
        public List<CourseInfo> GetNotEnabledCourseList
        {
            get
            {
                return _presentationModel.GetNotEnabledCourseList;
            }
        }

        //Get
        public List<string> GetClassNameList
        {
            get
            {
                return _presentationModel.GetClassNameList;
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
        private void AddIntoSelectedCourseListAndCourseTab(CourseInfo course, int department)
        {
            _presentationModel.AddIntoSelectedCourseListAndCourseTab(course, department);
        }

        //AddIntoNotEnabledCourseListAndCourseTab
        public void AddIntoNotEnabledCourseListAndCourseTab(CourseInfo course, int department)
        {
            _presentationModel.AddIntoNotEnabledCourseListAndCourseTab(course, department);
        }

        //AddIntoComputerScience3CourseList
        public void AddIntoCourseList(CourseInfo course, int selectedIndex)
        {
            _presentationModel.AddIntoCourseList(course, selectedIndex);
        }

        //remove
        private void RemoveCourseFromCourseList(int classIndex, int index)
        {
            _presentationModel.RemoveCourseFromCourseList(classIndex, index);
        }

        //RemoveCourseFromSelectedTabDictionary
        private void RemoveCourseFromSelectedTabDictionary(int index)
        {
            _presentationModel.RemoveCourseFromSelectedTabDictionary(index);
        }

        //RemoveCourseFromNotEnabledTabDictionary
        private void RemoveCourseFromNotEnabledTabDictionary(int index)
        {
            _presentationModel.RemoveCourseFromNotEnabledTabDictionary(index);
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

        //IsAddCourseDataButton
        public bool IsLoadComputerScienceCourseButton
        {
            get
            {
                return _isLoadComputerScienceCourseButton;
            }
        }

        //ResetAllButton
        public void ResetAllButton()
        {
            _isAddCourseDataButton = _isLoadComputerScienceCourseButton = true;
            _isSaveCourseDataButton = false;
        }

        //SelectListBox
        public void SelectListBox()
        {
            _isAddCourseDataButton = true;
            _isSaveCourseDataButton = false;
        }

        //ClickAddButton
        public void ClickAddButton()
        {
            _isAddCourseDataButton = false;
        }

        //ChangeTextSuccessfully
        public void ChangeContentEnabled()
        {
            _isSaveCourseDataButton = true;
        }

        //ChangeTextUnsuccessfully
        public void ChangeContentNotEnabled()
        {
            _isSaveCourseDataButton = false;
        }

        //SaveModifyCourseMainForEnabled
        public string SaveModifyCourseMainForEnabled(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int selectedIndex)
        {
            if (department.Item1 != SELECTED_LIST_TAB && department.Item1 != NOT_ENABLED_TAB)
            {
                RemoveCourseFromCourseList(department.Item1, department.Item3);
                AddIntoCourseList(newCourse, selectedIndex);
                return MODIFY_SUCCESSFUL;
            }
            else if (department.Item1 == SELECTED_LIST_TAB)
            {
                RemoveCourseFromSelectedTabDictionary(department.Item3);
                _presentationModel.RemoveCourseFromSelectedList(department.Item3);
                return SaveModifyForSelectedCheck(department, newCourse, course, selectedIndex);
            }
            else
                return SaveModifyCoursePartThree(department, newCourse, course, selectedIndex);
        }

        //SaveModifyCourseMainForNotEnabled
        public string SaveModifyCourseMainForNotEnabled(Tuple<int, int, int> department, CourseInfo newCourse, int selectedIndex)
        {
            if (department.Item1 != SELECTED_LIST_TAB && department.Item1 != NOT_ENABLED_TAB)
            {
                RemoveCourseFromCourseList(department.Item1, department.Item3);
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, selectedIndex);
            }
            else if (department.Item1 == SELECTED_LIST_TAB)
            {
                List<CourseInfo> selectedCourseList = GetSelectedCourseList;
                RemoveCourseFromSelectedTabDictionary(department.Item3);
                selectedCourseList.RemoveAt(department.Item3);
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, selectedIndex / TAB_SET + 1);
            }
            else
                return SaveModifyCoursePartSix(department, newCourse, selectedIndex);
            return MODIFY_SUCCESSFUL;
        }

        //SaveModifyForSelectedCheck
        private string SaveModifyForSelectedCheck(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList;
            List<CourseInfo> selectingCourseList = new List<CourseInfo>();
            selectingCourseList.Add(newCourse);
            string checkedMessage = _presentationModel.CheckCourseList(selectingCourseList, selectedCourseList);
            if (checkedMessage == "")
            {
                AddIntoSelectedCourseListAndCourseTab(newCourse, listNameIndex);
                return MODIFY_SUCCESSFUL;
            }
            else if (department.Item1 == SELECTED_LIST_TAB)
                AddIntoSelectedCourseListAndCourseTab(course, department.Item2);
            else
                AddIntoNotEnabledCourseListAndCourseTab(course, department.Item2);
            return MODIFY_NOT_SUCCESSFUL + ERROR_MESSAGE + checkedMessage;
        }

        //SaveModifyCoursePartThree
        private string SaveModifyCoursePartThree(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> notEnabledCourseList = GetNotEnabledCourseList;
            RemoveCourseFromNotEnabledTabDictionary(department.Item3);
            notEnabledCourseList.RemoveAt(department.Item3);
            if (department.Item2 % TAB_SET == 0)
                AddIntoCourseList(newCourse, listNameIndex);
            else
                return SaveModifyForSelectedCheck(department, newCourse, course, listNameIndex);
            return MODIFY_SUCCESSFUL;
        }

        //SaveModifyCoursePartSix
        private string SaveModifyCoursePartSix(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            List<CourseInfo> notEnabledCourseList = GetNotEnabledCourseList;
            RemoveCourseFromNotEnabledTabDictionary(department.Item3);
            notEnabledCourseList.RemoveAt(department.Item3);
            if (department.Item2 % TAB_SET == 0)
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex);
            else
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex * TAB_SET + 1);
            return MODIFY_SUCCESSFUL;
        }

        //ClickLoadComputerScienceCourseTabButton
        public void ClickLoadComputerScienceCourseTabButton()
        {
            _isLoadComputerScienceCourseButton = false;
        }

        //FinishLoadComputerScienceCourse
        public void FinishLoadComputerScienceCourse()
        {
            _isLoadComputerScienceCourseButton = true;
        }

        //UpdataCourseSelectionResultForm
        private void ReloadCourseManagementForm()
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
                _presentationModelChanged();
        }

        //GetClassListForSelectedIndex
        public List<CourseInfo> GetClassListForSelectedIndex(int selectedIndex)
        {
            return _presentationModel.GetClassListForSelectedIndex(selectedIndex);
        }

        //AddClassNameList
        public void AddClassNameList(string className)
        {
            _presentationModel.AddClassNameList(className);
        }

        //IsAddClassButton
        public bool IsAddClassButton
        {
            get
            {
                return _isAddClassButton;
            }
        }

        //IsAddCourseDataButton
        public bool IsSaveAddClassButton
        {
            get
            {
                return _isSaveAddClassButton;
            }
        }

        //ResetClassButton
        public void ResetClassButton()
        {
            _isAddClassButton = true;
            _isSaveAddClassButton = false;
        }

        //ChangeClassButton
        public void ChangeClassButton()
        {
            _isAddClassButton = true;
        }

        //ChangedClassNameTextEnable
        public void ChangedClassNameTextEnable()
        {
            _isSaveAddClassButton = true;
        }

        //ChangedClassNameTextNotEnable
        public void ChangedClassNameTextNotEnable()
        {
            _isSaveAddClassButton = false;
        }
    }
}
