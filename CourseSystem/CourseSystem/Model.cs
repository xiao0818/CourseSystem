using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CourseSystem
{
    public class Model
    {
        const string WEB_COMPUTER_SCIENCE_3 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        const string WEB_ELECTRONIC_ENGINEERING_3_A = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
        private List<CourseInfo> _computerScience3CourseList;
        private List<CourseInfo> _electronicEngineering3CourseList;
        private List<CourseInfo> _selectedCourseList;
        private Dictionary<string, int> _courseTabDictionary;
        const string STRUCTURE = "//body/table";
        const string FRONT_QUOTE = "「";
        const string SEPARATER = " ";
        const string BACK_QUOTE = "」";
        public Model()
        {
            _computerScience3CourseList = GetCourseInfo(WEB_COMPUTER_SCIENCE_3);
            _electronicEngineering3CourseList = GetCourseInfo(WEB_ELECTRONIC_ENGINEERING_3_A);
            _selectedCourseList = new List<CourseInfo>();
            SortAll();
            _courseTabDictionary = new Dictionary<string, int>();
        }

        //爬蟲網頁資料
        private List<CourseInfo> GetCourseInfo(string web)
        {
            HtmlNodeCollection nodeTableRow = GetFirst(web);
            List<CourseInfo> courseInfo = new List<CourseInfo>();

            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);
                courseInfo.Add(GetNewCourseInfo(nodeTableDatas));
            }
            return courseInfo;
        }

        //GetFirstPart
        private HtmlNodeCollection GetFirst(string web)
        {
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = webClient.Load(web);

            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(STRUCTURE);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;

            // 移除 tbody
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>資工三
            nodeTableRow.RemoveAt(0);
            // 移除 table header
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>小計
            nodeTableRow.RemoveAt(GetCount(nodeTableRow));
            return nodeTableRow;
        }

        //GetCount
        private int GetCount(HtmlNodeCollection nodeTableRow)
        {
            return nodeTableRow.Count - 1;
        }

        //GetNewCourseInfo
        private CourseInfo GetNewCourseInfo(HtmlNodeCollection nodeTableDatas)
        {
            return new CourseInfo(
                        nodeTableDatas[(int)CourseInfoHeaderText.Number].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Name].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Stage].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Credit].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Hour].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.CourseType].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Teacher].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime0].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.ClassTime1].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime2].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.ClassTime3].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime4].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.ClassTime5].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime6].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Classroom].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.NumberOfStudent].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.NumberOfDropStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.TeachingAssistant].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Language].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Outline].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Note].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.AttachStudent].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.Experiment].InnerText.Trim()
                        );
        }

        //Get
        public List<CourseInfo> GetComputerScience3CourseList
        {
            get
            {
                return _computerScience3CourseList;
            }
        }

        //Get
        public List<CourseInfo> GetElectronicEngineering3CourseList
        {
            get
            {
                return _electronicEngineering3CourseList;
            }
        }

        //Get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _selectedCourseList;
            }
        }

        //update
        public void SetSelectedCourseList(List<CourseInfo> selectedCourseList)
        {
            _selectedCourseList = selectedCourseList;
            SortAll();
        }

        //remove
        public void RemoveFromComputerScience3(int index)
        {
            _courseTabDictionary.Add(_computerScience3CourseList[index].Number, (int)Department.ComputerScience3);
            _computerScience3CourseList.RemoveAt(index);
        }

        //remove
        public void RemoveFromElectronicEngineering3(int index)
        {
            _courseTabDictionary.Add(_electronicEngineering3CourseList[index].Number, (int)Department.ElectronicEngineering3);
            _electronicEngineering3CourseList.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromComputerScience3(int index)
        {
            _courseTabDictionary.Add(_computerScience3CourseList[index].Number, (int)Department.ComputerScience3);
            _computerScience3CourseList.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromElectronicEngineering3(int index)
        {
            _courseTabDictionary.Add(_electronicEngineering3CourseList[index].Number, (int)Department.ElectronicEngineering3);
            _electronicEngineering3CourseList.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            if (_courseTabDictionary[_selectedCourseList[index].Number] == (int)Department.ComputerScience3)
            {
                _computerScience3CourseList.Add(_selectedCourseList[index]);
            }
            if (_courseTabDictionary[_selectedCourseList[index].Number] == (int)Department.ElectronicEngineering3)
            {
                _electronicEngineering3CourseList.Add(_selectedCourseList[index]);
            }
            _courseTabDictionary.Remove(_selectedCourseList[index].Number);
            _selectedCourseList.RemoveAt(index);
            SortAll();
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

        //sort
        private void SortAll()
        {
            _selectedCourseList.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
            _computerScience3CourseList.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
            _electronicEngineering3CourseList.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
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
                    sameNumberMessage = sameNumberMessage + FRONT_QUOTE + checkedCourse.Number + SEPARATER + checkedCourse.Name + BACK_QUOTE;
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
                    sameNameMessage = sameNameMessage + FRONT_QUOTE + checkedCourse.Number + SEPARATER + checkedCourse.Name + BACK_QUOTE;
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
                    sameTimeMessage = sameTimeMessage + FRONT_QUOTE + checkedCourse.Number + SEPARATER + checkedCourse.Name + BACK_QUOTE;
                }
            }
            return sameTimeMessage;
        }

        //GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex)
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            if (selectedIndex < _computerScience3CourseList.Count)
            {
                return _computerScience3CourseList[selectedIndex];
            }
            else if (selectedIndex - _computerScience3CourseList.Count < _electronicEngineering3CourseList.Count)
            {
                return _electronicEngineering3CourseList[selectedIndex - _computerScience3CourseList.Count];
            }
            else
            {
                return _selectedCourseList[selectedIndex - _computerScience3CourseList.Count - _electronicEngineering3CourseList.Count];
            }
        }

        //GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex)
        public Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            if (selectedIndex < _computerScience3CourseList.Count)
            {
                return Tuple.Create(0, (int)Department.ComputerScience3, selectedIndex);
            }
            else if (selectedIndex - _computerScience3CourseList.Count < _electronicEngineering3CourseList.Count)
            {
                return Tuple.Create(1, (int)Department.ElectronicEngineering3, selectedIndex - _computerScience3CourseList.Count);
            }
            else
            {
                return Tuple.Create(2, _courseTabDictionary[_selectedCourseList[selectedIndex - _computerScience3CourseList.Count - _electronicEngineering3CourseList.Count].Number], selectedIndex - _computerScience3CourseList.Count - _electronicEngineering3CourseList.Count);
            }
        }

        //AddIntoSelectedCourseList
        public void AddIntoSelectedCourseList(CourseInfo course, int department)
        {
            _selectedCourseList.Add(course);
            _courseTabDictionary.Add(course.Number, department);
            SortAll();
        }

        //AddIntoComputerScience3CourseList
        public void AddIntoComputerScience3CourseList(CourseInfo course)
        {
            _computerScience3CourseList.Add(course);
            SortAll();
        }

        //AddIntoElectronicEngineering3CourseList
        public void AddIntoElectronicEngineering3CourseList(CourseInfo course)
        {
            _electronicEngineering3CourseList.Add(course);
            SortAll();
        }

        //RemoveCourseFromTabDictionary
        public void RemoveCourseFromTabDictionary(int index)
        {
            _courseTabDictionary.Remove(_selectedCourseList[index].Number);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _selectedCourseList.Add(selectingCourse);
            SortAll();
        }
    }
}
