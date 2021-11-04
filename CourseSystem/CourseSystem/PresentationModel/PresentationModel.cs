using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class PresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        Model _model;
        const string FRONT_QUOTE = "「";
        const string SPACE = " ";
        const string BACK_QUOTE = "」";
        public PresentationModel(Model model)
        {
            _model = model;
            _model._modelChanged += ReloadForm;
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

        //Get
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

        //remove
        public void RemoveCourseFromComputerScience3(int index)
        {
            _model.RemoveCourseFromComputerScience3(index);
        }

        //remove
        public void RemoveCourseFromElectronicEngineering3(int index)
        {
            _model.RemoveCourseFromElectronicEngineering3(index);
        }

        //remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _model.RemoveCourseFromSelectionResult(index);
        }

        //CheckCourseList
        public string CheckCourseList(List<CourseInfo> checkedCourseList, List<CourseInfo> selectedCourseList)
        {
            string sameNumberMessage = "";
            string sameNameMessage = "";
            string sameTimeMessage = "";
            List<CourseInfo> allCourseList = selectedCourseList.Concat(checkedCourseList).ToList();
            sameNumberMessage = CheckSameNumber(allCourseList, checkedCourseList, sameNumberMessage);
            sameNameMessage = CheckSameName(allCourseList, checkedCourseList, sameNameMessage);
            sameTimeMessage = CheckSameTime(allCourseList, checkedCourseList, sameTimeMessage);
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

        //GetNumber
        private string GetNumber(CourseInfo courseInfo)
        {
            return courseInfo.Number;
        }

        //GetName
        private string GetName(CourseInfo courseInfo)
        {
            return courseInfo.Name;
        }

        //CheckSameNumber
        public string CheckSameNumber(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameNumberMessage)
        {
            foreach (CourseInfo checkedCourse in checkedCourseList)
            {
                int count = 0;
                foreach (CourseInfo selectedCourse in selectedCourseList)
                {
                    if (GetNumber(checkedCourse) == GetNumber(selectedCourse))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    sameNumberMessage = sameNumberMessage + FRONT_QUOTE + checkedCourse.Number + SPACE + checkedCourse.Name + BACK_QUOTE;
                }
            }
            return sameNumberMessage;
        }

        //CheckSameName
        public string CheckSameName(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameNameMessage)
        {
            foreach (CourseInfo checkedCourse in checkedCourseList)
            {
                int count = 0;
                foreach (CourseInfo selectedCourse in selectedCourseList)
                {
                    if (GetName(checkedCourse) == GetName(selectedCourse))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    sameNameMessage = sameNameMessage + FRONT_QUOTE + checkedCourse.Number + SPACE + checkedCourse.Name + BACK_QUOTE;
                }
            }
            return sameNameMessage;
        }

        //CheckSameTime
        public string CheckSameTime(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameTimeMessage)
        {
            foreach (CourseInfo checkedCourse in checkedCourseList)
            {
                int count = 0;
                foreach (CourseInfo selectedCourse in selectedCourseList)
                {
                    if (checkedCourse.GetCourseClassTime().Intersect(selectedCourse.GetCourseClassTime()).Count() > 0)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    sameTimeMessage = sameTimeMessage + FRONT_QUOTE + checkedCourse.Number + SPACE + checkedCourse.Name + BACK_QUOTE;
                }
            }
            return sameTimeMessage;
        }

        //GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex)
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            return _model.GetCourseInfoBySelectedIndex(selectedIndex);
        }

        //GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex)
        public Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            return _model.GetCourseDepartmentBySelectedIndex(selectedIndex);
        }

        //AddIntoSelectedCourseList
        public void AddIntoSelectedCourseList(CourseInfo course, int department)
        {
            _model.AddIntoSelectedCourseList(course, department);
        }

        //AddIntoComputerScience3CourseList
        public void AddIntoComputerScience3CourseList(CourseInfo course)
        {
            _model.AddIntoComputerScience3CourseList(course);
        }

        //AddIntoElectronicEngineering3CourseList
        public void AddIntoElectronicEngineering3CourseList(CourseInfo course)
        {
            _model.AddIntoElectronicEngineering3CourseList(course);
        }

        //RemoveCourseFromTabDictionary
        public void RemoveCourseFromTabDictionary(int index)
        {
            _model.RemoveCourseFromTabDictionary(index);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _model.AddSelectedCourse(selectingCourse);
        }

        //ReloadForm
        public void ReloadForm()
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
