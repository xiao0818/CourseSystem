using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class CourseSelectingFormPresentationModel
    {
        public event PresentationModelChangedEventHandler PresentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        Model _model;
        bool _isCheckButtonEnabled = true;
        bool _isSubmitButtonEnabled = false;
        public CourseSelectingFormPresentationModel(Model model)
        {
            _model = model;
            _model.ModelChanged += UpdataCourseSelectingForm;
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
        
        //set
        public void SetSelectedCourseList(List<CourseInfo> selectedCourseList)
        {
            _model.SetSelectedCourseList(selectedCourseList);
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
            string sameNumberMessage = "";
            string sameNameMessage = "";
            string sameTimeMessage = "";
            List<CourseInfo> allCourseList = selectedCourseList.Concat(checkedCourseList).ToList();
            sameNumberMessage = _model.CheckSameNumber(allCourseList, checkedCourseList, sameNumberMessage);
            sameNameMessage = _model.CheckSameName(allCourseList, checkedCourseList, sameNameMessage);
            sameTimeMessage = _model.CheckSameTime(allCourseList, checkedCourseList, sameTimeMessage);
            return GetSubmitResultMessage(sameNumberMessage, sameNameMessage, sameTimeMessage);
        }

        //GetSubmitResultMessage
        private string GetSubmitResultMessage(string sameNumberMessage, string sameNameMessage, string sameTimeMessage)
        {
            const string SAME_NUMBER_MESSAGE = "\n課號相同:";
            const string SAME_NAME_MESSAGE = "\n課程名稱相同:";
            const string SAME_TIME_MESSAGE = "\n衝堂:";
            if (sameNumberMessage != "")
            {
                sameNumberMessage = SAME_NUMBER_MESSAGE + sameNumberMessage;
            }
            if (sameNameMessage != "")
            {
                sameNameMessage = SAME_NAME_MESSAGE + sameNameMessage;
            }
            if (sameTimeMessage != "")
            {
                sameTimeMessage = SAME_TIME_MESSAGE + sameTimeMessage;
            }
            return sameNumberMessage + sameNameMessage + sameTimeMessage;
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _model.AddSelectedCourse(selectingCourse);
        }

        //UpdataCourseSelectingForm
        public void UpdataCourseSelectingForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void UpdateAllForm()
        {
            _model.UpdateAllForm();
        }

        //NotifyObservers
        public void NotifyObserver()
        {
            if (PresentationModelChanged != null)
            {
                PresentationModelChanged();
            }
        }
    }
}
