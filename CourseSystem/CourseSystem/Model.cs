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
        const string WEB_COMPUTER_SCIENCE_5 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2701";
        const string WEB_COMPUTER_SCIENCE_4 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2314";
        const string WEB_COMPUTER_SCIENCE_2 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2550";
        const string WEB_COMPUTER_SCIENCE_1 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2676";
        private List<CourseInfo> _selectedCourseList;
        private List<CourseInfo> _notEnabledCourseList;
        private Dictionary<string, int> _selectedCourseTabDictionary;
        private Dictionary<string, int> _notEnabledCourseTabDictionary;
        const string STRUCTURE = "//body/table";
        private List<List<CourseInfo>> _courseListCollection;
        public Model()
        {
            _modelChanged += SortAll;
            _courseListCollection = new List<List<CourseInfo>>();
            _courseListCollection.Add(GetCourseInfo(WEB_COMPUTER_SCIENCE_3));
            _courseListCollection.Add(GetCourseInfo(WEB_ELECTRONIC_ENGINEERING_3_A));
            _courseListCollection.Add(new List<CourseInfo>());
            _courseListCollection.Add(new List<CourseInfo>());
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
                return Tuple.Create((int)ListName.SelectedList, _selectedCourseTabDictionary[_selectedCourseList[selectedIndex - currentIndex].Number], selectedIndex - currentIndex);
            }
            return Tuple.Create((int)ListName.NotEnabledList, _notEnabledCourseTabDictionary[_selectedCourseList[selectedIndex - currentIndex - _selectedCourseList.Count].Number], selectedIndex - currentIndex - _selectedCourseList.Count);
        }

        //AddIntoSelectedCourseList
        public void AddIntoSelectedCourseListAndCourseTab(CourseInfo course, int department)
        {
            _selectedCourseList.Add(course);
            _selectedCourseTabDictionary.Add(course.Number, department);
        }

        //AddInto\CourseList
        public void AddIntoCourseList(CourseInfo course, int selectedIndex)
        {
            _courseListCollection[selectedIndex].Add(course);
        }

        //RemoveCourseFromTabDictionary
        public void RemoveCourseFromTabDictionary(int index)
        {
            _selectedCourseTabDictionary.Remove(_selectedCourseList[index].Number);
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
    }
}
