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
        Model _model;
        bool _isCheckButtonEnabled = true;
        bool _isSubmitButtonEnabled = false;
        public CourseSelectingFormPresentationModel(Model model)
        {
            _model = model;
            _model._modelChanged += ReloadCourseSelectingForm;
        }

        //get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _model.GetSelectedCourseList;
            }
        }

        //remove
        public void RemoveFromComputerScience3(int index)
        {
            _model.RemoveFromComputerScience3(index);
        }

        //remove
        public void RemoveFromElectronicEngineering3(int index)
        {
            _model.RemoveFromElectronicEngineering3(index);
        }

        //Get
        public List<CourseInfo> GetComputerScience3CourseList
        {
            get
            {
                return _model.GetComputerScience3CourseList;
            }
        }

        //Get
        public List<CourseInfo> GetElectronicEngineering3CourseList
        {
            get
            {
                return _model.GetElectronicEngineering3CourseList;
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
            return _model.CheckCourseList(checkedCourseList, selectedCourseList);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _model.AddSelectedCourse(selectingCourse);
        }

        //UpdataCourseSelectingForm
        public void ReloadCourseSelectingForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            _model.ReloadAllForm();
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
