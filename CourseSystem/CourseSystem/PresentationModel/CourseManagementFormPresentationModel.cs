using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class CourseManagementFormPresentationModel
    {
        Model _model;
        public CourseManagementFormPresentationModel(Model model)
        {
            _model = model;
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

        //GetCourseInfoBySelectedIndex
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            return _model.GetCourseInfoBySelectedIndex(selectedIndex);
        }

        //GetCourseDepartmentBySelectedIndex
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

        //Remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _model.RemoveCourseFromSelectionResult(index);
        }

        //CheckCourseList
        public string CheckCourseList(CourseInfo selectedCourse, List<CourseInfo> selectedCourseList)
        {
            string sameNumberMessage = "";
            string sameNameMessage = "";
            string sameTimeMessage = "";
            selectedCourseList.Add(selectedCourse);
            List<CourseInfo> allCourseList = selectedCourseList;
            sameNumberMessage = _model.CheckSameNumber(allCourseList, selectedCourseList, sameNumberMessage);
            sameNameMessage = _model.CheckSameName(allCourseList, selectedCourseList, sameNameMessage);
            sameTimeMessage = _model.CheckSameTime(allCourseList, selectedCourseList, sameTimeMessage);
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

        //RemoveCourseFromTabDictionary
        public void RemoveCourseFromTabDictionary(int index)
        {
            _model.RemoveCourseFromTabDictionary(index);
        }
    }
}
