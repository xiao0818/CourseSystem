using System;
using System.Collections.Generic;

namespace CourseSystem
{
    public class CourseManagementFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        bool _isSaveCourseDataButton;
        bool _isAddCourseDataButton;
        bool _isLoadComputerScienceCourseButton;
        const string MODIFY_SUCCESSFUL = "編輯成功";
        const string MODIFY_NOT_SUCCESSFUL = "編輯失敗";
        const string ERROR_MESSAGE = "\n此編輯會導致已選課程發生:";
        public CourseManagementFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadCourseManagementForm;
            _isAddCourseDataButton = true;
            _isSaveCourseDataButton = false;
            _isLoadComputerScienceCourseButton = true;
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

        //CheckCourseList
        private string CheckCourseList(CourseInfo selectedCourse, List<CourseInfo> selectedCourseList)
        {
            List<CourseInfo> selectingCourseList = new List<CourseInfo>();
            selectingCourseList.Add(selectedCourse);
            return _presentationModel.CheckCourseList(selectingCourseList, selectedCourseList);
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
            _isAddCourseDataButton = true;
            _isSaveCourseDataButton = false;
            _isLoadComputerScienceCourseButton = true;
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
            _isSaveCourseDataButton = false;
        }

        //ChangeTextSuccessfully
        public void ChangeContentEnabled()
        {
            _isAddCourseDataButton = false;
            _isSaveCourseDataButton = true;
        }

        //ChangeTextUnsuccessfully
        public void ChangeContentNotEnabled()
        {
            _isAddCourseDataButton = false;
            _isSaveCourseDataButton = false;
        }

        //SaveModifyCourseMainForEnabled
        public string SaveModifyCourseMainForEnabled(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int selectedIndex)
        {
            if (department.Item1 != (int)Department.SelectedList && department.Item1 != (int)Department.NotEnabledList)
            {
                return SaveModifyCoursePartOne(department, newCourse, selectedIndex);
            }
            else if (department.Item1 == (int)Department.SelectedList)
            {
                return SaveModifyCoursePartTwo(department, newCourse, course, selectedIndex);
            }
            else
            {
                return SaveModifyCoursePartThree(department, newCourse, course, selectedIndex);
            }
        }

        //SaveModifyCourseMainForNotEnabled
        public string SaveModifyCourseMainForNotEnabled(Tuple<int, int, int> department, CourseInfo newCourse, int selectedIndex)
        {
            if (department.Item1 != (int)Department.SelectedList && department.Item1 != (int)Department.NotEnabledList)
            {
                return SaveModifyCoursePartFour(department, newCourse, selectedIndex);
            }
            else if (department.Item1 == (int)Department.SelectedList)
            {
                return SaveModifyCoursePartFive(department, newCourse, selectedIndex);
            }
            else
            {
                return SaveModifyCoursePartSix(department, newCourse, selectedIndex);
            }
        }

        //SaveModifyForSelectedCheck
        private string SaveModifyForSelectedCheck(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList;
            string checkedMessage = CheckCourseList(newCourse, selectedCourseList);
            if (checkedMessage == "")
            {
                AddIntoSelectedCourseListAndCourseTab(newCourse, listNameIndex / 2);
                return MODIFY_SUCCESSFUL;
            }
            else if (department.Item1 == (int)Department.SelectedList)
            {
                AddIntoSelectedCourseListAndCourseTab(course, department.Item2);
            }
            else
            {
                AddIntoNotEnabledCourseListAndCourseTab(course, department.Item2);
            }
            return MODIFY_NOT_SUCCESSFUL + ERROR_MESSAGE + checkedMessage;
        }

        //SaveModifyCoursePartOne
        private string SaveModifyCoursePartOne(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            RemoveCourseFromCourseList(department.Item1, department.Item3);
            AddIntoCourseList(newCourse, listNameIndex);
            return MODIFY_SUCCESSFUL;
        }

        //SaveModifyCoursePartTwo
        private string SaveModifyCoursePartTwo(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            RemoveCourseFromSelectedTabDictionary(department.Item3);
            _presentationModel.RemoveCourseFromSelectedList(department.Item3);
            return SaveModifyForSelectedCheck(department, newCourse, course, listNameIndex);
        }

        //SaveModifyCoursePartThree
        private string SaveModifyCoursePartThree(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> notEnabledCourseList = GetNotEnabledCourseList;
            RemoveCourseFromNotEnabledTabDictionary(department.Item3);
            notEnabledCourseList.RemoveAt(department.Item3);
            if (department.Item2 % 2 == 0)
            {
                AddIntoCourseList(newCourse, listNameIndex);
                return MODIFY_SUCCESSFUL;
            }
            else
            {
                return SaveModifyForSelectedCheck(department, newCourse, course, listNameIndex / 2 + 1);
            }
        }

        //SaveModifyCoursePartFour
        private string SaveModifyCoursePartFour(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            RemoveCourseFromCourseList(department.Item1, department.Item3);
            AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex);
            return MODIFY_SUCCESSFUL;
        }

        //SaveModifyCoursePartFive
        private string SaveModifyCoursePartFive(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList;
            RemoveCourseFromSelectedTabDictionary(department.Item3);
            selectedCourseList.RemoveAt(department.Item3);
            AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex / 2 + 1);
            return MODIFY_SUCCESSFUL;
        }

        //SaveModifyCoursePartSix
        private string SaveModifyCoursePartSix(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            List<CourseInfo> notEnabledCourseList = GetNotEnabledCourseList;
            RemoveCourseFromNotEnabledTabDictionary(department.Item3);
            notEnabledCourseList.RemoveAt(department.Item3);
            if (department.Item2 % 2 == 0)
            {
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex);
            }
            else
            {
                AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex / 2 + 1);
            }
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
            {
                _presentationModelChanged();
            }
        }
    }
}
