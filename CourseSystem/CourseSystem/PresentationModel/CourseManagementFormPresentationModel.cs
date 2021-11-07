﻿using System;
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
            RemoveCourseFromCourseList(department.Item1, department.Item3);
            AddIntoCourseList(newCourse, listNameIndex);
            MessageBox.Show(MODIFY_SUCCESSFUL);
        }

        //SaveModifyCoursePartTwo
        public void SaveModifyCoursePartTwo(Tuple<int, int, int> department, CourseInfo newCourse, CourseInfo course, int listNameIndex)
        {
            List<CourseInfo> selectedCourseList = GetSelectedCourseList;
            RemoveCourseFromSelectedTabDictionary(department.Item3);
            selectedCourseList.RemoveAt(department.Item3);
            string checkedMessage = CheckCourseList(newCourse, selectedCourseList);
            if (checkedMessage == "")
            {
                MessageBox.Show(MODIFY_SUCCESSFUL);
                AddIntoSelectedCourseListAndCourseTab(newCourse, listNameIndex);
            }
            else
            {
                MessageBox.Show(MODIFY_NOT_SUCCESSFUL + ERROR_MESSAGE + checkedMessage);
                AddIntoSelectedCourseListAndCourseTab(course, department.Item2);
            }
        }

        //SaveModifyCoursePartThree
        public void SaveModifyCoursePartThree(Tuple<int, int, int> department, CourseInfo newCourse, int listNameIndex)
        {
            List<CourseInfo> notEnabledCourseList = GetNotEnabledCourseList;
            RemoveCourseFromNotEnabledTabDictionary(department.Item3);
            notEnabledCourseList.RemoveAt(department.Item3);
            AddIntoNotEnabledCourseListAndCourseTab(newCourse, listNameIndex);
            MessageBox.Show(MODIFY_SUCCESSFUL);
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
