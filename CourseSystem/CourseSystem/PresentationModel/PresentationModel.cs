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
        List<string> _classNameList = new List<string>();
        const string COMPUTER_SCIENCE_3_NAME = "資工三";
        const string ELECTRONIC_ENGINEERING_3_NAME = "電子三甲";
        const string COMPUTER_SCIENCE_5_NAME = "資工所";
        const string COMPUTER_SCIENCE_4_NAME = "資工四";
        const string COMPUTER_SCIENCE_2_NAME = "資工二";
        const string COMPUTER_SCIENCE_1_NAME = "資工一";
        bool _isLoadComputerScienceCourseTab;
        public PresentationModel(Model model)
        {
            _classNameList.Add(COMPUTER_SCIENCE_3_NAME);
            _classNameList.Add(ELECTRONIC_ENGINEERING_3_NAME);
            _classNameList.Add(COMPUTER_SCIENCE_5_NAME);
            _classNameList.Add(COMPUTER_SCIENCE_4_NAME);
            _classNameList.Add(COMPUTER_SCIENCE_2_NAME);
            _classNameList.Add(COMPUTER_SCIENCE_1_NAME);
            _model = model;
            _model._modelChanged += ReloadForm;
            _isLoadComputerScienceCourseTab = false;
        }

        //UpdateCourseListInfo
        public void UpdateCourseListInfo(int departmentIndex)
        {
            _model.UpdateCourseListInfo(departmentIndex);
        }

        //get
        public List<CourseInfo> GetCourseList(int index)
        {
            return _model.GetCourseList(index);
        }

        //Get
        public List<List<CourseInfo>> GetCourseListCollection
        {
            get
            {
                return _model.GetCourseListCollection;
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

        //Get
        public List<CourseInfo> GetNotEnabledCourseList
        {
            get
            {
                return _model.GetNotEnabledCourseList;
            }
        }

        //Get
        public List<string> GetClassNameList
        {
            get
            {
                return _classNameList;
            }
        }

        //remove
        public void RemoveFromCourseListAndAddInToSelectedTab(int index, int rowIndex)
        {
            _model.RemoveFromCourseListAndAddInToSelectedTab(index, rowIndex);
        }

        //remove
        public void RemoveCourseFromCourseList(int classIndex, int index)
        {
            _model.RemoveCourseFromCourseList(classIndex, index);
        }

        //remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _model.RemoveCourseFromSelectionResult(index);
        }

        //remove
        public void RemoveCourseFromSelectedList(int index)
        {
            _model.RemoveCourseFromSelectedList(index);
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
        private string CheckSameNumber(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameNumberMessage)
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
        private string CheckSameName(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameNameMessage)
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
        private string CheckSameTime(List<CourseInfo> selectedCourseList, List<CourseInfo> checkedCourseList, string sameTimeMessage)
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

        //AddIntoSelectedCourseListAndCourseTab
        public void AddIntoSelectedCourseListAndCourseTab(CourseInfo course, int department)
        {
            _model.AddIntoSelectedCourseListAndCourseTab(course, department);
        }

        //AddIntoNotEnabledCourseListAndCourseTab
        public void AddIntoNotEnabledCourseListAndCourseTab(CourseInfo course, int department)
        {
            _model.AddIntoNotEnabledCourseListAndCourseTab(course, department);
        }

        //AddIntoCourseList
        public void AddIntoCourseList(CourseInfo course, int selectedIndex)
        {
            _model.AddIntoCourseList(course, selectedIndex);
        }

        //RemoveCourseFromSelectedTabDictionary
        public void RemoveCourseFromSelectedTabDictionary(int index)
        {
            _model.RemoveCourseFromSelectedTabDictionary(index);
        }

        //RemoveCourseFromNotEnabledTabDictionary
        public void RemoveCourseFromNotEnabledTabDictionary(int index)
        {
            _model.RemoveCourseFromNotEnabledTabDictionary(index);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _model.AddSelectedCourse(selectingCourse);
        }

        //ClickLoadComputerScienceCourseTabButton
        public void ClickLoadComputerScienceCourseTabButton()
        {
            _isLoadComputerScienceCourseTab = true;
            ReloadAllForm();
        }

        //IsLoadComputerScienceCourseTab
        public bool IsLoadComputerScienceCourseTab
        {
            get
            {
                return _isLoadComputerScienceCourseTab;
            }
        }

        //FinishLoadComputerScienceCourseTabButton
        public void FinishLoadComputerScienceCourseTabButton()
        {
            _isLoadComputerScienceCourseTab = false;
        }

        //WaitNSeconds
        public void WaitSeconds(int second)
        {
            if (second < 1)
            {
                return;
            }
            DateTime desired = DateTime.Now.AddSeconds(second);
            while (DateTime.Now < desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        //ReloadForm
        private void ReloadForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            _model.ReloadAllForm();
        }

        //NotifyObservers
        private void NotifyObserver()
        {
            if (_presentationModelChanged != null)
            {
                _presentationModelChanged();
            }
        }
    }
}
