using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    public class CourseSelectingFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        bool _isCheckButtonEnabled = true;
        bool _isSubmitButtonEnabled = false;
        public CourseSelectingFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadCourseSelectingForm;
        }

        //UpdateCourseListInfo
        public void UpdateCourseListInfo(int departmentIndex)
        {
            _presentationModel.UpdateCourseListInfo(departmentIndex);
        }

        //get
        public List<CourseInfo> GetCourseList(int index)
        {
            return _presentationModel.GetCourseList(index);
        }

        //get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _presentationModel.GetSelectedCourseList;
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

        //remove
        public void RemoveFromCourseListAndAddInToSelectedTab(int index, int rowIndex)
        {
            _presentationModel.RemoveFromCourseListAndAddInToSelectedTab(index, rowIndex);
        }

        //ResetCheckButton
        public void ResetCheckButton()
        {
            _isCheckButtonEnabled = true;
        }

        //ResetSubmitButton
        public void ResetSubmitButton()
        {
            _isSubmitButtonEnabled = false;
        }

        //IsCheckButtonEnabled
        public bool IsCheckButtonEnabled
        {
            get
            {
                return _isCheckButtonEnabled;
            }
        }

        //IsSubmitButtonEnabled
        public bool IsSubmitButtonEnabled
        {
            get
            {
                return _isSubmitButtonEnabled;
            }
        }

        //ClickCheckButton
        public void ClickCheckButton()
        {
            _isCheckButtonEnabled = false;
        }

        //HasEnabledCheckBox
        public void HasEnabledCheckBox()
        {
            _isSubmitButtonEnabled = true;
        }

        //CheckCourseList
        public string CheckCourseList(List<CourseInfo> checkedCourseList, List<CourseInfo> selectedCourseList)
        {
            return _presentationModel.CheckCourseList(checkedCourseList, selectedCourseList);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _presentationModel.AddSelectedCourse(selectingCourse);
        }

        //GetIsLoadComputerScienceCourseTab
        public bool IsLoadComputerScienceCourseTab
        {
            get
            {
                return _presentationModel.IsLoadComputerScienceCourseTab;
            }
        }

        //FinishLoadComputerScienceCourseTabButton
        public void FinishLoadComputerScienceCourseTabButton()
        {
            _presentationModel.FinishLoadComputerScienceCourseTabButton();
        }

        //WaitNSeconds
        public void WaitSeconds(int second)
        {
            _presentationModel.WaitSeconds(second);
        }

        //UpdataCourseSelectingForm
        public void ReloadCourseSelectingForm()
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
