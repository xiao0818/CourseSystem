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

        //get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _presentationModel.GetSelectedCourseList;
            }
        }

        //remove
        public void RemoveFromCourseList(int index, int rowIndex)
        {
            _presentationModel.RemoveFromCourseList(index, rowIndex);
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
