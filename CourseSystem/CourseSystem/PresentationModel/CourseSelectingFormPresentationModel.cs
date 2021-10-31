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

        //CheckDataGridViewCheckBox
        public void CheckDataGridViewCheckBox(DataGridView firstDataGridView, DataGridView secondDataGridView)
        {
            ResetSubmitButton();
            foreach (DataGridViewRow row in firstDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    HasEnabledCheckBox();
                    break;
                }
            }
            foreach (DataGridViewRow row in secondDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    HasEnabledCheckBox();
                    break;
                }
            }
        }

        //TakeOutCheckedCourseListFromDataGridView
        public List<CourseInfo> TakeOutCheckedCourseListFromDataGridView(List<CourseInfo> checkedCourseList, DataGridView dataGridView)
        {
            int numberOfCourse = dataGridView.RowCount;
            for (int index = 0; index < numberOfCourse; index++)
            {
                DataGridViewRow row = dataGridView.Rows[numberOfCourse - index - 1];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    CourseInfo selectedCourse = new CourseInfo
                    (
                        row.Cells[(int)CourseInfoHeaderText.Number + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Name + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Stage + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Credit + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Hour + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.CourseType + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Teacher + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime0 + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.ClassTime1 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime2 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime3 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime4 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime5 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.ClassTime6 + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Classroom + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.NumberOfStudent + 1].Value.ToString(),
                        row.Cells[(int)CourseInfoHeaderText.NumberOfDropStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.TeachingAssistant + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Language + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Outline + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Note + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.AttachStudent + 1].Value.ToString(), row.Cells[(int)CourseInfoHeaderText.Experiment + 1].Value.ToString()
                    );
                    checkedCourseList.Add(selectedCourse);
                }
            }
            return checkedCourseList;
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
