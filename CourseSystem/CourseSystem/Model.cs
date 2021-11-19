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
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        const string WEB_COMPUTER_SCIENCE_3 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        const string WEB_ELECTRONIC_ENGINEERING_3_A = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
        const string WEB_COMPUTER_SCIENCE_1 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2676";
        const string WEB_COMPUTER_SCIENCE_2 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2550";
        const string WEB_COMPUTER_SCIENCE_4 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2314";
        const string WEB_COMPUTER_SCIENCE_5 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2701";
        private List<string> _courseWebList;
        private List<CourseInfo> _selectedCourseList;
        private List<CourseInfo> _notEnabledCourseList;
        private Dictionary<string, int> _selectedCourseTabDictionary;
        private Dictionary<string, int> _notEnabledCourseTabDictionary;
        const string STRUCTURE = "//body/table";
        private List<List<CourseInfo>> _courseListCollection;
        public Model()
        {
            _modelChanged += SortAll;
            _courseWebList = new List<string>();
            _courseWebList.Add(WEB_COMPUTER_SCIENCE_3);
            _courseWebList.Add(WEB_ELECTRONIC_ENGINEERING_3_A);
            //_courseWebList.Add(WEB_COMPUTER_SCIENCE_1);
            //_courseWebList.Add(WEB_COMPUTER_SCIENCE_2);
            //_courseWebList.Add(WEB_COMPUTER_SCIENCE_4);
            //_courseWebList.Add(WEB_COMPUTER_SCIENCE_5);
            _courseListCollection = new List<List<CourseInfo>>();
            _courseListCollection.Add(new List<CourseInfo>());
            _courseListCollection.Add(new List<CourseInfo>());
            _selectedCourseList = new List<CourseInfo>();
            _notEnabledCourseList = new List<CourseInfo>();
            SortAll();
            _selectedCourseTabDictionary = new Dictionary<string, int>();
            _notEnabledCourseTabDictionary = new Dictionary<string, int>();
        }

        //爬蟲網頁資料
        private List<CourseInfo> GetCourseInfo(string web)
        {
            if (web == "")
            {
                return new List<CourseInfo>();
            }

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
                        nodeTableDatas[(int)CourseInfoHeaderText.Number].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Name].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Stage].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Credit].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Hour].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.CourseType].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Teacher].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.ClassTime0].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime1].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime2].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime3].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime4].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime5].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime6].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Classroom].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.NumberOfStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.NumberOfDropStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.TeachingAssistant].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Language].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Outline].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Note].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.AttachStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Experiment].InnerText.Trim());
        }

        //UpdateCourseListInfo
        public void UpdateCourseListInfo(int departmentIndex)
        {
            List<CourseInfo> newCourseList = GetCourseInfo(_courseWebList[departmentIndex]);
            int numberOfNewCourseList = 0;
            for (int courseIndex = 0; courseIndex < _courseListCollection[departmentIndex].Count(); courseIndex++)
            {
                numberOfNewCourseList = newCourseList.Count();
                for (int index = 0; index < numberOfNewCourseList; index++)
                {
                    if (_courseListCollection[departmentIndex][courseIndex].Number == newCourseList[numberOfNewCourseList - index - 1].Number)
                    {
                        newCourseList.RemoveAt(numberOfNewCourseList - index - 1);
                    }
                }
            }
            newCourseList = DeleteDuplicateCourse(newCourseList, departmentIndex, _selectedCourseTabDictionary);
            newCourseList = DeleteDuplicateCourse(newCourseList, departmentIndex, _notEnabledCourseTabDictionary);
            _courseListCollection[departmentIndex] = _courseListCollection[departmentIndex].Union(newCourseList).ToList<CourseInfo>();
        }

        //DeleteDuplicateCourse
        private List<CourseInfo> DeleteDuplicateCourse(List<CourseInfo> newCourseList, int departmentIndex, Dictionary<string, int> tabDictionary)
        {
            int numberOfNewCourseList = newCourseList.Count();
            for (int index = 0; index < numberOfNewCourseList; index++)
            {
                if (tabDictionary.ContainsKey(GetNumber(newCourseList[numberOfNewCourseList - index - 1])))
                {
                    if (tabDictionary[GetNumber(newCourseList[numberOfNewCourseList - index - 1])] == departmentIndex)
                    {
                        newCourseList.RemoveAt(numberOfNewCourseList - index - 1);
                    }
                }
            }
            return newCourseList;
        }

        //Get
        public List<List<CourseInfo>> GetCourseListCollection
        {
            get
            {
                return _courseListCollection;
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

        //Get
        public List<CourseInfo> GetNotEnabledCourseList
        {
            get
            {
                return _notEnabledCourseList;
            }
        }

        //get
        public List<CourseInfo> GetCourseList(int index)
        {
            return _courseListCollection[index];
        }

        //remove
        public void RemoveFromCourseListAndAddInToSelectedTab(int index, int rowIndex)
        {
            _selectedCourseTabDictionary.Add(_courseListCollection[index][rowIndex].Number, index);
            _courseListCollection[index].RemoveAt(rowIndex);
        }

        //remove
        public void RemoveCourseFromCourseList(int classIndex, int index)
        {
            _courseListCollection[classIndex].RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _courseListCollection[_selectedCourseTabDictionary[_selectedCourseList[index].Number]].Add(_selectedCourseList[index]);
            _selectedCourseTabDictionary.Remove(_selectedCourseList[index].Number);
            _selectedCourseList.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromSelectedList(int index)
        {
            _selectedCourseList.RemoveAt(index);
        }

        //GetNumber
        private string GetNumber(CourseInfo courseInfo)
        {
            return courseInfo.Number;
        }

        //sort
        private void SortAll()
        {
            _selectedCourseList.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
            int index = 0;
            foreach (List<CourseInfo> courseList in _courseListCollection)
            {
                _courseListCollection[index].Sort(delegate (CourseInfo x, CourseInfo y)
                {
                    return x.Number.CompareTo(GetNumber(y));
                });
                index++;
            }
        }

        //GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex)
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            int currentIndex = 0;
            int classIndex = 0;
            foreach (List<CourseInfo> courseList in _courseListCollection)
            {
                if (selectedIndex < currentIndex + courseList.Count)
                {
                    return _courseListCollection[classIndex][selectedIndex - currentIndex];
                }
                currentIndex += courseList.Count;
                classIndex++;
            }
            if (selectedIndex < currentIndex + _selectedCourseList.Count)
            {
                return _selectedCourseList[selectedIndex - currentIndex];
            }
            return _notEnabledCourseList[selectedIndex - currentIndex - _selectedCourseList.Count];
        }

        //GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex)
        public Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            int currentIndex = 0;
            int classIndex = 0;
            foreach (List<CourseInfo> courseList in _courseListCollection)
            {
                if (selectedIndex < currentIndex + courseList.Count)
                {
                    return Tuple.Create(classIndex, classIndex, selectedIndex - currentIndex);
                }
                currentIndex += courseList.Count;
                classIndex++;
            }
            if (selectedIndex < currentIndex + _selectedCourseList.Count)
            {
                return Tuple.Create((int)Department.SelectedList, _selectedCourseTabDictionary[_selectedCourseList[selectedIndex - currentIndex].Number], selectedIndex - currentIndex);
            }
            return Tuple.Create((int)Department.NotEnabledList, _notEnabledCourseTabDictionary[_notEnabledCourseList[selectedIndex - currentIndex - _selectedCourseList.Count].Number], selectedIndex - currentIndex - _selectedCourseList.Count);
        }

        //AddIntoSelectedCourseList
        public void AddIntoSelectedCourseListAndCourseTab(CourseInfo course, int department)
        {
            _selectedCourseList.Add(course);
            _selectedCourseTabDictionary.Add(course.Number, department);
        }

        //AddIntoSelectedCourseList
        public void AddIntoNotEnabledCourseListAndCourseTab(CourseInfo course, int department)
        {
            _notEnabledCourseList.Add(course);
            _notEnabledCourseTabDictionary.Add(course.Number, department);
        }

        //AddInto\CourseList
        public void AddIntoCourseList(CourseInfo course, int selectedIndex)
        {
            _courseListCollection[selectedIndex].Add(course);
        }

        //RemoveCourseFromSelectedTabDictionary
        public void RemoveCourseFromSelectedTabDictionary(int index)
        {
            _selectedCourseTabDictionary.Remove(_selectedCourseList[index].Number);
        }

        //RemoveCourseFromNotEnabledTabDictionary
        public void RemoveCourseFromNotEnabledTabDictionary(int index)
        {
            _notEnabledCourseTabDictionary.Remove(_notEnabledCourseList[index].Number);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _selectedCourseList.Add(selectingCourse);
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            NotifyObserver();
        }

        //NotifyObservers
        public void NotifyObserver()
        {
            if (_modelChanged != null)
            {
                _modelChanged();
            }
        }

        //GetClassListForSelectedIndex
        public List<CourseInfo> GetClassListForSelectedIndex(int selectedIndex)
        {
            List<CourseInfo> courseList = new List<CourseInfo>();
            foreach (CourseInfo course in _courseListCollection[selectedIndex])
            {
                courseList.Add(course);
            }
            for (int index = 0; index < _selectedCourseList.Count(); index++)
            {
                if (_selectedCourseTabDictionary[GetNumber(_selectedCourseList[index])] == selectedIndex * 2)
                {
                    courseList.Add(_selectedCourseList[index]);
                }
            }
            for (int index = 0; index < _notEnabledCourseList.Count(); index++)
            {
                if (_notEnabledCourseTabDictionary[GetNumber(_notEnabledCourseList[index])] == selectedIndex * 2 || _notEnabledCourseTabDictionary[GetNumber(_notEnabledCourseList[index])] == selectedIndex * 2 + 1)
                {
                    courseList.Add(_notEnabledCourseList[index]);
                }
            }
            return courseList;
        }

        //AddClassNameList
        public void AddClassNameList(string className)
        {
            switch (className)
            {
                case "資工一":
                    _courseWebList.Add(WEB_COMPUTER_SCIENCE_1);
                    break;
                case "資工二":
                    _courseWebList.Add(WEB_COMPUTER_SCIENCE_2);
                    break;
                case "資工四":
                    _courseWebList.Add(WEB_COMPUTER_SCIENCE_4);
                    break;
                case "資工所":
                    _courseWebList.Add(WEB_COMPUTER_SCIENCE_5);
                    break;
                default:
                    _courseWebList.Add("");
                    break;
            }
            _courseListCollection.Add(new List<CourseInfo>());
            ReloadAllForm();
        }
    }
}
